public class StudentInfo
{
    private int Max = 0;
    private int Min = 0;
    private string MaxStudentID;
    private string MinStudentID;
    private string MaxStudentName;
    private string MinStudentName;
    private int MaxScore;
    private int MinScore;
    private int sumScore;
    private int sumScore2;
    private int sumScore3;
    private double averageScore;

    public void showInfo(int inputScore, string inputID, string inputName)
    {

        if (inputScore > Max)
        {
            Max = inputScore;
            MaxStudentID= inputID;
            MaxStudentName= inputName;
            MaxScore = inputScore;
            Min = Max;
        }

        if (inputScore < Min)
        {
            Min = inputScore;
            MinStudentID = inputID;
            MinStudentName = inputName;
            MinScore = inputScore;
        }
        sumScore = Max + Min;
        sumScore2 = sumScore / 2;
        sumScore3 = sumScore2;
        averageScore = sumScore3;

    }
    
    public string GetMaxStudentID()
    {
        return MaxStudentID;
    }
    public string GetMinStudentID()
    {
        return MinStudentID;
    }
    public string GetMaxStudentName()
    {
        return MaxStudentName;
    }
    public string GetMinStudentName()
    {
        return MinStudentName;
    }
    public int GetMaxScore()
    {
        return MaxScore;
    }

    public int GetMinScore()
    {
        return MinScore;
    }

    public double GetAverageScore()
    {
        return averageScore;
    }
}