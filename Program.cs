using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace _13_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(5, 10);
            m.fillRandom(-5, 5);
            m.Print();
            Matrix sum = new Matrix(5, 5);
            sum.fillRandom(0, 3);
            sum += m;
            sum.Print();

            Matrix mult = sum * m;
            mult.Print();


            Matrix dif = mult - sum;
            dif.Print();

            m *= 5;
            m.Print();

            for (int i = 0; i < 5; i++)
            {
                m[i, 0] = 777;
            }
            m.Print();

            Console.WriteLine(dif+sum == mult);
            Console.WriteLine(m == sum);
            Console.WriteLine(m != mult);

        }
    }
}