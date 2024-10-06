namespace ASSIGN_Banksystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Personkonto personkonto = new Personkonto(123456789, 10000);
            Sparkonto sparkonto = new Sparkonto(23456789, 22000);
            Investeringskonto investeringskonto = new Investeringskonto(3456789, 50000);
            bool backToStart = true;

            while (backToStart)
            {
                User.PrintOutStartMeny();
                int userOptionStart = Convert.ToInt32(Console.ReadLine()!);


                if (userOptionStart == 1)
                {
                    Console.WriteLine("Vilket konto vill du sätta in pengar på: ");
                    int userOptionSättaIn = Convert.ToInt32(Console.ReadLine()!);

                    if (userOptionSättaIn == 123456789)
                    {
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        personkonto.DepositPersonKonto();
                    }
                    if (userOptionSättaIn == 23456789)
                    {
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        sparkonto.DepositSparKonto();
                    }
                    if (userOptionSättaIn == 3456789)
                    {
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        investeringskonto.DepositInvesteringsKonto();
                    }
                    if (userOptionSättaIn != 123456789 && userOptionSättaIn != 23456789 && userOptionSättaIn != 3456789)
                    {
                        Console.WriteLine("Fel kontonummer, försök igen");
                    }

                }
                else if (userOptionStart == 2)
                {
                    Console.WriteLine("Vilket konto vill du ta ut pengar från: ");
                    int userOptionTaUt = Convert.ToInt32(Console.ReadLine()!);

                    if (userOptionTaUt == 123456789)
                    {
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        personkonto.DrawPersonKonto();
                    }
                    if (userOptionTaUt == 23456789)
                    {
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        sparkonto.DrawSparKonto();
                    }
                    if (userOptionTaUt == 3456789)
                    {
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        investeringskonto.DrawInvesteringsKonto();
                    }
                    if (userOptionTaUt != 123456789 && userOptionTaUt != 23456789 && userOptionTaUt != 3456789)
                    {
                        Console.WriteLine("Fel kontonummer, försök igen");
                    }

                }
                else if (userOptionStart == 3)
                {
                    Console.WriteLine("Hur mycket vill du överföra: ");
                    int moneyToTransfer = Convert.ToInt32(Console.ReadLine()!);

                    Console.WriteLine("Vilket konto vill du överföra pengar FRÅN: ");
                    int userOptionTransfer = Convert.ToInt32(Console.ReadLine()!);

                    if (userOptionTransfer == 123456789)
                    {
                        personkonto.PersonKontoSaldo = personkonto.PersonKontoSaldo - moneyToTransfer;
                        Console.WriteLine($"Du har tagit ut: {moneyToTransfer} från ditt personkonto");
                        Console.WriteLine($"Ditt saldo är nu: {personkonto.PersonKontoSaldo}");
                    }
                    if (userOptionTransfer == 23456789)
                    {
                        sparkonto.SparKontoSaldo = sparkonto.SparKontoSaldo - moneyToTransfer;
                        Console.WriteLine($"Du har tagit ut: {moneyToTransfer} från ditt sparkonto");
                        Console.WriteLine($"Ditt saldo är nu: {sparkonto.SparKontoSaldo}");

                    }
                    if (userOptionTransfer == 3456789)
                    {
                        investeringskonto.InvesteringsKontoSaldo = investeringskonto.InvesteringsKontoSaldo - moneyToTransfer;
                        Console.WriteLine($"Du har tagit ut: {moneyToTransfer} från ditt investeringskonto");
                        Console.WriteLine($"Ditt saldo är nu: {investeringskonto.InvesteringsKontoSaldo}");
                    }
                    if (userOptionTransfer != 123456789 && userOptionTransfer != 23456789 && userOptionTransfer != 3456789)
                    {
                        Console.WriteLine("Fel kontonummer, försök igen");
                    }

                    Console.WriteLine("Vilket konto vill du överföra pengar TILL: ");
                    int userOptionTransferTo = Convert.ToInt32(Console.ReadLine()!);

                    if (userOptionTransferTo == 123456789)
                    {
                        personkonto.PersonKontoSaldo = personkonto.PersonKontoSaldo + moneyToTransfer;
                        Console.WriteLine($"Du har satt in: {moneyToTransfer} på ditt personskonto");
                        Console.WriteLine($"Ditt saldo är nu: {personkonto.PersonKontoSaldo}");
                    }
                    if (userOptionTransferTo == 23456789)
                    {
                        sparkonto.SparKontoSaldo = sparkonto.SparKontoSaldo + moneyToTransfer;
                        Console.WriteLine($"Du har satt in: {moneyToTransfer} på ditt sparkonto");
                        Console.WriteLine($"Ditt saldo är nu: {sparkonto.SparKontoSaldo}");
                    }
                    if (userOptionTransferTo == 3456789)
                    {
                        investeringskonto.InvesteringsKontoSaldo = investeringskonto.InvesteringsKontoSaldo + moneyToTransfer;
                        Console.WriteLine($"Du har satt in: {moneyToTransfer} på ditt investeringskonto");
                        Console.WriteLine($"Ditt saldo är nu: {investeringskonto.InvesteringsKontoSaldo}");
                    }
                    if (userOptionTransferTo != 123456789 && userOptionTransferTo != 23456789 && userOptionTransferTo != 3456789)
                    {
                        Console.WriteLine("Fel kontonummer, försök igen");
                    }


                }
                else if (userOptionStart == 4)
                {
                    Console.WriteLine("Skriv in kontonummer för det konto du vill kontrollera: ");
                    int userOptionSaldo = Convert.ToInt32(Console.ReadLine()!);

                    if (userOptionSaldo == 123456789)
                    {
                        personkonto.CheckBalancePersonKonto();
                    }
                    if (userOptionSaldo == 23456789)
                    {
                        sparkonto.CheckBalanceSparKonto();
                    }
                    if (userOptionSaldo == 3456789)
                    {
                        investeringskonto.CheckBalanceInvesteringsKonto();
                    }
                    if (userOptionSaldo != 123456789 && userOptionSaldo != 23456789 && userOptionSaldo != 3456789)
                    {
                        Console.WriteLine("Fel kontonummer, försök igen");
                    }

                }
                else if (userOptionStart == 5)
                {
                    backToStart = false;
                }

            }

            Console.WriteLine("Tack för besöket!");

        }
    }
}
