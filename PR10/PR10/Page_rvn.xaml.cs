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
    public partial class Page_rvn : ContentPage
    {
        double currency;
        public Page_rvn()
        {
            InitializeComponent();
        }
        private void cur()//берём информацию с сайта
        {
            currency = 50;
        }
        private void Button1()
        {
            cur();
            double rvn = 50; //замена строчки на её ввод, пока это 50 rvn'ов
            double RvnAll = rvn * currency;
        }
    }
}