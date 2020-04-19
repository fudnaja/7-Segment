using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App7Segment
{
    public partial class Form1 : Form
    {
        int num = -1;
        public Form1()
        {
            InitializeComponent();
        }

        public void Display1(int i)
        {
            switch (i)
            {
                case 0:
                    lblA.BackColor = Color.Red;
                    lblB.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;
                    lblD.BackColor = Color.Red;
                    lblE.BackColor = Color.Red;
                    lblF.BackColor = Color.Red;

                    lblG.BackColor = Color.Black;
                    break;
                case 1:

                    lblB.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;

                    lblA.BackColor = Color.Black;
                    lblD.BackColor = Color.Black;
                    lblE.BackColor = Color.Black;
                    lblF.BackColor = Color.Black;
                    lblG.BackColor = Color.Black;
                    break;
                case 2:
                    lblA.BackColor = Color.Red;
                    lblB.BackColor = Color.Red;
                    lblD.BackColor = Color.Red;
                    lblE.BackColor = Color.Red;
                    lblG.BackColor = Color.Red;

                    lblC.BackColor = Color.Black;
                    lblF.BackColor = Color.Black;


                    break;
                case 3:
                    lblA.BackColor = Color.Red;
                    lblB.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;
                    lblD.BackColor = Color.Red;
                    lblG.BackColor = Color.Red;

                    lblE.BackColor = Color.Black;
                    lblF.BackColor = Color.Black;

                    break;
                case 4:

                    lblB.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;
                    lblF.BackColor = Color.Red;
                    lblG.BackColor = Color.Red;

                    lblA.BackColor = Color.Black;
                    lblE.BackColor = Color.Black;
                    lblD.BackColor = Color.Black;
                    break;
                case 5:
                    lblA.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;
                    lblD.BackColor = Color.Red;
                    lblF.BackColor = Color.Red;
                    lblG.BackColor = Color.Red;

                    lblB.BackColor = Color.Black;
                    lblE.BackColor = Color.Black;
                    break;
                case 6:
                    lblA.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;
                    lblD.BackColor = Color.Red;
                    lblE.BackColor = Color.Red;
                    lblF.BackColor = Color.Red;
                    lblG.BackColor = Color.Red;

                    lblB.BackColor = Color.Black;
                    break;
                case 7:
                    lblA.BackColor = Color.Red;
                    lblB.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;
                    lblF.BackColor = Color.Red;

                    lblD.BackColor = Color.Black;
                    lblE.BackColor = Color.Black;
                    lblG.BackColor = Color.Black;
                    break;
                case 8:
                    lblA.BackColor = Color.Red;
                    lblB.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;
                    lblD.BackColor = Color.Red;
                    lblE.BackColor = Color.Red;
                    lblF.BackColor = Color.Red;
                    lblG.BackColor = Color.Red;
                    break;
                case 9:
                    lblA.BackColor = Color.Red;
                    lblB.BackColor = Color.Red;
                    lblC.BackColor = Color.Red;
                    lblD.BackColor = Color.Red;
                    lblF.BackColor = Color.Red;
                    lblG.BackColor = Color.Red;

                    lblE.BackColor = Color.Black;
                    break;
                default:
                    // code block
                    break;
            }
        }

        public void Display2(int i)
        {
            switch (i)
            {
                case 0:
                    lblAA.BackColor = Color.Red;
                    lblBB.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;
                    lblDD.BackColor = Color.Red;
                    lblEE.BackColor = Color.Red;
                    lblFF.BackColor = Color.Red;

                    lblGG.BackColor = Color.Black;
                    break;
                case 1:

                    lblBB.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;

                    lblAA.BackColor = Color.Black;
                    lblDD.BackColor = Color.Black;
                    lblEE.BackColor = Color.Black;
                    lblFF.BackColor = Color.Black;
                    lblGG.BackColor = Color.Black;
                    break;
                case 2:
                    lblAA.BackColor = Color.Red;
                    lblBB.BackColor = Color.Red;
                    lblDD.BackColor = Color.Red;
                    lblEE.BackColor = Color.Red;
                    lblGG.BackColor = Color.Red;

                    lblCC.BackColor = Color.Black;
                    lblFF.BackColor = Color.Black;


                    break;
                case 3:
                    lblAA.BackColor = Color.Red;
                    lblBB.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;
                    lblDD.BackColor = Color.Red;
                    lblGG.BackColor = Color.Red;

                    lblEE.BackColor = Color.Black;
                    lblFF.BackColor = Color.Black;

                    break;
                case 4:

                    lblBB.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;
                    lblFF.BackColor = Color.Red;
                    lblGG.BackColor = Color.Red;

                    lblAA.BackColor = Color.Black;
                    lblEE.BackColor = Color.Black;
                    lblDD.BackColor = Color.Black;
                    break;
                case 5:
                    lblAA.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;
                    lblDD.BackColor = Color.Red;
                    lblFF.BackColor = Color.Red;
                    lblGG.BackColor = Color.Red;

                    lblBB.BackColor = Color.Black;
                    lblEE.BackColor = Color.Black;
                    break;
                case 6:
                    lblAA.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;
                    lblDD.BackColor = Color.Red;
                    lblEE.BackColor = Color.Red;
                    lblFF.BackColor = Color.Red;
                    lblGG.BackColor = Color.Red;

                    lblBB.BackColor = Color.Black;
                    break;
                case 7:
                    lblAA.BackColor = Color.Red;
                    lblBB.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;
                    lblFF.BackColor = Color.Red;

                    lblDD.BackColor = Color.Black;
                    lblEE.BackColor = Color.Black;
                    lblGG.BackColor = Color.Black;
                    break;
                case 8:
                    lblAA.BackColor = Color.Red;
                    lblBB.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;
                    lblDD.BackColor = Color.Red;
                    lblEE.BackColor = Color.Red;
                    lblFF.BackColor = Color.Red;
                    lblGG.BackColor = Color.Red;
                    break;
                case 9:
                    lblAA.BackColor = Color.Red;
                    lblBB.BackColor = Color.Red;
                    lblCC.BackColor = Color.Red;
                    lblDD.BackColor = Color.Red;
                    lblFF.BackColor = Color.Red;
                    lblGG.BackColor = Color.Red;

                    lblEE.BackColor = Color.Black;
                    break;
                default:
                    // code block
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (num == 9)
                num = -1;

            if(num ==-1 || num<10)
            {
                num++;
                Display1(num);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = (DateTime.Now.Second % 10);
            int ii = (DateTime.Now.Second / 10);
            Display1(ii);
            Display2(i);
        }
    }
}
