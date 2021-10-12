using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Net;

namespace PR10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_trx : ContentPage
    {
        public Page_trx()
        {
            InitializeComponent();
        }
        static double x;
        private void Button_Clicked1(object sender, EventArgs e)
        {
            string t;
            t = trx_kol.Text;
            double g = x * Convert.ToDouble(t);
            trxAll.Text = Convert.ToString(g);
        }
        static string Url = "https://api.cryptowat.ch/markets/okex/trxusdt/price";
        public static async void Trxpr(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = (await httpClient.GetAsync(Url)).EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            x = double.Parse(await Get());
        }
        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };
        // настройка клиента
        private static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }
        public static async Task<string> Get()
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return result;
        }
    }
}