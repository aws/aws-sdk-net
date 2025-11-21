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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KafkaConnect.Model;
using Amazon.KafkaConnect.Model.Internal.MarshallTransformations;
using Amazon.KafkaConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.KafkaConnect
{
    /// <summary>
    /// <para>Implementation for accessing KafkaConnect</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonKafkaConnectClient : AmazonServiceClient, IAmazonKafkaConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonKafkaConnectMetadata();
        private IKafkaConnectPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKafkaConnectPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KafkaConnectPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with the credentials loaded from the application's
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
        public AmazonKafkaConnectClient()
            : base(new AmazonKafkaConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with the credentials loaded from the application's
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
        public AmazonKafkaConnectClient(RegionEndpoint region)
            : base(new AmazonKafkaConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKafkaConnectClient Configuration Object</param>
        public AmazonKafkaConnectClient(AmazonKafkaConnectConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKafkaConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonKafkaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKafkaConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKafkaConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Credentials and an
        /// AmazonKafkaConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKafkaConnectClient Configuration Object</param>
        public AmazonKafkaConnectClient(AWSCredentials credentials, AmazonKafkaConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKafkaConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKafkaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKafkaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKafkaConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKafkaConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKafkaConnectClient Configuration Object</param>
        public AmazonKafkaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKafkaConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKafkaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKafkaConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKafkaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKafkaConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKafkaConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKafkaConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKafkaConnectClient Configuration Object</param>
        public AmazonKafkaConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKafkaConnectConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKafkaConnectEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKafkaConnectAuthSchemeHandler());
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


        #region  CreateConnector


        /// <summary>
        /// Creates a connector using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual CreateConnectorResponse CreateConnector(CreateConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorResponseUnmarshaller.Instance;

            return Invoke<CreateConnectorResponse>(request, options);
        }


        /// <summary>
        /// Creates a connector using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        public virtual Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomPlugin


        /// <summary>
        /// Creates a custom plugin using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPlugin service method.</param>
        /// 
        /// <returns>The response from the CreateCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateCustomPlugin">REST API Reference for CreateCustomPlugin Operation</seealso>
        public virtual CreateCustomPluginResponse CreateCustomPlugin(CreateCustomPluginRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomPluginResponseUnmarshaller.Instance;

            return Invoke<CreateCustomPluginResponse>(request, options);
        }


        /// <summary>
        /// Creates a custom plugin using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateCustomPlugin">REST API Reference for CreateCustomPlugin Operation</seealso>
        public virtual Task<CreateCustomPluginResponse> CreateCustomPluginAsync(CreateCustomPluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomPluginResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomPluginResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkerConfiguration


        /// <summary>
        /// Creates a worker configuration using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateWorkerConfiguration">REST API Reference for CreateWorkerConfiguration Operation</seealso>
        public virtual CreateWorkerConfigurationResponse CreateWorkerConfiguration(CreateWorkerConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateWorkerConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a worker configuration using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateWorkerConfiguration">REST API Reference for CreateWorkerConfiguration Operation</seealso>
        public virtual Task<CreateWorkerConfigurationResponse> CreateWorkerConfigurationAsync(CreateWorkerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkerConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkerConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnector


        /// <summary>
        /// Deletes the specified connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectorResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        public virtual Task<DeleteConnectorResponse> DeleteConnectorAsync(DeleteConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomPlugin


        /// <summary>
        /// Deletes a custom plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPlugin service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteCustomPlugin">REST API Reference for DeleteCustomPlugin Operation</seealso>
        public virtual DeleteCustomPluginResponse DeleteCustomPlugin(DeleteCustomPluginRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomPluginResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomPluginResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteCustomPlugin">REST API Reference for DeleteCustomPlugin Operation</seealso>
        public virtual Task<DeleteCustomPluginResponse> DeleteCustomPluginAsync(DeleteCustomPluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomPluginResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomPluginResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkerConfiguration


        /// <summary>
        /// Deletes the specified worker configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteWorkerConfiguration">REST API Reference for DeleteWorkerConfiguration Operation</seealso>
        public virtual DeleteWorkerConfigurationResponse DeleteWorkerConfiguration(DeleteWorkerConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkerConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified worker configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteWorkerConfiguration">REST API Reference for DeleteWorkerConfiguration Operation</seealso>
        public virtual Task<DeleteWorkerConfigurationResponse> DeleteWorkerConfigurationAsync(DeleteWorkerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkerConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkerConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnector


        /// <summary>
        /// Returns summary information about the connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        public virtual DescribeConnectorResponse DescribeConnector(DescribeConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorResponse>(request, options);
        }


        /// <summary>
        /// Returns summary information about the connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        public virtual Task<DescribeConnectorResponse> DescribeConnectorAsync(DescribeConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectorOperation


        /// <summary>
        /// Returns information about the specified connector's operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeConnectorOperation service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnectorOperation">REST API Reference for DescribeConnectorOperation Operation</seealso>
        public virtual DescribeConnectorOperationResponse DescribeConnectorOperation(DescribeConnectorOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectorOperationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified connector's operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectorOperation service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnectorOperation">REST API Reference for DescribeConnectorOperation Operation</seealso>
        public virtual Task<DescribeConnectorOperationResponse> DescribeConnectorOperationAsync(DescribeConnectorOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConnectorOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectorOperationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeConnectorOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomPlugin


        /// <summary>
        /// A summary description of the custom plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPlugin service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeCustomPlugin">REST API Reference for DescribeCustomPlugin Operation</seealso>
        public virtual DescribeCustomPluginResponse DescribeCustomPlugin(DescribeCustomPluginRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCustomPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomPluginResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomPluginResponse>(request, options);
        }


        /// <summary>
        /// A summary description of the custom plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeCustomPlugin">REST API Reference for DescribeCustomPlugin Operation</seealso>
        public virtual Task<DescribeCustomPluginResponse> DescribeCustomPluginAsync(DescribeCustomPluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeCustomPluginRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomPluginResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCustomPluginResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkerConfiguration


        /// <summary>
        /// Returns information about a worker configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkerConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeWorkerConfiguration">REST API Reference for DescribeWorkerConfiguration Operation</seealso>
        public virtual DescribeWorkerConfigurationResponse DescribeWorkerConfiguration(DescribeWorkerConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkerConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkerConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about a worker configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeWorkerConfiguration">REST API Reference for DescribeWorkerConfiguration Operation</seealso>
        public virtual Task<DescribeWorkerConfigurationResponse> DescribeWorkerConfigurationAsync(DescribeWorkerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkerConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkerConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWorkerConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnectorOperations


        /// <summary>
        /// Lists information about a connector's operation(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorOperations service method.</param>
        /// 
        /// <returns>The response from the ListConnectorOperations service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectorOperations">REST API Reference for ListConnectorOperations Operation</seealso>
        public virtual ListConnectorOperationsResponse ListConnectorOperations(ListConnectorOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorOperationsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorOperationsResponse>(request, options);
        }


        /// <summary>
        /// Lists information about a connector's operation(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectorOperations service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectorOperations">REST API Reference for ListConnectorOperations Operation</seealso>
        public virtual Task<ListConnectorOperationsResponse> ListConnectorOperationsAsync(ListConnectorOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorOperationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConnectorOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnectors


        /// <summary>
        /// Returns a list of all the connectors in this account and Region. The list is limited
        /// to connectors whose name starts with the specified prefix. The response also includes
        /// a description of each of the listed connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual ListConnectorsResponse ListConnectors(ListConnectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;

            return Invoke<ListConnectorsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all the connectors in this account and Region. The list is limited
        /// to connectors whose name starts with the specified prefix. The response also includes
        /// a description of each of the listed connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        public virtual Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListConnectorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCustomPlugins


        /// <summary>
        /// Returns a list of all of the custom plugins in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPlugins service method.</param>
        /// 
        /// <returns>The response from the ListCustomPlugins service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListCustomPlugins">REST API Reference for ListCustomPlugins Operation</seealso>
        public virtual ListCustomPluginsResponse ListCustomPlugins(ListCustomPluginsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomPluginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomPluginsResponseUnmarshaller.Instance;

            return Invoke<ListCustomPluginsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all of the custom plugins in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPlugins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomPlugins service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListCustomPlugins">REST API Reference for ListCustomPlugins Operation</seealso>
        public virtual Task<ListCustomPluginsResponse> ListCustomPluginsAsync(ListCustomPluginsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomPluginsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomPluginsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCustomPluginsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all the tags attached to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all the tags attached to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkerConfigurations


        /// <summary>
        /// Returns a list of all of the worker configurations in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListWorkerConfigurations service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListWorkerConfigurations">REST API Reference for ListWorkerConfigurations Operation</seealso>
        public virtual ListWorkerConfigurationsResponse ListWorkerConfigurations(ListWorkerConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkerConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkerConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListWorkerConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all of the worker configurations in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkerConfigurations service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListWorkerConfigurations">REST API Reference for ListWorkerConfigurations Operation</seealso>
        public virtual Task<ListWorkerConfigurationsResponse> ListWorkerConfigurationsAsync(ListWorkerConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkerConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkerConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkerConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Attaches tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Attaches tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnector


        /// <summary>
        /// Updates the specified connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        public virtual UpdateConnectorResponse UpdateConnector(UpdateConnectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectorResponse>(request, options);
        }


        /// <summary>
        /// Updates the specified connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        public virtual Task<UpdateConnectorResponse> UpdateConnectorAsync(UpdateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateConnectorResponse>(request, options, cancellationToken);
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