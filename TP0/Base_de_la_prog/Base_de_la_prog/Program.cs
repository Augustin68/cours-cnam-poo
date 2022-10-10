using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menuNumber;

            do
            {
                Console.WriteLine("Hello World!");

                String firstName = AskTextUserInput("Donne moi ton prénom, vil chenapan :");

                String name = AskTextUserInput("Et quel est ton nom, petit galopin :");


                Console.WriteLine("Bonjour " + FormatUserName(name, firstName) + " !");

                int size = AskNumberUserInput("Quel est ta taille ? (cm)");
                int weight = AskNumberUserInput("Quel est ton poids ? (kg)");
                int age = AskNumberUserInput("Quel est ton âge ? (années)");

                if (age < 18)
                {
                    Console.WriteLine("bouuh il a pas 18 ans lol. G pas envie de me moquer de toi mais bon le TP m'y oblige alors va te faire, t'es trop nul.");
                }

                Console.WriteLine("Ton IMC est " + GetBMI(size, weight).ToString("0.0"));
                WarnUserAboutBMI(GetBMI(size, weight));

                bool isHairGuessValid = false;
                do
                {
                    Console.WriteLine("A ton avis, combien de cheveux tu as sur la tête ?");
                    string hairGuess = Console.ReadLine();
                    int hairValue;
                    if (int.TryParse(hairGuess, out hairValue))
                    {
                        if (hairValue >= 100_000 && hairValue <= 150_000)
                        {
                            isHairGuessValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Je pense pas que c'est ça.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ecris un nombre gros batard.");
                    }
                } while (!isHairGuessValid);


                do
                {
                    Console.WriteLine("Que voulez vous faire à présent ?");
                    Console.WriteLine("1 - Quitter le programme");
                    Console.WriteLine("2 - Recommencer le programme");
                    Console.WriteLine("3 - Compter jusqu’à 10");
                    Console.WriteLine("4 - Téléphoner à Tata Jacqueline");
                    menuNumber = AskNumberUserInput("Entrez un des chiffre des choix si dessus :");
                } while (menuNumber < 1 || menuNumber > 4);

                switch (menuNumber)
                {
                    case 1:
                        ExitMessages();
                        break;
                    case 2:
                        Console.WriteLine("Redémarrage du programme...");
                        break;
                    case 3:
                        Console.WriteLine("=========");
                        CountOneToTen();
                        ExitMessages();
                        break;
                    case 4:
                        Console.WriteLine("BIP BIP BIP");
                        Console.WriteLine("Tata Jacqueline n'est pas disponible, elle prépare une tarte.");
                        ExitMessages();
                        break;
                }
            } while (menuNumber == 2);
            return;
        }
            
        static void CountOneToTen()
        {
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);

            }
        }

        static void ExitMessages()
        {
            Console.WriteLine("Fermeture en cours...");
            Console.WriteLine("Merci d'être passé !");
            Thread.Sleep(3000);
        }

        static String AskTextUserInput(String message)
        {
            bool isStringValid = false;
            string userString = "";
            do
            {
                Console.WriteLine(message);
                userString = Console.ReadLine();
                if (!userString.Any(char.IsDigit))
                {
                    isStringValid = true;
                } 
                else
                {
                    Console.WriteLine("Ne met pas de chiffre dans ton texte :))");
                }
            } while (!isStringValid);
            return userString;
        }

        static int AskNumberUserInput(String message)
        {
            bool isNumberValid = false;
            int userNumber;
            do
            {
                Console.WriteLine(message);
                String userInput = Console.ReadLine();
                if(int.TryParse(userInput, out userNumber)){
                    if (userNumber >= 0)
                    {
                        isNumberValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Entre un nombre positif :)");
                    }
                }
                else
                {
                    Console.WriteLine("Entre un nombre !!!");
                }
            } while (!isNumberValid);
            return userNumber;
        }

        static string FormatUserName(String name, String firstName)
        {
            return firstName + " " + name.ToUpper();
        }

        static float GetBMI(int size, int weight)
        {
            return weight / (float)Math.Pow((float)size/100, 2);
        }

        static void WarnUserAboutBMI(float BMI)
        {
            const String anorexie = "Attention à l’anorexie !";
            const String maigrichon = "Vous êtes un peu maigrichon !";
            const String normal = "Vous êtes de corpulence normale !";
            const String surpoids = "Vous êtes en surpoids !";
            const String obeseModere = "Obésité modérée !";
            const String obeseSevere = "Obésité sévère !";
            const String obeseMorbide = "Obésité morbide !";

            if(BMI < 16.5)
            {
                Console.WriteLine(anorexie);
            } 
            else if (BMI >= 16.5 && BMI < 18.5)
            {
                Console.WriteLine(maigrichon);
            }
            else if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine(normal);
            }
            else if(BMI >= 25 && BMI < 30)
            {
                Console.WriteLine(surpoids);
            }
            else if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine(obeseModere);
            }
            else if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine(obeseSevere);
            }
            else
            {
                Console.WriteLine(obeseMorbide);
            }
        }
    }
}