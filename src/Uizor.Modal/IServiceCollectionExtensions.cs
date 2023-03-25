using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uizor.Modal
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddUizorModal(this IServiceCollection services)
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            return services;
        }
    }
}
