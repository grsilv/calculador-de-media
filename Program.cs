{
    Console.Write("Professor, digite a primeira nota: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.Write("Professor, digite a segunda nota: ");
    int n2 = int.Parse(Console.ReadLine());

    Console.Write("Professor, digite a terceira nota: ");
    int n3 = int.Parse(Console.ReadLine());

    Console.Write("Professor, digite a última nota: ");
    int n4 = int.Parse(Console.ReadLine());

    Console.Clear();

    Console.WriteLine("Aguarde enquanto o resultado é calculado...");

    double med = (n1 + n2 + n3 + n4) / 4;

    if (med < 6)
    {
        Console.WriteLine("A nota final é igual a " + med);
        Console.WriteLine("O aluno está de recuperação.");
    }

    else
    {

        Console.WriteLine("A nota final é igual a " + med);
        Console.WriteLine("O aluno está aprovado. Parabéns.");
    }


}
