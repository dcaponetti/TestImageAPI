using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using TestImageAPI.Service;


namespace TestImageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageTestAPI : ControllerBase
    {
       

        private readonly ILogger<ImageTestAPI> _logger;
        private readonly IProduceImageService _produceImageService;

        public ImageTestAPI(ILogger<ImageTestAPI> logger,IProduceImageService ser)
        {
            _logger = logger;
            _produceImageService = ser;
        }

        [HttpGet(Name = "GetImage")]
        public async Task<ActionResult<List<string>>> Get()
        {
            List<string> strs = new List<string>();
            int t = 20;
           
                for (int i = 0; i < t; i++)
                {

                 strs.Add(_produceImageService.ProduceImageTest().Result);
                    
                }
                return strs;
             
            
        }
    }
}
