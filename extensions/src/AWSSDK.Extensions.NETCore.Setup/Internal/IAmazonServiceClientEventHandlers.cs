using Amazon.Runtime;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Extensions.NETCore.Setup.Internal
{
    /// <summary>
    /// IAmazonServiceClientCreateEventHandlers collects all of the IAmazonServiceClientEventHandler objects
    /// that will be run on every service client created as part of the dependency injection framework.
    /// </summary>
    public interface IAmazonServiceClientCreateEventHandlers
    {
        /// <summary>
        /// The list of handles registered
        /// </summary>
        IEnumerable<IAmazonServiceClientEventHandler> Handlers { get; }

        /// <summary>
        /// Add a new handler to be run on the new service clients
        /// </summary>
        /// <param name="handler"></param>
        void Add(IAmazonServiceClientEventHandler handler);
    }

    /// <summary>
    /// Default implementation of IAmazonServiceClientCreateEventHandlers
    /// </summary>
    internal class AmazonServiceClientEventHandlers : IAmazonServiceClientCreateEventHandlers
    {
        List<IAmazonServiceClientEventHandler> _handlers = new List<IAmazonServiceClientEventHandler>();

        public void Add(IAmazonServiceClientEventHandler handle)
        {
            _handlers.Add(handle);
        }

        public IEnumerable<IAmazonServiceClientEventHandler> Handlers => _handlers;

    }

    /// <summary>
    /// An interface defining a handler that will be run for each service client created.
    /// </summary>
    public interface IAmazonServiceClientEventHandler
    { 
        /// <summary>
        /// Display used to identitfy the handler run on a service client in the application's log.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// This method is called on the service client to perform any registration or eventing necessary.
        /// The service client is return in case the handler decides to wrap the service client like a proxy.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        IAmazonService Process(IAmazonService client);
    }
}