using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarkiSex
{
    class Cards
    {
        public string cardName { get; set; }
        public string cardUrl { get; set; }
        public string description { get; set; }
        public ObservableCollection<Cards> getCards()
        {
            ObservableCollection<Cards> cards = new ObservableCollection<Cards>()
            {
                new Cards{
                    cardUrl="Assets/Images/1 (9).jpg",
                    cardName="Papa(The Hieropant)",
                    description ="      Kehanet Anlamı: Esaret. Evlilik birleşimi. Toplumsal geleneklere aşırı tutsaklık. Sosyal açıdan beğenilme. Bağışlama ve iyilik. İlham. Sual soranın yardım dilediği kişi.\n\n       Ters Anlamı: Topluma bağlanmama. Ahenk. Aşırı şevkat. Zayıflık. Yeni fikirlere açıklık. Kolay aldanma. Saflık."
                },
                new Cards{
                    cardUrl="Assets/Images/1 (4).jpg",
                    cardName="Münzevi(The Hermit)",
                    description= "      Kehanet Anlamı: Basiret, hainlik. Hüner. Tarot açtıranın kendisini hedefe götürecek biriyle tanışması. Dolandırıcılık.\n\n      Ters Anlamı: Aptalca alışkanlıklar edinme. Gizleme, toyluk, korku. Yersiz tedbir. Yaşlanmaktan korkma.",
                },
                new Cards{
                    cardUrl="Assets/Images/1 (8).jpg",
                    cardName="Aşıklar(The Lovers)",
                    description= "      Kehanet Anlamı: Aşk, cazibe. Evlenilme konusunda seçim. Sorumluluk üstlenme. Başarılan imtihanlar. Güzellik.\n\n        Ters Anlamı: Başarısızlık. Evliliğin bitme tehlikesi. Yanlış eş seçimi. Aile müdahalesi. Yanlış planlar.",
                },
                new Cards{
                    cardUrl="Assets/Images/1 (1).jpg",
                    cardName="Kader Çarkı(Wheel of Fortune)",
                    description= "      Kehanet Anlamı: Başarı, büyüme. İyi şans ve talih. Saadet. Şansın beklenmedik şekilde iyiye dönmesi.\n\n        Ters Anlamı: Çoğalma, bolluk, fazlalık. Kötünün bile değişeceği bir nokta gelecektir.",
                },
                new Cards{
                    cardUrl="Assets/Images/1 (5).jpg",
                    cardName="Savaş Arabası(The Chariot)",
                    description= "      Kehanet Anlamı: Artistik işlerde başarı. Fethetme, yardım, tedbir. Savaş, zefer. Parasal konularda başarı. Rakiplerin alt edilmesi. Eş seçimi. İntikam, sıkıntı. Rahat bir yolculuk.\n\n        Ters Anlamı: Evliliğin nihayetlenmesi. Gürültü, boğuşma. Ahlaksızca zafer ve başarı. İntikam, yenilgi.",
                },
                new Cards{
                    cardUrl="Assets/Images/1 (3).jpg",
                    cardName="Kuvvet(Strength)",
                    description= "      Kehanet Anlamı: Kuvvet, kudret, enerji. Manevi güçler, maddi güçlerden ön plana geçiyor. Hareket, cesaret. Aşk nefreti. Yüksek idealler, dünyevi ihtirasları yeniyor. Alicenaplık.\n\n      Ters Anlamı: Madde maneviyata üstün gelecek. Kuvvetin kötüye kullanılması. Zayıflık, uyuşamamazlık. Fikir ayrılığı ve uyumsuzluk.",
                },
                new Cards{
                    cardUrl="Assets/Images/1 (2).jpg",
                    cardName="Adalet(Justice)",
                    description= "      Kehanet Anlamı: Eşitlik, doğruluk, dürüstlük. İcra eden. Para ile ilgili işlerde yasal yoldan olumlu gelişmeler. Hedefini bilen doğru eğitim. Bilgide gereksiz bölümlerin tasfiyesi.\n\n        Ters Anlamı: Adaletsizlik, eşitsizlik, yasal zorluklar. Aşırı hiddet. Kanun, tutuculuk, taraf tutma. Bu kart şayet 12 nolu Asılmış Adam(The Hanged Man)'dan sonra gelmişse, katı kurallardan ziyade affedici bir tutum takınılması gerektiğini gösterir.",
                },
                new Cards{
                    cardUrl="Assets/Images/1 (6).jpg",
                    cardName="Asılmış Adam(The Hanged Man)",
                    description= "      Kehanet Anlamı: Hikmet, idrak, tedbirlilik. Hayatın değişik bir yöne yönelmesi. Maneviyat uğruna feragat. Hayatta duraklama. Asılı kalan kararlar. Kurban, ilhamlar, kehanet.\n\n       Ters Anlamı: Fiziksel konularda tükenme. Bencillik, kibir ve gurur. Yanlış kehanetler. Manevi etkilerde direnç.",
                },

                
            };
            return cards;
        }
    }
}
