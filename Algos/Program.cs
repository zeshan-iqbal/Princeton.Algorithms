using System;

namespace Week1.UF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var uf = new UnionFind(10);

            uf.Union(1, 2);
            uf.Union(4, 6);
            uf.Union(2, 6);
            uf.Union(6, 9);

            Console.WriteLine(uf.IsConnected(1, 6));
        }
    }
}
