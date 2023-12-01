using System.Diagnostics;

namespace Lab2._2
{
    public partial class Form1 : Form
    {
        int arrayIndex = 0;
        int Max = 0;
        int Min = 0;
        string[] arrName = new string[10000];
        string[] arrID = new string[10000];
        int[] arrScore = new int[10000];
        int SUM = 0;
        int na = 0;
        int nbplus = 0;
        int nb = 0;
        int ncplus = 0;
        int nc = 0;
        int ndplus = 0;
        int nd = 0;
        int nf = 0;
        string Grade;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputName = infoTextBoxNM.Text;
            string inputID = infoTextBoxID.Text;
            int inputScore = int.Parse(infoTextBoxSC.Text);

            arrID[arrayIndex] = inputID;
            arrName[arrayIndex] = inputName;
            arrScore[arrayIndex] = inputScore;
            arrayIndex++;

            infoTextBoxSC.Text = inputScore.ToString();

            if (inputScore > Max)
            {
                Max = inputScore;
                MaxID.Text = inputID;
                MaxNM.Text = inputName;
                MaxSC.Text = inputScore.ToString();
                Min = Max;
            }

            if (inputScore < Min)
            {
                Min = inputScore;
                MinID.Text = inputID;
                MinNM.Text = inputName;
                MinSC.Text = inputScore.ToString();
            }

            int SUM = Max + Min;
            double SUM2 = SUM / 2;
            string SUM3 = SUM2.ToString();
            SCaverage.Text = SUM3;

            if (inputScore >= 80 && inputScore <= 100)
            {
                Grade = "A";
                na++;
            }
            else if (inputScore >= 75 && inputScore < 79)
            {
                Grade = "B+";
                nbplus++;
            }
            else if (inputScore >= 70 && inputScore < 74)
            {
                Grade = "B";
                nb++;
            }
            else if (inputScore >= 65 && inputScore < 69)
            {
                Grade = "C+";
                ncplus++;
            }
            else if (inputScore >= 60 && inputScore < 64)
            {
                Grade = "C";
                nc++;
            }
            else if (inputScore >= 55 && inputScore < 59)
            {
                Grade = "D+";
                ndplus++;
            }
            else if (inputScore >= 50 && inputScore < 54)
            {
                Grade = "D";
                nd++;
            }
            else
            {
                Grade = "F";
                nf++;
            }

            double v = (na * 4.0) + (nbplus * 3.5) + (nb * 3.0) + (ncplus * 2.5) + (nc * 2.0) + (ndplus * 1.5) + (nd * 1.0);
            int GPA = (int)v;
            double GPA2 = GPA / arrayIndex;
            string GPA3 = GPA2.ToString();
            GPAaverage.Text = GPA3;

            textBoxA.Text = na.ToString();
            textBoxBplus.Text = nbplus.ToString();
            textBoxB.Text = nb.ToString();
            textBoxCplus.Text = ncplus.ToString();
            textBoxC.Text = nc.ToString();
            textBoxDplus.Text = ndplus.ToString();
            textBoxD.Text = nd.ToString();
            textBoxF.Text = nf.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infoTextBoxID.Clear();
            infoTextBoxNM.Clear();
            infoTextBoxSC.Clear();
        }
    }
}
