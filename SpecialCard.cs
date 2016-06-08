using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_new
{
    public class SpecialCard:Field
    {
        public SpecialCard(int id, string name, string o, int zr)
        {
            Id = id;
            Name = name;
            Descript = o;
            DoSomething = zr;
            IsOccupied = false;
            HowManyHouses = 0;
            Owner = "brak";
            Cost = 0;
            FeeForHouse = 0;
            AmountForEntrance=new int[] {0,0,0,0,0};
        }
        public override string Type()
        {
            return "S";
        }
        public override bool Information()
        {
            Console.WriteLine("\t┌-----------------------------------------------------┐");
            Console.WriteLine("\t│\tNumer Id :                  {0}", this.Id);
            Console.WriteLine("\t│\tInformacje o polu:          {0}", this.Name);
            Console.WriteLine("\t│                                    ");
            Console.WriteLine("\t│{0}",this.Descript);
            Console.WriteLine("\t│{0}", this.DoSomething);
            Console.WriteLine("\t└-----------------------------------------------------┘");
            return true;
        }
        public override void IlustradeTheCard()
        {
            Console.WriteLine("┌-----------------------------------------------------┐");
            Console.WriteLine("│\t\t {0}.  {1}", this.Id, this.Name.ToUpper());
            Console.WriteLine("│\t {0}.  {1}", this.Descript, this.DoSomething);
            Console.WriteLine("└-----------------------------------------------------┘");
        }
    }
}
