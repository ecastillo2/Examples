using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFilePath = "C:\\Users\\Erick Castillo\\Downloads\\testfile.csv";
            string strSeperator = "-12678,789.00";
            string fmt2 = "(#,###.##)";
            string credit = "2343.00";
            double num = 0;
            credit = credit.Replace("-", "");
            num = Convert.ToDouble(credit);
            
            credit = num.ToString(fmt2);


            credit = String.Format("\"{0}\",", credit);
            credit = credit.Replace("\"", "");
            credit = ("\t" + credit + "\t");
            credit = String.Format("\"{0}\",", credit);
            credit = credit.Substring(0, credit.LastIndexOf(")") + 1);

            // Create and write the csv file
            File.WriteAllText(strFilePath, credit);



        }


    }
}
