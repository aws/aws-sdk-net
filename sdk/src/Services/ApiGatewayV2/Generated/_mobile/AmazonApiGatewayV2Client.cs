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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
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

namespace Amazon.ApiGatewayV2
{
    /// <summary>
    /// Implementation for accessing ApiGatewayV2
    ///
    /// Amazon API Gateway V2
    /// </summary>
    public partial class AmazonApiGatewayV2Client : AmazonServiceClient, IAmazonApiGatewayV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonApiGatewayV2Metadata();
        
        #region Constructors

#if CORECLR
    
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
        public AmazonApiGatewayV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApiGatewayV2Config()) { }

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
        public AmazonApiGatewayV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApiGatewayV2Config{RegionEndpoint = region}) { }

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
        public AmazonApiGatewayV2Client(AmazonApiGatewayV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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
            : this(credentials, new AmazonApiGatewayV2Config{RegionEndpoint = region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApiGatewayV2Config() {RegionEndpoint=region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApiGatewayV2Config{RegionEndpoint = region})
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


        #region  CreateApi

        internal virtual CreateApiResponse CreateApi(CreateApiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return Invoke<CreateApiResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateApiResponse> CreateApiAsync(CreateApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApiMapping

        internal virtual CreateApiMappingResponse CreateApiMapping(CreateApiMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return Invoke<CreateApiMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateApiMappingResponse> CreateApiMappingAsync(CreateApiMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAuthorizer

        internal virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateAuthorizerResponse> CreateAuthorizerAsync(CreateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
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
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainName

        internal virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameResponse>(request, options);
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
        public virtual Task<CreateDomainNameResponse> CreateDomainNameAsync(CreateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIntegration

        internal virtual CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIntegrationResponse

        internal virtual CreateIntegrationResponseResponse CreateIntegrationResponse(CreateIntegrationResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateIntegrationResponseResponse> CreateIntegrationResponseAsync(CreateIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIntegrationResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModel

        internal virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
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
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoute

        internal virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRouteResponse

        internal virtual CreateRouteResponseResponse CreateRouteResponse(CreateRouteResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateRouteResponseResponse> CreateRouteResponseAsync(CreateRouteResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStage

        internal virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
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
        public virtual Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApi

        internal virtual DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return Invoke<DeleteApiResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApiResponse> DeleteApiAsync(DeleteApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApiMapping

        internal virtual DeleteApiMappingResponse DeleteApiMapping(DeleteApiMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteApiMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApiMappingResponse> DeleteApiMappingAsync(DeleteApiMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAuthorizer

        internal virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteAuthorizerResponse> DeleteAuthorizerAsync(DeleteAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeployment

        internal virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
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
        public virtual Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainName

        internal virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameResponse>(request, options);
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
        public virtual Task<DeleteDomainNameResponse> DeleteDomainNameAsync(DeleteDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegration

        internal virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
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
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegrationResponse

        internal virtual DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseResponse>(request, options);
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
        public virtual Task<DeleteIntegrationResponseResponse> DeleteIntegrationResponseAsync(DeleteIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel

        internal virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
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
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoute

        internal virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteResponse

        internal virtual DeleteRouteResponseResponse DeleteRouteResponse(DeleteRouteResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteRouteResponseResponse> DeleteRouteResponseAsync(DeleteRouteResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStage

        internal virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
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
        public virtual Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApi

        internal virtual GetApiResponse GetApi(GetApiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return Invoke<GetApiResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApiResponse> GetApiAsync(GetApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApiMapping

        internal virtual GetApiMappingResponse GetApiMapping(GetApiMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApiMappingResponse> GetApiMappingAsync(GetApiMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApiMappings

        internal virtual GetApiMappingsResponse GetApiMappings(GetApiMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApiMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApiMappingsResponse> GetApiMappingsAsync(GetApiMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApis

        internal virtual GetApisResponse GetApis(GetApisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;

            return Invoke<GetApisResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApis operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApisResponse> GetApisAsync(GetApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;

            return InvokeAsync<GetApisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizer

        internal virtual GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAuthorizerResponse> GetAuthorizerAsync(GetAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<GetAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizers

        internal virtual GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAuthorizersResponse> GetAuthorizersAsync(GetAuthorizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return InvokeAsync<GetAuthorizersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeployment

        internal virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
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
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeployments

        internal virtual GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsResponse>(request, options);
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
        public virtual Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainName

        internal virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameResponse>(request, options);
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
        public virtual Task<GetDomainNameResponse> GetDomainNameAsync(GetDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainNames

        internal virtual GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesResponse>(request, options);
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
        public virtual Task<GetDomainNamesResponse> GetDomainNamesAsync(GetDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegration

        internal virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
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
        public virtual Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegrationResponse

        internal virtual GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseResponse>(request, options);
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
        public virtual Task<GetIntegrationResponseResponse> GetIntegrationResponseAsync(GetIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegrationResponses

        internal virtual GetIntegrationResponsesResponse GetIntegrationResponses(GetIntegrationResponsesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponsesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetIntegrationResponsesResponse> GetIntegrationResponsesAsync(GetIntegrationResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponsesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegrations

        internal virtual GetIntegrationsResponse GetIntegrations(GetIntegrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetIntegrationsResponse> GetIntegrationsAsync(GetIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModel

        internal virtual GetModelResponse GetModel(GetModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelResponse>(request, options);
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
        public virtual Task<GetModelResponse> GetModelAsync(GetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModels

        internal virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
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
        public virtual Task<GetModelsResponse> GetModelsAsync(GetModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelTemplate

        internal virtual GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateResponse>(request, options);
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
        public virtual Task<GetModelTemplateResponse> GetModelTemplateAsync(GetModelTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRoute

        internal virtual GetRouteResponse GetRoute(GetRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetRouteResponse> GetRouteAsync(GetRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;

            return InvokeAsync<GetRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRouteResponse

        internal virtual GetRouteResponseResponse GetRouteResponse(GetRouteResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetRouteResponseResponse> GetRouteResponseAsync(GetRouteResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetRouteResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRouteResponses

        internal virtual GetRouteResponsesResponse GetRouteResponses(GetRouteResponsesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponsesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRouteResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetRouteResponsesResponse> GetRouteResponsesAsync(GetRouteResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRouteResponsesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRoutes

        internal virtual GetRoutesResponse GetRoutes(GetRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return Invoke<GetRoutesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetRoutesResponse> GetRoutesAsync(GetRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStage

        internal virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
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
        public virtual Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return InvokeAsync<GetStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStages

        internal virtual GetStagesResponse GetStages(GetStagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesResponse>(request, options);
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
        public virtual Task<GetStagesResponse> GetStagesAsync(GetStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return InvokeAsync<GetStagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApi

        internal virtual UpdateApiResponse UpdateApi(UpdateApiRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return Invoke<UpdateApiResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApiResponse> UpdateApiAsync(UpdateApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApiMapping

        internal virtual UpdateApiMappingResponse UpdateApiMapping(UpdateApiMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateApiMappingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApiMappingResponse> UpdateApiMappingAsync(UpdateApiMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAuthorizer

        internal virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateAuthorizerResponse> UpdateAuthorizerAsync(UpdateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeployment

        internal virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentResponse>(request, options);
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
        public virtual Task<UpdateDeploymentResponse> UpdateDeploymentAsync(UpdateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainName

        internal virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameResponse>(request, options);
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
        public virtual Task<UpdateDomainNameResponse> UpdateDomainNameAsync(UpdateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegration

        internal virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
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
        public virtual Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegrationResponse

        internal virtual UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseResponse>(request, options);
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
        public virtual Task<UpdateIntegrationResponseResponse> UpdateIntegrationResponseAsync(UpdateIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateModel

        internal virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
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
        public virtual Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoute

        internal virtual UpdateRouteResponse UpdateRoute(UpdateRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateRouteResponse> UpdateRouteAsync(UpdateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRouteResponse

        internal virtual UpdateRouteResponseResponse UpdateRouteResponse(UpdateRouteResponseRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponseResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRouteResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateRouteResponseResponse> UpdateRouteResponseAsync(UpdateRouteResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRouteResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStage

        internal virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
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
        public virtual Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}