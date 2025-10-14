namespace Modulo
{
    public partial class MainPage : ContentPage
    {
        private bool _isDetailsVisible = false;
        private Border _selectedBorder = null;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDayTapped(object sender, EventArgs e)
        {
            if(sender is Border tappedBorder)
            {
                if(_selectedBorder == tappedBorder)
                {
                    tappedBorder.Background = Colors.White;
                    _selectedBorder = null;
                    _isDetailsVisible = false;
                    detailsSection.IsVisible = false;
                    return;
                }

                if(_selectedBorder != null)
                {
                    _selectedBorder.Background = Colors.White;
                }

                tappedBorder.Background = Colors.LightGray;
                _selectedBorder = tappedBorder;

                _isDetailsVisible = true;
                detailsSection.IsVisible = true;
            }
        }

        private void OnCollapseAllTapped(object sender, EventArgs e)
        {
            // Reset selected border
            if (_selectedBorder != null)
            {
                _selectedBorder.Background = Colors.White;
                _selectedBorder = null;
            }

            // Hide details section
            _isDetailsVisible = false;
            detailsSection.IsVisible = false;
        }

        private async void OnModuleTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CoursePage());
        }


    }
}
