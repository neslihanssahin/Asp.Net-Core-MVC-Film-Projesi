using System.Collections.Generic;
using System.Linq;
using MovieApp.Models;

namespace MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            { 
                new Movie(){
                    Id=1,
                    Name="Harry Potter",
                    Description="<p>'Harry Potter ve Felsefe Taşı' filmi, Harry'nin büyücü olduğunu öğrendiği ve Hogwarts Cadılık ve Büyücülük Okulu'na katıldığı ilk yılını anlatır. Harry, arkadaşları Ron ve Hermione ile birlikte Felsefe Taşı'nı ele geçirmeye çalışan Karanlık Lord Voldemort'u durdurmaya çalışır. Film, büyülü dünyanın kapılarını açarken dostluk, cesaret ve keşfetme temalarını işler.</p>",
                    ShortDescription="Harry Potter",
                    ImageUrl="harry.webp",
                    CategoryId=1},
                new Movie(){
                    Id=2,
                    Name="Shazam",
                    Description="<p>'Shazam!' 2019 yapımı bir süper kahraman filmidir ve DC Comics'in karakteri Shazam'dan esinlenmiştir. 14 yaşındaki Billy Batson, bir sihirli kelimeyi söyleyerek yetişkin bir süper kahramana dönüşme gücüne sahip olur. Genç Billy, bu yeni gücünü keşfederken, bir yandan da süper kötü Adam Sivana ile savaşmak zorundadır. Film, mizah dolu anları, gençlik enerjisi ve kalp ısıtan bir aile hikayesini bir araya getiriyor.</p>",
                    ShortDescription="Shazam",
                    ImageUrl="shazam.jpg",
                    CategoryId=1},
                new Movie(){
                    Id=3,
                    Name="Amazing Grace",
                    Description="<p>'Shazam!' 2019 yapımı bir süper kahraman filmidir ve DC Comics'in karakteri Shazam'dan esinlenmiştir. 14 yaşındaki Billy Batson, bir sihirli kelimeyi söyleyerek yetişkin bir süper kahramana dönüşme gücüne sahip olur. Genç Billy, bu yeni gücünü keşfederken, bir yandan da süper kötü Adam Sivana ile savaşmak zorundadır. Film, mizah dolu anları, gençlik enerjisi ve kalp ısıtan bir aile hikayesini bir araya getiriyor.</p>",
                    ShortDescription="Shazam",
                    ImageUrl="amazing.jpg",
                    CategoryId=1},
                new Movie(){
                    Id=4,
                    Name="High Life",
                 Description="<p>Amazing Grace filmi, 2006 yılında vizyona giren ve İngiliz siyasetçi William Wilberforce’un hayatını konu alan bir biyografik dramadır. Film, Wilberforce’un 18. yüzyılda Britanya İmparatorluğu'nda köle ticaretini sona erdirme mücadelesini anlatır. Film, William'ın inancı, azmi ve çevresindeki destekçileriyle birlikte verdiği zorlu mücadeleye odaklanır. Film ismini ünlü ilahi Amazing Grace'ten alır ve ilahinin yazarı John Newton da filmde Wilberforce’un akıl hocası olarak yer alır.</p>",
                    ShortDescription="High Life",
                    ImageUrl="highlife.jpg",
                    CategoryId=2},
                new Movie(){
                    Id=5,
                    Name="Billboard",
                    Description="<p>'Billboard,' 2017 yapımı bir dram komedi filmidir. Eski bir müzisyen olan Aidan, hayatını yeniden düzenlemek için kendi billboardunu kiralamaya karar verir. Bu süreçte, kendine ve geçmişine dair derin bir yolculuğa çıkar. Aidan, hem kendi hayatını hem de diğerlerinin hayatlarını etkileyen olaylarla yüzleşirken, geçmişiyle barış yapma şansı bulur. Film, duygusal derinlik ve mizahi unsurlar barındırıyor.</p>",
                    ShortDescription="Billboard",
                    ImageUrl="billboard.jpg",
                    CategoryId=3},
                new Movie(){
                    Id=6,
                    Name="Storm Boy",
                    Description="<p>'Storm Boy,' 2019 yapımı bir dram filmidir. Bu film, bir çocuğun ve onun deniz kuşu dostunun unutulmaz hikayesini anlatıyor. Güney Avustralya'nın etkileyici doğal manzaralarında geçen film, genç bir çocuğun büyüme sürecini, dostluklarını ve kaybı ele alıyor. Zamanla, Storm Boy, hayatının dönüm noktalarında cesaret ve dayanıklılık bulur. Film, doğa sevgisi ve ailenin önemi üzerine derin bir anlatım sunuyor.</p>",
                    ShortDescription="Storm Boy",
                    ImageUrl="storm.jpg",
                    CategoryId=3},new Movie(){
                    Id=7,
                    Name="1917",
                    Description="<p>I. Dünya Savaşı'nda geçen bu film, iki genç İngiliz askerin çok tehlikeli bir görevi yerine getirmek için zamana karşı yarışmasını konu alır. Siper savaşının ortasında, birliği kurtarmak için yüzlerce askere bir mesaj ulaştırmaları gerekmektedir. Tek bir çekim gibi görünecek şekilde çekilen film, izleyiciyi savaşın tam ortasına götüren sinematografisiyle büyük beğeni toplamıştır.</p>",
                    ShortDescription="1917",
                    ImageUrl="1917.webp",
                    CategoryId=4},
                    new Movie(){
                    Id=8,
                    Name="Greyhound",
                    Description="<p>II. Dünya Savaşı sırasında, Atlantik Okyanusu'nda geçen bu filmde, Amerikan destroyer kaptanı Ernest Krause (Tom Hanks), müttefik konvoyunu korumak için Alman denizaltılarına karşı ölümcül bir savaş verir. Krause, denizdeki zorlu koşullar ve sürekli bir tehdit altında, düşman saldırılarından kaçmaya çalışırken kaptan olarak cesaretini kanıtlamak zorundadır. Film, savaşın deniz cephesine odaklanmasıyla dikkat çekiyor.</p>",
                    ShortDescription="Greyhound",
                    ImageUrl="greyhound.webp",
                    CategoryId=4},
                    new Movie(){
                    Id=9,
                    Name="Free Guy",
                    Description="<p>'Free Guy', bir video oyununda yaşayan sıradan bir banka memuru olan Guy’ın, aslında yapay bir karakter olduğunu fark etmesiyle başlar. Guy, kendi hayatını kontrol etmeye karar vererek oyunun kahramanı haline gelir. Eğlenceli ve aksiyon dolu macerasında, hem oyun dünyasını hem de gerçek dünyayı kurtarmaya çalışır. Ryan Reynolds'ın enerjik performansı ve esprili diyaloglarıyla komedi ve aksiyonu başarıyla bir araya getiren bir film.</p>",
                    ShortDescription="Free Guy",
                    ImageUrl="freeguy.jpg",
                    CategoryId=5},
                

            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }

    }
}