using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Extensions.NETCore.Setup.Internal
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Extension method to a IAmazonServiceClientEventHandler to the collection of handles that are
        /// run for every AWS Service client created through this package.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="handle"></param>
        /// <returns></returns>
        public static IServiceCollection AddAmazonServiceClientCreateEventHandle(this IServiceCollection collection, IAmazonServiceClientEventHandler handle)
        {
            var handles = collection.FirstOrDefault(
                x => x.ServiceType == typeof(IAmazonServiceClientCreateEventHandlers))
                ?.ImplementationType as IAmazonServiceClientCreateEventHandlers;

            // If there is the first handle then add the collection to the list of
            // services.
            if (handles == null)
            {
                handles = new AmazonServiceClientEventHandlers();
                collection.AddSingleton<IAmazonServiceClientCreateEventHandlers>(handles);
            }

            handles.Add(handle);

            return collection;
        }
    }
}
