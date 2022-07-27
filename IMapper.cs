using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface IMapper<S, T>
    {
        T Map(S entity);
    }
}
