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
            PublicDashboard dashboard = new PublicDashboard(true);
            login.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // 128 is the transparency (0 = invisible, 255 = solid)
            // 0, 0, 0 is the Color (Black). Change to 255, 255, 255 for White.
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(60, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(brush, this.panel1.ClientRectangle);
            }
        }
    }

}