namespace ejercicio4
{
    public class modista
    {
        public static void Main ()
        {
            double Pulg = 0;
            double Mt = 0.0254;
            double Cpulg = 0;
            double MeDos = 0;

            Console.WriteLine("Digite la cantidad de metros necesitados de tela");
            MeDos = double.Parse(Console.ReadLine());

            Cpulg = MeDos / Mt;
            Console.WriteLine($"La cantidad de pulgadas en tela es {Cpulg} ");
        }
        
    }
}