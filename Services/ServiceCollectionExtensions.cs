using Microsoft.Extensions.DependencyInjection;
using PrehistoryMethodApp.Data;

namespace PrehistoryMethodApp.Services
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDragDrop(this IServiceCollection services)
        {
            return services.AddScoped(typeof(DragDropService<>));
        }
    }
}
