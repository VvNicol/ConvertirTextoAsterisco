namespace ConvertirTextoAsterisco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un texto");
            string frase = Console.ReadLine();
            Console.WriteLine("Escribe el caracter a cambiar");
            char caracterCambio = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Escribe el caracter por que cambia:");
            char caracterPorCambiar = Convert.ToChar(Console.ReadLine());

            frase.Replace(caracterCambio, caracterPorCambiar);
            Console.WriteLine(frase.Replace(caracterCambio , caracterPorCambiar));
        }
    }
}
