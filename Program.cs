using System.Drawing;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // Får fyrkanterna att synas

            Console.WriteLine("Ange antal en siffra för schackbrädet: "); // Ber användaren om en siffra för brädet och omvandlar sedan det till int
            string Number = Console.ReadLine();
            int UserNumber = Convert.ToInt32(Number);

            for (int Row = 0; Row < UserNumber; Row++) // Loop för att skapa schackbrädet
            {
                for (int Column = 0; Column < UserNumber; Column++)
                {
                    if ((Row + Column) % 2 == 0) // Om summan av Row och Column är jämn så skrivs en vit ruta ut, annars en svart.
                    {
                        Console.Write("□");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                }
                Console.WriteLine(); // Byter rad efter att varje rad är "full"
            }

        }
    }
}
