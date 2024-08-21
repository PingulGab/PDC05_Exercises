namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {

        public string Firstname { get; set; }
        public Color ColorRed {  get; set; }

        public MainPage()
        {
            InitializeComponent();

            Firstname = "Hello, MAUI!";
            ColorRed = Colors.Red;

            

            this.BindingContext = this;
        }

        private void OnChangedLabelName (object sender, EventArgs e)
        {
            this.Resources["StaticUsername"] = "Peter Butter";
        }

        private void DynamicOnChangedLabelName(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "Peter Butter";
        }

        private void OnChangeBackgroundColorSkyBlue(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.SkyBlue;
        }

        private void OnChangeBackgroundColorGray(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Gray;
        }

        private void OnChangeBackgroundColorGreen(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Green;
        }

        private void OnChangeBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.Red;
        }

    }

}
