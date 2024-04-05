using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

        private void OnCounterClicked(object sender, EventArgs e)
        {

            for (int row = 0; row < 15; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Items.Add($"{row}:{col}");
                }
            }
        }

        private void Ten_Clicked(object sender, EventArgs e)
        {
            list.ItemsLayout = new GridItemsLayout(10, ItemsLayoutOrientation.Vertical);
        }

        private void Five_Clicked(object sender, EventArgs e)
        {
            list.ItemsLayout = new GridItemsLayout(5, ItemsLayoutOrientation.Vertical);
        }
    }

}
