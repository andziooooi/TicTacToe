using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tictactoe
{
    public partial class StartPage : Form
    {
        public bool guest = false;
        public string username = "";
        public StartPage()
        {
            InitializeComponent();
            this.Resize += new EventHandler(StartPage_resize); // Dodanie obsługi zdarzenia Resize
            CenterControls();
        }


        private void playwithcomputer(object sender, EventArgs e)
        {
            Close();
            username = Username.Text;
        }

        private void Username_Click(object sender, EventArgs e)
        {
            Username.Clear();
        }

        private void playwithguest(object sender, EventArgs e)
        {
            username = Username.Text;
            guest = true;
            Close();
        }
        private void StartPage_resize(object sender, EventArgs e)
        {
            CenterControls(); // Wywołanie funkcji centrującej przycisk podczas zmiany rozmiaru formularza
        }

        private void CenterControls()
        {
            
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            //label1
            label1.Left = centerX - label1.Width / 2;
            label1.Top = centerY - 200; 

            //username input
            Username.Left = centerX - Username.Width / 2;
            Username.Top = centerY - 80;

            //btnplaywith comp
            button1.Left = centerX - button1.Width - 10; 
            button1.Top = Username.Bottom + 20; 

            //btnplay with guest
            btnplay.Left = centerX + 10; 
            btnplay.Top = Username.Bottom + 20; 
        }
    }
}
