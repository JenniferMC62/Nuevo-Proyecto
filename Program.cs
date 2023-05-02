class Program{
    static void Main()
    {
        int edad = 0;

        Console.WriteLine("Captura tu edad y presiona 'Enter'");
        string? edadCapturada = Console.ReadLine();
        if(edadCapturada is not null)
        {
            edad = int.Parse(edadCapturada);
        }
        Console.WriteLine($"Tu edad es {edad}");

    }

}