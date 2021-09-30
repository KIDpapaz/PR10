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
        static double UserTrx;

        public void TrxUser()
        {
            UserTrx = Convert.ToDouble(trx_kol);
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            string kkk = trx_kol.Text;
            double priceTrx = 0.08254;
            double g = Convert.ToDouble(kkk) * priceTrx;
            g = Math.Round(g, 2);
            trxAll.Text = Convert.ToString(g);
        }
    }
}