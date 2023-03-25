﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uizor.Modal
{
    public interface IModalResult
    {
        object Result { get; }
    }

    public interface IModalResult<T>
    {
        T Result { get; }
    }
}
