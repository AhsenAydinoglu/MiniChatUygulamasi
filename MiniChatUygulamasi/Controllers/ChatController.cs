using Microsoft.AspNetCore.Mvc;
using MiniChatUygulamasi.Models;

namespace MiniChatUygulamasi.Controllers
{
    public class ChatController : Controller
    {
        private readonly SohbetServisi _sohbetServisi;

        public ChatController(SohbetServisi sohbetServisi)
        {
           _sohbetServisi=sohbetServisi;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MesajlarPartial()
        {
            return PartialView("_Mesajlar");
        }

        [HttpPost]
        public IActionResult Gonder(Mesaj mesaj)
        {
            if (ModelState.IsValid)
            {
                _sohbetServisi.MesajEkle(mesaj.Gonderen, mesaj.Icerik);
                return Ok(); //durum kodu 200 (200'lü kodlar başarılı durumları temsil eder.)
            }
            return BadRequest(); //durum kodu 400 (400'lü kodlar hatayı temsil eder.)
        }
    }
}
