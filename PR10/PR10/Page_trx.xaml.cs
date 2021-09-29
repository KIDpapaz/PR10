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
        private object priceTrx;

        public void TrxUser()
        {
            UserTrx = Convert.ToDouble(trx_kol);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double priceTrx = 0.08606;
            trxAll.Text = (UserTrx * priceTrx).ToString();
        }
        private void zarab()
        {
            double NewPriceTrx = 0;
            double i = UserTrx;
            if(i > 0)
            {
                //провести расчет и сравнить результаты юсера и в будущем
            }
            else
            {
                //вывести что у вас на счету нечего нету
            }
        }
    }
}