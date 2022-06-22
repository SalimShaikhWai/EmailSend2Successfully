using EmailSend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmailSend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMailService _mailService;
        public HomeController(ILogger<HomeController> logger, IMailService mailService)
        {
            _logger = logger;
            _mailService = mailService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var request = new MailRequest();
;           request.ToEmail = "salimshaikh8605694835@gmail.com";
            request.Subject = "MyFirst emial";
            request.Body = "comipan";



            await _mailService.SendEmailAsync(request);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}