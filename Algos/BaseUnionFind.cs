using System;
using System.Linq;

namespace Week1.UF
{
    abstract class BaseUnionFind
    {
        protected readonly int[] Components;
        protected readonly int Size;

        protected BaseUnionFind(int n)
        {
            if (n <= 0)
                throw new ArgumentException($"Argument {nameof(n)} must be > 0");

            Size = n;
            Components = Enumerable
                .Range(0, n)
                .ToArray();
        }

        protected void EnsureNotOutOfBound(int p, int q)
        {
            if (p < 0 || q < 0 || p > Size || q > Size)
                throw new ArgumentOutOfRangeException($"Argument {nameof(p)} or {nameof(q)} is out of range.");
        }
    }
}