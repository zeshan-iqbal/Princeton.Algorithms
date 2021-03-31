using System;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace Week1.UF
{
    class QuickUnionFind : BaseUnionFind, IUnionFind
    {
        public QuickUnionFind(int n)
            : base(n)
        {
        }

        public void Union(int p, int q)
        {
            EnsureNotOutOfBound(p, q);
            Components[p] = q;
        }

        public bool IsConnected(int p, int q)
        {
            EnsureNotOutOfBound(p, q);
            return Parent(p) == Parent(q);
        }

        private int Parent(int c)
        {
            var parent = c;
            while (Components[parent] != parent)
            {
                parent = Components[parent];
            }
            
            return parent;
        }
    }
}