using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PR10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_trx(object sender, EventArgs e)
        {
            Page_trx ptrx = new Page_trx();
            this.Content = ptrx.Content;
        }

        private void Button_Clicked_rvn(object sender, EventArgs e)
        {

        }
        private void Button_Clicked_sol(object sender, EventArgs e)
        {

        }
    }
}
