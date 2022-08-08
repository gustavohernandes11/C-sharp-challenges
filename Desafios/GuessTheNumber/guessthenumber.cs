using System;

class GuessTheNumber
{
    static void Main(string[] args)
    {
    newgame:
        int randomNumber, userNumber;
        // Criando o número aleatório 
        Random rnd = new Random();
        randomNumber = rnd.Next(0, 10);

        Console.WriteLine("O número aleatório de 0 a 10 foi gerado! Você consegue descobrir qual número é?");

    retry:

        Console.WriteLine("Digite um número: ");
        userNumber = Int32.Parse(Console.ReadLine());
        if (userNumber > 10 | userNumber < 0)
        {
            Console.WriteLine("Esse número está fora do que é possível de ser gerado. (0 a 10)");
            goto retry;
        }

        if (userNumber > randomNumber)
        {
            Console.WriteLine("Errou. Tente um número menor da próxima vez!");
            goto retry;


        }
        else if (userNumber < randomNumber)
        {
            Console.WriteLine("Errou. Tente um número maior da próxima vez!");
            goto retry;

        }
        else if (userNumber == randomNumber)
        {
            Console.WriteLine("Parabéns! Você acertou o número!");
            Console.WriteLine("Quer jogar novamente? (y/n)");
            string res = Console.ReadLine();

            switch (res)
            {
                case "Y":
                case "y":
                    goto newgame;

                case "N":
                case "n":
                    Console.WriteLine("Obrigado por jogar!");
                    break;

                default:
                    break;

            }
        }


    }

}

