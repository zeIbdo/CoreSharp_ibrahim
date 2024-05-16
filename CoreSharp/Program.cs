namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;

            while (true)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                string operatorName;
                int size;
                string color;
                string brandName;
                string category;
                decimal price;
                decimal count;
                string loopTerminationResult;

                #region Operator name validaiton

                while (true)
                {
                    Console.Write("Operator's name : ");
                    operatorName = Console.ReadLine();

                    if (operatorName.Length >= 3 && operatorName.Length <= 15)
                        break;
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Size validation

                while (true)
                {
                    Console.Write("Size : ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50)
                        break;
                    else
                        Console.WriteLine("Size dugun daxil edilmeyib");
                }

                #endregion

                #region Color validation

                while (true)
                {
                    Console.Write("Color(aviable colors are \"Red\", \"Blue\", \"Black\"): ");
                    color = Console.ReadLine();
                    if (color == "Red" || color == "Black" || color == "Blue")
                        break;
                    else
                        Console.WriteLine("Reng duzgun daxil edilmeyib");

                }

                #endregion
                #region Brand name validation
                while (true)
                {
                    Console.Write("Brand name(brand names are \"Adidas\", \"Nike\" and \"Kappa\") : ");
                    brandName = Console.ReadLine();
                    if (brandName == "Adidas" || brandName == "Nike" || brandName == "Kappa")
                        break;
                    else
                        Console.WriteLine("Marka duzgun daxil edilmeyib");
                }
                #endregion
                #region Category validation
                while (true)
                {
                    Console.Write("Category(categories are \"Sport\", \"Classic\" and \"Slippers\") : ");
                    category = Console.ReadLine(); //Short cut to replace all : Ctrl + RR
                    if (category == "Sport" || category == "Classic" || category == "Slippers")
                        break;
                    else
                        Console.WriteLine("Kateqoriya duzgun daxil edilmeyib");
                }
                #endregion
                #region Price validation
                while (true)
                {
                    Console.Write("Price : ");
                    price = decimal.Parse(Console.ReadLine());
                    if (price >= 0)
                        break;
                    else
                        Console.WriteLine("Qiymet duzgun daxil edilmeyib");
                }
                #endregion
                #region Count validation
                while (true)
                {
                    Console.Write("Count : ");
                    count = decimal.Parse(Console.ReadLine());

                    if (count >= 0 & count == Math.Round(count))
                        break;
                    else
                        Console.WriteLine("Say duzgun daxil edilmeyib");
                }
                #endregion

                decimal individualTotal = count * price;
                resultTotal = resultTotal + individualTotal;

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                #region termination result validation
                while (true)
                {

                    Console.WriteLine("Yeni ayaqqabi elave olunsunmu? (Yes, No) (Y, N):  ");
                    loopTerminationResult = Console.ReadLine();

                    if (loopTerminationResult == "Y" | loopTerminationResult == "Yes" | loopTerminationResult == "No" | loopTerminationResult == "N")
                        break;
                    else 
                        Console.WriteLine("Duzgun cavab ver");
                }
                #endregion
                if (loopTerminationResult == "No" || loopTerminationResult == "N")
                    break;
            }


            Console.WriteLine("Result Total : " + resultTotal);

        }
    }
}