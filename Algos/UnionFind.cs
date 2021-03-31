using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Week1.UF
{
    class UnionFind : IUnionFind
    {
        private readonly int[] components;
        private int size;
        public UnionFind(int n)
        {
            if (n <= 0)
                throw new ArgumentException($"Argument {nameof(n)} must be > 0");

            size = n;
            components = Enumerable.Range(0, n).ToArray();
        }
        public void Union(int p, int q)
        {
            EnsureNotOutOfBound(p, q);

            if(IsConnected(p, q)) return;

            for (var i = 0; i < size; i++)
            {
                if (components[i] == components[q])
                    components[i] = components[p];
            } 
        }

        public bool IsConnected(int p, int q)
        {
            EnsureNotOutOfBound(p, q);
            //Connected components indexes will have same values.
            return components[p] == components[q];
        }
        
        private void EnsureNotOutOfBound(int p, int q)
        {
            if (p < 0 || q < 0 || p > size || q > size)
                throw new ArgumentOutOfRangeException($"Argument {nameof(p)} or {nameof(q)} is out of range.");
        }
    }
}