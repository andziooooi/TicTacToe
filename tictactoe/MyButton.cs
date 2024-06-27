namespace tictactoe
{
    public class MyButton : Button
    {
        public bool chosen;
        public MyButton() {
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.FromArgb(200, 200, 220);
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Color.FromArgb(186, 85, 211);

        }   
        
    }
}
