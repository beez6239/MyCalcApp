using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MyCalcApp
{
    
    public partial class Form1 : Form
    {
        decimal First_Number, Second_Number;
        string SelectedOperator = string.Empty;
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int Width, int Height);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = "9";
            }
            else
            {
                ResultScreen.Text += "9";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoundBtn();

        }
        private  void RoundBtn()
        {
            btnNine.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNine.Width, btnNine.Height, 22, 22));
            btnEight.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEight.Width, btnEight.Height, 22, 22));
            btnFour.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFour.Width, btnFour.Height, 22, 22));
            btnFive.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFive.Width, btnFive.Height, 22, 22));
            btnSix.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSix.Width, btnSix.Height, 22, 22));
            btnOne.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnOne.Width, btnOne.Height, 22, 22));
            btnTwo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTwo.Width, btnTwo.Height, 22, 22));
            btnZero.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnZero.Width, btnZero.Height, 22, 22));
            btnSeven.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSeven.Width, btnSeven.Height, 22, 22));
            btnThree.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnThree.Width, btnThree.Height, 22, 22));
            btnEqual.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEqual.Width, btnEqual.Height, 22, 22));
            btnRem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRem.Width, btnRem.Height, 22, 22));
            btnAdd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdd.Width, btnAdd.Height, 22, 22));
            btnSubtract.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSubtract.Width, btnSubtract.Height, 22, 22));
            btnMulti.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnMulti.Width, btnMulti.Height, 22, 22));
            btnDivide.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDivide.Width, btnDivide.Height, 22, 22));
            btnClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 22, 22));
            btndot.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btndot.Width, btndot.Height, 22, 22));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            First_Number = Decimal.Parse(ResultScreen.Text);
            ClearText();
            SelectedOperator = "-";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(ResultScreen.Text == "0")
            {
                ResultScreen.Text = "0";
            }
            else
            {
                ResultScreen.Text += "0";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(ResultScreen.Text == "0")
            {
                ResultScreen.Text = "1";
            }
            else
            {
                ResultScreen.Text += "1";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = "7";
            }
            else
            {
                ResultScreen.Text += "7";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = "5";
            }
            else
            {
                ResultScreen.Text += "5";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = "4";
            }
            else
            {
                ResultScreen.Text += "4";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = "8";
            }
            else
            {
                ResultScreen.Text += "8";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = "2";
            }
            else
            {
                ResultScreen.Text += "2";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = "6";
            }
            else
            {
                ResultScreen.Text += "6";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = "3";
            }
            else
            {
                ResultScreen.Text += "3";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(ResultScreen.Text == "0")
            {
                
            }else
            {
                ResultScreen.Text = "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            First_Number = Decimal.Parse(ResultScreen.Text);
            ClearText();
            SelectedOperator = "+";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            First_Number = Decimal.Parse(ResultScreen.Text);
            ClearText();
            SelectedOperator = "x";
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            First_Number = Decimal.Parse(ResultScreen.Text);
            ClearText();
            SelectedOperator = "%";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                Second_Number = Decimal.Parse(ResultScreen.Text);
                switch (SelectedOperator)
                {
                    case "/":
                        if (ResultScreen.Text != "0")
                            ResultScreen.Text = (First_Number / Second_Number).ToString();
                        break;
                    case "+":
                        
                            ResultScreen.Text = (First_Number + Second_Number).ToString();
                        break;
                    case "-":
                        
                            ResultScreen.Text = (First_Number - Second_Number).ToString();
                        break;
                    case "*":
                       
                            ResultScreen.Text = (First_Number * Second_Number).ToString();
                        break;
                    case "%":
                       
                            ResultScreen.Text = (First_Number % Second_Number).ToString();
                        break;
                    default:
                        ResultScreen.Text = "Syntax error!";
                        break;
                }
            }
            catch (Exception x)
            {
                ResultScreen.Text = "Input was not enter correctly";
            }
           
        }

        private void ClearText()
        {
            ResultScreen.Text = "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text == "0")
            {
                ResultScreen.Text = ".";
            }
            else
            {
                ResultScreen.Text += ".";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            First_Number = Decimal.Parse(ResultScreen.Text);
            ClearText();
            SelectedOperator = "/";
        }
    }
}
