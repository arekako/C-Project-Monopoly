using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_new
{
    public class Plansza
    {
        public List<Pole> Pola;
        //public List<MonopolyField> Pola;
        public List<Gracz> Gracze;//tutaj ich nie tworzymy ale w kodzie programu

        public Plansza()
        {
            this.Pola = new List<Pole>();//to jest bardzo wazne
            //this.Pola=new List<MonopolyField>();
            this.Gracze = new List<Gracz>();//to jest bardzo wazne , bez tego wyskakuje mi blad, nawet jesli tu nie bede korzystać z graczy to musi byc to zainicjowane

            //do domysnego konstuktora , przecież zawsze ma być tworzona tylko jedna plansza
            int[] tablica_oplat1 = { 20, 45, 100, 240, 500 };
            int[] tablica_oplat2 = { 25, 50, 110, 260, 530 };
            int[] tablica_oplat3 = { 30, 80, 200, 350, 580 };
            int[] tablica_oplat4 = { 35, 100, 300, 500, 630 };
            int[] tablica_oplat5 = { 40, 120, 350, 500, 700 };
            int[] tablica_oplat6 = { 45, 145, 360, 380, 750 };
            int[] tablica_oplat7 = { 50, 150, 390, 610, 780 };
            int[] tablica_oplat8 = { 55, 170, 400, 600, 790 };
            int[] tablica_oplat9 = { 60, 190, 420, 650, 800 };
            int[] tablica_oplat10 = { 65, 200, 450, 750, 1000 };

            int[] tablica_oplat11 = { 65, 200, 450, 750, 1000 };
            int[] tablica_oplat12 = { 65, 210, 450, 750, 1000 };
            int[] tablica_oplat13 = { 75, 220, 460, 760, 1100 };
            int[] tablica_oplat14 = { 75, 230, 460, 750, 1100 };
            int[] tablica_oplat15 = { 80, 240, 470, 775, 1200 };
            int[] tablica_oplat16 = { 80, 240, 460, 800, 1150 };
            int[] tablica_oplat17 = { 80, 230, 460, 870, 1150 };
            int[] tablica_oplat18 = { 90, 240, 470, 810, 1200 };
            int[] tablica_oplat19 = { 80, 240, 490, 820, 1250 };
            int[] tablica_oplat20 = { 90, 250, 490, 900, 1300 };

            int[] tablica_oplat21 = { 95, 250, 500, 900, 1250 };
            int[] tablica_oplat22 = { 95, 260, 510, 910, 1350 };
            int[] tablica_oplat23 = { 100, 260, 510, 920, 1200 };
            int[] tablica_oplat24 = { 100, 260, 520, 900, 1350 };
            int[] tablica_oplat25 = { 110, 270, 525, 925, 1390 };
            int[] tablica_oplat26 = { 110, 280, 530, 910, 1400 };
            int[] tablica_oplat27 = { 120, 290, 535, 950, 1400 };
            int[] tablica_oplat28 = { 120, 300, 540, 1000, 1430 };
            int[] tablica_oplat29 = { 125, 300, 550, 1030, 1450 };
            int[] tablica_oplat30 = { 130, 310, 550, 1100, 1500 };

            int[] tablica_oplat31 = { 130, 305, 600, 1100, 1500 };
            int[] tablica_oplat32 = { 130, 310, 650, 1100, 1530 };
            int[] tablica_oplat33 = { 135, 320, 660, 1150, 1580 };
            int[] tablica_oplat34 = { 135, 320, 670, 1180, 1630 };
            int[] tablica_oplat35 = { 140, 330, 680, 1200, 1700 };
            int[] tablica_oplat36 = { 145, 340, 690, 1250, 1750 };
            int[] tablica_oplat37 = { 150, 350, 710, 1300, 1780 };
            int[] tablica_oplat38 = { 155, 350, 720, 1330, 1790 };
            int[] tablica_oplat39 = { 160, 360, 730, 1370, 1800 };
            int[] tablica_oplat40 = { 165, 360, 740, 1400, 2000 };
            
            this.Pola.Add(new Pole(1, "Syria", 250, false, "brak", 30, tablica_oplat1, 0));
            this.Pola.Add(new Pole(2, "Portugalia", 250, false, "brak", 35, tablica_oplat2, 0));
            this.Pola.Add(new Pole(3, "Wlochy", 270, false, "brak", 40, tablica_oplat3, 0));
            this.Pola.Add(new Pole(4, "Niemcy", 280, false, "brak", 40, tablica_oplat4, 0));
            this.Pola.Add(new Pole(5, "Szkocja", 280, false, "brak", 40, tablica_oplat5, 0));
            this.Pola.Add(new Pole(6, "Anglia", 300, false, "brak", 50, tablica_oplat6, 0));
            this.Pola.Add(new Pole(7, "Polska", 310, false, "brak", 55, tablica_oplat7, 0));
            this.Pola.Add(new Pole(8, "Turcja", 330, false, "brak", 55, tablica_oplat8, 0));
            this.Pola.Add(new Pole(9, "Rosja", 350, false, "brak", 60, tablica_oplat9, 0));
            this.Pola.Add(new Pole(10, "Ukraina", 380, false, "brak", 60, tablica_oplat10, 0));

            this.Pola.Add(new Pole(11, "Brazylia", 380, false, "brak", 60, tablica_oplat11, 0));
            this.Pola.Add(new Pole(12, "Argentyna", 390, false, "brak", 65, tablica_oplat12, 0));
            this.Pola.Add(new Pole(13, "Urugwaj", 390, false, "brak", 65, tablica_oplat13, 0));
            this.Pola.Add(new Pole(14, "Paragwaj", 400, false, "brak", 70, tablica_oplat14, 0));
            this.Pola.Add(new Pole(15, "Boliwia", 400, false, "brak", 70, tablica_oplat15, 0));
            this.Pola.Add(new Pole(16, "Chile", 400, false, "brak", 80, tablica_oplat16, 0));
            this.Pola.Add(new Pole(17, "Kolumbia", 410, false, "brak", 85, tablica_oplat17, 0));
            this.Pola.Add(new Pole(18, "Wenezuela", 430, false, "brak", 85, tablica_oplat18, 0));
            this.Pola.Add(new Pole(19, "Belize", 450, false, "brak", 90, tablica_oplat19, 0));
            this.Pola.Add(new Pole(20, "Trynidad i Tobago", 480, false, "brak", 90, tablica_oplat20, 0));

            this.Pola.Add(new Pole(21, "Chiny", 490, false, "brak", 95, tablica_oplat21, 0));
            this.Pola.Add(new Pole(22, "Japonia", 490, false, "brak", 95, tablica_oplat22, 0));
            this.Pola.Add(new Pole(23, "Rosja", 490, false, "brak", 90, tablica_oplat23, 0));
            this.Pola.Add(new Pole(24, "Katar", 500, false, "brak", 90, tablica_oplat24, 0));
            this.Pola.Add(new Pole(25, "Indie", 510, false, "brak", 90, tablica_oplat25, 0));
            this.Pola.Add(new Pole(26, "Indonezja", 520, false, "brak", 110, tablica_oplat26, 0));
            this.Pola.Add(new Pole(27, "Korea", 510, false, "brak", 100, tablica_oplat27, 0));
            this.Pola.Add(new Pole(28, "Tadzykistan", 530, false, "brak", 90, tablica_oplat28, 0));
            this.Pola.Add(new Pole(29, "Kirgistan", 550, false, "brak", 90, tablica_oplat29, 0));
            this.Pola.Add(new Pole(30, "Malezja", 540, false, "brak", 90, tablica_oplat30, 0));

            this.Pola.Add(new Pole(31, "Irak", 550, false, "brak", 95, tablica_oplat31, 0));
            this.Pola.Add(new Pole(32, "Iran", 550, false, "brak", 95, tablica_oplat32, 0));
            this.Pola.Add(new Pole(33, "Egipt", 570, false, "brak", 90, tablica_oplat33, 0));
            this.Pola.Add(new Pole(34, "Tunezja", 580, false, "brak", 90, tablica_oplat34, 0));
            this.Pola.Add(new Pole(35, "RPA", 580, false, "brak", 90, tablica_oplat35, 0));
            this.Pola.Add(new Pole(36, "Kongo", 600, false, "brak", 90, tablica_oplat36, 0));
            this.Pola.Add(new Pole(37, "Senegal", 610, false, "brak", 95, tablica_oplat37, 0));
            this.Pola.Add(new Pole(38, "Nigeria", 630, false, "brak", 105, tablica_oplat38, 0));
            this.Pola.Add(new Pole(39, "Laos", 650, false, "brak", 120, tablica_oplat39, 0));
            this.Pola.Add(new Pole(40, "Liberia", 680, false, "brak", 130, tablica_oplat40, 0));
        }
        public int RozmiarPlanszy()
        {
            return this.Pola.Count();
        }
        public int IloscGraczy()
        {
            return this.Gracze.Count();
        }
        public static void CzyscKonsole()
        {
            Console.Clear();
        }//
        public static void Instrukcja_gry()
        {
            Console.WriteLine("┌---------------------------------------------------┐");
            Console.WriteLine("\tAutorem Aplikacji jest Arkadiusz Pepliński.\n");
            Console.WriteLine("\tWitam w grze Monopoly dla max 10 graczy.\n");
            Console.WriteLine("\tRozgrywka toczy się na planszy o różnych wymiarach\n \tw zależności od ilości graczy:");
            Console.WriteLine("\t\t 2-3 graczy 11 pól");
            Console.WriteLine("\t\t 4-5 graczy 16 pól");
            Console.WriteLine("\t\t 6-9 graczy 31 pól");
            Console.WriteLine("\t\t >10 graczy 40 pól");
            Console.WriteLine("\t\t ŻYCZĘ MIŁEJ ZABAWY");
            Console.WriteLine("└---------------------------------------------------┘");
            Console.WriteLine("Kliknij Enter by rozpocząć grę");
            Console.ReadLine();
            System.Threading.Thread.Sleep(1000);
            CzyscKonsole();
        }//
        public  void decyzjaInfo()
        {
            Console.WriteLine("\tWybierz t-tak lub n-nie.\n\tZatwierdź Enterem!");
        }
        public  bool decyzja()
        {
            decyzjaInfo();
            string zmienna;
            zmienna = Console.ReadLine();
            if (zmienna == "t")
            {
                return true;
            }
            else if (zmienna == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\tBłąd. Wybierz poprawną wartość!!!");
                decyzjaInfo();
                return decyzja();
            }
        }
        public string rysuj_kostke(int wartosc)
        {
            string napis = "";
            switch (wartosc)
            {
                case 0:
                    napis = " ";
                    break;
                case 1:
                    napis = "┌---┐\n│   │\n│ * │\n│   │\n└---┘";
                    break;
                case 2:
                    napis = "┌---┐\n│*  │\n│   │\n│  *│\n└---┘";
                    break;
                case 3:
                    napis = "┌---┐\n│*  │\n│ * │\n│  *│\n└---┘";
                    break;
                case 4:
                    napis = "┌---┐\n│* *│\n│   │\n│* *│\n└---┘";
                    break;
                case 5:
                    napis = "┌---┐\n│* *│\n│ * │\n│* *│\n└---┘";
                    break;
                default:
                    napis = "\n┌---┐\n│* *│\n│* *│ +\n│* *│\n└---┘\n" + rysuj_kostke(wartosc - 6);
                    break;
            }
            return napis;
        }//

        public int losuj()
        {
            int wyl = new Random().Next(1, 7);
            while (wyl % 6 == 0)
            {
                wyl = wyl + new Random().Next(1, 7);
                if (wyl > 30)
                {
                    wyl = wyl % 10;
                }
            }
            Console.WriteLine("\t Wylosowano:\t{0}", wyl);
            Console.WriteLine("{0}", rysuj_kostke(wyl));//
            return wyl;
        }//
        public void CzyJuzKoniecGry()
        {
            int ilu = Gracze.Count();//3 tutaj zamiana
            foreach (Gracz gr in Gracze)
            {
                if (gr.Kwota < 0)
                {
                    ilu--;
                    Console.WriteLine("\t\tJest gracz który nie ma już pieniędzy...");
                    Console.ReadKey();
                    if (ilu == 1)
                    {
                        Console.WriteLine("\t\t\t\tKONIEC GRY");
                        Console.WriteLine("\t\tZatwierdz Enterem wyjście z gry:");
                        Console.ReadKey();
                    }
                }
            }

        }
        public bool CzyWywalamyGracza()
        {
            foreach (Gracz gr in Gracze)
            {
                if (gr.Kwota < 0)
                {
                    Console.WriteLine("Jeden z graczy zbankrutował!");
                    Console.WriteLine("Jest nim {0}!", gr.Name.ToUpper());
                    Console.WriteLine("Wyrzucamy go z gry. Jego nieruchomości są już do kupienia.");
                    foreach (Pole p in Pola)
                    {
                        if (p.Wlasciciel.ToLower() == gr.Name.ToLower())
                        {
                            p.Wlasciciel = "brak";
                            p.Czy_zajete = false;
                            p.IleDomkow = 0;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public int KogoWywalamyDwa()
        {
            for (int i = 0; i < Gracze.Count(); i++)
            {
                if (Gracze[i].Kwota < 0)
                {
                    return i;
                }
            }
            return 100;
        }
        public string KoniecGry()
        {
            if (Gracze.Count() == 1)
            {
                Console.Clear();
                Console.WriteLine("KONIEC GRY. Zwyciezcą jest {0}", Gracze[0].Name);
                Console.ReadKey();
                return "KONIEC";
            }
            return " ";
        }
        public List<Pole> UstawPlansze(int liczbagraczy)//List<MonopolyField>
        {
            if (liczbagraczy < 4)
            {
                for (int i = 39; i > 10; i--)
                {
                    Pola.RemoveAt(i-1);
                }
                return Pola;
            }
            else if ((liczbagraczy >= 4) && (liczbagraczy < 6))
            {
                for (int i = 39; i > 15; i--)
                {
                    Pola.RemoveAt(i-1);
                }
                return Pola;
            }
            else if ((liczbagraczy >= 6) && (liczbagraczy < 10))
            {
                for (int i = 39; i > 30; i--)
                {
                    Pola.RemoveAt(i-1);
                }
                return Pola;
            }
            else
            {
                return Pola;
            }
        }
        public void InformacjaOPlanszy()
        {
            int iloscZajetych = 0;
            //foreach(MonopolyField pole in Pola)
            //if(pole.Typ()=="P")
            foreach (Pole pole in Pola)
            {
                if (pole.Czy_zajete == true)
                {
                    iloscZajetych++;
                }
            }
            Console.WriteLine("┌------------Informacje o planszy-------------------┐");
            Console.WriteLine("│");
            Console.WriteLine("│Łączna ilość pól to   {0}", Pola.Count());
            Console.WriteLine("│\t\tZajętych pól jest {0}", iloscZajetych);
            
            //foreach(MonopolyField pole in Pola)
            //if(pole.Typ()=="P")
            foreach (Pole pole in Pola)
            {
                if (pole.Czy_zajete == true)
                {
                    Console.WriteLine("│\tId: {0} - Nazwa: {1} - Ilość domków: {2} - Właścicielem jest {3}", pole.Id, pole.Nazwa, pole.IleDomkow, pole.Wlasciciel);
                }
            }
            Console.WriteLine("└---------------------------------------------------┘");
        }//
    }
}
