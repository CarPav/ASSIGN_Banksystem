using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGN_Banksystem
{
    internal class Investeringskonto
    {
        public int InvesteringsKontonummer { get; set; }
        public float InvesteringsKontoSaldo { get; set; }

        public Investeringskonto(int investeringskontonummer, float investeringskontosaldo)
        {
            InvesteringsKontonummer = investeringskontonummer;
            InvesteringsKontoSaldo = investeringskontosaldo;

        }

        public void DepositInvesteringsKonto()
        {
            int moneyToPutInInvesteringsKonto = UserInputInvest();
            InvesteringsKontoSaldo = InvesteringsKontoSaldo + moneyToPutInInvesteringsKonto;
            Console.WriteLine($"Du har satt in: {moneyToPutInInvesteringsKonto} på ditt investeringskonto");
            Console.WriteLine($"Ditt saldo är nu: {InvesteringsKontoSaldo}");
        }

        public void DrawInvesteringsKonto()
        {
            int moneyToTakeOutInvesteringsKonto = UserInputInvest();
            InvesteringsKontoSaldo = InvesteringsKontoSaldo - moneyToTakeOutInvesteringsKonto;
            Console.WriteLine($"Du har tagit ut: {moneyToTakeOutInvesteringsKonto} från ditt investeringskonto");
            Console.WriteLine($"Ditt saldo är nu: {InvesteringsKontoSaldo}");
        }

        public void CheckBalanceInvesteringsKonto()
        {
            Console.WriteLine($"Ditt saldo på investeringskonto är: {InvesteringsKontoSaldo}");
        }

        public int UserInputInvest()
        {
            string moneyInvestAsString = Console.ReadLine()!;
            int moneyInvest = Convert.ToInt32(moneyInvestAsString);
            return moneyInvest;
        }
    }
}
