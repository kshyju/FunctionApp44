using System.Diagnostics;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class HelloHttp
    {
        private readonly ILogger _logger;

        public HelloHttp(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HelloHttp>();
        }

        [Function("HelloHttp")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            var pid = Environment.ProcessId;
            var processPath = Environment.ProcessPath;
            _logger.LogInformation($"C# HTTP trigger function processed a request.pid:{pid},processPath:{processPath}");

            var envVariables = Environment.GetEnvironmentVariables();

            var ob = new
            {
                envVariables.Count,
                ProcessId = pid,
                ProcessPath = processPath,
                EnvironmentVariabes = envVariables
            };

            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(ob);
            return response;
        }
    }
}
