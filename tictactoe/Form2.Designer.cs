namespace tictactoe
{
    partial class Form2
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
            btnnewgame = new Button();
            button2 = new Button();
            labelwinner = new Label();
            SuspendLayout();
            // 
            // btnnewgame
            // 
            btnnewgame.BackColor = Color.FromArgb(200, 200, 220);
            btnnewgame.FlatAppearance.BorderColor = Color.FromArgb(186, 85, 211);
            btnnewgame.FlatAppearance.BorderSize = 2;
            btnnewgame.FlatStyle = FlatStyle.Flat;
            btnnewgame.Font = new Font("Segoe UI", 30F);
            btnnewgame.Location = new Point(135, 88);
            btnnewgame.Name = "btnnewgame";
            btnnewgame.Size = new Size(233, 94);
            btnnewgame.TabIndex = 0;
            btnnewgame.Text = "New game";
            btnnewgame.UseVisualStyleBackColor = true;
            btnnewgame.Click += btnnewgame_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(200, 200, 220);
            button2.FlatAppearance.BorderColor = Color.FromArgb(186, 85, 211);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(114, 188);
            button2.Name = "button2";
            button2.Size = new Size(282, 29);
            button2.TabIndex = 1;
            button2.Text = "Back to the lobby";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnlobby;
            // 
            // labelwinner
            // 
            labelwinner.Font = new Font("Segoe UI", 20F);
            labelwinner.Location = new Point(135, 9);
            labelwinner.Name = "labelwinner";
            labelwinner.Size = new Size(233, 76);
            labelwinner.TabIndex = 3;
            labelwinner.Text = "Winner: ";
            labelwinner.TextAlign = ContentAlignment.TopCenter;
            labelwinner.Paint += labelwinner_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 247);
            Controls.Add(labelwinner);
            Controls.Add(button2);
            Controls.Add(btnnewgame);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnnewgame;
        private Button button2;
        private Label labelwinner;
    }
}