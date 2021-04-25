using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Nfts;
using Newtonsoft.Json;
using Nfts.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Nfts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<string> _contasJohann;
        private List<string> _contasFelipe;
        private List<string> _contasAlexandre;
        private List<string> _contasPico;
        private List<string> _contasLucas;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _contasJohann = PopularContasJohann();
            _contasFelipe = PopularContasFelipe();
            _contasAlexandre = PopularContasAlexandre();
            _contasPico = PopularContasPico();
            _contasLucas = PopularContasLucas();

        }

        private List<string> PopularContasFelipe()
        {
            return new List<string>()
            {
                "d32rk.wam",
                "kf1bk.wam",
                "ptvbk.wam",
                "h1dri.wam",
                "5r.rk.wam",
                "bfarg.wam",
                "f2rrk.wam",
                "yurbm.wam",
                "qlrbo.wam",
                "qprro.wam",
                "ladro.wam"
            };
        }

        private List<string> PopularContasJohann()
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
                "j1hro.wam",
                "c1rrq.wam",
                "5o3bw.wam",
                "5g5bw.wam"

            };
        }

        private List<string> PopularContasAlexandre()
        {
            return new List<string>()
            {
                "jgvbo.wam",
                "lh5ro.wam",
                "4hbbo.wam",
                "ilbro.wam",
                "sxhro.wam",
                "y5iro.wam",
                "aljro.wam",
                "jlobo.wam",
                "mtoro.wam",
                "ntpbo.wam",
                "lhubq.wam"
            };
        }

        private List<string> PopularContasLucas()
        {
            return new List<string>()
            {
                "wtdbo.wam",
                "jwsrm.wam",
                "z1obo.wam",
                "31mbo.wam",
                "zndro.wam",
                "q13rq.wam",
                "mdlbu.wam",
                "iplru.wam",
                "zlmru.wam",
                "m5obu.wam",
                "4ppbu.wam"
            };
        }

        private List<string> PopularContasPico()
        {
            return new List<string>()
            {
                "1odbo.wam",
                "jlaro.wam",
                "fhjrq.wam",
                "dtbrq.wam",
                "p.ubq.wam",
                "wdbro.wam",
                "2svbq.wam",
                "hxkbq.wam",
                "l.wbu.wam",
                ".kwru.wam"
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

        public async Task<IActionResult> JohannNfts()
        {
            RetornoNfts nfts = new RetornoNfts();
            nfts.InfosGerais = new List<NftsIntermediario>();

            foreach (var conta in _contasJohann)
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync("https://atomic.wax.io/atomicassets/v1/assets?owner=" + conta);

                var jsonContent = JsonConvert.DeserializeObject<RetornoNfts>(await result.Content.ReadAsStringAsync());

                Account account = new Account() { account_name = conta };

                var resultContent = JsonConvert.SerializeObject(account);
                var contentString = new StringContent(resultContent, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new
                MediaTypeHeaderValue("application/json");

                var getAccount = await client.PostAsync("https://chain.wax.io/v1/chain/get_account", contentString);
                var accountContent = JsonConvert.DeserializeObject<AccountContent>(await getAccount.Content.ReadAsStringAsync());

                foreach (var infoGeral in jsonContent.InfosGerais)
                {
                    infoGeral.Conta = conta;
                    infoGeral.DonoConta = "Johann";
                    infoGeral.AccountContent = accountContent;
                }
                nfts.InfosGerais.AddRange(jsonContent.InfosGerais);
            }
            return View(nfts);
        }
        public async Task<IActionResult> Nfts()
        {
            RetornoNfts nfts = new RetornoNfts();
            nfts.InfosGerais = new List<NftsIntermediario>();

            foreach (var conta in _contasJohann)
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync("https://atomic.wax.io/atomicassets/v1/assets?owner=" + conta);

                var jsonContent = JsonConvert.DeserializeObject<RetornoNfts>(await result.Content.ReadAsStringAsync());

                Account account = new Account() { account_name = conta };

                var resultContent = JsonConvert.SerializeObject(account);
                var contentString = new StringContent(resultContent, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new
                MediaTypeHeaderValue("application/json");

                var getAccount = await client.PostAsync("https://chain.wax.io/v1/chain/get_account", contentString);
                var accountContent = JsonConvert.DeserializeObject<AccountContent>(await getAccount.Content.ReadAsStringAsync());

                foreach (var infoGeral in jsonContent.InfosGerais)
                {
                    infoGeral.Conta = conta;
                    infoGeral.DonoConta = "Johann";
                    infoGeral.AccountContent = accountContent;
                }
                nfts.InfosGerais.AddRange(jsonContent.InfosGerais);
            }
            foreach (var conta in _contasFelipe)
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync("https://atomic.wax.io/atomicassets/v1/assets?owner=" + conta);

                var jsonContent = JsonConvert.DeserializeObject<RetornoNfts>(await result.Content.ReadAsStringAsync());

                Account account = new Account() { account_name = conta };

                var resultContent = JsonConvert.SerializeObject(account);
                var contentString = new StringContent(resultContent, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new
                MediaTypeHeaderValue("application/json");

                var getAccount = await client.PostAsync("https://chain.wax.io/v1/chain/get_account", contentString);
                var accountContent = JsonConvert.DeserializeObject<AccountContent>(await getAccount.Content.ReadAsStringAsync());

                foreach (var infoGeral in jsonContent.InfosGerais)
                {
                    infoGeral.Conta = conta;
                    infoGeral.DonoConta = "Felipe";
                    infoGeral.AccountContent = accountContent;
                }
                nfts.InfosGerais.AddRange(jsonContent.InfosGerais);

            }
            foreach (var conta in _contasAlexandre)
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync("https://atomic.wax.io/atomicassets/v1/assets?owner=" + conta);

                var jsonContent = JsonConvert.DeserializeObject<RetornoNfts>(await result.Content.ReadAsStringAsync());

                Account account = new Account() { account_name = conta };

                var resultContent = JsonConvert.SerializeObject(account);
                var contentString = new StringContent(resultContent, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new
                MediaTypeHeaderValue("application/json");

                var getAccount = await client.PostAsync("https://chain.wax.io/v1/chain/get_account", contentString);
                var accountContent = JsonConvert.DeserializeObject<AccountContent>(await getAccount.Content.ReadAsStringAsync());

                foreach (var infoGeral in jsonContent.InfosGerais)
                {
                    infoGeral.Conta = conta;
                    infoGeral.DonoConta = "Alexandre";
                    infoGeral.AccountContent = accountContent;
                }
                nfts.InfosGerais.AddRange(jsonContent.InfosGerais);
            }
            foreach (var conta in _contasPico)
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync("https://atomic.wax.io/atomicassets/v1/assets?owner=" + conta);

                var jsonContent = JsonConvert.DeserializeObject<RetornoNfts>(await result.Content.ReadAsStringAsync());

                Account account = new Account() { account_name = conta };

                var resultContent = JsonConvert.SerializeObject(account);
                var contentString = new StringContent(resultContent, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new
                MediaTypeHeaderValue("application/json");

                var getAccount = await client.PostAsync("https://chain.wax.io/v1/chain/get_account", contentString);
                var accountContent = JsonConvert.DeserializeObject<AccountContent>(await getAccount.Content.ReadAsStringAsync());

                foreach (var infoGeral in jsonContent.InfosGerais)
                {
                    infoGeral.Conta = conta;
                    infoGeral.DonoConta = "Pico";
                    infoGeral.AccountContent = accountContent;
                }
                nfts.InfosGerais.AddRange(jsonContent.InfosGerais);
            }
            foreach (var conta in _contasLucas)
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync("https://atomic.wax.io/atomicassets/v1/assets?owner=" + conta);

                var jsonContent = JsonConvert.DeserializeObject<RetornoNfts>(await result.Content.ReadAsStringAsync());

                Account account = new Account() { account_name = conta };

                var resultContent = JsonConvert.SerializeObject(account);
                var contentString = new StringContent(resultContent, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new
                MediaTypeHeaderValue("application/json");

                var getAccount = await client.PostAsync("https://chain.wax.io/v1/chain/get_account", contentString);
                var accountContent = JsonConvert.DeserializeObject<AccountContent>(await getAccount.Content.ReadAsStringAsync());

                foreach (var infoGeral in jsonContent.InfosGerais)
                {
                    infoGeral.Conta = conta;
                    infoGeral.DonoConta = "Lucas";
                    infoGeral.AccountContent = accountContent;
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
