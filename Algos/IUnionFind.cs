namespace Week1.UF
{
    interface IUnionFind
    {
        /// <summary>
        /// Put two components into same connected component.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        void Union(int p, int q);

        /// <summary>
        /// Are p and q are connected?
        /// p and q are connected if both are in same connected component.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        bool IsConnected(int p, int q);
    }
}