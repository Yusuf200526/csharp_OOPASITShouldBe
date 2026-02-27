using System;
using System.Runtime.CompilerServices;
using System.Threading;

class clsCalculater
{
    private float _Result;
    private float _Operator;
    private string _OperationName = String.Empty;
    public void Clear()
    {
        _Result = 0;
        _Operator = 0;
        _OperationName = "Clear";
    }

    public void Add(float Operator)
    {
        _Operator = Operator;
        _OperationName = "Adding";
        _Result += _Operator;
    }

    public void Subtract(float Operator)
    {
        _Operator = Operator;
        _OperationName = "Subtracting";
        _Result -= _Operator;
    }

    public void Multiply(float Operator)
    {
        _Operator = Operator;
        _OperationName = "Multiplying";
        _Result *= _Operator;
    }

    public void Divide(float Operator)
    {
        if(Operator==0)
        {
            _Operator = Operator;
            _Result /= 1;
            _OperationName = "Dividing";
            return;
        }
        _Operator = Operator;
        _OperationName = "Dividing";
        _Result /= _Operator;
    }

    public void PrintResult()
    {
        Console.WriteLine("Result After {0} {1} is : {2}", _OperationName, _Operator, _Result);
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        clsCalculater Calculater1 = new clsCalculater();

        Calculater1.Clear();
        Calculater1.PrintResult();

        Calculater1.Add(1);
        Calculater1.PrintResult();

        Calculater1.Subtract(3);
        Calculater1.PrintResult();

        Calculater1.Multiply(23);
        Calculater1.PrintResult();

        Calculater1.Divide(0);
        Calculater1.PrintResult();

        Calculater1.Divide(12);
        Calculater1.PrintResult();

        Calculater1.Clear();
        Calculater1.PrintResult();

        Console.ReadKey();

        

    }
}
