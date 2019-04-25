using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/************************************************************************************************************************************
 Add a functionality that prevents error input from the user for the answers to the question such that when the user inputs an 
 answer other than A,B,C,D it gets an error message
 ************************************************************************************************************************************/
namespace QuizApp
{
    class Program
    {
        static int result;
        static string name, address, age;
        static string[] answers = { "A", "B", "B", "B", "D", "B", "B", "A", "A", "A" };
        static string q1 = @"
1.      Grand Central Terminal, Park Avenue, New York is the world's

A.	largest railway station
B.	highest railway station
C.	longest railway station
D.	None of the above
                ";

        static string q2 = @"
2. 	Entomology is the science that studies

A.	Behavior of human beings
B.	Insects
C.	The origin and history of technical and scientific terms
D.	The formation of rocks
                ";

static string q3 = @"
3. 	Eritrea, which became the 182nd member of the UN in 1993, is in the continent of

A.	Asia
B.	Africa
C.	Europe
D.	Australia
";

static string q4 = @"
4. 	Garampani sanctuary is located at

A.	Junagarh, Gujarat
B.	Diphu, Assam
C.	Kohima, Nagaland
D.	Gangtok, Sikkim
";

static string q5 = @"
5. 	For which of the following disciplines is Nobel Prize awarded?

A.	Physics and Chemistry
B.	Physiology or Medicine
C.	Literature, Peace and Economics
D.	All of the above
";

static string q6 = @"
6. 	Hitler party which came into power in 1933 is known as

A.	Labour Party
B.	Nazi Party
C.	Ku-Klux-Klan
D.	Democratic Party
";

static string q7 = @"
7. 	FFC stands for

A.	Foreign Finance Corporation
B.	Film Finance Corporation
C.	Federation of Football Council
D.	None of the above";
                            

static string q8 = @"
8. 	Fastest shorthand writer was

A.	Dr. G. D. Bist
B.	J.R.D. Tata
C.	J.M. Tagore
D.	Khudada Khan
";

static string q9 = @"
9. 	Epsom (England) is the place associated with

A.	Horse racing
B.	Polo
C.	Shooting
D.	Snooker
";

static string q10 = @"
10.     First human heart transplant operation conducted by Dr. Christiaan Barnard on Louis Washkansky, was conducted in

A.	1967
B.	1968
C.	1958
D.	1922
";

        static void Main(string[] args)
        {
            int counter = 1;
            InitDisplay();
        interval:
            QuestionDisplay();
            Console.ReadLine();
            
            //allows for the test to be taken three times
            if (counter < 3)
            {
                ++counter;
                goto interval;
            }
        }

        static void InitDisplay()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("\t Quiz App 1.0");
            Console.WriteLine("*******************************");
            Console.WriteLine("Input your name, address and age");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Address: ");
            address = Console.ReadLine();
            Console.Write("Age: ");
            age = Console.ReadLine();
            Console.WriteLine($"{name.ToUpper()}, welcome to the quiz app. Press enter to start the quiz");
            Console.ReadLine();
            return;
        }

        static void QuestionDisplay()
        {
            //intializes result to zero once the questions start to display all over again
            result = 0;
            

            Console.WriteLine($"{q1}");
            //To show an answer prompts
            //Console.Write("Answer: ");
            string answer1 = Console.ReadLine();
            Scoring(answer1, 0);

            Console.WriteLine($"{q2}");
            string answer2 = Console.ReadLine();
            Scoring(answer2, 1);

            Console.WriteLine($"{q3}");
            string answer3 = Console.ReadLine();
            Scoring(answer3, 2);

            Console.WriteLine($"{q4}");
            string answer4 = Console.ReadLine();
            Scoring(answer4, 3);

            Console.WriteLine($"{q5}");
            string answer5 = Console.ReadLine();
            Scoring(answer5, 4);

            Console.WriteLine($"{q6}");
            string answer6 = Console.ReadLine();
            Scoring(answer6, 5);

            Console.WriteLine($"{q7}");
            string answer7 = Console.ReadLine();
            Scoring(answer7, 6);

            Console.WriteLine($"{q8}");
            string answer8 = Console.ReadLine();
            Scoring(answer8, 7);

            Console.WriteLine($"{q9}");
            string answer9 = Console.ReadLine();
            Scoring(answer9, 8);

            Console.WriteLine($"{q10}");
            string answer10 = Console.ReadLine();
            Scoring(answer10, 9);

            Console.WriteLine("Test Completed!");
            //time delay here would be nice
            Console.WriteLine($"{name.ToUpper()}, you scored {result} out of 10! ");
                
        }

        static void Scoring(string response, int questionIndex)
        {
            if (response.ToUpper() == "A" || response.ToUpper() == "B" || response.ToUpper() == "C" || response.ToUpper() == "D" )
            {
                if (response.ToUpper() == answers[questionIndex])
                    result += 1;
            }
           /* else
            {
                ErrorFunction();
            }*/
      
            return;
        }

        /*static void ErrorFunction()
        {
            Console.WriteLine("Input either A or B or C or D as your answer");
            goto continueQuestion;
        }*/

    }
}
