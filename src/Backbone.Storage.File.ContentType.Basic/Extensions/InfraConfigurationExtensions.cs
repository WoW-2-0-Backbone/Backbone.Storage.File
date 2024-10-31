using Backbone.Storage.File.ContentType.Abstractions.Brokers;
using Backbone.Storage.File.ContentType.Basic.Brokers;
using Microsoft.Extensions.DependencyInjection;

namespace Backbone.Storage.File.ContentType.Basic.Extensions;

/// <summary>
/// Provides extension methods to configure the serialization provider.
/// </summary>
public static class InfraConfigurationExtensions
{
    /// <summary>
    /// Configures the serialization provider to use Newtonsoft JSON serialization.
    /// </summary>
    /// <param name="services"></param>
    public static void AddBasicFileContentTypeInfra(this IServiceCollection services)
    {
        services
            .AddSingleton<IFileContentTypeProvider, FileContentTypeProvider>()
            .AddSingleton<IFileContentTypeParser, FileContentTypeParser>();
    }
}