using Microsoft.AspNetCore.Mvc;
using UrlShortener.Extensions;
using UrlShortener.Models;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrlsController : Controller
    {
        private readonly ILogger<UrlsController> _logger;

        public UrlsController(ILogger<UrlsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUrl")]
        public Urls GetUrls()
        {
            return new Urls
            {
                Id = 1,   
                OriginalUrl = "hola",
                ShortendUrl = "Hola desde un metodo"
            };
        }

        [HttpPost(Name = "ShortenUrl")]
        public Urls Shorten(string OriginalUrl)
        {
            
            string shortenurl = UrlsExtensions.ShortendUrl(OriginalUrl);

            return new Urls { 
                OriginalUrl = OriginalUrl,
                ShortendUrl = shortenurl,
                Id = 1
            };
        }

        
    }


}
