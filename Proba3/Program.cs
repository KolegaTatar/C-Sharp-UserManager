using Proba3.classes;

namespace Proba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run == true)
            {
                Console.WriteLine("         MENU");
                Console.WriteLine("1. Kalkulator walutowy ");
                Console.WriteLine("2. Wyjście");
                Console.Write("Twój wybór to: ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Wybrałeś: Kalkulator walutowy ");
                    Waluta1 w1 = new Waluta1();
                    Waluta2 w2 = new Waluta2();
                    bool ster = true;
                    do
                    {
                        try
                        {
                            Console.Write("Podaj kwotę: ");
                            w1.Kwota = float.Parse(Console.ReadLine().Replace('.', ','));
                            Console.WriteLine("Wybierz walute z jakiej zamieniasz: [ Euro, Dolra, PLN ]");
                            w1.Waluta_1 = Console.ReadLine().ToLower();
                            Console.WriteLine("Wybierz walute na jaką chcesz zamienić: [ Euro, Dolra, PLN ]");
                            w2.Waluta_2 = Console.ReadLine().ToLower();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Podałeś błędny format kwoty " + e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Mamy doczynienia z błędem: " + e.Message);
                        }

                        if ((w1.Waluta_1 == "Euro" || w1.Waluta_1 == "euro" || w1.Waluta_1 == "Dolar" || w1.Waluta_1 == "dolar" || w1.Waluta_1 == "PLN" || w1.Waluta_1 == "pln") && (w2.Waluta_2 == "Euro" || w2.Waluta_2 == "euro" || w2.Waluta_2 == "Dolar" || w2.Waluta_2 == "dolar" || w2.Waluta_2 == "PLN" || w2.Waluta_2 == "pln"))
                        {
                            ster = false;
                        }
                        else
                        {
                            Console.WriteLine("Błędne dane, wpisz jeszcze raz");

                        }
                    } while (ster==true);

                    //konwersja
                    float wynik = 0.0f;
                    if(w1.Waluta_1 == "dolar" && w2.Waluta_2=="pln")
                    {
                        wynik = w1.Kwota * w1.kursy[1];
                        Console.WriteLine("Kwota "+w1.Kwota+" w "+w1.Waluta_1+" po kursie " + w1.kursy[1]+" wynosi: "+wynik+" "+w2.Waluta_2);
                    }
                    if (w1.Waluta_1 == "dolar" && w2.Waluta_2 == "euro")
                    {
                        wynik = w1.Kwota * w1.kursy[0];
                        Console.WriteLine("Kwota " + w1.Kwota + " w " + w1.Waluta_1 + " po kursie " + w1.kursy[0] + " wynosi: " + wynik + " " + w2.Waluta_2);
                    }
                    if (w1.Waluta_1 == "dolar" && w2.Waluta_2 == "dolar")
                    {
                        wynik = w1.Kwota * 1;
                        Console.WriteLine("Kwota " + w1.Kwota + " w " + w1.Waluta_1 + " po kursie " + 1 + " wynosi: " + wynik + " " + w2.Waluta_2);
                    }


                    if (w1.Waluta_1 == "euro" && w2.Waluta_2 == "pln")
                    {
                        wynik = w1.Kwota * w1.kursy[2];
                        Console.WriteLine("Kwota " + w1.Kwota + " w " + w1.Waluta_1 + " po kursie " + w1.kursy[2] + " wynosi: " + wynik + " " + w2.Waluta_2);
                    }
                    if (w1.Waluta_1 == "euro" && w2.Waluta_2 == "dolar")
                    {
                        wynik = w1.Kwota * w1.kursy[3];
                        Console.WriteLine("Kwota " + w1.Kwota + " w " + w1.Waluta_1 + " po kursie " + w1.kursy[3] + " wynosi: " + wynik + " " + w2.Waluta_2);
                    }
                    if (w1.Waluta_1 == "euro" && w2.Waluta_2 == "euro")
                    {
                        wynik = w1.Kwota * 1;
                        Console.WriteLine("Kwota " + w1.Kwota + " w " + w1.Waluta_1 + " po kursie " + 1 + " wynosi: " + wynik + " " + w2.Waluta_2);
                    }


                    if (w1.Waluta_1 == "pln" && w2.Waluta_2 == "dolar")
                    {
                        wynik = w1.Kwota * w1.kursy[5];
                        Console.WriteLine("Kwota " + w1.Kwota + " w " + w1.Waluta_1 + " po kursie " + w1.kursy[5] + " wynosi: " + wynik + " " + w2.Waluta_2);
                    }
                    if (w1.Waluta_1 == "pln" && w2.Waluta_2 == "euro")
                    {
                        wynik = w1.Kwota * w1.kursy[5];
                        Console.WriteLine("Kwota " + w1.Kwota + " w " + w1.Waluta_1 + " po kursie " + w1.kursy[5] + " wynosi: " + wynik + " " + w2.Waluta_2);
                    }
                    if (w1.Waluta_1 == "pln" && w2.Waluta_2 == "pln")
                    {
                        wynik = w1.Kwota * 1;
                        Console.WriteLine("Kwota " + w1.Kwota + " w " + w1.Waluta_1 + " po kursie " + 1 + " wynosi: " + wynik + " " + w2.Waluta_2);
                    }
                }
                else if (option == 2)
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("Błędny wybór, spróbuj ponownie");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Dziękujemy za korzystanie z kalkultora walut");
        }
    
    }
}