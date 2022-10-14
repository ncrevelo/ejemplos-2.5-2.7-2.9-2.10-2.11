namespace ejercicio3
{
    public class Sueldo
    {
        public static void Main()
        {
            int SS, CH, VH;
            Console.WriteLine("Por favor digite las horas trabajadas");
            CH = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor digite el valor de la hora");
            VH = int.Parse(Console.ReadLine());
            SS = CH * VH;
            Console.WriteLine($"El sueldo semanal es{SS}");
        }

    }
}
 
