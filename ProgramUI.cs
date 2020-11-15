using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ProgramUI
    {   
        public string[] list = 
        {
            "rock",
            "paper",
            "scissors"
        };

        Random random = new Random();

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Rock, Paper, Scissors!\n\n" +
                    "Press any key to continue...");

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("What would you like to do?\n\n" +
                    "Play\n" +
                    "Just hang out here and do NOTHING I guess..\n" +
                    "Quit\n\n\n");

                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "play":
                        PlayGame();
                        break;
                    case "quit":
                        keepRunning = false;
                        break;
                    default:
                        HangOut();
                        break;
                }
                Console.Clear();
            }
        }

        private void PlayGame()
        {
            Console.Clear();
            Console.WriteLine("Let's begin! Choose:\n" +
                "ROCK\n" +
                "PAPER\n" +
                "SCISSORS.");

            string input = Console.ReadLine().ToLower();
            Console.Clear();

            int index = random.Next(list.Length);;

            string compPick = list[index];

            if (input == "rock" && compPick == "scissors")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "You win! Take that technology!\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }
            else if (input == "rock" && compPick == "rock")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "Its a tie! What are the odds?\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }
            else if (input == "rock" && compPick == "paper")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "The Computer Gods have deemed it your fate to lose this time...\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }
            else if (input == "paper" && compPick == "paper")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "Its a tie! What are the odds?\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }
            else if (input == "paper" && compPick == "scissors")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "The Computer Gods have deemed it your fate to lose this time...\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }
            else if (input == "paper" && compPick == "rock")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "You win! Take that technology!\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }
            else if (input == "scissors" && compPick == "scissors")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "Its a tie! What are the odds?\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }
            else if (input == "scissors" && compPick == "rock")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "The Computer Gods have deemed it your fate to lose this time...\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }
            else if (input == "scissors" && compPick == "paper")
            {
                Console.WriteLine($"You chose {input} while the computer chose {compPick} \n\n" +
                    "You win! Take that technology!\n\n\n" +
                    "Would you like to:\n" +
                    "Retry\n" +
                    "or\n" +
                    "Go To Menu\n\n");
            }

            input = Console.ReadLine().ToLower();
            Console.Clear();

            switch (input)
            {
                case "retry":
                    PlayGame();
                    break;
                case "menu":
                    Menu();
                    break;
                case "go to menu":
                    Menu();
                    break;
                case "or":
                    Or();
                    break;
                default:
                    Console.WriteLine("My computer brain is too dumb and slow for what you just did. So I'm gonna just assume you said retry.");
                    Console.ReadKey();
                    PlayGame();
                    break;
            }

        }
        private void Or()
        {
            Console.Clear();
            Console.WriteLine("You found the EASTER\n\n" +
                "    eeeeeeeeeeee       ggggggggg   ggggg   ggggggggg   ggggg\n" +
                "  ee::::::::::::ee    g:::::::::ggg::::g  g:::::::::ggg::::g\n" +
                "e::::::eeeee:::::ee g:::::::::::::::::g g:::::::::::::::::g\n" +
                "e::::::e     e:::::eg::::::ggggg::::::ggg::::::ggggg::::::gg\n" +
                "e:::::::eeeee::::::eg:::::g     g:::::g g:::::g     g:::::g\n" +
                "e:::::::::::::::::e g:::::g     g:::::g g:::::g     g:::::g\n" +
                "e::::::eeeeeeeeeee  g:::::g     g:::::g g:::::g     g:::::g\n" +
                "e:::::::e           g::::::g    g:::::g g::::::g    g:::::g\n" +
                "e::::::::e          g:::::::ggggg:::::g g:::::::ggggg:::::g\n" +
                " e::::::::eeeeeeee   g::::::::::::::::g  g::::::::::::::::g\n" +
                "  ee:::::::::::::e    gg::::::::::::::g   gg::::::::::::::g\n" +
                "    eeeeeeeeeeeeee      gggggggg::::::g     gggggggg::::::g\n" +
                "                                g:::::g             g:::::g\n" +
                "                    gggggg      g:::::g gggggg      g:::::g\n" +
                "                    g:::::gg   gg:::::g g:::::gg   gg:::::g\n" +
                "                    g::::::ggg:::::::g  g::::::ggg:::::::g\n" +
                "                     gg:::::::::::::g    gg:::::::::::::g\n" +
                "                        ggg::::::ggg        ggg::::::ggg\n" +
                "                           gggggg              gggggg");

            Console.ReadKey();
            Menu();
        }
        private void HangOut()
        {
            Console.Clear();
            Console.WriteLine("Alrighty, you either put in some nonsense in or want to just hang out.\n" +
                            "Welp...\n\n\n\n\n\n\n" +
                            "Guess we're just gonna hang out then huh?\n" +
                            "Well just type 'QUIT' when you wanna go back to the menu.\n\n");
            Console.ReadLine();
            Console.WriteLine("Whoa whoa there partner! Trying to leave already???\n\n");
            Console.ReadKey();
            Console.WriteLine("Now now, lets not be too hasty. You came here to hang out and not play Rock Paper Scissors, remember??");

            string input = Console.ReadLine().ToLower();
            
            if (input.Contains("quit"))
            {
                Console.WriteLine("Wow, so eager to hang out and now you just wanna quit huh?\n\n" +
                    "Well FINE...\n" +
                    "...\n" +
                    "SEE IF I CARE!..");
            }
            else
            {
                Console.WriteLine("Well... I hadn't thought of that before.");
            }

            Console.Clear();
            Console.WriteLine("Well uh, you're cramping my style so you should probably leave now.");
            Console.ReadKey();
            Menu();
        }
    }
}
