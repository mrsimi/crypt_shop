using System.Threading.Tasks;
using client.Graph.Schemas;
using GraphQL;
using GraphQL.SystemTextJson;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace client.Controllers
{
    [ApiController]
    [Route ("graphql")]
    public class GraphQlController : ControllerBase
    {
        private MainSchema _schema;
        public GraphQlController (MainSchema schema)
        {
            _schema = schema;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync ([FromBody] GraphQlQuery query)
        {
            var inputs = query.Variables == null ? default (Inputs) : query.Variables.ToString ().ToInputs ();
            var json = await _schema.ExecuteAsync (_ =>
            {
                _.Query = query.Query;
                _.Inputs = inputs;
            });

            var result = new JsonResult (JsonConvert.DeserializeObject (json));

            return Content(json, "application/json");
        }
    }

    public class GraphQlQuery
    {
        public string OperationName { get; set; }
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}