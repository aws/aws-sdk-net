/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the lambda-web-2025-03-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LambdaWeb.Model;
using Amazon.LambdaWeb.Model.Internal.MarshallTransformations;
using Amazon.LambdaWeb.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.LambdaWeb
{
    /// <summary>
    /// <para>Implementation for accessing LambdaWeb</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS Lambda Web Functions is a capability of AWS Lambda that you can use to run web
    /// applications and API backends as serverless HTTP servers. Your code listens on a network
    /// port and handles requests directly. You can use familiar Node.js web frameworks such
    /// as Express, Hono, or React Router with no Lambda-specific adapters or wrappers. You
    /// develop and run your server locally like any other Node.js web app.
    /// 
    ///  
    /// <para>
    /// Lambda creates an HTTPS endpoint, manages the execution environments, and scales your
    /// application with traffic, including to zero when it's idle. To reduce latency for
    /// globally distributed users, you can deploy across multiple AWS Regions behind a single
    /// endpoint.
    /// </para>
    ///  
    /// <para>
    /// A Web Function has one or more immutable revisions (code and configuration) and one
    /// or more endpoints that expose it over HTTPS.
    /// </para>
    ///  
    /// <para>
    /// Use Web Functions for workloads that receive and respond to HTTP traffic directly.
    /// Common use cases include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Web applications – Deploy full-stack or front-end applications that serve HTML, assets,
    /// and API routes from a single deployment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// REST and GraphQL APIs – Build API backends that serve high request volumes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Microservices – Run HTTP services that scale independently with traffic, including
    /// to zero when idle.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Server-side rendering (SSR) – Serve pages that are rendered on the server at request
    /// time rather than pre-built. A Web Function runs your framework's production server
    /// directly. This suits applications that render personalized or frequently changing
    /// content on each request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Streaming responses – Stream output to the client as it is produced, such as responses
    /// from a large language model.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For event-driven processing, such as handling queue messages or file uploads, use
    /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-functions-chapter.html">Lambda
    /// Event Functions</a> instead. For more information about Web Functions, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/web-functions.html">Lambda
    /// Web Functions</a> in the <i>AWS Lambda Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonLambdaWebClient : AmazonServiceClient, IAmazonLambdaWeb
    {
        private static IServiceMetadata serviceMetadata = new AmazonLambdaWebMetadata();
        private ILambdaWebPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ILambdaWebPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new LambdaWebPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonLambdaWebClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonLambdaWebClient()
            : base(new AmazonLambdaWebConfig()) { }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaWebClient(RegionEndpoint region)
            : base(new AmazonLambdaWebConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonLambdaWebClient Configuration Object</param>
        public AmazonLambdaWebClient(AmazonLambdaWebConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLambdaWebClient(AWSCredentials credentials)
            : this(credentials, new AmazonLambdaWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaWebClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLambdaWebConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Credentials and an
        /// AmazonLambdaWebClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLambdaWebClient Configuration Object</param>
        public AmazonLambdaWebClient(AWSCredentials credentials, AmazonLambdaWebConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLambdaWebConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaWebClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLambdaWebClient Configuration Object</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLambdaWebConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaWebConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLambdaWebConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLambdaWebClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLambdaWebClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLambdaWebClient Configuration Object</param>
        public AmazonLambdaWebClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLambdaWebConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaWebEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonLambdaWebAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateWebFunction


        /// <summary>
        /// Creates a web function with an initial revision and endpoint. To create a web function,
        /// you provide the function name, revision configuration (code and service settings),
        /// and endpoint configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunction</c> permission on the
        /// web function. You don't need separate permissions for the initial revision or endpoint.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunction service method.</param>
        /// 
        /// <returns>The response from the CreateWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunction">REST API Reference for CreateWebFunction Operation</seealso>
        public virtual CreateWebFunctionResponse CreateWebFunction(CreateWebFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebFunctionResponseUnmarshaller.Instance;

            return Invoke<CreateWebFunctionResponse>(request, options);
        }


        /// <summary>
        /// Creates a web function with an initial revision and endpoint. To create a web function,
        /// you provide the function name, revision configuration (code and service settings),
        /// and endpoint configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunction</c> permission on the
        /// web function. You don't need separate permissions for the initial revision or endpoint.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunction">REST API Reference for CreateWebFunction Operation</seealso>
        public virtual Task<CreateWebFunctionResponse> CreateWebFunctionAsync(CreateWebFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebFunctionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWebFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWebFunctionEndpoint


        /// <summary>
        /// Creates an endpoint for a web function. An endpoint exposes the web function over
        /// HTTPS and routes traffic to one or more revisions.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunctionEndpoint</c> permission
        /// on the web function, not on the endpoint being created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunctionEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunctionEndpoint">REST API Reference for CreateWebFunctionEndpoint Operation</seealso>
        public virtual CreateWebFunctionEndpointResponse CreateWebFunctionEndpoint(CreateWebFunctionEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebFunctionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebFunctionEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateWebFunctionEndpointResponse>(request, options);
        }


        /// <summary>
        /// Creates an endpoint for a web function. An endpoint exposes the web function over
        /// HTTPS and routes traffic to one or more revisions.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunctionEndpoint</c> permission
        /// on the web function, not on the endpoint being created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunctionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunctionEndpoint">REST API Reference for CreateWebFunctionEndpoint Operation</seealso>
        public virtual Task<CreateWebFunctionEndpointResponse> CreateWebFunctionEndpointAsync(CreateWebFunctionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebFunctionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebFunctionEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWebFunctionEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWebFunctionRevision


        /// <summary>
        /// Creates an immutable revision for a web function. A revision represents a specific
        /// version of the function code and configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunctionRevision</c> permission
        /// on the web function, not on the revision being created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunctionRevision service method.</param>
        /// 
        /// <returns>The response from the CreateWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunctionRevision">REST API Reference for CreateWebFunctionRevision Operation</seealso>
        public virtual CreateWebFunctionRevisionResponse CreateWebFunctionRevision(CreateWebFunctionRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebFunctionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebFunctionRevisionResponseUnmarshaller.Instance;

            return Invoke<CreateWebFunctionRevisionResponse>(request, options);
        }


        /// <summary>
        /// Creates an immutable revision for a web function. A revision represents a specific
        /// version of the function code and configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>CreateWebFunctionRevision</c> permission
        /// on the web function, not on the revision being created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebFunctionRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/CreateWebFunctionRevision">REST API Reference for CreateWebFunctionRevision Operation</seealso>
        public virtual Task<CreateWebFunctionRevisionResponse> CreateWebFunctionRevisionAsync(CreateWebFunctionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWebFunctionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWebFunctionRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWebFunctionRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Removes the resource-based policy from a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Removes the resource-based policy from a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebFunction


        /// <summary>
        /// Deletes a web function and all of its associated revisions and endpoints.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>DeleteWebFunction</c> permission on the
        /// web function. You don't need the <c>DeleteWebFunctionRevision</c> or <c>DeleteWebFunctionEndpoint</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunction service method.</param>
        /// 
        /// <returns>The response from the DeleteWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunction">REST API Reference for DeleteWebFunction Operation</seealso>
        public virtual DeleteWebFunctionResponse DeleteWebFunction(DeleteWebFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebFunctionResponseUnmarshaller.Instance;

            return Invoke<DeleteWebFunctionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a web function and all of its associated revisions and endpoints.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>DeleteWebFunction</c> permission on the
        /// web function. You don't need the <c>DeleteWebFunctionRevision</c> or <c>DeleteWebFunctionEndpoint</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunction">REST API Reference for DeleteWebFunction Operation</seealso>
        public virtual Task<DeleteWebFunctionResponse> DeleteWebFunctionAsync(DeleteWebFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebFunctionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWebFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebFunctionEndpoint


        /// <summary>
        /// Deletes a web function endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunctionEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunctionEndpoint">REST API Reference for DeleteWebFunctionEndpoint Operation</seealso>
        public virtual DeleteWebFunctionEndpointResponse DeleteWebFunctionEndpoint(DeleteWebFunctionEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebFunctionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebFunctionEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteWebFunctionEndpointResponse>(request, options);
        }


        /// <summary>
        /// Deletes a web function endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunctionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunctionEndpoint">REST API Reference for DeleteWebFunctionEndpoint Operation</seealso>
        public virtual Task<DeleteWebFunctionEndpointResponse> DeleteWebFunctionEndpointAsync(DeleteWebFunctionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebFunctionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebFunctionEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWebFunctionEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWebFunctionRevision


        /// <summary>
        /// Deletes a web function revision. You cannot delete a revision that is currently serving
        /// traffic on an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunctionRevision service method.</param>
        /// 
        /// <returns>The response from the DeleteWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunctionRevision">REST API Reference for DeleteWebFunctionRevision Operation</seealso>
        public virtual DeleteWebFunctionRevisionResponse DeleteWebFunctionRevision(DeleteWebFunctionRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebFunctionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebFunctionRevisionResponseUnmarshaller.Instance;

            return Invoke<DeleteWebFunctionRevisionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a web function revision. You cannot delete a revision that is currently serving
        /// traffic on an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebFunctionRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/DeleteWebFunctionRevision">REST API Reference for DeleteWebFunctionRevision Operation</seealso>
        public virtual Task<DeleteWebFunctionRevisionResponse> DeleteWebFunctionRevisionAsync(DeleteWebFunctionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWebFunctionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWebFunctionRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWebFunctionRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the resource-based policy attached to a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the resource-based policy attached to a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWebAccountSettings


        /// <summary>
        /// Retrieves details about your AWS Lambda Web Functions account settings for the current
        /// AWS Region, including the quotas that apply to web functions and your current usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetWebAccountSettings service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebAccountSettings">REST API Reference for GetWebAccountSettings Operation</seealso>
        public virtual GetWebAccountSettingsResponse GetWebAccountSettings(GetWebAccountSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetWebAccountSettingsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about your AWS Lambda Web Functions account settings for the current
        /// AWS Region, including the quotas that apply to web functions and your current usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebAccountSettings service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebAccountSettings">REST API Reference for GetWebAccountSettings Operation</seealso>
        public virtual Task<GetWebAccountSettingsResponse> GetWebAccountSettingsAsync(GetWebAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebAccountSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWebAccountSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWebFunction


        /// <summary>
        /// Retrieves details about a web function, including its current state and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunction service method.</param>
        /// 
        /// <returns>The response from the GetWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunction">REST API Reference for GetWebFunction Operation</seealso>
        public virtual GetWebFunctionResponse GetWebFunction(GetWebFunctionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebFunctionResponseUnmarshaller.Instance;

            return Invoke<GetWebFunctionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a web function, including its current state and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebFunction service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunction">REST API Reference for GetWebFunction Operation</seealso>
        public virtual Task<GetWebFunctionResponse> GetWebFunctionAsync(GetWebFunctionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebFunctionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebFunctionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWebFunctionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWebFunctionEndpoint


        /// <summary>
        /// Retrieves details about a web function endpoint, including its current state, configuration,
        /// and domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunctionEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunctionEndpoint">REST API Reference for GetWebFunctionEndpoint Operation</seealso>
        public virtual GetWebFunctionEndpointResponse GetWebFunctionEndpoint(GetWebFunctionEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebFunctionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebFunctionEndpointResponseUnmarshaller.Instance;

            return Invoke<GetWebFunctionEndpointResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a web function endpoint, including its current state, configuration,
        /// and domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunctionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunctionEndpoint">REST API Reference for GetWebFunctionEndpoint Operation</seealso>
        public virtual Task<GetWebFunctionEndpointResponse> GetWebFunctionEndpointAsync(GetWebFunctionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebFunctionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebFunctionEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWebFunctionEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWebFunctionRevision


        /// <summary>
        /// Retrieves details about a web function revision, including its state and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunctionRevision service method.</param>
        /// 
        /// <returns>The response from the GetWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunctionRevision">REST API Reference for GetWebFunctionRevision Operation</seealso>
        public virtual GetWebFunctionRevisionResponse GetWebFunctionRevision(GetWebFunctionRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebFunctionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebFunctionRevisionResponseUnmarshaller.Instance;

            return Invoke<GetWebFunctionRevisionResponse>(request, options);
        }


        /// <summary>
        /// Retrieves details about a web function revision, including its state and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebFunctionRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebFunctionRevision service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/GetWebFunctionRevision">REST API Reference for GetWebFunctionRevision Operation</seealso>
        public virtual Task<GetWebFunctionRevisionResponse> GetWebFunctionRevisionAsync(GetWebFunctionRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWebFunctionRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWebFunctionRevisionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWebFunctionRevisionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns a list of tags applied to a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of tags applied to a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWebFunctionEndpoints


        /// <summary>
        /// Lists endpoints for a web function. Use pagination to ensure that the operation returns
        /// quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctionEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListWebFunctionEndpoints service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctionEndpoints">REST API Reference for ListWebFunctionEndpoints Operation</seealso>
        public virtual ListWebFunctionEndpointsResponse ListWebFunctionEndpoints(ListWebFunctionEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebFunctionEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebFunctionEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListWebFunctionEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Lists endpoints for a web function. Use pagination to ensure that the operation returns
        /// quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctionEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebFunctionEndpoints service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctionEndpoints">REST API Reference for ListWebFunctionEndpoints Operation</seealso>
        public virtual Task<ListWebFunctionEndpointsResponse> ListWebFunctionEndpointsAsync(ListWebFunctionEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebFunctionEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebFunctionEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWebFunctionEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWebFunctionRevisions


        /// <summary>
        /// Lists revisions for a web function. Use pagination to ensure that the operation returns
        /// quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctionRevisions service method.</param>
        /// 
        /// <returns>The response from the ListWebFunctionRevisions service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctionRevisions">REST API Reference for ListWebFunctionRevisions Operation</seealso>
        public virtual ListWebFunctionRevisionsResponse ListWebFunctionRevisions(ListWebFunctionRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebFunctionRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebFunctionRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListWebFunctionRevisionsResponse>(request, options);
        }


        /// <summary>
        /// Lists revisions for a web function. Use pagination to ensure that the operation returns
        /// quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctionRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebFunctionRevisions service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctionRevisions">REST API Reference for ListWebFunctionRevisions Operation</seealso>
        public virtual Task<ListWebFunctionRevisionsResponse> ListWebFunctionRevisionsAsync(ListWebFunctionRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebFunctionRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebFunctionRevisionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWebFunctionRevisionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWebFunctions


        /// <summary>
        /// Lists web functions in your account. Use pagination to ensure that the operation returns
        /// quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctions service method.</param>
        /// 
        /// <returns>The response from the ListWebFunctions service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctions">REST API Reference for ListWebFunctions Operation</seealso>
        public virtual ListWebFunctionsResponse ListWebFunctions(ListWebFunctionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebFunctionsResponseUnmarshaller.Instance;

            return Invoke<ListWebFunctionsResponse>(request, options);
        }


        /// <summary>
        /// Lists web functions in your account. Use pagination to ensure that the operation returns
        /// quickly and successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebFunctions service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/ListWebFunctions">REST API Reference for ListWebFunctions Operation</seealso>
        public virtual Task<ListWebFunctionsResponse> ListWebFunctionsAsync(ListWebFunctionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWebFunctionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebFunctionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWebFunctionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Adds or updates a resource-based policy on a web function. A resource-based policy
        /// grants permissions to other AWS accounts or services to perform actions on the web
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Adds or updates a resource-based policy on a web function. A resource-based policy
        /// grants permissions to other AWS accounts or services to perform actions on the web
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a web function. If a tag key already exists, the existing value is overwritten
        /// with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to a web function. If a tag key already exists, the existing value is overwritten
        /// with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a web function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWebFunctionEndpoint


        /// <summary>
        /// Updates the configuration of a web function endpoint. You can modify the authorization
        /// type, auto-deployment mode, revision weights, scaling, and throttling settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebFunctionEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/UpdateWebFunctionEndpoint">REST API Reference for UpdateWebFunctionEndpoint Operation</seealso>
        public virtual UpdateWebFunctionEndpointResponse UpdateWebFunctionEndpoint(UpdateWebFunctionEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWebFunctionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebFunctionEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateWebFunctionEndpointResponse>(request, options);
        }


        /// <summary>
        /// Updates the configuration of a web function endpoint. You can modify the authorization
        /// type, auto-deployment mode, revision weights, scaling, and throttling settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebFunctionEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebFunctionEndpoint service method, as returned by LambdaWeb.</returns>
        /// <exception cref="Amazon.LambdaWeb.Model.AccessDeniedException">
        /// You don't have permission to perform this operation. Check the IAM policies for your
        /// identity and any resource-based policy on the web function.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For example, the resource
        /// is being modified by another request, you tried to delete a revision that is serving
        /// traffic on an endpoint, or the policy revision ID that you specified doesn't match
        /// the current policy. Resolve the conflict and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.InternalServerException">
        /// The request failed because of an internal error in the service. Retry the request.
        /// If the error persists, open a support case.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ResourceNotFoundException">
        /// The specified web function, revision, endpoint, or resource-based policy doesn't exist.
        /// Verify the resource identifier and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota, such as the maximum number of web functions
        /// in your account or the maximum number of revisions or endpoints per web function.
        /// Request a quota increase or reduce usage and try again.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ThrottlingException">
        /// The request was denied because it exceeded the request rate that Lambda allows for
        /// your account. Reduce the frequency of requests and retry with exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.LambdaWeb.Model.ValidationException">
        /// The request failed validation because a parameter was missing, malformed, or outside
        /// the allowed range. Check the request parameters and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lambda-web-2025-03-07/UpdateWebFunctionEndpoint">REST API Reference for UpdateWebFunctionEndpoint Operation</seealso>
        public virtual Task<UpdateWebFunctionEndpointResponse> UpdateWebFunctionEndpointAsync(UpdateWebFunctionEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWebFunctionEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWebFunctionEndpointResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWebFunctionEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}