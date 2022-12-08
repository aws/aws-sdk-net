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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTTwinMaker.Model;
using Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations;
using Amazon.IoTTwinMaker.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTTwinMaker
{
    /// <summary>
    /// Implementation for accessing IoTTwinMaker
    ///
    /// IoT TwinMaker is a service that enables you to build operational digital twins of
    /// physical systems. IoT TwinMaker overlays measurements and analysis from real-world
    /// sensors, cameras, and enterprise applications so you can create data visualizations
    /// to monitor your physical factory, building, or industrial plant. You can use this
    /// real-world data to monitor operations and diagnose and repair errors.
    /// </summary>
    public partial class AmazonIoTTwinMakerClient : AmazonServiceClient, IAmazonIoTTwinMaker
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTTwinMakerMetadata();
        private IIoTTwinMakerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTTwinMakerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTTwinMakerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with the credentials loaded from the application's
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
        public AmazonIoTTwinMakerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTTwinMakerConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with the credentials loaded from the application's
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
        public AmazonIoTTwinMakerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTTwinMakerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTTwinMakerClient Configuration Object</param>
        public AmazonIoTTwinMakerClient(AmazonIoTTwinMakerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTTwinMakerClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTTwinMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTTwinMakerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTTwinMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Credentials and an
        /// AmazonIoTTwinMakerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTTwinMakerClient Configuration Object</param>
        public AmazonIoTTwinMakerClient(AWSCredentials credentials, AmazonIoTTwinMakerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTTwinMakerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTTwinMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTTwinMakerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTTwinMakerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTTwinMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTTwinMakerClient Configuration Object</param>
        public AmazonIoTTwinMakerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTTwinMakerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTTwinMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTTwinMakerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTTwinMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTTwinMakerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTTwinMakerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTTwinMakerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTTwinMakerClient Configuration Object</param>
        public AmazonIoTTwinMakerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTTwinMakerConfig clientConfig)
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTTwinMakerEndpointResolver());
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


        #region  BatchPutPropertyValues


        /// <summary>
        /// Sets values for multiple time series properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutPropertyValues service method.</param>
        /// 
        /// <returns>The response from the BatchPutPropertyValues service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/BatchPutPropertyValues">REST API Reference for BatchPutPropertyValues Operation</seealso>
        public virtual BatchPutPropertyValuesResponse BatchPutPropertyValues(BatchPutPropertyValuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutPropertyValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutPropertyValuesResponseUnmarshaller.Instance;

            return Invoke<BatchPutPropertyValuesResponse>(request, options);
        }


        /// <summary>
        /// Sets values for multiple time series properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutPropertyValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutPropertyValues service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/BatchPutPropertyValues">REST API Reference for BatchPutPropertyValues Operation</seealso>
        public virtual Task<BatchPutPropertyValuesResponse> BatchPutPropertyValuesAsync(BatchPutPropertyValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutPropertyValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutPropertyValuesResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchPutPropertyValuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateComponentType


        /// <summary>
        /// Creates a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentType service method.</param>
        /// 
        /// <returns>The response from the CreateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateComponentType">REST API Reference for CreateComponentType Operation</seealso>
        public virtual CreateComponentTypeResponse CreateComponentType(CreateComponentTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentTypeResponseUnmarshaller.Instance;

            return Invoke<CreateComponentTypeResponse>(request, options);
        }


        /// <summary>
        /// Creates a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateComponentType">REST API Reference for CreateComponentType Operation</seealso>
        public virtual Task<CreateComponentTypeResponse> CreateComponentTypeAsync(CreateComponentTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateComponentTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEntity


        /// <summary>
        /// Creates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntity service method.</param>
        /// 
        /// <returns>The response from the CreateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateEntity">REST API Reference for CreateEntity Operation</seealso>
        public virtual CreateEntityResponse CreateEntity(CreateEntityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntityResponseUnmarshaller.Instance;

            return Invoke<CreateEntityResponse>(request, options);
        }


        /// <summary>
        /// Creates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateEntity">REST API Reference for CreateEntity Operation</seealso>
        public virtual Task<CreateEntityResponse> CreateEntityAsync(CreateEntityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntityResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEntityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateScene


        /// <summary>
        /// Creates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScene service method.</param>
        /// 
        /// <returns>The response from the CreateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateScene">REST API Reference for CreateScene Operation</seealso>
        public virtual CreateSceneResponse CreateScene(CreateSceneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSceneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSceneResponseUnmarshaller.Instance;

            return Invoke<CreateSceneResponse>(request, options);
        }


        /// <summary>
        /// Creates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScene service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateScene">REST API Reference for CreateScene Operation</seealso>
        public virtual Task<CreateSceneResponse> CreateSceneAsync(CreateSceneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSceneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSceneResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSceneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSyncJob


        /// <summary>
        /// This action creates a SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSyncJob service method.</param>
        /// 
        /// <returns>The response from the CreateSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateSyncJob">REST API Reference for CreateSyncJob Operation</seealso>
        public virtual CreateSyncJobResponse CreateSyncJob(CreateSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSyncJobResponseUnmarshaller.Instance;

            return Invoke<CreateSyncJobResponse>(request, options);
        }


        /// <summary>
        /// This action creates a SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateSyncJob">REST API Reference for CreateSyncJob Operation</seealso>
        public virtual Task<CreateSyncJobResponse> CreateSyncJobAsync(CreateSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSyncJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSyncJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkspace


        /// <summary>
        /// Creates a workplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        public virtual CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceResponse>(request, options);
        }


        /// <summary>
        /// Creates a workplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        public virtual Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteComponentType


        /// <summary>
        /// Deletes a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponentType service method.</param>
        /// 
        /// <returns>The response from the DeleteComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteComponentType">REST API Reference for DeleteComponentType Operation</seealso>
        public virtual DeleteComponentTypeResponse DeleteComponentType(DeleteComponentTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentTypeResponse>(request, options);
        }


        /// <summary>
        /// Deletes a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteComponentType">REST API Reference for DeleteComponentType Operation</seealso>
        public virtual Task<DeleteComponentTypeResponse> DeleteComponentTypeAsync(DeleteComponentTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteComponentTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEntity


        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntity service method.</param>
        /// 
        /// <returns>The response from the DeleteEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteEntity">REST API Reference for DeleteEntity Operation</seealso>
        public virtual DeleteEntityResponse DeleteEntity(DeleteEntityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityResponseUnmarshaller.Instance;

            return Invoke<DeleteEntityResponse>(request, options);
        }


        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteEntity">REST API Reference for DeleteEntity Operation</seealso>
        public virtual Task<DeleteEntityResponse> DeleteEntityAsync(DeleteEntityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEntityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScene


        /// <summary>
        /// Deletes a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScene service method.</param>
        /// 
        /// <returns>The response from the DeleteScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteScene">REST API Reference for DeleteScene Operation</seealso>
        public virtual DeleteSceneResponse DeleteScene(DeleteSceneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSceneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSceneResponseUnmarshaller.Instance;

            return Invoke<DeleteSceneResponse>(request, options);
        }


        /// <summary>
        /// Deletes a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScene service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteScene">REST API Reference for DeleteScene Operation</seealso>
        public virtual Task<DeleteSceneResponse> DeleteSceneAsync(DeleteSceneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSceneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSceneResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSceneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSyncJob


        /// <summary>
        /// Delete the SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSyncJob service method.</param>
        /// 
        /// <returns>The response from the DeleteSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteSyncJob">REST API Reference for DeleteSyncJob Operation</seealso>
        public virtual DeleteSyncJobResponse DeleteSyncJob(DeleteSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSyncJobResponseUnmarshaller.Instance;

            return Invoke<DeleteSyncJobResponse>(request, options);
        }


        /// <summary>
        /// Delete the SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteSyncJob">REST API Reference for DeleteSyncJob Operation</seealso>
        public virtual Task<DeleteSyncJobResponse> DeleteSyncJobAsync(DeleteSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSyncJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSyncJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkspace


        /// <summary>
        /// Deletes a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        public virtual DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceResponse>(request, options);
        }


        /// <summary>
        /// Deletes a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        public virtual Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteQuery


        /// <summary>
        /// Run queries to access information from your knowledge graph of entities within individual
        /// workspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.QueryTimeoutException">
        /// The query timeout exception.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual ExecuteQueryResponse ExecuteQuery(ExecuteQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteQueryResponse>(request, options);
        }


        /// <summary>
        /// Run queries to access information from your knowledge graph of entities within individual
        /// workspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.QueryTimeoutException">
        /// The query timeout exception.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual Task<ExecuteQueryResponse> ExecuteQueryAsync(ExecuteQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComponentType


        /// <summary>
        /// Retrieves information about a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentType service method.</param>
        /// 
        /// <returns>The response from the GetComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetComponentType">REST API Reference for GetComponentType Operation</seealso>
        public virtual GetComponentTypeResponse GetComponentType(GetComponentTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentTypeResponseUnmarshaller.Instance;

            return Invoke<GetComponentTypeResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetComponentType">REST API Reference for GetComponentType Operation</seealso>
        public virtual Task<GetComponentTypeResponse> GetComponentTypeAsync(GetComponentTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetComponentTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEntity


        /// <summary>
        /// Retrieves information about an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntity service method.</param>
        /// 
        /// <returns>The response from the GetEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetEntity">REST API Reference for GetEntity Operation</seealso>
        public virtual GetEntityResponse GetEntity(GetEntityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntityResponseUnmarshaller.Instance;

            return Invoke<GetEntityResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetEntity">REST API Reference for GetEntity Operation</seealso>
        public virtual Task<GetEntityResponse> GetEntityAsync(GetEntityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntityResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetEntityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPricingPlan


        /// <summary>
        /// Gets the pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPricingPlan service method.</param>
        /// 
        /// <returns>The response from the GetPricingPlan service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPricingPlan">REST API Reference for GetPricingPlan Operation</seealso>
        public virtual GetPricingPlanResponse GetPricingPlan(GetPricingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPricingPlanResponseUnmarshaller.Instance;

            return Invoke<GetPricingPlanResponse>(request, options);
        }


        /// <summary>
        /// Gets the pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPricingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPricingPlan service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPricingPlan">REST API Reference for GetPricingPlan Operation</seealso>
        public virtual Task<GetPricingPlanResponse> GetPricingPlanAsync(GetPricingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPricingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPricingPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPropertyValue


        /// <summary>
        /// Gets the property values for a component, component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for either <code>componentName</code>, <code>componentTypeId</code>,
        /// <code>entityId</code>, or <code>workspaceId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValue service method.</param>
        /// 
        /// <returns>The response from the GetPropertyValue service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValue">REST API Reference for GetPropertyValue Operation</seealso>
        public virtual GetPropertyValueResponse GetPropertyValue(GetPropertyValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertyValueResponseUnmarshaller.Instance;

            return Invoke<GetPropertyValueResponse>(request, options);
        }


        /// <summary>
        /// Gets the property values for a component, component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for either <code>componentName</code>, <code>componentTypeId</code>,
        /// <code>entityId</code>, or <code>workspaceId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertyValue service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValue">REST API Reference for GetPropertyValue Operation</seealso>
        public virtual Task<GetPropertyValueResponse> GetPropertyValueAsync(GetPropertyValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertyValueResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPropertyValueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPropertyValueHistory


        /// <summary>
        /// Retrieves information about the history of a time series property value for a component,
        /// component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for <code>workspaceId</code>. For entity-specific queries,
        /// specify values for <code>componentName</code> and <code>entityId</code>. For cross-entity
        /// quries, specify a value for <code>componentTypeId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValueHistory service method.</param>
        /// 
        /// <returns>The response from the GetPropertyValueHistory service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValueHistory">REST API Reference for GetPropertyValueHistory Operation</seealso>
        public virtual GetPropertyValueHistoryResponse GetPropertyValueHistory(GetPropertyValueHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertyValueHistoryResponseUnmarshaller.Instance;

            return Invoke<GetPropertyValueHistoryResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about the history of a time series property value for a component,
        /// component type, entity, or workspace.
        /// 
        ///  
        /// <para>
        /// You must specify a value for <code>workspaceId</code>. For entity-specific queries,
        /// specify values for <code>componentName</code> and <code>entityId</code>. For cross-entity
        /// quries, specify a value for <code>componentTypeId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertyValueHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertyValueHistory service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorFailureException">
        /// The connector failed.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConnectorTimeoutException">
        /// The connector timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetPropertyValueHistory">REST API Reference for GetPropertyValueHistory Operation</seealso>
        public virtual Task<GetPropertyValueHistoryResponse> GetPropertyValueHistoryAsync(GetPropertyValueHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPropertyValueHistoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPropertyValueHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetScene


        /// <summary>
        /// Retrieves information about a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScene service method.</param>
        /// 
        /// <returns>The response from the GetScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetScene">REST API Reference for GetScene Operation</seealso>
        public virtual GetSceneResponse GetScene(GetSceneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSceneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSceneResponseUnmarshaller.Instance;

            return Invoke<GetSceneResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScene service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetScene">REST API Reference for GetScene Operation</seealso>
        public virtual Task<GetSceneResponse> GetSceneAsync(GetSceneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSceneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSceneResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSceneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSyncJob


        /// <summary>
        /// Gets the SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncJob service method.</param>
        /// 
        /// <returns>The response from the GetSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetSyncJob">REST API Reference for GetSyncJob Operation</seealso>
        public virtual GetSyncJobResponse GetSyncJob(GetSyncJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSyncJobResponseUnmarshaller.Instance;

            return Invoke<GetSyncJobResponse>(request, options);
        }


        /// <summary>
        /// Gets the SyncJob.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSyncJob service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetSyncJob">REST API Reference for GetSyncJob Operation</seealso>
        public virtual Task<GetSyncJobResponse> GetSyncJobAsync(GetSyncJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSyncJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSyncJobResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetSyncJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkspace


        /// <summary>
        /// Retrieves information about a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspace service method.</param>
        /// 
        /// <returns>The response from the GetWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetWorkspace">REST API Reference for GetWorkspace Operation</seealso>
        public virtual GetWorkspaceResponse GetWorkspace(GetWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkspaceResponseUnmarshaller.Instance;

            return Invoke<GetWorkspaceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/GetWorkspace">REST API Reference for GetWorkspace Operation</seealso>
        public virtual Task<GetWorkspaceResponse> GetWorkspaceAsync(GetWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkspaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComponentTypes


        /// <summary>
        /// Lists all component types in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentTypes service method.</param>
        /// 
        /// <returns>The response from the ListComponentTypes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListComponentTypes">REST API Reference for ListComponentTypes Operation</seealso>
        public virtual ListComponentTypesResponse ListComponentTypes(ListComponentTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentTypesResponseUnmarshaller.Instance;

            return Invoke<ListComponentTypesResponse>(request, options);
        }


        /// <summary>
        /// Lists all component types in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComponentTypes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListComponentTypes">REST API Reference for ListComponentTypes Operation</seealso>
        public virtual Task<ListComponentTypesResponse> ListComponentTypesAsync(ListComponentTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListComponentTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntities


        /// <summary>
        /// Lists all entities in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntities service method.</param>
        /// 
        /// <returns>The response from the ListEntities service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListEntities">REST API Reference for ListEntities Operation</seealso>
        public virtual ListEntitiesResponse ListEntities(ListEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesResponse>(request, options);
        }


        /// <summary>
        /// Lists all entities in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntities service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListEntities">REST API Reference for ListEntities Operation</seealso>
        public virtual Task<ListEntitiesResponse> ListEntitiesAsync(ListEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScenes


        /// <summary>
        /// Lists all scenes in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScenes service method.</param>
        /// 
        /// <returns>The response from the ListScenes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListScenes">REST API Reference for ListScenes Operation</seealso>
        public virtual ListScenesResponse ListScenes(ListScenesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScenesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScenesResponseUnmarshaller.Instance;

            return Invoke<ListScenesResponse>(request, options);
        }


        /// <summary>
        /// Lists all scenes in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScenes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScenes service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListScenes">REST API Reference for ListScenes Operation</seealso>
        public virtual Task<ListScenesResponse> ListScenesAsync(ListScenesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScenesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScenesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListScenesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSyncJobs


        /// <summary>
        /// List all SyncJobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncJobs service method.</param>
        /// 
        /// <returns>The response from the ListSyncJobs service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncJobs">REST API Reference for ListSyncJobs Operation</seealso>
        public virtual ListSyncJobsResponse ListSyncJobs(ListSyncJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSyncJobsResponseUnmarshaller.Instance;

            return Invoke<ListSyncJobsResponse>(request, options);
        }


        /// <summary>
        /// List all SyncJobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSyncJobs service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncJobs">REST API Reference for ListSyncJobs Operation</seealso>
        public virtual Task<ListSyncJobsResponse> ListSyncJobsAsync(ListSyncJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSyncJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSyncJobsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSyncJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSyncResources


        /// <summary>
        /// Lists the sync resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncResources service method.</param>
        /// 
        /// <returns>The response from the ListSyncResources service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncResources">REST API Reference for ListSyncResources Operation</seealso>
        public virtual ListSyncResourcesResponse ListSyncResources(ListSyncResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSyncResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSyncResourcesResponseUnmarshaller.Instance;

            return Invoke<ListSyncResourcesResponse>(request, options);
        }


        /// <summary>
        /// Lists the sync resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSyncResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSyncResources service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListSyncResources">REST API Reference for ListSyncResources Operation</seealso>
        public virtual Task<ListSyncResourcesResponse> ListSyncResourcesAsync(ListSyncResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSyncResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSyncResourcesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSyncResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkspaces


        /// <summary>
        /// Retrieves information about workspaces in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        public virtual ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return Invoke<ListWorkspacesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about workspaces in the current account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        public virtual Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.TooManyTagsException">
        /// The number of tags exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.TooManyTagsException">
        /// The number of tags exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateComponentType


        /// <summary>
        /// Updates information in a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentType service method.</param>
        /// 
        /// <returns>The response from the UpdateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateComponentType">REST API Reference for UpdateComponentType Operation</seealso>
        public virtual UpdateComponentTypeResponse UpdateComponentType(UpdateComponentTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentTypeResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentTypeResponse>(request, options);
        }


        /// <summary>
        /// Updates information in a component type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComponentType service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateComponentType">REST API Reference for UpdateComponentType Operation</seealso>
        public virtual Task<UpdateComponentTypeResponse> UpdateComponentTypeAsync(UpdateComponentTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentTypeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateComponentTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEntity


        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEntity service method.</param>
        /// 
        /// <returns>The response from the UpdateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateEntity">REST API Reference for UpdateEntity Operation</seealso>
        public virtual UpdateEntityResponse UpdateEntity(UpdateEntityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEntityResponseUnmarshaller.Instance;

            return Invoke<UpdateEntityResponse>(request, options);
        }


        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEntity service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateEntity">REST API Reference for UpdateEntity Operation</seealso>
        public virtual Task<UpdateEntityResponse> UpdateEntityAsync(UpdateEntityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEntityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEntityResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEntityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePricingPlan


        /// <summary>
        /// Update the pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingPlan service method.</param>
        /// 
        /// <returns>The response from the UpdatePricingPlan service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        public virtual UpdatePricingPlanResponse UpdatePricingPlan(UpdatePricingPlanRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePricingPlanResponseUnmarshaller.Instance;

            return Invoke<UpdatePricingPlanResponse>(request, options);
        }


        /// <summary>
        /// Update the pricing plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePricingPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePricingPlan service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdatePricingPlan">REST API Reference for UpdatePricingPlan Operation</seealso>
        public virtual Task<UpdatePricingPlanResponse> UpdatePricingPlanAsync(UpdatePricingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePricingPlanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePricingPlanResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePricingPlanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScene


        /// <summary>
        /// Updates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScene service method.</param>
        /// 
        /// <returns>The response from the UpdateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateScene">REST API Reference for UpdateScene Operation</seealso>
        public virtual UpdateSceneResponse UpdateScene(UpdateSceneRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSceneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSceneResponseUnmarshaller.Instance;

            return Invoke<UpdateSceneResponse>(request, options);
        }


        /// <summary>
        /// Updates a scene.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScene service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScene service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateScene">REST API Reference for UpdateScene Operation</seealso>
        public virtual Task<UpdateSceneResponse> UpdateSceneAsync(UpdateSceneRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSceneRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSceneResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSceneResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkspace


        /// <summary>
        /// Updates a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        public virtual UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceResponse>(request, options);
        }


        /// <summary>
        /// Updates a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by IoTTwinMaker.</returns>
        /// <exception cref="Amazon.IoTTwinMaker.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.InternalServerException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ResourceNotFoundException">
        /// The resource wasn't found.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ServiceQuotaExceededException">
        /// The service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoTTwinMaker.Model.ValidationException">
        /// Failed
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iottwinmaker-2021-11-29/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        public virtual Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateWorkspaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}