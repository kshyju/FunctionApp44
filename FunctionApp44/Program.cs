using Microsoft.Extensions.Hosting;
using Microsoft.Azure.Functions.Worker;
var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureGeneratedFunctionMetadataProvider()
    .ConfigureGeneratedFunctionExecutor()
    .Build();

host.Run();
