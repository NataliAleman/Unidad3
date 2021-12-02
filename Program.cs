using System;
public class AhorcadoNatali
{
    public static void Main()
    {
        //el usuario ingresa el numero de letras que tiene su palabra e ingresa su palabra
        string palabra;
        int n;
        Console.WriteLine("Bienvenido por favor ingresa cuantas letras tiene tu palabra, e incluye espacios si es que los lleva");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la palabra para que el otro jugardo intente adivinarla");
        palabra = Console.ReadLine();
        // En mi caso la palabra se muestra con una serie de guiones -----
        string mostrarpalabra = "";
        for (int i = 0; i < n; i++)
        {
            if (palabra[i] == ' ')
                mostrarpalabra = mostrarpalabra + " ";
            else
                mostrarpalabra = mostrarpalabra + " - ";
        }
        //variables
        int fallosrestantes = 5;
        char letractual;
        bool terminado = false;

        //estructura do while para las oportunidades de la persona
        do
        {
            //se muestra la palabra oculta y el usuario intenta adivinar con una letra
            Console.WriteLine("Palabra oculta: {0}", mostrarpalabra);
            Console.WriteLine("Tus oportunidades restantes son: {0}", fallosrestantes);

            //el usuario elige otra letra
            Console.WriteLine("Por favor, introduzca otra letra");
            letractual = Convert.ToChar(Console.ReadLine());

            //si la letra no es parte de la palabra a adivinar el jugador perdera una oportunidad de las 5 que tiene
            if (palabra.IndexOf(letractual) == -1)
                fallosrestantes--;
            // si la letra es parte de la palabra se mostrara en los lugares de la palabra correspondiente, por lo cual no se pierde ninguna oportunidad de las 5 que tiene
            string Mostrarsiguiente = "";
            for (int i = 0; i < n; i++)
            {
                if (letractual == palabra[i])
                    Mostrarsiguiente = Mostrarsiguiente + letractual;
                else
                    Mostrarsiguiente = Mostrarsiguiente + mostrarpalabra[i];
            }
            mostrarpalabra = Mostrarsiguiente;
            // si se adivino la palabra o si de plano el usuario ya no tiene intentos
            if (mostrarpalabra.IndexOf("-") < 0)
            {
                Console.WriteLine("Felicidades, la palabra que adivinaste es: {0}", palabra);
                terminado = true;
            }
            if (fallosrestantes == 0)
            {
                Console.WriteLine("Perdiste tus intentos la palabra para adivinar era: {0}", palabra);
                terminado = true;
            }
            Console.WriteLine();
        }
        while (!terminado);
        Console.ReadKey();
    }
}
