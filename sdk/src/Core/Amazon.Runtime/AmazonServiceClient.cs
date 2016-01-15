/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace Amazon.Runtime
{
    public abstract class AmazonServiceClient : IDisposable
    {
        private bool _disposed;
        private Logger _logger;

        protected RuntimePipeline RuntimePipeline { get; set; }
        protected internal AWSCredentials Credentials { get; private set; }
        public ClientConfig Config { get; private set; }

        protected virtual bool SupportResponseLogging
        {
            get { return true; }
        }

        #region Events


        private PreRequestEventHandler mBeforeMarshallingEvent;

        /// <summary>
        /// Occurs before a request is marshalled.
        /// </summary>
        internal event PreRequestEventHandler BeforeMarshallingEvent
        {
            add
            {
                lock (this)
                {
                    mBeforeMarshallingEvent += value;
                }
            }
            remove
            {
                lock (this)
                {
                    mBeforeMarshallingEvent -= value;
                }
            }
        }


        private RequestEventHandler mBeforeRequestEvent;

        /// <summary>
        /// Occurs before a request is issued against the service.
        /// </summary>
        public event RequestEventHandler BeforeRequestEvent
        {
            add
            {
                lock (this)
                {
                    mBeforeRequestEvent += value;
                }
            }
            remove
            {
                lock (this)
                {
                    mBeforeRequestEvent -= value;
                }
            }
        }

        private ResponseEventHandler mAfterResponseEvent;

        /// <summary>
        /// Occurs after a response is received from the service.
        /// </summary>
        public event ResponseEventHandler AfterResponseEvent
        {
            add
            {
                lock (this)
                {
                    mAfterResponseEvent += value;
                }
            }
            remove
            {
                lock (this)
                {
                    mAfterResponseEvent -= value;
                }
            }
        }

        private ExceptionEventHandler mExceptionEvent;

        /// <summary>
        /// Occurs after an exception is encountered.
        /// </summary>
        public event ExceptionEventHandler ExceptionEvent
        {
            add
            {
                lock (this)
                {
                    mExceptionEvent += value;
                }
            }
            remove
            {
                lock (this)
                {
                    mExceptionEvent -= value;
                }
            }
        }

        #endregion

        #region Constructors

        protected AmazonServiceClient(AWSCredentials credentials, ClientConfig config)
        {
            if (config.DisableLogging)
                _logger = Logger.EmptyLogger;
            else
                _logger = Logger.GetLogger(this.GetType());

            config.Validate();
            this.Config = config;
            this.Credentials = credentials;
            Signer = CreateSigner();

            Initialize();

            BuildRuntimePipeline();
        }

        protected AbstractAWSSigner Signer
        {
            get;
            private set;
        }

        protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
            : this(new SessionAWSCredentials(awsAccessKeyId, awsSecretAccessKey, awsSessionToken), config)
        {
        }

        protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config)
        {
        }

        protected virtual void Initialize()
        {
        }

        #endregion

        #region Invoke methods

        protected TResponse Invoke<TRequest, TResponse>(TRequest request,
            IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller)
            where TRequest : AmazonWebServiceRequest
            where TResponse : AmazonWebServiceResponse
        {
            ThrowIfDisposed();

            var executionContext = new ExecutionContext(
                new RequestContext(this.Config.LogMetrics)
                {
                    ClientConfig = this.Config,
                    Marshaller = marshaller,
                    OriginalRequest = request,
                    Signer = Signer,
                    Unmarshaller = unmarshaller,
                    IsAsync = false
                },
                new ResponseContext()
            );

            var response = (TResponse)this.RuntimePipeline.InvokeSync(executionContext).Response;
            return response;
        }

#if UNITY
        protected IAsyncResult BeginInvoke<TRequest>(TRequest request,
           IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller, AsyncOptions asyncOptions,
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper)
           where TRequest : AmazonWebServiceRequest
        {
            ThrowIfDisposed();

            asyncOptions = asyncOptions ?? new AsyncOptions();
            var executionContext = new AsyncExecutionContext(
                new AsyncRequestContext(this.Config.LogMetrics)
                {
                    ClientConfig = this.Config,
                    Marshaller = marshaller,
                    OriginalRequest = request,
                    Signer = Signer,
                    Unmarshaller = unmarshaller,
                    Action = callbackHelper,
                    AsyncOptions = asyncOptions,
                    IsAsync = true
                },
                new AsyncResponseContext()
            );

            return this.RuntimePipeline.InvokeAsync(executionContext);
        }
#endif

#if AWS_ASYNC_API 

        protected System.Threading.Tasks.Task<TResponse> InvokeAsync<TRequest, TResponse>(TRequest request, 
            IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller,
            System.Threading.CancellationToken cancellationToken)            
            where TRequest: AmazonWebServiceRequest
            where TResponse : AmazonWebServiceResponse, new()
        {
            ThrowIfDisposed();

            var executionContext = new ExecutionContext(
                new RequestContext(this.Config.LogMetrics)
                {
                    ClientConfig = this.Config,
                    Marshaller = marshaller,
                    OriginalRequest = request,
                    Signer = Signer,
                    Unmarshaller = unmarshaller,
                    IsAsync = true,
                    CancellationToken = cancellationToken
                },
                new ResponseContext()
            );

            return this.RuntimePipeline.InvokeAsync<TResponse>(executionContext);
        }

#elif AWS_APM_API
        protected IAsyncResult BeginInvoke<TRequest>(TRequest request,
            IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller,
            AsyncCallback callback, object state)
            where TRequest : AmazonWebServiceRequest
        {
            ThrowIfDisposed();

            var executionContext = new AsyncExecutionContext(
                new AsyncRequestContext(this.Config.LogMetrics)
                {
                    ClientConfig = this.Config,
                    Marshaller = marshaller,
                    OriginalRequest = request,
                    Signer = Signer,
                    Unmarshaller = unmarshaller,
                    Callback = callback,
                    State = state,
                    IsAsync = true
                },
                new AsyncResponseContext()
            );

            var asyncResult = this.RuntimePipeline.InvokeAsync(executionContext);
            return asyncResult;
        }

        protected static TResponse EndInvoke<TResponse>(IAsyncResult result)
            where TResponse : AmazonWebServiceResponse
        {
            if (result == null)
                throw new ArgumentNullException("result", "Parameter result cannot be null.");

            var asyncResult = result as RuntimeAsyncResult;

            if (asyncResult == null)
                throw new ArgumentOutOfRangeException("result", "Parameter result is not of type RuntimeAsyncResult.");

            using (asyncResult)
            {
                if (!asyncResult.IsCompleted)
                {
                    asyncResult.AsyncWaitHandle.WaitOne();
                }

                if (asyncResult.Exception != null)
                {
                    AWSSDKUtils.PreserveStackTrace(asyncResult.Exception);
                    throw asyncResult.Exception;
                }

                return (TResponse)asyncResult.Response;
            }
        }
#endif

        #endregion

        #region Process Handlers

        protected void ProcessPreRequestHandlers(IExecutionContext executionContext)
        {
            //if (request == null)
            //    return;
            if (mBeforeMarshallingEvent == null)
                return;

            PreRequestEventArgs args = PreRequestEventArgs.Create(executionContext.RequestContext.OriginalRequest);
            mBeforeMarshallingEvent(this, args);
        }

        protected void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            WebServiceRequestEventArgs args = WebServiceRequestEventArgs.Create(request);

            if (request.OriginalRequest != null)
                request.OriginalRequest.FireBeforeRequestEvent(this, args);

            if (mBeforeRequestEvent != null)
                mBeforeRequestEvent(this, args);
        }

        protected void ProcessResponseHandlers(IExecutionContext executionContext)
        {
            if (mAfterResponseEvent == null)
                return;

            WebServiceResponseEventArgs args = WebServiceResponseEventArgs.Create(
                executionContext.ResponseContext.Response,
                executionContext.RequestContext.Request,
                executionContext.ResponseContext.HttpResponse);

            mAfterResponseEvent(this, args);
        }

        protected virtual void ProcessExceptionHandlers(IExecutionContext executionContext, Exception exception)
        {
            if (mExceptionEvent == null)
                return;

            WebServiceExceptionEventArgs args = WebServiceExceptionEventArgs.Create(exception, executionContext.RequestContext.Request);
            mExceptionEvent(this, args);
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
                if (RuntimePipeline != null)
                    RuntimePipeline.Dispose();

                _disposed = true;
            }
        }

        private void ThrowIfDisposed()
        {
            if (this._disposed)
                throw new ObjectDisposedException(GetType().FullName);
        }

        #endregion

        protected abstract AbstractAWSSigner CreateSigner();
        protected virtual void CustomizeRuntimePipeline(RuntimePipeline pipeline) { }

        private void BuildRuntimePipeline()
        {
#if BCL || BCL45
            var httpRequestFactory = new HttpWebRequestFactory();
            var httpHandler = new HttpHandler<Stream>(httpRequestFactory, this);
#elif UNITY
            IHttpRequestFactory<string> httpRequestFactory = null;
            HttpHandler<string> httpHandler = null;

            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                httpRequestFactory = new UnityWwwRequestFactory();
                httpHandler = new HttpHandler<string>(httpRequestFactory, this);
            }
            else
            {
                httpRequestFactory = new UnityWebRequestFactory();
                httpHandler = new HttpHandler<string>(httpRequestFactory, this);
            }
#else
            var httpRequestFactory = new HttpRequestMessageFactory(this.Config);
            var httpHandler = new HttpHandler<System.Net.Http.HttpContent>(httpRequestFactory, this);
#endif
            var preMarshallHandler = new CallbackHandler();
            preMarshallHandler.OnPreInvoke = this.ProcessPreRequestHandlers;

            var postMarshallHandler = new CallbackHandler();
            postMarshallHandler.OnPreInvoke = this.ProcessRequestHandlers;

            var postUnmarshallHandler = new CallbackHandler();
            postUnmarshallHandler.OnPostInvoke = this.ProcessResponseHandlers;

            var errorCallbackHandler = new ErrorCallbackHandler();
            errorCallbackHandler.OnError = this.ProcessExceptionHandlers;

            // Build default runtime pipeline.
            this.RuntimePipeline = new RuntimePipeline(new List<IPipelineHandler>
                {
                    httpHandler,
                    new Unmarshaller(this.SupportResponseLogging),
                    new ErrorHandler(_logger),
                    postUnmarshallHandler,
                    new Signer(),
                    new CredentialsRetriever(this.Credentials),
                    new RetryHandler(new DefaultRetryPolicy(this.Config.MaxErrorRetry)),
                    postMarshallHandler,
                    new EndpointResolver(),
                    new Marshaller(),
                    preMarshallHandler,
                    errorCallbackHandler,
                    new MetricsHandler()
#if UNITY
                    ,new ThreadPoolExecutionHandler(10)//remove the hardcoded to unity config
#endif
                },
                _logger
            );

            CustomizeRuntimePipeline(this.RuntimePipeline);
        }

        public static Uri ComposeUrl(IRequest iRequest)
        {
            Uri url = iRequest.Endpoint;
            var resourcePath = iRequest.ResourcePath;
            if (resourcePath == null)
                resourcePath = string.Empty;
            else
            {
                if (resourcePath.StartsWith("/", StringComparison.Ordinal))
                    resourcePath = resourcePath.Substring(1);
            }

            // Construct any sub resource/query parameter additions to append to the
            // resource path. Services like S3 which allow '?' and/or '&' in resource paths 
            // should use SubResources instead of appending them to the resource path with 
            // query string delimiters during request marshalling.

            var delim = "?";
            var sb = new StringBuilder();

            if (iRequest.SubResources.Count > 0)
            {
                foreach (var subResource in iRequest.SubResources)
                {
                    sb.AppendFormat("{0}{1}", delim, subResource.Key);
                    if (subResource.Value != null)
                        sb.AppendFormat("={0}", subResource.Value);
                    delim = "&";
                }
            }

            if (iRequest.UseQueryString && iRequest.Parameters.Count > 0)
            {
                var queryString = AWSSDKUtils.GetParametersAsString(iRequest.Parameters);
                sb.AppendFormat("{0}{1}", delim, queryString);
            }


            if (AWSSDKUtils.HasBidiControlCharacters(resourcePath))
                throw new AmazonClientException(string.Format(CultureInfo.InvariantCulture,
                    "Target resource path [{0}] has bidirectional characters, which are not supported" +
                    "by System.Uri and thus cannot be handled by the .NET SDK.", resourcePath));

            var parameterizedPath = string.Concat(AWSSDKUtils.UrlEncode(resourcePath, true), sb);
            var uri = new Uri(url.AbsoluteUri + parameterizedPath);
            DontUnescapePathDotsAndSlashes(uri);
            return uri;
        }

        /// <summary>
        /// Patches the in-flight uri to stop it unescaping the path etc (what Uri did before
        /// Microsoft deprecated the constructor flag). This is particularly important for
        /// Amazon S3 customers who want to use backslash (\) in their key names.
        /// </summary>
        /// <remarks>
        /// Different behavior in the various runtimes has been observed and in addition some 
        /// 'documented' ways of doing this between 2.x and 4.x runtimes has also been observed 
        /// to not be reliable.
        /// 
        /// This patch effectively emulates what adding a schemesettings element to the 
        /// app.config file with value 'name="http" genericUriParserOptions="DontUnescapePathDotsAndSlashes"'
        /// does. As we're a dll, that avenue is not open to us.
        /// </remarks>
        /// <param name="uri"></param>
        private static void DontUnescapePathDotsAndSlashes(Uri uri)
        {
#if BCL
            // System.UriSyntaxFlags is internal
            const int UnEscapeDotsAndSlashes = 0x2000000;

            if (uri == null)
                throw new ArgumentNullException("uri");

            try
            {
                // currently prefer silent return than exceptions or log messages if reflection fails to
                // find the fields we need, otherwise we could generate a lot of noise if someone
                // runs on a platform without these fields
                FieldInfo fieldInfo = uri.GetType().GetField("m_Syntax", BindingFlags.Instance | BindingFlags.NonPublic);
                if (fieldInfo == null)
                    return;

                var uriParser = fieldInfo.GetValue(uri);

                fieldInfo = typeof(UriParser).GetField("m_Flags", BindingFlags.Instance | BindingFlags.NonPublic);
                if (fieldInfo == null)
                    return;

                var uriSyntaxFlags = fieldInfo.GetValue(uriParser);
                uriSyntaxFlags = (int)uriSyntaxFlags & ~UnEscapeDotsAndSlashes;

                fieldInfo.SetValue(uriParser, uriSyntaxFlags);
            }
            catch (Exception)
            {
                // swallow the exception because this platform doesn't support the hack to fix the big in the Uri class.
            }
#endif
        }

        /// <summary>
        /// Used to create a copy of the config for a different service than the current instance.
        /// </summary>
        /// <typeparam name="C">Target service ClientConfig</typeparam>
        /// <returns>The new ClientConfig for the desired service</returns>
        internal C CloneConfig<C>()
            where C : ClientConfig, new()
        {
            var config = new C();
            CloneConfig(config);
            return config;
        }

        internal void CloneConfig(ClientConfig newConfig)
        {
            if (!string.IsNullOrEmpty(this.Config.ServiceURL))
            {
                var regionName = Util.AWSSDKUtils.DetermineRegion(this.Config.ServiceURL);
                RegionEndpoint region = RegionEndpoint.GetBySystemName(regionName);
                newConfig.RegionEndpoint = region;
            }
            else
            {
                newConfig.RegionEndpoint = this.Config.RegionEndpoint;
            }

            newConfig.UseHttp = this.Config.UseHttp;


            newConfig.ProxyCredentials = this.Config.ProxyCredentials;
#if BCL
            newConfig.ProxyHost = this.Config.ProxyHost;
            newConfig.ProxyPort = this.Config.ProxyPort;
#endif
        }
    }
}
