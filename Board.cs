using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_new
{
    public class Board
    {
        public List<Field> Pola;
        public List<Player> Players;//tutaj ich nie tworzymy ale w kodzie programu
      
        public Board()
        {
            this.Pola=new List<Field>();
            this.Players = new List<Player>();//to jest bardzo wazne , bez tego wyskakuje mi blad, nawet jesli tu nie bede korzystać z graczy to musi byc to zainicjowane
            //do domysnego konstuktora, przecież zawsze ma być tworzona tylko jedna plansza
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

            this.Pola.Add(new Card(1, "Syria", 250, false, "brak", 30, tablica_oplat1, 0));
            this.Pola.Add(new Card(2, "Portugalia", 250, false, "brak", 35, tablica_oplat2, 0));
            this.Pola.Add(new Card(3, "Wlochy", 270, false, "brak", 40, tablica_oplat3, 0));
            this.Pola.Add(new SpecialCard(4, "Szansa 1", "Wygrales na loterii", 100));
            this.Pola.Add(new Card(5, "Szkocja", 280, false, "brak", 40, tablica_oplat5, 0));
            this.Pola.Add(new Card(6, "Anglia", 300, false, "brak", 50, tablica_oplat6, 0));
            this.Pola.Add(new Card(7, "Polska", 310, false, "brak", 55, tablica_oplat7, 0));
            this.Pola.Add(new Card(8, "Turcja", 330, false, "brak", 55, tablica_oplat8, 0));
            this.Pola.Add(new SpecialCard(9, "Ryzyko 1", "Placisz podatek za świeże powietrze", -100));
            this.Pola.Add(new Card(10, "Ukraina", 380, false, "brak", 60, tablica_oplat10, 0));

            this.Pola.Add(new Card(11, "Brazylia", 380, false, "brak", 60, tablica_oplat11, 0));
            this.Pola.Add(new SpecialCard(12, "Szansa 2", "Wygrales na loterii", 150));
            this.Pola.Add(new Card(13, "Urugwaj", 390, false, "brak", 65, tablica_oplat13, 0));
            this.Pola.Add(new Card(14, "Paragwaj", 400, false, "brak", 70, tablica_oplat14, 0));
            this.Pola.Add(new Card(15, "Boliwia", 400, false, "brak", 70, tablica_oplat15, 0));
            this.Pola.Add(new Card(16, "Chile", 400, false, "brak", 80, tablica_oplat16, 0));
            this.Pola.Add(new SpecialCard(17, "Ryzyko 2", "Przegrałes w karty", -150));
            this.Pola.Add(new Card(18, "Wenezuela", 430, false, "brak", 85, tablica_oplat18, 0));
            this.Pola.Add(new Card(19, "Belize", 450, false, "brak", 90, tablica_oplat19, 0));
            this.Pola.Add(new Card(20, "Trynidad i Tobago", 480, false, "brak", 90, tablica_oplat20, 0));

            this.Pola.Add(new Card(21, "Chiny", 490, false, "brak", 95, tablica_oplat21, 0));
            this.Pola.Add(new Card(22, "Japonia", 490, false, "brak", 95, tablica_oplat22, 0));
            this.Pola.Add(new SpecialCard(23, "Szansa 3", "Wygrales na loterii", 250));
            this.Pola.Add(new Card(24, "Katar", 500, false, "brak", 90, tablica_oplat24, 0));
            this.Pola.Add(new Card(25, "Indie", 510, false, "brak", 90, tablica_oplat25, 0));
            this.Pola.Add(new Card(26, "Indonezja", 520, false, "brak", 110, tablica_oplat26, 0));
            this.Pola.Add(new Card(27, "Korea", 510, false, "brak", 100, tablica_oplat27, 0));
            this.Pola.Add(new SpecialCard(28, "Ryzyko 3", "Przegrałeś na loterii",-200));
            this.Pola.Add(new Card(29, "Kirgistan", 550, false, "brak", 90, tablica_oplat29, 0));
            this.Pola.Add(new Card(30, "Malezja", 540, false, "brak", 90, tablica_oplat30, 0));

            this.Pola.Add(new Card(31, "Irak", 550, false, "brak", 95, tablica_oplat31, 0));
            this.Pola.Add(new SpecialCard(32, "Szansa 4", "Wygrales na loterii", 300));
            this.Pola.Add(new Card(33, "Egipt", 570, false, "brak", 90, tablica_oplat33, 0));
            this.Pola.Add(new Card(34, "Tunezja", 580, false, "brak", 90, tablica_oplat34, 0));
            this.Pola.Add(new Card(35, "RPA", 580, false, "brak", 90, tablica_oplat35, 0));
            this.Pola.Add(new SpecialCard(36, "Ryzyko 4", "Wygrales na loterii", -250));
            this.Pola.Add(new Card(37, "Senegal", 610, false, "brak", 95, tablica_oplat37, 0));
            this.Pola.Add(new Card(38, "Nigeria", 630, false, "brak", 105, tablica_oplat38, 0));
            this.Pola.Add(new Card(39, "Laos", 650, false, "brak", 120, tablica_oplat39, 0));
            this.Pola.Add(new Card(40, "Liberia", 680, false, "brak", 130, tablica_oplat40, 0));
        }
        public static void ConsoleClear()
        {
            Console.Clear();
        }//
        public static void Instruction()
        {
            Console.WriteLine("┌---------------------------------------------------┐");
            Console.WriteLine("\tAutorem Aplikacji jest Arkadiusz Pepliński.\n");
            Console.WriteLine("\tWitam w grze Monopoly dla max 10 graczy.\n");
            Console.WriteLine("\tRozgrywka toczy się na planszy o różnych wymiarach\n \tw zależności od ilości graczy:\n");
            Console.WriteLine("\t 2-3   graczy 10 pól w tym 2 specjalne\n");
            Console.WriteLine("\t 4-5   graczy 15 pól w tym 3 specjalne\n");
            Console.WriteLine("\t 6-9   graczy 30 pól w tym 6 specjalnych\n");
            Console.WriteLine("\t 10    graczy 40 pól w tym 8 specjalnych\n");
            Console.WriteLine("\t ŻYCZĘ MIŁEJ ZABAWY\n");
            Console.WriteLine("└---------------------------------------------------┘");
            Console.WriteLine("Kliknij Enter by rozpocząć grę");
            Console.ReadLine();
            System.Threading.Thread.Sleep(1000);
            ConsoleClear();
        }//
        public static string DrawACube(int number)
        {
            string napis = "";
            switch (number)
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
                    napis = "\n┌---┐\n│* *│\n│* *│ +\n│* *│\n└---┘\n" + DrawACube(number - 6);
                    break;
            }
            return napis;
        }//dodałem static
        public void IsTheEnd()
        {
            int howMany = Players.Count();//3 tutaj zamiana
            try
            {
                foreach (Player gr in Players)
                {
                    if (gr.Cash < 0 && howMany != 1)
                    {
                        howMany--;
                        Console.WriteLine("\t\tJest gracz który nie ma już pieniędzy...");
                        Console.ReadKey();
                        ReductionPlayer();
                        if (howMany == 1)
                        {
                            Console.WriteLine("\t\t\t\tKONIEC GRY");
                            Console.WriteLine("\t\tZatwierdz Enterem wyjście z gry:");
                            Console.ReadKey();
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Wyjątek : Brak graczy {0}",e.Message);
            }
        }
        public bool IsRemovePlayer()
        {
            foreach (Player gr in Players)
            {
                if (gr.Cash < 0)
                {
                    Console.WriteLine("Jeden z graczy zbankrutował!");
                    Console.WriteLine("Jest nim {0}!", gr.Name.ToUpper());
                    Console.WriteLine("Wyrzucamy go z gry. Jego nieruchomości są już do kupienia.");
                    foreach (Field p in Pola)//Pole
                    {
                        if(p.Type()=="P")
                        {
                            if (p.Owner.ToLower() == gr.Name.ToLower())
                            {
                                p.Owner = "brak";
                                p.IsOccupied = false;
                                p.HowManyHouses = 0;
                            }
                        }
                    }
                    return true;
                }
            }
            return false;
        }
        public int WhoIsDelete()
        {
            for (int i = 0; i < Players.Count(); i++)
            {
                if (Players[i].Cash < 0)
                {
                    return i;
                }
            }
            return 100;
        }
        public string IsFinish()
        {
            if (Players.Count() == 1)
            {
                Console.Clear();
                Console.WriteLine("KONIEC GRY. Zwyciezcą jest {0}", Players[0].Name);
                Console.WriteLine("Kliknij 9Enter by wyłączyć aplikację!");//
                while (Console.ReadLine() != "9")//
                {
                    IsFinish();
                }
                System.Diagnostics.Process.GetCurrentProcess().Kill();//
                return "KONIEC";
            }
            return " ";
        }
        public List<Field> SetBoards(int numberofplayers)//List<Pole>
        {
            if (numberofplayers < 4)
            {
                for (int i = 40; i > 10; i--)//39
                {
                    Pola.RemoveAt(i - 1);
                }
                return Pola;
            }
            else if ((numberofplayers >= 4) && (numberofplayers < 6))
            {
                for (int i = 40; i > 15; i--)
                {
                    Pola.RemoveAt(i - 1);
                }
                return Pola;
            }
            else if ((numberofplayers >= 6) && (numberofplayers < 10))
            {
                for (int i = 40; i > 30; i--)
                {
                    Pola.RemoveAt(i - 1);
                }
                return Pola;
            }
            else
            {
                return Pola;
            }
        }
        public void BoardInformation()
        {
            int amountSize = 0;//zajete
            int numberofFields = 0;
            int numberofSpecialFields = 0;
            foreach (Field pole in Pola)
            {
                if (pole.Type() == "P")
                {
                    numberofFields++;
                    if (pole.IsOccupied == true)
                    {
                        amountSize++;
                    }
                }
                else
                {
                    numberofSpecialFields++;
                }
            }
            Console.WriteLine("┌------------Informacje o planszy-------------------┐");
            Console.WriteLine("│");
            Console.WriteLine("│Łączna ilość pól ogólnie     :   {0}",Pola.Count());//PolaCount()
            Console.WriteLine("│Łączna ilość pól do kupienia :   {0}", numberofFields-amountSize);//PolaCount()
            Console.WriteLine("│Łączna ilość pól specjalnych :   {0}", numberofSpecialFields);
            Console.WriteLine("│\t\tZajętych pól jest {0}", amountSize);

            foreach (Field pole in Pola)
            {
                if (pole.IsOccupied == true)
                {
                    Console.WriteLine("│\tId: {0} - Nazwa: {1} - Ilość domków: {2} - Właścicielem jest {3}", pole.Id, pole.Name, pole.HowManyHouses, pole.Owner);
                }
            }
            Console.WriteLine("└---------------------------------------------------┘");
        }//
        public void ReductionPlayer()
        {
            while (IsRemovePlayer() == true)
            {
                int zmienna = WhoIsDelete();
                this.Players.RemoveAt(zmienna);//-1
                Console.WriteLine("Wyrzucilismy gracza z gry!");
                Console.WriteLine("Pozostało {0} graczy", this.Players.Count());
                Console.WriteLine("Kliknij Enter, aby kontynuować z mniejszą liczbą graczy");
                Console.ReadLine();
                ConsoleClear();
            }
        
        }
        public int EnterTheNumberOfPlayers()
        {
            ConsoleClear();
            Console.WriteLine("Podaj liczbę graczy  z zakresu (2-10):");
            string liczba_graczy_str = Console.ReadLine();
            try 
            { 
            int liczba_graczy = Int32.Parse(liczba_graczy_str);
                while (!(liczba_graczy < 11 && liczba_graczy > 1))
            {
                return EnterTheNumberOfPlayers();
            }
                return liczba_graczy;
            }
            catch
            {
                Console.WriteLine("Zła wartość! Podana wartość musi być liczbą z odpowiedniego zakresu!");
                System.Threading.Thread.Sleep(2000);
            }
          return EnterTheNumberOfPlayers();//gdy wywołamy np: r
        }
        public void EnterThePlayers(int number)
        {
            string varName;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Podaj nazwę gracza {0}. Zatwierdź Enterem", i + 1);
                varName = Console.ReadLine();
                Board.ConsoleClear();
                this.Players.Add(new Player(i + 1, varName, 5000, 0, new List<Card>(), number));//5000
                this.Players[i].WelcomePlayer();
                Console.WriteLine("Kliknij Enter, aby kontynuować...");
                Console.ReadLine();
                Board.ConsoleClear();
            }
        }
        public void BuyField(Player player)
        {
            this.Pola[player.CurrentPosition - 1].IlustradeTheCard();
            Console.WriteLine("\tCzy chcesz kupić  wolną dzialkę?");
            if (player.Decision() == true)
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("\tKupiles dzialke o numerze {0}", player.CurrentPosition);
                player.MoneyChange(this.Pola[player.CurrentPosition - 1].Cost);//ODEJMOWANIE
                this.Pola[player.CurrentPosition - 1].ChangeOfOwner(player.Name);//PRZYPISANIE WLASCICIELA DO DZIALKI
                this.Pola[player.CurrentPosition - 1].IsOccupied = true;
                player.Posessions.Add((Card)this.Pola[player.CurrentPosition - 1]);// PRZYPISANIE DZIALKI DO GRACZA
                this.Pola[player.CurrentPosition - 1].Information();
                Console.WriteLine("\t\tRuch kolejnego gracza\n");
            }
            else
            {
                Console.WriteLine("\n\tNie zdecydowałeś się na kupno działki.");
                Console.WriteLine("\n\tRuch kolejnego gracza\n");
            }
        }
        /////////////////////////////////////////Metoda z algorytmem gry dla wielu graczy////////////////////////////////////////
        public void Game()
        {
            int RoundNumber = 1;
            Instruction();
            /////////////////////////////////       Create Players     ///////////////////////////////////
            int numberOfPlayers = EnterTheNumberOfPlayers();
            ConsoleClear();
            EnterThePlayers(numberOfPlayers);
            this.SetBoards(numberOfPlayers);//ustawia liczbę pol w zalezności od ilosci graczy
            //////////////////////////            Proper Game                 //////////////////////////////////
            while (true)
            {
                ///////////////////////         First, check whether the conditions further games       /////////
                IsTheEnd();
                IsFinish();
                ConsoleClear();
                Console.WriteLine("_________________Runda nr.{0}_________", RoundNumber);
                BoardInformation();
                foreach (Player player in this.Players)
                {
                    player.InformationAboutYourself();
                    player.SelectOption();
                    Console.WriteLine("{0}, kliknij Enter by losować", player.Name);
                    Console.ReadLine();
                    player.SwitchCurrentPosition(player.Draw());
                    System.Threading.Thread.Sleep(2000);
                    ////////////////////////////////////////When we go beyond the scope of the board//////////////////////////
                    player.StartAnotherRound(this.Pola.Count());
                    ////////////////////////////////////////// If we fall into the field of P-type and you can buy them/////////////////////
                    if ((this.Pola[player.Numer()].IsOccupied == false) && (this.Pola[player.Numer()].Type() == "P"))//Card to buy
                    {
                        Console.WriteLine("\nObecnie stoisz na tym polu :");
                        if (player.Cash >= this.Pola[player.Numer()].Cost)//if we have money
                        {
                            this.BuyField(player);
                        }
                        else
                        {
                            this.Pola[player.Numer()].IlustradeTheCard();
                            Console.WriteLine("\tBrak środkow na kupno działki.Graj rozważnie");
                            Console.WriteLine("\tRuch kolejnego gracza\n");
                        }
                    }
                    else if ((this.Pola[player.Numer()].IsOccupied == true) && (this.Pola[player.Numer()].Type() == "P"))//Card not to buy
                    {
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("\t\t\tWjechales w zajętą dzialkę!");
                        if (this.Pola[player.Numer()].Owner == player.Name)//if card is our
                        {
                            Console.WriteLine("\t\t\tRozważ budowę domków");
                            this.Pola[player.Numer()].InformationAbutHouses();
                            if (this.Pola[player.Numer()].HowManyhouses() < 5)//if we can buy houses
                            {
                                Console.WriteLine("\t\t\tCzy chcesz kupić domek?");
                                if (player.Decision() == true)//if yes
                                {
                                    System.Threading.Thread.Sleep(2000);
                                    if (player.Cash >= this.Pola[player.Numer()].FeeForHouse)//if we can afford to buy (stać nas)
                                    {
                                        Console.WriteLine("\t\t\tZdecydowaleś się na kupno domku!");
                                        player.MoneyChange(this.Pola[player.Numer()].FeeForHouse);
                                        this.Pola[player.Numer()].ChangeTheNumberOfHouses();
                                        Console.WriteLine("\t\t\tZmieniono liczbę domkow na {0}", this.Pola[player.Numer()].HowManyHouses);
                                        Console.WriteLine("\t\t\tRuch kolejnego gracza\n");
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
                                    Console.WriteLine("\t\t\tRuch kolejnego gracza\n");
                                }
                            }
                            else
                            {
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("\t\t\t\tTu już stoji hotel! Więcej domków nie jesteś w stanie kupić");
                                Console.WriteLine("\t\t\t\tRuch kolejnego gracza\n");
                            }
                        }
                        else
                        {
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("\t\t\tTa dzialka ma już swojego innego wlasciciela");
                            foreach (Player szukanygracz in this.Players)
                            {
                                if (szukanygracz.Name == this.Pola[player.Numer()].Owner)
                                {
                                    if (this.Pola[player.Numer()].HowManyHouses != 0)
                                    {
                                        Console.WriteLine("\t\t\t\nA jej wlascicielem jest {0}", this.Pola[player.Numer()].Owner);
                                        player.MoneyChange(this.Pola[player.Numer()].AmountForEntrance[this.Pola[player.Numer()].HowManyHouses - 1]);
                                        szukanygracz.MoneyChange(-this.Pola[player.Numer()].AmountForEntrance[this.Pola[player.Numer()].HowManyHouses - 1]);
                                        Console.WriteLine("\t\t\tZaplaciłeś mu {0}", this.Pola[player.Numer()].AmountForEntrance[this.Pola[player.Numer()].HowManyHouses - 1]);
                                        Console.WriteLine("\t\t\tRuch kolejnego gracza\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\t\t\tA jej wlascicielem jest {0}", this.Pola[player.Numer()].Owner);
                                        player.MoneyChange(this.Pola[player.Numer()].AmountForEntrance[this.Pola[player.Numer()].HowManyHouses]);
                                        szukanygracz.MoneyChange(-this.Pola[player.Numer()].AmountForEntrance[this.Pola[player.Numer()].HowManyHouses]);
                                        Console.WriteLine("\t\t\tZaplaciłeś mu {0}", this.Pola[player.Numer()].AmountForEntrance[this.Pola[player.Numer()].HowManyHouses]);
                                        Console.WriteLine("\t\t\tRuch kolejnego gracza\n");
                                    }
                                }
                            }
                        }
                    }
                    else if (this.Pola[player.Numer()].Type() == "S")
                    {
                        this.Pola[player.Numer()].IlustradeTheCard();
                        player.Cash += this.Pola[player.Numer()].DoSomething;
                        Console.WriteLine("Zmieniono stan konta głownego");
                        Console.WriteLine("{1} aktualnie posiadasz {0}", player.Cash,player.Name);
                    }
                    Console.WriteLine("Kliknij Enter, by zakończyć swój ruch...");
                    Console.ReadLine();
                }
                Console.WriteLine("\t\t\tKliknij Enter aby rozpocząć {0} rundę: \n", RoundNumber + 1);
                RoundNumber++;
                Console.ReadLine();
                System.Threading.Thread.Sleep(2000);
            }


        }
    }
}

