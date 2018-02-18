using Xamarin.Forms;

namespace CarouselPageDemo
{
	public partial class MainPage : CarouselPage
	{
		public MainPage()
		{
			InitializeComponent();

            Children.Add(new FirstPage());
            Children.Add(new SecondPage());
            Children.Add(new ThirdPage());
            Children.Add(new fourthPage());
        }
    }
}