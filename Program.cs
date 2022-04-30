string opcaoDesejada;
double a, b, resultado;

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":

        Console.WriteLine("a soma de A + B\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a + b;

        Console.WriteLine($"{a} + {b} é {resultado} ");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
     break;


    case "-":
       
       Console.WriteLine("a subtração de A - B\n");
       Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a - b;

        Console.WriteLine($"{a} - {b} é {resultado} ");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();      
        break;

     case "*":


        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
   
        break;
    case "/":
     
        Console.WriteLine("a divisão de A / B\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey(); 

        if(b==0)
        {
        Console.WriteLine("não é possivel dividir por 0");
        }
    
       else
        {
     resultado = a / b;
     Console.WriteLine($"{a} / {b} é {resultado} ");    
        }
     
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
       break;
     default:
        Console.WriteLine("Opção inválida.");
        break;
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");