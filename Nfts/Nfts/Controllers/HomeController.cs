using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Nfts;
using Newtonsoft.Json;
using Nfts.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Nfts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<string> _contas;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _contas = PopularContas();
        }

        private List<string> PopularContas()
        {
            return new List<string>()
            {
                "r52rm.wam",
                "v13bm.wam",
                "zl1bo.wam",
                "otabo.wam",
                "rparo.wam",
                "ttbro.wam",
                "d1cro.wam",
                "e1ibo.wam",
                "j1hbo.wam",
                "j1hro.wam"
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Nfts()
        {
            RetornoNfts nfts = new RetornoNfts();
            nfts.InfosGerais = new List<NftsIntermediario>();

            foreach(var conta in _contas)
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync("https://atomic.wax.io/atomicassets/v1/assets?owner=" + conta);

                var jsonContent = JsonConvert.DeserializeObject<RetornoNfts>(await result.Content.ReadAsStringAsync());

                foreach(var infoGeral in jsonContent.InfosGerais){
                    infoGeral.Conta = conta;
                }

                nfts.InfosGerais.AddRange(jsonContent.InfosGerais);

            }

            return View(nfts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
