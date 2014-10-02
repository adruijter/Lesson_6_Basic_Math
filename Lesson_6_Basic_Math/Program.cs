using System;

namespace Lesson_6_Basic_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double quotient, getal1, getal2, som, verschil, modulus,
                    halveKorteAs, halveLangeAs, oppervlakteElipse,  product;


            // Definieer een string variabele die de invoer kan bevatten
            string eersteInvoerGetal, tweedeInvoerGetal;

            // Schrijf een melding naar de console dat er een getal moet worden ingevoerd
            Console.WriteLine("Geef een getal tussen de 0 en de 120");

            // Lees het eerste getal in van het scherm
            eersteInvoerGetal = Console.ReadLine();
            
            // Maak van de variabele van het type string eersteInvoerGetal een double.
            getal1 = Convert.ToDouble(eersteInvoerGetal);

            // Schrijf een melding naar het scherm dat er een tweede getal ingevoerd moet worden
            Console.WriteLine("Geef een getal tussen de 0 en de 200");

            //Lees het tweede getal in van het scherm
            tweedeInvoerGetal = Console.ReadLine();

            // Maak van de variabele van het type string tweedeInvoerGetal een double
            getal2 = Convert.ToDouble(tweedeInvoerGetal);

            
            som = getal1 + getal2;
            verschil = getal1 - getal2;
            product = getal1 * getal2;
            modulus = getal1 % getal2;
            quotient = getal1 / getal2;

            Console.WriteLine("De som van " + getal1.ToString() + 
                              " + " + getal2.ToString() + 
                              " = " + som.ToString());
            Console.WriteLine("Het verschil van " + getal1.ToString() +
                              " - " + getal2.ToString() +
                              " = " + verschil.ToString());
            Console.WriteLine("Het product van " + getal1.ToString() +
                             " x " + getal2.ToString() +
                             " = " + product.ToString());
            Console.WriteLine("De modulus van " + getal1.ToString() +
                             " % " + getal2.ToString() +
                             " = " + modulus.ToString());
            Console.WriteLine("Het quotient van " + getal1.ToString() +
                             " / " + getal2.ToString() +
                             " = " + quotient.ToString());

          
            
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("De berekening van de oppervlakte van een elipse");
            Console.Write("\nGeef eerst de lengte van de korte halve as: ");
            string stringHalveKorteAs = Console.ReadLine();

            halveKorteAs = Convert.ToDouble(stringHalveKorteAs);

            Console.Write("\nGeef nu de lengte van de korte lange as: ");
            
            // Type de waarde in van de halve lange as.
            string stringHalveLangeAs = Console.ReadLine();

            
            halveLangeAs = Convert.ToDouble(stringHalveLangeAs);

            oppervlakteElipse = Math.Round(halveLangeAs * halveKorteAs * Math.PI, 2);
            
            Console.WriteLine("\nDe oppervlakte van de elipse is: {0} ", oppervlakteElipse.ToString());        
            
            Console.ReadLine();
        }
    }
}
