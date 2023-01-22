using System.ComponentModel.DataAnnotations;

namespace MiniChatUygulamasi.Models
{
    public class Mesaj
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Gonderen { get; set; }
        [Required, MaxLength(400)]
        public string Icerik { get; set; }
        public DateTime Zaman { get; set; } = DateTime.Now;
    }
}
