# WinForm ile Semantic Kernel Entegrasyonu

![Projenin Ekran Görüntüsü](./Images/.png)

Bu proje, **WinForm** tabanlı bir uygulamaya **Semantic Kernel** entegrasyonunu içermektedir. Model olarak **Llama 3.1 8B** kullanılmış ve **Ollama** aracılığıyla lokal olarak çalıştırılmıştır.

## 🚀 Proje Hakkında

Bu projede, **Semantic Kernel** ile doğal dil işleme (NLP) yetenekleri eklenmiş bir **WinForm uygulaması** geliştirilmiştir. Kullanıcı, uygulama arayüzü üzerinden model ile etkileşime geçerek çeşitli metin tabanlı işlemleri gerçekleştirebilir.

## 📌 Kullanılan Teknolojiler

- **C# (WinForms)**: Uygulamanın GUI (Grafiksel Kullanıcı Arayüzü) için kullanılmıştır.
- **Semantic Kernel**: AI tabanlı yanıt üretme ve metin işleme için entegre edilmiştir.
- **Llama 3.1 8B**: Model olarak kullanılmıştır.
- **Ollama**: Llama modelini lokal olarak çalıştırmak için kullanılmıştır.

## 🔧 Kurulum

1. **Ollama'yı yükleyin**:
   Ollama'yı sisteminize yüklemek için aşağıdaki adımları takip edin:

   - [Ollama Resmi Web Sitesi](https://ollama.com) üzerinden uygun sürümü indirin ve yükleyin.

2. **Llama 3.1 8B modelini indirin**:

   ```sh
   ollama pull llama3:8b
   ```

3. **Proje bağımlılıklarını yükleyin**:

   - `SemanticKernel` ve `System.Windows.Forms` NuGet paketlerini yükleyin:
     ```sh
     dotnet add package Microsoft.SemanticKernel
     ```

4. **Ollama'yı çalıştırın**:

   ```sh
   ollama run llama3:8b
   ```

5. **WinForm uygulamasını başlatın**:
   - Projeyi Visual Studio veya Rider ile açın ve çalıştırın.

## 📌 Özellikler

- **Yerel AI modeli ile entegrasyon**: İnternet bağlantısı olmadan çalışabilme.
- **Semantic Kernel kullanarak metin işleme**: Kullanıcı girdilerine akıllı yanıtlar üretme.
- **WinForm tabanlı kullanıcı dostu arayüz**.

## 📌 Kullanım

- **Metin giriş kutusuna** sorularınızı yazın.
- **"Gönder"** düğmesine basarak AI modelinden yanıt alın.
- Yanıtlar **dinamik olarak ekrana** yansıtılır.

---

📩 **İletişim:** [E-posta adresinizi ekleyebilirsiniz]
