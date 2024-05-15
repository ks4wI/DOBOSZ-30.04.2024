while (true)
{
    Console.WriteLine("<-----MENU----->");
    Console.WriteLine("Wybierz opcje:");
    Console.WriteLine("1. ");
    Console.WriteLine("2. ");
    Console.WriteLine("3. ");
    Console.WriteLine("4. Wyjscie");
    Console.WriteLine("<--------------->");
    string wybor = Console.ReadLine();
    switch (wybor)
    {
        case "1":
            Console.WriteLine("<-----1----->");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. Wyjscie");
            Console.WriteLine("<--------------->");
            string wybor1 = Console.ReadLine();
            switch (wybor1)
            {
                case "1":
                    
                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":
                    break;
                case "5":
                    Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("nieprawidlowy wybor");
                    break;
            }
            break;

        case "2":
            Console.WriteLine("<-----2----->");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. Wyjscie");
            Console.WriteLine("<--------------->");
            string wybor2 = Console.ReadLine();
            switch (wybor2)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":

                    break;
                case "4":

                    break;
                case "5":
                    Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("nieprawidlowy wybor");
                    break;
            }
            break;
        case "3":
            Console.WriteLine("<-----3----->");
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            Console.WriteLine("3. Wyjscie");
            Console.WriteLine("<--------------->");
            string wybor3 = Console.ReadLine();
            switch (wybor3)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "3":
                    Console.WriteLine("Porgram zostanie zamkniety"); Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("nieprawidlowy wybor");
                    break;
            }
            break;

        case "4":
            Console.WriteLine("Program zostanie zamkniety"); Environment.Exit(0);
            break;
        default:
            Console.WriteLine("nieprawidlowy wybor");
            break;

    }
}