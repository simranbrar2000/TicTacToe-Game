namespace TicTacToe
{
    public partial class Form1 : Form
    {


        Boolean checker;
        int plusone;

        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }

        private bool CheckForDraw()
        {
            
            return btnTic1.Text != "" && btnTic2.Text != "" && btnTic3.Text != "" &&
                   btnTic4.Text != "" && btnTic5.Text != "" && btnTic6.Text != "" &&
                   btnTic7.Text != "" && btnTic8.Text != "" && btnTic9.Text != "";
        }

        void score()
        {
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.PowderBlue;
                btnTic2.BackColor = System.Drawing.Color.PowderBlue;
                btnTic3.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label2.Text));
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Pink;
                btnTic4.BackColor = System.Drawing.Color.Pink;
                btnTic7.BackColor = System.Drawing.Color.Pink;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label2.Text));
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = System.Drawing.Color.Crimson;
                btnTic5.BackColor = System.Drawing.Color.Crimson;
                btnTic9.BackColor = System.Drawing.Color.Crimson;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label2.Text));
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.CadetBlue;
                btnTic5.BackColor = System.Drawing.Color.CadetBlue;
                btnTic7.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label2.Text));
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = System.Drawing.Color.SlateBlue;
                btnTic5.BackColor = System.Drawing.Color.SlateBlue;
                btnTic8.BackColor = System.Drawing.Color.SlateBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label2.Text));
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = System.Drawing.Color.Violet;
                btnTic6.BackColor = System.Drawing.Color.Violet;
                btnTic9.BackColor = System.Drawing.Color.Violet;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label2.Text));
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic5.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic6.BackColor = System.Drawing.Color.DarkSlateBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label2.Text));
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic8.BackColor = System.Drawing.Color.DarkSlateBlue;
                btnTic9.BackColor = System.Drawing.Color.DarkSlateBlue;

                MessageBox.Show("The winner is Player X", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label2.Text));
                label2.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            //===========================================================================================================

            if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.AliceBlue;
                btnTic2.BackColor = System.Drawing.Color.AliceBlue;
                btnTic3.BackColor = System.Drawing.Color.AliceBlue;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label3.Text));
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.LemonChiffon;
                btnTic4.BackColor = System.Drawing.Color.LemonChiffon;
                btnTic7.BackColor = System.Drawing.Color.LemonChiffon;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label3.Text));
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = System.Drawing.Color.BlueViolet;
                btnTic5.BackColor = System.Drawing.Color.BlueViolet;
                btnTic9.BackColor = System.Drawing.Color.BlueViolet;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label3.Text));
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = System.Drawing.Color.NavajoWhite;
                btnTic5.BackColor = System.Drawing.Color.NavajoWhite;
                btnTic7.BackColor = System.Drawing.Color.NavajoWhite;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label3.Text));
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = Color.SandyBrown;
                btnTic5.BackColor = Color.SandyBrown;
                btnTic8.BackColor = Color.SandyBrown;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label3.Text));
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = Color.SeaGreen;
                btnTic6.BackColor = Color.SeaGreen;
                btnTic9.BackColor = Color.SeaGreen;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label3.Text));
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = Color.PeachPuff;
                btnTic5.BackColor = Color.PeachPuff;
                btnTic6.BackColor = Color.PeachPuff;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label3.Text));
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = Color.BurlyWood;
                btnTic8.BackColor = Color.BurlyWood;
                btnTic9.BackColor = Color.BurlyWood;

                MessageBox.Show("The winner is Player O", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(StripNonNumeric(label3.Text));
                label3.Text = Convert.ToString(plusone + 1);
                Enable_False();


                if (CheckForDraw())
                {
                    MessageBox.Show("The game is a draw", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Enable_False();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            label2.Text = "0";
            label3.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string StripNonNumeric(string input)
        {
            return new string(input.Where(char.IsDigit).ToArray());
        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            btnTic1.Enabled = false;
            score();
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            btnTic2.Enabled = false;
            score();
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            btnTic3.Enabled = false;
            score();
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            btnTic4.Enabled = false;
            score();
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            btnTic5.Enabled = false;
            score();
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            btnTic6.Enabled = false;
            score();
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            btnTic7.Enabled = false;
            score();
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            btnTic8.Enabled = false;
            score();
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            btnTic9.Enabled = false;
            score();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                label2.Text = "X";
                label3.Text = "O";

                btnTic1.BackColor = Color.Gainsboro;
                btnTic2.BackColor = Color.Gainsboro;
                btnTic3.BackColor = Color.Gainsboro;
                btnTic4.BackColor = Color.Gainsboro;
                btnTic5.BackColor = Color.Gainsboro;
                btnTic6.BackColor = Color.Gainsboro;
                btnTic7.BackColor = Color.Gainsboro;
                btnTic8.BackColor = Color.Gainsboro;
                btnTic9.BackColor = Color.Gainsboro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            try
            {

                btnTic1.Enabled = true;
                btnTic2.Enabled = true;
                btnTic3.Enabled = true;
                btnTic4.Enabled = true;
                btnTic5.Enabled = true;
                btnTic6.Enabled = true;
                btnTic7.Enabled = true;
                btnTic8.Enabled = true;
                btnTic9.Enabled = true;

                btnTic1.Text = "";
                btnTic2.Text = "";
                btnTic3.Text = "";
                btnTic4.Text = "";
                btnTic5.Text = "";
                btnTic6.Text = "";
                btnTic7.Text = "";
                btnTic8.Text = "";
                btnTic9.Text = "";

                btnNewGame.Enabled = true;

                btnTic1.BackColor = Color.Gainsboro;
                btnTic2.BackColor = Color.Gainsboro;
                btnTic3.BackColor = Color.Gainsboro;
                btnTic4.BackColor = Color.Gainsboro;
                btnTic5.BackColor = Color.Gainsboro;
                btnTic6.BackColor = Color.Gainsboro;
                btnTic7.BackColor = Color.Gainsboro;
                btnTic8.BackColor = Color.Gainsboro;
                btnTic9.BackColor = Color.Gainsboro;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


