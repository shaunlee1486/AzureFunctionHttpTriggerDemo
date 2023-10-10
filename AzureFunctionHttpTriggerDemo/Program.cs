using AzureFunctionHttpTriggerDemo;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
	.ConfigureFunctionsWorkerDefaults(builder =>
	{
		builder.UseMiddleware<ExceptionHandlingMiddleware>();
	})
	.ConfigureServices(serives =>
	{

	})
	.Build();

host.Run();
