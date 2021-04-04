using GraphQL.Types;

namespace client.Graph.Queries
{
    public class MainQuery : ObjectGraphType
    {
        public MainQuery ()
        {
            Name = "MainQuery";

            Field<ProductQuery> ("product", resolve : context => new { });
        }
    }
}