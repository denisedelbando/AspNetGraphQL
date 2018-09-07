using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class GraphQLController : ApiController
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _executer;
        private readonly IDocumentWriter _writer;
        private readonly IDictionary<string, string> _namedQueries;

        public GraphQLController(
            IDocumentExecuter executer,
            IDocumentWriter writer,
            ISchema schema)
        {
            _executer = executer;
            _writer = writer;
            _schema = schema;

            _namedQueries = new Dictionary<string, string>
            {
                ["a-query"] = @"query foo { hero { name } }"
            };
        }


        // This will display an example error
        [HttpGet]
        public async Task<HttpResponseMessage> GetAsync(HttpRequestMessage request)
        {
            var httpResult = false
                ? HttpStatusCode.BadRequest
                : HttpStatusCode.OK;

            var response = request.CreateResponse(httpResult, new { pagibig = "test" });
            //response.Content = new StringContent(new { pagibig = "test" }, Encoding.UTF8, "application/json");

            return response;

            
        }

    }
}
