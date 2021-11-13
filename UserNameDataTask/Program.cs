using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //programm käsib kasutajalt eesnime;
                //programm käsib kasutajal sisestada number 1-3;
                //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi;
                //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimene täht;
                //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkus;

                Console.WriteLine("Sisesta oma eesnimi:");
                string userName = Console.ReadLine();

                Console.WriteLine("Sisesta number 1-3:");
                char userChoice = Convert.ToChar(Console.ReadLine());

                switch (userChoice)
                {
                    case '1':
                        ReverseName(userName);
                        break;

                    case '2':
                        FirstLetter(userName);
                        break;

                    case '3':
                        Counter(userName);
                        break;

                    default:
                        Console.WriteLine("Kena päeva!");
                        break;
                }

            }
        }

        private static void Counter(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }

        private static void ReverseName(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        private static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }
    }
}
