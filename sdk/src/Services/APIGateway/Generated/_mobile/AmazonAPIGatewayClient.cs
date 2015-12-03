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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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

#if DNX
    
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

#endif

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

        internal CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            var marshaller = new CreateApiKeyRequestMarshaller();
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyRequest,CreateApiKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateApiKeyResponse> CreateApiKeyAsync(CreateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateApiKeyRequestMarshaller();
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiKeyRequest,CreateApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBasePathMapping

        internal CreateBasePathMappingResponse CreateBasePathMapping(CreateBasePathMappingRequest request)
        {
            var marshaller = new CreateBasePathMappingRequestMarshaller();
            var unmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<CreateBasePathMappingRequest,CreateBasePathMappingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateBasePathMappingResponse> CreateBasePathMappingAsync(CreateBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateBasePathMappingRequestMarshaller();
            var unmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBasePathMappingRequest,CreateBasePathMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment

        internal CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDeploymentRequestMarshaller();
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainName

        internal CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var marshaller = new CreateDomainNameRequestMarshaller();
            var unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameRequest,CreateDomainNameResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDomainNameResponse> CreateDomainNameAsync(CreateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDomainNameRequestMarshaller();
            var unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainNameRequest,CreateDomainNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateModel

        internal CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var marshaller = new CreateModelRequestMarshaller();
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelRequest,CreateModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateModelRequestMarshaller();
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelRequest,CreateModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResource

        internal CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var marshaller = new CreateResourceRequestMarshaller();
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceRequest,CreateResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateResourceRequestMarshaller();
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceRequest,CreateResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRestApi

        internal CreateRestApiResponse CreateRestApi(CreateRestApiRequest request)
        {
            var marshaller = new CreateRestApiRequestMarshaller();
            var unmarshaller = CreateRestApiResponseUnmarshaller.Instance;

            return Invoke<CreateRestApiRequest,CreateRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateRestApiResponse> CreateRestApiAsync(CreateRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRestApiRequestMarshaller();
            var unmarshaller = CreateRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRestApiRequest,CreateRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStage

        internal CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var marshaller = new CreateStageRequestMarshaller();
            var unmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageRequest,CreateStageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStageRequestMarshaller();
            var unmarshaller = CreateStageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStageRequest,CreateStageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApiKey

        internal DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var marshaller = new DeleteApiKeyRequestMarshaller();
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyRequest,DeleteApiKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteApiKeyRequestMarshaller();
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiKeyRequest,DeleteApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBasePathMapping

        internal DeleteBasePathMappingResponse DeleteBasePathMapping(DeleteBasePathMappingRequest request)
        {
            var marshaller = new DeleteBasePathMappingRequestMarshaller();
            var unmarshaller = DeleteBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteBasePathMappingRequest,DeleteBasePathMappingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteBasePathMappingResponse> DeleteBasePathMappingAsync(DeleteBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBasePathMappingRequestMarshaller();
            var unmarshaller = DeleteBasePathMappingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBasePathMappingRequest,DeleteBasePathMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClientCertificate

        internal DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request)
        {
            var marshaller = new DeleteClientCertificateRequestMarshaller();
            var unmarshaller = DeleteClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteClientCertificateRequest,DeleteClientCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteClientCertificateResponse> DeleteClientCertificateAsync(DeleteClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteClientCertificateRequestMarshaller();
            var unmarshaller = DeleteClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClientCertificateRequest,DeleteClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeployment

        internal DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var marshaller = new DeleteDeploymentRequestMarshaller();
            var unmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentRequest,DeleteDeploymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDeploymentRequestMarshaller();
            var unmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentRequest,DeleteDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainName

        internal DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var marshaller = new DeleteDomainNameRequestMarshaller();
            var unmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameRequest,DeleteDomainNameResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDomainNameResponse> DeleteDomainNameAsync(DeleteDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDomainNameRequestMarshaller();
            var unmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainNameRequest,DeleteDomainNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegration

        internal DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var marshaller = new DeleteIntegrationRequestMarshaller();
            var unmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationRequest,DeleteIntegrationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIntegrationRequestMarshaller();
            var unmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationRequest,DeleteIntegrationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegrationResponse

        internal DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var marshaller = new DeleteIntegrationResponseRequestMarshaller();
            var unmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseRequest,DeleteIntegrationResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteIntegrationResponseResponse> DeleteIntegrationResponseAsync(DeleteIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteIntegrationResponseRequestMarshaller();
            var unmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponseRequest,DeleteIntegrationResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMethod

        internal DeleteMethodResponse DeleteMethod(DeleteMethodRequest request)
        {
            var marshaller = new DeleteMethodRequestMarshaller();
            var unmarshaller = DeleteMethodResponseUnmarshaller.Instance;

            return Invoke<DeleteMethodRequest,DeleteMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteMethodResponse> DeleteMethodAsync(DeleteMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMethodRequestMarshaller();
            var unmarshaller = DeleteMethodResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMethodRequest,DeleteMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMethodResponse

        internal DeleteMethodResponseResponse DeleteMethodResponse(DeleteMethodResponseRequest request)
        {
            var marshaller = new DeleteMethodResponseRequestMarshaller();
            var unmarshaller = DeleteMethodResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteMethodResponseRequest,DeleteMethodResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteMethodResponseResponse> DeleteMethodResponseAsync(DeleteMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMethodResponseRequestMarshaller();
            var unmarshaller = DeleteMethodResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMethodResponseRequest,DeleteMethodResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel

        internal DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var marshaller = new DeleteModelRequestMarshaller();
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelRequest,DeleteModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteModelRequestMarshaller();
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelRequest,DeleteModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteResource

        internal DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var marshaller = new DeleteResourceRequestMarshaller();
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceRequest,DeleteResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteResourceRequestMarshaller();
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceRequest,DeleteResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRestApi

        internal DeleteRestApiResponse DeleteRestApi(DeleteRestApiRequest request)
        {
            var marshaller = new DeleteRestApiRequestMarshaller();
            var unmarshaller = DeleteRestApiResponseUnmarshaller.Instance;

            return Invoke<DeleteRestApiRequest,DeleteRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRestApiResponse> DeleteRestApiAsync(DeleteRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRestApiRequestMarshaller();
            var unmarshaller = DeleteRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRestApiRequest,DeleteRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStage

        internal DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var marshaller = new DeleteStageRequestMarshaller();
            var unmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageRequest,DeleteStageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStageRequestMarshaller();
            var unmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStageRequest,DeleteStageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  FlushStageCache

        internal FlushStageCacheResponse FlushStageCache(FlushStageCacheRequest request)
        {
            var marshaller = new FlushStageCacheRequestMarshaller();
            var unmarshaller = FlushStageCacheResponseUnmarshaller.Instance;

            return Invoke<FlushStageCacheRequest,FlushStageCacheResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<FlushStageCacheResponse> FlushStageCacheAsync(FlushStageCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new FlushStageCacheRequestMarshaller();
            var unmarshaller = FlushStageCacheResponseUnmarshaller.Instance;

            return InvokeAsync<FlushStageCacheRequest,FlushStageCacheResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateClientCertificate

        internal GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request)
        {
            var marshaller = new GenerateClientCertificateRequestMarshaller();
            var unmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;

            return Invoke<GenerateClientCertificateRequest,GenerateClientCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(GenerateClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GenerateClientCertificateRequestMarshaller();
            var unmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateClientCertificateRequest,GenerateClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccount

        internal GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var marshaller = new GetAccountRequestMarshaller();
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountRequest,GetAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetAccountRequestMarshaller();
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountRequest,GetAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApiKey

        internal GetApiKeyResponse GetApiKey(GetApiKeyRequest request)
        {
            var marshaller = new GetApiKeyRequestMarshaller();
            var unmarshaller = GetApiKeyResponseUnmarshaller.Instance;

            return Invoke<GetApiKeyRequest,GetApiKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetApiKeyResponse> GetApiKeyAsync(GetApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetApiKeyRequestMarshaller();
            var unmarshaller = GetApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiKeyRequest,GetApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApiKeys

        internal GetApiKeysResponse GetApiKeys(GetApiKeysRequest request)
        {
            var marshaller = new GetApiKeysRequestMarshaller();
            var unmarshaller = GetApiKeysResponseUnmarshaller.Instance;

            return Invoke<GetApiKeysRequest,GetApiKeysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetApiKeysResponse> GetApiKeysAsync(GetApiKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetApiKeysRequestMarshaller();
            var unmarshaller = GetApiKeysResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiKeysRequest,GetApiKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBasePathMapping

        internal GetBasePathMappingResponse GetBasePathMapping(GetBasePathMappingRequest request)
        {
            var marshaller = new GetBasePathMappingRequestMarshaller();
            var unmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<GetBasePathMappingRequest,GetBasePathMappingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBasePathMappingResponse> GetBasePathMappingAsync(GetBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBasePathMappingRequestMarshaller();
            var unmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBasePathMappingRequest,GetBasePathMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBasePathMappings

        internal GetBasePathMappingsResponse GetBasePathMappings(GetBasePathMappingsRequest request)
        {
            var marshaller = new GetBasePathMappingsRequestMarshaller();
            var unmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;

            return Invoke<GetBasePathMappingsRequest,GetBasePathMappingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetBasePathMappingsResponse> GetBasePathMappingsAsync(GetBasePathMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBasePathMappingsRequestMarshaller();
            var unmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBasePathMappingsRequest,GetBasePathMappingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetClientCertificate

        internal GetClientCertificateResponse GetClientCertificate(GetClientCertificateRequest request)
        {
            var marshaller = new GetClientCertificateRequestMarshaller();
            var unmarshaller = GetClientCertificateResponseUnmarshaller.Instance;

            return Invoke<GetClientCertificateRequest,GetClientCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetClientCertificateResponse> GetClientCertificateAsync(GetClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetClientCertificateRequestMarshaller();
            var unmarshaller = GetClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetClientCertificateRequest,GetClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetClientCertificates

        internal GetClientCertificatesResponse GetClientCertificates(GetClientCertificatesRequest request)
        {
            var marshaller = new GetClientCertificatesRequestMarshaller();
            var unmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<GetClientCertificatesRequest,GetClientCertificatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetClientCertificatesResponse> GetClientCertificatesAsync(GetClientCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetClientCertificatesRequestMarshaller();
            var unmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<GetClientCertificatesRequest,GetClientCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeployment

        internal GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var marshaller = new GetDeploymentRequestMarshaller();
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeploymentRequestMarshaller();
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeployments

        internal GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var marshaller = new GetDeploymentsRequestMarshaller();
            var unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsRequest,GetDeploymentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDeploymentsRequestMarshaller();
            var unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentsRequest,GetDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDomainName

        internal GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var marshaller = new GetDomainNameRequestMarshaller();
            var unmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameRequest,GetDomainNameResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDomainNameResponse> GetDomainNameAsync(GetDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDomainNameRequestMarshaller();
            var unmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNameRequest,GetDomainNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDomainNames

        internal GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var marshaller = new GetDomainNamesRequestMarshaller();
            var unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesRequest,GetDomainNamesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetDomainNamesResponse> GetDomainNamesAsync(GetDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDomainNamesRequestMarshaller();
            var unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNamesRequest,GetDomainNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIntegration

        internal GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var marshaller = new GetIntegrationRequestMarshaller();
            var unmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationRequest,GetIntegrationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIntegrationRequestMarshaller();
            var unmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationRequest,GetIntegrationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIntegrationResponse

        internal GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var marshaller = new GetIntegrationResponseRequestMarshaller();
            var unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseRequest,GetIntegrationResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetIntegrationResponseResponse> GetIntegrationResponseAsync(GetIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetIntegrationResponseRequestMarshaller();
            var unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponseRequest,GetIntegrationResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMethod

        internal GetMethodResponse GetMethod(GetMethodRequest request)
        {
            var marshaller = new GetMethodRequestMarshaller();
            var unmarshaller = GetMethodResponseUnmarshaller.Instance;

            return Invoke<GetMethodRequest,GetMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetMethodResponse> GetMethodAsync(GetMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMethodRequestMarshaller();
            var unmarshaller = GetMethodResponseUnmarshaller.Instance;

            return InvokeAsync<GetMethodRequest,GetMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMethodResponse

        internal GetMethodResponseResponse GetMethodResponse(GetMethodResponseRequest request)
        {
            var marshaller = new GetMethodResponseRequestMarshaller();
            var unmarshaller = GetMethodResponseResponseUnmarshaller.Instance;

            return Invoke<GetMethodResponseRequest,GetMethodResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetMethodResponseResponse> GetMethodResponseAsync(GetMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMethodResponseRequestMarshaller();
            var unmarshaller = GetMethodResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetMethodResponseRequest,GetMethodResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetModel

        internal GetModelResponse GetModel(GetModelRequest request)
        {
            var marshaller = new GetModelRequestMarshaller();
            var unmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelRequest,GetModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetModelResponse> GetModelAsync(GetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetModelRequestMarshaller();
            var unmarshaller = GetModelResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelRequest,GetModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetModels

        internal GetModelsResponse GetModels(GetModelsRequest request)
        {
            var marshaller = new GetModelsRequestMarshaller();
            var unmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsRequest,GetModelsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetModelsResponse> GetModelsAsync(GetModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetModelsRequestMarshaller();
            var unmarshaller = GetModelsResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelsRequest,GetModelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetModelTemplate

        internal GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var marshaller = new GetModelTemplateRequestMarshaller();
            var unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateRequest,GetModelTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetModelTemplateResponse> GetModelTemplateAsync(GetModelTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetModelTemplateRequestMarshaller();
            var unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelTemplateRequest,GetModelTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResource

        internal GetResourceResponse GetResource(GetResourceRequest request)
        {
            var marshaller = new GetResourceRequestMarshaller();
            var unmarshaller = GetResourceResponseUnmarshaller.Instance;

            return Invoke<GetResourceRequest,GetResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetResourceResponse> GetResourceAsync(GetResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetResourceRequestMarshaller();
            var unmarshaller = GetResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceRequest,GetResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResources

        internal GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var marshaller = new GetResourcesRequestMarshaller();
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return Invoke<GetResourcesRequest,GetResourcesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetResourcesRequestMarshaller();
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcesRequest,GetResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRestApi

        internal GetRestApiResponse GetRestApi(GetRestApiRequest request)
        {
            var marshaller = new GetRestApiRequestMarshaller();
            var unmarshaller = GetRestApiResponseUnmarshaller.Instance;

            return Invoke<GetRestApiRequest,GetRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetRestApiResponse> GetRestApiAsync(GetRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRestApiRequestMarshaller();
            var unmarshaller = GetRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetRestApiRequest,GetRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRestApis

        internal GetRestApisResponse GetRestApis(GetRestApisRequest request)
        {
            var marshaller = new GetRestApisRequestMarshaller();
            var unmarshaller = GetRestApisResponseUnmarshaller.Instance;

            return Invoke<GetRestApisRequest,GetRestApisResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetRestApisResponse> GetRestApisAsync(GetRestApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetRestApisRequestMarshaller();
            var unmarshaller = GetRestApisResponseUnmarshaller.Instance;

            return InvokeAsync<GetRestApisRequest,GetRestApisResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSdk

        internal GetSdkResponse GetSdk(GetSdkRequest request)
        {
            var marshaller = new GetSdkRequestMarshaller();
            var unmarshaller = GetSdkResponseUnmarshaller.Instance;

            return Invoke<GetSdkRequest,GetSdkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSdk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdk operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetSdkResponse> GetSdkAsync(GetSdkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSdkRequestMarshaller();
            var unmarshaller = GetSdkResponseUnmarshaller.Instance;

            return InvokeAsync<GetSdkRequest,GetSdkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStage

        internal GetStageResponse GetStage(GetStageRequest request)
        {
            var marshaller = new GetStageRequestMarshaller();
            var unmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageRequest,GetStageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStageRequestMarshaller();
            var unmarshaller = GetStageResponseUnmarshaller.Instance;

            return InvokeAsync<GetStageRequest,GetStageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStages

        internal GetStagesResponse GetStages(GetStagesRequest request)
        {
            var marshaller = new GetStagesRequestMarshaller();
            var unmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesRequest,GetStagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetStagesResponse> GetStagesAsync(GetStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStagesRequestMarshaller();
            var unmarshaller = GetStagesResponseUnmarshaller.Instance;

            return InvokeAsync<GetStagesRequest,GetStagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutIntegration

        internal PutIntegrationResponse PutIntegration(PutIntegrationRequest request)
        {
            var marshaller = new PutIntegrationRequestMarshaller();
            var unmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationRequest,PutIntegrationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutIntegrationResponse> PutIntegrationAsync(PutIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutIntegrationRequestMarshaller();
            var unmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<PutIntegrationRequest,PutIntegrationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutIntegrationResponse

        internal PutIntegrationResponseResponse PutIntegrationResponse(PutIntegrationResponseRequest request)
        {
            var marshaller = new PutIntegrationResponseRequestMarshaller();
            var unmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationResponseRequest,PutIntegrationResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutIntegrationResponseResponse> PutIntegrationResponseAsync(PutIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutIntegrationResponseRequestMarshaller();
            var unmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<PutIntegrationResponseRequest,PutIntegrationResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMethod

        internal PutMethodResponse PutMethod(PutMethodRequest request)
        {
            var marshaller = new PutMethodRequestMarshaller();
            var unmarshaller = PutMethodResponseUnmarshaller.Instance;

            return Invoke<PutMethodRequest,PutMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutMethodResponse> PutMethodAsync(PutMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMethodRequestMarshaller();
            var unmarshaller = PutMethodResponseUnmarshaller.Instance;

            return InvokeAsync<PutMethodRequest,PutMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMethodResponse

        internal PutMethodResponseResponse PutMethodResponse(PutMethodResponseRequest request)
        {
            var marshaller = new PutMethodResponseRequestMarshaller();
            var unmarshaller = PutMethodResponseResponseUnmarshaller.Instance;

            return Invoke<PutMethodResponseRequest,PutMethodResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutMethodResponseResponse> PutMethodResponseAsync(PutMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMethodResponseRequestMarshaller();
            var unmarshaller = PutMethodResponseResponseUnmarshaller.Instance;

            return InvokeAsync<PutMethodResponseRequest,PutMethodResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestInvokeMethod

        internal TestInvokeMethodResponse TestInvokeMethod(TestInvokeMethodRequest request)
        {
            var marshaller = new TestInvokeMethodRequestMarshaller();
            var unmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;

            return Invoke<TestInvokeMethodRequest,TestInvokeMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<TestInvokeMethodResponse> TestInvokeMethodAsync(TestInvokeMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TestInvokeMethodRequestMarshaller();
            var unmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;

            return InvokeAsync<TestInvokeMethodRequest,TestInvokeMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccount

        internal UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var marshaller = new UpdateAccountRequestMarshaller();
            var unmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountRequest,UpdateAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAccountRequestMarshaller();
            var unmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountRequest,UpdateAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApiKey

        internal UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var marshaller = new UpdateApiKeyRequestMarshaller();
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyRequest,UpdateApiKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateApiKeyResponse> UpdateApiKeyAsync(UpdateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateApiKeyRequestMarshaller();
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiKeyRequest,UpdateApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateBasePathMapping

        internal UpdateBasePathMappingResponse UpdateBasePathMapping(UpdateBasePathMappingRequest request)
        {
            var marshaller = new UpdateBasePathMappingRequestMarshaller();
            var unmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateBasePathMappingRequest,UpdateBasePathMappingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateBasePathMappingResponse> UpdateBasePathMappingAsync(UpdateBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateBasePathMappingRequestMarshaller();
            var unmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBasePathMappingRequest,UpdateBasePathMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateClientCertificate

        internal UpdateClientCertificateResponse UpdateClientCertificate(UpdateClientCertificateRequest request)
        {
            var marshaller = new UpdateClientCertificateRequestMarshaller();
            var unmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateClientCertificateRequest,UpdateClientCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateClientCertificateResponse> UpdateClientCertificateAsync(UpdateClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateClientCertificateRequestMarshaller();
            var unmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClientCertificateRequest,UpdateClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeployment

        internal UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var marshaller = new UpdateDeploymentRequestMarshaller();
            var unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentRequest,UpdateDeploymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateDeploymentResponse> UpdateDeploymentAsync(UpdateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDeploymentRequestMarshaller();
            var unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeploymentRequest,UpdateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainName

        internal UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var marshaller = new UpdateDomainNameRequestMarshaller();
            var unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameRequest,UpdateDomainNameResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateDomainNameResponse> UpdateDomainNameAsync(UpdateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateDomainNameRequestMarshaller();
            var unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainNameRequest,UpdateDomainNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegration

        internal UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var marshaller = new UpdateIntegrationRequestMarshaller();
            var unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationRequest,UpdateIntegrationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateIntegrationRequestMarshaller();
            var unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationRequest,UpdateIntegrationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegrationResponse

        internal UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var marshaller = new UpdateIntegrationResponseRequestMarshaller();
            var unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseRequest,UpdateIntegrationResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateIntegrationResponseResponse> UpdateIntegrationResponseAsync(UpdateIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateIntegrationResponseRequestMarshaller();
            var unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationResponseRequest,UpdateIntegrationResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMethod

        internal UpdateMethodResponse UpdateMethod(UpdateMethodRequest request)
        {
            var marshaller = new UpdateMethodRequestMarshaller();
            var unmarshaller = UpdateMethodResponseUnmarshaller.Instance;

            return Invoke<UpdateMethodRequest,UpdateMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateMethodResponse> UpdateMethodAsync(UpdateMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMethodRequestMarshaller();
            var unmarshaller = UpdateMethodResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMethodRequest,UpdateMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMethodResponse

        internal UpdateMethodResponseResponse UpdateMethodResponse(UpdateMethodResponseRequest request)
        {
            var marshaller = new UpdateMethodResponseRequestMarshaller();
            var unmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateMethodResponseRequest,UpdateMethodResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateMethodResponseResponse> UpdateMethodResponseAsync(UpdateMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateMethodResponseRequestMarshaller();
            var unmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMethodResponseRequest,UpdateMethodResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateModel

        internal UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var marshaller = new UpdateModelRequestMarshaller();
            var unmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelRequest,UpdateModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateModelRequestMarshaller();
            var unmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateModelRequest,UpdateModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateResource

        internal UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var marshaller = new UpdateResourceRequestMarshaller();
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceRequest,UpdateResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateResourceRequestMarshaller();
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceRequest,UpdateResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRestApi

        internal UpdateRestApiResponse UpdateRestApi(UpdateRestApiRequest request)
        {
            var marshaller = new UpdateRestApiRequestMarshaller();
            var unmarshaller = UpdateRestApiResponseUnmarshaller.Instance;

            return Invoke<UpdateRestApiRequest,UpdateRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateRestApiResponse> UpdateRestApiAsync(UpdateRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateRestApiRequestMarshaller();
            var unmarshaller = UpdateRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRestApiRequest,UpdateRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStage

        internal UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var marshaller = new UpdateStageRequestMarshaller();
            var unmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageRequest,UpdateStageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStageRequestMarshaller();
            var unmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStageRequest,UpdateStageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}