using System.Diagnostics;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Lab2._2
{
    public partial class Form1 : Form
    {
        internal StudentInfo INFO = new StudentInfo();
        internal GradeCal GPACAL = new GradeCal();
        int arrayIndex = 0;
        int na, nbplus, nb, ncplus, nc, ndplus, nd, nf;
        string grade;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputName = infoTextBoxNM.Text;
            string inputID = infoTextBoxID.Text;
            int inputScore = int.Parse(infoTextBoxSC.Text);

            infoTextBoxSC.Text = inputScore.ToString();

            //ดึงมากจากclass StudentInfo
            INFO.showInfo(inputScore, inputID,inputName);
            string MaxName = INFO.GetMaxStudentName();
            string MinName = INFO.GetMinStudentName();
            string MaxstudentID = INFO.GetMaxStudentID();
            string MinstudentID = INFO.GetMinStudentID();
            string MaxScore = Convert.ToString(INFO.GetMaxScore());
            string MinScore = Convert.ToString(INFO.GetMinScore());
            string ScoreAverage = Convert.ToString(INFO.GetAverageScore());
            MaxNM.Text = MaxName;
            MinNM.Text = MinName;
            MaxID.Text = MaxstudentID;
            MinID.Text = MinstudentID;
            MaxSC.Text = MaxScore;
            MinSC.Text = MinScore;
            SCaverage.Text = ScoreAverage;
            arrayIndex++;
            //ดึงมาจากclass GradeCal
            GPACAL.CalculateGrade(inputScore);
            int na = GPACAL.GetGradeCountA();
            int nbplus = GPACAL.GetGradeCountBPlus();
            int nb = GPACAL.GetGradeCountB();
            int ncplus = GPACAL.GetGradeCountCPlus();
            int nc = GPACAL.GetGradeCountC();
            int ndplus = GPACAL.GetGradeCountDPlus();
            int nd = GPACAL.GetGradeCountD();
            int nf = GPACAL.GetGradeCountF();
            int GPA_average =GPACAL.GetGPAaverage();

            textBoxA.Text = na.ToString();
            textBoxBplus.Text = nbplus.ToString();
            textBoxB.Text = nb.ToString();
            textBoxCplus.Text = ncplus.ToString();
            textBoxC.Text = nc.ToString();
            textBoxDplus.Text = ndplus.ToString();
            textBoxD.Text = nd.ToString();
            textBoxF.Text = nf.ToString();
            GPAaverage.Text = GPA_average.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            infoTextBoxID.Clear();
            infoTextBoxNM.Clear();
            infoTextBoxSC.Clear();
        }
    }
}
