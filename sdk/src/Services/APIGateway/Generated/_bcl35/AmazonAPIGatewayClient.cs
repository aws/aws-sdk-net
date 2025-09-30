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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.APIGateway.Model;
using Amazon.APIGateway.Model.Internal.MarshallTransformations;
using Amazon.APIGateway.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.APIGateway
{
    /// <summary>
    /// <para>Implementation for accessing APIGateway</para>
    ///
    /// Amazon API Gateway 
    /// <para>
    /// Amazon API Gateway helps developers deliver robust, secure, and scalable mobile and
    /// web application back ends. API Gateway allows developers to securely connect mobile
    /// and web applications to APIs that run on Lambda, Amazon EC2, or other publicly addressable
    /// web services that are hosted outside of AWS.
    /// </para>
    /// </summary>
    public partial class AmazonAPIGatewayClient : AmazonServiceClient, IAmazonAPIGateway
    {
        private static IServiceMetadata serviceMetadata = new AmazonAPIGatewayMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IAPIGatewayPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAPIGatewayPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new APIGatewayPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with the credentials loaded from the application's
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
        public AmazonAPIGatewayClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAPIGatewayConfig()) { }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with the credentials loaded from the application's
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
        public AmazonAPIGatewayClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAPIGatewayConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAPIGatewayClient Configuration Object</param>
        public AmazonAPIGatewayClient(AmazonAPIGatewayConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAPIGatewayClient(AWSCredentials credentials)
            : this(credentials, new AmazonAPIGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIGatewayClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAPIGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Credentials and an
        /// AmazonAPIGatewayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAPIGatewayClient Configuration Object</param>
        public AmazonAPIGatewayClient(AWSCredentials credentials, AmazonAPIGatewayConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAPIGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAPIGatewayConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAPIGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAPIGatewayClient Configuration Object</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAPIGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAPIGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAPIGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAPIGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAPIGatewayClient Configuration Object</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAPIGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.APIGateway.Internal.AmazonAPIGatewayPostMarshallHandler());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAPIGatewayEndpointResolver());
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


        #region  CreateApiKey

        /// <summary>
        /// Create an ApiKey resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual IAsyncResult BeginCreateApiKey(CreateApiKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiKey.</param>
        /// 
        /// <returns>Returns a  CreateApiKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        public virtual CreateApiKeyResponse EndCreateApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAuthorizer

        /// <summary>
        /// Adds a new Authorizer resource to an existing RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginCreateAuthorizer(CreateAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthorizer.</param>
        /// 
        /// <returns>Returns a  CreateAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        public virtual CreateAuthorizerResponse EndCreateAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBasePathMapping

        /// <summary>
        /// Creates a new BasePathMapping resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the CreateBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateBasePathMapping">REST API Reference for CreateBasePathMapping Operation</seealso>
        public virtual CreateBasePathMappingResponse CreateBasePathMapping(CreateBasePathMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBasePathMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<CreateBasePathMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBasePathMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateBasePathMapping">REST API Reference for CreateBasePathMapping Operation</seealso>
        public virtual IAsyncResult BeginCreateBasePathMapping(CreateBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBasePathMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBasePathMapping.</param>
        /// 
        /// <returns>Returns a  CreateBasePathMappingResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateBasePathMapping">REST API Reference for CreateBasePathMapping Operation</seealso>
        public virtual CreateBasePathMappingResponse EndCreateBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeployment

        /// <summary>
        /// Creates a Deployment resource, which makes a specified RestApi callable over the internet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        public virtual CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDocumentationPart

        /// <summary>
        /// Creates a documentation part.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the CreateDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationPart">REST API Reference for CreateDocumentationPart Operation</seealso>
        public virtual CreateDocumentationPartResponse CreateDocumentationPart(CreateDocumentationPartRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDocumentationPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentationPartResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationPart operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDocumentationPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationPart">REST API Reference for CreateDocumentationPart Operation</seealso>
        public virtual IAsyncResult BeginCreateDocumentationPart(CreateDocumentationPartRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDocumentationPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentationPartResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocumentationPart.</param>
        /// 
        /// <returns>Returns a  CreateDocumentationPartResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationPart">REST API Reference for CreateDocumentationPart Operation</seealso>
        public virtual CreateDocumentationPartResponse EndCreateDocumentationPart(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDocumentationPartResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDocumentationVersion

        /// <summary>
        /// Creates a documentation version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationVersion">REST API Reference for CreateDocumentationVersion Operation</seealso>
        public virtual CreateDocumentationVersionResponse CreateDocumentationVersion(CreateDocumentationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDocumentationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentationVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationVersion operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDocumentationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationVersion">REST API Reference for CreateDocumentationVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateDocumentationVersion(CreateDocumentationVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDocumentationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentationVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  CreateDocumentationVersionResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationVersion">REST API Reference for CreateDocumentationVersion Operation</seealso>
        public virtual CreateDocumentationVersionResponse EndCreateDocumentationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDocumentationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomainName

        /// <summary>
        /// Creates a new domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainName.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        public virtual CreateDomainNameResponse EndCreateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomainNameAccessAssociation

        /// <summary>
        /// Creates a domain name access association resource between an access association source
        /// and a private custom domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainNameAccessAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDomainNameAccessAssociation service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainNameAccessAssociation">REST API Reference for CreateDomainNameAccessAssociation Operation</seealso>
        public virtual CreateDomainNameAccessAssociationResponse CreateDomainNameAccessAssociation(CreateDomainNameAccessAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameAccessAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameAccessAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameAccessAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainNameAccessAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainNameAccessAssociation operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainNameAccessAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainNameAccessAssociation">REST API Reference for CreateDomainNameAccessAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateDomainNameAccessAssociation(CreateDomainNameAccessAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainNameAccessAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameAccessAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainNameAccessAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainNameAccessAssociation.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameAccessAssociationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainNameAccessAssociation">REST API Reference for CreateDomainNameAccessAssociation Operation</seealso>
        public virtual CreateDomainNameAccessAssociationResponse EndCreateDomainNameAccessAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainNameAccessAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModel

        /// <summary>
        /// Adds a new Model resource to an existing RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateModel">REST API Reference for CreateModel Operation</seealso>
        public virtual CreateModelResponse EndCreateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRequestValidator

        /// <summary>
        /// Creates a RequestValidator of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequestValidator service method.</param>
        /// 
        /// <returns>The response from the CreateRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRequestValidator">REST API Reference for CreateRequestValidator Operation</seealso>
        public virtual CreateRequestValidatorResponse CreateRequestValidator(CreateRequestValidatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRequestValidatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<CreateRequestValidatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRequestValidator operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRequestValidator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRequestValidator">REST API Reference for CreateRequestValidator Operation</seealso>
        public virtual IAsyncResult BeginCreateRequestValidator(CreateRequestValidatorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRequestValidatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRequestValidatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRequestValidator.</param>
        /// 
        /// <returns>Returns a  CreateRequestValidatorResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRequestValidator">REST API Reference for CreateRequestValidator Operation</seealso>
        public virtual CreateRequestValidatorResponse EndCreateRequestValidator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRequestValidatorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResource

        /// <summary>
        /// Creates a Resource resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual IAsyncResult BeginCreateResource(CreateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResource.</param>
        /// 
        /// <returns>Returns a  CreateResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateResource">REST API Reference for CreateResource Operation</seealso>
        public virtual CreateResourceResponse EndCreateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRestApi

        /// <summary>
        /// Creates a new RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi service method.</param>
        /// 
        /// <returns>The response from the CreateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRestApi">REST API Reference for CreateRestApi Operation</seealso>
        public virtual CreateRestApiResponse CreateRestApi(CreateRestApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestApiResponseUnmarshaller.Instance;

            return Invoke<CreateRestApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRestApi">REST API Reference for CreateRestApi Operation</seealso>
        public virtual IAsyncResult BeginCreateRestApi(CreateRestApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRestApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRestApi.</param>
        /// 
        /// <returns>Returns a  CreateRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRestApi">REST API Reference for CreateRestApi Operation</seealso>
        public virtual CreateRestApiResponse EndCreateRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStage

        /// <summary>
        /// Creates a new Stage resource that references a pre-existing Deployment for the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateStage">REST API Reference for CreateStage Operation</seealso>
        public virtual CreateStageResponse EndCreateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUsagePlan

        /// <summary>
        /// Creates a usage plan with the throttle and quota limits, as well as the associated
        /// API stages, specified in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlan service method.</param>
        /// 
        /// <returns>The response from the CreateUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlan">REST API Reference for CreateUsagePlan Operation</seealso>
        public virtual CreateUsagePlanResponse CreateUsagePlan(CreateUsagePlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUsagePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsagePlanResponseUnmarshaller.Instance;

            return Invoke<CreateUsagePlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlan operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUsagePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlan">REST API Reference for CreateUsagePlan Operation</seealso>
        public virtual IAsyncResult BeginCreateUsagePlan(CreateUsagePlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUsagePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsagePlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsagePlan.</param>
        /// 
        /// <returns>Returns a  CreateUsagePlanResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlan">REST API Reference for CreateUsagePlan Operation</seealso>
        public virtual CreateUsagePlanResponse EndCreateUsagePlan(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUsagePlanResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUsagePlanKey

        /// <summary>
        /// Creates a usage plan key for adding an existing API key to a usage plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlanKey service method.</param>
        /// 
        /// <returns>The response from the CreateUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlanKey">REST API Reference for CreateUsagePlanKey Operation</seealso>
        public virtual CreateUsagePlanKeyResponse CreateUsagePlanKey(CreateUsagePlanKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUsagePlanKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<CreateUsagePlanKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlanKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUsagePlanKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlanKey">REST API Reference for CreateUsagePlanKey Operation</seealso>
        public virtual IAsyncResult BeginCreateUsagePlanKey(CreateUsagePlanKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUsagePlanKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsagePlanKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  CreateUsagePlanKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlanKey">REST API Reference for CreateUsagePlanKey Operation</seealso>
        public virtual CreateUsagePlanKeyResponse EndCreateUsagePlanKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUsagePlanKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcLink

        /// <summary>
        /// Creates a VPC link, under the caller's account in a selected region, in an asynchronous
        /// operation that typically takes 2-4 minutes to complete and become operational. The
        /// caller must have permissions to create and update VPC Endpoint services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// 
        /// <returns>The response from the CreateVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        public virtual CreateVpcLinkResponse CreateVpcLink(CreateVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<CreateVpcLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcLink(CreateVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcLink.</param>
        /// 
        /// <returns>Returns a  CreateVpcLinkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        public virtual CreateVpcLinkResponse EndCreateVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApiKey

        /// <summary>
        /// Deletes the ApiKey resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey service method.</param>
        /// 
        /// <returns>The response from the DeleteApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual IAsyncResult BeginDeleteApiKey(DeleteApiKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiKey.</param>
        /// 
        /// <returns>Returns a  DeleteApiKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        public virtual DeleteApiKeyResponse EndDeleteApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAuthorizer

        /// <summary>
        /// Deletes an existing Authorizer resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginDeleteAuthorizer(DeleteAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthorizer.</param>
        /// 
        /// <returns>Returns a  DeleteAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        public virtual DeleteAuthorizerResponse EndDeleteAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBasePathMapping

        /// <summary>
        /// Deletes the BasePathMapping resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteBasePathMapping">REST API Reference for DeleteBasePathMapping Operation</seealso>
        public virtual DeleteBasePathMappingResponse DeleteBasePathMapping(DeleteBasePathMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBasePathMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteBasePathMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBasePathMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteBasePathMapping">REST API Reference for DeleteBasePathMapping Operation</seealso>
        public virtual IAsyncResult BeginDeleteBasePathMapping(DeleteBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBasePathMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBasePathMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBasePathMapping.</param>
        /// 
        /// <returns>Returns a  DeleteBasePathMappingResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteBasePathMapping">REST API Reference for DeleteBasePathMapping Operation</seealso>
        public virtual DeleteBasePathMappingResponse EndDeleteBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClientCertificate

        /// <summary>
        /// Deletes the ClientCertificate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteClientCertificate">REST API Reference for DeleteClientCertificate Operation</seealso>
        public virtual DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteClientCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteClientCertificate">REST API Reference for DeleteClientCertificate Operation</seealso>
        public virtual IAsyncResult BeginDeleteClientCertificate(DeleteClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClientCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteClientCertificateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteClientCertificate">REST API Reference for DeleteClientCertificate Operation</seealso>
        public virtual DeleteClientCertificateResponse EndDeleteClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeployment

        /// <summary>
        /// Deletes a Deployment resource. Deleting a deployment will only succeed if there are
        /// no Stage resources associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        public virtual DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDocumentationPart

        /// <summary>
        /// Deletes a documentation part
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the DeleteDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationPart">REST API Reference for DeleteDocumentationPart Operation</seealso>
        public virtual DeleteDocumentationPartResponse DeleteDocumentationPart(DeleteDocumentationPartRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDocumentationPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentationPartResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationPart operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocumentationPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationPart">REST API Reference for DeleteDocumentationPart Operation</seealso>
        public virtual IAsyncResult BeginDeleteDocumentationPart(DeleteDocumentationPartRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDocumentationPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentationPartResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentationPart.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentationPartResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationPart">REST API Reference for DeleteDocumentationPart Operation</seealso>
        public virtual DeleteDocumentationPartResponse EndDeleteDocumentationPart(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDocumentationPartResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDocumentationVersion

        /// <summary>
        /// Deletes a documentation version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationVersion">REST API Reference for DeleteDocumentationVersion Operation</seealso>
        public virtual DeleteDocumentationVersionResponse DeleteDocumentationVersion(DeleteDocumentationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDocumentationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentationVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationVersion operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocumentationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationVersion">REST API Reference for DeleteDocumentationVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteDocumentationVersion(DeleteDocumentationVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDocumentationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentationVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentationVersionResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationVersion">REST API Reference for DeleteDocumentationVersion Operation</seealso>
        public virtual DeleteDocumentationVersionResponse EndDeleteDocumentationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDocumentationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomainName

        /// <summary>
        /// Deletes the DomainName resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainName.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        public virtual DeleteDomainNameResponse EndDeleteDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomainNameAccessAssociation

        /// <summary>
        /// Deletes the DomainNameAccessAssociation resource.
        /// 
        ///  
        /// <para>
        /// Only the AWS account that created the DomainNameAccessAssociation resource can delete
        /// it. To stop an access association source in another AWS account from accessing your
        /// private custom domain name, use the RejectDomainNameAccessAssociation operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainNameAccessAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainNameAccessAssociation service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainNameAccessAssociation">REST API Reference for DeleteDomainNameAccessAssociation Operation</seealso>
        public virtual DeleteDomainNameAccessAssociationResponse DeleteDomainNameAccessAssociation(DeleteDomainNameAccessAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameAccessAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameAccessAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameAccessAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainNameAccessAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainNameAccessAssociation operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainNameAccessAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainNameAccessAssociation">REST API Reference for DeleteDomainNameAccessAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomainNameAccessAssociation(DeleteDomainNameAccessAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameAccessAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameAccessAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainNameAccessAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainNameAccessAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameAccessAssociationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainNameAccessAssociation">REST API Reference for DeleteDomainNameAccessAssociation Operation</seealso>
        public virtual DeleteDomainNameAccessAssociationResponse EndDeleteDomainNameAccessAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainNameAccessAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGatewayResponse

        /// <summary>
        /// Clears any customization of a GatewayResponse of a specified response type on the
        /// given RestApi and resets it with the default settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteGatewayResponse">REST API Reference for DeleteGatewayResponse Operation</seealso>
        public virtual DeleteGatewayResponseResponse DeleteGatewayResponse(DeleteGatewayResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGatewayResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteGatewayResponse">REST API Reference for DeleteGatewayResponse Operation</seealso>
        public virtual IAsyncResult BeginDeleteGatewayResponse(DeleteGatewayResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGatewayResponse.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteGatewayResponse">REST API Reference for DeleteGatewayResponse Operation</seealso>
        public virtual DeleteGatewayResponseResponse EndDeleteGatewayResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGatewayResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIntegration

        /// <summary>
        /// Represents a delete integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        public virtual DeleteIntegrationResponse EndDeleteIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIntegrationResponse

        /// <summary>
        /// Represents a delete integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        public virtual DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        public virtual IAsyncResult BeginDeleteIntegrationResponse(DeleteIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        public virtual DeleteIntegrationResponseResponse EndDeleteIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMethod

        /// <summary>
        /// Deletes an existing Method resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod service method.</param>
        /// 
        /// <returns>The response from the DeleteMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethod">REST API Reference for DeleteMethod Operation</seealso>
        public virtual DeleteMethodResponse DeleteMethod(DeleteMethodRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMethodResponseUnmarshaller.Instance;

            return Invoke<DeleteMethodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethod">REST API Reference for DeleteMethod Operation</seealso>
        public virtual IAsyncResult BeginDeleteMethod(DeleteMethodRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMethodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMethod.</param>
        /// 
        /// <returns>Returns a  DeleteMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethod">REST API Reference for DeleteMethod Operation</seealso>
        public virtual DeleteMethodResponse EndDeleteMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMethodResponse

        /// <summary>
        /// Deletes an existing MethodResponse resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethodResponse">REST API Reference for DeleteMethodResponse Operation</seealso>
        public virtual DeleteMethodResponseResponse DeleteMethodResponse(DeleteMethodResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMethodResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMethodResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteMethodResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMethodResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethodResponse">REST API Reference for DeleteMethodResponse Operation</seealso>
        public virtual IAsyncResult BeginDeleteMethodResponse(DeleteMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMethodResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMethodResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMethodResponse.</param>
        /// 
        /// <returns>Returns a  DeleteMethodResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethodResponse">REST API Reference for DeleteMethodResponse Operation</seealso>
        public virtual DeleteMethodResponseResponse EndDeleteMethodResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMethodResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteModel

        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        public virtual DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRequestValidator

        /// <summary>
        /// Deletes a RequestValidator of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequestValidator service method.</param>
        /// 
        /// <returns>The response from the DeleteRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRequestValidator">REST API Reference for DeleteRequestValidator Operation</seealso>
        public virtual DeleteRequestValidatorResponse DeleteRequestValidator(DeleteRequestValidatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRequestValidatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<DeleteRequestValidatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequestValidator operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRequestValidator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRequestValidator">REST API Reference for DeleteRequestValidator Operation</seealso>
        public virtual IAsyncResult BeginDeleteRequestValidator(DeleteRequestValidatorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRequestValidatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRequestValidatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRequestValidator.</param>
        /// 
        /// <returns>Returns a  DeleteRequestValidatorResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRequestValidator">REST API Reference for DeleteRequestValidator Operation</seealso>
        public virtual DeleteRequestValidatorResponse EndDeleteRequestValidator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRequestValidatorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResource

        /// <summary>
        /// Deletes a Resource resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual IAsyncResult BeginDeleteResource(DeleteResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResource.</param>
        /// 
        /// <returns>Returns a  DeleteResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        public virtual DeleteResourceResponse EndDeleteResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRestApi

        /// <summary>
        /// Deletes the specified API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi service method.</param>
        /// 
        /// <returns>The response from the DeleteRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRestApi">REST API Reference for DeleteRestApi Operation</seealso>
        public virtual DeleteRestApiResponse DeleteRestApi(DeleteRestApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestApiResponseUnmarshaller.Instance;

            return Invoke<DeleteRestApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRestApi">REST API Reference for DeleteRestApi Operation</seealso>
        public virtual IAsyncResult BeginDeleteRestApi(DeleteRestApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRestApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRestApi.</param>
        /// 
        /// <returns>Returns a  DeleteRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRestApi">REST API Reference for DeleteRestApi Operation</seealso>
        public virtual DeleteRestApiResponse EndDeleteRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStage

        /// <summary>
        /// Deletes a Stage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        public virtual DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUsagePlan

        /// <summary>
        /// Deletes a usage plan of a given plan Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlan service method.</param>
        /// 
        /// <returns>The response from the DeleteUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlan">REST API Reference for DeleteUsagePlan Operation</seealso>
        public virtual DeleteUsagePlanResponse DeleteUsagePlan(DeleteUsagePlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUsagePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsagePlanResponseUnmarshaller.Instance;

            return Invoke<DeleteUsagePlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlan operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUsagePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlan">REST API Reference for DeleteUsagePlan Operation</seealso>
        public virtual IAsyncResult BeginDeleteUsagePlan(DeleteUsagePlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUsagePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsagePlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsagePlan.</param>
        /// 
        /// <returns>Returns a  DeleteUsagePlanResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlan">REST API Reference for DeleteUsagePlan Operation</seealso>
        public virtual DeleteUsagePlanResponse EndDeleteUsagePlan(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUsagePlanResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUsagePlanKey

        /// <summary>
        /// Deletes a usage plan key and remove the underlying API key from the associated usage
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlanKey service method.</param>
        /// 
        /// <returns>The response from the DeleteUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlanKey">REST API Reference for DeleteUsagePlanKey Operation</seealso>
        public virtual DeleteUsagePlanKeyResponse DeleteUsagePlanKey(DeleteUsagePlanKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUsagePlanKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteUsagePlanKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlanKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUsagePlanKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlanKey">REST API Reference for DeleteUsagePlanKey Operation</seealso>
        public virtual IAsyncResult BeginDeleteUsagePlanKey(DeleteUsagePlanKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUsagePlanKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsagePlanKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  DeleteUsagePlanKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlanKey">REST API Reference for DeleteUsagePlanKey Operation</seealso>
        public virtual DeleteUsagePlanKeyResponse EndDeleteUsagePlanKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUsagePlanKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcLink

        /// <summary>
        /// Deletes an existing VpcLink of a specified identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        public virtual DeleteVpcLinkResponse DeleteVpcLink(DeleteVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        public virtual IAsyncResult BeginDeleteVpcLink(DeleteVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcLink.</param>
        /// 
        /// <returns>Returns a  DeleteVpcLinkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        public virtual DeleteVpcLinkResponse EndDeleteVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  FlushStageAuthorizersCache

        /// <summary>
        /// Flushes all authorizer cache entries on a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache service method.</param>
        /// 
        /// <returns>The response from the FlushStageAuthorizersCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageAuthorizersCache">REST API Reference for FlushStageAuthorizersCache Operation</seealso>
        public virtual FlushStageAuthorizersCacheResponse FlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlushStageAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlushStageAuthorizersCacheResponseUnmarshaller.Instance;

            return Invoke<FlushStageAuthorizersCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlushStageAuthorizersCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageAuthorizersCache">REST API Reference for FlushStageAuthorizersCache Operation</seealso>
        public virtual IAsyncResult BeginFlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlushStageAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlushStageAuthorizersCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlushStageAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushStageAuthorizersCache.</param>
        /// 
        /// <returns>Returns a  FlushStageAuthorizersCacheResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageAuthorizersCache">REST API Reference for FlushStageAuthorizersCache Operation</seealso>
        public virtual FlushStageAuthorizersCacheResponse EndFlushStageAuthorizersCache(IAsyncResult asyncResult)
        {
            return EndInvoke<FlushStageAuthorizersCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  FlushStageCache

        /// <summary>
        /// Flushes a stage's cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache service method.</param>
        /// 
        /// <returns>The response from the FlushStageCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageCache">REST API Reference for FlushStageCache Operation</seealso>
        public virtual FlushStageCacheResponse FlushStageCache(FlushStageCacheRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlushStageCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlushStageCacheResponseUnmarshaller.Instance;

            return Invoke<FlushStageCacheResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlushStageCache
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageCache">REST API Reference for FlushStageCache Operation</seealso>
        public virtual IAsyncResult BeginFlushStageCache(FlushStageCacheRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = FlushStageCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FlushStageCacheResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushStageCache.</param>
        /// 
        /// <returns>Returns a  FlushStageCacheResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageCache">REST API Reference for FlushStageCache Operation</seealso>
        public virtual FlushStageCacheResponse EndFlushStageCache(IAsyncResult asyncResult)
        {
            return EndInvoke<FlushStageCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateClientCertificate

        /// <summary>
        /// Generates a ClientCertificate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GenerateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GenerateClientCertificate">REST API Reference for GenerateClientCertificate Operation</seealso>
        public virtual GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;

            return Invoke<GenerateClientCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GenerateClientCertificate">REST API Reference for GenerateClientCertificate Operation</seealso>
        public virtual IAsyncResult BeginGenerateClientCertificate(GenerateClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateClientCertificate.</param>
        /// 
        /// <returns>Returns a  GenerateClientCertificateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GenerateClientCertificate">REST API Reference for GenerateClientCertificate Operation</seealso>
        public virtual GenerateClientCertificateResponse EndGenerateClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccount

        /// <summary>
        /// Gets information about the current Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccount.</param>
        /// 
        /// <returns>Returns a  GetAccountResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAccount">REST API Reference for GetAccount Operation</seealso>
        public virtual GetAccountResponse EndGetAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiKey

        /// <summary>
        /// Gets information about the current ApiKey resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey service method.</param>
        /// 
        /// <returns>The response from the GetApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKey">REST API Reference for GetApiKey Operation</seealso>
        public virtual GetApiKeyResponse GetApiKey(GetApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiKeyResponseUnmarshaller.Instance;

            return Invoke<GetApiKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKey">REST API Reference for GetApiKey Operation</seealso>
        public virtual IAsyncResult BeginGetApiKey(GetApiKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKey.</param>
        /// 
        /// <returns>Returns a  GetApiKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKey">REST API Reference for GetApiKey Operation</seealso>
        public virtual GetApiKeyResponse EndGetApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiKeys

        /// <summary>
        /// Gets information about the current ApiKeys resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys service method.</param>
        /// 
        /// <returns>The response from the GetApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKeys">REST API Reference for GetApiKeys Operation</seealso>
        public virtual GetApiKeysResponse GetApiKeys(GetApiKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiKeysResponseUnmarshaller.Instance;

            return Invoke<GetApiKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApiKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKeys">REST API Reference for GetApiKeys Operation</seealso>
        public virtual IAsyncResult BeginGetApiKeys(GetApiKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKeys.</param>
        /// 
        /// <returns>Returns a  GetApiKeysResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKeys">REST API Reference for GetApiKeys Operation</seealso>
        public virtual GetApiKeysResponse EndGetApiKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAuthorizer

        /// <summary>
        /// Describe an existing Authorizer resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        public virtual GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginGetAuthorizer(GetAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizer.</param>
        /// 
        /// <returns>Returns a  GetAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        public virtual GetAuthorizerResponse EndGetAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAuthorizers

        /// <summary>
        /// Describe an existing Authorizers resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizers service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        public virtual GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAuthorizers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        public virtual IAsyncResult BeginGetAuthorizers(GetAuthorizersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizers.</param>
        /// 
        /// <returns>Returns a  GetAuthorizersResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        public virtual GetAuthorizersResponse EndGetAuthorizers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAuthorizersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBasePathMapping

        /// <summary>
        /// Describe a BasePathMapping resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the GetBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMapping">REST API Reference for GetBasePathMapping Operation</seealso>
        public virtual GetBasePathMappingResponse GetBasePathMapping(GetBasePathMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBasePathMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<GetBasePathMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBasePathMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMapping">REST API Reference for GetBasePathMapping Operation</seealso>
        public virtual IAsyncResult BeginGetBasePathMapping(GetBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBasePathMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBasePathMapping.</param>
        /// 
        /// <returns>Returns a  GetBasePathMappingResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMapping">REST API Reference for GetBasePathMapping Operation</seealso>
        public virtual GetBasePathMappingResponse EndGetBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBasePathMappings

        /// <summary>
        /// Represents a collection of BasePathMapping resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings service method.</param>
        /// 
        /// <returns>The response from the GetBasePathMappings service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMappings">REST API Reference for GetBasePathMappings Operation</seealso>
        public virtual GetBasePathMappingsResponse GetBasePathMappings(GetBasePathMappingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBasePathMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;

            return Invoke<GetBasePathMappingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBasePathMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMappings">REST API Reference for GetBasePathMappings Operation</seealso>
        public virtual IAsyncResult BeginGetBasePathMappings(GetBasePathMappingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBasePathMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBasePathMappings.</param>
        /// 
        /// <returns>Returns a  GetBasePathMappingsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMappings">REST API Reference for GetBasePathMappings Operation</seealso>
        public virtual GetBasePathMappingsResponse EndGetBasePathMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBasePathMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClientCertificate

        /// <summary>
        /// Gets information about the current ClientCertificate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificate">REST API Reference for GetClientCertificate Operation</seealso>
        public virtual GetClientCertificateResponse GetClientCertificate(GetClientCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClientCertificateResponseUnmarshaller.Instance;

            return Invoke<GetClientCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificate">REST API Reference for GetClientCertificate Operation</seealso>
        public virtual IAsyncResult BeginGetClientCertificate(GetClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClientCertificate.</param>
        /// 
        /// <returns>Returns a  GetClientCertificateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificate">REST API Reference for GetClientCertificate Operation</seealso>
        public virtual GetClientCertificateResponse EndGetClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClientCertificates

        /// <summary>
        /// Gets a collection of ClientCertificate resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificates service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificates">REST API Reference for GetClientCertificates Operation</seealso>
        public virtual GetClientCertificatesResponse GetClientCertificates(GetClientCertificatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClientCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<GetClientCertificatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetClientCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificates">REST API Reference for GetClientCertificates Operation</seealso>
        public virtual IAsyncResult BeginGetClientCertificates(GetClientCertificatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClientCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClientCertificates.</param>
        /// 
        /// <returns>Returns a  GetClientCertificatesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificates">REST API Reference for GetClientCertificates Operation</seealso>
        public virtual GetClientCertificatesResponse EndGetClientCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClientCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployment

        /// <summary>
        /// Gets information about a Deployment resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        public virtual GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployments

        /// <summary>
        /// Gets information about a Deployments collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        public virtual GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeployments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        public virtual IAsyncResult BeginGetDeployments(GetDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployments.</param>
        /// 
        /// <returns>Returns a  GetDeploymentsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        public virtual GetDeploymentsResponse EndGetDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentationPart

        /// <summary>
        /// Gets a documentation part.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationPart">REST API Reference for GetDocumentationPart Operation</seealso>
        public virtual GetDocumentationPartResponse GetDocumentationPart(GetDocumentationPartRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentationPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationPartResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationPart operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentationPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationPart">REST API Reference for GetDocumentationPart Operation</seealso>
        public virtual IAsyncResult BeginGetDocumentationPart(GetDocumentationPartRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentationPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentationPartResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationPart.</param>
        /// 
        /// <returns>Returns a  GetDocumentationPartResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationPart">REST API Reference for GetDocumentationPart Operation</seealso>
        public virtual GetDocumentationPartResponse EndGetDocumentationPart(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentationPartResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentationParts

        /// <summary>
        /// Gets documentation parts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationParts service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationParts service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationParts">REST API Reference for GetDocumentationParts Operation</seealso>
        public virtual GetDocumentationPartsResponse GetDocumentationParts(GetDocumentationPartsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentationPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentationPartsResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationPartsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationParts operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentationParts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationParts">REST API Reference for GetDocumentationParts Operation</seealso>
        public virtual IAsyncResult BeginGetDocumentationParts(GetDocumentationPartsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentationPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentationPartsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationParts.</param>
        /// 
        /// <returns>Returns a  GetDocumentationPartsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationParts">REST API Reference for GetDocumentationParts Operation</seealso>
        public virtual GetDocumentationPartsResponse EndGetDocumentationParts(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentationPartsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentationVersion

        /// <summary>
        /// Gets a documentation version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersion service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersion">REST API Reference for GetDocumentationVersion Operation</seealso>
        public virtual GetDocumentationVersionResponse GetDocumentationVersion(GetDocumentationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersion operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersion">REST API Reference for GetDocumentationVersion Operation</seealso>
        public virtual IAsyncResult BeginGetDocumentationVersion(GetDocumentationVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentationVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  GetDocumentationVersionResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersion">REST API Reference for GetDocumentationVersion Operation</seealso>
        public virtual GetDocumentationVersionResponse EndGetDocumentationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentationVersions

        /// <summary>
        /// Gets documentation versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersions service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationVersions service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersions">REST API Reference for GetDocumentationVersions Operation</seealso>
        public virtual GetDocumentationVersionsResponse GetDocumentationVersions(GetDocumentationVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentationVersionsResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersions operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentationVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersions">REST API Reference for GetDocumentationVersions Operation</seealso>
        public virtual IAsyncResult BeginGetDocumentationVersions(GetDocumentationVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDocumentationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDocumentationVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationVersions.</param>
        /// 
        /// <returns>Returns a  GetDocumentationVersionsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersions">REST API Reference for GetDocumentationVersions Operation</seealso>
        public virtual GetDocumentationVersionsResponse EndGetDocumentationVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentationVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainName

        /// <summary>
        /// Represents a domain name that is contained in a simpler, more intuitive URL that can
        /// be called.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// 
        /// <returns>The response from the GetDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainName.</param>
        /// 
        /// <returns>Returns a  GetDomainNameResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        public virtual GetDomainNameResponse EndGetDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainNameAccessAssociations

        /// <summary>
        /// Represents a collection on DomainNameAccessAssociations resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNameAccessAssociations service method.</param>
        /// 
        /// <returns>The response from the GetDomainNameAccessAssociations service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNameAccessAssociations">REST API Reference for GetDomainNameAccessAssociations Operation</seealso>
        public virtual GetDomainNameAccessAssociationsResponse GetDomainNameAccessAssociations(GetDomainNameAccessAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameAccessAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameAccessAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameAccessAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainNameAccessAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNameAccessAssociations operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainNameAccessAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNameAccessAssociations">REST API Reference for GetDomainNameAccessAssociations Operation</seealso>
        public virtual IAsyncResult BeginGetDomainNameAccessAssociations(GetDomainNameAccessAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNameAccessAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameAccessAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainNameAccessAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainNameAccessAssociations.</param>
        /// 
        /// <returns>Returns a  GetDomainNameAccessAssociationsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNameAccessAssociations">REST API Reference for GetDomainNameAccessAssociations Operation</seealso>
        public virtual GetDomainNameAccessAssociationsResponse EndGetDomainNameAccessAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNameAccessAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainNames

        /// <summary>
        /// Represents a collection of DomainName resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// 
        /// <returns>The response from the GetDomainNames service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        public virtual GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        public virtual IAsyncResult BeginGetDomainNames(GetDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainNames.</param>
        /// 
        /// <returns>Returns a  GetDomainNamesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        public virtual GetDomainNamesResponse EndGetDomainNames(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExport

        /// <summary>
        /// Exports a deployed version of a RestApi in a specified format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetExport">REST API Reference for GetExport Operation</seealso>
        public virtual GetExportResponse GetExport(GetExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportResponseUnmarshaller.Instance;

            return Invoke<GetExportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExport operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetExport">REST API Reference for GetExport Operation</seealso>
        public virtual IAsyncResult BeginGetExport(GetExportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExport.</param>
        /// 
        /// <returns>Returns a  GetExportResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetExport">REST API Reference for GetExport Operation</seealso>
        public virtual GetExportResponse EndGetExport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGatewayResponse

        /// <summary>
        /// Gets a GatewayResponse of a specified response type on the given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the GetGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponse">REST API Reference for GetGatewayResponse Operation</seealso>
        public virtual GetGatewayResponseResponse GetGatewayResponse(GetGatewayResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGatewayResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGatewayResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponse">REST API Reference for GetGatewayResponse Operation</seealso>
        public virtual IAsyncResult BeginGetGatewayResponse(GetGatewayResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGatewayResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGatewayResponse.</param>
        /// 
        /// <returns>Returns a  GetGatewayResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponse">REST API Reference for GetGatewayResponse Operation</seealso>
        public virtual GetGatewayResponseResponse EndGetGatewayResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGatewayResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGatewayResponses

        /// <summary>
        /// Gets the GatewayResponses collection on the given RestApi. If an API developer has
        /// not added any definitions for gateway responses, the result will be the API Gateway-generated
        /// default GatewayResponses collection for the supported response types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponses service method.</param>
        /// 
        /// <returns>The response from the GetGatewayResponses service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponses">REST API Reference for GetGatewayResponses Operation</seealso>
        public virtual GetGatewayResponsesResponse GetGatewayResponses(GetGatewayResponsesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGatewayResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponsesResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponsesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGatewayResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponses operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGatewayResponses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponses">REST API Reference for GetGatewayResponses Operation</seealso>
        public virtual IAsyncResult BeginGetGatewayResponses(GetGatewayResponsesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGatewayResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponsesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGatewayResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGatewayResponses.</param>
        /// 
        /// <returns>Returns a  GetGatewayResponsesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponses">REST API Reference for GetGatewayResponses Operation</seealso>
        public virtual GetGatewayResponsesResponse EndGetGatewayResponses(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGatewayResponsesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIntegration

        /// <summary>
        /// Get the integration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegration.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        public virtual GetIntegrationResponse EndGetIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIntegrationResponse

        /// <summary>
        /// Represents a get integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the GetIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        public virtual GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        public virtual IAsyncResult BeginGetIntegrationResponse(GetIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        public virtual GetIntegrationResponseResponse EndGetIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMethod

        /// <summary>
        /// Describe an existing Method resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMethod service method.</param>
        /// 
        /// <returns>The response from the GetMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethod">REST API Reference for GetMethod Operation</seealso>
        public virtual GetMethodResponse GetMethod(GetMethodRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMethodResponseUnmarshaller.Instance;

            return Invoke<GetMethodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethod">REST API Reference for GetMethod Operation</seealso>
        public virtual IAsyncResult BeginGetMethod(GetMethodRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMethodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMethod.</param>
        /// 
        /// <returns>Returns a  GetMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethod">REST API Reference for GetMethod Operation</seealso>
        public virtual GetMethodResponse EndGetMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMethodResponse

        /// <summary>
        /// Describes a MethodResponse resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse service method.</param>
        /// 
        /// <returns>The response from the GetMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethodResponse">REST API Reference for GetMethodResponse Operation</seealso>
        public virtual GetMethodResponseResponse GetMethodResponse(GetMethodResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMethodResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMethodResponseResponseUnmarshaller.Instance;

            return Invoke<GetMethodResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMethodResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethodResponse">REST API Reference for GetMethodResponse Operation</seealso>
        public virtual IAsyncResult BeginGetMethodResponse(GetMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMethodResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMethodResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMethodResponse.</param>
        /// 
        /// <returns>Returns a  GetMethodResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethodResponse">REST API Reference for GetMethodResponse Operation</seealso>
        public virtual GetMethodResponseResponse EndGetMethodResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMethodResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModel

        /// <summary>
        /// Describes an existing model defined for a RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// 
        /// <returns>The response from the GetModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModel">REST API Reference for GetModel Operation</seealso>
        public virtual GetModelResponse GetModel(GetModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModel operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModel">REST API Reference for GetModel Operation</seealso>
        public virtual IAsyncResult BeginGetModel(GetModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModel.</param>
        /// 
        /// <returns>Returns a  GetModelResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModel">REST API Reference for GetModel Operation</seealso>
        public virtual GetModelResponse EndGetModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModels

        /// <summary>
        /// Describes existing Models defined for a RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModels">REST API Reference for GetModels Operation</seealso>
        public virtual GetModelsResponse EndGetModels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModelTemplate

        /// <summary>
        /// Generates a sample mapping template that can be used to transform a payload into the
        /// structure of a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// 
        /// <returns>The response from the GetModelTemplate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        public virtual GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetModelTemplate(GetModelTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelTemplate.</param>
        /// 
        /// <returns>Returns a  GetModelTemplateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        public virtual GetModelTemplateResponse EndGetModelTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRequestValidator

        /// <summary>
        /// Gets a RequestValidator of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidator service method.</param>
        /// 
        /// <returns>The response from the GetRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidator">REST API Reference for GetRequestValidator Operation</seealso>
        public virtual GetRequestValidatorResponse GetRequestValidator(GetRequestValidatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequestValidatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<GetRequestValidatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidator operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRequestValidator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidator">REST API Reference for GetRequestValidator Operation</seealso>
        public virtual IAsyncResult BeginGetRequestValidator(GetRequestValidatorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequestValidatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestValidatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequestValidator.</param>
        /// 
        /// <returns>Returns a  GetRequestValidatorResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidator">REST API Reference for GetRequestValidator Operation</seealso>
        public virtual GetRequestValidatorResponse EndGetRequestValidator(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRequestValidatorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRequestValidators

        /// <summary>
        /// Gets the RequestValidators collection of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidators service method.</param>
        /// 
        /// <returns>The response from the GetRequestValidators service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidators">REST API Reference for GetRequestValidators Operation</seealso>
        public virtual GetRequestValidatorsResponse GetRequestValidators(GetRequestValidatorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequestValidatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestValidatorsResponseUnmarshaller.Instance;

            return Invoke<GetRequestValidatorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRequestValidators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidators operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRequestValidators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidators">REST API Reference for GetRequestValidators Operation</seealso>
        public virtual IAsyncResult BeginGetRequestValidators(GetRequestValidatorsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRequestValidatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRequestValidatorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequestValidators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequestValidators.</param>
        /// 
        /// <returns>Returns a  GetRequestValidatorsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidators">REST API Reference for GetRequestValidators Operation</seealso>
        public virtual GetRequestValidatorsResponse EndGetRequestValidators(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRequestValidatorsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResource

        /// <summary>
        /// Lists information about a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResource service method.</param>
        /// 
        /// <returns>The response from the GetResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResource">REST API Reference for GetResource Operation</seealso>
        public virtual GetResourceResponse GetResource(GetResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceResponseUnmarshaller.Instance;

            return Invoke<GetResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResource">REST API Reference for GetResource Operation</seealso>
        public virtual IAsyncResult BeginGetResource(GetResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResource.</param>
        /// 
        /// <returns>Returns a  GetResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResource">REST API Reference for GetResource Operation</seealso>
        public virtual GetResourceResponse EndGetResource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResources

        /// <summary>
        /// Lists information about a collection of Resource resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return Invoke<GetResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual IAsyncResult BeginGetResources(GetResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResources.</param>
        /// 
        /// <returns>Returns a  GetResourcesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResources">REST API Reference for GetResources Operation</seealso>
        public virtual GetResourcesResponse EndGetResources(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRestApi

        /// <summary>
        /// Lists the RestApi resource in the collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi service method.</param>
        /// 
        /// <returns>The response from the GetRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApi">REST API Reference for GetRestApi Operation</seealso>
        public virtual GetRestApiResponse GetRestApi(GetRestApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestApiResponseUnmarshaller.Instance;

            return Invoke<GetRestApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApi">REST API Reference for GetRestApi Operation</seealso>
        public virtual IAsyncResult BeginGetRestApi(GetRestApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestApi.</param>
        /// 
        /// <returns>Returns a  GetRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApi">REST API Reference for GetRestApi Operation</seealso>
        public virtual GetRestApiResponse EndGetRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRestApis

        /// <summary>
        /// Lists the RestApis resources for your collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis service method.</param>
        /// 
        /// <returns>The response from the GetRestApis service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApis">REST API Reference for GetRestApis Operation</seealso>
        public virtual GetRestApisResponse GetRestApis(GetRestApisRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestApisResponseUnmarshaller.Instance;

            return Invoke<GetRestApisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRestApis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApis">REST API Reference for GetRestApis Operation</seealso>
        public virtual IAsyncResult BeginGetRestApis(GetRestApisRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRestApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRestApisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestApis.</param>
        /// 
        /// <returns>Returns a  GetRestApisResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApis">REST API Reference for GetRestApis Operation</seealso>
        public virtual GetRestApisResponse EndGetRestApis(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestApisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSdk

        /// <summary>
        /// Generates a client SDK for a RestApi and Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdk service method.</param>
        /// 
        /// <returns>The response from the GetSdk service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdk">REST API Reference for GetSdk Operation</seealso>
        public virtual GetSdkResponse GetSdk(GetSdkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSdkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSdkResponseUnmarshaller.Instance;

            return Invoke<GetSdkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSdk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdk operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSdk
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdk">REST API Reference for GetSdk Operation</seealso>
        public virtual IAsyncResult BeginGetSdk(GetSdkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSdkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSdkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdk.</param>
        /// 
        /// <returns>Returns a  GetSdkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdk">REST API Reference for GetSdk Operation</seealso>
        public virtual GetSdkResponse EndGetSdk(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSdkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSdkType

        /// <summary>
        /// Gets an SDK type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdkType service method.</param>
        /// 
        /// <returns>The response from the GetSdkType service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkType">REST API Reference for GetSdkType Operation</seealso>
        public virtual GetSdkTypeResponse GetSdkType(GetSdkTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSdkTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSdkTypeResponseUnmarshaller.Instance;

            return Invoke<GetSdkTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSdkType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdkType operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSdkType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkType">REST API Reference for GetSdkType Operation</seealso>
        public virtual IAsyncResult BeginGetSdkType(GetSdkTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSdkTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSdkTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdkType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdkType.</param>
        /// 
        /// <returns>Returns a  GetSdkTypeResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkType">REST API Reference for GetSdkType Operation</seealso>
        public virtual GetSdkTypeResponse EndGetSdkType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSdkTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSdkTypes

        /// <summary>
        /// Gets SDK types
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdkTypes service method.</param>
        /// 
        /// <returns>The response from the GetSdkTypes service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkTypes">REST API Reference for GetSdkTypes Operation</seealso>
        public virtual GetSdkTypesResponse GetSdkTypes(GetSdkTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSdkTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSdkTypesResponseUnmarshaller.Instance;

            return Invoke<GetSdkTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSdkTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdkTypes operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSdkTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkTypes">REST API Reference for GetSdkTypes Operation</seealso>
        public virtual IAsyncResult BeginGetSdkTypes(GetSdkTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSdkTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSdkTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdkTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdkTypes.</param>
        /// 
        /// <returns>Returns a  GetSdkTypesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkTypes">REST API Reference for GetSdkTypes Operation</seealso>
        public virtual GetSdkTypesResponse EndGetSdkTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSdkTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStage

        /// <summary>
        /// Gets information about a Stage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStage">REST API Reference for GetStage Operation</seealso>
        public virtual GetStageResponse EndGetStage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStages

        /// <summary>
        /// Gets information about one or more Stage resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// 
        /// <returns>The response from the GetStages service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStages">REST API Reference for GetStages Operation</seealso>
        public virtual GetStagesResponse GetStages(GetStagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStages operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStages">REST API Reference for GetStages Operation</seealso>
        public virtual IAsyncResult BeginGetStages(GetStagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStages.</param>
        /// 
        /// <returns>Returns a  GetStagesResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStages">REST API Reference for GetStages Operation</seealso>
        public virtual GetStagesResponse EndGetStages(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStagesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTags

        /// <summary>
        /// Gets the Tags collection for a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual GetTagsResponse EndGetTags(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUsage

        /// <summary>
        /// Gets the usage data of a usage plan in a specified time interval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsage service method.</param>
        /// 
        /// <returns>The response from the GetUsage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsage">REST API Reference for GetUsage Operation</seealso>
        public virtual GetUsageResponse GetUsage(GetUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageResponseUnmarshaller.Instance;

            return Invoke<GetUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsage">REST API Reference for GetUsage Operation</seealso>
        public virtual IAsyncResult BeginGetUsage(GetUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsage.</param>
        /// 
        /// <returns>Returns a  GetUsageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsage">REST API Reference for GetUsage Operation</seealso>
        public virtual GetUsageResponse EndGetUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUsagePlan

        /// <summary>
        /// Gets a usage plan of a given plan identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlan service method.</param>
        /// 
        /// <returns>The response from the GetUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlan">REST API Reference for GetUsagePlan Operation</seealso>
        public virtual GetUsagePlanResponse GetUsagePlan(GetUsagePlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsagePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsagePlanResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlan operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsagePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlan">REST API Reference for GetUsagePlan Operation</seealso>
        public virtual IAsyncResult BeginGetUsagePlan(GetUsagePlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsagePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsagePlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlan.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlan">REST API Reference for GetUsagePlan Operation</seealso>
        public virtual GetUsagePlanResponse EndGetUsagePlan(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUsagePlanResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUsagePlanKey

        /// <summary>
        /// Gets a usage plan key of a given key identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKey service method.</param>
        /// 
        /// <returns>The response from the GetUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKey">REST API Reference for GetUsagePlanKey Operation</seealso>
        public virtual GetUsagePlanKeyResponse GetUsagePlanKey(GetUsagePlanKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsagePlanKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsagePlanKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKey">REST API Reference for GetUsagePlanKey Operation</seealso>
        public virtual IAsyncResult BeginGetUsagePlanKey(GetUsagePlanKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsagePlanKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsagePlanKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKey">REST API Reference for GetUsagePlanKey Operation</seealso>
        public virtual GetUsagePlanKeyResponse EndGetUsagePlanKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUsagePlanKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUsagePlanKeys

        /// <summary>
        /// Gets all the usage plan keys representing the API keys added to a specified usage
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKeys service method.</param>
        /// 
        /// <returns>The response from the GetUsagePlanKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKeys">REST API Reference for GetUsagePlanKeys Operation</seealso>
        public virtual GetUsagePlanKeysResponse GetUsagePlanKeys(GetUsagePlanKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsagePlanKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsagePlanKeysResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlanKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKeys operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsagePlanKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKeys">REST API Reference for GetUsagePlanKeys Operation</seealso>
        public virtual IAsyncResult BeginGetUsagePlanKeys(GetUsagePlanKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsagePlanKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsagePlanKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlanKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlanKeys.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanKeysResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKeys">REST API Reference for GetUsagePlanKeys Operation</seealso>
        public virtual GetUsagePlanKeysResponse EndGetUsagePlanKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUsagePlanKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUsagePlans

        /// <summary>
        /// Gets all the usage plans of the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlans service method.</param>
        /// 
        /// <returns>The response from the GetUsagePlans service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlans">REST API Reference for GetUsagePlans Operation</seealso>
        public virtual GetUsagePlansResponse GetUsagePlans(GetUsagePlansRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsagePlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsagePlansResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlansResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlans operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsagePlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlans">REST API Reference for GetUsagePlans Operation</seealso>
        public virtual IAsyncResult BeginGetUsagePlans(GetUsagePlansRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUsagePlansRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsagePlansResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlans.</param>
        /// 
        /// <returns>Returns a  GetUsagePlansResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlans">REST API Reference for GetUsagePlans Operation</seealso>
        public virtual GetUsagePlansResponse EndGetUsagePlans(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUsagePlansResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVpcLink

        /// <summary>
        /// Gets a specified VPC link under the caller's account in a region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// 
        /// <returns>The response from the GetVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        public virtual GetVpcLinkResponse GetVpcLink(GetVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        public virtual IAsyncResult BeginGetVpcLink(GetVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLink.</param>
        /// 
        /// <returns>Returns a  GetVpcLinkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        public virtual GetVpcLinkResponse EndGetVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVpcLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVpcLinks

        /// <summary>
        /// Gets the VpcLinks collection under the caller's account in a selected region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// 
        /// <returns>The response from the GetVpcLinks service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        public virtual GetVpcLinksResponse GetVpcLinks(GetVpcLinksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        public virtual IAsyncResult BeginGetVpcLinks(GetVpcLinksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLinks.</param>
        /// 
        /// <returns>Returns a  GetVpcLinksResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        public virtual GetVpcLinksResponse EndGetVpcLinks(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVpcLinksResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportApiKeys

        /// <summary>
        /// Import API keys from an external source, such as a CSV-formatted file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApiKeys service method.</param>
        /// 
        /// <returns>The response from the ImportApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportApiKeys">REST API Reference for ImportApiKeys Operation</seealso>
        public virtual ImportApiKeysResponse ImportApiKeys(ImportApiKeysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiKeysResponseUnmarshaller.Instance;

            return Invoke<ImportApiKeysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportApiKeys operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportApiKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportApiKeys">REST API Reference for ImportApiKeys Operation</seealso>
        public virtual IAsyncResult BeginImportApiKeys(ImportApiKeysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportApiKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiKeysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportApiKeys.</param>
        /// 
        /// <returns>Returns a  ImportApiKeysResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportApiKeys">REST API Reference for ImportApiKeys Operation</seealso>
        public virtual ImportApiKeysResponse EndImportApiKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportApiKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportDocumentationParts

        /// <summary>
        /// Imports documentation parts
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDocumentationParts service method.</param>
        /// 
        /// <returns>The response from the ImportDocumentationParts service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportDocumentationParts">REST API Reference for ImportDocumentationParts Operation</seealso>
        public virtual ImportDocumentationPartsResponse ImportDocumentationParts(ImportDocumentationPartsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDocumentationPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDocumentationPartsResponseUnmarshaller.Instance;

            return Invoke<ImportDocumentationPartsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportDocumentationParts operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportDocumentationParts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportDocumentationParts">REST API Reference for ImportDocumentationParts Operation</seealso>
        public virtual IAsyncResult BeginImportDocumentationParts(ImportDocumentationPartsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportDocumentationPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportDocumentationPartsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportDocumentationParts.</param>
        /// 
        /// <returns>Returns a  ImportDocumentationPartsResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportDocumentationParts">REST API Reference for ImportDocumentationParts Operation</seealso>
        public virtual ImportDocumentationPartsResponse EndImportDocumentationParts(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportDocumentationPartsResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportRestApi

        /// <summary>
        /// A feature of the API Gateway control service for creating a new API from an external
        /// API definition file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportRestApi service method.</param>
        /// 
        /// <returns>The response from the ImportRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportRestApi">REST API Reference for ImportRestApi Operation</seealso>
        public virtual ImportRestApiResponse ImportRestApi(ImportRestApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportRestApiResponseUnmarshaller.Instance;

            return Invoke<ImportRestApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportRestApi">REST API Reference for ImportRestApi Operation</seealso>
        public virtual IAsyncResult BeginImportRestApi(ImportRestApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportRestApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportRestApi.</param>
        /// 
        /// <returns>Returns a  ImportRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportRestApi">REST API Reference for ImportRestApi Operation</seealso>
        public virtual ImportRestApiResponse EndImportRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  PutGatewayResponse

        /// <summary>
        /// Creates a customization of a GatewayResponse of a specified response type and status
        /// code on the given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the PutGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutGatewayResponse">REST API Reference for PutGatewayResponse Operation</seealso>
        public virtual PutGatewayResponseResponse PutGatewayResponse(PutGatewayResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutGatewayResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<PutGatewayResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGatewayResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGatewayResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutGatewayResponse">REST API Reference for PutGatewayResponse Operation</seealso>
        public virtual IAsyncResult BeginPutGatewayResponse(PutGatewayResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutGatewayResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGatewayResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGatewayResponse.</param>
        /// 
        /// <returns>Returns a  PutGatewayResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutGatewayResponse">REST API Reference for PutGatewayResponse Operation</seealso>
        public virtual PutGatewayResponseResponse EndPutGatewayResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<PutGatewayResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  PutIntegration

        /// <summary>
        /// Sets up a method's integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        public virtual PutIntegrationResponse PutIntegration(PutIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        public virtual IAsyncResult BeginPutIntegration(PutIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegration.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        public virtual PutIntegrationResponse EndPutIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutIntegrationResponse

        /// <summary>
        /// Represents a put integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the PutIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegrationResponse">REST API Reference for PutIntegrationResponse Operation</seealso>
        public virtual PutIntegrationResponseResponse PutIntegrationResponse(PutIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegrationResponse">REST API Reference for PutIntegrationResponse Operation</seealso>
        public virtual IAsyncResult BeginPutIntegrationResponse(PutIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegrationResponse">REST API Reference for PutIntegrationResponse Operation</seealso>
        public virtual PutIntegrationResponseResponse EndPutIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<PutIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMethod

        /// <summary>
        /// Add a method to an existing Resource resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMethod service method.</param>
        /// 
        /// <returns>The response from the PutMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethod">REST API Reference for PutMethod Operation</seealso>
        public virtual PutMethodResponse PutMethod(PutMethodRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMethodResponseUnmarshaller.Instance;

            return Invoke<PutMethodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethod">REST API Reference for PutMethod Operation</seealso>
        public virtual IAsyncResult BeginPutMethod(PutMethodRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMethodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMethod.</param>
        /// 
        /// <returns>Returns a  PutMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethod">REST API Reference for PutMethod Operation</seealso>
        public virtual PutMethodResponse EndPutMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMethodResponse

        /// <summary>
        /// Adds a MethodResponse to an existing Method resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse service method.</param>
        /// 
        /// <returns>The response from the PutMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethodResponse">REST API Reference for PutMethodResponse Operation</seealso>
        public virtual PutMethodResponseResponse PutMethodResponse(PutMethodResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMethodResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMethodResponseResponseUnmarshaller.Instance;

            return Invoke<PutMethodResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMethodResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethodResponse">REST API Reference for PutMethodResponse Operation</seealso>
        public virtual IAsyncResult BeginPutMethodResponse(PutMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMethodResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMethodResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMethodResponse.</param>
        /// 
        /// <returns>Returns a  PutMethodResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethodResponse">REST API Reference for PutMethodResponse Operation</seealso>
        public virtual PutMethodResponseResponse EndPutMethodResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMethodResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRestApi

        /// <summary>
        /// A feature of the API Gateway control service for updating an existing API with an
        /// input of external API definitions. The update can take the form of merging the supplied
        /// definition into the existing API or overwriting the existing API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRestApi service method.</param>
        /// 
        /// <returns>The response from the PutRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutRestApi">REST API Reference for PutRestApi Operation</seealso>
        public virtual PutRestApiResponse PutRestApi(PutRestApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRestApiResponseUnmarshaller.Instance;

            return Invoke<PutRestApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutRestApi">REST API Reference for PutRestApi Operation</seealso>
        public virtual IAsyncResult BeginPutRestApi(PutRestApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRestApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRestApi.</param>
        /// 
        /// <returns>Returns a  PutRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutRestApi">REST API Reference for PutRestApi Operation</seealso>
        public virtual PutRestApiResponse EndPutRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectDomainNameAccessAssociation

        /// <summary>
        /// Rejects a domain name access association with a private custom domain name.
        /// 
        ///  
        /// <para>
        /// To reject a domain name access association with an access association source in another
        /// AWS account, use this operation. To remove a domain name access association with an
        /// access association source in your own account, use the DeleteDomainNameAccessAssociation
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectDomainNameAccessAssociation service method.</param>
        /// 
        /// <returns>The response from the RejectDomainNameAccessAssociation service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/RejectDomainNameAccessAssociation">REST API Reference for RejectDomainNameAccessAssociation Operation</seealso>
        public virtual RejectDomainNameAccessAssociationResponse RejectDomainNameAccessAssociation(RejectDomainNameAccessAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectDomainNameAccessAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDomainNameAccessAssociationResponseUnmarshaller.Instance;

            return Invoke<RejectDomainNameAccessAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectDomainNameAccessAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectDomainNameAccessAssociation operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectDomainNameAccessAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/RejectDomainNameAccessAssociation">REST API Reference for RejectDomainNameAccessAssociation Operation</seealso>
        public virtual IAsyncResult BeginRejectDomainNameAccessAssociation(RejectDomainNameAccessAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectDomainNameAccessAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectDomainNameAccessAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectDomainNameAccessAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectDomainNameAccessAssociation.</param>
        /// 
        /// <returns>Returns a  RejectDomainNameAccessAssociationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/RejectDomainNameAccessAssociation">REST API Reference for RejectDomainNameAccessAssociation Operation</seealso>
        public virtual RejectDomainNameAccessAssociationResponse EndRejectDomainNameAccessAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectDomainNameAccessAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds or updates a tag on a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TestInvokeAuthorizer

        /// <summary>
        /// Simulate the execution of an Authorizer in your RestApi with headers, parameters,
        /// and an incoming request body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer service method.</param>
        /// 
        /// <returns>The response from the TestInvokeAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        public virtual TestInvokeAuthorizerResponse TestInvokeAuthorizer(TestInvokeAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return Invoke<TestInvokeAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestInvokeAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginTestInvokeAuthorizer(TestInvokeAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeAuthorizer.</param>
        /// 
        /// <returns>Returns a  TestInvokeAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        public virtual TestInvokeAuthorizerResponse EndTestInvokeAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<TestInvokeAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  TestInvokeMethod

        /// <summary>
        /// Simulate the invocation of a Method in your RestApi with headers, parameters, and
        /// an incoming request body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod service method.</param>
        /// 
        /// <returns>The response from the TestInvokeMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeMethod">REST API Reference for TestInvokeMethod Operation</seealso>
        public virtual TestInvokeMethodResponse TestInvokeMethod(TestInvokeMethodRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestInvokeMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;

            return Invoke<TestInvokeMethodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestInvokeMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeMethod">REST API Reference for TestInvokeMethod Operation</seealso>
        public virtual IAsyncResult BeginTestInvokeMethod(TestInvokeMethodRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TestInvokeMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeMethod.</param>
        /// 
        /// <returns>Returns a  TestInvokeMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeMethod">REST API Reference for TestInvokeMethod Operation</seealso>
        public virtual TestInvokeMethodResponse EndTestInvokeMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<TestInvokeMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccount

        /// <summary>
        /// Changes information about the current Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
        /// 
        /// <returns>The response from the UpdateAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        public virtual UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccount(UpdateAccountRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccount.</param>
        /// 
        /// <returns>Returns a  UpdateAccountResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        public virtual UpdateAccountResponse EndUpdateAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApiKey

        /// <summary>
        /// Changes information about an ApiKey resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey service method.</param>
        /// 
        /// <returns>The response from the UpdateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual IAsyncResult BeginUpdateApiKey(UpdateApiKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApiKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiKey.</param>
        /// 
        /// <returns>Returns a  UpdateApiKeyResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        public virtual UpdateApiKeyResponse EndUpdateApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAuthorizer

        /// <summary>
        /// Updates an existing Authorizer resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual IAsyncResult BeginUpdateAuthorizer(UpdateAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthorizer.</param>
        /// 
        /// <returns>Returns a  UpdateAuthorizerResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        public virtual UpdateAuthorizerResponse EndUpdateAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBasePathMapping

        /// <summary>
        /// Changes information about the BasePathMapping resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateBasePathMapping">REST API Reference for UpdateBasePathMapping Operation</seealso>
        public virtual UpdateBasePathMappingResponse UpdateBasePathMapping(UpdateBasePathMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBasePathMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateBasePathMappingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBasePathMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateBasePathMapping">REST API Reference for UpdateBasePathMapping Operation</seealso>
        public virtual IAsyncResult BeginUpdateBasePathMapping(UpdateBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBasePathMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBasePathMapping.</param>
        /// 
        /// <returns>Returns a  UpdateBasePathMappingResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateBasePathMapping">REST API Reference for UpdateBasePathMapping Operation</seealso>
        public virtual UpdateBasePathMappingResponse EndUpdateBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClientCertificate

        /// <summary>
        /// Changes information about an ClientCertificate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateClientCertificate">REST API Reference for UpdateClientCertificate Operation</seealso>
        public virtual UpdateClientCertificateResponse UpdateClientCertificate(UpdateClientCertificateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateClientCertificateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateClientCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateClientCertificate">REST API Reference for UpdateClientCertificate Operation</seealso>
        public virtual IAsyncResult BeginUpdateClientCertificate(UpdateClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClientCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClientCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateClientCertificateResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateClientCertificate">REST API Reference for UpdateClientCertificate Operation</seealso>
        public virtual UpdateClientCertificateResponse EndUpdateClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDeployment

        /// <summary>
        /// Changes information about a Deployment resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual IAsyncResult BeginUpdateDeployment(UpdateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeployment.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        public virtual UpdateDeploymentResponse EndUpdateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDocumentationPart

        /// <summary>
        /// Updates a documentation part.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationPart">REST API Reference for UpdateDocumentationPart Operation</seealso>
        public virtual UpdateDocumentationPartResponse UpdateDocumentationPart(UpdateDocumentationPartRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDocumentationPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentationPartResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationPart operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocumentationPart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationPart">REST API Reference for UpdateDocumentationPart Operation</seealso>
        public virtual IAsyncResult BeginUpdateDocumentationPart(UpdateDocumentationPartRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDocumentationPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentationPartResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentationPart.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentationPartResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationPart">REST API Reference for UpdateDocumentationPart Operation</seealso>
        public virtual UpdateDocumentationPartResponse EndUpdateDocumentationPart(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentationPartResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDocumentationVersion

        /// <summary>
        /// Updates a documentation version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationVersion">REST API Reference for UpdateDocumentationVersion Operation</seealso>
        public virtual UpdateDocumentationVersionResponse UpdateDocumentationVersion(UpdateDocumentationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDocumentationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentationVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationVersion operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDocumentationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationVersion">REST API Reference for UpdateDocumentationVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateDocumentationVersion(UpdateDocumentationVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDocumentationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDocumentationVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentationVersionResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationVersion">REST API Reference for UpdateDocumentationVersion Operation</seealso>
        public virtual UpdateDocumentationVersionResponse EndUpdateDocumentationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomainName

        /// <summary>
        /// Changes information about the DomainName resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainName.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        public virtual UpdateDomainNameResponse EndUpdateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGatewayResponse

        /// <summary>
        /// Updates a GatewayResponse of a specified response type on the given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateGatewayResponse">REST API Reference for UpdateGatewayResponse Operation</seealso>
        public virtual UpdateGatewayResponseResponse UpdateGatewayResponse(UpdateGatewayResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGatewayResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateGatewayResponse">REST API Reference for UpdateGatewayResponse Operation</seealso>
        public virtual IAsyncResult BeginUpdateGatewayResponse(UpdateGatewayResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayResponse.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateGatewayResponse">REST API Reference for UpdateGatewayResponse Operation</seealso>
        public virtual UpdateGatewayResponseResponse EndUpdateGatewayResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGatewayResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIntegration

        /// <summary>
        /// Represents an update integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntegration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual IAsyncResult BeginUpdateIntegration(UpdateIntegrationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        public virtual UpdateIntegrationResponse EndUpdateIntegration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIntegrationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateIntegrationResponse

        /// <summary>
        /// Represents an update integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        public virtual UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIntegrationResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        public virtual IAsyncResult BeginUpdateIntegrationResponse(UpdateIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        public virtual UpdateIntegrationResponseResponse EndUpdateIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMethod

        /// <summary>
        /// Updates an existing Method resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod service method.</param>
        /// 
        /// <returns>The response from the UpdateMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethod">REST API Reference for UpdateMethod Operation</seealso>
        public virtual UpdateMethodResponse UpdateMethod(UpdateMethodRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMethodResponseUnmarshaller.Instance;

            return Invoke<UpdateMethodResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMethod
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethod">REST API Reference for UpdateMethod Operation</seealso>
        public virtual IAsyncResult BeginUpdateMethod(UpdateMethodRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMethodRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMethodResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMethod.</param>
        /// 
        /// <returns>Returns a  UpdateMethodResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethod">REST API Reference for UpdateMethod Operation</seealso>
        public virtual UpdateMethodResponse EndUpdateMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMethodResponse

        /// <summary>
        /// Updates an existing MethodResponse resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethodResponse">REST API Reference for UpdateMethodResponse Operation</seealso>
        public virtual UpdateMethodResponseResponse UpdateMethodResponse(UpdateMethodResponseRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMethodResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateMethodResponseResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMethodResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethodResponse">REST API Reference for UpdateMethodResponse Operation</seealso>
        public virtual IAsyncResult BeginUpdateMethodResponse(UpdateMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMethodResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMethodResponse.</param>
        /// 
        /// <returns>Returns a  UpdateMethodResponseResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethodResponse">REST API Reference for UpdateMethodResponse Operation</seealso>
        public virtual UpdateMethodResponseResponse EndUpdateMethodResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMethodResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateModel

        /// <summary>
        /// Changes information about a model. The maximum size of the model is 400 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        public virtual UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRequestValidator

        /// <summary>
        /// Updates a RequestValidator of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequestValidator service method.</param>
        /// 
        /// <returns>The response from the UpdateRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRequestValidator">REST API Reference for UpdateRequestValidator Operation</seealso>
        public virtual UpdateRequestValidatorResponse UpdateRequestValidator(UpdateRequestValidatorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRequestValidatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<UpdateRequestValidatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequestValidator operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRequestValidator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRequestValidator">REST API Reference for UpdateRequestValidator Operation</seealso>
        public virtual IAsyncResult BeginUpdateRequestValidator(UpdateRequestValidatorRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRequestValidatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRequestValidatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRequestValidator.</param>
        /// 
        /// <returns>Returns a  UpdateRequestValidatorResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRequestValidator">REST API Reference for UpdateRequestValidator Operation</seealso>
        public virtual UpdateRequestValidatorResponse EndUpdateRequestValidator(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRequestValidatorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResource

        /// <summary>
        /// Changes information about a Resource resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        public virtual UpdateResourceResponse EndUpdateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRestApi

        /// <summary>
        /// Changes information about the specified API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi service method.</param>
        /// 
        /// <returns>The response from the UpdateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRestApi">REST API Reference for UpdateRestApi Operation</seealso>
        public virtual UpdateRestApiResponse UpdateRestApi(UpdateRestApiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestApiResponseUnmarshaller.Instance;

            return Invoke<UpdateRestApiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRestApi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRestApi">REST API Reference for UpdateRestApi Operation</seealso>
        public virtual IAsyncResult BeginUpdateRestApi(UpdateRestApiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRestApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRestApiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRestApi.</param>
        /// 
        /// <returns>Returns a  UpdateRestApiResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRestApi">REST API Reference for UpdateRestApi Operation</seealso>
        public virtual UpdateRestApiResponse EndUpdateRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStage

        /// <summary>
        /// Changes information about a Stage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        public virtual UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUsage

        /// <summary>
        /// Grants a temporary extension to the remaining quota of a usage plan associated with
        /// a specified API key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsage service method.</param>
        /// 
        /// <returns>The response from the UpdateUsage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsage">REST API Reference for UpdateUsage Operation</seealso>
        public virtual UpdateUsageResponse UpdateUsage(UpdateUsageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsageResponseUnmarshaller.Instance;

            return Invoke<UpdateUsageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsage operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsage">REST API Reference for UpdateUsage Operation</seealso>
        public virtual IAsyncResult BeginUpdateUsage(UpdateUsageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsage.</param>
        /// 
        /// <returns>Returns a  UpdateUsageResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsage">REST API Reference for UpdateUsage Operation</seealso>
        public virtual UpdateUsageResponse EndUpdateUsage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUsageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUsagePlan

        /// <summary>
        /// Updates a usage plan of a given plan Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsagePlan service method.</param>
        /// 
        /// <returns>The response from the UpdateUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsagePlan">REST API Reference for UpdateUsagePlan Operation</seealso>
        public virtual UpdateUsagePlanResponse UpdateUsagePlan(UpdateUsagePlanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUsagePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsagePlanResponseUnmarshaller.Instance;

            return Invoke<UpdateUsagePlanResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsagePlan operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUsagePlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsagePlan">REST API Reference for UpdateUsagePlan Operation</seealso>
        public virtual IAsyncResult BeginUpdateUsagePlan(UpdateUsagePlanRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUsagePlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsagePlanResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsagePlan.</param>
        /// 
        /// <returns>Returns a  UpdateUsagePlanResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsagePlan">REST API Reference for UpdateUsagePlan Operation</seealso>
        public virtual UpdateUsagePlanResponse EndUpdateUsagePlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUsagePlanResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVpcLink

        /// <summary>
        /// Updates an existing VpcLink of a specified identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// 
        /// <returns>The response from the UpdateVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        public virtual UpdateVpcLinkResponse UpdateVpcLink(UpdateVpcLinkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink operation on AmazonAPIGatewayClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        public virtual IAsyncResult BeginUpdateVpcLink(UpdateVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcLink.</param>
        /// 
        /// <returns>Returns a  UpdateVpcLinkResult from APIGateway.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        public virtual UpdateVpcLinkResponse EndUpdateVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVpcLinkResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonAPIGatewayEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}