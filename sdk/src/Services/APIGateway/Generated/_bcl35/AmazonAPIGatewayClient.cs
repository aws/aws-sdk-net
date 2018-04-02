/*
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

/*
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.APIGateway.Model;
using Amazon.APIGateway.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.APIGateway
{
    /// <summary>
    /// Implementation for accessing APIGateway
    ///
    /// Amazon API Gateway 
    /// <para>
    /// Amazon API Gateway helps developers deliver robust, secure, and scalable mobile and
    /// web application back ends. API Gateway allows developers to securely connect mobile
    /// and web applications to APIs that run on AWS Lambda, Amazon EC2, or other publicly
    /// addressable web services that are hosted outside of AWS.
    /// </para>
    /// </summary>
    public partial class AmazonAPIGatewayClient : AmazonServiceClient, IAmazonAPIGateway
    {
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Create an <a>ApiKey</a> resource. 
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/create-api-key.html">AWS
        /// CLI</a></div>
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
        public virtual CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            var marshaller = CreateApiKeyRequestMarshaller.Instance;
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyRequest,CreateApiKeyResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateApiKey(CreateApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateApiKeyRequestMarshaller.Instance;
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke<CreateApiKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApiKey.</param>
        /// 
        /// <returns>Returns a  CreateApiKeyResult from APIGateway.</returns>
        public virtual CreateApiKeyResponse EndCreateApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAuthorizer

        /// <summary>
        /// Adds a new <a>Authorizer</a> resource to an existing <a>RestApi</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/create-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
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
        public virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var marshaller = CreateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerRequest,CreateAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateAuthorizer(CreateAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<CreateAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthorizer.</param>
        /// 
        /// <returns>Returns a  CreateAuthorizerResult from APIGateway.</returns>
        public virtual CreateAuthorizerResponse EndCreateAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateBasePathMapping

        /// <summary>
        /// Creates a new <a>BasePathMapping</a> resource.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual CreateBasePathMappingResponse CreateBasePathMapping(CreateBasePathMappingRequest request)
        {
            var marshaller = CreateBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<CreateBasePathMappingRequest,CreateBasePathMappingResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateBasePathMapping(CreateBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;

            return BeginInvoke<CreateBasePathMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBasePathMapping.</param>
        /// 
        /// <returns>Returns a  CreateBasePathMappingResult from APIGateway.</returns>
        public virtual CreateBasePathMappingResponse EndCreateBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDeployment

        /// <summary>
        /// Creates a <a>Deployment</a> resource, which makes a specified <a>RestApi</a> callable
        /// over the internet.
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
        public virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeployment.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentResult from APIGateway.</returns>
        public virtual CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDocumentationPart

        /// <summary>
        /// 
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
        public virtual CreateDocumentationPartResponse CreateDocumentationPart(CreateDocumentationPartRequest request)
        {
            var marshaller = CreateDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = CreateDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentationPartRequest,CreateDocumentationPartResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateDocumentationPart(CreateDocumentationPartRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = CreateDocumentationPartResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDocumentationPartRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocumentationPart.</param>
        /// 
        /// <returns>Returns a  CreateDocumentationPartResult from APIGateway.</returns>
        public virtual CreateDocumentationPartResponse EndCreateDocumentationPart(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDocumentationPartResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDocumentationVersion

        /// <summary>
        /// 
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
        public virtual CreateDocumentationVersionResponse CreateDocumentationVersion(CreateDocumentationVersionRequest request)
        {
            var marshaller = CreateDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentationVersionRequest,CreateDocumentationVersionResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateDocumentationVersion(CreateDocumentationVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateDocumentationVersionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDocumentationVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  CreateDocumentationVersionResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var marshaller = CreateDomainNameRequestMarshaller.Instance;
            var unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameRequest,CreateDomainNameResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateDomainNameRequestMarshaller.Instance;
            var unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDomainNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainName.</param>
        /// 
        /// <returns>Returns a  CreateDomainNameResult from APIGateway.</returns>
        public virtual CreateDomainNameResponse EndCreateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateModel

        /// <summary>
        /// Adds a new <a>Model</a> resource to an existing <a>RestApi</a> resource.
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
        public virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var marshaller = CreateModelRequestMarshaller.Instance;
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelRequest,CreateModelResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateModelRequestMarshaller.Instance;
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return BeginInvoke<CreateModelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from APIGateway.</returns>
        public virtual CreateModelResponse EndCreateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRequestValidator

        /// <summary>
        /// Creates a <a>ReqeustValidator</a> of a given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequestValidator service method.</param>
        /// 
        /// <returns>The response from the CreateRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
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
        public virtual CreateRequestValidatorResponse CreateRequestValidator(CreateRequestValidatorRequest request)
        {
            var marshaller = CreateRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = CreateRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<CreateRequestValidatorRequest,CreateRequestValidatorResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateRequestValidator(CreateRequestValidatorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = CreateRequestValidatorResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRequestValidatorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRequestValidator.</param>
        /// 
        /// <returns>Returns a  CreateRequestValidatorResult from APIGateway.</returns>
        public virtual CreateRequestValidatorResponse EndCreateRequestValidator(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRequestValidatorResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateResource

        /// <summary>
        /// Creates a <a>Resource</a> resource.
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
        public virtual CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var marshaller = CreateResourceRequestMarshaller.Instance;
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceRequest,CreateResourceResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateResource(CreateResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateResourceRequestMarshaller.Instance;
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return BeginInvoke<CreateResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResource.</param>
        /// 
        /// <returns>Returns a  CreateResourceResult from APIGateway.</returns>
        public virtual CreateResourceResponse EndCreateResource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRestApi

        /// <summary>
        /// Creates a new <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi service method.</param>
        /// 
        /// <returns>The response from the CreateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
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
        public virtual CreateRestApiResponse CreateRestApi(CreateRestApiRequest request)
        {
            var marshaller = CreateRestApiRequestMarshaller.Instance;
            var unmarshaller = CreateRestApiResponseUnmarshaller.Instance;

            return Invoke<CreateRestApiRequest,CreateRestApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateRestApi(CreateRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateRestApiRequestMarshaller.Instance;
            var unmarshaller = CreateRestApiResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRestApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRestApi.</param>
        /// 
        /// <returns>Returns a  CreateRestApiResult from APIGateway.</returns>
        public virtual CreateRestApiResponse EndCreateRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStage

        /// <summary>
        /// Creates a new <a>Stage</a> resource that references a pre-existing <a>Deployment</a>
        /// for the API.
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
        public virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var marshaller = CreateStageRequestMarshaller.Instance;
            var unmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageRequest,CreateStageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateStageRequestMarshaller.Instance;
            var unmarshaller = CreateStageResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStage.</param>
        /// 
        /// <returns>Returns a  CreateStageResult from APIGateway.</returns>
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
        public virtual CreateUsagePlanResponse CreateUsagePlan(CreateUsagePlanRequest request)
        {
            var marshaller = CreateUsagePlanRequestMarshaller.Instance;
            var unmarshaller = CreateUsagePlanResponseUnmarshaller.Instance;

            return Invoke<CreateUsagePlanRequest,CreateUsagePlanResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateUsagePlan(CreateUsagePlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateUsagePlanRequestMarshaller.Instance;
            var unmarshaller = CreateUsagePlanResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUsagePlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsagePlan.</param>
        /// 
        /// <returns>Returns a  CreateUsagePlanResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual CreateUsagePlanKeyResponse CreateUsagePlanKey(CreateUsagePlanKeyRequest request)
        {
            var marshaller = CreateUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = CreateUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<CreateUsagePlanKeyRequest,CreateUsagePlanKeyResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateUsagePlanKey(CreateUsagePlanKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = CreateUsagePlanKeyResponseUnmarshaller.Instance;

            return BeginInvoke<CreateUsagePlanKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  CreateUsagePlanKeyResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual CreateVpcLinkResponse CreateVpcLink(CreateVpcLinkRequest request)
        {
            var marshaller = CreateVpcLinkRequestMarshaller.Instance;
            var unmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<CreateVpcLinkRequest,CreateVpcLinkResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginCreateVpcLink(CreateVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateVpcLinkRequestMarshaller.Instance;
            var unmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVpcLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcLink.</param>
        /// 
        /// <returns>Returns a  CreateVpcLinkResult from APIGateway.</returns>
        public virtual CreateVpcLinkResponse EndCreateVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApiKey

        /// <summary>
        /// Deletes the <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey service method.</param>
        /// 
        /// <returns>The response from the DeleteApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var marshaller = DeleteApiKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyRequest,DeleteApiKeyResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteApiKey(DeleteApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteApiKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteApiKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApiKey.</param>
        /// 
        /// <returns>Returns a  DeleteApiKeyResult from APIGateway.</returns>
        public virtual DeleteApiKeyResponse EndDeleteApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAuthorizer

        /// <summary>
        /// Deletes an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/delete-authorizer.html">AWS
        /// CLI</a></div>
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
        public virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var marshaller = DeleteAuthorizerRequestMarshaller.Instance;
            var unmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerRequest,DeleteAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteAuthorizer(DeleteAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteAuthorizerRequestMarshaller.Instance;
            var unmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthorizer.</param>
        /// 
        /// <returns>Returns a  DeleteAuthorizerResult from APIGateway.</returns>
        public virtual DeleteAuthorizerResponse EndDeleteAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBasePathMapping

        /// <summary>
        /// Deletes the <a>BasePathMapping</a> resource.
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
        public virtual DeleteBasePathMappingResponse DeleteBasePathMapping(DeleteBasePathMappingRequest request)
        {
            var marshaller = DeleteBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = DeleteBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteBasePathMappingRequest,DeleteBasePathMappingResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteBasePathMapping(DeleteBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = DeleteBasePathMappingResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteBasePathMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBasePathMapping.</param>
        /// 
        /// <returns>Returns a  DeleteBasePathMappingResult from APIGateway.</returns>
        public virtual DeleteBasePathMappingResponse EndDeleteBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClientCertificate

        /// <summary>
        /// Deletes the <a>ClientCertificate</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteClientCertificate service method, as returned by APIGateway.</returns>
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
        public virtual DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request)
        {
            var marshaller = DeleteClientCertificateRequestMarshaller.Instance;
            var unmarshaller = DeleteClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteClientCertificateRequest,DeleteClientCertificateResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteClientCertificate(DeleteClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteClientCertificateRequestMarshaller.Instance;
            var unmarshaller = DeleteClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteClientCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteClientCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteClientCertificateResult from APIGateway.</returns>
        public virtual DeleteClientCertificateResponse EndDeleteClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeployment

        /// <summary>
        /// Deletes a <a>Deployment</a> resource. Deleting a deployment will only succeed if there
        /// are no <a>Stage</a> resources associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by APIGateway.</returns>
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
        public virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var marshaller = DeleteDeploymentRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentRequest,DeleteDeploymentResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDeploymentRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeployment.</param>
        /// 
        /// <returns>Returns a  DeleteDeploymentResult from APIGateway.</returns>
        public virtual DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDocumentationPart

        /// <summary>
        /// 
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
        public virtual DeleteDocumentationPartResponse DeleteDocumentationPart(DeleteDocumentationPartRequest request)
        {
            var marshaller = DeleteDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentationPartRequest,DeleteDocumentationPartResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteDocumentationPart(DeleteDocumentationPartRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentationPartResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDocumentationPartRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentationPart.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentationPartResult from APIGateway.</returns>
        public virtual DeleteDocumentationPartResponse EndDeleteDocumentationPart(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDocumentationPartResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDocumentationVersion

        /// <summary>
        /// 
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
        public virtual DeleteDocumentationVersionResponse DeleteDocumentationVersion(DeleteDocumentationVersionRequest request)
        {
            var marshaller = DeleteDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentationVersionRequest,DeleteDocumentationVersionResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteDocumentationVersion(DeleteDocumentationVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentationVersionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDocumentationVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentationVersionResult from APIGateway.</returns>
        public virtual DeleteDocumentationVersionResponse EndDeleteDocumentationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDocumentationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomainName

        /// <summary>
        /// Deletes the <a>DomainName</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var marshaller = DeleteDomainNameRequestMarshaller.Instance;
            var unmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameRequest,DeleteDomainNameResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteDomainNameRequestMarshaller.Instance;
            var unmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDomainNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainName.</param>
        /// 
        /// <returns>Returns a  DeleteDomainNameResult from APIGateway.</returns>
        public virtual DeleteDomainNameResponse EndDeleteDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGatewayResponse

        /// <summary>
        /// Clears any customization of a <a>GatewayResponse</a> of a specified response type
        /// on the given <a>RestApi</a> and resets it with the default settings.
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
        public virtual DeleteGatewayResponseResponse DeleteGatewayResponse(DeleteGatewayResponseRequest request)
        {
            var marshaller = DeleteGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponseRequest,DeleteGatewayResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteGatewayResponse(DeleteGatewayResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteGatewayResponseResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteGatewayResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGatewayResponse.</param>
        /// 
        /// <returns>Returns a  DeleteGatewayResponseResult from APIGateway.</returns>
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
        public virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var marshaller = DeleteIntegrationRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationRequest,DeleteIntegrationResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIntegrationRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIntegrationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegration.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResult from APIGateway.</returns>
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
        public virtual DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var marshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseRequest,DeleteIntegrationResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteIntegrationResponse(DeleteIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteIntegrationResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  DeleteIntegrationResponseResult from APIGateway.</returns>
        public virtual DeleteIntegrationResponseResponse EndDeleteIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMethod

        /// <summary>
        /// Deletes an existing <a>Method</a> resource.
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
        public virtual DeleteMethodResponse DeleteMethod(DeleteMethodRequest request)
        {
            var marshaller = DeleteMethodRequestMarshaller.Instance;
            var unmarshaller = DeleteMethodResponseUnmarshaller.Instance;

            return Invoke<DeleteMethodRequest,DeleteMethodResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteMethod(DeleteMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteMethodRequestMarshaller.Instance;
            var unmarshaller = DeleteMethodResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteMethodRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMethod.</param>
        /// 
        /// <returns>Returns a  DeleteMethodResult from APIGateway.</returns>
        public virtual DeleteMethodResponse EndDeleteMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMethodResponse

        /// <summary>
        /// Deletes an existing <a>MethodResponse</a> resource.
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
        public virtual DeleteMethodResponseResponse DeleteMethodResponse(DeleteMethodResponseRequest request)
        {
            var marshaller = DeleteMethodResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteMethodResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteMethodResponseRequest,DeleteMethodResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteMethodResponse(DeleteMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteMethodResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteMethodResponseResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteMethodResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMethodResponse.</param>
        /// 
        /// <returns>Returns a  DeleteMethodResponseResult from APIGateway.</returns>
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
        public virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var marshaller = DeleteModelRequestMarshaller.Instance;
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelRequest,DeleteModelResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteModelRequestMarshaller.Instance;
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteModelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from APIGateway.</returns>
        public virtual DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRequestValidator

        /// <summary>
        /// Deletes a <a>RequestValidator</a> of a given <a>RestApi</a>.
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
        public virtual DeleteRequestValidatorResponse DeleteRequestValidator(DeleteRequestValidatorRequest request)
        {
            var marshaller = DeleteRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = DeleteRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<DeleteRequestValidatorRequest,DeleteRequestValidatorResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteRequestValidator(DeleteRequestValidatorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = DeleteRequestValidatorResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRequestValidatorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRequestValidator.</param>
        /// 
        /// <returns>Returns a  DeleteRequestValidatorResult from APIGateway.</returns>
        public virtual DeleteRequestValidatorResponse EndDeleteRequestValidator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRequestValidatorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResource

        /// <summary>
        /// Deletes a <a>Resource</a> resource.
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
        public virtual DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var marshaller = DeleteResourceRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceRequest,DeleteResourceResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteResource(DeleteResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteResourceRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResource.</param>
        /// 
        /// <returns>Returns a  DeleteResourceResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual DeleteRestApiResponse DeleteRestApi(DeleteRestApiRequest request)
        {
            var marshaller = DeleteRestApiRequestMarshaller.Instance;
            var unmarshaller = DeleteRestApiResponseUnmarshaller.Instance;

            return Invoke<DeleteRestApiRequest,DeleteRestApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteRestApi(DeleteRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteRestApiRequestMarshaller.Instance;
            var unmarshaller = DeleteRestApiResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRestApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRestApi.</param>
        /// 
        /// <returns>Returns a  DeleteRestApiResult from APIGateway.</returns>
        public virtual DeleteRestApiResponse EndDeleteRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStage

        /// <summary>
        /// Deletes a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by APIGateway.</returns>
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
        public virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var marshaller = DeleteStageRequestMarshaller.Instance;
            var unmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageRequest,DeleteStageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteStageRequestMarshaller.Instance;
            var unmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteStageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStage.</param>
        /// 
        /// <returns>Returns a  DeleteStageResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual DeleteUsagePlanResponse DeleteUsagePlan(DeleteUsagePlanRequest request)
        {
            var marshaller = DeleteUsagePlanRequestMarshaller.Instance;
            var unmarshaller = DeleteUsagePlanResponseUnmarshaller.Instance;

            return Invoke<DeleteUsagePlanRequest,DeleteUsagePlanResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteUsagePlan(DeleteUsagePlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteUsagePlanRequestMarshaller.Instance;
            var unmarshaller = DeleteUsagePlanResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUsagePlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsagePlan.</param>
        /// 
        /// <returns>Returns a  DeleteUsagePlanResult from APIGateway.</returns>
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
        public virtual DeleteUsagePlanKeyResponse DeleteUsagePlanKey(DeleteUsagePlanKeyRequest request)
        {
            var marshaller = DeleteUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteUsagePlanKeyRequest,DeleteUsagePlanKeyResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteUsagePlanKey(DeleteUsagePlanKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteUsagePlanKeyResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteUsagePlanKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  DeleteUsagePlanKeyResult from APIGateway.</returns>
        public virtual DeleteUsagePlanKeyResponse EndDeleteUsagePlanKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUsagePlanKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcLink

        /// <summary>
        /// Deletes an existing <a>VpcLink</a> of a specified identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcLink service method, as returned by APIGateway.</returns>
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
        public virtual DeleteVpcLinkResponse DeleteVpcLink(DeleteVpcLinkRequest request)
        {
            var marshaller = DeleteVpcLinkRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcLinkRequest,DeleteVpcLinkResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginDeleteVpcLink(DeleteVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteVpcLinkRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVpcLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcLink.</param>
        /// 
        /// <returns>Returns a  DeleteVpcLinkResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual FlushStageAuthorizersCacheResponse FlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request)
        {
            var marshaller = FlushStageAuthorizersCacheRequestMarshaller.Instance;
            var unmarshaller = FlushStageAuthorizersCacheResponseUnmarshaller.Instance;

            return Invoke<FlushStageAuthorizersCacheRequest,FlushStageAuthorizersCacheResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginFlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request, AsyncCallback callback, object state)
        {
            var marshaller = FlushStageAuthorizersCacheRequestMarshaller.Instance;
            var unmarshaller = FlushStageAuthorizersCacheResponseUnmarshaller.Instance;

            return BeginInvoke<FlushStageAuthorizersCacheRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlushStageAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushStageAuthorizersCache.</param>
        /// 
        /// <returns>Returns a  FlushStageAuthorizersCacheResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual FlushStageCacheResponse FlushStageCache(FlushStageCacheRequest request)
        {
            var marshaller = FlushStageCacheRequestMarshaller.Instance;
            var unmarshaller = FlushStageCacheResponseUnmarshaller.Instance;

            return Invoke<FlushStageCacheRequest,FlushStageCacheResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginFlushStageCache(FlushStageCacheRequest request, AsyncCallback callback, object state)
        {
            var marshaller = FlushStageCacheRequestMarshaller.Instance;
            var unmarshaller = FlushStageCacheResponseUnmarshaller.Instance;

            return BeginInvoke<FlushStageCacheRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlushStageCache.</param>
        /// 
        /// <returns>Returns a  FlushStageCacheResult from APIGateway.</returns>
        public virtual FlushStageCacheResponse EndFlushStageCache(IAsyncResult asyncResult)
        {
            return EndInvoke<FlushStageCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateClientCertificate

        /// <summary>
        /// Generates a <a>ClientCertificate</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GenerateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request)
        {
            var marshaller = GenerateClientCertificateRequestMarshaller.Instance;
            var unmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;

            return Invoke<GenerateClientCertificateRequest,GenerateClientCertificateResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGenerateClientCertificate(GenerateClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GenerateClientCertificateRequestMarshaller.Instance;
            var unmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<GenerateClientCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateClientCertificate.</param>
        /// 
        /// <returns>Returns a  GenerateClientCertificateResult from APIGateway.</returns>
        public virtual GenerateClientCertificateResponse EndGenerateClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GenerateClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccount

        /// <summary>
        /// Gets information about the current <a>Account</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var marshaller = GetAccountRequestMarshaller.Instance;
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountRequest,GetAccountResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetAccountRequestMarshaller.Instance;
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return BeginInvoke<GetAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccount.</param>
        /// 
        /// <returns>Returns a  GetAccountResult from APIGateway.</returns>
        public virtual GetAccountResponse EndGetAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiKey

        /// <summary>
        /// Gets information about the current <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey service method.</param>
        /// 
        /// <returns>The response from the GetApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetApiKeyResponse GetApiKey(GetApiKeyRequest request)
        {
            var marshaller = GetApiKeyRequestMarshaller.Instance;
            var unmarshaller = GetApiKeyResponseUnmarshaller.Instance;

            return Invoke<GetApiKeyRequest,GetApiKeyResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetApiKey(GetApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetApiKeyRequestMarshaller.Instance;
            var unmarshaller = GetApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke<GetApiKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKey.</param>
        /// 
        /// <returns>Returns a  GetApiKeyResult from APIGateway.</returns>
        public virtual GetApiKeyResponse EndGetApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApiKeys

        /// <summary>
        /// Gets information about the current <a>ApiKeys</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys service method.</param>
        /// 
        /// <returns>The response from the GetApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetApiKeysResponse GetApiKeys(GetApiKeysRequest request)
        {
            var marshaller = GetApiKeysRequestMarshaller.Instance;
            var unmarshaller = GetApiKeysResponseUnmarshaller.Instance;

            return Invoke<GetApiKeysRequest,GetApiKeysResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetApiKeys(GetApiKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetApiKeysRequestMarshaller.Instance;
            var unmarshaller = GetApiKeysResponseUnmarshaller.Instance;

            return BeginInvoke<GetApiKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApiKeys.</param>
        /// 
        /// <returns>Returns a  GetApiKeysResult from APIGateway.</returns>
        public virtual GetApiKeysResponse EndGetApiKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAuthorizer

        /// <summary>
        /// Describe an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/get-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request)
        {
            var marshaller = GetAuthorizerRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerRequest,GetAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetAuthorizer(GetAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetAuthorizerRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<GetAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizer.</param>
        /// 
        /// <returns>Returns a  GetAuthorizerResult from APIGateway.</returns>
        public virtual GetAuthorizerResponse EndGetAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAuthorizers

        /// <summary>
        /// Describe an existing <a>Authorizers</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/get-authorizers.html">AWS
        /// CLI</a></div>
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
        public virtual GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request)
        {
            var marshaller = GetAuthorizersRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersRequest,GetAuthorizersResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetAuthorizers(GetAuthorizersRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetAuthorizersRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return BeginInvoke<GetAuthorizersRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAuthorizers.</param>
        /// 
        /// <returns>Returns a  GetAuthorizersResult from APIGateway.</returns>
        public virtual GetAuthorizersResponse EndGetAuthorizers(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAuthorizersResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBasePathMapping

        /// <summary>
        /// Describe a <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the GetBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetBasePathMappingResponse GetBasePathMapping(GetBasePathMappingRequest request)
        {
            var marshaller = GetBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<GetBasePathMappingRequest,GetBasePathMappingResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetBasePathMapping(GetBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;

            return BeginInvoke<GetBasePathMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBasePathMapping.</param>
        /// 
        /// <returns>Returns a  GetBasePathMappingResult from APIGateway.</returns>
        public virtual GetBasePathMappingResponse EndGetBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBasePathMappings

        /// <summary>
        /// Represents a collection of <a>BasePathMapping</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings service method.</param>
        /// 
        /// <returns>The response from the GetBasePathMappings service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetBasePathMappingsResponse GetBasePathMappings(GetBasePathMappingsRequest request)
        {
            var marshaller = GetBasePathMappingsRequestMarshaller.Instance;
            var unmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;

            return Invoke<GetBasePathMappingsRequest,GetBasePathMappingsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetBasePathMappings(GetBasePathMappingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetBasePathMappingsRequestMarshaller.Instance;
            var unmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;

            return BeginInvoke<GetBasePathMappingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBasePathMappings.</param>
        /// 
        /// <returns>Returns a  GetBasePathMappingsResult from APIGateway.</returns>
        public virtual GetBasePathMappingsResponse EndGetBasePathMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBasePathMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClientCertificate

        /// <summary>
        /// Gets information about the current <a>ClientCertificate</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetClientCertificateResponse GetClientCertificate(GetClientCertificateRequest request)
        {
            var marshaller = GetClientCertificateRequestMarshaller.Instance;
            var unmarshaller = GetClientCertificateResponseUnmarshaller.Instance;

            return Invoke<GetClientCertificateRequest,GetClientCertificateResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetClientCertificate(GetClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetClientCertificateRequestMarshaller.Instance;
            var unmarshaller = GetClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<GetClientCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClientCertificate.</param>
        /// 
        /// <returns>Returns a  GetClientCertificateResult from APIGateway.</returns>
        public virtual GetClientCertificateResponse EndGetClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClientCertificates

        /// <summary>
        /// Gets a collection of <a>ClientCertificate</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificates service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetClientCertificatesResponse GetClientCertificates(GetClientCertificatesRequest request)
        {
            var marshaller = GetClientCertificatesRequestMarshaller.Instance;
            var unmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<GetClientCertificatesRequest,GetClientCertificatesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetClientCertificates(GetClientCertificatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetClientCertificatesRequestMarshaller.Instance;
            var unmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke<GetClientCertificatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetClientCertificates.</param>
        /// 
        /// <returns>Returns a  GetClientCertificatesResult from APIGateway.</returns>
        public virtual GetClientCertificatesResponse EndGetClientCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClientCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployment

        /// <summary>
        /// Gets information about a <a>Deployment</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by APIGateway.</returns>
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
        public virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var marshaller = GetDeploymentRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDeploymentRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployment.</param>
        /// 
        /// <returns>Returns a  GetDeploymentResult from APIGateway.</returns>
        public virtual GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDeployments

        /// <summary>
        /// Gets information about a <a>Deployments</a> collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
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
        public virtual GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var marshaller = GetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsRequest,GetDeploymentsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDeployments(GetDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return BeginInvoke<GetDeploymentsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeployments.</param>
        /// 
        /// <returns>Returns a  GetDeploymentsResult from APIGateway.</returns>
        public virtual GetDeploymentsResponse EndGetDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentationPart

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationPart service method.</param>
        /// 
        /// <returns>The response from the GetDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetDocumentationPartResponse GetDocumentationPart(GetDocumentationPartRequest request)
        {
            var marshaller = GetDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationPartRequest,GetDocumentationPartResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDocumentationPart(GetDocumentationPartRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationPartResponseUnmarshaller.Instance;

            return BeginInvoke<GetDocumentationPartRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationPart.</param>
        /// 
        /// <returns>Returns a  GetDocumentationPartResult from APIGateway.</returns>
        public virtual GetDocumentationPartResponse EndGetDocumentationPart(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentationPartResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentationParts

        /// <summary>
        /// 
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
        public virtual GetDocumentationPartsResponse GetDocumentationParts(GetDocumentationPartsRequest request)
        {
            var marshaller = GetDocumentationPartsRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationPartsResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationPartsRequest,GetDocumentationPartsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDocumentationParts(GetDocumentationPartsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDocumentationPartsRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationPartsResponseUnmarshaller.Instance;

            return BeginInvoke<GetDocumentationPartsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationParts.</param>
        /// 
        /// <returns>Returns a  GetDocumentationPartsResult from APIGateway.</returns>
        public virtual GetDocumentationPartsResponse EndGetDocumentationParts(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentationPartsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentationVersion

        /// <summary>
        /// 
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
        public virtual GetDocumentationVersionResponse GetDocumentationVersion(GetDocumentationVersionRequest request)
        {
            var marshaller = GetDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationVersionRequest,GetDocumentationVersionResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDocumentationVersion(GetDocumentationVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationVersionResponseUnmarshaller.Instance;

            return BeginInvoke<GetDocumentationVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  GetDocumentationVersionResult from APIGateway.</returns>
        public virtual GetDocumentationVersionResponse EndGetDocumentationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDocumentationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDocumentationVersions

        /// <summary>
        /// 
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
        public virtual GetDocumentationVersionsResponse GetDocumentationVersions(GetDocumentationVersionsRequest request)
        {
            var marshaller = GetDocumentationVersionsRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationVersionsResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationVersionsRequest,GetDocumentationVersionsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDocumentationVersions(GetDocumentationVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDocumentationVersionsRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetDocumentationVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentationVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentationVersions.</param>
        /// 
        /// <returns>Returns a  GetDocumentationVersionsResult from APIGateway.</returns>
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
        public virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var marshaller = GetDomainNameRequestMarshaller.Instance;
            var unmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameRequest,GetDomainNameResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDomainNameRequestMarshaller.Instance;
            var unmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke<GetDomainNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainName.</param>
        /// 
        /// <returns>Returns a  GetDomainNameResult from APIGateway.</returns>
        public virtual GetDomainNameResponse EndGetDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainNames

        /// <summary>
        /// Represents a collection of <a>DomainName</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// 
        /// <returns>The response from the GetDomainNames service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var marshaller = GetDomainNamesRequestMarshaller.Instance;
            var unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesRequest,GetDomainNamesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetDomainNames(GetDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetDomainNamesRequestMarshaller.Instance;
            var unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return BeginInvoke<GetDomainNamesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainNames.</param>
        /// 
        /// <returns>Returns a  GetDomainNamesResult from APIGateway.</returns>
        public virtual GetDomainNamesResponse EndGetDomainNames(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExport

        /// <summary>
        /// Exports a deployed version of a <a>RestApi</a> in a specified format.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetExportResponse GetExport(GetExportRequest request)
        {
            var marshaller = GetExportRequestMarshaller.Instance;
            var unmarshaller = GetExportResponseUnmarshaller.Instance;

            return Invoke<GetExportRequest,GetExportResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetExport(GetExportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetExportRequestMarshaller.Instance;
            var unmarshaller = GetExportResponseUnmarshaller.Instance;

            return BeginInvoke<GetExportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExport.</param>
        /// 
        /// <returns>Returns a  GetExportResult from APIGateway.</returns>
        public virtual GetExportResponse EndGetExport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGatewayResponse

        /// <summary>
        /// Gets a <a>GatewayResponse</a> of a specified response type on the given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the GetGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetGatewayResponseResponse GetGatewayResponse(GetGatewayResponseRequest request)
        {
            var marshaller = GetGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = GetGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponseRequest,GetGatewayResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetGatewayResponse(GetGatewayResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = GetGatewayResponseResponseUnmarshaller.Instance;

            return BeginInvoke<GetGatewayResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGatewayResponse.</param>
        /// 
        /// <returns>Returns a  GetGatewayResponseResult from APIGateway.</returns>
        public virtual GetGatewayResponseResponse EndGetGatewayResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGatewayResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGatewayResponses

        /// <summary>
        /// Gets the <a>GatewayResponses</a> collection on the given <a>RestApi</a>. If an API
        /// developer has not added any definitions for gateway responses, the result will be
        /// the API Gateway-generated default <a>GatewayResponses</a> collection for the supported
        /// response types.
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
        public virtual GetGatewayResponsesResponse GetGatewayResponses(GetGatewayResponsesRequest request)
        {
            var marshaller = GetGatewayResponsesRequestMarshaller.Instance;
            var unmarshaller = GetGatewayResponsesResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponsesRequest,GetGatewayResponsesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetGatewayResponses(GetGatewayResponsesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetGatewayResponsesRequestMarshaller.Instance;
            var unmarshaller = GetGatewayResponsesResponseUnmarshaller.Instance;

            return BeginInvoke<GetGatewayResponsesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGatewayResponses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGatewayResponses.</param>
        /// 
        /// <returns>Returns a  GetGatewayResponsesResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var marshaller = GetIntegrationRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationRequest,GetIntegrationResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntegrationRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntegrationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegration.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var marshaller = GetIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseRequest,GetIntegrationResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetIntegrationResponse(GetIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke<GetIntegrationResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  GetIntegrationResponseResult from APIGateway.</returns>
        public virtual GetIntegrationResponseResponse EndGetIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMethod

        /// <summary>
        /// Describe an existing <a>Method</a> resource.
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
        public virtual GetMethodResponse GetMethod(GetMethodRequest request)
        {
            var marshaller = GetMethodRequestMarshaller.Instance;
            var unmarshaller = GetMethodResponseUnmarshaller.Instance;

            return Invoke<GetMethodRequest,GetMethodResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetMethod(GetMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetMethodRequestMarshaller.Instance;
            var unmarshaller = GetMethodResponseUnmarshaller.Instance;

            return BeginInvoke<GetMethodRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMethod.</param>
        /// 
        /// <returns>Returns a  GetMethodResult from APIGateway.</returns>
        public virtual GetMethodResponse EndGetMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMethodResponse

        /// <summary>
        /// Describes a <a>MethodResponse</a> resource.
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
        public virtual GetMethodResponseResponse GetMethodResponse(GetMethodResponseRequest request)
        {
            var marshaller = GetMethodResponseRequestMarshaller.Instance;
            var unmarshaller = GetMethodResponseResponseUnmarshaller.Instance;

            return Invoke<GetMethodResponseRequest,GetMethodResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetMethodResponse(GetMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetMethodResponseRequestMarshaller.Instance;
            var unmarshaller = GetMethodResponseResponseUnmarshaller.Instance;

            return BeginInvoke<GetMethodResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMethodResponse.</param>
        /// 
        /// <returns>Returns a  GetMethodResponseResult from APIGateway.</returns>
        public virtual GetMethodResponseResponse EndGetMethodResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMethodResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModel

        /// <summary>
        /// Describes an existing model defined for a <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// 
        /// <returns>The response from the GetModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetModelResponse GetModel(GetModelRequest request)
        {
            var marshaller = GetModelRequestMarshaller.Instance;
            var unmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelRequest,GetModelResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetModel(GetModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetModelRequestMarshaller.Instance;
            var unmarshaller = GetModelResponseUnmarshaller.Instance;

            return BeginInvoke<GetModelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModel.</param>
        /// 
        /// <returns>Returns a  GetModelResult from APIGateway.</returns>
        public virtual GetModelResponse EndGetModel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetModels

        /// <summary>
        /// Describes existing <a>Models</a> defined for a <a>RestApi</a> resource.
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
        public virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var marshaller = GetModelsRequestMarshaller.Instance;
            var unmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsRequest,GetModelsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetModelsRequestMarshaller.Instance;
            var unmarshaller = GetModelsResponseUnmarshaller.Instance;

            return BeginInvoke<GetModelsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from APIGateway.</returns>
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
        public virtual GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var marshaller = GetModelTemplateRequestMarshaller.Instance;
            var unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateRequest,GetModelTemplateResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetModelTemplate(GetModelTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetModelTemplateRequestMarshaller.Instance;
            var unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return BeginInvoke<GetModelTemplateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelTemplate.</param>
        /// 
        /// <returns>Returns a  GetModelTemplateResult from APIGateway.</returns>
        public virtual GetModelTemplateResponse EndGetModelTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRequestValidator

        /// <summary>
        /// Gets a <a>RequestValidator</a> of a given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidator service method.</param>
        /// 
        /// <returns>The response from the GetRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetRequestValidatorResponse GetRequestValidator(GetRequestValidatorRequest request)
        {
            var marshaller = GetRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = GetRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<GetRequestValidatorRequest,GetRequestValidatorResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetRequestValidator(GetRequestValidatorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = GetRequestValidatorResponseUnmarshaller.Instance;

            return BeginInvoke<GetRequestValidatorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequestValidator.</param>
        /// 
        /// <returns>Returns a  GetRequestValidatorResult from APIGateway.</returns>
        public virtual GetRequestValidatorResponse EndGetRequestValidator(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRequestValidatorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRequestValidators

        /// <summary>
        /// Gets the <a>RequestValidators</a> collection of a given <a>RestApi</a>.
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
        public virtual GetRequestValidatorsResponse GetRequestValidators(GetRequestValidatorsRequest request)
        {
            var marshaller = GetRequestValidatorsRequestMarshaller.Instance;
            var unmarshaller = GetRequestValidatorsResponseUnmarshaller.Instance;

            return Invoke<GetRequestValidatorsRequest,GetRequestValidatorsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetRequestValidators(GetRequestValidatorsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetRequestValidatorsRequestMarshaller.Instance;
            var unmarshaller = GetRequestValidatorsResponseUnmarshaller.Instance;

            return BeginInvoke<GetRequestValidatorsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRequestValidators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRequestValidators.</param>
        /// 
        /// <returns>Returns a  GetRequestValidatorsResult from APIGateway.</returns>
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
        public virtual GetResourceResponse GetResource(GetResourceRequest request)
        {
            var marshaller = GetResourceRequestMarshaller.Instance;
            var unmarshaller = GetResourceResponseUnmarshaller.Instance;

            return Invoke<GetResourceRequest,GetResourceResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetResource(GetResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetResourceRequestMarshaller.Instance;
            var unmarshaller = GetResourceResponseUnmarshaller.Instance;

            return BeginInvoke<GetResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResource.</param>
        /// 
        /// <returns>Returns a  GetResourceResult from APIGateway.</returns>
        public virtual GetResourceResponse EndGetResource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResources

        /// <summary>
        /// Lists information about a collection of <a>Resource</a> resources.
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
        public virtual GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var marshaller = GetResourcesRequestMarshaller.Instance;
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return Invoke<GetResourcesRequest,GetResourcesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetResources(GetResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetResourcesRequestMarshaller.Instance;
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return BeginInvoke<GetResourcesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResources.</param>
        /// 
        /// <returns>Returns a  GetResourcesResult from APIGateway.</returns>
        public virtual GetResourcesResponse EndGetResources(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRestApi

        /// <summary>
        /// Lists the <a>RestApi</a> resource in the collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi service method.</param>
        /// 
        /// <returns>The response from the GetRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetRestApiResponse GetRestApi(GetRestApiRequest request)
        {
            var marshaller = GetRestApiRequestMarshaller.Instance;
            var unmarshaller = GetRestApiResponseUnmarshaller.Instance;

            return Invoke<GetRestApiRequest,GetRestApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetRestApi(GetRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetRestApiRequestMarshaller.Instance;
            var unmarshaller = GetRestApiResponseUnmarshaller.Instance;

            return BeginInvoke<GetRestApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestApi.</param>
        /// 
        /// <returns>Returns a  GetRestApiResult from APIGateway.</returns>
        public virtual GetRestApiResponse EndGetRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRestApis

        /// <summary>
        /// Lists the <a>RestApis</a> resources for your collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis service method.</param>
        /// 
        /// <returns>The response from the GetRestApis service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetRestApisResponse GetRestApis(GetRestApisRequest request)
        {
            var marshaller = GetRestApisRequestMarshaller.Instance;
            var unmarshaller = GetRestApisResponseUnmarshaller.Instance;

            return Invoke<GetRestApisRequest,GetRestApisResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetRestApis(GetRestApisRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetRestApisRequestMarshaller.Instance;
            var unmarshaller = GetRestApisResponseUnmarshaller.Instance;

            return BeginInvoke<GetRestApisRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRestApis.</param>
        /// 
        /// <returns>Returns a  GetRestApisResult from APIGateway.</returns>
        public virtual GetRestApisResponse EndGetRestApis(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestApisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSdk

        /// <summary>
        /// Generates a client SDK for a <a>RestApi</a> and <a>Stage</a>.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetSdkResponse GetSdk(GetSdkRequest request)
        {
            var marshaller = GetSdkRequestMarshaller.Instance;
            var unmarshaller = GetSdkResponseUnmarshaller.Instance;

            return Invoke<GetSdkRequest,GetSdkResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetSdk(GetSdkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSdkRequestMarshaller.Instance;
            var unmarshaller = GetSdkResponseUnmarshaller.Instance;

            return BeginInvoke<GetSdkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdk operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdk.</param>
        /// 
        /// <returns>Returns a  GetSdkResult from APIGateway.</returns>
        public virtual GetSdkResponse EndGetSdk(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSdkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSdkType

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdkType service method.</param>
        /// 
        /// <returns>The response from the GetSdkType service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetSdkTypeResponse GetSdkType(GetSdkTypeRequest request)
        {
            var marshaller = GetSdkTypeRequestMarshaller.Instance;
            var unmarshaller = GetSdkTypeResponseUnmarshaller.Instance;

            return Invoke<GetSdkTypeRequest,GetSdkTypeResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetSdkType(GetSdkTypeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSdkTypeRequestMarshaller.Instance;
            var unmarshaller = GetSdkTypeResponseUnmarshaller.Instance;

            return BeginInvoke<GetSdkTypeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdkType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdkType.</param>
        /// 
        /// <returns>Returns a  GetSdkTypeResult from APIGateway.</returns>
        public virtual GetSdkTypeResponse EndGetSdkType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSdkTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSdkTypes

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdkTypes service method.</param>
        /// 
        /// <returns>The response from the GetSdkTypes service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetSdkTypesResponse GetSdkTypes(GetSdkTypesRequest request)
        {
            var marshaller = GetSdkTypesRequestMarshaller.Instance;
            var unmarshaller = GetSdkTypesResponseUnmarshaller.Instance;

            return Invoke<GetSdkTypesRequest,GetSdkTypesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetSdkTypes(GetSdkTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetSdkTypesRequestMarshaller.Instance;
            var unmarshaller = GetSdkTypesResponseUnmarshaller.Instance;

            return BeginInvoke<GetSdkTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSdkTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSdkTypes.</param>
        /// 
        /// <returns>Returns a  GetSdkTypesResult from APIGateway.</returns>
        public virtual GetSdkTypesResponse EndGetSdkTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSdkTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStage

        /// <summary>
        /// Gets information about a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var marshaller = GetStageRequestMarshaller.Instance;
            var unmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageRequest,GetStageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetStageRequestMarshaller.Instance;
            var unmarshaller = GetStageResponseUnmarshaller.Instance;

            return BeginInvoke<GetStageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStage.</param>
        /// 
        /// <returns>Returns a  GetStageResult from APIGateway.</returns>
        public virtual GetStageResponse EndGetStage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetStages

        /// <summary>
        /// Gets information about one or more <a>Stage</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// 
        /// <returns>The response from the GetStages service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetStagesResponse GetStages(GetStagesRequest request)
        {
            var marshaller = GetStagesRequestMarshaller.Instance;
            var unmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesRequest,GetStagesResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetStages(GetStagesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetStagesRequestMarshaller.Instance;
            var unmarshaller = GetStagesResponseUnmarshaller.Instance;

            return BeginInvoke<GetStagesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetStages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStages.</param>
        /// 
        /// <returns>Returns a  GetStagesResult from APIGateway.</returns>
        public virtual GetStagesResponse EndGetStages(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStagesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTags

        /// <summary>
        /// Gets the <a>Tags</a> collection for a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
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
        public virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var marshaller = GetTagsRequestMarshaller.Instance;
            var unmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsRequest,GetTagsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetTagsRequestMarshaller.Instance;
            var unmarshaller = GetTagsResponseUnmarshaller.Instance;

            return BeginInvoke<GetTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from APIGateway.</returns>
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
        public virtual GetUsageResponse GetUsage(GetUsageRequest request)
        {
            var marshaller = GetUsageRequestMarshaller.Instance;
            var unmarshaller = GetUsageResponseUnmarshaller.Instance;

            return Invoke<GetUsageRequest,GetUsageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetUsage(GetUsageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUsageRequestMarshaller.Instance;
            var unmarshaller = GetUsageResponseUnmarshaller.Instance;

            return BeginInvoke<GetUsageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsage.</param>
        /// 
        /// <returns>Returns a  GetUsageResult from APIGateway.</returns>
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
        public virtual GetUsagePlanResponse GetUsagePlan(GetUsagePlanRequest request)
        {
            var marshaller = GetUsagePlanRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanRequest,GetUsagePlanResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetUsagePlan(GetUsagePlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUsagePlanRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanResponseUnmarshaller.Instance;

            return BeginInvoke<GetUsagePlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlan.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanResult from APIGateway.</returns>
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
        public virtual GetUsagePlanKeyResponse GetUsagePlanKey(GetUsagePlanKeyRequest request)
        {
            var marshaller = GetUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanKeyRequest,GetUsagePlanKeyResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetUsagePlanKey(GetUsagePlanKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanKeyResponseUnmarshaller.Instance;

            return BeginInvoke<GetUsagePlanKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlanKey.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanKeyResult from APIGateway.</returns>
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
        public virtual GetUsagePlanKeysResponse GetUsagePlanKeys(GetUsagePlanKeysRequest request)
        {
            var marshaller = GetUsagePlanKeysRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanKeysResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanKeysRequest,GetUsagePlanKeysResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetUsagePlanKeys(GetUsagePlanKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUsagePlanKeysRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanKeysResponseUnmarshaller.Instance;

            return BeginInvoke<GetUsagePlanKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlanKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlanKeys.</param>
        /// 
        /// <returns>Returns a  GetUsagePlanKeysResult from APIGateway.</returns>
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
        public virtual GetUsagePlansResponse GetUsagePlans(GetUsagePlansRequest request)
        {
            var marshaller = GetUsagePlansRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlansResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlansRequest,GetUsagePlansResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetUsagePlans(GetUsagePlansRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUsagePlansRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlansResponseUnmarshaller.Instance;

            return BeginInvoke<GetUsagePlansRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsagePlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsagePlans.</param>
        /// 
        /// <returns>Returns a  GetUsagePlansResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetVpcLinkResponse GetVpcLink(GetVpcLinkRequest request)
        {
            var marshaller = GetVpcLinkRequestMarshaller.Instance;
            var unmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinkRequest,GetVpcLinkResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetVpcLink(GetVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetVpcLinkRequestMarshaller.Instance;
            var unmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke<GetVpcLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLink.</param>
        /// 
        /// <returns>Returns a  GetVpcLinkResult from APIGateway.</returns>
        public virtual GetVpcLinkResponse EndGetVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVpcLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVpcLinks

        /// <summary>
        /// Gets the <a>VpcLinks</a> collection under the caller's account in a selected region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// 
        /// <returns>The response from the GetVpcLinks service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual GetVpcLinksResponse GetVpcLinks(GetVpcLinksRequest request)
        {
            var marshaller = GetVpcLinksRequestMarshaller.Instance;
            var unmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinksRequest,GetVpcLinksResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginGetVpcLinks(GetVpcLinksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetVpcLinksRequestMarshaller.Instance;
            var unmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return BeginInvoke<GetVpcLinksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcLinks.</param>
        /// 
        /// <returns>Returns a  GetVpcLinksResult from APIGateway.</returns>
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
        public virtual ImportApiKeysResponse ImportApiKeys(ImportApiKeysRequest request)
        {
            var marshaller = ImportApiKeysRequestMarshaller.Instance;
            var unmarshaller = ImportApiKeysResponseUnmarshaller.Instance;

            return Invoke<ImportApiKeysRequest,ImportApiKeysResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginImportApiKeys(ImportApiKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ImportApiKeysRequestMarshaller.Instance;
            var unmarshaller = ImportApiKeysResponseUnmarshaller.Instance;

            return BeginInvoke<ImportApiKeysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportApiKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportApiKeys.</param>
        /// 
        /// <returns>Returns a  ImportApiKeysResult from APIGateway.</returns>
        public virtual ImportApiKeysResponse EndImportApiKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportApiKeysResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportDocumentationParts

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDocumentationParts service method.</param>
        /// 
        /// <returns>The response from the ImportDocumentationParts service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
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
        public virtual ImportDocumentationPartsResponse ImportDocumentationParts(ImportDocumentationPartsRequest request)
        {
            var marshaller = ImportDocumentationPartsRequestMarshaller.Instance;
            var unmarshaller = ImportDocumentationPartsResponseUnmarshaller.Instance;

            return Invoke<ImportDocumentationPartsRequest,ImportDocumentationPartsResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginImportDocumentationParts(ImportDocumentationPartsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ImportDocumentationPartsRequestMarshaller.Instance;
            var unmarshaller = ImportDocumentationPartsResponseUnmarshaller.Instance;

            return BeginInvoke<ImportDocumentationPartsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportDocumentationParts.</param>
        /// 
        /// <returns>Returns a  ImportDocumentationPartsResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual ImportRestApiResponse ImportRestApi(ImportRestApiRequest request)
        {
            var marshaller = ImportRestApiRequestMarshaller.Instance;
            var unmarshaller = ImportRestApiResponseUnmarshaller.Instance;

            return Invoke<ImportRestApiRequest,ImportRestApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginImportRestApi(ImportRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ImportRestApiRequestMarshaller.Instance;
            var unmarshaller = ImportRestApiResponseUnmarshaller.Instance;

            return BeginInvoke<ImportRestApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportRestApi.</param>
        /// 
        /// <returns>Returns a  ImportRestApiResult from APIGateway.</returns>
        public virtual ImportRestApiResponse EndImportRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  PutGatewayResponse

        /// <summary>
        /// Creates a customization of a <a>GatewayResponse</a> of a specified response type and
        /// status code on the given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the PutGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
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
        public virtual PutGatewayResponseResponse PutGatewayResponse(PutGatewayResponseRequest request)
        {
            var marshaller = PutGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = PutGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<PutGatewayResponseRequest,PutGatewayResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginPutGatewayResponse(PutGatewayResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = PutGatewayResponseResponseUnmarshaller.Instance;

            return BeginInvoke<PutGatewayResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGatewayResponse.</param>
        /// 
        /// <returns>Returns a  PutGatewayResponseResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual PutIntegrationResponse PutIntegration(PutIntegrationRequest request)
        {
            var marshaller = PutIntegrationRequestMarshaller.Instance;
            var unmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationRequest,PutIntegrationResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginPutIntegration(PutIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutIntegrationRequestMarshaller.Instance;
            var unmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke<PutIntegrationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegration.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResult from APIGateway.</returns>
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
        public virtual PutIntegrationResponseResponse PutIntegrationResponse(PutIntegrationResponseRequest request)
        {
            var marshaller = PutIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationResponseRequest,PutIntegrationResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginPutIntegrationResponse(PutIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke<PutIntegrationResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  PutIntegrationResponseResult from APIGateway.</returns>
        public virtual PutIntegrationResponseResponse EndPutIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<PutIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMethod

        /// <summary>
        /// Add a method to an existing <a>Resource</a> resource.
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
        public virtual PutMethodResponse PutMethod(PutMethodRequest request)
        {
            var marshaller = PutMethodRequestMarshaller.Instance;
            var unmarshaller = PutMethodResponseUnmarshaller.Instance;

            return Invoke<PutMethodRequest,PutMethodResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginPutMethod(PutMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutMethodRequestMarshaller.Instance;
            var unmarshaller = PutMethodResponseUnmarshaller.Instance;

            return BeginInvoke<PutMethodRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMethod.</param>
        /// 
        /// <returns>Returns a  PutMethodResult from APIGateway.</returns>
        public virtual PutMethodResponse EndPutMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMethodResponse

        /// <summary>
        /// Adds a <a>MethodResponse</a> to an existing <a>Method</a> resource.
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
        public virtual PutMethodResponseResponse PutMethodResponse(PutMethodResponseRequest request)
        {
            var marshaller = PutMethodResponseRequestMarshaller.Instance;
            var unmarshaller = PutMethodResponseResponseUnmarshaller.Instance;

            return Invoke<PutMethodResponseRequest,PutMethodResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginPutMethodResponse(PutMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutMethodResponseRequestMarshaller.Instance;
            var unmarshaller = PutMethodResponseResponseUnmarshaller.Instance;

            return BeginInvoke<PutMethodResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMethodResponse.</param>
        /// 
        /// <returns>Returns a  PutMethodResponseResult from APIGateway.</returns>
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
        public virtual PutRestApiResponse PutRestApi(PutRestApiRequest request)
        {
            var marshaller = PutRestApiRequestMarshaller.Instance;
            var unmarshaller = PutRestApiResponseUnmarshaller.Instance;

            return Invoke<PutRestApiRequest,PutRestApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginPutRestApi(PutRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PutRestApiRequestMarshaller.Instance;
            var unmarshaller = PutRestApiResponseUnmarshaller.Instance;

            return BeginInvoke<PutRestApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRestApi.</param>
        /// 
        /// <returns>Returns a  PutRestApiResult from APIGateway.</returns>
        public virtual PutRestApiResponse EndPutRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRestApiResponse>(asyncResult);
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<TagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from APIGateway.</returns>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TestInvokeAuthorizer

        /// <summary>
        /// Simulate the execution of an <a>Authorizer</a> in your <a>RestApi</a> with headers,
        /// parameters, and an incoming request body.
        /// 
        ///  <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/use-custom-authorizer.html">Enable
        /// custom authorizers</a> </div>
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
        public virtual TestInvokeAuthorizerResponse TestInvokeAuthorizer(TestInvokeAuthorizerRequest request)
        {
            var marshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            var unmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return Invoke<TestInvokeAuthorizerRequest,TestInvokeAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginTestInvokeAuthorizer(TestInvokeAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            var unmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<TestInvokeAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeAuthorizer.</param>
        /// 
        /// <returns>Returns a  TestInvokeAuthorizerResult from APIGateway.</returns>
        public virtual TestInvokeAuthorizerResponse EndTestInvokeAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<TestInvokeAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  TestInvokeMethod

        /// <summary>
        /// Simulate the execution of a <a>Method</a> in your <a>RestApi</a> with headers, parameters,
        /// and an incoming request body.
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
        public virtual TestInvokeMethodResponse TestInvokeMethod(TestInvokeMethodRequest request)
        {
            var marshaller = TestInvokeMethodRequestMarshaller.Instance;
            var unmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;

            return Invoke<TestInvokeMethodRequest,TestInvokeMethodResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginTestInvokeMethod(TestInvokeMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TestInvokeMethodRequestMarshaller.Instance;
            var unmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;

            return BeginInvoke<TestInvokeMethodRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeMethod.</param>
        /// 
        /// <returns>Returns a  TestInvokeMethodResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke<UntagResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from APIGateway.</returns>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccount

        /// <summary>
        /// Changes information about the current <a>Account</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
        /// 
        /// <returns>The response from the UpdateAccount service method, as returned by APIGateway.</returns>
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
        public virtual UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var marshaller = UpdateAccountRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountRequest,UpdateAccountResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateAccount(UpdateAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateAccountRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAccountRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccount.</param>
        /// 
        /// <returns>Returns a  UpdateAccountResult from APIGateway.</returns>
        public virtual UpdateAccountResponse EndUpdateAccount(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApiKey

        /// <summary>
        /// Changes information about an <a>ApiKey</a> resource.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var marshaller = UpdateApiKeyRequestMarshaller.Instance;
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyRequest,UpdateApiKeyResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateApiKey(UpdateApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateApiKeyRequestMarshaller.Instance;
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateApiKeyRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApiKey.</param>
        /// 
        /// <returns>Returns a  UpdateApiKeyResult from APIGateway.</returns>
        public virtual UpdateApiKeyResponse EndUpdateApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAuthorizer

        /// <summary>
        /// Updates an existing <a>Authorizer</a> resource.
        /// 
        ///  <div class="seeAlso"><a href="http://docs.aws.amazon.com/cli/latest/reference/apigateway/update-authorizer.html">AWS
        /// CLI</a></div>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by APIGateway.</returns>
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
        public virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var marshaller = UpdateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerRequest,UpdateAuthorizerResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateAuthorizer(UpdateAuthorizerRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateAuthorizerRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthorizer.</param>
        /// 
        /// <returns>Returns a  UpdateAuthorizerResult from APIGateway.</returns>
        public virtual UpdateAuthorizerResponse EndUpdateAuthorizer(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAuthorizerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBasePathMapping

        /// <summary>
        /// Changes information about the <a>BasePathMapping</a> resource.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateBasePathMappingResponse UpdateBasePathMapping(UpdateBasePathMappingRequest request)
        {
            var marshaller = UpdateBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateBasePathMappingRequest,UpdateBasePathMappingResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateBasePathMapping(UpdateBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateBasePathMappingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBasePathMapping.</param>
        /// 
        /// <returns>Returns a  UpdateBasePathMappingResult from APIGateway.</returns>
        public virtual UpdateBasePathMappingResponse EndUpdateBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClientCertificate

        /// <summary>
        /// Changes information about an <a>ClientCertificate</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateClientCertificate service method, as returned by APIGateway.</returns>
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
        public virtual UpdateClientCertificateResponse UpdateClientCertificate(UpdateClientCertificateRequest request)
        {
            var marshaller = UpdateClientCertificateRequestMarshaller.Instance;
            var unmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateClientCertificateRequest,UpdateClientCertificateResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateClientCertificate(UpdateClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateClientCertificateRequestMarshaller.Instance;
            var unmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateClientCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateClientCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateClientCertificateResult from APIGateway.</returns>
        public virtual UpdateClientCertificateResponse EndUpdateClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDeployment

        /// <summary>
        /// Changes information about a <a>Deployment</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by APIGateway.</returns>
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
        public virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var marshaller = UpdateDeploymentRequestMarshaller.Instance;
            var unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentRequest,UpdateDeploymentResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateDeployment(UpdateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDeploymentRequestMarshaller.Instance;
            var unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDeploymentRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDeployment.</param>
        /// 
        /// <returns>Returns a  UpdateDeploymentResult from APIGateway.</returns>
        public virtual UpdateDeploymentResponse EndUpdateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDocumentationPart

        /// <summary>
        /// 
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
        public virtual UpdateDocumentationPartResponse UpdateDocumentationPart(UpdateDocumentationPartRequest request)
        {
            var marshaller = UpdateDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentationPartRequest,UpdateDocumentationPartResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateDocumentationPart(UpdateDocumentationPartRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentationPartResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDocumentationPartRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentationPart.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentationPartResult from APIGateway.</returns>
        public virtual UpdateDocumentationPartResponse EndUpdateDocumentationPart(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentationPartResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDocumentationVersion

        /// <summary>
        /// 
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateDocumentationVersionResponse UpdateDocumentationVersion(UpdateDocumentationVersionRequest request)
        {
            var marshaller = UpdateDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentationVersionRequest,UpdateDocumentationVersionResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateDocumentationVersion(UpdateDocumentationVersionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentationVersionResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDocumentationVersionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDocumentationVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDocumentationVersionResult from APIGateway.</returns>
        public virtual UpdateDocumentationVersionResponse EndUpdateDocumentationVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDocumentationVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomainName

        /// <summary>
        /// Changes information about the <a>DomainName</a> resource.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var marshaller = UpdateDomainNameRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameRequest,UpdateDomainNameResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateDomainNameRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateDomainNameRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainName.</param>
        /// 
        /// <returns>Returns a  UpdateDomainNameResult from APIGateway.</returns>
        public virtual UpdateDomainNameResponse EndUpdateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGatewayResponse

        /// <summary>
        /// Updates a <a>GatewayResponse</a> of a specified response type on the given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayResponse service method, as returned by APIGateway.</returns>
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
        public virtual UpdateGatewayResponseResponse UpdateGatewayResponse(UpdateGatewayResponseRequest request)
        {
            var marshaller = UpdateGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayResponseRequest,UpdateGatewayResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateGatewayResponse(UpdateGatewayResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateGatewayResponseResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateGatewayResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGatewayResponse.</param>
        /// 
        /// <returns>Returns a  UpdateGatewayResponseResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var marshaller = UpdateIntegrationRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationRequest,UpdateIntegrationResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateIntegration(UpdateIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateIntegrationRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateIntegrationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegration.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var marshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseRequest,UpdateIntegrationResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateIntegrationResponse(UpdateIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateIntegrationResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIntegrationResponse.</param>
        /// 
        /// <returns>Returns a  UpdateIntegrationResponseResult from APIGateway.</returns>
        public virtual UpdateIntegrationResponseResponse EndUpdateIntegrationResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateIntegrationResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMethod

        /// <summary>
        /// Updates an existing <a>Method</a> resource.
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
        public virtual UpdateMethodResponse UpdateMethod(UpdateMethodRequest request)
        {
            var marshaller = UpdateMethodRequestMarshaller.Instance;
            var unmarshaller = UpdateMethodResponseUnmarshaller.Instance;

            return Invoke<UpdateMethodRequest,UpdateMethodResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateMethod(UpdateMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateMethodRequestMarshaller.Instance;
            var unmarshaller = UpdateMethodResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateMethodRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMethod.</param>
        /// 
        /// <returns>Returns a  UpdateMethodResult from APIGateway.</returns>
        public virtual UpdateMethodResponse EndUpdateMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMethodResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateMethodResponse

        /// <summary>
        /// Updates an existing <a>MethodResponse</a> resource.
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
        public virtual UpdateMethodResponseResponse UpdateMethodResponse(UpdateMethodResponseRequest request)
        {
            var marshaller = UpdateMethodResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateMethodResponseRequest,UpdateMethodResponseResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateMethodResponse(UpdateMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateMethodResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateMethodResponseRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMethodResponse.</param>
        /// 
        /// <returns>Returns a  UpdateMethodResponseResult from APIGateway.</returns>
        public virtual UpdateMethodResponseResponse EndUpdateMethodResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateMethodResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateModel

        /// <summary>
        /// Changes information about a model.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var marshaller = UpdateModelRequestMarshaller.Instance;
            var unmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelRequest,UpdateModelResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateModelRequestMarshaller.Instance;
            var unmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateModelRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from APIGateway.</returns>
        public virtual UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRequestValidator

        /// <summary>
        /// Updates a <a>RequestValidator</a> of a given <a>RestApi</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequestValidator service method.</param>
        /// 
        /// <returns>The response from the UpdateRequestValidator service method, as returned by APIGateway.</returns>
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
        public virtual UpdateRequestValidatorResponse UpdateRequestValidator(UpdateRequestValidatorRequest request)
        {
            var marshaller = UpdateRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = UpdateRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<UpdateRequestValidatorRequest,UpdateRequestValidatorResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateRequestValidator(UpdateRequestValidatorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = UpdateRequestValidatorResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateRequestValidatorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRequestValidator.</param>
        /// 
        /// <returns>Returns a  UpdateRequestValidatorResult from APIGateway.</returns>
        public virtual UpdateRequestValidatorResponse EndUpdateRequestValidator(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRequestValidatorResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateResource

        /// <summary>
        /// Changes information about a <a>Resource</a> resource.
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
        public virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var marshaller = UpdateResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceRequest,UpdateResourceResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateResourceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateRestApiResponse UpdateRestApi(UpdateRestApiRequest request)
        {
            var marshaller = UpdateRestApiRequestMarshaller.Instance;
            var unmarshaller = UpdateRestApiResponseUnmarshaller.Instance;

            return Invoke<UpdateRestApiRequest,UpdateRestApiResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateRestApi(UpdateRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateRestApiRequestMarshaller.Instance;
            var unmarshaller = UpdateRestApiResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateRestApiRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRestApi.</param>
        /// 
        /// <returns>Returns a  UpdateRestApiResult from APIGateway.</returns>
        public virtual UpdateRestApiResponse EndUpdateRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateStage

        /// <summary>
        /// Changes information about a <a>Stage</a> resource.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var marshaller = UpdateStageRequestMarshaller.Instance;
            var unmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageRequest,UpdateStageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateStageRequestMarshaller.Instance;
            var unmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateStageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStage.</param>
        /// 
        /// <returns>Returns a  UpdateStageResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateUsageResponse UpdateUsage(UpdateUsageRequest request)
        {
            var marshaller = UpdateUsageRequestMarshaller.Instance;
            var unmarshaller = UpdateUsageResponseUnmarshaller.Instance;

            return Invoke<UpdateUsageRequest,UpdateUsageResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateUsage(UpdateUsageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateUsageRequestMarshaller.Instance;
            var unmarshaller = UpdateUsageResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUsageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsage.</param>
        /// 
        /// <returns>Returns a  UpdateUsageResult from APIGateway.</returns>
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateUsagePlanResponse UpdateUsagePlan(UpdateUsagePlanRequest request)
        {
            var marshaller = UpdateUsagePlanRequestMarshaller.Instance;
            var unmarshaller = UpdateUsagePlanResponseUnmarshaller.Instance;

            return Invoke<UpdateUsagePlanRequest,UpdateUsagePlanResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateUsagePlan(UpdateUsagePlanRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateUsagePlanRequestMarshaller.Instance;
            var unmarshaller = UpdateUsagePlanResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateUsagePlanRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUsagePlan.</param>
        /// 
        /// <returns>Returns a  UpdateUsagePlanResult from APIGateway.</returns>
        public virtual UpdateUsagePlanResponse EndUpdateUsagePlan(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUsagePlanResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVpcLink

        /// <summary>
        /// Updates an existing <a>VpcLink</a> of a specified identifier.
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        public virtual UpdateVpcLinkResponse UpdateVpcLink(UpdateVpcLinkRequest request)
        {
            var marshaller = UpdateVpcLinkRequestMarshaller.Instance;
            var unmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcLinkRequest,UpdateVpcLinkResponse>(request, marshaller, unmarshaller);
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
        public virtual IAsyncResult BeginUpdateVpcLink(UpdateVpcLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateVpcLinkRequestMarshaller.Instance;
            var unmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateVpcLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcLink.</param>
        /// 
        /// <returns>Returns a  UpdateVpcLinkResult from APIGateway.</returns>
        public virtual UpdateVpcLinkResponse EndUpdateVpcLink(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVpcLinkResponse>(asyncResult);
        }

        #endregion
        
    }
}