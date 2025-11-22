using RadAR_Lib;
using OOP_Rad_Lib;
//using System.Threading;

class Program
{
    static void MainMenu(Banking.BankAccount account)
    {
        string? mainMenuOption;

        while (true)
        {
            Console.Clear();
            PageTitles.MainPageTitle();

            //Thread.Sleep(1500);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please choose an option:\n");

            MenuItemFormatter.PrintMenuItem(1, "Banking");
            MenuItemFormatter.PrintMenuItem(2, "Types of Inheritance");
            MenuItemFormatter.PrintMenuItem(3, "Abstraction Activities");
            MenuItemFormatter.PrintMenuItem(4, "Polymorphism Activities");
            MenuItemFormatter.PrintMenuItem(5, "Credits");
            MenuItemFormatter.PrintMenuItem(6, "Exit");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------\n");

            //Thread.Sleep(1500);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("<RAD_IND> ");
            Console.ForegroundColor = ConsoleColor.White;
            mainMenuOption = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            if (mainMenuOption == "1" || "banking".Equals(mainMenuOption, StringComparison.OrdinalIgnoreCase))
            {
                string? bankMenuOption;

                while (true)
                {
                    Console.Clear();
                    PageTitles.BankingPageTitle();

                    //Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose an option:\n");

                    MenuItemFormatter.PrintMenuItem(1, "Deposit");
                    MenuItemFormatter.PrintMenuItem(2, "Withdraw");
                    MenuItemFormatter.PrintMenuItem(3, "Balance");
                    MenuItemFormatter.PrintMenuItem(4, "Expected Output");
                    MenuItemFormatter.PrintMenuItem(5, "Return");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------\n");

                    //Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("<RAD_IND> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    bankMenuOption = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (bankMenuOption == "1" || "deposit".Equals(bankMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.BankingPageTitle();
                        Banking.HandleDeposit(account);
                        Console.WriteLine("");
                        //Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine(); Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (bankMenuOption == "2" || "withdraw".Equals(bankMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.BankingPageTitle();
                        Banking.HandleWithdraw(account);
                        Console.WriteLine("");
                        //Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (bankMenuOption == "3" || "balance".Equals(bankMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.BankingPageTitle();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("==============================");
                        account.GetBalance();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("==============================");
                        Console.WriteLine("");
                        //Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (bankMenuOption == "4" || "expected output".Equals(bankMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.BankingPageTitle();
                        Console.WriteLine("Expected Output:");
                        //Thread.Sleep(1000);
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("==============================");
                        account.Deposit(1000);
                        account.Withdraw(200);
                        account.GetBalance();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("==============================");
                        Console.WriteLine("");
                        //Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (bankMenuOption == "5" || "return".Equals(bankMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Invalid option. ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Please try again.\n");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                }
            }
            else if (mainMenuOption == "2" || "types of inheritance".Equals(mainMenuOption, StringComparison.OrdinalIgnoreCase))
            {
                string? toiMenuOption;

                while (true)
                {
                    Console.Clear();
                    PageTitles.ToIPageTitle();

                    //Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose an option:\n");

                    MenuItemFormatter.PrintMenuItem(1, "Single Inheritance");
                    MenuItemFormatter.PrintMenuItem(2, "Multiple Inheritance");
                    MenuItemFormatter.PrintMenuItem(3, "Multilevel Inheritance");
                    MenuItemFormatter.PrintMenuItem(4, "Hierarchical Inheritance");
                    MenuItemFormatter.PrintMenuItem(5, "Hybrid Inheritance");
                    MenuItemFormatter.PrintMenuItem(6, "Return");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------\n");

                    //Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("<RAD_IND> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    toiMenuOption = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (toiMenuOption == "1" || "single inheritance".Equals(toiMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.ToIPageTitle();

                        Console.WriteLine("SINGLE INHERITANCE - A subclass inherits from only one superclass. This is the simplest and most common form of inheritance.");
                        Console.WriteLine("");
                        Console.WriteLine("class Animal { 'Hungers' }");
                        Console.WriteLine("class Dog : Animal { 'Barks' }");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (toiMenuOption == "2" || "multiple inheritance".Equals(toiMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.ToIPageTitle();

                        Console.WriteLine("MULTIPLE INHERITANCE - A subclass inherits from multiple superclasses, acquiring features from all of them.");
                        Console.WriteLine("");
                        Console.WriteLine("Unfortunately C# does not allow a class to inherit from multiple parent classes directly. So a solution I've found is to use Interfaces.");
                        Console.WriteLine("");
                        Console.WriteLine("interface ICanFly { void Fly(); }");
                        Console.WriteLine("interface ICanSwim { void Swim(); }");
                        Console.WriteLine("class Duck : ICanFly, ICanSwim { 'Can both Swim and Fly' }");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (toiMenuOption == "3" || "multilevel inheritance".Equals(toiMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.ToIPageTitle();

                        Console.WriteLine("MULTILEVEL INHERITANCE - A chain of inheritance where a class inherits from a subclass, which in turn inherited from another class.");
                        Console.WriteLine("");
                        Console.WriteLine("class Animal { 'Hungers' }");
                        Console.WriteLine("class Dog : Animal { 'Barks' }");
                        Console.WriteLine("class Labrador : Dog { 'Has Brown Fur' }");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (toiMenuOption == "4" || "hierarchical inheritance".Equals(toiMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.ToIPageTitle();

                        Console.WriteLine("HIERARCHICHAL INHERITANCE - Multiple subclasses inherit from a single superclass.");
                        Console.WriteLine("");
                        Console.WriteLine("class Animal { 'Hungers' }");
                        Console.WriteLine("class Dog : Animal { 'Barks' }");
                        Console.WriteLine("class Cat : Animal { 'Meows' }");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (toiMenuOption == "5" || "hybrid inheritance".Equals(toiMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.ToIPageTitle();

                        Console.WriteLine("HYBRID INHERITANCE - A combination of two or more of the above types of inheritance within a single program. This can involve a mix of single, multiple, or multilevel inheritance structures.");
                        Console.WriteLine("");
                        Console.WriteLine("Multilevel and Hierarchical:");
                        Console.WriteLine("");
                        Console.WriteLine("class Animal { 'Hungers' }");
                        Console.WriteLine("class Dog : Animal { 'Barks' }");
                        Console.WriteLine("class Labrador : Dog { 'Has Brown Fur' }");
                        Console.WriteLine("class Cat : Animal { 'Meows' }");
                        Console.WriteLine("class Siamese : Cat { 'Has White Fur' }");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (toiMenuOption == "6" || "return".Equals(toiMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Invalid option. ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Please try again.\n");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                }
            }
            else if (mainMenuOption == "3" || "abstraction activities".Equals(mainMenuOption, StringComparison.OrdinalIgnoreCase))
            {
                string? aaMenuOption;

                while (true)
                {
                    Console.Clear();
                    PageTitles.AAPageTitle();

                    //Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose an option:\n");

                    MenuItemFormatter.PrintMenuItem(1, "Activity 1");
                    MenuItemFormatter.PrintMenuItem(2, "Activity 2");
                    MenuItemFormatter.PrintMenuItem(3, "Activity 3");
                    MenuItemFormatter.PrintMenuItem(4, "Expected Output");
                    MenuItemFormatter.PrintMenuItem(5, "Return");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------\n");

                    //Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("<RAD_IND> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    aaMenuOption = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (aaMenuOption == "1" || "activity 1".Equals(aaMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.AAPageTitle();

                        AbstractionActs.ActivityDescription.ActDesc1();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Output:");
                        Console.WriteLine("");
                        AbstractionActs.ActivityOutput.Activity1.ActOut1();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (aaMenuOption == "2" || "activity 2".Equals(aaMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.AAPageTitle();

                        AbstractionActs.ActivityDescription.ActDesc2();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Output:");
                        Console.WriteLine("");
                        AbstractionActs.ActivityOutput.ActOut2();
                        Console.WriteLine("");
                        AbstractionActs.AbstractionActsExamples.RunExample();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (aaMenuOption == "3" || "activity 3".Equals(aaMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.AAPageTitle();

                        AbstractionActs.ActivityDescription.ActDesc3();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Output:");
                        Console.WriteLine("");
                        AbstractionActs.ActivityOutput.Activity3.ActOut3();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (aaMenuOption == "4" || "expected output".Equals(aaMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.AAPageTitle();

                        AbstractionActs.ActivityOutput.ExpectedOutput.ExpOut();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (aaMenuOption == "5" || "return".Equals(aaMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Invalid option. ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Please try again.\n");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                }
            }
            else if (mainMenuOption == "4" || "polymorphism activities".Equals(mainMenuOption, StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                PageTitles.MainPageTitle();

                string? paMenuOption;

                while (true)
                {
                    Console.Clear();
                    PageTitles.PAPageTitle();

                    //Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please choose an option:\n");

                    MenuItemFormatter.PrintMenuItem(1, "Activity 4");
                    MenuItemFormatter.PrintMenuItem(2, "Activity 5");
                    MenuItemFormatter.PrintMenuItem(3, "Activity 6");
                    MenuItemFormatter.PrintMenuItem(4, "Expected Output");
                    MenuItemFormatter.PrintMenuItem(5, "Return");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----------------------------------------\n");

                    //Thread.Sleep(1500);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("<RAD_IND> ");
                    Console.ForegroundColor = ConsoleColor.White;
                    paMenuOption = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (paMenuOption == "1" || "activity 4".Equals(paMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.PAPageTitle();

                        PolymorphismActs.ActivityDescription.ActDesc4();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Output:");
                        Console.WriteLine("");
                        PolymorphismActs.ActivityOutput.Activity4.ActOut4();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (paMenuOption == "2" || "activty 5".Equals(paMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.PAPageTitle();

                        PolymorphismActs.ActivityDescription.ActDesc5();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Output:");
                        Console.WriteLine("");
                        //PolymorphismActs.ActivityOutput.Activity5.ActOut5();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (paMenuOption == "3" || "activty 6".Equals(paMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Clear();
                        PageTitles.PAPageTitle();

                        PolymorphismActs.ActivityDescription.ActDesc6();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Output:");
                        Console.WriteLine("");
                        PolymorphismActs.ActivityOutput.Activity6.ActOut6();
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                    else if (paMenuOption == "4" || "expected output".Equals(paMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        
                    }
                    else if (paMenuOption == "5" || "return".Equals(paMenuOption, StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Invalid option. ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Please try again.\n");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Press ENTER to return.");
                        Console.ReadLine();
                    }
                }
            }
            else if (mainMenuOption == "5" || "credits".Equals(mainMenuOption, StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                PageTitles.MainPageTitle();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("                       --------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("CREDITS");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("--------------------------------------                        \n");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                                                  C# OOP OUTPUTS CONSOLE APP BY:                                                  ");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                                          RadioActive R                                                           ");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("                                                              A.K.A.                                                              ");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                                  Richard Cornelius V. Timosa II                                                  ");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                       -----------------------------------------------------------------------------------                        ");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Press ENTER to return.");
                Console.ReadLine();
            }
            else if (mainMenuOption == "6" || "exit".Equals(mainMenuOption, StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                PageTitles.MainPageTitle();

                Console.WriteLine("Exiting...");
                Console.ResetColor();
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Invalid option. ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Please try again.\n");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Press ENTER to return.");
                Console.ReadLine();
            }
        }
    }
    static void Main(string[] args)
    {
        //Thread.Sleep(3000);
        Banking.BankAccount account = new Banking.BankAccount();
        MainMenu(account);
    }
}
