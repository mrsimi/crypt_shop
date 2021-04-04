using System;
using client.Graph.Queries;
using client.Graph.Schemas;
using client.Graph.Types;
using GraphQL;
using GraphQL.SystemTextJson;
using infrastructure.Implementations;
using infrastructure.Interfaces;
using infrastructure.UoW;
using Microsoft.Extensions.DependencyInjection;

namespace client
{
    public static class ConfigurationServiceExtension
    {
        public static void AddCustomeServices (this IServiceCollection services)
        {
            services.AddTransient (typeof (IRepository<>), typeof (Repository<>));
            services.AddTransient<IProductRepository, ProductRepository> ();
            services.AddTransient<IUnitOfWork, UnitOfWork> ();

            // services.AddCors(o => o.AddPolicy("MyPolicy", p =>
			// {
			// 	p.AllowAnyHeader();
			// 	p.AllowAnyMethod();
			// 	p.AllowAnyOrigin();
			// }));
        }

        public static void AddGraphQlServices (this IServiceCollection services)
        {
            services.AddScoped<IServiceProvider> (c => new FuncServiceProvider (type => c.GetRequiredService (type)));
            services.AddScoped<ProductType> ();
            services.AddScoped<ProductQuery> ();
            services.AddScoped<MainSchema>();
            services.AddScoped<IDocumentExecuter, DocumentExecuter> ();
            services.AddScoped<IDocumentWriter, DocumentWriter> ();

            //services.
        }
    }
}