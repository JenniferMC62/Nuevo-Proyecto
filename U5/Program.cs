class Program{
    static void Main()
    {
        uint? edad = 0;

        Console.WriteLine("Captura tu edad y presiona 'Enter'");
        string? edadCapturada = Console.ReadLine();
        if(edadCapturada is not null)
        {
            try{
            edad = uint.Parse(edadCapturada);
            }

            catch(System.FormatException)
            {
                Console.WriteLine("El formato es incorrecto");
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("Esa es una edad muy grande o muy pequeña");
            }
        }
        if(edad is not null)
        Console.WriteLine($"Tu edad es {edad}");
        else
        Console.WriteLine($"No se capturó tu edad");

    }

}