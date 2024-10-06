using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGN_Banksystem
{
    public class User
    {
        public static void PrintOutStartMeny()
        {
            Console.WriteLine("       ");
            Console.WriteLine("Välkommen till hembanken. Välj från menyn nedan?");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1 - Sätta in pengar");
            Console.WriteLine("2 - Ta ut pengar");
            Console.WriteLine("3 - Överföra pengar");
            Console.WriteLine("4 - Kontrollera Saldo");
            Console.WriteLine("5 - Exit");
        }
        public static void PrintOutKontrollSaldo()
        {
            Console.WriteLine("Vilket konto vill du kontrollera ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1 - Personkonto");
            Console.WriteLine("2 - Sparkonto");
            Console.WriteLine("3 - Investeringskonto");
            Console.WriteLine("4 - Tillbaka till Start");
        }

    }
}
