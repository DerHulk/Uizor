using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uizor.Modal
{
    internal class ModalService : IModalService
    {
        public event EventHandler OnOpenRequest;

        public Task<IModalInstance> Open<TModal, TModalResult>() where TModalResult : IModalResult
        {
            this.OnOpenRequest?.Invoke(this, new EventArgs());
            throw new NotImplementedException();
        }

        public Task<IModalInstance> Open<TModal, TModalResult, T>() where TModalResult : IModalResult<T>
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            this.OnOpenRequest?.Invoke(this, new EventArgs());
        }
    }
}
