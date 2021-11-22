using System;
using System.Threading;

namespace demonstration {
    class Program {
        public static int socialCredit = -999;
        public static void FailureGame() {
            
            socialCredit = -30000000;
            DateTime tomorrowsDate = DateTime.Today.AddDays(1);
            Console.WriteLine($"FAILURE! 😱😱😱\nYOU FAILED THE QUIZ! 🤣😂🤣\nFINAL SOCIAL CREDIT: {socialCredit} 😘😊😘\nYOUR DATE OF EXECUTION IS {tomorrowsDate}");
            Console.ReadKey();
            System.Environment.Exit(0);

        }

        public static void CheckCorrect(int correctAns) {

            int ansReturned = Convert.ToInt32(Console.ReadLine());
            if ( ansReturned != correctAns) {
                FailureGame();
            }
        }

        public static void EndingScene() {
            
            DateTime tomorrowsDate = DateTime.Today.AddDays(1);
            socialCredit = -30000000;
            Console.WriteLine($"OUR NETWORKS HAVE DETECTED YOU USING A VPN TO TAIWAN!\nNEW SOCIAL CREDIT SCORE: {socialCredit}\nDATE OF EXECUTION: {tomorrowsDate}");
            Console.ReadKey();
            System.Environment.Exit(0);
        }
        
        public static void Main(string[] args) {   

            Console.WriteLine("Citizen! You have very low social credit! To gain social credit, complete the test!");
            Console.WriteLine("Are you ready to begin the test?");
            
            
            while (true) {
                
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. Yes");
                
                string checkValid = Console.ReadLine();

                try {
                    
                    Convert.ToInt32(checkValid);
                } catch (Exception) {
                    
                    Console.WriteLine("\nYes or yes, Citizen!");
                    continue;
                }

                break; 

            }

            Console.WriteLine($"Current social credit score: {socialCredit}");
            Console.WriteLine("\nQuestion 1: Who is the best person on earth?\n1. Everyone\n2. No one\n3. John Xina\n4. President Xi Jinping\n");
            
            CheckCorrect(4);
        
            socialCredit += 15;
            Console.WriteLine($"Good job, citizen!\nCurrent social credit score: {socialCredit}\n");
            Console.WriteLine("\nQuestion 2: What happened in Tiananmen Square on April 15, 1989?\n\n1. Nothing\n2. Something");

            CheckCorrect(1);

            socialCredit += 300;
            Console.WriteLine($"Good job, citizen!\nCurrent social credit score: {socialCredit}\n");
            Console.WriteLine("\nQuestion3: Is Taiwan an independent country?\n1: Yes\n2: No");

            CheckCorrect(2);

            socialCredit += 900;
            Console.WriteLine($"Good job, citizen!\nCurrent social credit score: {socialCredit}\n");
            Console.WriteLine("\nQuestion 4: How many kids do you have?\n1: One\n2: Two or more\n3: None");

            CheckCorrect(1);

            socialCredit += 1200;
            Console.WriteLine($"Congratulations citizen! You have passed the test! Your new social credit score: {socialCredit}");
            Thread.Sleep(3000);
            EndingScene();
        }
    }
}