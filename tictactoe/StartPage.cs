using System.Drawing.Drawing2D;

namespace tictactoe
{
    public partial class StartPage : Form
    {

        public bool guest = false;
        public string username = "";
        public bool play = false;
        public StartPage()
        {
            InitializeComponent();
            Paint += new PaintEventHandler(BackgroundGradient);
            Resize += new EventHandler(StartPage_resize); 

            CenterControls();
        }

        private void playwithcomputer(object sender, EventArgs e)
        {
            username = Username.Text;
            guest = false;
            play = true;
            Close();
        }

        private void Username_Click(object sender, EventArgs e)
        {
            Username.Font = new Font("Segoe UI", 48F, FontStyle.Regular);
            Username.Clear();
        }

        private void playwithguest(object sender, EventArgs e)
        {
            username = Username.Text;
            play = true;
            guest = true;
            Close();
        }
        private void StartPage_resize(object sender, EventArgs e)
        {
            CenterControls(); 
        }

        private void CenterControls()
        {

            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 2;

            //label1
            //label1_Paint();
            label1.Left = centerX - label1.Width / 2;
            label1.Top = centerY - 200;

            //username input
            //Username.Left = centerX - Username.Width / 2;
            //Username.Top = centerY - 80;
            //panel1 
            panel1.Left = centerX - panel1.Width / 2;
            panel1.Top = centerY - 80;

            //btnplaywith comp
            button1.Left = centerX - button1.Width - 10;
            button1.Top = panel1.Bottom + 20;

            //btnplay with guest
            btnplay.Left = centerX + 10;
            btnplay.Top = panel1.Bottom + 20;
        }
        private void BackgroundGradient(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(rectangle, Color.FromArgb(173, 216, 230), Color.FromArgb(135, 206, 250), 65f);
            graphics.FillRectangle(b, rectangle);
        }
        public void label1_Paint(object sender, PaintEventArgs e)
        {         
            ControlPaint.DrawBorder(e.Graphics, label1.ClientRectangle, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid);
        }
        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid);
        }

    }
}
