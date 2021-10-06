using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace PR10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_trx : ContentPage
    {
        public Page_trx()
        {
            InitializeComponent();
        }

        private void coinmarketcap()
        {
            //System.Net.WebClient wc = new System.Net.WebClient();
            //String Response = wc.DownloadString("https://coinmarketcap.com/currencies/tron/");
            //String Rate = System.Text.RegularExpressions.Regex.Match(Response,).Groups[1].Value;
            //trxAll.Text = Rate;
        } 

        private void Button_Clicked1(object sender, EventArgs e)
        {
            coinmarketcap();
            p2p();
        }
        private void p2p()
        {
            int p2p = 20; //сколько у него (пользователя) денег
            int i = p2p;
            if (i > 0 )
            {
                //расчет колво актива
            }
            else
            {
                //вывод что у вас нету монет
            }
        }
    }
}