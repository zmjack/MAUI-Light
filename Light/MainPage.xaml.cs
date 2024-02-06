namespace Light
{
    public partial class MainPage : ContentPage
    {
        private bool _light = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLightSwitch(object sender, EventArgs e)
        {
            try
            {
                if (_light)
                {
                    await Flashlight.Default.TurnOffAsync();
                    _light = false;
                    LightSwitch.Source = "turnoff.jpg";
                }
                else
                {
                    await Flashlight.Default.TurnOnAsync();
                    _light = true;
                    LightSwitch.Source = "turnon.jpg";
                }
            }
            catch { }
        }
    }

}
