namespace ejercicio2
{
    public class leche 
    {
        public static void Main()
        {
            double LPG = 3.785;
            double LV, PG, CG, VV;

            Console.WriteLine("Por favor digite los litros de la venta ");
            LV = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor digite el precio del galon");
            PG = double.Parse(Console.ReadLine());
            CG = LV / LPG;
            VV = CG * PG;
            Console.WriteLine($"El valor venta es {VV}");
            Console.WriteLine($"Cantidad de galones {CG}");

        }
    }
  
   
}


