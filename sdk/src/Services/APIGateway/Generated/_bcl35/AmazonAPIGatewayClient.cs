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
    /// Amazon API Gateway helps developers deliver robust, secure and scalable mobile and
    /// web application backends. Amazon API Gateway allows developers to securely connect
    /// mobile and web applications to APIs that run on AWS Lambda, Amazon EC2, or other publicly
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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            var marshaller = new CreateApiKeyRequestMarshaller();
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
        public IAsyncResult BeginCreateApiKey(CreateApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateApiKeyRequestMarshaller();
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
        public  CreateApiKeyResponse EndCreateApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApiKeyResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public CreateBasePathMappingResponse CreateBasePathMapping(CreateBasePathMappingRequest request)
        {
            var marshaller = new CreateBasePathMappingRequestMarshaller();
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
        public IAsyncResult BeginCreateBasePathMapping(CreateBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateBasePathMappingRequestMarshaller();
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
        public  CreateBasePathMappingResponse EndCreateBasePathMapping(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
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
        public IAsyncResult BeginCreateDeployment(CreateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
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
        public  CreateDeploymentResponse EndCreateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeploymentResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var marshaller = new CreateDomainNameRequestMarshaller();
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
        public IAsyncResult BeginCreateDomainName(CreateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDomainNameRequestMarshaller();
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
        public  CreateDomainNameResponse EndCreateDomainName(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var marshaller = new CreateModelRequestMarshaller();
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
        public IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateModelRequestMarshaller();
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
        public  CreateModelResponse EndCreateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateModelResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var marshaller = new CreateResourceRequestMarshaller();
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
        public IAsyncResult BeginCreateResource(CreateResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateResourceRequestMarshaller();
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
        public  CreateResourceResponse EndCreateResource(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public CreateRestApiResponse CreateRestApi(CreateRestApiRequest request)
        {
            var marshaller = new CreateRestApiRequestMarshaller();
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
        public IAsyncResult BeginCreateRestApi(CreateRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateRestApiRequestMarshaller();
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
        public  CreateRestApiResponse EndCreateRestApi(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRestApiResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStage

        /// <summary>
        /// Creates a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var marshaller = new CreateStageRequestMarshaller();
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
        public IAsyncResult BeginCreateStage(CreateStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateStageRequestMarshaller();
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
        public  CreateStageResponse EndCreateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStageResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var marshaller = new DeleteApiKeyRequestMarshaller();
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
        public IAsyncResult BeginDeleteApiKey(DeleteApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteApiKeyRequestMarshaller();
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
        public  DeleteApiKeyResponse EndDeleteApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApiKeyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBasePathMapping

        /// <summary>
        /// Deletes the <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteBasePathMappingResponse DeleteBasePathMapping(DeleteBasePathMappingRequest request)
        {
            var marshaller = new DeleteBasePathMappingRequestMarshaller();
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
        public IAsyncResult BeginDeleteBasePathMapping(DeleteBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteBasePathMappingRequestMarshaller();
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
        public  DeleteBasePathMappingResponse EndDeleteBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteClientCertificate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request)
        {
            var marshaller = new DeleteClientCertificateRequestMarshaller();
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
        public IAsyncResult BeginDeleteClientCertificate(DeleteClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteClientCertificateRequestMarshaller();
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
        public  DeleteClientCertificateResponse EndDeleteClientCertificate(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var marshaller = new DeleteDeploymentRequestMarshaller();
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
        public IAsyncResult BeginDeleteDeployment(DeleteDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDeploymentRequestMarshaller();
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
        public  DeleteDeploymentResponse EndDeleteDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeploymentResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var marshaller = new DeleteDomainNameRequestMarshaller();
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
        public IAsyncResult BeginDeleteDomainName(DeleteDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDomainNameRequestMarshaller();
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
        public  DeleteDomainNameResponse EndDeleteDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainNameResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIntegration

        /// <summary>
        /// Represents a delete integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var marshaller = new DeleteIntegrationRequestMarshaller();
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
        public IAsyncResult BeginDeleteIntegration(DeleteIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteIntegrationRequestMarshaller();
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
        public  DeleteIntegrationResponse EndDeleteIntegration(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var marshaller = new DeleteIntegrationResponseRequestMarshaller();
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
        public IAsyncResult BeginDeleteIntegrationResponse(DeleteIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteIntegrationResponseRequestMarshaller();
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
        public  DeleteIntegrationResponseResponse EndDeleteIntegrationResponse(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteMethodResponse DeleteMethod(DeleteMethodRequest request)
        {
            var marshaller = new DeleteMethodRequestMarshaller();
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
        public IAsyncResult BeginDeleteMethod(DeleteMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteMethodRequestMarshaller();
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
        public  DeleteMethodResponse EndDeleteMethod(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteMethodResponseResponse DeleteMethodResponse(DeleteMethodResponseRequest request)
        {
            var marshaller = new DeleteMethodResponseRequestMarshaller();
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
        public IAsyncResult BeginDeleteMethodResponse(DeleteMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteMethodResponseRequestMarshaller();
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
        public  DeleteMethodResponseResponse EndDeleteMethodResponse(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var marshaller = new DeleteModelRequestMarshaller();
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
        public IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteModelRequestMarshaller();
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
        public  DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteModelResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var marshaller = new DeleteResourceRequestMarshaller();
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
        public IAsyncResult BeginDeleteResource(DeleteResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteResourceRequestMarshaller();
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
        public  DeleteResourceResponse EndDeleteResource(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteRestApiResponse DeleteRestApi(DeleteRestApiRequest request)
        {
            var marshaller = new DeleteRestApiRequestMarshaller();
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
        public IAsyncResult BeginDeleteRestApi(DeleteRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRestApiRequestMarshaller();
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
        public  DeleteRestApiResponse EndDeleteRestApi(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var marshaller = new DeleteStageRequestMarshaller();
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
        public IAsyncResult BeginDeleteStage(DeleteStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteStageRequestMarshaller();
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
        public  DeleteStageResponse EndDeleteStage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStageResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public FlushStageCacheResponse FlushStageCache(FlushStageCacheRequest request)
        {
            var marshaller = new FlushStageCacheRequestMarshaller();
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
        public IAsyncResult BeginFlushStageCache(FlushStageCacheRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new FlushStageCacheRequestMarshaller();
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
        public  FlushStageCacheResponse EndFlushStageCache(IAsyncResult asyncResult)
        {
            return EndInvoke<FlushStageCacheResponse>(asyncResult);
        }

        #endregion
        
        #region  GenerateClientCertificate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GenerateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request)
        {
            var marshaller = new GenerateClientCertificateRequestMarshaller();
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
        public IAsyncResult BeginGenerateClientCertificate(GenerateClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GenerateClientCertificateRequestMarshaller();
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
        public  GenerateClientCertificateResponse EndGenerateClientCertificate(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var marshaller = new GetAccountRequestMarshaller();
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
        public IAsyncResult BeginGetAccount(GetAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetAccountRequestMarshaller();
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
        public  GetAccountResponse EndGetAccount(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetApiKeyResponse GetApiKey(GetApiKeyRequest request)
        {
            var marshaller = new GetApiKeyRequestMarshaller();
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
        public IAsyncResult BeginGetApiKey(GetApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetApiKeyRequestMarshaller();
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
        public  GetApiKeyResponse EndGetApiKey(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetApiKeysResponse GetApiKeys(GetApiKeysRequest request)
        {
            var marshaller = new GetApiKeysRequestMarshaller();
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
        public IAsyncResult BeginGetApiKeys(GetApiKeysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetApiKeysRequestMarshaller();
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
        public  GetApiKeysResponse EndGetApiKeys(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApiKeysResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetBasePathMappingResponse GetBasePathMapping(GetBasePathMappingRequest request)
        {
            var marshaller = new GetBasePathMappingRequestMarshaller();
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
        public IAsyncResult BeginGetBasePathMapping(GetBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBasePathMappingRequestMarshaller();
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
        public  GetBasePathMappingResponse EndGetBasePathMapping(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetBasePathMappingsResponse GetBasePathMappings(GetBasePathMappingsRequest request)
        {
            var marshaller = new GetBasePathMappingsRequestMarshaller();
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
        public IAsyncResult BeginGetBasePathMappings(GetBasePathMappingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetBasePathMappingsRequestMarshaller();
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
        public  GetBasePathMappingsResponse EndGetBasePathMappings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBasePathMappingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClientCertificate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetClientCertificateResponse GetClientCertificate(GetClientCertificateRequest request)
        {
            var marshaller = new GetClientCertificateRequestMarshaller();
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
        public IAsyncResult BeginGetClientCertificate(GetClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetClientCertificateRequestMarshaller();
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
        public  GetClientCertificateResponse EndGetClientCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetClientCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetClientCertificates

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificates service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetClientCertificatesResponse GetClientCertificates(GetClientCertificatesRequest request)
        {
            var marshaller = new GetClientCertificatesRequestMarshaller();
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
        public IAsyncResult BeginGetClientCertificates(GetClientCertificatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetClientCertificatesRequestMarshaller();
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
        public  GetClientCertificatesResponse EndGetClientCertificates(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var marshaller = new GetDeploymentRequestMarshaller();
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
        public IAsyncResult BeginGetDeployment(GetDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeploymentRequestMarshaller();
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
        public  GetDeploymentResponse EndGetDeployment(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var marshaller = new GetDeploymentsRequestMarshaller();
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
        public IAsyncResult BeginGetDeployments(GetDeploymentsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDeploymentsRequestMarshaller();
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
        public  GetDeploymentsResponse EndGetDeployments(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeploymentsResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var marshaller = new GetDomainNameRequestMarshaller();
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
        public IAsyncResult BeginGetDomainName(GetDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDomainNameRequestMarshaller();
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
        public  GetDomainNameResponse EndGetDomainName(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var marshaller = new GetDomainNamesRequestMarshaller();
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
        public IAsyncResult BeginGetDomainNames(GetDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetDomainNamesRequestMarshaller();
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
        public  GetDomainNamesResponse EndGetDomainNames(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIntegration

        /// <summary>
        /// Represents a get integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var marshaller = new GetIntegrationRequestMarshaller();
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
        public IAsyncResult BeginGetIntegration(GetIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetIntegrationRequestMarshaller();
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
        public  GetIntegrationResponse EndGetIntegration(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var marshaller = new GetIntegrationResponseRequestMarshaller();
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
        public IAsyncResult BeginGetIntegrationResponse(GetIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetIntegrationResponseRequestMarshaller();
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
        public  GetIntegrationResponseResponse EndGetIntegrationResponse(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetMethodResponse GetMethod(GetMethodRequest request)
        {
            var marshaller = new GetMethodRequestMarshaller();
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
        public IAsyncResult BeginGetMethod(GetMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetMethodRequestMarshaller();
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
        public  GetMethodResponse EndGetMethod(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetMethodResponseResponse GetMethodResponse(GetMethodResponseRequest request)
        {
            var marshaller = new GetMethodResponseRequestMarshaller();
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
        public IAsyncResult BeginGetMethodResponse(GetMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetMethodResponseRequestMarshaller();
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
        public  GetMethodResponseResponse EndGetMethodResponse(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetModelResponse GetModel(GetModelRequest request)
        {
            var marshaller = new GetModelRequestMarshaller();
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
        public IAsyncResult BeginGetModel(GetModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetModelRequestMarshaller();
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
        public  GetModelResponse EndGetModel(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetModelsResponse GetModels(GetModelsRequest request)
        {
            var marshaller = new GetModelsRequestMarshaller();
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
        public IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetModelsRequestMarshaller();
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
        public  GetModelsResponse EndGetModels(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var marshaller = new GetModelTemplateRequestMarshaller();
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
        public IAsyncResult BeginGetModelTemplate(GetModelTemplateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetModelTemplateRequestMarshaller();
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
        public  GetModelTemplateResponse EndGetModelTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetModelTemplateResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetResourceResponse GetResource(GetResourceRequest request)
        {
            var marshaller = new GetResourceRequestMarshaller();
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
        public IAsyncResult BeginGetResource(GetResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetResourceRequestMarshaller();
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
        public  GetResourceResponse EndGetResource(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var marshaller = new GetResourcesRequestMarshaller();
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
        public IAsyncResult BeginGetResources(GetResourcesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetResourcesRequestMarshaller();
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
        public  GetResourcesResponse EndGetResources(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetRestApiResponse GetRestApi(GetRestApiRequest request)
        {
            var marshaller = new GetRestApiRequestMarshaller();
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
        public IAsyncResult BeginGetRestApi(GetRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetRestApiRequestMarshaller();
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
        public  GetRestApiResponse EndGetRestApi(IAsyncResult asyncResult)
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
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetRestApisResponse GetRestApis(GetRestApisRequest request)
        {
            var marshaller = new GetRestApisRequestMarshaller();
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
        public IAsyncResult BeginGetRestApis(GetRestApisRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetRestApisRequestMarshaller();
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
        public  GetRestApisResponse EndGetRestApis(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRestApisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSdk

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdk service method.</param>
        /// 
        /// <returns>The response from the GetSdk service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetSdkResponse GetSdk(GetSdkRequest request)
        {
            var marshaller = new GetSdkRequestMarshaller();
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
        public IAsyncResult BeginGetSdk(GetSdkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetSdkRequestMarshaller();
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
        public  GetSdkResponse EndGetSdk(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSdkResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetStageResponse GetStage(GetStageRequest request)
        {
            var marshaller = new GetStageRequestMarshaller();
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
        public IAsyncResult BeginGetStage(GetStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetStageRequestMarshaller();
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
        public  GetStageResponse EndGetStage(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public GetStagesResponse GetStages(GetStagesRequest request)
        {
            var marshaller = new GetStagesRequestMarshaller();
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
        public IAsyncResult BeginGetStages(GetStagesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetStagesRequestMarshaller();
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
        public  GetStagesResponse EndGetStages(IAsyncResult asyncResult)
        {
            return EndInvoke<GetStagesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutIntegration

        /// <summary>
        /// Represents a put integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public PutIntegrationResponse PutIntegration(PutIntegrationRequest request)
        {
            var marshaller = new PutIntegrationRequestMarshaller();
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
        public IAsyncResult BeginPutIntegration(PutIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutIntegrationRequestMarshaller();
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
        public  PutIntegrationResponse EndPutIntegration(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public PutIntegrationResponseResponse PutIntegrationResponse(PutIntegrationResponseRequest request)
        {
            var marshaller = new PutIntegrationResponseRequestMarshaller();
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
        public IAsyncResult BeginPutIntegrationResponse(PutIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutIntegrationResponseRequestMarshaller();
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
        public  PutIntegrationResponseResponse EndPutIntegrationResponse(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public PutMethodResponse PutMethod(PutMethodRequest request)
        {
            var marshaller = new PutMethodRequestMarshaller();
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
        public IAsyncResult BeginPutMethod(PutMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutMethodRequestMarshaller();
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
        public  PutMethodResponse EndPutMethod(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public PutMethodResponseResponse PutMethodResponse(PutMethodResponseRequest request)
        {
            var marshaller = new PutMethodResponseRequestMarshaller();
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
        public IAsyncResult BeginPutMethodResponse(PutMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutMethodResponseRequestMarshaller();
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
        public  PutMethodResponseResponse EndPutMethodResponse(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMethodResponseResponse>(asyncResult);
        }

        #endregion
        
        #region  TestInvokeMethod

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod service method.</param>
        /// 
        /// <returns>The response from the TestInvokeMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public TestInvokeMethodResponse TestInvokeMethod(TestInvokeMethodRequest request)
        {
            var marshaller = new TestInvokeMethodRequestMarshaller();
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
        public IAsyncResult BeginTestInvokeMethod(TestInvokeMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TestInvokeMethodRequestMarshaller();
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
        public  TestInvokeMethodResponse EndTestInvokeMethod(IAsyncResult asyncResult)
        {
            return EndInvoke<TestInvokeMethodResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var marshaller = new UpdateAccountRequestMarshaller();
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
        public IAsyncResult BeginUpdateAccount(UpdateAccountRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateAccountRequestMarshaller();
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
        public  UpdateAccountResponse EndUpdateAccount(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var marshaller = new UpdateApiKeyRequestMarshaller();
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
        public IAsyncResult BeginUpdateApiKey(UpdateApiKeyRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateApiKeyRequestMarshaller();
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
        public  UpdateApiKeyResponse EndUpdateApiKey(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApiKeyResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateBasePathMappingResponse UpdateBasePathMapping(UpdateBasePathMappingRequest request)
        {
            var marshaller = new UpdateBasePathMappingRequestMarshaller();
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
        public IAsyncResult BeginUpdateBasePathMapping(UpdateBasePathMappingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateBasePathMappingRequestMarshaller();
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
        public  UpdateBasePathMappingResponse EndUpdateBasePathMapping(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBasePathMappingResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateClientCertificate

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateClientCertificateResponse UpdateClientCertificate(UpdateClientCertificateRequest request)
        {
            var marshaller = new UpdateClientCertificateRequestMarshaller();
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
        public IAsyncResult BeginUpdateClientCertificate(UpdateClientCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateClientCertificateRequestMarshaller();
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
        public  UpdateClientCertificateResponse EndUpdateClientCertificate(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var marshaller = new UpdateDeploymentRequestMarshaller();
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
        public IAsyncResult BeginUpdateDeployment(UpdateDeploymentRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDeploymentRequestMarshaller();
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
        public  UpdateDeploymentResponse EndUpdateDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeploymentResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var marshaller = new UpdateDomainNameRequestMarshaller();
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
        public IAsyncResult BeginUpdateDomainName(UpdateDomainNameRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateDomainNameRequestMarshaller();
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
        public  UpdateDomainNameResponse EndUpdateDomainName(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainNameResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var marshaller = new UpdateIntegrationRequestMarshaller();
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
        public IAsyncResult BeginUpdateIntegration(UpdateIntegrationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateIntegrationRequestMarshaller();
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
        public  UpdateIntegrationResponse EndUpdateIntegration(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var marshaller = new UpdateIntegrationResponseRequestMarshaller();
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
        public IAsyncResult BeginUpdateIntegrationResponse(UpdateIntegrationResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateIntegrationResponseRequestMarshaller();
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
        public  UpdateIntegrationResponseResponse EndUpdateIntegrationResponse(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateMethodResponse UpdateMethod(UpdateMethodRequest request)
        {
            var marshaller = new UpdateMethodRequestMarshaller();
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
        public IAsyncResult BeginUpdateMethod(UpdateMethodRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateMethodRequestMarshaller();
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
        public  UpdateMethodResponse EndUpdateMethod(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateMethodResponseResponse UpdateMethodResponse(UpdateMethodResponseRequest request)
        {
            var marshaller = new UpdateMethodResponseRequestMarshaller();
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
        public IAsyncResult BeginUpdateMethodResponse(UpdateMethodResponseRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateMethodResponseRequestMarshaller();
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
        public  UpdateMethodResponseResponse EndUpdateMethodResponse(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var marshaller = new UpdateModelRequestMarshaller();
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
        public IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateModelRequestMarshaller();
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
        public  UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateModelResponse>(asyncResult);
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var marshaller = new UpdateResourceRequestMarshaller();
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
        public IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateResourceRequestMarshaller();
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
        public  UpdateResourceResponse EndUpdateResource(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateRestApiResponse UpdateRestApi(UpdateRestApiRequest request)
        {
            var marshaller = new UpdateRestApiRequestMarshaller();
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
        public IAsyncResult BeginUpdateRestApi(UpdateRestApiRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateRestApiRequestMarshaller();
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
        public  UpdateRestApiResponse EndUpdateRestApi(IAsyncResult asyncResult)
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        public UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var marshaller = new UpdateStageRequestMarshaller();
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
        public IAsyncResult BeginUpdateStage(UpdateStageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UpdateStageRequestMarshaller();
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
        public  UpdateStageResponse EndUpdateStage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateStageResponse>(asyncResult);
        }

        #endregion
        
    }
}