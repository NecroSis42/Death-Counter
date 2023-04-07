using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Countdown
{
    

    public partial class Form1 : Form
    {
        int H = 0;
        int M = 0;
        int S = 0;
        int TH = 0;
        int TM = 0;
        int TS = 0;
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int v1 = 0;
        int v2 = 0;
       
        public Form1()
        {
            InitializeComponent();

            label1.Text = "0";
            StreamWriter B = new StreamWriter(Application.StartupPath + @"\res\Counter.txt");
            B.Write(label1.Text);
            B.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add)
            {
                a++;
                label1.Text = a.ToString();
                StreamWriter B = new StreamWriter(Application.StartupPath + @"\res\Counter.txt");
                B.Write(label1.Text);
                B.Close();

                //Einstellung für den Timer

                if (M + b > 120)
                {
                    M = (M + b) - 120;
                    H = H + 2;
                }
                else
                if (M + b == 120)
                {
                    M = 0;
                    H = H + 2;
                }
                else
                if (M + b > 60)
                {
                    M = (M + b) - 60;
                    H = H + 1;
                }
                else
                if (M + b == 60)
                {
                    M = 0;
                    H = H + 1;
                }
                else
                {
                    M = (M + b);
                }

                if (H < 10)
                {
                    CDH.Text = "0" + H.ToString();
                }
                else
                {
                    CDH.Text = H.ToString();
                }

                if (M < 10)
                {
                    CDM.Text = "0" + M.ToString();
                }
                else
                {
                    CDM.Text = M.ToString();
                }

                if (S < 10)
                {
                    CDS.Text = "0" + S.ToString();
                }
                else
                {
                    CDS.Text = S.ToString();
                }

                StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
                C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
                C.Close();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                //Einstellung für den Timer

                if (M + c > 120)
                {
                    M = (M + c) - 120;
                    H = H + 2;
                }
                else
                if (M + c == 120)
                {
                    M = 0;
                    H = H + 2;
                }
                else
                if (M + c > 60)
                {
                    M = (M + c) - 60;
                    H = H + 1;
                }
                else
                if (M + c == 60)
                {
                    M = 0;
                    H = H + 1;
                }
                else
                {
                    M = (M + c);
                }

                if (H < 10)
                {
                    CDH.Text = "0" + H.ToString();
                }
                else
                {
                    CDH.Text = H.ToString();
                }

                if (M < 10)
                {
                    CDM.Text = "0" + M.ToString();
                }
                else
                {
                    CDM.Text = M.ToString();
                }

                if (S < 10)
                {
                    CDS.Text = "0" + S.ToString();
                }
                else
                {
                    CDS.Text = S.ToString();
                }

                StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
                C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
                C.Close();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                //Einstellung für den Timer

                if (M + d > 120)
                {
                    M = (M + d) - 120;
                    H = H + 2;
                }
                else
                if (M + d == 120)
                {
                    M = 0;
                    H = H + 2;
                }
                else
                if (M + d > 60)
                {
                    M = (M + d) - 60;
                    H = H + 1;
                }
                else
                if (M + d == 60)
                {
                    M = 0;
                    H = H + 1;
                }
                else
                {
                    M = (M + d);
                }

                if (H < 10)
                {
                    CDH.Text = "0" + H.ToString();
                }
                else
                {
                    CDH.Text = H.ToString();
                }

                if (M < 10)
                {
                    CDM.Text = "0" + M.ToString();
                }
                else
                {
                    CDM.Text = M.ToString();
                }

                if (S < 10)
                {
                    CDS.Text = "0" + S.ToString();
                }
                else
                {
                    CDS.Text = S.ToString();
                }

                StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
                C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
                C.Close();
            }
            if (e.KeyCode == Keys.Divide)
            {
                //Einstellung für den Timer

                if (M + v1 > 120)
                {
                    M = (M + v1) - 120;
                    H = H + 2;
                }
                else
                if (M + v1 == 120)
                {
                    M = 0;
                    H = H + 2;
                }
                else
                if (M + v1 > 60)
                {
                    M = (M + v1) - 60;
                    H = H + 1;
                }
                else
                if (M + v1 == 60)
                {
                    M = 0;
                    H = H + 1;
                }
                else
                {
                    M = (M + v1);
                }

                if (H < 10)
                {
                    CDH.Text = "0" + H.ToString();
                }
                else
                {
                    CDH.Text = H.ToString();
                }

                if (M < 10)
                {
                    CDM.Text = "0" + M.ToString();
                }
                else
                {
                    CDM.Text = M.ToString();
                }

                if (S < 10)
                {
                    CDS.Text = "0" + S.ToString();
                }
                else
                {
                    CDS.Text = S.ToString();
                }

                StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
                C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
                C.Close();
            }
            if (e.KeyCode == Keys.Decimal)
            {
                //Einstellung für den Timer

                if (M + v2 > 120)
                {
                    M = (M + v2) - 120;
                    H = H + 2;
                }
                else
                if (M + v2 == 120)
                {
                    M = 0;
                    H = H + 2;
                }
                else
                if (M + v2 > 60)
                {
                    M = (M + v2) - 60;
                    H = H + 1;
                }
                else
                if (M + v2 == 60)
                {
                    M = 0;
                    H = H + 1;
                }
                else
                {
                    M = (M + v2);
                }

                if (H < 10)
                {
                    CDH.Text = "0" + H.ToString();
                }
                else
                {
                    CDH.Text = H.ToString();
                }

                if (M < 10)
                {
                    CDM.Text = "0" + M.ToString();
                }
                else
                {
                    CDM.Text = M.ToString();
                }

                if (S < 10)
                {
                    CDS.Text = "0" + S.ToString();
                }
                else
                {
                    CDS.Text = S.ToString();
                }

                StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
                C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
                C.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            label1.Text = "0";
            StreamWriter B = new StreamWriter(Application.StartupPath + @"\res\Counter.txt");
            B.Write(label1.Text);
            B.Close();
            
            CDH.Text = "00";
            CDM.Text = "00";
            CDS.Text = "00";
            StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
            C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
            C.Close();
        }

        // AlwaysOnTop

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Show();
            if (checkBox1.Checked == true)
            {
                this.TopMost = true;
            }
            else
            if (checkBox1.Checked == false)
            {
                this.TopMost = false;
                this.Show();
            }
        }

        // Countdown

        private void timer1_Tick(object sender, EventArgs e) //Timer
        {
            

            if ((S == 0) && (M == 0) && (H > 0)) //smH
            {
                H = H - 1;
                M = 60;
                M = M - 1;
                S = 60;
            }

            if ((S == 0) && (M > 0) && (H > 0)) //sMH
            {
                M = M - 1;
                S = 60;
            }

            if ((S == 0) && (M > 0) && (H == 0)) //sMh
            {
                M = M - 1;
                S = 60;
            }

            if ((S > 0) && (M == 0) && (H > 0)) //SmH
            {
                S = S - 1;
            }

            if ((S > 0) && (M > 0) && (H > 0)) //SMH
            {
                S = S - 1;
            }

            if ((S > 0) && (M > 0) && (H == 0)) //SMh
            {
                S = S - 1;
            }

            if ((S > 0) && (M == 0) && (H == 0)) //Smh
            {
                S = S - 1;
            }

            if (H < 10)
            {
                CDH.Text = "0" + H.ToString();
            }
            else
            {
                CDH.Text = H.ToString();
            }

            if (M < 10)
            {
                CDM.Text = "0" + M.ToString();
            }
            else
            {
                CDM.Text = M.ToString();
            }

            if (S < 10)
            {
                CDS.Text = "0" + S.ToString();
            }
            else
            {
                CDS.Text = S.ToString();
            }

            if ((S == 0) && (M == 0) && (H == 0)) //smh
            {
                timer1.Stop();
            }
            StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
            C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
            C.Close();
        }

        private void button1_Click(object sender, EventArgs e) //Übernimmt die Eingabe in die entsprechenden Labels
        {
            if (TBS.Text.Length < 2)
            {
                TBS.Text = "0" + TBS.Text;
            }
            if (TBM.Text.Length < 2)
            {
                TBM.Text = "0" + TBM.Text;
            }
            if (TBH.Text.Length < 2)
            {
                TBH.Text = "0" + TBH.Text;
            }
            CDS.Text = TBS.Text;
            CDM.Text = TBM.Text;
            CDH.Text = TBH.Text;
            H = Convert.ToInt32(TBH.Text);
            M = Convert.ToInt32(TBM.Text);
            S = Convert.ToInt32(TBS.Text); 
            TH = Convert.ToInt32(TBH.Text);
            TM = Convert.ToInt32(TBM.Text);
            TS = Convert.ToInt32(TBS.Text);

            StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
            C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
            C.Close();
        }

        private void TBS_KeyPress(object sender, KeyPressEventArgs e) //Lässt nur Nummern im Textfeld für Sekunden zu
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void TBS_KeyUp(object sender, KeyEventArgs e) //aktualisiert beim Loslassen der Taste, sodass der Wert für Sekunden 
        {                                                     //59 nicht übersteigen und auch nicht nur eine 0 ausgewählt werden kann  
            int x = Convert.ToInt32(TBS.Text);
            if (x > 59)
            {
                TBS.Text = "59";
            }
            
            if (x == 0)
            {
                TBS.Text = "00";
            }
        }

        private void TBM_KeyPress(object sender, KeyPressEventArgs e)   //Dasselbe nochmal für die Minuten...
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBM_KeyUp(object sender, KeyEventArgs e)
        {
            int x = Convert.ToInt32(TBM.Text);
            if (x > 59)
            {
                TBM.Text = "59";
            }
            if (x == 0)
            {
                TBM.Text = "00";
            }
        }

        private void TBH_KeyPress(object sender, KeyPressEventArgs e)   //Für die Stunden reicht es, dass nur Zahlen eingegeben werden
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e) //ResetBTN
        {
            if (TH < 10)
            {
                TBH.Text = "0" + TH.ToString();
                CDH.Text = "0" + TH.ToString();
            }
            else
            {
                TBH.Text = TH.ToString();
                CDH.Text = TH.ToString();
            }

            if (TM < 10)
            {
                TBM.Text = "0" + TM.ToString();
                CDM.Text = "0" + TM.ToString();
            }
            else
            {
                TBM.Text = TM.ToString();
                CDM.Text = TM.ToString();
            }

            if (TS < 10)
            {
                TBS.Text = "0" + TS.ToString();
                CDS.Text = "0" + TS.ToString();
            }
            else
            {
                TBS.Text = TS.ToString();
                CDS.Text = TS.ToString();
            }
            H = TH;
            M = TM;
            S = TS;

            timer1.Stop();
            StartBTN.Enabled = true;
            button3.Text = "Pause";
            StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
            C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
            C.Close();
        }

        private void StartBTN_Click(object sender, EventArgs e) //StartBTN
        {
            timer1.Start();
            StartBTN.Enabled = false;
            StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
            C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
            C.Close();
        }

        private void button4_Click(object sender, EventArgs e) //StopBTN
        {
            timer1.Stop();
            H = 0;
            M = 0;
            S = 0;
            CDS.Text = "0" + S.ToString();
            CDM.Text = "0" + M.ToString();
            CDH.Text = "0" + H.ToString();
            StartBTN.Enabled = true;
            StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
            C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
            C.Close();
        }

        private void button3_Click(object sender, EventArgs e) //PauseBTN
        {
            if (button3.Text == "Pause")
            {
                timer1.Stop();
                button3.Text = "Resume";
            }
            else
            {
                timer1.Start();
                button3.Text = "Pause";
            }
            StreamWriter C = new StreamWriter(Application.StartupPath + @"\res\Countdown.txt");
            C.Write(CDH.Text + ":" + CDM.Text + ":" + CDS.Text);
            C.Close();
        }

        private void SZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            b = Convert.ToInt32(SZ.Text);
        }

        private void FLWtextbox_KeyPress(object sender, KeyPressEventArgs e) //Lässt nur Zahlen bei der Eingabe in die Follower-Box zu
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FLWacceptbutton_Click(object sender, EventArgs e) //konvertiert den Text aus der Follower-Box und gibt es als Variable c aus
        {
            c = Convert.ToInt32(FLWtextbox.Text);
        }

        private void ACHacceptbtn_Click(object sender, EventArgs e)
        {
            d = Convert.ToInt32(ACHtextbox.Text);
        }

        private void ACHtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ANE1textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ANE2textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ANE1acceptbtn_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToInt32(ANE1textbox.Text);
            ANE1label.Text = ANE1nametextBox.Text;
        }

        private void ANE2acceptbtn_Click(object sender, EventArgs e)
        {
            v2 = Convert.ToInt32(ANE2textbox.Text);
            ANE2label.Text = ANE2nametextBox.Text;
        }
    }
}
