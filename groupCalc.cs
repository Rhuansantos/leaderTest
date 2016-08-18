using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string a;
            string b;
            string c;
            string d;
            string e;
            string f;
            string g;
            string h;
            string i;
            string j;
            int userValue = 0;
            string callName = "";



            Console.WriteLine("What is your name?:");
            userName = Console.ReadLine();
            Console.WriteLine("q1.) I NEVER lose track of time. (yes / no / not sure):");
            a = Console.ReadLine();
            Console.WriteLine("q2.) I'm good at making \"small talk\". (yes / no / not sure):");
            b = Console.ReadLine();
            Console.WriteLine("q3.) Rules should always be followed. (yes / no / not sure):");
            c = Console.ReadLine();
            Console.WriteLine("q4.) Sometimes it's better to lose than risk hurting someone. (yes / no / not sure):");
            d = Console.ReadLine();
            Console.WriteLine("q5.) If I do NOT know something I can easily figure it out, just give me a few hours. (yes / no / not sure):");
            e = Console.ReadLine();
            Console.WriteLine("q6.) I break big projects down into smaller and more manageable steps. (yes / no / not sure):");
            f = Console.ReadLine();
            Console.WriteLine("q7.) When working towards a goal, I take the time I need to evaluate the strategies employed and the progress being made. (yes / no / not sure):");
            g = Console.ReadLine();
            Console.WriteLine("q8.) I can calm myself down when I'm under stress. (yes / no / not sure):");
            h = Console.ReadLine();
            Console.WriteLine("q9.) I am good at brainstorming. (yes / no / not sure):");
            i = Console.ReadLine();
            Console.WriteLine("q10.) It's okay when things don't go my way. (yes / no / not sure):");
            j = Console.ReadLine();



            userValue += calculateUser(a);
            userValue += calculateUser(b);
            userValue += calculateUser(c);
            userValue += calculateUser(d);
            userValue += calculateUser(e);
            userValue += calculateUser(f);
            userValue += calculateUser(g);
            userValue += calculateUser(h);
            userValue += calculateUser(i);
            userValue += calculateUser(j);

           


            if (userValue <= 30)
            {
                callName = "Victor-Lima";
                //Console.WriteLine("You are \" Victor-Lima \".");
            }
            else if (userValue > 30 && userValue <= 50)
            {
                callName = "Alpha-Lima";
                //Console.WriteLine("You are \" Alpha-Lima \".");
            }
            else if (userValue > 50 && userValue <= 70)
            {
                callName = "Alpha-Hotel";
                //Console.WriteLine("You are \" Alpha-Hotel \".");
            }
            else if (userValue > 70 && userValue <= 90)
            {
                callName = "Victor-Hotel";
                //Console.WriteLine("You are \" Victor-Hotel \".");
            }
            else if (userValue > 90)
            {
                callName = "99-Zulu!";
                //Console.WriteLine("You are \" 99-Zulu \".");
            }
            else
            {
                Console.WriteLine("You are \" There had been a problem with your score, please try again. \".");
            }

            Console.WriteLine("\nHello " + userName + ", please remember your \"Call Name\",  you will be grouped shortly.\n");
            Console.WriteLine("Your \"Call Name\" is: " + callName + ".\n");
            Console.WriteLine("\n\nDid you find this application useful? Please leave a comment:");
            string userFeedback = Console.ReadLine();

        }



        static int calculateUser(string userInput)
        {
            int score = 0;
            if (userInput == "yes")
            {
                return score += 10;
            }
            else if (userInput == "no")
            {
                return score -= 5;
            }
            else
            {
                return score -= 1;
            }
        }
    }

}
