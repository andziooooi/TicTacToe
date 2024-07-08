namespace tictactoe
{
    public class MyButton : Button
    {
        public bool chosen;
        public MyButton() {
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.FromArgb(200, 200, 220);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.FromArgb(186, 85, 211);
        }         
    }
}
