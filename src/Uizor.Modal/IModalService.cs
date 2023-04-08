using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uizor.Modal
{
    public interface IModalService
    {
        event EventHandler OnOpenRequest;

        void Open();
        Task<IModalInstance> Open<TModal, TModalResult>() where TModalResult : IModalResult;
        Task<IModalInstance> Open<TModal, TModalResult, T>() where TModalResult : IModalResult<T>;
    }
}
