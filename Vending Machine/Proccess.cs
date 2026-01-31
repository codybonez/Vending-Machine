using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public static class Proccess
    {


        public static void VendingMachineMenu()
        {
            string itemName ="";
                int vendingNumber = 0;
                bool isSelected = false;
            // choose path of choice
            string path = @"C:\Users\jamel\Downloads\Git_Vending.txt";
           
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
                                string createText = "Enjoy Your CocaCola" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your CocaCola" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("Pepsi", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your Pepsi" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Pepsi" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("RootBeer", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your RootBeer" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your RootBeer" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("Sprite", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your Sprite" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Sprite" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
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
                                string createText = "Enjoy Your Lays" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Lays" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                               string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                            isSelected = true;
                            }
                            else if (itemName.Equals("Pringles", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your Pringles" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Pringles" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("SunChips", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your SunChips" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your SunChips" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("Cheetos", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your Cheetos" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Cheetos" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
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
                                string createText = "Enjoy Your Snickers" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Snickers" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("Twix", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your Twix" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Twix" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("Reeses", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your Reeses" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Reeses" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("KitKat", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your KitKat" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your KitKat" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
                                isSelected = true;
                            }
                            else if (itemName.Equals("Oreos", StringComparison.OrdinalIgnoreCase))
                            {
                                string createText = "Enjoy Your Oreos" + Environment.NewLine;
                                File.WriteAllText(path, createText);
                                string appendText = "Enjoy Your Oroes" + Environment.NewLine;
                                File.AppendAllText(path, appendText);
                                string readText = File.ReadAllText(path);
                                Console.WriteLine(readText);
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
