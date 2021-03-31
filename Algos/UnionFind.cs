using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Week1.UF
{
    class UnionFind : BaseUnionFind, IUnionFind
    {
        public UnionFind(int n): base(n)
        { }

        public void Union(int p, int q)
        {
            EnsureNotOutOfBound(p, q);

            if(IsConnected(p, q)) return;

            for (var i = 0; i < Size; i++)
            {
                if (Components[i] == Components[q])
                    Components[i] = Components[p];
            } 
        }

        public bool IsConnected(int p, int q)
        {
            EnsureNotOutOfBound(p, q);
            //Connected components indexes will have same values.
            return Components[p] == Components[q];
        }
    }
}