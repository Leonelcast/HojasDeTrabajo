using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{

    public interface IList<T>
    {
        T Get(int indice);
        bool Set(int indice, T valor);
        void Push(T valor);
        int Length { get; }
    }

}

