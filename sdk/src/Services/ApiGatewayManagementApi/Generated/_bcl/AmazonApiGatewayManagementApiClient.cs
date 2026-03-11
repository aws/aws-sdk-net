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
 * Do not modify this file. This file is generated from the apigatewaymanagementapi-2018-11-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ApiGatewayManagementApi.Model;
using Amazon.ApiGatewayManagementApi.Model.Internal.MarshallTransformations;
using Amazon.ApiGatewayManagementApi.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ApiGatewayManagementApi
{
    /// <summary>
    /// <para>Implementation for accessing ApiGatewayManagementApi</para>
    ///
    /// The Amazon API Gateway Management API allows you to directly manage runtime aspects
    /// of your deployed APIs. To use it, you must explicitly set the SDK's endpoint to point
    /// to the endpoint of your deployed API. The endpoint will be of the form https://{api-id}.execute-api.{region}.amazonaws.com/{stage},
    /// or will be the endpoint corresponding to your API's custom domain and base path, if
    /// applicable.
    /// </summary>
    public partial class AmazonApiGatewayManagementApiClient : AmazonServiceClient, IAmazonApiGatewayManagementApi
    {
        private static IServiceMetadata serviceMetadata = new AmazonApiGatewayManagementApiMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with the credentials loaded from the application's
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
        public AmazonApiGatewayManagementApiClient()
            : base(new AmazonApiGatewayManagementApiConfig()) { }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with the credentials loaded from the application's
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
        public AmazonApiGatewayManagementApiClient(RegionEndpoint region)
            : base(new AmazonApiGatewayManagementApiConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApiGatewayManagementApiClient Configuration Object</param>
        public AmazonApiGatewayManagementApiClient(AmazonApiGatewayManagementApiConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApiGatewayManagementApiClient(AWSCredentials credentials)
            : this(credentials, new AmazonApiGatewayManagementApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayManagementApiClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApiGatewayManagementApiConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Credentials and an
        /// AmazonApiGatewayManagementApiClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApiGatewayManagementApiClient Configuration Object</param>
        public AmazonApiGatewayManagementApiClient(AWSCredentials credentials, AmazonApiGatewayManagementApiConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayManagementApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayManagementApiConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApiGatewayManagementApiClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApiGatewayManagementApiClient Configuration Object</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApiGatewayManagementApiConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayManagementApiConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayManagementApiConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApiGatewayManagementApiClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApiGatewayManagementApiClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApiGatewayManagementApiClient Configuration Object</param>
        public AmazonApiGatewayManagementApiClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApiGatewayManagementApiConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApiGatewayManagementApiEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApiGatewayManagementApiAuthSchemeHandler());
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


        #region  DeleteConnection


        /// <summary>
        /// Delete the connection with the provided id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }


        /// <summary>
        /// Delete the connection with the provided id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnection


        /// <summary>
        /// Get information about the connection with the provided id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }


        /// <summary>
        /// Get information about the connection with the provided id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PostToConnection


        /// <summary>
        /// Sends the provided data to the specified connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostToConnection service method.</param>
        /// 
        /// <returns>The response from the PostToConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.PayloadTooLargeException">
        /// The data has exceeded the maximum size allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/PostToConnection">REST API Reference for PostToConnection Operation</seealso>
        public virtual PostToConnectionResponse PostToConnection(PostToConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostToConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostToConnectionResponseUnmarshaller.Instance;

            return Invoke<PostToConnectionResponse>(request, options);
        }


        /// <summary>
        /// Sends the provided data to the specified connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostToConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostToConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.PayloadTooLargeException">
        /// The data has exceeded the maximum size allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/PostToConnection">REST API Reference for PostToConnection Operation</seealso>
        public virtual Task<PostToConnectionResponse> PostToConnectionAsync(PostToConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostToConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostToConnectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<PostToConnectionResponse>(request, options, cancellationToken);
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