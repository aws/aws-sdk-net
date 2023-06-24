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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SageMakerGeospatial.Model;
using Amazon.SageMakerGeospatial.Model.Internal.MarshallTransformations;
using Amazon.SageMakerGeospatial.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SageMakerGeospatial
{
    /// <summary>
    /// Implementation for accessing SageMakerGeospatial
    ///
    /// Provides APIs for creating and managing SageMaker geospatial resources.
    /// </summary>
    public partial class AmazonSageMakerGeospatialClient : AmazonServiceClient, IAmazonSageMakerGeospatial
    {
        private static IServiceMetadata serviceMetadata = new AmazonSageMakerGeospatialMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with the credentials loaded from the application's
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
        public AmazonSageMakerGeospatialClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerGeospatialConfig()) { }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with the credentials loaded from the application's
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
        public AmazonSageMakerGeospatialClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSageMakerGeospatialConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSageMakerGeospatialClient Configuration Object</param>
        public AmazonSageMakerGeospatialClient(AmazonSageMakerGeospatialConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSageMakerGeospatialClient(AWSCredentials credentials)
            : this(credentials, new AmazonSageMakerGeospatialConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerGeospatialClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSageMakerGeospatialConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Credentials and an
        /// AmazonSageMakerGeospatialClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSageMakerGeospatialClient Configuration Object</param>
        public AmazonSageMakerGeospatialClient(AWSCredentials credentials, AmazonSageMakerGeospatialConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerGeospatialConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSageMakerGeospatialConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerGeospatialClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSageMakerGeospatialClient Configuration Object</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSageMakerGeospatialConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerGeospatialConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSageMakerGeospatialConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSageMakerGeospatialClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSageMakerGeospatialClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSageMakerGeospatialClient Configuration Object</param>
        public AmazonSageMakerGeospatialClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSageMakerGeospatialConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISageMakerGeospatialPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISageMakerGeospatialPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SageMakerGeospatialPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSageMakerGeospatialEndpointResolver());
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


        #region  DeleteEarthObservationJob

        internal virtual DeleteEarthObservationJobResponse DeleteEarthObservationJob(DeleteEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<DeleteEarthObservationJobResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to delete an Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteEarthObservationJob">REST API Reference for DeleteEarthObservationJob Operation</seealso>
        public virtual Task<DeleteEarthObservationJobResponse> DeleteEarthObservationJobAsync(DeleteEarthObservationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEarthObservationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEarthObservationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVectorEnrichmentJob

        internal virtual DeleteVectorEnrichmentJobResponse DeleteVectorEnrichmentJob(DeleteVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<DeleteVectorEnrichmentJobResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to delete a Vector Enrichment job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/DeleteVectorEnrichmentJob">REST API Reference for DeleteVectorEnrichmentJob Operation</seealso>
        public virtual Task<DeleteVectorEnrichmentJobResponse> DeleteVectorEnrichmentJobAsync(DeleteVectorEnrichmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVectorEnrichmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVectorEnrichmentJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportEarthObservationJob

        internal virtual ExportEarthObservationJobResponse ExportEarthObservationJob(ExportEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<ExportEarthObservationJobResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to export results of an Earth Observation job and optionally source
        /// images used as input to the EOJ to an Amazon S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportEarthObservationJob">REST API Reference for ExportEarthObservationJob Operation</seealso>
        public virtual Task<ExportEarthObservationJobResponse> ExportEarthObservationJobAsync(ExportEarthObservationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEarthObservationJobResponseUnmarshaller.Instance;

            return InvokeAsync<ExportEarthObservationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportVectorEnrichmentJob

        internal virtual ExportVectorEnrichmentJobResponse ExportVectorEnrichmentJob(ExportVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<ExportVectorEnrichmentJobResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to copy results of a Vector Enrichment job to an Amazon S3 location.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ExportVectorEnrichmentJob">REST API Reference for ExportVectorEnrichmentJob Operation</seealso>
        public virtual Task<ExportVectorEnrichmentJobResponse> ExportVectorEnrichmentJobAsync(ExportVectorEnrichmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportVectorEnrichmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<ExportVectorEnrichmentJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEarthObservationJob

        internal virtual GetEarthObservationJobResponse GetEarthObservationJob(GetEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<GetEarthObservationJobResponse>(request, options);
        }



        /// <summary>
        /// Get the details for a previously initiated Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetEarthObservationJob">REST API Reference for GetEarthObservationJob Operation</seealso>
        public virtual Task<GetEarthObservationJobResponse> GetEarthObservationJobAsync(GetEarthObservationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEarthObservationJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetEarthObservationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRasterDataCollection

        internal virtual GetRasterDataCollectionResponse GetRasterDataCollection(GetRasterDataCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRasterDataCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRasterDataCollectionResponseUnmarshaller.Instance;

            return Invoke<GetRasterDataCollectionResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to get details of a specific raster data collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRasterDataCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRasterDataCollection service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetRasterDataCollection">REST API Reference for GetRasterDataCollection Operation</seealso>
        public virtual Task<GetRasterDataCollectionResponse> GetRasterDataCollectionAsync(GetRasterDataCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRasterDataCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRasterDataCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetRasterDataCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTile

        internal virtual GetTileResponse GetTile(GetTileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTileResponseUnmarshaller.Instance;

            return Invoke<GetTileResponse>(request, options);
        }



        /// <summary>
        /// Gets a web mercator tile for the given Earth Observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTile service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetTile">REST API Reference for GetTile Operation</seealso>
        public virtual Task<GetTileResponse> GetTileAsync(GetTileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTileResponseUnmarshaller.Instance;

            return InvokeAsync<GetTileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVectorEnrichmentJob

        internal virtual GetVectorEnrichmentJobResponse GetVectorEnrichmentJob(GetVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<GetVectorEnrichmentJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves details of a Vector Enrichment Job for a given job Amazon Resource Name
        /// (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/GetVectorEnrichmentJob">REST API Reference for GetVectorEnrichmentJob Operation</seealso>
        public virtual Task<GetVectorEnrichmentJobResponse> GetVectorEnrichmentJobAsync(GetVectorEnrichmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVectorEnrichmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetVectorEnrichmentJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEarthObservationJobs

        internal virtual ListEarthObservationJobsResponse ListEarthObservationJobs(ListEarthObservationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEarthObservationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEarthObservationJobsResponseUnmarshaller.Instance;

            return Invoke<ListEarthObservationJobsResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to get a list of the Earth Observation jobs associated with the
        /// calling Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEarthObservationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEarthObservationJobs service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListEarthObservationJobs">REST API Reference for ListEarthObservationJobs Operation</seealso>
        public virtual Task<ListEarthObservationJobsResponse> ListEarthObservationJobsAsync(ListEarthObservationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEarthObservationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEarthObservationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEarthObservationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRasterDataCollections

        internal virtual ListRasterDataCollectionsResponse ListRasterDataCollections(ListRasterDataCollectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRasterDataCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRasterDataCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListRasterDataCollectionsResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to get raster data collections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRasterDataCollections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRasterDataCollections service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListRasterDataCollections">REST API Reference for ListRasterDataCollections Operation</seealso>
        public virtual Task<ListRasterDataCollectionsResponse> ListRasterDataCollectionsAsync(ListRasterDataCollectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRasterDataCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRasterDataCollectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRasterDataCollectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags attached to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVectorEnrichmentJobs

        internal virtual ListVectorEnrichmentJobsResponse ListVectorEnrichmentJobs(ListVectorEnrichmentJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVectorEnrichmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVectorEnrichmentJobsResponseUnmarshaller.Instance;

            return Invoke<ListVectorEnrichmentJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of vector enrichment jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVectorEnrichmentJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVectorEnrichmentJobs service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/ListVectorEnrichmentJobs">REST API Reference for ListVectorEnrichmentJobs Operation</seealso>
        public virtual Task<ListVectorEnrichmentJobsResponse> ListVectorEnrichmentJobsAsync(ListVectorEnrichmentJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVectorEnrichmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVectorEnrichmentJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVectorEnrichmentJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchRasterDataCollection

        internal virtual SearchRasterDataCollectionResponse SearchRasterDataCollection(SearchRasterDataCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRasterDataCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRasterDataCollectionResponseUnmarshaller.Instance;

            return Invoke<SearchRasterDataCollectionResponse>(request, options);
        }



        /// <summary>
        /// Allows you run image query on a specific raster data collection to get a list of the
        /// satellite imagery matching the selected filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRasterDataCollection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchRasterDataCollection service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/SearchRasterDataCollection">REST API Reference for SearchRasterDataCollection Operation</seealso>
        public virtual Task<SearchRasterDataCollectionResponse> SearchRasterDataCollectionAsync(SearchRasterDataCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchRasterDataCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchRasterDataCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<SearchRasterDataCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEarthObservationJob

        internal virtual StartEarthObservationJobResponse StartEarthObservationJob(StartEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<StartEarthObservationJobResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to create an Earth observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartEarthObservationJob">REST API Reference for StartEarthObservationJob Operation</seealso>
        public virtual Task<StartEarthObservationJobResponse> StartEarthObservationJobAsync(StartEarthObservationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEarthObservationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartEarthObservationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartVectorEnrichmentJob

        internal virtual StartVectorEnrichmentJobResponse StartVectorEnrichmentJob(StartVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<StartVectorEnrichmentJobResponse>(request, options);
        }



        /// <summary>
        /// Creates a Vector Enrichment job for the supplied job type. Currently, there are two
        /// supported job types: reverse geocoding and map matching.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StartVectorEnrichmentJob">REST API Reference for StartVectorEnrichmentJob Operation</seealso>
        public virtual Task<StartVectorEnrichmentJobResponse> StartVectorEnrichmentJobAsync(StartVectorEnrichmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVectorEnrichmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartVectorEnrichmentJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopEarthObservationJob

        internal virtual StopEarthObservationJobResponse StopEarthObservationJob(StopEarthObservationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEarthObservationJobResponseUnmarshaller.Instance;

            return Invoke<StopEarthObservationJobResponse>(request, options);
        }



        /// <summary>
        /// Use this operation to stop an existing earth observation job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEarthObservationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEarthObservationJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopEarthObservationJob">REST API Reference for StopEarthObservationJob Operation</seealso>
        public virtual Task<StopEarthObservationJobResponse> StopEarthObservationJobAsync(StopEarthObservationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEarthObservationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEarthObservationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopEarthObservationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopVectorEnrichmentJob

        internal virtual StopVectorEnrichmentJobResponse StopVectorEnrichmentJob(StopVectorEnrichmentJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopVectorEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<StopVectorEnrichmentJobResponse>(request, options);
        }



        /// <summary>
        /// Stops the Vector Enrichment job for a given job ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopVectorEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopVectorEnrichmentJob service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/StopVectorEnrichmentJob">REST API Reference for StopVectorEnrichmentJob Operation</seealso>
        public virtual Task<StopVectorEnrichmentJobResponse> StopVectorEnrichmentJobAsync(StopVectorEnrichmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopVectorEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopVectorEnrichmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopVectorEnrichmentJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// The resource you want to tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// The resource you want to untag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SageMakerGeospatial.</returns>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SageMakerGeospatial.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-geospatial-2020-05-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}