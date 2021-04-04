using System;
using client.Graph.Queries;
using GraphQL.Types;

namespace client.Graph.Schemas
{
    public class MainSchema : Schema
    {
        public MainSchema (IServiceProvider services) : base (services)
        {
            Query = new MainQuery();
        }
    }
}