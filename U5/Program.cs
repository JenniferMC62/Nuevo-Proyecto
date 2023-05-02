class Program{
    static void Main()
    {
        int edad = 0;

        Console.WriteLine("Captura tu edad y presiona 'Enter'");
        string? edadCapturada = Console.ReadLine();
        if(edadCapturada is not null)
        {
            try{
            edad = int.Parse(edadCapturada);
            }

            catch(System.FormatException)
            {
                Console.WriteLine("El formato es incorrecto");
            }
        }
        if(edad is not null)
        Console.WriteLine($"Tu edad es {edad}");
        else
        Console.WriteLine($"No se capturó tu edad");

    }

}