Console.Write("Números pares entre 0 e ?: ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());

if(numeroDigitado >=1 )
{
    int numeroPar = 0;

    while (numeroPar <= numeroDigitado)
    {
        Console.Write($"{numeroPar} ");
        numeroPar += 2;
    }
}
else
{
    Console.WriteLine($"O número {numeroDigitado} não é inteiro positivo.");
}