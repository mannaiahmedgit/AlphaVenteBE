using System.Reflection;

namespace AlphaVenteApi.Services
{
    public static  class InjectService
    {
      /*  internal static IServiceCollection AddAllService(this  IServiceCollection services)
        {
            var allProviderTypes = Assembly.GetAssembly(typeof(IUserProfileService)).
                GetTypes().Where(t => t.Namespace != null).ToList();
            foreach (var intfc in allProviderTypes.Where(t=>t.IsInterface))
            {
                var impl = allProviderTypes.FirstOrDefault(c => c.IsClass && intfc.Name.Substring(1) == c.Name);
                if (impl != null)
                {
                    services.AddTransient(intfc, impl);
                }
                
            }
            return services;
        }*/
    }
}
