
namespace ejercicio1
{
   public class lotes
    {
        public static void Main ()
        {
            decimal a, b, c, at, ar, ato;
            Console.WriteLine ("Por favor digite la longitud de A");
            a = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese la longitud de B");
                b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la longitud de C");
            c = decimal.Parse(Console.ReadLine());
            ar = b * c;
            at = ((a - c) * b) / 2;
            ato = ar + at;
            Console.WriteLine($"El area del lote es {ato}"); 


        }
    }
}