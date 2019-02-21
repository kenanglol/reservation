# reservation
Hotel Reservation Application  (Otel Rezervasyon Uygulaması)

----English-----

Please change "data"  file's path as yourself when you download all of it.
Steps of changing data file path

1)open windowsformapp5.2.sln file
2)open program.cs and enter the test class
3)change "computer_path" string your computer's "data" file path
4)compile the program
note= use double slash when give the path  for get rid of shortcuts

-----Türkçe-----

Lütfen indirdiğiniz "data" dosyasının dosya yolunu değiştirmeyi unutmayınız.
Uygulama Adımları

1)WindowsFormApp5.2.sln dosyasını visual studio'da açınız.
2)Program.cs dosyasına tıklayın ve test sınıfını açınız
3)"computer_path" adlı değişkene "data" dosyasının kendi bilgisayarınızdaki dosya yolunu yazın
4)Programı derleyin

Not:Dosya yolunda çift taksim kullanın





Projenin Yapımında Kullanılan Araçlar

1)Visual Studio Community 2017  Version.15.8.7
2)C# Version 7.3


Problemin Kısa Tanımı

Ağaç,heap,liste,hashtable gibi veri yapıları kullanılarak bir otel rezervasyon sistemi tasarlanması.Apriori algoritması kullanılarak tavsiye sistemi eklenmesi.Sistem kullanıcılarının yorumları göz önünde bulundurularak duygu analizi yapılması.


Sınıfların ve Metodların Açıklanması

Class düzey;
-Her ile ait turistik yer ağacının elemanlarının bulunduğu düzeylerle birlikte listelenmesinde kullanılır.Ağacın her nodunu ve düzeyini bir obje olarak tutar.

Class nod;
-Ağacın düğümleri için kullanılan sınıf.

Class BinTree;
-Ağaç veri yapısının gerçekleştirilmesi

Add()
-Ağaca eleman ekler.

In_order()
-Ağacı inorder şeklinde gezer.

post_order()
-Ağacı postorder şeklinde gezer.

pre_order()
-Ağacı preorder şeklinde gezer.

Seviye_dondur()
-Verilen elemanın düzeyini döndürür.

Balance()
-Ağacı dengeler.

Uygula()
-Ağacın içindeki tüm otelleri bir listeye atar.

Search()
-Ağaçta turistik yer nesnesi kullanarak arama yapma.

Remove()
-Ağaçtan eleman silme.

Class AbstractHeap;
-Heap’in implemente edilmesi için gerekli.

EnlargeIfNeed()
-Gerektiğinde heapin listesinin kapasitesini arttırır.

Peek()
-En baştaki elemanı döndürür.

Pop()
-İlk elemanı heap içinden çıkarır.

Add()
-Eleman Ekler.

HeapifyDown()
-Ekleme ve silme yapıldıktan sonra ağacın dengelenmesi sırasında üst elemanı 	 aşağı indirir.

HeapifyUp()
-Ekleme ve silme yapıldıktan sonra ağacın dengelenmesi sırasında alt elemanı 	 üste çıkarır.

Class Lineer_Hash;
-Lineer Hashing mantığı ile çalışan hash classı

Hash_func()
-Yerleştirilecek değeri alarak ona uygun indexi döndürür.

Add()
-Eleman ekler.

Remove()
Eleman siler.

Class sehir;
-Içinde yer ağacı ve şehir ismi bulunduran class.




Class oda;
-Yatak sayısı, .dat dosyası için kullanılan oda_id ,rezervasyon listesi,fiyat ,doluluk ve oda tipi tutan class.

Class Üye;
-İçinde kullanıcı bilgileri tutan class.

Tavsiye()
-Kullanıcı tavsiyesi için olan otelleri liste olarak döndüren metod.

Class Admin;
-Admin karı ve admin metodlarını barındıran class.

Yer_ekle()
-Verilen şehire yer ekleyen metod.

Otel_ekle()
-Verilen turistik yere otel ekleyen metod.

Otel_arama()
-Şehirlerin bulunduğu lineer hash içinde aramaa yaparak otel döndüren fonk.

Class ozellik;
Özellik ismini ve özelliğe sahip otelleri tutan class.

Class otel;

Rezervasyon()
-Admin karı olarak rezerve edilen odanın %10 eklenir, rezervasyon dosyaya 		 yazılır ve doluluk kontrol edilir.

Oda_ekle()
-Otele oda ekleyen ve bunu dosyaya yazan metod.

Oda_sil()
-Otelden oda silen ve odayı rezerve eden kişilerden de rezervasyonu silen 		 metod.

Oda_ara()
-Otelde oda id ile oda arayan fonksiyon.

Class turistik;
-İçinde otel listesini ve adını tutan class.
Otel_arama()
-İsmi ile otel arayan metod.


Class frekans;
Oteli ve frekansını tutan class.

Class kombinasyon;
Otel kombinasyonlarını ve bu kombinasyonların frekanslarını tutan class.

Class apriori;

GetCombinations()
-Otel listesi alıp bu otellerin kombinasyonlarını döndüren metod.

Çalıştır()
-Apriori algoritmasını çalıştıran metod.

Frekle()
-Otel kombinasyonlarını ayıklayıp en yüksek frekanslıyı döndüren metod.

List_oluştur()
-Frekansları sınır değeri geçen otelleri ayıklayan metod.

Class test;
-Dosyalardan verileri okuyup sistemi gerçekleyen class.

GÖRÜŞ ANALİZİ

Kullanıcının girdiği paragraftaki tüm kelimeleri tek tek kontrol et. Pozitif kelime yüzdesi negatif kelime yüzdesinden fazla ise bu yorum olumlu bir yorumdur. Zaman ekleriyle beraber olumsuzluk eki içeren kelimeler  negatif içerikli kelimelerdir. Kelime zaman eki içeriyor fakat olumsuzluk eki bulundurmuyorsa bu kelime pozitif kelimelere eklenir.  (Örn.  Kullana-ma-dım => zaman+ olumsuzluk eki içerir , Kullan-dım  sadece zaman içerir.)

ÖNERİ SİSTEMİ-1

Birliktelik analizinde birçok algoritma itemlerin frekanslarından yararlanır. Apriori ve FP Growth Algoritması bunlardan biridir.Apriori Algoritmasını kısacak ifade edelim. 
Tavsiye verilecek olan üyeyi al. Tüm üyelerin gittiği otelleri, frekansları ile tut. Frekansı destek değeri geçemeyen otelleri tavsiye havuzundan çıkar. Elimizde kalan otellerin kombinasyonlarını al. Bu kombinasyonları kullanıcıların gittiği oteller içinde ara.Buna göre tekrar bir frekans oluştur. Oluşturduğun frekanslar için bir sınır değeri belirle,sınır değer genellikle (destek değer/birlikteliği aranan elemanın frekansı) şeklindedir.Frekansı ve kombinasyondaki eleman sayısını çarp. Değeri en yüksek olan oteller kombinasyonunu tavsiye olarak öner.




DOSYALAR VE AMAÇLARI

1)Apriorisource.dat
Kullanıcı ismi ve oda idlerini rezervasyonları kaydetmek içi tutan 	dosya.

2)Gorus.dat
Kullanıcı görüşlerini kaydeden dosya

3)Kullanıcılar.dat
Kullanıcı bilgilerini tutan dosya.

4)negative.dat
Negatif kelimeler için ilkel veri tabanı.

5)odalar.dat
Odaları primary key olarak oda_id ile tutan ve oda bilgilerini barındıran dosya.

6)Oteller.dat
Otel bilgilerini ve otellere ait odaların id değerlerini tutan dosya.

7)Ozellikler.dat
Otel özelliklerini ve hangi otelin belirtilen özelliğe sahip olduğunu tutan dosya.

8)possitive.dat
Pozitif kelimelerin tutulduğu veri dosyası.

9)Press.dat
Olumluluk eklerini yüklem kontrolü sağlayan eklerin bulunduğu veri dosyası.

10)Press2.dat
Olumsuzluk eklerini yüklem kontrolü sağlayan eklerin bulunduğu veri dosyası.

11)Sehirler.dat
Şehirleri ve şehirlere ait turistik yerleri tutan dosya.

12)Yerler.dat
Turistik yerleri ve onlara ait otelleri tutan dosya.
