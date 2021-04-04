using core.Models;
using GraphQL.Types;

namespace client.Graph.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType ()
        {
            Name = "Product";
            Field (p => p.Id).Description ("Product's Id");
            Field (p => p.Name, type:typeof(StringGraphType)).Description ("Product name");
            Field (p => p.Price, type:typeof(DecimalGraphType)).Description ("Product name");
            Field (p => p.Description, type:typeof(StringGraphType)).Description ("Product name");
            
        }
    }
}