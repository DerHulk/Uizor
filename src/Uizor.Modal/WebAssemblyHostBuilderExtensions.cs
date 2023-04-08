using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uizor.Modal
{
    public static class WebAssemblyHostBuilderExtensions
    {
        public static WebAssemblyHostBuilder AddModal(this WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<ModalDialog>("body::after");
            builder.Services.AddSingleton<IModalService, ModalService>();
            return builder;
        }
    }
}
