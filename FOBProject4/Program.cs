using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOBProject4
{
    class Program
    {
        MemberInfo myMemberInfo = null;
        static void Main(string[] args)
        {
            
           myMemberInfo = new MemberInfo();
           

           Console.WriteLine("Enter your first name.");
           string sFirstName = Console.ReadLine();
           Console.WriteLine("Enter your last name.");
           string sLastName = Console.ReadLine();
           Console.WriteLine("What is your job position at your establishment?");
           string sJobPosition = Console.ReadLine();
           Console.WriteLine("How many years have you been in your current role at your establishment?");
           int iYearsAtEstab = int.Parse(Console.ReadLine());

            string sResult = myMemberInfo.MemberInfoAdd(sFirstName, sLastName, sJobPosition, iYearsAtEstab);
            Console.WriteLine(sResult);
            Console.ReadLine();
            Controller();
            
        }

            public static void Controller()
            {
             
            Console.WriteLine("Imaging the situation, you have just changed over your keg and now you are looking at the FOB.");
            Console.WriteLine("You have taken the training course, complete the readings, but which step do you take first?");
            Console.WriteLine("Do you 1- release the ball, 2 - vent the FOB or 3 -reset the pin?");
            Console.WriteLine("Please use the numerical value for your choice");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string nope = myMemberInfo.sNotVentFirst();
                Console.WriteLine(nope);
                Console.WriteLine("You should have vented the FOB.");
                Console.ReadLine();
                Controller();
            }
            else if (choice == 2) {
                string yes = myMemberInfo.sVentFirst();
                Console.WriteLine(yes);
                Console.ReadLine();
                

            }
            else if (choice == 3) {
                string notagain = myMemberInfo.sNotVentAgain();
                Console.WriteLine(notagain);
                Console.WriteLine(" You should have vented first.");
                Console.ReadLine();
                Controller();
            }
            else
            {
                
                string oops = "Please make a choice of one of the three options.";
                Console.WriteLine(oops);
                Console.ReadLine();
                Controller();
            }
                Controller2();
                
                
            }

            
            public static void Controller2()
            {
                MemberInfo myMemberInfo3 = new MemberInfo();
                Console.WriteLine("After venting the FOB, what should you do next?");
                Console.WriteLine("Should you 1 - reset the pin or 2 - release the ball? Please select a number.");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                string nope = myMemberInfo3.sSecondStepNotCorrect();
                Console.WriteLine(nope);
                Console.WriteLine("You should have released the ball.");
                Console.ReadLine();
                Controller2();
            }
            else if (selection == 2)
            {
                string alright = myMemberInfo3.sSecondStepCorrect();
                Console.WriteLine(alright);
            }else{
                string result = "Please make a choice of one of the two options. Press enter to continue.";
                Console.WriteLine(result);
                Console.ReadLine();
                Controller2();
            }
            Controller3();
          }

        public static void Controller3()
        {
            MemberInfo myMemberInfo4 = new MemberInfo();
            Console.WriteLine("After releasing the ball, what is the last thing you have to do? 1 - Reset the pin or 2-Vent again?");
            int option = int.Parse(Console.ReadLine());

            if (option==1){
                string yes3 = myMemberInfo4.sThirdStepCorrect();
                Console.WriteLine(yes3);
                Console.ReadLine();

            }else if(option ==2){
                string no3 = myMemberInfo4.sThirdStepNotCorrect();
                Console.WriteLine(no3);
                Console.ReadLine();
                Controller3();

            }else{
                string result = "Please make a choice of one of the two options.";
                Console.WriteLine(result);
                Console.ReadLine();
                Controller3();
            }
            Console.WriteLine("You have completed the trainer, press any key to close.");
            Console.ReadLine();
        }

     }
}
    
    

