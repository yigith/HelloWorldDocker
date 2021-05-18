# Kolay Başlangıç
Projenizi oluşturduktan sonra uygulamanızı docker üzerinde çalıştırmak için öncelikle bilgisayarınıza Docker Desktop programını indirip kurunuz.

Projenize sağ tuşla tıklayıp Add > Docker Support.. seçeneği ile projenize Docker file ve Docker ignore dosyalarını ekleyiniz. Target OS olarak Linux'u seçiniz.

Sonrasında Docker ile start diyerek uygulamanızı derleyip sizin için oluşturulmuş image ile oluşturulan container içinde çalıştırabilirsiniz.

Console uygulamanızın çıktısını Output penceresinde görebilirsiniz. Ya da kendi açtığınız bir konsol penceresinde görebilmek için uygulamayı attach etmeniz gerekmektedir.

# Attach
Win + R (Çalıştır) > cmd
docker ps (çalışan container'ları listele)
docker attach e5c (container id'nin ilk 3 harfi)

# Diğer Docker Komutları
docker images (çalışan image'lar)
docker ps (çalışan container'lar)
docker ps -a (tüm container'lar)
docker ps --all (tüm container'lar)

# CLI (Command-line Interface) aracılığıyla oluşturulan image ve container'ları silme
Win + R (Çalıştır) > cmd

docker ps -a : tüm container'ları listele ve silmek istediğiniz container'in id'sinin ilk 3 harfini öğren. Status UP ise çalışıyor anlamına gelir.

docker stop 8b5: diyerek çalışan container'ı durdurabilirsiniz.

docker rm 8b5: diyerek container'ı kaldır (çalışıyorsa --force ekiyle silmey zorlayabilirsiniz.)

docker images: diyerek varolan image'lar listelenir ve silinmek istenen image'ın id'si öğrenilir

docker rmi 8fa: id'sinin ilk 3 harfi belirtilen image'ı kaldır

# Dockerfile ile Image build etme
Öncelikle solution klasörüne gidilir (cmd üzerinde)

docker build -f HelloWorldDocker\Dockerfile -t helloworldimage .

docker run --name helloworldcontainer helloworldimage (helloworldimage kullanarak belirtilen adda container oluştur ve çalıştır create/start/attach)

## YA DA build'den sonra
docker create --name helloworldcontainer2 helloworldimage

docker start helloworldcontainer2

docker attach helloworldcontainer2
