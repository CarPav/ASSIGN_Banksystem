using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGN_Banksystem
{
    public class Personkonto
    {
        public int PersonKontonummer { get; set; }
        public float PersonKontoSaldo { get; set; }


        public Personkonto(int personkontonummer, float personkontosaldo)
        {
            PersonKontonummer = personkontonummer;
            PersonKontoSaldo = personkontosaldo;

        }

        public void DepositPersonKonto()
        {
            int moneyToPutInPersonKonto = UserInputPerson();
            PersonKontoSaldo = PersonKontoSaldo + moneyToPutInPersonKonto;
            Console.WriteLine($"Du har satt in: {moneyToPutInPersonKonto} på ditt personkonto");
            Console.WriteLine($"Ditt saldo är nu: {PersonKontoSaldo}");
        }

        public void DrawPersonKonto()
        {

            int moneyToTakeOutPersonKonto = UserInputPerson();
            PersonKontoSaldo = PersonKontoSaldo - moneyToTakeOutPersonKonto;
            Console.WriteLine($"Du har tagit ut: {moneyToTakeOutPersonKonto} från ditt personkonto");
            Console.WriteLine($"Ditt saldo är nu: {PersonKontoSaldo}");
        }

        public void CheckBalancePersonKonto()
        {
            Console.WriteLine($"Ditt saldo på personkonto är: {PersonKontoSaldo}");
        }

        public int UserInputPerson()
        {
            string moneyPersonAsString = Console.ReadLine()!;
            int moneyPerson = Convert.ToInt32(moneyPersonAsString);
            return moneyPerson;
        }
    }

}
