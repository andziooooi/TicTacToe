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
            SuspendLayout();
            // 
            // btnplay
            // 
            btnplay.Font = new Font("Segoe UI", 30F);
            btnplay.Location = new Point(12, 340);
            btnplay.Name = "btnplay";
            btnplay.Size = new Size(372, 98);
            btnplay.TabIndex = 0;
            btnplay.Text = "Play with guest";
            btnplay.UseVisualStyleBackColor = true;
            btnplay.Click += playwithguest;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 50F);
            Username.Location = new Point(109, 198);
            Username.Margin = new Padding(100, 3, 100, 100);
            Username.MaxLength = 10;
            Username.MinimumSize = new Size(0, 100);
            Username.Name = "Username";
            Username.Size = new Size(582, 100);
            Username.TabIndex = 1;
            Username.Text = "Gracz";
            Username.TextAlign = HorizontalAlignment.Center;
            Username.Click += Username_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 50F);
            label1.Location = new Point(109, 48);
            label1.Name = "label1";
            label1.Size = new Size(582, 91);
            label1.TabIndex = 2;
            label1.Text = "Enter your name!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(416, 340);
            button1.Name = "button1";
            button1.Size = new Size(372, 98);
            button1.TabIndex = 3;
            button1.Text = "Play with computer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playwithcomputer;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Username);
            Controls.Add(btnplay);
            Name = "StartPage";
            Text = "StartPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnplay;
        private TextBox Username;
        private Label label1;
        private Button button1;
    }
}