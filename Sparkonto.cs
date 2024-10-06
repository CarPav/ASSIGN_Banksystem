using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGN_Banksystem
{
    internal class Sparkonto
    {
        public int SparKontonummer { get; set; }
        public float SparKontoSaldo { get; set; }

        public Sparkonto(int sparkontonummer, float sparkontosaldo)
        {
            SparKontonummer = sparkontonummer;
            SparKontoSaldo = sparkontosaldo;

        }

        public void DepositSparKonto()
        {
            int moneyToPutInSparKonto = UserInputSpar();
            SparKontoSaldo = SparKontoSaldo + moneyToPutInSparKonto;
            Console.WriteLine($"Du har satt in: {moneyToPutInSparKonto} på ditt sparkonto");
            Console.WriteLine($"Ditt saldo är nu: {SparKontoSaldo}");
        }

        public void DrawSparKonto()
        {
            int moneyToTakeOutSparKonto = UserInputSpar();
            SparKontoSaldo = SparKontoSaldo - moneyToTakeOutSparKonto;
            Console.WriteLine($"Du har tagit ut: {moneyToTakeOutSparKonto} från ditt sparkonto");
            Console.WriteLine($"Ditt saldo är nu: {SparKontoSaldo}");
        }

        public void CheckBalanceSparKonto()
        {
            Console.WriteLine($"Ditt saldo på sparkonto är: {SparKontoSaldo}");
        }

        public int UserInputSpar()
        {
            string moneySparAsString = Console.ReadLine()!;
            int moneySpar = Convert.ToInt32(moneySparAsString);
            return moneySpar;
        }
    }
}
