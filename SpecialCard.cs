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
            if (this.Id == 4 || this.Id == 12 || this.Id == 23 || this.Id == 32)
            {
                RandomValue(1);
            }
            else
            {
                RandomValue(-1);
            }
            Console.WriteLine("┌-----------------------------------------------------┐");
            Console.WriteLine("│\t\t {0}.  {1}", this.Id, this.Name.ToUpper());
            Console.WriteLine("│\t {0}.  {1}", this.Descript, this.DoSomething);
            Console.WriteLine("└-----------------------------------------------------┘");
        }
        public void RandomValue(int a)
        {
            int[] positive = new int[6] { 100, 150, 200, 250, 300, 400 };
            int[] negative = new int[6] { -100, -150, -200, -250, -300, -400 };
            int value = 1000;
            int retvalue = 0;
            switch (a)
            {
                case 1:
                    value = new Random().Next(0, 6);
                    retvalue = positive[value];
                    this.DoSomething = retvalue;
                    break;
                case -1:
                    value = new Random().Next(0, 6);
                    retvalue = negative[value];
                    this.DoSomething = retvalue;
                    break;
            }
        }
    }
}
