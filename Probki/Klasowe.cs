using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_new
{
    class Klasowe
    {
        static void Main(string[] args)
        {
            int numerRundy = 1;
            string zmiennaImie;

            Plansza Monopoly = new Plansza();//dziala poprawnie
            Plansza.Instrukcja_gry();

            /////////////////////////////////////////////////////
            int[] tabl = { 95, 250, 500, 900, 1250 };
            Pole jakiespole = new Pole(21, "Chiny", 490, false, "brak", 95, tabl, 0);
            PoleSpecjalne jakiespolespecjalne = new PoleSpecjalne(22, "Szansa", "Wygrales na loterii", 100);
            MonopolyField costam = new Pole(21, "Chiny", 490, false, "brak", 95, tabl, 0);
            MonopolyField costam2 = new PoleSpecjalne(22, "Szansa", "Wygrales na loterii", 100);

            //Console.WriteLine("Pole jekiespole typ {0}", jakiespole.Typ());
            //Console.WriteLine("PoleSpecjalne jekiespolespecjalne typ {0}", jakiespolespecjalne.Typ());
            //Console.WriteLine("MonopolyField costam typ {0}", costam.Typ());
            //Console.WriteLine("MonopolyField costam2 typ {0}", costam2.Typ());

            //jakiespole.ObrazujKarte();
            //jakiespolespecjalne.ObrazujKarte();
            //costam.ObrazujKarte();
            //costam2.ObrazujKarte();//działa
            //Console.WriteLine("Pole jakiespole Iledomkow: {0}", jakiespole.Iledomkow());
            //Console.WriteLine("PoleSpecjalne jakiespolespecjalne Iledomkow: {0}", jakiespolespecjalne.Iledomkow());
            //Console.WriteLine("MonopolyField costam Iledomkow : {0}", costam.Iledomkow());
            //Console.WriteLine("MonopolyField costam2 Iledomkow : {0}", costam2.Iledomkow());

            List<MonopolyField> MojeWszystkiePola = new List<MonopolyField>();
            MojeWszystkiePola.Add(new Pole(21, "Chiny", 490, false, "brak", 95, tabl, 0));
            MojeWszystkiePola.Add(new PoleSpecjalne(22, "Szansa", "Wygrales na loterii", 100));
            MojeWszystkiePola.Add(new Pole(23, "Chiny", 490, false, "brak", 95, tabl, 0));
            MojeWszystkiePola.Add(new PoleSpecjalne(24, "Szansa", "Wygrales na loterii", 200));
            MojeWszystkiePola.Add(new Pole(25, "Chiny", 490, false, "brak", 95, tabl, 0));
            MojeWszystkiePola.Add(new PoleSpecjalne(26, "Szansa", "Wygrales na loterii", 300));
            MojeWszystkiePola.Add(new Pole(27, "Chiny", 490, false, "brak", 95, tabl, 0));
            MojeWszystkiePola.Add(new PoleSpecjalne(28, "Szansa", "Wygrales na loterii", 400));
            int z = 0;
            foreach (MonopolyField item in MojeWszystkiePola)
            {
                if (item.Typ() == "S")
                {
                    Console.WriteLine(item.Nazwa);
                    Console.WriteLine(item.Typ());
                    item.ObrazujKarte();
                    z++;
                }
            }
            //Console.WriteLine(z);
            //Console.WriteLine(MojeWszystkiePola.Count());
            //sprawdzic funkcje co wyrzuca

            /////////////////////////////////////////////////////////



            //Monopoly.Instrukcja_gry();
            Console.WriteLine("Podaj liczbę graczy ");
            string liczba_graczy_str = Console.ReadLine();
            int liczba_graczy = Int32.Parse(liczba_graczy_str);
            Plansza.CzyscKonsole();
            //Monopoly.CzyscKonsole();

            for (int i = 0; i < liczba_graczy; i++)
            {
                Console.WriteLine("Podaj imie gracza {0}", i + 1);
                zmiennaImie = Console.ReadLine();
                Plansza.CzyscKonsole();
                //Monopoly.CzyscKonsole();
                Monopoly.Gracze.Add(new Gracz(i + 1, zmiennaImie, 3000, 0, new List<Pole>(), liczba_graczy));//5000
                Monopoly.Gracze[i].PrzywitanieGracza();
                Console.WriteLine("Kliknij Enter, aby kontynuować...");
                Console.ReadLine();
                Plansza.CzyscKonsole();
                //Monopoly.CzyscKonsole();
            }
            Monopoly.UstawPlansze(liczba_graczy);//ustawia liczbę pol w zalezności od ilosci graczy
            ///////////////////////////////////////////////////////////////////
            while (true)
            {
                Monopoly.CzyJuzKoniecGry();
                Monopoly.KoniecGry();
                if (Monopoly.CzyWywalamyGracza() == true)//wywaliło false
                {
                    int zmienna = Monopoly.KogoWywalamyDwa();
                    Monopoly.Gracze.RemoveAt(zmienna - 1);
                    Console.WriteLine("Wyrzucilismy gracza z gry!");
                    Console.WriteLine("Pozostało {0} graczy", Monopoly.Gracze.Count());
                    Console.WriteLine("Kliknij Enter, aby kontynuować z mniejszą liczbą graczy");
                    Console.ReadLine();
                    Plansza.CzyscKonsole();
                    //Monopoly.CzyscKonsole();
                }
                Plansza.CzyscKonsole();
                //Monopoly.CzyscKonsole();

                Console.WriteLine(Monopoly.IloscGraczy());
              
                Console.WriteLine("_________________Runda nr.{0}_________", numerRundy);
                Monopoly.InformacjaOPlanszy();
                foreach (Gracz gracz in Monopoly.Gracze)
                {
                    gracz.Infor();
                    Console.WriteLine("{0}, kliknij Enter by losować", gracz.Name);
                    Console.ReadLine();
                    Console.WriteLine("Losowanie...");
                    System.Threading.Thread.Sleep(2000);
                    gracz.ZmienAktPoz(Monopoly.losuj());
                    System.Threading.Thread.Sleep(2000);
                    if (gracz.AktualnaPozycjaNaPlanszy > Monopoly.Pola.Count())//10
                    {
                        gracz.AktualnaPozycjaNaPlanszy = (gracz.AktualnaPozycjaNaPlanszy - Monopoly.Pola.Count()) % Monopoly.Pola.Count();
                        if (gracz.AktualnaPozycjaNaPlanszy == 0)
                        {
                            gracz.AktualnaPozycjaNaPlanszy = 1;
                        }
                    }
                    Console.WriteLine("\nAktualna pozycja na planszy:" + gracz.AktualnaPozycjaNaPlanszy);
                    //////////////////////////////////////////
                    if (Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Czy_zajete == false)//WOLNA DZIAŁKA
                    {
                        if (gracz.Kwota >= Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Koszt)//jezeli gracz ma wiecej hajsu niż koszt dzialki
                        {
                            Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].ObrazujKarte();
                            Console.WriteLine("\tCzy chcesz kupić  wolną dzialkę?");
                            if (Monopoly.decyzja() == true)
                            {
                                System.Threading.Thread.Sleep(2000);
                                Console.WriteLine("\tKupiles dzialke o numerze {0}", gracz.AktualnaPozycjaNaPlanszy);
                                gracz.ZmienKwote(Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Koszt);//ODEJMOWANIE
                                Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].ZmianaWlasciciela(gracz.Name);//PRZYPISANIE WLASCICIELA DO DZIALKI
                                Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Czy_zajete = true;
                                gracz.Dzialki.Add(Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1]);// PRZYPISANIE DZIALKI DO GRACZA
                                Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Infor();
                                Console.WriteLine("\t\tRuch kolejnego gracza");
                                Console.WriteLine("   ");
                            }
                            else
                            {
                                Console.WriteLine("\n\tNie zdecydowałeś się na kupno działki.");
                                Console.WriteLine("\n\tRuch kolejnego gracza");
                                Console.WriteLine("   ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\tBrak środkow na koncie.Graj rozważnie");
                            Console.WriteLine("\tRuch kolejnego gracza");
                            Console.WriteLine("");
                        }
                    }
                    else if (Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Czy_zajete == true)//DZIALKA ZAJETA
                    {
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("\t\t\tWjechales w zajętą dzialkę!");
                        if (Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Wlasciciel == gracz.Name)//jezeli dzialka nasza to
                        {
                            Console.WriteLine("\t\t\tRozważ budowę domków");
                            Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].InformacjaDlaWlascicielaODomkach();
                            if (Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Iledomkow() < 5)//gdy jest mozliwosc kupna domku
                            {
                                Console.WriteLine("\t\t\tCzy chcesz kupić domek?");
                                if (Monopoly.decyzja() == true)//jezeli tak
                                {
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("\t\t\tChcesz kupić domek!");
                                    //sprawdzenie czy nas stac
                                    if (gracz.Kwota >= Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].OplataZaDomek)// jezeli tak
                                    {
                                        Console.WriteLine("\t\t\tZdecydowaleś się na kupno domku!");
                                        gracz.ZmienKwote(Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].OplataZaDomek);//odejmowanie hajsu za domek
                                        Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].ZmienLiczbeDomkow();
                                        Console.WriteLine("\t\t\tZmieniono liczbę domkow na {0}", Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].IleDomkow);
                                        Console.WriteLine("\t\t\tRuch kolejnego gracza");
                                        Console.WriteLine("");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\t\t\t\tNie stać cię na kupno domku");
                                        Console.WriteLine("\t\t\t\tRuch kolejnego gracza");
                                        Console.WriteLine("   ");
                                    }
                                }
                                else//jezeli nie
                                {
                                    System.Threading.Thread.Sleep(2000);
                                    Console.WriteLine("\t\t\tNie chcesz kupić domku");
                                    Console.WriteLine("\t\t\tRuch kolejnego gracza");
                                    Console.WriteLine(" ");
                                }
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("\t\t\t\tTu już stoji hotel! Więcej domków nie jesteś w stanie kupić");
                                Console.WriteLine("\t\t\t\tRuch kolejnego gracza");
                                Console.WriteLine(" ");
                            }
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("\t\t\tTa dzialka ma już swojego innego wlasciciela");
                            foreach (Gracz szukanygracz in Monopoly.Gracze)
                            {
                                if (szukanygracz.Name == Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Wlasciciel)
                                {
                                    if (Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].IleDomkow != 0)
                                    {
                                        Console.WriteLine("\t\t\t\nA jej wlascicielem jest {0}", Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Wlasciciel);
                                        gracz.ZmienKwote(Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].KwotaZaWejscie[Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].IleDomkow - 1]);
                                        szukanygracz.ZmienKwote(-Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].KwotaZaWejscie[Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].IleDomkow - 1]);
                                        Console.WriteLine("\t\t\tZaplaciłeś mu {0}", Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].KwotaZaWejscie[Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].IleDomkow - 1]);
                                        Console.WriteLine("\t\t\tRuch kolejnego gracza");
                                        Console.WriteLine(" ");

                                    }
                                    else
                                    {
                                        Console.WriteLine("\t\t\tA jej wlascicielem jest {0}", Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].Wlasciciel);
                                        gracz.ZmienKwote(Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].KwotaZaWejscie[Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].IleDomkow]);
                                        szukanygracz.ZmienKwote(-Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].KwotaZaWejscie[Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].IleDomkow]);
                                        Console.WriteLine("\t\t\tZaplaciłeś mu {0}", Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].KwotaZaWejscie[Monopoly.Pola[gracz.AktualnaPozycjaNaPlanszy - 1].IleDomkow]);
                                        Console.WriteLine("\t\t\tRuch kolejnego gracza");
                                        Console.WriteLine("   ");
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine("Kliknij Enter, by zakończyć swój ruch...");
                    Console.ReadLine();
                }
                Console.WriteLine("\t\t\tKliknij Enter aby rozpocząć {0} rundę: ", numerRundy + 1);
                numerRundy++;
                Console.WriteLine("");
                Console.ReadLine();
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}