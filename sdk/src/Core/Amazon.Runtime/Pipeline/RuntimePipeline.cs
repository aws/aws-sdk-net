﻿/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// A runtime pipeline contains a collection of handlers which represent
    /// different stages of request and response processing.
    /// </summary>
    public partial class RuntimePipeline : IDisposable
    {
        #region Private members

        bool _disposed;
        ILogger _logger;

        // The top-most handler in the pipeline.
        IPipelineHandler _handler;

        #endregion

        #region Properties

        /// <summary>
        /// The top-most handler in the pipeline.
        /// </summary>
        public IPipelineHandler Handler
        {
            get { return _handler; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for RuntimePipeline.
        /// </summary>
        /// <param name="handler">The handler with which the pipeline is initalized.</param>        
        public RuntimePipeline(IPipelineHandler handler) 
        {
            if (handler == null)
                throw new ArgumentNullException("handler");

            var logger =
                 Amazon.Runtime.Internal.Util.Logger.GetLogger(typeof(RuntimePipeline));

            _handler = handler;
            _handler.Logger = logger;

            _logger = logger;
        }

        /// <summary>
        /// Constructor for RuntimePipeline.
        /// </summary>        
        /// <param name="handlers">List of handlers with which the pipeline is initalized.</param>                
        public RuntimePipeline(IList<IPipelineHandler> handlers)
            : this(handlers, Amazon.Runtime.Internal.Util.Logger.GetLogger(typeof(RuntimePipeline)))
        {            
        }

        /// <summary>
        /// Constructor for RuntimePipeline.
        /// </summary>        
        /// <param name="handlers">List of handlers with which the pipeline is initalized.</param>        
        /// <param name="logger">The logger used to log messages.</param>
        public RuntimePipeline(IList<IPipelineHandler> handlers, ILogger logger)
        {
            if (handlers == null || handlers.Count == 0)
                throw new ArgumentNullException("handlers");

            if (logger == null)
                throw new ArgumentNullException("logger");

            _logger = logger;
            
            foreach (var handler in handlers)
            {
                this.AddHandler(handler);
            }
        }

        /// <summary>
        /// Constructor for RuntimePipeline.
        /// </summary>
        /// <param name="handler">The handler with which the pipeline is initalized.</param>
        /// <param name="logger">The logger used to log messages.</param>
        public RuntimePipeline(IPipelineHandler handler, ILogger logger)
        {
            if (handler == null)
                throw new ArgumentNullException("handler");

            if (logger == null)
                throw new ArgumentNullException("logger");

            _handler = handler;
            _handler.Logger = logger;

            _logger = logger;
        }

        #endregion

        #region Invoke methods

        /// <summary>
        /// Invokes the pipeline synchronously.
        /// </summary>
        /// <param name="executionContext">Request context</param>
        /// <returns>Response context</returns>
        public IResponseContext InvokeSync(IExecutionContext executionContext)
        {
            ThrowIfDisposed();

            _handler.InvokeSync(executionContext);            
            return executionContext.ResponseContext;
        }

#if AWS_ASYNC_API

        /// <summary>
        /// Invokes the pipeline asynchronously.
        /// </summary>
        /// <param name="executionContext">Request context</param>
        /// <returns>Response context</returns>
        public System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
            where T : AmazonWebServiceResponse, new()
        {
            ThrowIfDisposed();

            return _handler.InvokeAsync<T>(executionContext);
        }

#elif AWS_APM_API

        /// <summary>
        /// Invokes the pipeline asynchronously.
        /// </summary>
        /// <param name="executionContext">Request context</param>
        /// <returns>IAsyncResult which represents the in progress asynchronous operation.</returns>
        public IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            ThrowIfDisposed();

            return _handler.InvokeAsync(executionContext);
        }
#endif

        #endregion

        #region Handler methods

        /// <summary>
        /// Adds a new handler to the top of the pipeline.
        /// </summary>
        /// <param name="handler">The handler to be added to the pipeline.</param>
        public void AddHandler(IPipelineHandler handler)
        {
            if (handler == null)
                throw new ArgumentNullException("handler");

            ThrowIfDisposed();

            var innerMostHandler = GetInnermostHandler(handler);

            if (_handler != null)
            {
                innerMostHandler.InnerHandler = _handler;
                _handler.OuterHandler = innerMostHandler;    
            }
            
            _handler = handler;

            SetHandlerProperties(handler);
        }
        
        /// <summary>
        /// Adds a handler after the first instance of handler of type T.        
        /// </summary>
        /// <typeparam name="T">Type of the handler after which the given handler instance is added.</typeparam>
        /// <param name="handler">The handler to be added to the pipeline.</param>
        public void AddHandlerAfter<T>(IPipelineHandler handler)
            where T : IPipelineHandler
        {
            if (handler == null)
                throw new ArgumentNullException("handler");

            ThrowIfDisposed();

            var type = typeof(T);
            var current = _handler;
            while (current != null)
            {
                if (current.GetType() == type)
                {
                    InsertHandler(handler, current);
                    SetHandlerProperties(handler);
                    return;
                }
                current = current.InnerHandler;
            }
            throw new InvalidOperationException(
                string.Format(CultureInfo.InvariantCulture, "Cannot find a handler of type {0}", type.Name));
        }
                        
        /// <summary>
        /// Adds a handler before the first instance of handler of type T.
        /// </summary>
        /// <typeparam name="T">Type of the handler before which the given handler instance is added.</typeparam>
        /// <param name="handler">The handler to be added to the pipeline.</param>
        public void AddHandlerBefore<T>(IPipelineHandler handler)
            where T : IPipelineHandler
        {
            if (handler == null)
                throw new ArgumentNullException("handler");

            ThrowIfDisposed();

            var type = typeof(T);
            if (_handler.GetType() == type)
            {
                // Add the handler to the top of the pipeline
                AddHandler(handler);
                SetHandlerProperties(handler);
                return;
            }

            var current = _handler;
            while (current != null)
            {
                if (current.InnerHandler != null &&
                    current.InnerHandler.GetType() == type)
                {
                    InsertHandler(handler, current);
                    SetHandlerProperties(handler);
                    return;
                }
                current = current.InnerHandler;
            }

            throw new InvalidOperationException(
                string.Format(CultureInfo.InvariantCulture, "Cannot find a handler of type {0}", type.Name));
        }

        /// <summary>
        /// Removes the first occurance of a handler of type T.
        /// </summary>
        /// <typeparam name="T">Type of the handler which will be removed.</typeparam>
        public void RemoveHandler<T>()
        {
            ThrowIfDisposed();

            var type = typeof(T);

            IPipelineHandler previous = null;
            var current = _handler;

            while (current != null)
            {
                if (current.GetType() == type)
                {
                    // Cannot remove the handler if it's the only one in the pipeline
                    if (current == _handler && _handler.InnerHandler == null)
                    {
                        throw new InvalidOperationException(
                            "The pipeline contains a single handler, cannot remove the only handler in the pipeline.");
                    }

                    // current is the top, point top to current's inner handler
                    if (current == _handler)                    
                        _handler = current.InnerHandler;
                    

                    // Wireup outer handler to current's inner handler
                    if (current.OuterHandler != null)                    
                        current.OuterHandler.InnerHandler = current.InnerHandler;

                    // Wireup inner handler to current's outer handler
                    if (current.InnerHandler != null)
                        current.InnerHandler.OuterHandler = current.OuterHandler;

                    // Cleanup current
                    current.InnerHandler = null;
                    current.OuterHandler = null;

                    return;
                }

                previous = current;
                current = current.InnerHandler;
            }

            throw new InvalidOperationException(
                string.Format(CultureInfo.InvariantCulture, "Cannot find a handler of type {0}", type.Name));
        }

        /// <summary>
        /// Replaces the first occurance of a handler of type T with the given handler.
        /// </summary>
        /// <typeparam name="T">Type of the handler which will be replaced.</typeparam>
        /// <param name="handler">The handler to be added to the pipeline.</param>
        public void ReplaceHandler<T>(IPipelineHandler handler)
            where T : IPipelineHandler
        {
            if (handler == null)
                throw new ArgumentNullException("handler");

            ThrowIfDisposed();

            var type = typeof(T);
            IPipelineHandler previous = null;
            var current = _handler;
            while (current != null)
            {
                if (current.GetType() == type)
                {
                    // Replace current with handler.
                    handler.InnerHandler = current.InnerHandler;
                    handler.OuterHandler = current.OuterHandler;
                    if(previous != null)
                    {
                        // Wireup previous handler
                        previous.InnerHandler = handler;
                    }
                    else
                    {
                        // Current is the top, replace it.
                        _handler = handler;                        
                    }

                    if (current.InnerHandler != null)
                    {
                        // Wireup next handler
                        current.InnerHandler.OuterHandler = handler;
                    }
                    
                    // Cleanup current
                    current.InnerHandler = null;
                    current.OuterHandler = null;

                    SetHandlerProperties(handler);
                    return;
                }
                previous = current;
                current = current.InnerHandler;                
            }
            throw new InvalidOperationException(
                string.Format(CultureInfo.InvariantCulture, "Cannot find a handler of type {0}", type.Name));
        }

        /// <summary>
        /// Inserts the given handler after current handler in the pipeline.
        /// </summary>
        /// <param name="handler">Handler to be inserted in the pipeline.</param>
        /// <param name="current">Handler after which the given handler is inserted.</param>
        private static void InsertHandler(IPipelineHandler handler, IPipelineHandler current)
        {
            var next = current.InnerHandler;
            current.InnerHandler = handler;
            handler.OuterHandler = current;
            
            if (next!=null)
            {
                var innerMostHandler = GetInnermostHandler(handler);
                innerMostHandler.InnerHandler = next;
                next.OuterHandler = innerMostHandler;
            }
        }

        /// <summary>
        /// Gets the innermost handler by traversing the inner handler till 
        /// it reaches the last one.
        /// </summary>
        private static IPipelineHandler GetInnermostHandler(IPipelineHandler handler)
        {
            var current = handler;
            while (current.InnerHandler != null)
            {
                current = current.InnerHandler;
            }
            return current;
        }

        private void SetHandlerProperties(IPipelineHandler handler)
        {
            ThrowIfDisposed();

            handler.Logger = _logger;
        }

        /// <summary>
        /// Retrieves a list of handlers, in the order of their execution.
        /// </summary>
        /// <returns>Handlers in the current pipeline.</returns>
        public List<IPipelineHandler> Handlers
        {
            get
            {
                return EnumerateHandlers().ToList();
            }
        }

        /// <summary>
        /// Retrieves current handlers, in the order of their execution.
        /// </summary>
        /// <returns>Handlers in the current pipeline.</returns>
        public IEnumerable<IPipelineHandler> EnumerateHandlers()
        {
            var handler = this.Handler;
            while(handler != null)
            {
                yield return handler;
                handler = handler.InnerHandler;
            }
        }

        #endregion

        #region Dispose methods

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                var handler = this.Handler;
                while (handler != null)
                {
                    var innerHandler = handler.InnerHandler;
                    var disposable = handler as IDisposable;
                    if (disposable != null)
                    {
                        disposable.Dispose();
                    }
                    handler = innerHandler;
                }

                _disposed = true;
            }
        }

        private void ThrowIfDisposed()
        {
            if (this._disposed)
                throw new ObjectDisposedException(GetType().FullName);
        }

        #endregion
    }
}
