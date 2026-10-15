string cifra = "", numeroIntero = "";
int i = 1;

do
{
    do
    {
        Console.WriteLine("Inserire la cifra N" + i + " oppure N per fermarsi");
        cifra = Console.ReadLine();

        if (cifra != "N" && (cifra != "1" && cifra != "2" && cifra != "3" && cifra != "4" && cifra != "5" && cifra != "6" && cifra != "7" && cifra != "8" && cifra != "9" && cifra != "0"))
        {
            Console.WriteLine("valore non valido, reinserire");
        }
    } while (cifra != "N" && (cifra != "1" && cifra != "2" && cifra != "3" && cifra != "4" && cifra != "5" && cifra != "6" && cifra != "7" && cifra != "8" && cifra != "9" && cifra != "0"));

    if (cifra != "N")
    {
        numeroIntero = numeroIntero + cifra;
    }

    i++;
} while (cifra != "N");

Console.WriteLine("Il numero e' " + numeroIntero);

