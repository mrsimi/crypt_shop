using client.Graph.Types;
using core.Models;
using GraphQL;
using GraphQL.Types;
using infrastructure.UoW;

namespace client.Graph.Queries
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery (IUnitOfWork uow)
        {
            FieldAsync<ProductType, Product> (
                "single",
                arguments : new QueryArguments (
                    new QueryArgument<IntGraphType> { Name = "id" }
                ),
                resolve : async context =>
                {
                    var id = context.GetArgument<int> ("id");
                    return await uow.ProductRepository.GetProductByIdAsync (id);
                }
            );
        }
    }
}