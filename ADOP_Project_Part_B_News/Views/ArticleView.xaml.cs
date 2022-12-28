using System.Web;

namespace ADOP_Project_Part_B_News.Views
{
    public partial class ArticleView : ContentPage
    {

        public ArticleView()
        {
            InitializeComponent();
         }
        public ArticleView(string Url)
        {
            InitializeComponent();
            BindingContext = new UrlWebViewSource
            {
                Url = HttpUtility.UrlDecode(Url)
            };
        }
    }
}
