using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PROJECT
{
    public class Program
    {
        public static void Filing(string name, string city, string InterestedField, double per)
        {
            FileStream fs = new FileStream($"{Environment.CurrentDirectory}/test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine($"Name:{name};City:{city};Interested Field:{InterestedField};Percentage:{per};");
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public static string CityChoice(int UserSelection1)
        {
            string[] array = new string[5] { "Karachi", "Lahore", "Faisalabad", "Islamabad", "Peshawar" };
            string city = array[UserSelection1 - 1];
            // Console.WriteLine(city);
            return city;
        }
        public static string FieldChoice(int UserSelection2)
        {
            string[] array = new string[4] { "Engineering", "Medical", "Commerce", "Computer Science" };
            string InterestedField = array[UserSelection2 - 1];
            // Console.WriteLine(InterestedField);
            return InterestedField;
        }
        public static void Main()
        {
            try
            {
                while (true)
                {
                start:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGray;//COLOUR
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR
                    Console.WriteLine("\n\t\t\t\tWELCOME TO UNIVERSITY FINDER\n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;//COLOUR
                    Console.WriteLine("=========================================================================================");
                    string name, city, InterestedField;
                    double per;

                    Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR
                    Console.WriteLine("Please Enter Your Name");
                    name = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.DarkGray;//COLOUR
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR

                    Console.WriteLine("Please Enter any one number to make your choice in which city do you want to apply:");
                    Console.WriteLine("1.Karachi \n2.Lahore \n3.Faisalabad \n4.Islamabad \n5.Peshawar");
                    int UserSelection1 = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.DarkGray;//COLOUR
                    Console.WriteLine("=========================================================================================");

                    Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR
                    city = CityChoice(UserSelection1);
                    //Function will now return selected City as String..

                    Console.WriteLine("Please Enter any one number to make your choice in which Field do you want to apply:");
                    Console.WriteLine("1.Engineering \n2.Medical \n3.Commerce \n4.Computer Science");
                    int UserSelection2 = Convert.ToInt32(Console.ReadLine());

                    InterestedField = FieldChoice(UserSelection2);
                    //Function will now return selected Field as String..
                    Console.ForegroundColor = ConsoleColor.DarkGray;//COLOUR
                    Console.WriteLine("=========================================================================================");

                    Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR
                    Console.WriteLine("Please Enter Your Percentage");
                    per = Convert.ToDouble(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.DarkGray;//COLOUR
                    Console.WriteLine("=========================================================================================");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR

                    string[,] UniversityNames = new string[26, 2]
                    {    

                //KARACHI UNIVERSITIES:
                {"NED University","Aga Khan University"},//0
                {"Karachi University","Dawood University of Engineering and Technology"},//1
                {"Jinnah University for Women", "Shaheed Zulfiqar Ali Bhutto Institute of Science and Technology"},//2
                {"Habib University","Ziauddin University"},//3
                {"Bahria University","Institute of Business Management"},//4
                {"Karachi Institute of Economics and Technology (PAF-KIET)","Textile Institute of Pakistan"},//5
                {"FAST University","Sir Syed University of Engineering and Technology"},//6
                {"Iqra University","DOW University of Health and Science"},//7
               
                //LAHORE UNIVERSITIES:
                {"Lahore University of Management Sciences","University of the Punjab"},//8
                {"The University of Lahore","University of Management and Technology"},//9
                {"University of Central Punjab","University of Health Sciences"},//10
                {"Hajvery University","University of Veterinary and Animal Sciences"},//11
                {"Lahore Leads University","Qarshi University"},//12

                //FAISALABAD UNIVERSITIES:
                {"The University of Faisalabad","University of Agriculture"},//13
                {"Government College University Faisalabad","National Textile University"},//14
                {"Government College Women University","Faisalabad Medical University"},//15

                //ISLAMABAD UNIVERSITIES:
                {"COMSATS Institute of Information Technology","Air University"},//16
                {"Institute of Space Technology","National Defence University"},//17
                {"International Islamic University","National University of Sciences and Technology"},//18
                {"Quaid-i-Azam University","Riphah International University"},//19
                {"Shaheed Zulfiqar Ali Bhutto Medical University","Pakistan Institute of Engineering and Applied Sciences"},//20

                //PESHAWAR UNIVERSITIES:
                {"CECOS University","University of Peshawar"},//21
                {"Abasyn University","Khyber Medical University"},//22
                {"University of Engineering and Technology","Gandhara University"},//23
                {"Sarhad University of Science and Information Technology","Islamia College University"},//24
                {"Jinnah Medical College University","Khyber Pakhtunkhwa Agricultural University"},//25
                
				};                   

                    if (per >= 50)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR
                        Console.WriteLine("\nCongrats " + name + "! You are Applicable In These Universities");
                        Console.ForegroundColor = ConsoleColor.DarkGray;//COLOUR
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR
                        Console.WriteLine("Really Sorry! According to your Percentage we dont have any University");
                        Console.ForegroundColor = ConsoleColor.DarkGray;//COLOUR
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;//COLOUR
                    }
                    // FOR KARACHI:
                    if (per >= 80 && (city == "Karachi"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[0, 0]);
                            Console.WriteLine("2." + UniversityNames[1, 0]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[2, 0]);
                            Console.WriteLine("2." + UniversityNames[7, 1]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[1, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[0, 0]);
                            Console.WriteLine("2." + UniversityNames[1, 0]);
                        }
                    }
                    else if (per >= 70 && per < 80 && (city == "Karachi"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[1, 1]);
                            Console.WriteLine("2." + UniversityNames[5, 1]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[0, 1]);
                            Console.WriteLine("2." + UniversityNames[3, 1]);
                            Console.WriteLine("3." + UniversityNames[4, 0]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[4, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[6, 0]);
                        }
                    }
                    else if (per >= 60 && per < 70 && (city == "Karachi"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[2, 1]);
                            Console.WriteLine("2." + UniversityNames[5, 0]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is Offering Medical below 70% in Karachi");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[5, 0]);
                            Console.WriteLine("2." + UniversityNames[7, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[5, 0]);
                            Console.WriteLine("2." + UniversityNames[4, 1]);
                            Console.WriteLine("3." + UniversityNames[6, 1]);
                        }
                    }
                    else if (per >= 50 && per < 60 && (city == "Karachi"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[6, 1]);
                            Console.WriteLine("2." + UniversityNames[7, 0]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is Offering Medical below 70% in Karachi");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[7, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[7, 0]);
                        }
                    }
                    //FOR LAHORE:
                    if (per >= 80 && (city == "Lahore"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[8, 1]);
                            Console.WriteLine("2." + UniversityNames[9, 1]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[11, 1]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[8, 0]);
                            Console.WriteLine("2." + UniversityNames[9, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[8, 0]);
                            Console.WriteLine("2." + UniversityNames[8, 1]);
                            Console.WriteLine("3." + UniversityNames[9, 0]);
                        }
                    }
                    else if (per >= 70 && per < 80 && (city == "Lahore"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[10, 0]);
                            Console.WriteLine("2." + UniversityNames[11, 0]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[10, 1]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[10, 0]);
                            Console.WriteLine("2." + UniversityNames[11, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[11, 0]);
                            Console.WriteLine("2." + UniversityNames[12, 0]);
                        }
                    }
                    else if (per >= 60 && per < 70 && (city == "Lahore"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[11, 0]);
                            Console.WriteLine("2." + UniversityNames[12, 1]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is Offering Medical below 70% in Lahore");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[11, 0]);
                            Console.WriteLine("2." + UniversityNames[12, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[11, 0]);
                            Console.WriteLine("2." + UniversityNames[12, 1]);
                        }
                    }
                    else if (per >= 50 && per < 60 && (city == "Lahore"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("No University is Offering Engineering below 60% in Lahore");
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is Offering Medical below 70% in Lahore");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[11, 1]);
                            Console.WriteLine("2." + UniversityNames[12, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[10, 0]);
                        }
                    }
                    //FOR FAISALABAD:
                    if (per >= 80 && (city == "Faisalabad"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[13, 0]);
                            Console.WriteLine("2." + UniversityNames[14, 0]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[13, 1]);
                            Console.WriteLine("2." + UniversityNames[15, 1]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[13, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[13, 0]);
                        }
                    }
                    else if (per >= 70 && per < 80 && (city == "Faisalabad"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[13, 1]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[14, 0]);
                            Console.WriteLine("2." + UniversityNames[15, 0]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[13, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[13, 1]);
                        }
                    }
                    else if (per >= 60 && per < 70 && (city == "Faisalabad"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[14, 1]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is Offering Medical below 70% in Faisalabad");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[14, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[14, 1]);
                        }
                    }
                    else if (per >= 50 && per < 60 && (city == "Faisalabad"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("No University is Offering Engineering Below 60%");
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is Offering Medical Below 70%");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[14, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[14, 0]);
                        }
                    }
                    //FOR ISLAMABAD:
                    if (per >= 80 && (city == "Islamabad"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[18, 1]);
                            Console.WriteLine("2." + UniversityNames[19, 0]);
                            Console.WriteLine("3." + UniversityNames[20, 1]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[19, 1]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[18, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[18, 1]);
                            Console.WriteLine("2." + UniversityNames[19, 0]);
                            Console.WriteLine("3." + UniversityNames[20, 1]);
                        }
                    }
                    else if (per >= 70 && per < 80 && (city == "Islamabad"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[16, 0]);
                            Console.WriteLine("2." + UniversityNames[16, 1]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[20, 0]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[17, 1]);
                            Console.WriteLine("2." + UniversityNames[18, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[16, 0]);
                            Console.WriteLine("2." + UniversityNames[16, 1]);
                            Console.WriteLine("3." + UniversityNames[17, 1]);
                        }
                    }
                    else if (per >= 60 && per < 70 && (city == "Islamabad"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[17, 0]);
                            Console.WriteLine("2." + UniversityNames[17, 1]);
                            Console.WriteLine("3." + UniversityNames[18, 0]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is offering Medical below 70% in Isalmabad");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[17, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[17, 0]);
                        }
                    }
                    else if (per >= 50 && per < 60 && (city == "Islamabad"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("No University is offering Engineering Below 60% in Islamabad");
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No university is offering Medical below 70% in Islamabad");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[16, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[18, 0]);
                        }
                    }
                    //FOR PESHAWAR:
                    if (per >= 80 && (city == "Peshawar"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[21, 1]);
                            Console.WriteLine("2." + UniversityNames[24, 1]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[22, 1]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[22, 1]);
                            Console.WriteLine("2." + UniversityNames[24, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[21, 1]);
                            Console.WriteLine("2." + UniversityNames[24, 1]);
                        }
                    }
                    else if (per >= 70 && per < 80 && (city == "Peshawar"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[22, 0]);
                            Console.WriteLine("2." + UniversityNames[23, 0]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("1." + UniversityNames[22, 0]);
                            Console.WriteLine("2." + UniversityNames[25, 0]);
                            Console.WriteLine("3." + UniversityNames[25, 1]);
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[21, 0]);
                            Console.WriteLine("2." + UniversityNames[23, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[22, 0]);
                            Console.WriteLine("2." + UniversityNames[23, 0]);
                        }
                    }
                    else if (per >= 60 && per < 70 && (city == "Peshawar"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("1." + UniversityNames[21, 0]);
                            Console.WriteLine("2." + UniversityNames[22, 1]);
                            Console.WriteLine("3." + UniversityNames[23, 1]);
                            Console.WriteLine("4." + UniversityNames[24, 0]);
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is offering Medical below 70% in Peshawar");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[23, 1]);
                            Console.WriteLine("2." + UniversityNames[24, 0]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[21, 0]);
                            Console.WriteLine("2." + UniversityNames[22, 1]);
                        }
                    }
                    else if (per >= 50 && per < 60 && (city == "Peshawar"))
                    {
                        if (InterestedField == "Engineering")
                        {
                            Console.WriteLine("No University is offering Engineering Below 60% in Peshawar");
                        }
                        else if (InterestedField == "Medical")
                        {
                            Console.WriteLine("No University is offering Medical Below 70% in Peshawar");
                        }
                        else if (InterestedField == "Commerce")
                        {
                            Console.WriteLine("1." + UniversityNames[25, 1]);
                        }
                        else if (InterestedField == "Computer Science")
                        {
                            Console.WriteLine("1." + UniversityNames[23, 1]);
                            Console.WriteLine("2." + UniversityNames[24, 0]);
                        }
                    }
                    // FILING:
                    Filing(name,city,InterestedField,per);

                    while (true) // Continue asking user until a correct answer is given.
                    {
                        Console.Write("\nDo you want to Continue? Press Y to Continue OR Press N to Exit : ");
                        string str = Console.ReadLine().ToUpper();
                        switch (str)
                        { 
                            case "Y":
                                goto start;// Exit the inner while-loop and continue in the outer while loop.
                            case "N":
                                return;// Return is used to the Exit the Main-Function.
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n\n\t Sorry the program is terminated because You have given some wrong information");
            }
        }
    }
}