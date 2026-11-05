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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;
using Amazon.ApiGatewayV2.Model;
using Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations;
using Amazon.ApiGatewayV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570

namespace Amazon.ApiGatewayV2
{
    /// <summary>
    /// <para>Implementation for accessing ApiGatewayV2</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Amazon API Gateway V2
    /// </summary>
    public partial class AmazonApiGatewayV2Client : AmazonServiceClient, IAmazonApiGatewayV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonApiGatewayV2Metadata();
        private IApiGatewayV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IApiGatewayV2PaginatorFactory Paginators
        {
            get
            {
                if (this._paginators == null)
                {
                    this._paginators = new ApiGatewayV2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with the credentials loaded from the application's
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
        public AmazonApiGatewayV2Client() : base(new AmazonApiGatewayV2Config()) { }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with the credentials loaded from the application's
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
        public AmazonApiGatewayV2Client(RegionEndpoint region) : base(new AmazonApiGatewayV2Config { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApiGatewayV2Client Configuration Object</param>
        public AmazonApiGatewayV2Client(AmazonApiGatewayV2Config config) : base(config) { }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApiGatewayV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonApiGatewayV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApiGatewayV2Config { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Credentials and an
        /// AmazonApiGatewayV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApiGatewayV2Client Configuration Object</param>
        public AmazonApiGatewayV2Client(AWSCredentials credentials, AmazonApiGatewayV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayV2Config { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApiGatewayV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApiGatewayV2Client Configuration Object</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonApiGatewayV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayV2Config { RegionEndpoint = region })
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApiGatewayV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApiGatewayV2Client Configuration Object</param>
        public AmazonApiGatewayV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApiGatewayV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApiGatewayV2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApiGatewayV2AuthSchemeHandler());
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

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApi service method.</param>
        /// <returns>The response from the CreateApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual CreateApiResponse CreateApi(CreateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return Invoke<CreateApiResponse>(request, options);
        }
#else
        internal virtual CreateApiResponse CreateApi(CreateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return Invoke<CreateApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApi">REST API Reference for CreateApi Operation</seealso>
        public virtual Task<CreateApiResponse> CreateApiAsync(CreateApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping service method.</param>
        /// <returns>The response from the CreateApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApiMapping">REST API Reference for CreateApiMapping Operation</seealso>
        public virtual CreateApiMappingResponse CreateApiMapping(CreateApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return Invoke<CreateApiMappingResponse>(request, options);
        }
#else
        internal virtual CreateApiMappingResponse CreateApiMapping(CreateApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return Invoke<CreateApiMappingResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateApiMapping">REST API Reference for CreateApiMapping Operation</seealso>
        public virtual Task<CreateApiMappingResponse> CreateApiMappingAsync(CreateApiMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiMappingResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Authorizer for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// <returns>The response from the CreateAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerResponse>(request, options);
        }
#else
        internal virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an Authorizer for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual Task<CreateAuthorizerResponse> CreateAuthorizerAsync(CreateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAuthorizerResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a Deployment for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <returns>The response from the CreateDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }
#else
        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a Deployment for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// <returns>The response from the CreateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameResponse>(request, options);
        }
#else
        internal virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual Task<CreateDomainNameResponse> CreateDomainNameAsync(CreateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainNameResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <returns>The response from the CreateIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }
#else
        internal virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        public virtual Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntegrationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse service method.</param>
        /// <returns>The response from the CreateIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegrationResponse">REST API Reference for CreateIntegrationResponse Operation</seealso>
        public virtual CreateIntegrationResponseResponse CreateIntegrationResponse(CreateIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponseResponse>(request, options);
        }
#else
        internal virtual CreateIntegrationResponseResponse CreateIntegrationResponse(CreateIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateIntegrationResponse">REST API Reference for CreateIntegrationResponse Operation</seealso>
        public virtual Task<CreateIntegrationResponseResponse> CreateIntegrationResponseAsync(CreateIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntegrationResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a Model for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <returns>The response from the CreateModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }
#else
        internal virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a Model for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <returns>The response from the CreatePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual CreatePortalResponse CreatePortal(CreatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return Invoke<CreatePortalResponse>(request, options);
        }
#else
        internal virtual CreatePortalResponse CreatePortal(CreatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return Invoke<CreatePortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual Task<CreatePortalResponse> CreatePortalAsync(CreatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortalProduct service method.</param>
        /// <returns>The response from the CreatePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortalProduct">REST API Reference for CreatePortalProduct Operation</seealso>
        public virtual CreatePortalProductResponse CreatePortalProduct(CreatePortalProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalProductResponseUnmarshaller.Instance;

            return Invoke<CreatePortalProductResponse>(request, options);
        }
#else
        internal virtual CreatePortalProductResponse CreatePortalProduct(CreatePortalProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalProductResponseUnmarshaller.Instance;

            return Invoke<CreatePortalProductResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortalProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreatePortalProduct">REST API Reference for CreatePortalProduct Operation</seealso>
        public virtual Task<CreatePortalProductResponse> CreatePortalProductAsync(CreatePortalProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalProductResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortalProductResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new product page for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductPage service method.</param>
        /// <returns>The response from the CreateProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        public virtual CreateProductPageResponse CreateProductPage(CreateProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductPageResponseUnmarshaller.Instance;

            return Invoke<CreateProductPageResponse>(request, options);
        }
#else
        internal virtual CreateProductPageResponse CreateProductPage(CreateProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductPageResponseUnmarshaller.Instance;

            return Invoke<CreateProductPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new product page for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        public virtual Task<CreateProductPageResponse> CreateProductPageAsync(CreateProductPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductPageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProductPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a product REST endpoint page for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductRestEndpointPage service method.</param>
        /// <returns>The response from the CreateProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductRestEndpointPage">REST API Reference for CreateProductRestEndpointPage Operation</seealso>
        public virtual CreateProductRestEndpointPageResponse CreateProductRestEndpointPage(CreateProductRestEndpointPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductRestEndpointPageResponseUnmarshaller.Instance;

            return Invoke<CreateProductRestEndpointPageResponse>(request, options);
        }
#else
        internal virtual CreateProductRestEndpointPageResponse CreateProductRestEndpointPage(CreateProductRestEndpointPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductRestEndpointPageResponseUnmarshaller.Instance;

            return Invoke<CreateProductRestEndpointPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a product REST endpoint page for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductRestEndpointPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateProductRestEndpointPage">REST API Reference for CreateProductRestEndpointPage Operation</seealso>
        public virtual Task<CreateProductRestEndpointPageResponse> CreateProductRestEndpointPageAsync(CreateProductRestEndpointPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProductRestEndpointPageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProductRestEndpointPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a Route for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// <returns>The response from the CreateRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponse>(request, options);
        }
#else
        internal virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a Route for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a RouteResponse for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse service method.</param>
        /// <returns>The response from the CreateRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRouteResponse">REST API Reference for CreateRouteResponse Operation</seealso>
        public virtual CreateRouteResponseResponse CreateRouteResponse(CreateRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponseResponse>(request, options);
        }
#else
        internal virtual CreateRouteResponseResponse CreateRouteResponse(CreateRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a RouteResponse for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRouteResponse">REST API Reference for CreateRouteResponse Operation</seealso>
        public virtual Task<CreateRouteResponseResponse> CreateRouteResponseAsync(CreateRouteResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a RoutingRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingRule service method.</param>
        /// <returns>The response from the CreateRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoutingRule">REST API Reference for CreateRoutingRule Operation</seealso>
        public virtual CreateRoutingRuleResponse CreateRoutingRule(CreateRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRoutingRuleResponse>(request, options);
        }
#else
        internal virtual CreateRoutingRuleResponse CreateRoutingRule(CreateRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRoutingRuleResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a RoutingRule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateRoutingRule">REST API Reference for CreateRoutingRule Operation</seealso>
        public virtual Task<CreateRoutingRuleResponse> CreateRoutingRuleAsync(CreateRoutingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoutingRuleResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a Stage for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// <returns>The response from the CreateStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
        }
#else
        internal virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a Stage for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// <returns>The response from the CreateVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        public virtual CreateVpcLinkResponse CreateVpcLink(CreateVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<CreateVpcLinkResponse>(request, options);
        }
#else
        internal virtual CreateVpcLinkResponse CreateVpcLink(CreateVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<CreateVpcLinkResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        public virtual Task<CreateVpcLinkResponse> CreateVpcLinkAsync(CreateVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcLinkResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the AccessLogSettings for a Stage. To disable access logging for a Stage,
        /// delete its AccessLogSettings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSettings service method.</param>
        /// <returns>The response from the DeleteAccessLogSettings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAccessLogSettings">REST API Reference for DeleteAccessLogSettings Operation</seealso>
        public virtual DeleteAccessLogSettingsResponse DeleteAccessLogSettings(DeleteAccessLogSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessLogSettingsResponse>(request, options);
        }
#else
        internal virtual DeleteAccessLogSettingsResponse DeleteAccessLogSettings(DeleteAccessLogSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessLogSettingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the AccessLogSettings for a Stage. To disable access logging for a Stage,
        /// delete its AccessLogSettings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAccessLogSettings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAccessLogSettings">REST API Reference for DeleteAccessLogSettings Operation</seealso>
        public virtual Task<DeleteAccessLogSettingsResponse> DeleteAccessLogSettingsAsync(DeleteAccessLogSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessLogSettingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi service method.</param>
        /// <returns>The response from the DeleteApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return Invoke<DeleteApiResponse>(request, options);
        }
#else
        internal virtual DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return Invoke<DeleteApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApi">REST API Reference for DeleteApi Operation</seealso>
        public virtual Task<DeleteApiResponse> DeleteApiAsync(DeleteApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping service method.</param>
        /// <returns>The response from the DeleteApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApiMapping">REST API Reference for DeleteApiMapping Operation</seealso>
        public virtual DeleteApiMappingResponse DeleteApiMapping(DeleteApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteApiMappingResponse>(request, options);
        }
#else
        internal virtual DeleteApiMappingResponse DeleteApiMapping(DeleteApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteApiMappingResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteApiMapping">REST API Reference for DeleteApiMapping Operation</seealso>
        public virtual Task<DeleteApiMappingResponse> DeleteApiMappingAsync(DeleteApiMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiMappingResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// <returns>The response from the DeleteAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerResponse>(request, options);
        }
#else
        internal virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual Task<DeleteAuthorizerResponse> DeleteAuthorizerAsync(DeleteAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAuthorizerResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a CORS configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsConfiguration service method.</param>
        /// <returns>The response from the DeleteCorsConfiguration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteCorsConfiguration">REST API Reference for DeleteCorsConfiguration Operation</seealso>
        public virtual DeleteCorsConfigurationResponse DeleteCorsConfiguration(DeleteCorsConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCorsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCorsConfigurationResponse>(request, options);
        }
#else
        internal virtual DeleteCorsConfigurationResponse DeleteCorsConfiguration(DeleteCorsConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCorsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCorsConfigurationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a CORS configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteCorsConfiguration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteCorsConfiguration">REST API Reference for DeleteCorsConfiguration Operation</seealso>
        public virtual Task<DeleteCorsConfigurationResponse> DeleteCorsConfigurationAsync(DeleteCorsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCorsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCorsConfigurationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// <returns>The response from the DeleteDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
        }
#else
        internal virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// <returns>The response from the DeleteDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameResponse>(request, options);
        }
#else
        internal virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual Task<DeleteDomainNameResponse> DeleteDomainNameAsync(DeleteDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainNameResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <returns>The response from the DeleteIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }
#else
        internal virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// <returns>The response from the DeleteIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        public virtual DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseResponse>(request, options);
        }
#else
        internal virtual DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        public virtual Task<DeleteIntegrationResponseResponse> DeleteIntegrationResponseAsync(DeleteIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <returns>The response from the DeleteModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }
#else
        internal virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <returns>The response from the DeletePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual DeletePortalResponse DeletePortal(DeletePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return Invoke<DeletePortalResponse>(request, options);
        }
#else
        internal virtual DeletePortalResponse DeletePortal(DeletePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return Invoke<DeletePortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual Task<DeletePortalResponse> DeletePortalAsync(DeletePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortalProduct service method.</param>
        /// <returns>The response from the DeletePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProduct">REST API Reference for DeletePortalProduct Operation</seealso>
        public virtual DeletePortalProductResponse DeletePortalProduct(DeletePortalProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalProductResponseUnmarshaller.Instance;

            return Invoke<DeletePortalProductResponse>(request, options);
        }
#else
        internal virtual DeletePortalProductResponse DeletePortalProduct(DeletePortalProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalProductResponseUnmarshaller.Instance;

            return Invoke<DeletePortalProductResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortalProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProduct">REST API Reference for DeletePortalProduct Operation</seealso>
        public virtual Task<DeletePortalProductResponse> DeletePortalProductAsync(DeletePortalProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalProductResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortalProductResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortalProductSharingPolicy service method.</param>
        /// <returns>The response from the DeletePortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProductSharingPolicy">REST API Reference for DeletePortalProductSharingPolicy Operation</seealso>
        public virtual DeletePortalProductSharingPolicyResponse DeletePortalProductSharingPolicy(DeletePortalProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePortalProductSharingPolicyResponse>(request, options);
        }
#else
        internal virtual DeletePortalProductSharingPolicyResponse DeletePortalProductSharingPolicy(DeletePortalProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePortalProductSharingPolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortalProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeletePortalProductSharingPolicy">REST API Reference for DeletePortalProductSharingPolicy Operation</seealso>
        public virtual Task<DeletePortalProductSharingPolicyResponse> DeletePortalProductSharingPolicyAsync(DeletePortalProductSharingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalProductSharingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortalProductSharingPolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductPage service method.</param>
        /// <returns>The response from the DeleteProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        public virtual DeleteProductPageResponse DeleteProductPage(DeleteProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductPageResponseUnmarshaller.Instance;

            return Invoke<DeleteProductPageResponse>(request, options);
        }
#else
        internal virtual DeleteProductPageResponse DeleteProductPage(DeleteProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductPageResponseUnmarshaller.Instance;

            return Invoke<DeleteProductPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        public virtual Task<DeleteProductPageResponse> DeleteProductPageAsync(DeleteProductPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductPageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProductPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductRestEndpointPage service method.</param>
        /// <returns>The response from the DeleteProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductRestEndpointPage">REST API Reference for DeleteProductRestEndpointPage Operation</seealso>
        public virtual DeleteProductRestEndpointPageResponse DeleteProductRestEndpointPage(DeleteProductRestEndpointPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductRestEndpointPageResponseUnmarshaller.Instance;

            return Invoke<DeleteProductRestEndpointPageResponse>(request, options);
        }
#else
        internal virtual DeleteProductRestEndpointPageResponse DeleteProductRestEndpointPage(DeleteProductRestEndpointPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductRestEndpointPageResponseUnmarshaller.Instance;

            return Invoke<DeleteProductRestEndpointPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductRestEndpointPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteProductRestEndpointPage">REST API Reference for DeleteProductRestEndpointPage Operation</seealso>
        public virtual Task<DeleteProductRestEndpointPageResponse> DeleteProductRestEndpointPageAsync(DeleteProductRestEndpointPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProductRestEndpointPageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProductRestEndpointPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// <returns>The response from the DeleteRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponse>(request, options);
        }
#else
        internal virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a route request parameter. Supported only for WebSocket APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteRequestParameter service method.</param>
        /// <returns>The response from the DeleteRouteRequestParameter service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteRequestParameter">REST API Reference for DeleteRouteRequestParameter Operation</seealso>
        public virtual DeleteRouteRequestParameterResponse DeleteRouteRequestParameter(DeleteRouteRequestParameterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteRequestParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequestParameterResponse>(request, options);
        }
#else
        internal virtual DeleteRouteRequestParameterResponse DeleteRouteRequestParameter(DeleteRouteRequestParameterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteRequestParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequestParameterResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a route request parameter. Supported only for WebSocket APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteRequestParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRouteRequestParameter service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteRequestParameter">REST API Reference for DeleteRouteRequestParameter Operation</seealso>
        public virtual Task<DeleteRouteRequestParameterResponse> DeleteRouteRequestParameterAsync(DeleteRouteRequestParameterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteRequestParameterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteRequestParameterResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse service method.</param>
        /// <returns>The response from the DeleteRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteResponse">REST API Reference for DeleteRouteResponse Operation</seealso>
        public virtual DeleteRouteResponseResponse DeleteRouteResponse(DeleteRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponseResponse>(request, options);
        }
#else
        internal virtual DeleteRouteResponseResponse DeleteRouteResponse(DeleteRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteResponse">REST API Reference for DeleteRouteResponse Operation</seealso>
        public virtual Task<DeleteRouteResponseResponse> DeleteRouteResponseAsync(DeleteRouteResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the RouteSettings for a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteSettings service method.</param>
        /// <returns>The response from the DeleteRouteSettings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteSettings">REST API Reference for DeleteRouteSettings Operation</seealso>
        public virtual DeleteRouteSettingsResponse DeleteRouteSettings(DeleteRouteSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteSettingsResponse>(request, options);
        }
#else
        internal virtual DeleteRouteSettingsResponse DeleteRouteSettings(DeleteRouteSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteSettingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the RouteSettings for a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRouteSettings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRouteSettings">REST API Reference for DeleteRouteSettings Operation</seealso>
        public virtual Task<DeleteRouteSettingsResponse> DeleteRouteSettingsAsync(DeleteRouteSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRouteSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteSettingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingRule service method.</param>
        /// <returns>The response from the DeleteRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoutingRule">REST API Reference for DeleteRoutingRule Operation</seealso>
        public virtual DeleteRoutingRuleResponse DeleteRoutingRule(DeleteRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRoutingRuleResponse>(request, options);
        }
#else
        internal virtual DeleteRoutingRuleResponse DeleteRoutingRule(DeleteRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRoutingRuleResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteRoutingRule">REST API Reference for DeleteRoutingRule Operation</seealso>
        public virtual Task<DeleteRoutingRuleResponse> DeleteRoutingRuleAsync(DeleteRoutingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoutingRuleResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// <returns>The response from the DeleteStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
        }
#else
        internal virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// <returns>The response from the DeleteVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        public virtual DeleteVpcLinkResponse DeleteVpcLink(DeleteVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcLinkResponse>(request, options);
        }
#else
        internal virtual DeleteVpcLinkResponse DeleteVpcLink(DeleteVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcLinkResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        public virtual Task<DeleteVpcLinkResponse> DeleteVpcLinkAsync(DeleteVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcLinkResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the publication of a portal portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisablePortal service method.</param>
        /// <returns>The response from the DisablePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DisablePortal">REST API Reference for DisablePortal Operation</seealso>
        public virtual DisablePortalResponse DisablePortal(DisablePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisablePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisablePortalResponseUnmarshaller.Instance;

            return Invoke<DisablePortalResponse>(request, options);
        }
#else
        internal virtual DisablePortalResponse DisablePortal(DisablePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisablePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisablePortalResponseUnmarshaller.Instance;

            return Invoke<DisablePortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes the publication of a portal portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisablePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisablePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/DisablePortal">REST API Reference for DisablePortal Operation</seealso>
        public virtual Task<DisablePortalResponse> DisablePortalAsync(DisablePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisablePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisablePortalResponseUnmarshaller.Instance;

            return InvokeAsync<DisablePortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportApi service method.</param>
        /// <returns>The response from the ExportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ExportApi">REST API Reference for ExportApi Operation</seealso>
        public virtual ExportApiResponse ExportApi(ExportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportApiResponseUnmarshaller.Instance;

            return Invoke<ExportApiResponse>(request, options);
        }
#else
        internal virtual ExportApiResponse ExportApi(ExportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportApiResponseUnmarshaller.Instance;

            return Invoke<ExportApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ExportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ExportApi">REST API Reference for ExportApi Operation</seealso>
        public virtual Task<ExportApiResponse> ExportApiAsync(ExportApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportApiResponseUnmarshaller.Instance;

            return InvokeAsync<ExportApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApi service method.</param>
        /// <returns>The response from the GetApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual GetApiResponse GetApi(GetApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return Invoke<GetApiResponse>(request, options);
        }
#else
        internal virtual GetApiResponse GetApi(GetApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return Invoke<GetApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApi">REST API Reference for GetApi Operation</seealso>
        public virtual Task<GetApiResponse> GetApiAsync(GetApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping service method.</param>
        /// <returns>The response from the GetApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMapping">REST API Reference for GetApiMapping Operation</seealso>
        public virtual GetApiMappingResponse GetApiMapping(GetApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingResponse>(request, options);
        }
#else
        internal virtual GetApiMappingResponse GetApiMapping(GetApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMapping">REST API Reference for GetApiMapping Operation</seealso>
        public virtual Task<GetApiMappingResponse> GetApiMappingAsync(GetApiMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiMappingResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets API mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings service method.</param>
        /// <returns>The response from the GetApiMappings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMappings">REST API Reference for GetApiMappings Operation</seealso>
        public virtual GetApiMappingsResponse GetApiMappings(GetApiMappingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingsResponse>(request, options);
        }
#else
        internal virtual GetApiMappingsResponse GetApiMappings(GetApiMappingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets API mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetApiMappings service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApiMappings">REST API Reference for GetApiMappings Operation</seealso>
        public virtual Task<GetApiMappingsResponse> GetApiMappingsAsync(GetApiMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiMappingsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a collection of Api resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApis service method.</param>
        /// <returns>The response from the GetApis service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApis">REST API Reference for GetApis Operation</seealso>
        public virtual GetApisResponse GetApis(GetApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;

            return Invoke<GetApisResponse>(request, options);
        }
#else
        internal virtual GetApisResponse GetApis(GetApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;

            return Invoke<GetApisResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a collection of Api resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetApis service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetApis">REST API Reference for GetApis Operation</seealso>
        public virtual Task<GetApisResponse> GetApisAsync(GetApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;

            return InvokeAsync<GetApisResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// <returns>The response from the GetAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        public virtual GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerResponse>(request, options);
        }
#else
        internal virtual GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        public virtual Task<GetAuthorizerResponse> GetAuthorizerAsync(GetAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<GetAuthorizerResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the Authorizers for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// <returns>The response from the GetAuthorizers service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        public virtual GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersResponse>(request, options);
        }
#else
        internal virtual GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the Authorizers for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAuthorizers service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        public virtual Task<GetAuthorizersResponse> GetAuthorizersAsync(GetAuthorizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return InvokeAsync<GetAuthorizersResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <returns>The response from the GetDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }
#else
        internal virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the Deployments for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// <returns>The response from the GetDeployments service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        public virtual GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsResponse>(request, options);
        }
#else
        internal virtual GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the Deployments for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDeployments service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        public virtual Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// <returns>The response from the GetDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameResponse>(request, options);
        }
#else
        internal virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual Task<GetDomainNameResponse> GetDomainNameAsync(GetDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNameResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the domain names for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// <returns>The response from the GetDomainNames service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        public virtual GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesResponse>(request, options);
        }
#else
        internal virtual GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the domain names for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDomainNames service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        public virtual Task<GetDomainNamesResponse> GetDomainNamesAsync(GetDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNamesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <returns>The response from the GetIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }
#else
        internal virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// <returns>The response from the GetIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        public virtual GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseResponse>(request, options);
        }
#else
        internal virtual GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        public virtual Task<GetIntegrationResponseResponse> GetIntegrationResponseAsync(GetIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the IntegrationResponses for an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses service method.</param>
        /// <returns>The response from the GetIntegrationResponses service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponses">REST API Reference for GetIntegrationResponses Operation</seealso>
        public virtual GetIntegrationResponsesResponse GetIntegrationResponses(GetIntegrationResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponsesResponse>(request, options);
        }
#else
        internal virtual GetIntegrationResponsesResponse GetIntegrationResponses(GetIntegrationResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponsesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the IntegrationResponses for an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetIntegrationResponses service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrationResponses">REST API Reference for GetIntegrationResponses Operation</seealso>
        public virtual Task<GetIntegrationResponsesResponse> GetIntegrationResponsesAsync(GetIntegrationResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponsesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the Integrations for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations service method.</param>
        /// <returns>The response from the GetIntegrations service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrations">REST API Reference for GetIntegrations Operation</seealso>
        public virtual GetIntegrationsResponse GetIntegrations(GetIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationsResponse>(request, options);
        }
#else
        internal virtual GetIntegrationsResponse GetIntegrations(GetIntegrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the Integrations for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetIntegrations service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetIntegrations">REST API Reference for GetIntegrations Operation</seealso>
        public virtual Task<GetIntegrationsResponse> GetIntegrationsAsync(GetIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// <returns>The response from the GetModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModel">REST API Reference for GetModel Operation</seealso>
        public virtual GetModelResponse GetModel(GetModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelResponse>(request, options);
        }
#else
        internal virtual GetModelResponse GetModel(GetModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModel">REST API Reference for GetModel Operation</seealso>
        public virtual Task<GetModelResponse> GetModelAsync(GetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a model template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// <returns>The response from the GetModelTemplate service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        public virtual GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateResponse>(request, options);
        }
#else
        internal virtual GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a model template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetModelTemplate service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        public virtual Task<GetModelTemplateResponse> GetModelTemplateAsync(GetModelTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelTemplateResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the Models for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// <returns>The response from the GetModels service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
        }
#else
        internal virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the Models for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetModels service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual Task<GetModelsResponse> GetModelsAsync(GetModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// <returns>The response from the GetPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortal">REST API Reference for GetPortal Operation</seealso>
        public virtual GetPortalResponse GetPortal(GetPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return Invoke<GetPortalResponse>(request, options);
        }
#else
        internal virtual GetPortalResponse GetPortal(GetPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return Invoke<GetPortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortal">REST API Reference for GetPortal Operation</seealso>
        public virtual Task<GetPortalResponse> GetPortalAsync(GetPortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalResponseUnmarshaller.Instance;

            return InvokeAsync<GetPortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalProduct service method.</param>
        /// <returns>The response from the GetPortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProduct">REST API Reference for GetPortalProduct Operation</seealso>
        public virtual GetPortalProductResponse GetPortalProduct(GetPortalProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalProductResponseUnmarshaller.Instance;

            return Invoke<GetPortalProductResponse>(request, options);
        }
#else
        internal virtual GetPortalProductResponse GetPortalProduct(GetPortalProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalProductResponseUnmarshaller.Instance;

            return Invoke<GetPortalProductResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProduct">REST API Reference for GetPortalProduct Operation</seealso>
        public virtual Task<GetPortalProductResponse> GetPortalProductAsync(GetPortalProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalProductResponseUnmarshaller.Instance;

            return InvokeAsync<GetPortalProductResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalProductSharingPolicy service method.</param>
        /// <returns>The response from the GetPortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProductSharingPolicy">REST API Reference for GetPortalProductSharingPolicy Operation</seealso>
        public virtual GetPortalProductSharingPolicyResponse GetPortalProductSharingPolicy(GetPortalProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPortalProductSharingPolicyResponse>(request, options);
        }
#else
        internal virtual GetPortalProductSharingPolicyResponse GetPortalProductSharingPolicy(GetPortalProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<GetPortalProductSharingPolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortalProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetPortalProductSharingPolicy">REST API Reference for GetPortalProductSharingPolicy Operation</seealso>
        public virtual Task<GetPortalProductSharingPolicyResponse> GetPortalProductSharingPolicyAsync(GetPortalProductSharingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPortalProductSharingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPortalProductSharingPolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductPage service method.</param>
        /// <returns>The response from the GetProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        public virtual GetProductPageResponse GetProductPage(GetProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductPageResponseUnmarshaller.Instance;

            return Invoke<GetProductPageResponse>(request, options);
        }
#else
        internal virtual GetProductPageResponse GetProductPage(GetProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductPageResponseUnmarshaller.Instance;

            return Invoke<GetProductPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        public virtual Task<GetProductPageResponse> GetProductPageAsync(GetProductPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductPageResponseUnmarshaller.Instance;

            return InvokeAsync<GetProductPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductRestEndpointPage service method.</param>
        /// <returns>The response from the GetProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductRestEndpointPage">REST API Reference for GetProductRestEndpointPage Operation</seealso>
        public virtual GetProductRestEndpointPageResponse GetProductRestEndpointPage(GetProductRestEndpointPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductRestEndpointPageResponseUnmarshaller.Instance;

            return Invoke<GetProductRestEndpointPageResponse>(request, options);
        }
#else
        internal virtual GetProductRestEndpointPageResponse GetProductRestEndpointPage(GetProductRestEndpointPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductRestEndpointPageResponseUnmarshaller.Instance;

            return Invoke<GetProductRestEndpointPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductRestEndpointPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetProductRestEndpointPage">REST API Reference for GetProductRestEndpointPage Operation</seealso>
        public virtual Task<GetProductRestEndpointPageResponse> GetProductRestEndpointPageAsync(GetProductRestEndpointPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProductRestEndpointPageResponseUnmarshaller.Instance;

            return InvokeAsync<GetProductRestEndpointPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoute service method.</param>
        /// <returns>The response from the GetRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoute">REST API Reference for GetRoute Operation</seealso>
        public virtual GetRouteResponse GetRoute(GetRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponse>(request, options);
        }
#else
        internal virtual GetRouteResponse GetRoute(GetRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoute">REST API Reference for GetRoute Operation</seealso>
        public virtual Task<GetRouteResponse> GetRouteAsync(GetRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;

            return InvokeAsync<GetRouteResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse service method.</param>
        /// <returns>The response from the GetRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponse">REST API Reference for GetRouteResponse Operation</seealso>
        public virtual GetRouteResponseResponse GetRouteResponse(GetRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponseResponse>(request, options);
        }
#else
        internal virtual GetRouteResponseResponse GetRouteResponse(GetRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponse">REST API Reference for GetRouteResponse Operation</seealso>
        public virtual Task<GetRouteResponseResponse> GetRouteResponseAsync(GetRouteResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetRouteResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the RouteResponses for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses service method.</param>
        /// <returns>The response from the GetRouteResponses service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponses">REST API Reference for GetRouteResponses Operation</seealso>
        public virtual GetRouteResponsesResponse GetRouteResponses(GetRouteResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponsesResponse>(request, options);
        }
#else
        internal virtual GetRouteResponsesResponse GetRouteResponses(GetRouteResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponsesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the RouteResponses for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRouteResponses service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRouteResponses">REST API Reference for GetRouteResponses Operation</seealso>
        public virtual Task<GetRouteResponsesResponse> GetRouteResponsesAsync(GetRouteResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRouteResponsesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the Routes for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes service method.</param>
        /// <returns>The response from the GetRoutes service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutes">REST API Reference for GetRoutes Operation</seealso>
        public virtual GetRoutesResponse GetRoutes(GetRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return Invoke<GetRoutesResponse>(request, options);
        }
#else
        internal virtual GetRoutesResponse GetRoutes(GetRoutesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return Invoke<GetRoutesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the Routes for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRoutes service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutes">REST API Reference for GetRoutes Operation</seealso>
        public virtual Task<GetRoutesResponse> GetRoutesAsync(GetRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoutesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingRule service method.</param>
        /// <returns>The response from the GetRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutingRule">REST API Reference for GetRoutingRule Operation</seealso>
        public virtual GetRoutingRuleResponse GetRoutingRule(GetRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<GetRoutingRuleResponse>(request, options);
        }
#else
        internal virtual GetRoutingRuleResponse GetRoutingRule(GetRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<GetRoutingRuleResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetRoutingRule">REST API Reference for GetRoutingRule Operation</seealso>
        public virtual Task<GetRoutingRuleResponse> GetRoutingRuleAsync(GetRoutingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoutingRuleResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// <returns>The response from the GetStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
        }
#else
        internal virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return InvokeAsync<GetStageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets the Stages for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// <returns>The response from the GetStages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStages">REST API Reference for GetStages Operation</seealso>
        public virtual GetStagesResponse GetStages(GetStagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesResponse>(request, options);
        }
#else
        internal virtual GetStagesResponse GetStages(GetStagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets the Stages for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetStages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetStages">REST API Reference for GetStages Operation</seealso>
        public virtual Task<GetStagesResponse> GetStagesAsync(GetStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return InvokeAsync<GetStagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a collection of Tag resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// <returns>The response from the GetTags service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }
#else
        internal virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a collection of Tag resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetTags service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTagsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// <returns>The response from the GetVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        public virtual GetVpcLinkResponse GetVpcLink(GetVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinkResponse>(request, options);
        }
#else
        internal virtual GetVpcLinkResponse GetVpcLink(GetVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinkResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        public virtual Task<GetVpcLinkResponse> GetVpcLinkAsync(GetVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return InvokeAsync<GetVpcLinkResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Gets a collection of VPC links.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// <returns>The response from the GetVpcLinks service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        public virtual GetVpcLinksResponse GetVpcLinks(GetVpcLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinksResponse>(request, options);
        }
#else
        internal virtual GetVpcLinksResponse GetVpcLinks(GetVpcLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinksResponse>(request, options);
        }
#endif

        /// <summary>
        /// Gets a collection of VPC links.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetVpcLinks service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        public virtual Task<GetVpcLinksResponse> GetVpcLinksAsync(GetVpcLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return InvokeAsync<GetVpcLinksResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Imports an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApi service method.</param>
        /// <returns>The response from the ImportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ImportApi">REST API Reference for ImportApi Operation</seealso>
        public virtual ImportApiResponse ImportApi(ImportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiResponseUnmarshaller.Instance;

            return Invoke<ImportApiResponse>(request, options);
        }
#else
        internal virtual ImportApiResponse ImportApi(ImportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiResponseUnmarshaller.Instance;

            return Invoke<ImportApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Imports an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ImportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ImportApi">REST API Reference for ImportApi Operation</seealso>
        public virtual Task<ImportApiResponse> ImportApiAsync(ImportApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiResponseUnmarshaller.Instance;

            return InvokeAsync<ImportApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists portal products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortalProducts service method.</param>
        /// <returns>The response from the ListPortalProducts service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortalProducts">REST API Reference for ListPortalProducts Operation</seealso>
        public virtual ListPortalProductsResponse ListPortalProducts(ListPortalProductsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalProductsResponseUnmarshaller.Instance;

            return Invoke<ListPortalProductsResponse>(request, options);
        }
#else
        internal virtual ListPortalProductsResponse ListPortalProducts(ListPortalProductsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalProductsResponseUnmarshaller.Instance;

            return Invoke<ListPortalProductsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists portal products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortalProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPortalProducts service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortalProducts">REST API Reference for ListPortalProducts Operation</seealso>
        public virtual Task<ListPortalProductsResponse> ListPortalProductsAsync(ListPortalProductsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalProductsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalProductsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortalProductsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <returns>The response from the ListPortals service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual ListPortalsResponse ListPortals(ListPortalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return Invoke<ListPortalsResponse>(request, options);
        }
#else
        internal virtual ListPortalsResponse ListPortals(ListPortalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return Invoke<ListPortalsResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPortals service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual Task<ListPortalsResponse> ListPortalsAsync(ListPortalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortalsResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the product pages for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductPages service method.</param>
        /// <returns>The response from the ListProductPages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        public virtual ListProductPagesResponse ListProductPages(ListProductPagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductPagesResponseUnmarshaller.Instance;

            return Invoke<ListProductPagesResponse>(request, options);
        }
#else
        internal virtual ListProductPagesResponse ListProductPages(ListProductPagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductPagesResponseUnmarshaller.Instance;

            return Invoke<ListProductPagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the product pages for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductPages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProductPages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        public virtual Task<ListProductPagesResponse> ListProductPagesAsync(ListProductPagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductPagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProductPagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists the product REST endpoint pages of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductRestEndpointPages service method.</param>
        /// <returns>The response from the ListProductRestEndpointPages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductRestEndpointPages">REST API Reference for ListProductRestEndpointPages Operation</seealso>
        public virtual ListProductRestEndpointPagesResponse ListProductRestEndpointPages(ListProductRestEndpointPagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductRestEndpointPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductRestEndpointPagesResponseUnmarshaller.Instance;

            return Invoke<ListProductRestEndpointPagesResponse>(request, options);
        }
#else
        internal virtual ListProductRestEndpointPagesResponse ListProductRestEndpointPages(ListProductRestEndpointPagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductRestEndpointPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductRestEndpointPagesResponseUnmarshaller.Instance;

            return Invoke<ListProductRestEndpointPagesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists the product REST endpoint pages of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductRestEndpointPages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProductRestEndpointPages service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListProductRestEndpointPages">REST API Reference for ListProductRestEndpointPages Operation</seealso>
        public virtual Task<ListProductRestEndpointPagesResponse> ListProductRestEndpointPagesAsync(ListProductRestEndpointPagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProductRestEndpointPagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProductRestEndpointPagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProductRestEndpointPagesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Lists routing rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingRules service method.</param>
        /// <returns>The response from the ListRoutingRules service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListRoutingRules">REST API Reference for ListRoutingRules Operation</seealso>
        public virtual ListRoutingRulesResponse ListRoutingRules(ListRoutingRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoutingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingRulesResponseUnmarshaller.Instance;

            return Invoke<ListRoutingRulesResponse>(request, options);
        }
#else
        internal virtual ListRoutingRulesResponse ListRoutingRules(ListRoutingRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoutingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingRulesResponseUnmarshaller.Instance;

            return Invoke<ListRoutingRulesResponse>(request, options);
        }
#endif

        /// <summary>
        /// Lists routing rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRoutingRules service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ListRoutingRules">REST API Reference for ListRoutingRules Operation</seealso>
        public virtual Task<ListRoutingRulesResponse> ListRoutingRulesAsync(ListRoutingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRoutingRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRoutingRulesResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a portal preview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewPortal service method.</param>
        /// <returns>The response from the PreviewPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PreviewPortal">REST API Reference for PreviewPortal Operation</seealso>
        public virtual PreviewPortalResponse PreviewPortal(PreviewPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PreviewPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewPortalResponseUnmarshaller.Instance;

            return Invoke<PreviewPortalResponse>(request, options);
        }
#else
        internal virtual PreviewPortalResponse PreviewPortal(PreviewPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PreviewPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewPortalResponseUnmarshaller.Instance;

            return Invoke<PreviewPortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a portal preview.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PreviewPortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PreviewPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PreviewPortal">REST API Reference for PreviewPortal Operation</seealso>
        public virtual Task<PreviewPortalResponse> PreviewPortalAsync(PreviewPortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PreviewPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PreviewPortalResponseUnmarshaller.Instance;

            return InvokeAsync<PreviewPortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Publishes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishPortal service method.</param>
        /// <returns>The response from the PublishPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PublishPortal">REST API Reference for PublishPortal Operation</seealso>
        public virtual PublishPortalResponse PublishPortal(PublishPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishPortalResponseUnmarshaller.Instance;

            return Invoke<PublishPortalResponse>(request, options);
        }
#else
        internal virtual PublishPortalResponse PublishPortal(PublishPortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishPortalResponseUnmarshaller.Instance;

            return Invoke<PublishPortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Publishes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishPortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PublishPortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PublishPortal">REST API Reference for PublishPortal Operation</seealso>
        public virtual Task<PublishPortalResponse> PublishPortalAsync(PublishPortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishPortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishPortalResponseUnmarshaller.Instance;

            return InvokeAsync<PublishPortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPortalProductSharingPolicy service method.</param>
        /// <returns>The response from the PutPortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutPortalProductSharingPolicy">REST API Reference for PutPortalProductSharingPolicy Operation</seealso>
        public virtual PutPortalProductSharingPolicyResponse PutPortalProductSharingPolicy(PutPortalProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPortalProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPortalProductSharingPolicyResponse>(request, options);
        }
#else
        internal virtual PutPortalProductSharingPolicyResponse PutPortalProductSharingPolicy(PutPortalProductSharingPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPortalProductSharingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutPortalProductSharingPolicyResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the sharing policy for a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPortalProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutPortalProductSharingPolicy service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutPortalProductSharingPolicy">REST API Reference for PutPortalProductSharingPolicy Operation</seealso>
        public virtual Task<PutPortalProductSharingPolicyResponse> PutPortalProductSharingPolicyAsync(PutPortalProductSharingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutPortalProductSharingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPortalProductSharingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutPortalProductSharingPolicyResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRoutingRule service method.</param>
        /// <returns>The response from the PutRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutRoutingRule">REST API Reference for PutRoutingRule Operation</seealso>
        public virtual PutRoutingRuleResponse PutRoutingRule(PutRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<PutRoutingRuleResponse>(request, options);
        }
#else
        internal virtual PutRoutingRuleResponse PutRoutingRule(PutRoutingRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRoutingRuleResponseUnmarshaller.Instance;

            return Invoke<PutRoutingRuleResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a routing rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRoutingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutRoutingRule service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/PutRoutingRule">REST API Reference for PutRoutingRule Operation</seealso>
        public virtual Task<PutRoutingRuleResponse> PutRoutingRuleAsync(PutRoutingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRoutingRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRoutingRuleResponseUnmarshaller.Instance;

            return InvokeAsync<PutRoutingRuleResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Puts an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReimportApi service method.</param>
        /// <returns>The response from the ReimportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ReimportApi">REST API Reference for ReimportApi Operation</seealso>
        public virtual ReimportApiResponse ReimportApi(ReimportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReimportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReimportApiResponseUnmarshaller.Instance;

            return Invoke<ReimportApiResponse>(request, options);
        }
#else
        internal virtual ReimportApiResponse ReimportApi(ReimportApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReimportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReimportApiResponseUnmarshaller.Instance;

            return Invoke<ReimportApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Puts an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReimportApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ReimportApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ReimportApi">REST API Reference for ReimportApi Operation</seealso>
        public virtual Task<ReimportApiResponse> ReimportApiAsync(ReimportApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReimportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReimportApiResponseUnmarshaller.Instance;

            return InvokeAsync<ReimportApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Resets all authorizer cache entries on a stage. Supported only for HTTP APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAuthorizersCache service method.</param>
        /// <returns>The response from the ResetAuthorizersCache service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ResetAuthorizersCache">REST API Reference for ResetAuthorizersCache Operation</seealso>
        public virtual ResetAuthorizersCacheResponse ResetAuthorizersCache(ResetAuthorizersCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAuthorizersCacheResponseUnmarshaller.Instance;

            return Invoke<ResetAuthorizersCacheResponse>(request, options);
        }
#else
        internal virtual ResetAuthorizersCacheResponse ResetAuthorizersCache(ResetAuthorizersCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAuthorizersCacheResponseUnmarshaller.Instance;

            return Invoke<ResetAuthorizersCacheResponse>(request, options);
        }
#endif

        /// <summary>
        /// Resets all authorizer cache entries on a stage. Supported only for HTTP APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAuthorizersCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ResetAuthorizersCache service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/ResetAuthorizersCache">REST API Reference for ResetAuthorizersCache Operation</seealso>
        public virtual Task<ResetAuthorizersCacheResponse> ResetAuthorizersCacheAsync(ResetAuthorizersCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAuthorizersCacheResponseUnmarshaller.Instance;

            return InvokeAsync<ResetAuthorizersCacheResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new Tag resource to represent a tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#else
        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Creates a new Tag resource to represent a tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#else
        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }
#endif

        /// <summary>
        /// Deletes a Tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi service method.</param>
        /// <returns>The response from the UpdateApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual UpdateApiResponse UpdateApi(UpdateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return Invoke<UpdateApiResponse>(request, options);
        }
#else
        internal virtual UpdateApiResponse UpdateApi(UpdateApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return Invoke<UpdateApiResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateApi service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApi">REST API Reference for UpdateApi Operation</seealso>
        public virtual Task<UpdateApiResponse> UpdateApiAsync(UpdateApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// The API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping service method.</param>
        /// <returns>The response from the UpdateApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApiMapping">REST API Reference for UpdateApiMapping Operation</seealso>
        public virtual UpdateApiMappingResponse UpdateApiMapping(UpdateApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateApiMappingResponse>(request, options);
        }
#else
        internal virtual UpdateApiMappingResponse UpdateApiMapping(UpdateApiMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateApiMappingResponse>(request, options);
        }
#endif

        /// <summary>
        /// The API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateApiMapping service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateApiMapping">REST API Reference for UpdateApiMapping Operation</seealso>
        public virtual Task<UpdateApiMappingResponse> UpdateApiMappingAsync(UpdateApiMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiMappingResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// <returns>The response from the UpdateAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerResponse>(request, options);
        }
#else
        internal virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAuthorizer service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual Task<UpdateAuthorizerResponse> UpdateAuthorizerAsync(UpdateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAuthorizerResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// <returns>The response from the UpdateDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentResponse>(request, options);
        }
#else
        internal virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateDeployment service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual Task<UpdateDeploymentResponse> UpdateDeploymentAsync(UpdateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeploymentResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// <returns>The response from the UpdateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameResponse>(request, options);
        }
#else
        internal virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual Task<UpdateDomainNameResponse> UpdateDomainNameAsync(UpdateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainNameResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <returns>The response from the UpdateIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
        }
#else
        internal virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateIntegration service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// <returns>The response from the UpdateIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        public virtual UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseResponse>(request, options);
        }
#else
        internal virtual UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateIntegrationResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        public virtual Task<UpdateIntegrationResponseResponse> UpdateIntegrationResponseAsync(UpdateIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// <returns>The response from the UpdateModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
        }
#else
        internal virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateModel service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateModelResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <returns>The response from the UpdatePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual UpdatePortalResponse UpdatePortal(UpdatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalResponse>(request, options);
        }
#else
        internal virtual UpdatePortalResponse UpdatePortal(UpdatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdatePortal service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual Task<UpdatePortalResponse> UpdatePortalAsync(UpdatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePortalResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates the portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortalProduct service method.</param>
        /// <returns>The response from the UpdatePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortalProduct">REST API Reference for UpdatePortalProduct Operation</seealso>
        public virtual UpdatePortalProductResponse UpdatePortalProduct(UpdatePortalProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalProductResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalProductResponse>(request, options);
        }
#else
        internal virtual UpdatePortalProductResponse UpdatePortalProduct(UpdatePortalProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalProductResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalProductResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates the portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortalProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdatePortalProduct service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdatePortalProduct">REST API Reference for UpdatePortalProduct Operation</seealso>
        public virtual Task<UpdatePortalProductResponse> UpdatePortalProductAsync(UpdatePortalProductRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalProductResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePortalProductResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductPage service method.</param>
        /// <returns>The response from the UpdateProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        public virtual UpdateProductPageResponse UpdateProductPage(UpdateProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductPageResponseUnmarshaller.Instance;

            return Invoke<UpdateProductPageResponse>(request, options);
        }
#else
        internal virtual UpdateProductPageResponse UpdateProductPage(UpdateProductPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductPageResponseUnmarshaller.Instance;

            return Invoke<UpdateProductPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a product page of a portal product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProductPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        public virtual Task<UpdateProductPageResponse> UpdateProductPageAsync(UpdateProductPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductPageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProductPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductRestEndpointPage service method.</param>
        /// <returns>The response from the UpdateProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductRestEndpointPage">REST API Reference for UpdateProductRestEndpointPage Operation</seealso>
        public virtual UpdateProductRestEndpointPageResponse UpdateProductRestEndpointPage(UpdateProductRestEndpointPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductRestEndpointPageResponseUnmarshaller.Instance;

            return Invoke<UpdateProductRestEndpointPageResponse>(request, options);
        }
#else
        internal virtual UpdateProductRestEndpointPageResponse UpdateProductRestEndpointPage(UpdateProductRestEndpointPageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductRestEndpointPageResponseUnmarshaller.Instance;

            return Invoke<UpdateProductRestEndpointPageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a product REST endpoint page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductRestEndpointPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProductRestEndpointPage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateProductRestEndpointPage">REST API Reference for UpdateProductRestEndpointPage Operation</seealso>
        public virtual Task<UpdateProductRestEndpointPageResponse> UpdateProductRestEndpointPageAsync(UpdateProductRestEndpointPageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProductRestEndpointPageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProductRestEndpointPageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProductRestEndpointPageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// <returns>The response from the UpdateRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual UpdateRouteResponse UpdateRoute(UpdateRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponse>(request, options);
        }
#else
        internal virtual UpdateRouteResponse UpdateRoute(UpdateRouteRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRoute service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual Task<UpdateRouteResponse> UpdateRouteAsync(UpdateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRouteResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse service method.</param>
        /// <returns>The response from the UpdateRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRouteResponse">REST API Reference for UpdateRouteResponse Operation</seealso>
        public virtual UpdateRouteResponseResponse UpdateRouteResponse(UpdateRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponseResponse>(request, options);
        }
#else
        internal virtual UpdateRouteResponseResponse UpdateRouteResponse(UpdateRouteResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponseResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateRouteResponse service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateRouteResponse">REST API Reference for UpdateRouteResponse Operation</seealso>
        public virtual Task<UpdateRouteResponseResponse> UpdateRouteResponseAsync(UpdateRouteResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRouteResponseResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// <returns>The response from the UpdateStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
        }
#else
        internal virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateStage service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStageResponse>(request, options, cancellationToken);
        }

#if NETFRAMEWORK
        /// <summary>
        /// Updates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// <returns>The response from the UpdateVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        public virtual UpdateVpcLinkResponse UpdateVpcLink(UpdateVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcLinkResponse>(request, options);
        }
#else
        internal virtual UpdateVpcLinkResponse UpdateVpcLink(UpdateVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcLinkResponse>(request, options);
        }
#endif

        /// <summary>
        /// Updates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateVpcLink service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.BadRequestException">
        /// The request is not valid, for example, the input is incomplete or incorrect. See the
        /// accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.NotFoundException">
        /// The resource specified in the request was not found. See the message field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayV2.Model.TooManyRequestsException">
        /// A limit has been exceeded. See the accompanying error message for details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewayv2-2018-11-29/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        public virtual Task<UpdateVpcLinkResponse> UpdateVpcLinkAsync(UpdateVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVpcLinkResponse>(request, options, cancellationToken);
        }

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
    }
}
