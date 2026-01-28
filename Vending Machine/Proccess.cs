using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public static class Proccess
    {
<<<<<<< Updated upstream


=======
>>>>>>> Stashed changes
        public static void VendingMachineMenu()
        {
            string itemName ="";
                int vendingNumber = 0;
                bool isSelected = false;

            string time = DateTime.Now.ToString("MM-dd-yyyy");
            string path = "logs";
            string fileName = "log.txt";

            if (!string.IsNullOrWhiteSpace(path) && !Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists($"{path}/{fileName}"))
            {
                File.Create($"{path}/{fileName}");
            }

            do
            {
                Console.WriteLine("Select number for vending machine 1 = sodas, 2 = Chips, 3 = Candy, and 4 = Exit");
                vendingNumber = Int32.Parse(Console.ReadLine());
                switch (vendingNumber)
                {
                    case 1:
                        
                        
                            Console.WriteLine("\nSelect soda [CocaCola, Pepsi, RootBeer]");
                            itemName = Console.ReadLine();
                            if (itemName.Equals("CocaCola", StringComparison.OrdinalIgnoreCase))
                            {
                                File.AppendAllText($"{path}/{fileName}", $"Added CocaCola at {time}");
                                Console.WriteLine("Enjoy your CocaCola");
                                isSelected = true;
                            }
                            else if (itemName.Equals("Pepsi", StringComparison.OrdinalIgnoreCase))
                            {
                                File.AppendAllText($"{path}/{fileName}", $"Added Pepsi at {time}");
                                Console.WriteLine("Enjoy your Pepsi");
                                isSelected = true;
                            }
                            else if (itemName.Equals("RootBeer", StringComparison.OrdinalIgnoreCase))
                            {
                                File.AppendAllText($"{path}/{fileName}", $"Added RootBeer at {time}");
                                Console.WriteLine("Enjoy your RootBeer");
                                isSelected = true;
                            }
                            else if (itemName.Equals("Sprite", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your Sprite");
                                isSelected = true;
                            }
                            else
                            {
                                Console.WriteLine("Not the correct soda in the vending machine, going back.");
                                isSelected = false;
                            }
                        
                        break;

                    case 2:
                    
                         Console.WriteLine("\nSelect chips [Lays, Pringles, SunChips]");
                            itemName = Console.ReadLine();
                            if (itemName.Equals("Lays", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your Lays");
                                isSelected = true;
                            }
                            else if (itemName.Equals("Pringles", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your Pringles");
                                isSelected = true;
                            }
                            else if (itemName.Equals("SunChips", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your SunChips");
                                isSelected = true;
                            }
                            else if (itemName.Equals("Cheetos", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your Cheetos");
                                isSelected = true;
                            }
                            else
                            {
                                Console.WriteLine("Not the correct chips in the vending machine, going back.");
                                isSelected = false;
                            }
                        
                        break;
                    case 3:

                            Console.WriteLine("\nSelect Candy [Snickers, Twix, Reeses]");
                            itemName = Console.ReadLine();
                            if (itemName.Equals("Snickers", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your Snickers");
                                isSelected = true;
                            }
                            else if (itemName.Equals("Twix", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your Twix");
                                isSelected = true;
                            }
                            else if (itemName.Equals("Reeses", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your Reeses");
                                isSelected = true;
                            }
                            else if (itemName.Equals("KitKat", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your KitKat");
                                isSelected = true;
                            }
                            else if (itemName.Equals("Oreos", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Enjoy your Oroes");
                                isSelected = true;
                            }
                            else
                            {
                                Console.WriteLine("Not the correct candy in the vending machine, going back.");
                                isSelected = false;
                            }
                        break;


                            case 4:
                        Console.WriteLine("Exiting vending machine");
                        break;

                    default:

                        Console.WriteLine("Not in the vending machine, please try again.");
                        break;

                }
            } while (vendingNumber != 4);
        }

    }
}
