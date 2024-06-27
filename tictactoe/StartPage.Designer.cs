namespace tictactoe
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnplay = new Button();
            Username = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnplay
            // 
            btnplay.BackColor = Color.FromArgb(200, 200, 220);
            btnplay.FlatAppearance.BorderColor = Color.FromArgb(186, 85, 211);
            btnplay.FlatAppearance.BorderSize = 2;
            btnplay.FlatStyle = FlatStyle.Flat;
            btnplay.Font = new Font("Segoe UI", 29F);
            btnplay.Location = new Point(12, 340);
            btnplay.Name = "btnplay";
            btnplay.Size = new Size(372, 98);
            btnplay.TabIndex = 0;
            btnplay.Text = "Play with guest";
            btnplay.UseVisualStyleBackColor = false;
            btnplay.Click += playwithguest;
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Segoe UI", 48F, FontStyle.Italic);
            Username.Location = new Point(34, 15);
            Username.Margin = new Padding(100, 3, 100, 100);
            Username.MaxLength = 10;
            Username.MinimumSize = new Size(0, 90);
            Username.Name = "Username";
            Username.Size = new Size(582, 90);
            Username.TabIndex = 1;
            Username.Text = "Player";
            Username.TextAlign = HorizontalAlignment.Center;
            Username.Click += Username_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(117, 72);
            label1.Name = "label1";
            label1.Size = new Size(582, 100);
            label1.TabIndex = 2;
            label1.Text = "Enter your name!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Paint += label1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(200, 200, 220);
            button1.FlatAppearance.BorderColor = Color.FromArgb(186, 85, 211);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 29F);
            button1.Location = new Point(416, 340);
            button1.Name = "button1";
            button1.Size = new Size(372, 98);
            button1.TabIndex = 3;
            button1.Text = "Play with computer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += playwithcomputer;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Username);
            panel1.Location = new Point(53, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 121);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnplay);
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StartPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnplay;
        private TextBox Username;
        private Label label1;
        private Button button1;
        private Panel panel1;
    }
}