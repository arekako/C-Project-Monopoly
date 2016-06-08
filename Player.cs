using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_new
{
    public class Player
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public int Cash{get;set;}
        public int CurrentPosition{get;set;}
        public int Number { get; set; }//
        public List<Card> Posessions{get;set;}//These are the fields which the player bought
       
        public Player(int id,string name,int cash,int currentposition,List<Card> posessions,int number)
        {
            Id = id;
            Name = name;
            Cash = cash;
            CurrentPosition = currentposition;
            Posessions = posessions;
            Number = number;
        }
        public void InformationAboutYourself()
        {
            Console.WriteLine("┌-----------------------------------------------------┐");
            Console.WriteLine("│\tId gracza:                  {0}", this.Id);
            Console.WriteLine("│\tImie gracza:                {0}", this.Name);
            Console.WriteLine("│\tKwota jaką dysponuje gracz: {0}", this.Cash);
            Console.WriteLine("│\tObecnie jest na polu:       {0}", this.CurrentPosition);
            Console.WriteLine("│\tIlość nieruchomości:        {0}", this.Posessions.Count());
            Console.WriteLine("└-----------------------------------------------------┘");
        }
        public int SwitchCurrentPosition(int howmany)
        {
            this.CurrentPosition += howmany;
            return this.CurrentPosition;
        }
        public int MoneyChange(int howmany)
        {
            this.Cash -= howmany;
            return this.Cash;
        }
        public void WelcomePlayer()
        {
            Console.WriteLine("┌-----------------------------------------------------┐");
            Console.WriteLine("│\tWitaj w grze               {0}   ", Name);
            Console.WriteLine("│\tDodano gracza nr           {0}", Id);
            Console.WriteLine("│\tKwota, którą posiadasz to: {0}   ", Cash);
            Console.WriteLine("└-----------------------------------------------------┘");
        
        }
        public void GoThroughTheStart()
        {
            this.Cash += 50;
        }
        public int Draw()
        {
            Console.WriteLine("Losowanie...Poczekaj aż kostka się zatrzymie!");
            System.Threading.Thread.Sleep(2000);
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
            Console.WriteLine("{0}", Board.DrawACube(wyl));//
            return wyl;
        }
        public void StartAnotherRound(int boardsize)
        {
            ////////////////////////////////////////When we go beyond the scope of the board//////////////////////////
            try
            {
                if (CurrentPosition > boardsize)//10
                {
                    GoThroughTheStart();//
                    CurrentPosition = (CurrentPosition - boardsize) % boardsize;
                    if (CurrentPosition == 0)
                    {
                        CurrentPosition = 1;
                    }
                }
                Console.WriteLine("\nAktualna pozycja na planszy :" + CurrentPosition);
            }
            catch
            {
                Console.WriteLine("Nieprawidłowy rozmiar planszy");
            }
        
        }
        public void InfoDecision()
        {
            Console.WriteLine("\tWpisz t (jeśli tak) lub n (jeśli nie).\n\tZatwierdź Enterem!");
        }
        public bool Decision()
        {
            InfoDecision();
            string decisionVariable;
            decisionVariable = Console.ReadLine();
            try
            {
                if (decisionVariable == "t")
                {
                    return true;
                }
                else if (decisionVariable == "n")
                {
                    return false;
                }
            }
            catch
            {
                Console.WriteLine("\tBłąd.\n\tWybierz poprawną wartość!!!\n");
            }
            return Decision();
        }
        public int Numer()
        {
            return CurrentPosition - 1;
        }
        public void ViewOwnPosession(int which)
        {
            try
            {
                var pos = Posessions.Where(x => x.Id == which).First();
                pos.IlustradeTheCard();
            }
            catch
            {
                Console.WriteLine("Nie masz takiej działki");
            }

        }
        public void SelectOption()
        {
            Console.WriteLine("Wybierz jedną z opcji <zatwierdź Enterem>:\n\t\t1-Losowanie\n\t\t2-Obejrz swoje działki");
            try
            {
                int playerDecision = int.Parse(Console.ReadLine());
                switch (playerDecision)
                {
                    case 1:
                        Console.WriteLine("Teraz bedziesz losować");
                        break;

                    case 2:
                        if (Posessions.Count() == 0)
                        {
                            Console.WriteLine("Nie masz jeszcze żadnej posiadłości.");
                            SelectOption();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Teraz musisz wybrać jedną ze swoich działek, masz nastepujące możliwości: ");
                            foreach (Card p in Posessions)
                            {
                                Console.WriteLine(p.Id);
                            }
                            Console.WriteLine("Wpisz numer działki z podanej wyżej listy");
                        }
                        try
                        {
                            int num = int.Parse(Console.ReadLine());
                            ViewOwnPosession(num);
                            SelectOption();
                        }
                        catch
                        {
                            Console.WriteLine("Błąd. Wybierz poprawną liczbę");
                        }
                        break;
                    default:
                        Console.WriteLine("Wybierz poprawną wartość");
                        SelectOption();
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Wybierz poprawną wartość");
                SelectOption();
            }
        }
    }
}
