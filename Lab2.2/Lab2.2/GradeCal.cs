using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    internal class GradeCal
    {
        private int na, nbplus, nb, ncplus, nc, ndplus, nd, nf;
        private double arrayIndex;
        private double totalGPA; 
        private int GPAaverage; 
        
        
        public GradeCal()
        {

            na = nbplus = nb = ncplus = nc = ndplus = nd = nf = 0;
            arrayIndex = 0.0;
            totalGPA = 0.0;
        }

        public void CalculateGrade(int inputScore)
        {
            string currentGrade;

            if (inputScore >= 80 && inputScore <= 100)
            {
                currentGrade = "A";
                na++;
            }
            else if (inputScore >= 75 && inputScore < 79)
            {
                currentGrade = "B+";
                nbplus++;
            }
            else if (inputScore >= 70 && inputScore < 74)
            {
                currentGrade = "B";
                nb++;
            }
            else if (inputScore >= 65 && inputScore < 69)
            {
                currentGrade = "C+";
                ncplus++;
            }
            else if (inputScore >= 60 && inputScore < 64)
            {
                currentGrade = "C";
                nc++;
            }
            else if (inputScore >= 55 && inputScore < 59)
            {
                currentGrade = "D+";
                ndplus++;
            }
            else if (inputScore >= 50 && inputScore < 54)
            {
                currentGrade = "D";
                nd++;
            }
            else
            {
                currentGrade = "F";
                nf++;
            }

            
            totalGPA = (na * 4.0) + (nbplus * 3.5) + (nb * 3.0) + (ncplus * 2.5) + (nc * 2.0) + (ndplus * 1.5) + (nd * 1.0);
            arrayIndex++;
 
            double GPA2 = totalGPA / arrayIndex;
            GPAaverage = (int)GPA2;

        }
        public int GetGPAaverage()
        {
            return GPAaverage;
        }
        public int GetGradeCountA()
        {
            return na;
        }
        public int GetGradeCountBPlus()
        {
            return nbplus;
        }
        public int GetGradeCountB()
        {
            return nb;
        }
        public int GetGradeCountCPlus()
        {
            return ncplus;
        }
        public int GetGradeCountC()
        {
            return nc;
        }
        public int GetGradeCountDPlus()
        {
            return ndplus;
        }
        public int GetGradeCountD()
        {
            return nd;
        }
        public int GetGradeCountF()
        {
            return nf;
        }
    }
}
