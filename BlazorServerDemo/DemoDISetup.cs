using BlazorServerDemo.Data;
//using Microsoft.Extensions.DependencyInjection;

namespace BlazorServerDemo
{
    public static class DemoDISetup
    {
        public static IServiceCollection AddDemoInfo(this IServiceCollection services) {

            services.AddTransient<IDemo, Demo>(); // Creates a new instance everytime we call it 
                                                  // when you asked for interface idemo you are going to give them demo 
            services.AddTransient<IDemo, UTCDemo>(); // Creates a new instance everytime we call it 

            services.AddTransient<ProcessDemo>();

            return services;
        }
    }
}
