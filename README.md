# Mikroservis Mimarilerinde Gateway: Ocelot ve Consul Entegrasyonu

Bu proje, mikroservis mimarilerinde bir API Gateway olarak **Ocelot** kullanılarak **Consul** ile servis keşfi entegrasyonunu uygulamaktadır. .NET Core 9 kullanılarak geliştirilmiş olan bu örnek proje, gateway mimarisi için modern ve güçlü bir çözüm sunar.

---

## Projenin Amacı

Bu projenin temel amacı, mikroservis mimarisinde:

1. **API Gateway** olarak Ocelot'un kullanılmasını göstermek,
2. **Consul** ile dinamik servis keşfi entegrasyonunu gerçekleştirmek,
3. Mikroservis tabanlı bir sistemde yük dengeleme, hata toleransı ve servis yönlendirme süreçlerini basitleştirmektir.

---

## Proje Özellikleri

- **Mikroservis Keşfi**: Consul, mikroservislerin dinamik olarak keşfedilmesini sağlar.
- **Ocelot ile Yönlendirme**: API Gateway olarak Ocelot, gelen talepleri ilgili mikroservislere yönlendirir.
- **Konfigürasyon Yönetimi**: Ocelot'un JSON tabanlı yapılandırma dosyası ve Consul'den dinamik yapılandırma desteği.
- **Load Balancing (Yük Dengeleme)**: Ocelot ve Consul entegrasyonu sayesinde, hizmete erişimde yük dengeleme uygulanır.
- **Basit ve Hızlı Kurulum**: Docker Compose ile Consul ve mikroservislerin hızlı bir şekilde ayağa kaldırılması.

---

## Gereksinimler

- .NET Core 9 SDK
- Docker ve Docker Compose
- Visual Studio veya Visual Studio Code

---

## Proje Yapısı

```plaintext
|-- src
    |-- ApiGateways
    |   |-- Web
    |       |--WebApiGateway
    |--BuildingBlocks
    |   |-- Services.Core
    |-- Services
        |-- IdentityService
        |   |-- Identity.Api       
|-- docker-compose.yml

```

---

## Kurulum ve Çalıştırma

1. **Depoyu Klonlayın**

```bash
git clone https://github.com/KerimDemirer/OcelotConsulWithDockerCompose.git

```

2. **Docker Servislerini Çalıştırın**

```bash
docker-compose up --build
```

3. **Gateway ve Mikroservisleri Test Edin**
   - Consul arayüzüne erişmek için: `http://localhost:8500`
   - Ocelot Gateway'e erişim: `http://localhost:5000`

---

## Önemli Dosyalar

### `ocelot.json`

Ocelot konfigürasyon dosyası, servis rotalarını ve yük dengeleme kurallarını tanımlar.

### `docker-compose.yml`

Docker Compose dosyası, Consul ve mikroservislerin yapılandırmasını içerir.

---

## Kullanılan Teknolojiler

- **.NET Core 9**: Projenin ana geliştirme platformu.
- **Ocelot**: API Gateway çözümü.
- **Consul**: Servis keşfi ve yapılandırma yönetimi.
- **Docker**: Mikroservislerin ve Consul'ün konteynerize edilmesi.

---

## Katkıda Bulunma

Katkıda bulunmak için lütfen bir `pull request` gönderin veya [issue açın](https://github.com/kullaniciadi/mikroservis-ocelot-consul/issues).

---

## Lisans

Bu proje MIT lisansı altında sunulmaktadır. Daha fazla bilgi için `LICENSE` dosyasını inceleyebilirsiniz.

---

Bu proje ile mikroservislerinizi modern bir mimari ile nasıl entegre edebileceğinizi öğrenebilir ve kendi projelerinize uyarlayabilirsiniz. Sorularınız için [tartışma sayfasını](https://github.com/kullaniciadi/mikroservis-ocelot-consul/discussions) kullanabilirsiniz.



