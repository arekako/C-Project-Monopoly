using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_new
{
    //po tej klasie dziedziczą Pole i PoleSpecjalne
    //w kodzie Rozgrywka mamy utworzonę listę Field: która ma w sobie elementy typu Pole i PoleSpecjalne
    //w jaki sposob rozrożniać te elementy w foreachu gdy mają rożne metody?,
    //czy rzutowanie (Pole) jest prawidlowe?
    public class Field
    {
        public int Id{ get; set;}
        public string Name{ get; set;}
        public bool IsOccupied { get; set; }
        public string Owner { get; set; }
        public int HowManyHouses { get; set; }
        public int Cost { get; set; }
        public int FeeForHouse { get; set; }
        public int[] AmountForEntrance { get; set; }
        public  int DoSomething { get; set; }
        public  string Descript { get; set; }

        public virtual string Type()
        { 
            return "Typ wskazanego pola to MonopolyField";
        }
        public virtual bool Information() 
        {
            return true;
        }
        public virtual void IlustradeTheCard() 
        {
            Console.WriteLine("Ogolna karta nie ma swojego Obrazu");
        }
        public virtual void InformationAbutHouses()
        {
            Console.WriteLine("Klasa Field nie ma domków. Domki sa tylko dla typu Pole");
        }
        public virtual string ChangeOfOwner(string b)
        {
            return "Field nie posiada pola.Tylko Card może zmienic wlasciciela!";
        }
        public virtual int HowManyhouses()
        {
            return 0;
        }
        public virtual int ChangeTheNumberOfHouses()
        {
            return 0;
        }
        public virtual int Pledge()
        {
            return 0;
        }//zastaw

    }
}
