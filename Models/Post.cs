using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Project.Models
{
    public class Post
    {
        public int PostID { get; set; }
        public Foto Foto { get; set; }
        //Post Başlığı
        public string Title { get; set; }
        //Post içeriği
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        //Okuma miktarı
        public int ReadingQuantity { get; set; }
        //Paylaşılma Sayısı
        public int SharedQuantity { get; set; }
        //Okuma Süresi
        public int RedingDuration { get; set; }
        //Puan ortalaması
        public decimal? AvarageScore { get; set; }
        //kaç kişi oy verdi
        public int PeopleVote { get; set; }

        [ForeignKey("Category")]
        public Category CategoryName { get; set; }
        

    }
}
