using System;
using System.Collections;
using System.Collections.Generic;

namespace TestProject
{
    class Cars
    {
        private String model;
        private String brand;
        private int price;
        private String condition; // brandnew or 2nd hand

        public int getPrice()
        {
            return this.price;
        }
        public String getModel()
        {
            return this.model;
        }
        public String getCondtion()
        {
            return this.condition;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public void setModel(String model)
        {
            this.model = model;
        }
        public void setCondtion(String condition)
        {
            this.condition = condition;
        }
        public String getBrand()
        {
            return this.brand;
        }
        public void setBrand(String brand)
        {
            this.brand = brand;
        }
    }
    
    class Toyota : Cars
    {
        public Toyota(String model, String condition)
        {
            setModel(model);
            setCondtion(condition);
        }

        private String customStickerColor;

        public void setCustomStickerColor(String color)
        {
            this.customStickerColor = color;
        }

        public String getCustomStickerColor()
        {
            return this.customStickerColor;
        }
        
    }
    
    class Mitsubishi : Cars
    {
        private Boolean isTransformable;
        public Mitsubishi(String model, String condition, Boolean isTransformable)
        {
            setModel(model);
            setCondtion(condition);
            this.isTransformable = isTransformable;
        }
        
    }

    class Tesla : Cars
    {
        private Boolean isElectric;
        public Tesla(String model, String condition, Boolean isElectric)
        {
            setModel(model);
            setCondtion(condition);
            this.isElectric = isElectric;
        }
        
    }
    
    class Program
    {
        static List<Cars> carList = new List<Cars>();
        static void Main(string[] args)
        {
            buyWindow();
            showCart();
        }

        static void buyWindow()
        {
            String itemChoice;
            String modelName;
            String condition;
            String isUnique;
            Boolean again = true;
            String buyAgain;
            int itemCount = 0;
            int toyotaCount = 1;
            int teslaCount = 1;
            int mitsubishiCount = 1;
            String[] cars = new string[] {"Tesla","Toyota", "Mitsubishi"};
            
                Console.WriteLine("Welcome to our Car Dealership");
            while (again)
            {
                Console.WriteLine("Here are the list of our cars");
                for (int i = 0; i < cars.Length; i++)
                {
                    Console.WriteLine(cars[i]);
                }
                Console.Write("What would you like to buy? ");
                itemChoice = Console.ReadLine().ToLower();
                    if (itemChoice == "tesla")
                    {
                        Console.Write("Enter model name: ");
                        modelName = Console.ReadLine();
                        Console.Write("What condition do you prefer? ");
                        condition = Console.ReadLine();
                        Console.Write("Would you like your car to be electric? Y/N ");
                        isUnique = Console.ReadLine().ToLower();

                        if (isUnique == "y" || isUnique == "yes")
                        {
                            Tesla tesla = new Tesla(modelName,condition, true);
                            tesla.setBrand($"Tesla{teslaCount}");
                            carList.Add(tesla);
                            teslaCount++;
                            itemCount++;
                        }
                    }
                    else if (itemChoice == "mitsubishi")
                    {
                        Console.Write("Enter model name: ");
                        modelName = Console.ReadLine();
                        Console.Write("What condition do you prefer? ");
                        condition = Console.ReadLine();
                        Console.Write("Would you like your car to transform? Y/N ");
                        isUnique = Console.ReadLine().ToLower();

                        if (isUnique == "y" || isUnique == "yes")
                        {
                            Mitsubishi mitsubishi = new Mitsubishi(modelName, condition, true);
                            mitsubishi.setBrand($"Mitsubishi{mitsubishiCount}");
                            carList.Add(mitsubishi);
                            mitsubishiCount++;
                            itemCount++;
                        }
                    }
                    else if (itemChoice == "toyota")
                    {
                        Console.Write("Enter model name: ");
                        modelName = Console.ReadLine();
                        Console.Write("What condition do you prefer? ");
                        condition = Console.ReadLine();
                        Console.Write("Enter a color for your sticker: ");
                        isUnique = Console.ReadLine().ToLower();

                        Toyota toyota = new Toyota(modelName, condition);
                        toyota.setCustomStickerColor(isUnique);
                        toyota.setBrand($"Toyota{toyotaCount}");
                        carList.Add(toyota);
                        toyotaCount++;
                        itemCount++;
                }
                    else {
                        Console.WriteLine("Sorry, your car is currently not available");
                    }
                Console.Write("Would you like to buy another car? Y/N ");
                buyAgain = Console.ReadLine().ToLower();
                    if (buyAgain == "n" || buyAgain == "no")
                    {
                        again = false;
                    }
                    
                    else { 
                        
                    }
                    
            }
        }
        static void showCart()
        {
            for(int i = 0; i<carList.Count; i++)
            {
                Console.WriteLine(carList[i].getBrand());
            }
        }
    }
}
