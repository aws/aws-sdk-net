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


        /// <summary>
        /// Creates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApi service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;

            return Invoke<CreateApiResponse>(request, options);
        }


        /// <summary>
        /// Creates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApiMapping


        /// <summary>
        /// Creates an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;

            return Invoke<CreateApiMappingResponse>(request, options);
        }


        /// <summary>
        /// Creates an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApiMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateApiMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAuthorizer


        /// <summary>
        /// Creates an Authorizer for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerResponse>(request, options);
        }


        /// <summary>
        /// Creates an Authorizer for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Creates a Deployment for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Creates a Deployment for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainName


        /// <summary>
        /// Creates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameResponse>(request, options);
        }


        /// <summary>
        /// Creates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by ApiGatewayV2.</returns>
        /// <exception cref="Amazon.ApiGatewayV2.Model.AccessDeniedException">
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateDomainNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIntegration


        /// <summary>
        /// Creates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Creates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIntegrationResponse


        /// <summary>
        /// Creates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<CreateIntegrationResponseResponse>(request, options);
        }


        /// <summary>
        /// Creates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIntegrationResponseResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIntegrationResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Creates a Model for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelResponse>(request, options);
        }


        /// <summary>
        /// Creates a Model for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoute


        /// <summary>
        /// Creates a Route for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponse>(request, options);
        }


        /// <summary>
        /// Creates a Route for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRouteResponse


        /// <summary>
        /// Creates a RouteResponse for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponseResponse>(request, options);
        }


        /// <summary>
        /// Creates a RouteResponse for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRouteResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStage


        /// <summary>
        /// Creates a Stage for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageResponse>(request, options);
        }


        /// <summary>
        /// Creates a Stage for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStageResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcLink


        /// <summary>
        /// Creates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<CreateVpcLinkResponse>(request, options);
        }


        /// <summary>
        /// Creates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVpcLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAccessLogSettings


        /// <summary>
        /// Deletes the AccessLogSettings for a Stage. To disable access logging for a Stage,
        /// delete its AccessLogSettings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSettings service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessLogSettingsResponse>(request, options);
        }


        /// <summary>
        /// Deletes the AccessLogSettings for a Stage. To disable access logging for a Stage,
        /// delete its AccessLogSettings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessLogSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccessLogSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessLogSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAccessLogSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApi


        /// <summary>
        /// Deletes an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;

            return Invoke<DeleteApiResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApiMapping


        /// <summary>
        /// Deletes an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteApiMappingResponse>(request, options);
        }


        /// <summary>
        /// Deletes an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApiMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteApiMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAuthorizer


        /// <summary>
        /// Deletes an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCorsConfiguration


        /// <summary>
        /// Deletes a CORS configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsConfiguration service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCorsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCorsConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a CORS configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCorsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCorsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCorsConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCorsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeployment


        /// <summary>
        /// Deletes a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainName


        /// <summary>
        /// Deletes a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameResponse>(request, options);
        }


        /// <summary>
        /// Deletes a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteDomainNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Deletes an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegrationResponse


        /// <summary>
        /// Deletes an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseResponse>(request, options);
        }


        /// <summary>
        /// Deletes an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIntegrationResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoute


        /// <summary>
        /// Deletes a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteRequestParameter


        /// <summary>
        /// Deletes a route request parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteRequestParameter service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteRequestParameterResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequestParameterResponse>(request, options);
        }


        /// <summary>
        /// Deletes a route request parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteRequestParameter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestParameterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteRequestParameterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRouteRequestParameterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteResponse


        /// <summary>
        /// Deletes a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponseResponse>(request, options);
        }


        /// <summary>
        /// Deletes a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRouteResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteSettings


        /// <summary>
        /// Deletes the RouteSettings for a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteSettings service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteSettingsResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteSettingsResponse>(request, options);
        }


        /// <summary>
        /// Deletes the RouteSettings for a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRouteSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStage


        /// <summary>
        /// Deletes a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStageResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcLink


        /// <summary>
        /// Deletes a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcLinkResponse>(request, options);
        }


        /// <summary>
        /// Deletes a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVpcLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportApi


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportApi service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportApiResponseUnmarshaller.Instance;

            return Invoke<ExportApiResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportApiResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApi


        /// <summary>
        /// Gets an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApi service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;

            return Invoke<GetApiResponse>(request, options);
        }


        /// <summary>
        /// Gets an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApiMapping


        /// <summary>
        /// Gets an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingResponse>(request, options);
        }


        /// <summary>
        /// Gets an API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApiMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApiMappings


        /// <summary>
        /// Gets API mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;

            return Invoke<GetApiMappingsResponse>(request, options);
        }


        /// <summary>
        /// Gets API mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApiMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApiMappingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApiMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetApis


        /// <summary>
        /// Gets a collection of Api resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApis service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;

            return Invoke<GetApisResponse>(request, options);
        }


        /// <summary>
        /// Gets a collection of Api resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApisResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetApisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizer


        /// <summary>
        /// Gets an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerResponse>(request, options);
        }


        /// <summary>
        /// Gets an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizers


        /// <summary>
        /// Gets the Authorizers for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersResponse>(request, options);
        }


        /// <summary>
        /// Gets the Authorizers for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAuthorizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAuthorizersResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAuthorizersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeployment


        /// <summary>
        /// Gets a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Gets a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDeployments


        /// <summary>
        /// Gets the Deployments for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsResponse>(request, options);
        }


        /// <summary>
        /// Gets the Deployments for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeploymentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeploymentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDeploymentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainName


        /// <summary>
        /// Gets a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameResponse>(request, options);
        }


        /// <summary>
        /// Gets a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDomainNames


        /// <summary>
        /// Gets the domain names for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesResponse>(request, options);
        }


        /// <summary>
        /// Gets the domain names for an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDomainNamesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainNamesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDomainNamesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Gets an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Gets an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegrationResponse


        /// <summary>
        /// Gets an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseResponse>(request, options);
        }


        /// <summary>
        /// Gets an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIntegrationResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegrationResponses


        /// <summary>
        /// Gets the IntegrationResponses for an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponsesResponse>(request, options);
        }


        /// <summary>
        /// Gets the IntegrationResponses for an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationResponsesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIntegrationResponsesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetIntegrations


        /// <summary>
        /// Gets the Integrations for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationsResponse>(request, options);
        }


        /// <summary>
        /// Gets the Integrations for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIntegrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIntegrationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetIntegrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModel


        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelResponse>(request, options);
        }


        /// <summary>
        /// Gets a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModels


        /// <summary>
        /// Gets the Models for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsResponse>(request, options);
        }


        /// <summary>
        /// Gets the Models for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetModelTemplate


        /// <summary>
        /// Gets a model template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateResponse>(request, options);
        }


        /// <summary>
        /// Gets a model template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetModelTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetModelTemplateResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetModelTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRoute


        /// <summary>
        /// Gets a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoute service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponse>(request, options);
        }


        /// <summary>
        /// Gets a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRouteResponse


        /// <summary>
        /// Gets a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponseResponse>(request, options);
        }


        /// <summary>
        /// Gets a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponseResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRouteResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRouteResponses


        /// <summary>
        /// Gets the RouteResponses for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;

            return Invoke<GetRouteResponsesResponse>(request, options);
        }


        /// <summary>
        /// Gets the RouteResponses for a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteResponsesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteResponsesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRouteResponsesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRoutes


        /// <summary>
        /// Gets the Routes for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;

            return Invoke<GetRoutesResponse>(request, options);
        }


        /// <summary>
        /// Gets the Routes for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRoutesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStage


        /// <summary>
        /// Gets a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageResponse>(request, options);
        }


        /// <summary>
        /// Gets a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStageResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStages


        /// <summary>
        /// Gets the Stages for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesResponse>(request, options);
        }


        /// <summary>
        /// Gets the Stages for an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStagesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetStagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTags


        /// <summary>
        /// Gets a collection of Tag resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }


        /// <summary>
        /// Gets a collection of Tag resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVpcLink


        /// <summary>
        /// Gets a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinkResponse>(request, options);
        }


        /// <summary>
        /// Gets a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVpcLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVpcLinks


        /// <summary>
        /// Gets a collection of VPC links.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinksResponse>(request, options);
        }


        /// <summary>
        /// Gets a collection of VPC links.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVpcLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcLinksResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVpcLinksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportApi


        /// <summary>
        /// Imports an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApi service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiResponseUnmarshaller.Instance;

            return Invoke<ImportApiResponse>(request, options);
        }


        /// <summary>
        /// Imports an API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportApiResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReimportApi


        /// <summary>
        /// Puts an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReimportApi service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ReimportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReimportApiResponseUnmarshaller.Instance;

            return Invoke<ReimportApiResponse>(request, options);
        }


        /// <summary>
        /// Puts an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReimportApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ReimportApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReimportApiResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReimportApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetAuthorizersCache


        /// <summary>
        /// Resets all authorizer cache entries on a stage. Supported only for HTTP APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAuthorizersCache service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAuthorizersCacheResponseUnmarshaller.Instance;

            return Invoke<ResetAuthorizersCacheResponse>(request, options);
        }


        /// <summary>
        /// Resets all authorizer cache entries on a stage. Supported only for HTTP APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAuthorizersCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetAuthorizersCacheRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetAuthorizersCacheResponseUnmarshaller.Instance;
            
            return InvokeAsync<ResetAuthorizersCacheResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Creates a new Tag resource to represent a tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Creates a new Tag resource to represent a tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes a Tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApi


        /// <summary>
        /// Updates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;

            return Invoke<UpdateApiResponse>(request, options);
        }


        /// <summary>
        /// Updates an Api resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApiResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApiMapping


        /// <summary>
        /// The API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateApiMappingResponse>(request, options);
        }


        /// <summary>
        /// The API mapping.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApiMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApiMappingResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateApiMappingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAuthorizer


        /// <summary>
        /// Updates an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerResponse>(request, options);
        }


        /// <summary>
        /// Updates an Authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuthorizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAuthorizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeployment


        /// <summary>
        /// Updates a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentResponse>(request, options);
        }


        /// <summary>
        /// Updates a Deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainName


        /// <summary>
        /// Updates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameResponse>(request, options);
        }


        /// <summary>
        /// Updates a domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDomainNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateDomainNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegration


        /// <summary>
        /// Updates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponse>(request, options);
        }


        /// <summary>
        /// Updates an Integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateIntegrationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegrationResponse


        /// <summary>
        /// Updates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseResponse>(request, options);
        }


        /// <summary>
        /// Updates an IntegrationResponses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateIntegrationResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateModel


        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelResponse>(request, options);
        }


        /// <summary>
        /// Updates a Model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateModelResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoute


        /// <summary>
        /// Updates a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponse>(request, options);
        }


        /// <summary>
        /// Updates a Route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRouteResponse


        /// <summary>
        /// Updates a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteResponseResponse>(request, options);
        }


        /// <summary>
        /// Updates a RouteResponse.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRouteResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRouteResponseRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRouteResponseResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRouteResponseResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStage


        /// <summary>
        /// Updates a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageResponse>(request, options);
        }


        /// <summary>
        /// Updates a Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStageResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVpcLink


        /// <summary>
        /// Updates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcLinkResponse>(request, options);
        }


        /// <summary>
        /// Updates a VPC link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateVpcLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}