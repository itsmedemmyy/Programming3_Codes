using System;

namespace TimeKeeping_activity
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("||Time Keeping System for Employees|| ");
            Console.WriteLine("");
            Console.WriteLine("Date:" + DateTime.Today.ToShortDateString());

            Console.WriteLine("");
            //Time_in 
            Console.Write("Enter your employee id to Time_In:");
            string emp_Id = Console.ReadLine();

            TimeSpan timeIN = new TimeSpan(8, 0, 0);
            Console.WriteLine($"You have successfully Time_In at {timeIN}");
            TimeSpan reg_HrsStart = new TimeSpan(8, 0, 0);

            Console.WriteLine("");
            Console.WriteLine("<---------------------------------------------->");
            Console.WriteLine("");

            //Time_out
            Console.Write("Enter your employee id to Time_out:");
            emp_Id = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(14, 0, 0);
            Console.WriteLine($"You have successfully Time_out at {timeOut}");
            TimeSpan reg_HrsEnd = new TimeSpan(17, 0, 0);

            //Lunch break
            TimeSpan lunchbreak_dur = new TimeSpan(1, 0, 0);

            Console.WriteLine("");
            Console.WriteLine("<---------------------------------------------->");
            Console.WriteLine("");

            //Getting Total hrs of work
            TimeSpan totalWorkHrs = timeOut - timeIN - lunchbreak_dur;
            Console.WriteLine("Total hours of work:" + totalWorkHrs);

            //Getting total regular hrs of Work

            TimeSpan late = new TimeSpan(0, 0, 0);
            TimeSpan early = new TimeSpan(0, 0, 0);
            TimeSpan TotalUndertime = new TimeSpan(0, 0, 0);

            if (timeIN > reg_HrsStart)
            {
                late = timeIN - reg_HrsStart;
            }
            if (timeOut < reg_HrsEnd)
            {
                early = timeOut - reg_HrsEnd;

            }
            TimeSpan total_reg_hrs = totalWorkHrs - late - early;
            Console.WriteLine($"Total regular hours of work:{total_reg_hrs}");

            //Getting total undertime work hrs
            if (timeIN < reg_HrsStart)
            {
                TimeSpan a = new TimeSpan(0, 0, 0);
                Console.WriteLine(a);
            }
            if (timeOut < reg_HrsEnd)
            {
                TotalUndertime = reg_HrsEnd - timeOut;
                Console.WriteLine($"Total hours of undertime: {TotalUndertime}");
            }

        }
    }
}
