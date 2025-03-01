using Codeblaze.SemanticKernel.Connectors.Ollama;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;


namespace KernelBotApp
{
    public partial class Form1 : Form
    {
        private readonly Kernel kernel;
        private bool chatStatus = true;
        public Form1()
        {
            InitializeComponent();

            var builder = Kernel.CreateBuilder()
                    .AddOllamaChatCompletion("llama3.1:8b", "http://localhost:11434");

            builder.Services.AddScoped<HttpClient>();
            kernel = builder.Build();
            flowLayoutChatPanel.WrapContents = false;
        }



        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            await SendKernelAI();
        }
        private async void label1_Click(object sender, EventArgs e)
        {
            await SendKernelAI();
        }

        public async Task SendKernelAI()
        {
            try
            {
                if (chatStatus)
                {
                    chatStatus = false;
                    pictureBox1.Visible = false;
                    label1.Visible = false;
                    pictureBox2.Visible = true;

                    string userText = richTextBox.Text.ToString();
                    if (string.IsNullOrWhiteSpace(userText))
                    {
                        MessageBox.Show("Lütfen soru sorun?");
                        return;
                    }
                    AddMessageToChatPanel(userText, true);
                    richTextBox.Clear();
                    var result = await kernel.InvokePromptAsync(userText);
                    AddMessageToChatPanel(result.ToString(), false);

                    pictureBox2.Visible = false;
                    pictureBox1.Visible = true;
                    label1.Visible = true;
                    chatStatus = true;
                }
                else
                {
                    MessageBox.Show("Lütfen yapay zekanýn cevabýný bekleyin.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kernel AI zaman aþýmýna uðradý!");
            }
        }

        public void AddMessageToChatPanel(string message, bool isUSer)
        {
            Label label = new Label();
            
            if (isUSer)
            {
                label.Text = $"Sen : {message}";
                label.ForeColor = Color.White;
                label.Font = new Font(label.Font.FontFamily, 14, FontStyle.Regular);
                label.Margin = new Padding(0, 8, 0, 8); // (Sol, Üst, Sað, Alt) olarak Margin ekle
                label.AutoSize = true;  // Yazý uzunluðuna göre etiket boyutlanacak
                label.MaximumSize = new Size(flowLayoutChatPanel.ClientSize.Width - 50, 0); // Maksimum geniþlik 50px boþluk býrakacak
                label.TextAlign = ContentAlignment.MiddleLeft;  // Metni sola hizala
                flowLayoutChatPanel.Controls.Add(label);
            }
            else
            {
                label.Text = $"Kernel: {message}";
                label.ForeColor = Color.ForestGreen;
                label.Font = new Font(label.Font.FontFamily, 14, FontStyle.Regular);
                label.Margin = new Padding(0, 8, 0, 8); // (Sol, Üst, Sað, Alt) olarak Margin ekle
                label.AutoSize = true;  // Yazý uzunluðuna göre etiket boyutlanacak
                label.MaximumSize = new Size(flowLayoutChatPanel.ClientSize.Width - 50, 0); // Maksimum geniþlik 50px boþluk býrakacak
                label.TextAlign = ContentAlignment.MiddleLeft;  // Metni sola hizala
                flowLayoutChatPanel.Controls.Add(label);
            }


        }
    }
}
