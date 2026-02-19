using MaterialSkin;
using MaterialSkin.Controls;


namespace Brgy.App
{
    public partial class Entry : MaterialForm
    {
        public Entry()
        {
            InitializeComponent();

            // Set up the Material Theme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Official Blue Color Scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900, Primary.Blue500,
                Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnPublic_Click(object sender, EventArgs e)
        {
            PublicDashboard dash = new PublicDashboard(false); // Add 'false' here
            dash.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Redirect to the Login Form, NOT the Register Form
            LogForm login = new LogForm();
            login.Show();
            this.Hide();
        }
    }

}