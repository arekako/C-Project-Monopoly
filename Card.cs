using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_new
{
    public class Card:Field
    {
        public Card(int id, string naz, int kos, bool czy, string wl, int opl, int[] kw, int howMany)
        {
            Id = id;
            Name = naz;
            Cost = kos;
            IsOccupied = czy;
            Owner = wl;
            FeeForHouse = opl;
            AmountForEntrance = kw;
            HowManyHouses = howMany;
        }
        public override string Type()
        {
            return "P";
        }
        public  override bool Information()
        {
            Console.WriteLine("\t┌-----------------------------------------------------┐");
            Console.WriteLine("\t│\tNumer Id :                  {0}", this.Id);
            Console.WriteLine("\t│\tInformacje o polu:          {0}", this.Name);
            Console.WriteLine("\t│\tKoszt zakupu nieruchomości: {0}", this.Cost);
            if (IsOccupied == true)
            {
                Console.WriteLine("\t│\tWlascicielem jest :         {0}", this.Owner);
            }
            else
            {
                Console.WriteLine("\t│\tBrak własciciela - do kupienia!!!");
            }
            Console.WriteLine("\t│                                    ");
            Console.WriteLine("\t│\tOplata za postawienie domku to {0}", this.FeeForHouse);
            Console.WriteLine("\t│\tObecna ilość domków to {0}", this.HowManyHouses);
            Console.WriteLine("\t│\tOplata za 1 domek {0},\n\t│\tOplata za 2 domek {1},\n\t│\tOplata za 3 domek {2},\n\t│\tOplata za 4 domek {3},\n\t│\tOplata za hotel  {4}", this.AmountForEntrance[0], this.AmountForEntrance[1], this.AmountForEntrance[2], this.AmountForEntrance[3], this.AmountForEntrance[4]);
            Console.WriteLine("\t└-----------------------------------------------------┘");
            return true;
        }
        public override void IlustradeTheCard()
        {
            Console.WriteLine("┌-----------------------------------------------------┐");
            Console.WriteLine("│\t\t\t{0}.  {1}", this.Id, this.Name.ToUpper());
            Console.WriteLine("│                                    ");
            Console.WriteLine("│\tKoszt działki:           {0}           ", this.Cost);
            Console.WriteLine("│\tWłaściciel dzialki:      {0}           ", this.Owner.ToUpper());
            Console.WriteLine("│\tOpłata za domek to:      {0}           ", this.FeeForHouse);
            Console.WriteLine("│\tAktualna ilość domków to {0}", this.HowManyHouses);
            Console.WriteLine("│                                    ");
            Console.WriteLine("│\t\tO domków-     {0}", this.AmountForEntrance[0]);
            Console.WriteLine("│\t\t1 domek -     {0}", this.AmountForEntrance[0]);
            Console.WriteLine("│\t\t2 domek -     {0}", this.AmountForEntrance[1]);
            Console.WriteLine("│\t\t3 domek -     {0}", this.AmountForEntrance[2]);
            Console.WriteLine("│\t\t4 domek -     {0}", this.AmountForEntrance[3]);
            Console.WriteLine("│\t\thotel   -     {0}", this.AmountForEntrance[4]);
            Console.WriteLine("└-----------------------------------------------------┘");
        }
        public  override void InformationAbutHouses()
        {
            if (Owner != "brak")
            {
                Console.WriteLine("|X|  Na tej nieruchomości stoji {0} domków!", this.HowManyHouses);
            }
            else
            {
                this.HowManyHouses = 0;
                Console.WriteLine("|X|  Brak Domkow");
            }
        }
        public  override string ChangeOfOwner(string b)
        {
            this.Owner = b;
            return this.Owner;
        }
        public override int HowManyhouses()
        {
          return this.HowManyHouses;
        }
        public override int ChangeTheNumberOfHouses()
        {
            this.HowManyHouses++;
            return this.HowManyHouses;
        }
        public override int Pledge()
        {
            double kwota;
            kwota = 0.5 * (Cost + HowManyHouses * FeeForHouse);
            return (int)kwota;
        }
    }
}
