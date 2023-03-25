using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uizor.Modal
{
    internal class ModalResult<T> : IModalResult<T>
    {
        public T Result => throw new NotImplementedException();
    }
}
