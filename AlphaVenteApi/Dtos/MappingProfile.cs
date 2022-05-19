using AutoMapper;
using System.Reflection;

namespace AlphaVenteApi.Dtos
{
    public class MappingProfile:Profile 
    {
        public MappingProfile()
        {
            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(t =>
                t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom))
                || t.IsClass && typeof(IMapFrom).IsAssignableFrom(t)
                )
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);

                var methodInfo = type.GetMethod("Mapping");
                   

                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
