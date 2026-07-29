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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTSiteWise.Model;
using Amazon.IoTSiteWise.Model.Internal.MarshallTransformations;
using Amazon.IoTSiteWise.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.IoTSiteWise
{
    /// <summary>
    /// <para>Implementation for accessing IoTSiteWise</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// Welcome to the IoT SiteWise API Reference. IoT SiteWise is an Amazon Web Services
    /// service that connects <a href="https://en.wikipedia.org/wiki/Internet_of_things#Industrial_applications">Industrial
    /// Internet of Things (IIoT)</a> devices to the power of the Amazon Web Services Cloud.
    /// For more information, see the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/">IoT
    /// SiteWise User Guide</a>. For information about IoT SiteWise quotas, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
    /// in the <i>IoT SiteWise User Guide</i>.
    /// </summary>
    public partial class AmazonIoTSiteWiseClient : AmazonServiceClient, IAmazonIoTSiteWise
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTSiteWiseMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with the credentials loaded from the application's
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
        public AmazonIoTSiteWiseClient()
            : base(new AmazonIoTSiteWiseConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with the credentials loaded from the application's
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
        public AmazonIoTSiteWiseClient(RegionEndpoint region)
            : base(new AmazonIoTSiteWiseConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTSiteWiseClient Configuration Object</param>
        public AmazonIoTSiteWiseClient(AmazonIoTSiteWiseConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTSiteWiseClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTSiteWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSiteWiseClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTSiteWiseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Credentials and an
        /// AmazonIoTSiteWiseClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTSiteWiseClient Configuration Object</param>
        public AmazonIoTSiteWiseClient(AWSCredentials credentials, AmazonIoTSiteWiseConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTSiteWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTSiteWiseConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTSiteWiseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTSiteWiseClient Configuration Object</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTSiteWiseConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTSiteWiseConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTSiteWiseConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTSiteWiseClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTSiteWiseClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTSiteWiseClient Configuration Object</param>
        public AmazonIoTSiteWiseClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTSiteWiseConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIoTSiteWisePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTSiteWisePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTSiteWisePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTSiteWiseEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTSiteWiseAuthSchemeHandler());
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


        #region  AssociateAssets

        internal virtual AssociateAssetsResponse AssociateAssets(AssociateAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssetsResponseUnmarshaller.Instance;

            return Invoke<AssociateAssetsResponse>(request, options);
        }



        /// <summary>
        /// Associates a child asset with the given parent asset through a hierarchy defined in
        /// the parent asset's model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/add-associated-assets.html">Associating
        /// assets</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/AssociateAssets">REST API Reference for AssociateAssets Operation</seealso>
        public virtual Task<AssociateAssetsResponse> AssociateAssetsAsync(AssociateAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateTimeSeriesToAssetProperty

        internal virtual AssociateTimeSeriesToAssetPropertyResponse AssociateTimeSeriesToAssetProperty(AssociateTimeSeriesToAssetPropertyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateTimeSeriesToAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTimeSeriesToAssetPropertyResponseUnmarshaller.Instance;

            return Invoke<AssociateTimeSeriesToAssetPropertyResponse>(request, options);
        }



        /// <summary>
        /// Associates a time series (data stream) with an asset property.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTimeSeriesToAssetProperty service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTimeSeriesToAssetProperty service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/AssociateTimeSeriesToAssetProperty">REST API Reference for AssociateTimeSeriesToAssetProperty Operation</seealso>
        public virtual Task<AssociateTimeSeriesToAssetPropertyResponse> AssociateTimeSeriesToAssetPropertyAsync(AssociateTimeSeriesToAssetPropertyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateTimeSeriesToAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTimeSeriesToAssetPropertyResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTimeSeriesToAssetPropertyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchAssociateDataSegmentsToDataset

        internal virtual BatchAssociateDataSegmentsToDatasetResponse BatchAssociateDataSegmentsToDataset(BatchAssociateDataSegmentsToDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateDataSegmentsToDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateDataSegmentsToDatasetResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateDataSegmentsToDatasetResponse>(request, options);
        }



        /// <summary>
        /// Associates a batch of data segments with a curated dataset. Data segments are time-bounded
        /// slices of time series data selected from source session datasets. Data segments that
        /// belong to the same time series can't overlap in time, regardless of which dataset
        /// they belong to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateDataSegmentsToDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateDataSegmentsToDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchAssociateDataSegmentsToDataset">REST API Reference for BatchAssociateDataSegmentsToDataset Operation</seealso>
        public virtual Task<BatchAssociateDataSegmentsToDatasetResponse> BatchAssociateDataSegmentsToDatasetAsync(BatchAssociateDataSegmentsToDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateDataSegmentsToDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateDataSegmentsToDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<BatchAssociateDataSegmentsToDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchAssociateProjectAssets

        internal virtual BatchAssociateProjectAssetsResponse BatchAssociateProjectAssets(BatchAssociateProjectAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateProjectAssetsResponseUnmarshaller.Instance;

            return Invoke<BatchAssociateProjectAssetsResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Associates a group (batch) of assets with an IoT SiteWise Monitor project.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateProjectAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAssociateProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchAssociateProjectAssets">REST API Reference for BatchAssociateProjectAssets Operation</seealso>
        public virtual Task<BatchAssociateProjectAssetsResponse> BatchAssociateProjectAssetsAsync(BatchAssociateProjectAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAssociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAssociateProjectAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchAssociateProjectAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDeleteDatasetDataSegments

        internal virtual BatchDeleteDatasetDataSegmentsResponse BatchDeleteDatasetDataSegments(BatchDeleteDatasetDataSegmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteDatasetDataSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDatasetDataSegmentsResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteDatasetDataSegmentsResponse>(request, options);
        }



        /// <summary>
        /// Deletes a batch of data segments from a session dataset. Deleting a data segment deletes
        /// the underlying time series data for the segment's time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDatasetDataSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteDatasetDataSegments service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchDeleteDatasetDataSegments">REST API Reference for BatchDeleteDatasetDataSegments Operation</seealso>
        public virtual Task<BatchDeleteDatasetDataSegmentsResponse> BatchDeleteDatasetDataSegmentsAsync(BatchDeleteDatasetDataSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteDatasetDataSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDatasetDataSegmentsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteDatasetDataSegmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDisassociateDataSegmentsFromDataset

        internal virtual BatchDisassociateDataSegmentsFromDatasetResponse BatchDisassociateDataSegmentsFromDataset(BatchDisassociateDataSegmentsFromDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateDataSegmentsFromDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateDataSegmentsFromDatasetResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateDataSegmentsFromDatasetResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a batch of data segments from a curated dataset. Disassociating a data
        /// segment doesn't delete the underlying data in the source session dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateDataSegmentsFromDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateDataSegmentsFromDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchDisassociateDataSegmentsFromDataset">REST API Reference for BatchDisassociateDataSegmentsFromDataset Operation</seealso>
        public virtual Task<BatchDisassociateDataSegmentsFromDatasetResponse> BatchDisassociateDataSegmentsFromDatasetAsync(BatchDisassociateDataSegmentsFromDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateDataSegmentsFromDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateDataSegmentsFromDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDisassociateDataSegmentsFromDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchDisassociateProjectAssets

        internal virtual BatchDisassociateProjectAssetsResponse BatchDisassociateProjectAssets(BatchDisassociateProjectAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateProjectAssetsResponseUnmarshaller.Instance;

            return Invoke<BatchDisassociateProjectAssetsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a group (batch) of assets from an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateProjectAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisassociateProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchDisassociateProjectAssets">REST API Reference for BatchDisassociateProjectAssets Operation</seealso>
        public virtual Task<BatchDisassociateProjectAssetsResponse> BatchDisassociateProjectAssetsAsync(BatchDisassociateProjectAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisassociateProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisassociateProjectAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDisassociateProjectAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetAssetPropertyAggregates

        internal virtual BatchGetAssetPropertyAggregatesResponse BatchGetAssetPropertyAggregates(BatchGetAssetPropertyAggregatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyAggregatesResponseUnmarshaller.Instance;

            return Invoke<BatchGetAssetPropertyAggregatesResponse>(request, options);
        }



        /// <summary>
        /// Gets aggregated values (for example, average, minimum, and maximum) for one or more
        /// asset properties. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
        /// aggregates</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyAggregates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAssetPropertyAggregates service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyAggregates">REST API Reference for BatchGetAssetPropertyAggregates Operation</seealso>
        public virtual Task<BatchGetAssetPropertyAggregatesResponse> BatchGetAssetPropertyAggregatesAsync(BatchGetAssetPropertyAggregatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyAggregatesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetAssetPropertyAggregatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetAssetPropertyValue

        internal virtual BatchGetAssetPropertyValueResponse BatchGetAssetPropertyValue(BatchGetAssetPropertyValueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyValueResponseUnmarshaller.Instance;

            return Invoke<BatchGetAssetPropertyValueResponse>(request, options);
        }



        /// <summary>
        /// Gets the current value for one or more asset properties. For more information, see
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#current-values">Querying
        /// current values</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAssetPropertyValue service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyValue">REST API Reference for BatchGetAssetPropertyValue Operation</seealso>
        public virtual Task<BatchGetAssetPropertyValueResponse> BatchGetAssetPropertyValueAsync(BatchGetAssetPropertyValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyValueResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetAssetPropertyValueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchGetAssetPropertyValueHistory

        internal virtual BatchGetAssetPropertyValueHistoryResponse BatchGetAssetPropertyValueHistory(BatchGetAssetPropertyValueHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyValueHistoryResponseUnmarshaller.Instance;

            return Invoke<BatchGetAssetPropertyValueHistoryResponse>(request, options);
        }



        /// <summary>
        /// Gets the historical values for one or more asset properties. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#historical-values">Querying
        /// historical values</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAssetPropertyValueHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAssetPropertyValueHistory service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchGetAssetPropertyValueHistory">REST API Reference for BatchGetAssetPropertyValueHistory Operation</seealso>
        public virtual Task<BatchGetAssetPropertyValueHistoryResponse> BatchGetAssetPropertyValueHistoryAsync(BatchGetAssetPropertyValueHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAssetPropertyValueHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetAssetPropertyValueHistoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  BatchPutAssetPropertyValue

        internal virtual BatchPutAssetPropertyValueResponse BatchPutAssetPropertyValue(BatchPutAssetPropertyValueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAssetPropertyValueResponseUnmarshaller.Instance;

            return Invoke<BatchPutAssetPropertyValueResponse>(request, options);
        }



        /// <summary>
        /// Sends a list of asset property values to IoT SiteWise. Each value is a timestamp-quality-value
        /// (TQV) data point. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/ingest-api.html">Ingesting
        /// data using the API</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// With respect to Unix epoch time, IoT SiteWise accepts only TQVs that have a timestamp
        /// of no more than 7 days in the past and no more than 10 minutes in the future. IoT
        /// SiteWise rejects timestamps outside of the inclusive range of [-7 days, +10 minutes]
        /// and returns a <c>TimestampOutOfRangeException</c> error.
        /// </para>
        ///  
        /// <para>
        /// For each asset property, IoT SiteWise overwrites TQVs with duplicate timestamps unless
        /// the newer TQV has a different quality. For example, if you store a TQV <c>{T1, GOOD,
        /// V1}</c>, then storing <c>{T1, GOOD, V2}</c> replaces the existing TQV.
        /// </para>
        ///  </important> 
        /// <para>
        /// IoT SiteWise authorizes access to each <c>BatchPutAssetPropertyValue</c> entry individually.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-batchputassetpropertyvalue-action">BatchPutAssetPropertyValue
        /// authorization</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAssetPropertyValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutAssetPropertyValue service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/BatchPutAssetPropertyValue">REST API Reference for BatchPutAssetPropertyValue Operation</seealso>
        public virtual Task<BatchPutAssetPropertyValueResponse> BatchPutAssetPropertyValueAsync(BatchPutAssetPropertyValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAssetPropertyValueResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutAssetPropertyValueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelEnrichmentJob

        internal virtual CancelEnrichmentJobResponse CancelEnrichmentJob(CancelEnrichmentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<CancelEnrichmentJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels a running or pending enrichment job. This is an idempotent operation—calling
        /// it multiple times with the same jobId is safe and returns the current status.
        /// 
        ///  <h2>Behavior</h2> <ul> <li>Jobs in PENDING or RUNNING status transition to CANCELLED</li>
        /// <li>Jobs in RUNNING state may not be cancellable once they have progressed to certain
        /// processing stages</li> <li>Jobs already in terminal states (COMPLETED, FAILED, TIMED_OUT)
        /// cannot be cancelled; the operation returns a ConflictingOperationException</li> <li>Cancelling
        /// an already-CANCELLED job is a no-op and returns the current status (idempotent behavior)</li>
        /// <li>The API responds immediately after recording the cancellation</li> <li>Cleanup
        /// of job resources happens asynchronously in the background</li> </ul> <h2>When to Cancel</h2>
        /// 
        /// <para>
        /// Cancel a job when:
        /// </para>
        ///  <ul> <li>The job is taking longer than expected</li> <li>The job was created with
        /// incorrect parameters</li> <li>You no longer need the results</li> </ul> <h2>Idempotency</h2>
        /// 
        /// <para>
        /// You can safely retry cancellation requests. Calling CancelEnrichmentJob multiple times
        /// for the same job returns the current status without error as long as the job is not
        /// in a terminal state other than CANCELLED.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelEnrichmentJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CancelEnrichmentJob">REST API Reference for CancelEnrichmentJob Operation</seealso>
        public virtual Task<CancelEnrichmentJobResponse> CancelEnrichmentJobAsync(CancelEnrichmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelEnrichmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelEnrichmentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelPipelineExecution

        internal virtual CancelPipelineExecutionResponse CancelPipelineExecution(CancelPipelineExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<CancelPipelineExecutionResponse>(request, options);
        }



        /// <summary>
        /// Cancels a pipeline execution in the specified workspace. If the execution is not in
        /// a terminal state (such as NOT_STARTED or RUNNING), it transitions to CANCELLING and
        /// asynchronously to CANCELLED. This operation is idempotent: calling it on an execution
        /// that is already CANCELLING or CANCELLED returns success with the current state. Calling
        /// it on a terminal execution (SUCCEEDED or FAILED) returns a conflict error. You can
        /// optionally provide a reason; it is returned in the stateDetails field when you describe
        /// the execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelPipelineExecution service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CancelPipelineExecution">REST API Reference for CancelPipelineExecution Operation</seealso>
        public virtual Task<CancelPipelineExecutionResponse> CancelPipelineExecutionAsync(CancelPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelPipelineExecutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelQuery

        internal virtual CancelQueryResponse CancelQuery(CancelQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;

            return Invoke<CancelQueryResponse>(request, options);
        }



        /// <summary>
        /// Cancels a running query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        public virtual Task<CancelQueryResponse> CancelQueryAsync(CancelQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelQueryResponseUnmarshaller.Instance;

            return InvokeAsync<CancelQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAccessPolicy

        internal virtual CreateAccessPolicyResponse CreateAccessPolicy(CreateAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateAccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates an access policy that grants the specified identity (IAM Identity Center user,
        /// IAM Identity Center group, or IAM user) access to the specified IoT SiteWise Monitor
        /// portal or project resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// Support for access policies that use an SSO Group as the identity is not supported
        /// at this time.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAccessPolicy">REST API Reference for CreateAccessPolicy Operation</seealso>
        public virtual Task<CreateAccessPolicyResponse> CreateAccessPolicyAsync(CreateAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAccessPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new application for the workspace and IdC application provided
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAsset

        internal virtual CreateAssetResponse CreateAsset(CreateAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return Invoke<CreateAssetResponse>(request, options);
        }



        /// <summary>
        /// Creates an asset from an existing asset model. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/create-assets.html">Creating
        /// assets</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual Task<CreateAssetResponse> CreateAssetAsync(CreateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAssetModel

        internal virtual CreateAssetModelResponse CreateAssetModel(CreateAssetModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelResponseUnmarshaller.Instance;

            return Invoke<CreateAssetModelResponse>(request, options);
        }



        /// <summary>
        /// Creates an asset model from specified property and hierarchy definitions. You create
        /// assets from asset models. With asset models, you can easily create assets of the same
        /// type that have standardized definitions. Each asset created from a model inherits
        /// the asset model's property and hierarchy definitions. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/define-models.html">Defining
        /// asset models</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can create three types of asset models, <c>ASSET_MODEL</c>, <c>COMPONENT_MODEL</c>,
        /// or an <c>INTERFACE</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ASSET_MODEL</b> – (default) An asset model that you can use to create assets.
        /// Can't be included as a component in another asset model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPONENT_MODEL</b> – A reusable component that you can include in the composite
        /// models of other asset models. You can't create assets directly from this type of asset
        /// model. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>INTERFACE</b> – An interface is a type of model that defines a standard structure
        /// that can be applied to different asset models.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAssetModel">REST API Reference for CreateAssetModel Operation</seealso>
        public virtual Task<CreateAssetModelResponse> CreateAssetModelAsync(CreateAssetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssetModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAssetModelCompositeModel

        internal virtual CreateAssetModelCompositeModelResponse CreateAssetModelCompositeModel(CreateAssetModelCompositeModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelCompositeModelResponseUnmarshaller.Instance;

            return Invoke<CreateAssetModelCompositeModelResponse>(request, options);
        }



        /// <summary>
        /// Creates a custom composite model from specified property and hierarchy definitions.
        /// There are two types of custom composite models, <c>inline</c> and <c>component-model-based</c>.
        /// 
        /// 
        ///  
        /// <para>
        /// Use component-model-based custom composite models to define standard, reusable components.
        /// A component-model-based custom composite model consists of a name, a description,
        /// and the ID of the component model it references. A component-model-based custom composite
        /// model has no properties of its own; its referenced component model provides its associated
        /// properties to any created assets. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/custom-composite-models.html">Custom
        /// composite models (Components)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use inline custom composite models to organize the properties of an asset model. The
        /// properties of inline custom composite models are local to the asset model where they
        /// are included and can't be used to create multiple assets.
        /// </para>
        ///  
        /// <para>
        /// To create a component-model-based model, specify the <c>composedAssetModelId</c> of
        /// an existing asset model with <c>assetModelType</c> of <c>COMPONENT_MODEL</c>.
        /// </para>
        ///  
        /// <para>
        /// To create an inline model, specify the <c>assetModelCompositeModelProperties</c> and
        /// don't include an <c>composedAssetModelId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetModelCompositeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetModelCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateAssetModelCompositeModel">REST API Reference for CreateAssetModelCompositeModel Operation</seealso>
        public virtual Task<CreateAssetModelCompositeModelResponse> CreateAssetModelCompositeModelAsync(CreateAssetModelCompositeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetModelCompositeModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAssetModelCompositeModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBulkImportJob

        internal virtual CreateBulkImportJobResponse CreateBulkImportJob(CreateBulkImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBulkImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBulkImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateBulkImportJobResponse>(request, options);
        }



        /// <summary>
        /// Defines a job to ingest data to IoT SiteWise from Amazon S3. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/CreateBulkImportJob.html">Create
        /// a bulk import job (CLI)</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// Before you create a bulk import job that ingests data into time series outside of
        /// a workspace, you must enable IoT SiteWise warm tier or IoT SiteWise cold tier. For
        /// more information about how to configure storage settings, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_PutStorageConfiguration.html">PutStorageConfiguration</a>.
        /// This requirement doesn't apply to bulk import jobs that ingest data into a session
        /// dataset in a workspace (jobs that specify a <c>workspaceName</c> and <c>datasetId</c>).
        /// Those jobs don't use IoT SiteWise warm or cold tier storage.
        /// </para>
        ///  
        /// <para>
        /// Bulk import is designed to store historical data to IoT SiteWise.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Newly ingested data in the hot tier triggers notifications and computations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After data moves from the hot tier to the warm or cold tier based on retention settings,
        /// it does not trigger computations or notifications.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data older than 7 days does not trigger computations or notifications.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBulkImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBulkImportJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateBulkImportJob">REST API Reference for CreateBulkImportJob Operation</seealso>
        public virtual Task<CreateBulkImportJobResponse> CreateBulkImportJobAsync(CreateBulkImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBulkImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBulkImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBulkImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateComputationModel

        internal virtual CreateComputationModelResponse CreateComputationModel(CreateComputationModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputationModelResponseUnmarshaller.Instance;

            return Invoke<CreateComputationModelResponse>(request, options);
        }



        /// <summary>
        /// Create a computation model with a configuration and data binding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputationModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComputationModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateComputationModel">REST API Reference for CreateComputationModel Operation</seealso>
        public virtual Task<CreateComputationModelResponse> CreateComputationModelAsync(CreateComputationModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputationModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComputationModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDashboard

        internal virtual CreateDashboardResponse CreateDashboard(CreateDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return Invoke<CreateDashboardResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a dashboard in an IoT SiteWise Monitor project.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        public virtual Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Creates a dataset. Session and curated datasets are created in a workspace. A session
        /// dataset contains data segments of time series data, and a curated dataset curates
        /// data segments selected from source session datasets. A dataset that connects to an
        /// external datasource is created outside of a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDatasetExportJob

        internal virtual CreateDatasetExportJobResponse CreateDatasetExportJob(CreateDatasetExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetExportJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous job that exports dataset and time-series data from a workspace
        /// to Amazon S3. The operation returns a jobId immediately; poll DescribeDatasetExportJob
        /// to track progress and ListDatasetExportJobs to enumerate a workspace's jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatasetExportJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateDatasetExportJob">REST API Reference for CreateDatasetExportJob Operation</seealso>
        public virtual Task<CreateDatasetExportJobResponse> CreateDatasetExportJobAsync(CreateDatasetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEnrichmentJob

        internal virtual CreateEnrichmentJobResponse CreateEnrichmentJob(CreateEnrichmentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<CreateEnrichmentJobResponse>(request, options);
        }



        /// <summary>
        /// Creates an asynchronous enrichment job to analyze time-series sensor data. The operation
        /// returns immediately with job details while processing continues in the background.
        /// 
        ///  <h2>Idempotency</h2> 
        /// <para>
        /// Include a clientToken to make the operation idempotent. If you submit the same request
        /// with the same token within the idempotency window, you receive the original job details
        /// without creating a duplicate.
        /// </para>
        ///  <h2>Prerequisites</h2> 
        /// <para>
        /// Before creating a job, ensure:
        /// </para>
        ///  <ul> <li>The workspace is in ACTIVE state (not being deleted)</li> <li>You have IAM
        /// permissions for the workspace, dataset, and time-series resources</li> <li>You have
        /// KMS Decrypt permission on the workspace's customer-managed encryption key</li> <li>No
        /// duplicate job (same workspace, dataset, property, and job type) is currently running</li>
        /// </ul> <h2>Workflow</h2> <ol> <li>Submit the job with configuration specifying which
        /// video data to analyze and the time range</li> <li>Capture the jobId from the response</li>
        /// <li>Use DescribeEnrichmentJob to monitor progress and check job status</li> <li>When
        /// status reaches a terminal state (COMPLETED, FAILED, TIMED_OUT, CANCELLED), check results</li>
        /// <li>For COMPLETED jobs, query IoT SiteWise for semantic search on video events</li>
        /// </ol> <h2>Error Handling</h2> <ul> <li>ConflictingOperationException: A duplicate
        /// job is already running for the same configuration</li> <li>InvalidRequestException:
        /// Invalid parameters (e.g., both timeSeriesId and propertyAlias specified)</li> <li>AccessDeniedException:
        /// Insufficient IAM or KMS permissions</li> <li>LimitExceededException: Too many concurrent
        /// jobs or requests</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnrichmentJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateEnrichmentJob">REST API Reference for CreateEnrichmentJob Operation</seealso>
        public virtual Task<CreateEnrichmentJobResponse> CreateEnrichmentJobAsync(CreateEnrichmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnrichmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnrichmentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateGateway

        internal virtual CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayResponse>(request, options);
        }



        /// <summary>
        /// Creates a gateway, which is a virtual or edge device that delivers industrial data
        /// streams from local servers to IoT SiteWise. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/gateway-connector.html">Ingesting
        /// data using a gateway</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePipeline

        internal virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }



        /// <summary>
        /// Creates a new pipeline in the specified workspace. A pipeline defines a directed acyclic
        /// graph (DAG) of compute nodes, where each node references a task and can declare dependencies
        /// on other nodes. Cyclic dependencies are not allowed. Nodes without dependencies run
        /// in parallel, while nodes with dependencies wait for all upstream nodes to complete
        /// successfully before starting.
        /// 
        ///  
        /// <para>
        /// You can set environment variables at the pipeline level that are shared across all
        /// compute nodes, and override them at the individual compute node level.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePortal

        internal virtual CreatePortalResponse CreatePortal(CreatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return Invoke<CreatePortalResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a portal, which can contain projects and dashboards. IoT SiteWise Monitor
        /// uses IAM Identity Center or IAM to authenticate portal users and manage user permissions.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can sign in to a new portal, you must add at least one identity to that
        /// portal. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/administer-portals.html#portal-change-admins">Adding
        /// or removing portal administrators</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        public virtual Task<CreatePortalResponse> CreatePortalAsync(CreatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePortalResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePortalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProject

        internal virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a project in the specified portal.
        /// </para>
        ///  <note> 
        /// <para>
        /// Make sure that the project name and description don't contain confidential information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTask

        internal virtual CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return Invoke<CreateTaskResponse>(request, options);
        }



        /// <summary>
        /// Creates a new task in the specified workspace. A task defines a reusable containerized
        /// compute workload that can be referenced by one or more pipeline compute nodes.
        /// 
        ///  
        /// <para>
        /// Specify a <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_ContainerTaskConfiguration.html"><c>containerTaskConfiguration</c></a>
        /// for custom container workloads with configurable ECR image, processing type, processing
        /// unit, and environment variables.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateTask">REST API Reference for CreateTask Operation</seealso>
        public virtual Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWorkspace

        internal virtual CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a workspace in IoT SiteWise. A workspace isolates its resources, such as datasets,
        /// time series, pipelines, and tasks, and their data from other workspaces, and has its
        /// own quotas and throttling limits. You must specify an encryption configuration when
        /// you create a workspace. The operation returns immediately with the workspace in the
        /// <c>CREATING</c> state. Provisioning completes asynchronously, after which the workspace
        /// state is <c>ACTIVE</c>, or <c>FAILED</c> if provisioning doesn't complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        public virtual Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkspaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAccessPolicy

        internal virtual DeleteAccessPolicyResponse DeleteAccessPolicy(DeleteAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes an access policy that grants the specified identity access to the specified
        /// IoT SiteWise Monitor resource. You can use this operation to revoke access to an IoT
        /// SiteWise Monitor resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAccessPolicy">REST API Reference for DeleteAccessPolicy Operation</seealso>
        public virtual Task<DeleteAccessPolicyResponse> DeleteAccessPolicyAsync(DeleteAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccessPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an application by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAsset

        internal virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }



        /// <summary>
        /// Deletes an asset. This action can't be undone. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// You can't delete an asset that's associated to another asset. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DisassociateAssets.html">DisassociateAssets</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAssetModel

        internal virtual DeleteAssetModelResponse DeleteAssetModel(DeleteAssetModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes an asset model. This action can't be undone. You must delete all assets created
        /// from an asset model before you can delete the model. Also, you can't delete an asset
        /// model if a parent asset model exists that contains a property formula expression that
        /// depends on the asset model that you want to delete. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModel">REST API Reference for DeleteAssetModel Operation</seealso>
        public virtual Task<DeleteAssetModelResponse> DeleteAssetModelAsync(DeleteAssetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssetModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAssetModelCompositeModel

        internal virtual DeleteAssetModelCompositeModelResponse DeleteAssetModelCompositeModel(DeleteAssetModelCompositeModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelCompositeModelResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetModelCompositeModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a composite model. This action can't be undone. You must delete all assets
        /// created from a composite model before you can delete the model. Also, you can't delete
        /// a composite model if a parent asset model exists that contains a property formula
        /// expression that depends on the asset model that you want to delete. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/delete-assets-and-models.html">Deleting
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModelCompositeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssetModelCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModelCompositeModel">REST API Reference for DeleteAssetModelCompositeModel Operation</seealso>
        public virtual Task<DeleteAssetModelCompositeModelResponse> DeleteAssetModelCompositeModelAsync(DeleteAssetModelCompositeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelCompositeModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssetModelCompositeModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAssetModelInterfaceRelationship

        internal virtual DeleteAssetModelInterfaceRelationshipResponse DeleteAssetModelInterfaceRelationship(DeleteAssetModelInterfaceRelationshipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetModelInterfaceRelationshipResponse>(request, options);
        }



        /// <summary>
        /// Deletes an interface relationship between an asset model and an interface asset model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetModelInterfaceRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssetModelInterfaceRelationship service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteAssetModelInterfaceRelationship">REST API Reference for DeleteAssetModelInterfaceRelationship Operation</seealso>
        public virtual Task<DeleteAssetModelInterfaceRelationshipResponse> DeleteAssetModelInterfaceRelationshipAsync(DeleteAssetModelInterfaceRelationshipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAssetModelInterfaceRelationshipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteComputationModel

        internal virtual DeleteComputationModelResponse DeleteComputationModel(DeleteComputationModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputationModelResponseUnmarshaller.Instance;

            return Invoke<DeleteComputationModelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a computation model. This action can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputationModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComputationModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteComputationModel">REST API Reference for DeleteComputationModel Operation</seealso>
        public virtual Task<DeleteComputationModelResponse> DeleteComputationModelAsync(DeleteComputationModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputationModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteComputationModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDashboard

        internal virtual DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dashboard from IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        public virtual Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDataset

        internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }



        /// <summary>
        /// Deletes a dataset. This can't be undone. Deleting a session dataset also deletes the
        /// underlying time series data in the session. You can't delete a session dataset while
        /// a curated dataset references its data segments. First delete the curated dataset or
        /// disassociate the data segments. Deleting a curated dataset doesn't delete the underlying
        /// data in the source session datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteGateway

        internal virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes a gateway from IoT SiteWise. When you delete a gateway, some of the gateway's
        /// files remain in your gateway's file system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePipeline

        internal virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }



        /// <summary>
        /// Deletes a pipeline from the specified workspace. A pipeline cannot be deleted if it
        /// has any active executions. Wait for all executions to complete before attempting to
        /// delete the pipeline, or use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_CancelPipelineExecution.html">CancelPipelineExecution</a>
        /// to stop a running execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePortal

        internal virtual DeletePortalResponse DeletePortal(DeletePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return Invoke<DeletePortalResponse>(request, options);
        }



        /// <summary>
        /// Deletes a portal from IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        public virtual Task<DeletePortalResponse> DeletePortalAsync(DeletePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePortalResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePortalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProject

        internal virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }



        /// <summary>
        /// Deletes a project from IoT SiteWise Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTask

        internal virtual DeleteTaskResponse DeleteTask(DeleteTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteTaskResponse>(request, options);
        }



        /// <summary>
        /// Deletes a task from the specified workspace. A task cannot be deleted if it is currently
        /// referenced by any existing pipeline. Remove the task from all pipelines before attempting
        /// to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTask service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        public virtual Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTimeSeries

        internal virtual DeleteTimeSeriesResponse DeleteTimeSeries(DeleteTimeSeriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimeSeriesResponseUnmarshaller.Instance;

            return Invoke<DeleteTimeSeriesResponse>(request, options);
        }



        /// <summary>
        /// Deletes a time series (data stream). If you delete a time series that's associated
        /// with an asset property, the asset property still exists, but the time series will
        /// no longer be associated with this asset property. You can't delete a time series until
        /// all of its data segments have been deleted from session datasets.
        /// 
        ///  
        /// <para>
        /// To identify a time series, do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the time series isn't associated with an asset property, specify the <c>alias</c>
        /// of the time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the time series is associated with an asset property, specify one of the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>alias</c> of the time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> that identifies the asset property.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimeSeries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTimeSeries service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteTimeSeries">REST API Reference for DeleteTimeSeries Operation</seealso>
        public virtual Task<DeleteTimeSeriesResponse> DeleteTimeSeriesAsync(DeleteTimeSeriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimeSeriesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTimeSeriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWorkspace

        internal virtual DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a workspace. Before you delete a workspace, you must delete all resources
        /// contained in or associated with the workspace, such as datasets, time series, pipelines,
        /// and tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        public virtual Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkspaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAccessPolicy

        internal virtual DescribeAccessPolicyResponse DescribeAccessPolicy(DescribeAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeAccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// Describes an access policy, which specifies an identity's access to an IoT SiteWise
        /// Monitor portal or project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAccessPolicy">REST API Reference for DescribeAccessPolicy Operation</seealso>
        public virtual Task<DescribeAccessPolicyResponse> DescribeAccessPolicyAsync(DescribeAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccessPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAction

        internal virtual DescribeActionResponse DescribeAction(DescribeActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionResponseUnmarshaller.Instance;

            return Invoke<DescribeActionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAction service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAction">REST API Reference for DescribeAction Operation</seealso>
        public virtual Task<DescribeActionResponse> DescribeActionAsync(DescribeActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeApplication

        internal virtual DescribeApplicationResponse DescribeApplication(DescribeApplicationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves Application details based on the ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplication service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeApplication">REST API Reference for DescribeApplication Operation</seealso>
        public virtual Task<DescribeApplicationResponse> DescribeApplicationAsync(DescribeApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAsset

        internal virtual DescribeAssetResponse DescribeAsset(DescribeAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAsset">REST API Reference for DescribeAsset Operation</seealso>
        public virtual Task<DescribeAssetResponse> DescribeAssetAsync(DescribeAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAssetCompositeModel

        internal virtual DescribeAssetCompositeModelResponse DescribeAssetCompositeModel(DescribeAssetCompositeModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetCompositeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetCompositeModelResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an asset composite model (also known as an asset component).
        /// An <c>AssetCompositeModel</c> is an instance of an <c>AssetModelCompositeModel</c>.
        /// If you want to see information about the model this is based on, call <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeAssetModelCompositeModel.html">DescribeAssetModelCompositeModel</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetCompositeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetCompositeModel">REST API Reference for DescribeAssetCompositeModel Operation</seealso>
        public virtual Task<DescribeAssetCompositeModelResponse> DescribeAssetCompositeModelAsync(DescribeAssetCompositeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetCompositeModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetCompositeModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAssetModel

        internal virtual DescribeAssetModelResponse DescribeAssetModel(DescribeAssetModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetModelResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an asset model. This includes details about the asset
        /// model's properties, hierarchies, composite models, and any interface relationships
        /// if the asset model implements interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModel">REST API Reference for DescribeAssetModel Operation</seealso>
        public virtual Task<DescribeAssetModelResponse> DescribeAssetModelAsync(DescribeAssetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAssetModelCompositeModel

        internal virtual DescribeAssetModelCompositeModelResponse DescribeAssetModelCompositeModel(DescribeAssetModelCompositeModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelCompositeModelResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetModelCompositeModelResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an asset model composite model (also known as an asset
        /// model component). For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/custom-composite-models.html">Custom
        /// composite models (Components)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModelCompositeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetModelCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModelCompositeModel">REST API Reference for DescribeAssetModelCompositeModel Operation</seealso>
        public virtual Task<DescribeAssetModelCompositeModelResponse> DescribeAssetModelCompositeModelAsync(DescribeAssetModelCompositeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelCompositeModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetModelCompositeModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAssetModelInterfaceRelationship

        internal virtual DescribeAssetModelInterfaceRelationshipResponse DescribeAssetModelInterfaceRelationship(DescribeAssetModelInterfaceRelationshipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetModelInterfaceRelationshipResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an interface relationship between an asset model and an
        /// interface asset model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetModelInterfaceRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetModelInterfaceRelationship service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetModelInterfaceRelationship">REST API Reference for DescribeAssetModelInterfaceRelationship Operation</seealso>
        public virtual Task<DescribeAssetModelInterfaceRelationshipResponse> DescribeAssetModelInterfaceRelationshipAsync(DescribeAssetModelInterfaceRelationshipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetModelInterfaceRelationshipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAssetProperty

        internal virtual DescribeAssetPropertyResponse DescribeAssetProperty(DescribeAssetPropertyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetPropertyResponseUnmarshaller.Instance;

            return Invoke<DescribeAssetPropertyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an asset property.
        /// 
        ///  <note> 
        /// <para>
        /// When you call this operation for an attribute property, this response includes the
        /// default attribute value that you define in the asset model. If you update the default
        /// value in the model, this operation's response includes the new default value.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation doesn't return the value of the asset property. To get the value of
        /// an asset property, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_GetAssetPropertyValue.html">GetAssetPropertyValue</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAssetProperty service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAssetProperty service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeAssetProperty">REST API Reference for DescribeAssetProperty Operation</seealso>
        public virtual Task<DescribeAssetPropertyResponse> DescribeAssetPropertyAsync(DescribeAssetPropertyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAssetPropertyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAssetPropertyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeBulkImportJob

        internal virtual DescribeBulkImportJobResponse DescribeBulkImportJob(DescribeBulkImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBulkImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBulkImportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeBulkImportJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a bulk import job request. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/DescribeBulkImportJob.html">Describe
        /// a bulk import job (CLI)</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBulkImportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBulkImportJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeBulkImportJob">REST API Reference for DescribeBulkImportJob Operation</seealso>
        public virtual Task<DescribeBulkImportJobResponse> DescribeBulkImportJobAsync(DescribeBulkImportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBulkImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBulkImportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBulkImportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeComputationModel

        internal virtual DescribeComputationModelResponse DescribeComputationModel(DescribeComputationModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputationModelResponseUnmarshaller.Instance;

            return Invoke<DescribeComputationModelResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a computation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputationModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComputationModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeComputationModel">REST API Reference for DescribeComputationModel Operation</seealso>
        public virtual Task<DescribeComputationModelResponse> DescribeComputationModelAsync(DescribeComputationModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputationModelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComputationModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeComputationModelExecutionSummary

        internal virtual DescribeComputationModelExecutionSummaryResponse DescribeComputationModelExecutionSummary(DescribeComputationModelExecutionSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComputationModelExecutionSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputationModelExecutionSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeComputationModelExecutionSummaryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the execution summary of a computation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputationModelExecutionSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComputationModelExecutionSummary service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeComputationModelExecutionSummary">REST API Reference for DescribeComputationModelExecutionSummary Operation</seealso>
        public virtual Task<DescribeComputationModelExecutionSummaryResponse> DescribeComputationModelExecutionSummaryAsync(DescribeComputationModelExecutionSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeComputationModelExecutionSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputationModelExecutionSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComputationModelExecutionSummaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDashboard

        internal virtual DescribeDashboardResponse DescribeDashboard(DescribeDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;

            return Invoke<DescribeDashboardResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a dashboard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDashboard">REST API Reference for DescribeDashboard Operation</seealso>
        public virtual Task<DescribeDashboardResponse> DescribeDashboardAsync(DescribeDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDataset

        internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDatasetExportJob

        internal virtual DescribeDatasetExportJobResponse DescribeDatasetExportJob(DescribeDatasetExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetExportJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetExportJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a dataset export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDatasetExportJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDatasetExportJob">REST API Reference for DescribeDatasetExportJob Operation</seealso>
        public virtual Task<DescribeDatasetExportJobResponse> DescribeDatasetExportJobAsync(DescribeDatasetExportJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetExportJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetExportJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDefaultEncryptionConfiguration

        internal virtual DescribeDefaultEncryptionConfigurationResponse DescribeDefaultEncryptionConfiguration(DescribeDefaultEncryptionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultEncryptionConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the default encryption configuration for the Amazon Web
        /// Services account in the default or specified Region. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultEncryptionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDefaultEncryptionConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeDefaultEncryptionConfiguration">REST API Reference for DescribeDefaultEncryptionConfiguration Operation</seealso>
        public virtual Task<DescribeDefaultEncryptionConfigurationResponse> DescribeDefaultEncryptionConfigurationAsync(DescribeDefaultEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultEncryptionConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEnrichmentJob

        internal virtual DescribeEnrichmentJobResponse DescribeEnrichmentJob(DescribeEnrichmentJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnrichmentJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEnrichmentJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific enrichment job, including its current
        /// status, configuration, and timestamps.
        /// 
        ///  <h2>Use Cases</h2> <ul> <li>Monitor job progress by checking status updates with
        /// DescribeEnrichmentJob</li> <li>Retrieve the complete job configuration submitted during
        /// creation</li> <li>Debug failed jobs by examining the failureMessage field</li> <li>Track
        /// job lifecycle with creation, update, completion, and cancellation timestamps</li>
        /// </ul> <h2>Status Monitoring</h2> 
        /// <para>
        /// Jobs progress through statuses: PENDING → RUNNING → terminal state
        /// </para>
        ///  
        /// <para>
        /// Terminal states:
        /// </para>
        ///  <ul> <li>COMPLETED: Job finished successfully; query IoT SiteWise for semantic search
        /// results</li> <li>FAILED: Job encountered an error; check failureMessage for details</li>
        /// <li>TIMED_OUT: Job exceeded maximum processing time</li> <li>CANCELLED: Job was cancelled
        /// via CancelEnrichmentJob</li> </ul> <h2>Response Fields</h2> 
        /// <para>
        /// The response includes:
        /// </para>
        ///  <ul> <li>Current job status and type</li> <li>Full job configuration as originally
        /// submitted</li> <li>Lifecycle timestamps (created, updated, completed, cancelled)</li>
        /// <li>Failure details if status is FAILED</li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnrichmentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnrichmentJob service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeEnrichmentJob">REST API Reference for DescribeEnrichmentJob Operation</seealso>
        public virtual Task<DescribeEnrichmentJobResponse> DescribeEnrichmentJobAsync(DescribeEnrichmentJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnrichmentJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnrichmentJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnrichmentJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeExecution

        internal virtual DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeExecutionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual Task<DescribeExecutionResponse> DescribeExecutionAsync(DescribeExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExecutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGateway

        internal virtual DescribeGatewayResponse DescribeGateway(DescribeGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeGateway">REST API Reference for DescribeGateway Operation</seealso>
        public virtual Task<DescribeGatewayResponse> DescribeGatewayAsync(DescribeGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeGatewayCapabilityConfiguration

        internal virtual DescribeGatewayCapabilityConfigurationResponse DescribeGatewayCapabilityConfiguration(DescribeGatewayCapabilityConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayCapabilityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeGatewayCapabilityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Each gateway capability defines data sources for a gateway. This is the namespace
        /// of the gateway capability.
        /// 
        ///  
        /// <para>
        /// . The namespace follows the format <c>service:capability:version</c>, where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>service</c> - The service providing the capability, or <c>iotsitewise</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>capability</c> - The specific capability type. Options include: <c>opcuacollector</c>
        /// for the OPC UA data source collector, or <c>publisher</c> for data publisher capability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>version</c> - The version number of the capability. Option include <c>2</c> for
        /// Classic streams, V2 gateways, and <c>3</c> for MQTT-enabled, V3 gateways.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After updating a capability configuration, the sync status becomes <c>OUT_OF_SYNC</c>
        /// until the gateway processes the configuration.Use <c>DescribeGatewayCapabilityConfiguration</c>
        /// to check the sync status and verify the configuration was applied.
        /// </para>
        ///  
        /// <para>
        /// A gateway can have multiple capability configurations with different namespaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGatewayCapabilityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGatewayCapabilityConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeGatewayCapabilityConfiguration">REST API Reference for DescribeGatewayCapabilityConfiguration Operation</seealso>
        public virtual Task<DescribeGatewayCapabilityConfigurationResponse> DescribeGatewayCapabilityConfigurationAsync(DescribeGatewayCapabilityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGatewayCapabilityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGatewayCapabilityConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeLoggingOptions

        internal virtual DescribeLoggingOptionsResponse DescribeLoggingOptions(DescribeLoggingOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current IoT SiteWise logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoggingOptions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual Task<DescribeLoggingOptionsResponse> DescribeLoggingOptionsAsync(DescribeLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePipeline

        internal virtual DescribePipelineResponse DescribePipeline(DescribePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return Invoke<DescribePipelineResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific pipeline in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipeline service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        public virtual Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePipelineExecution

        internal virtual DescribePipelineExecutionResponse DescribePipelineExecution(DescribePipelineExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribePipelineExecutionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific pipeline execution, including the
        /// overall execution status and the status of each individual compute node. Use this
        /// operation to monitor execution progress and inspect per-node results, environment
        /// variables, and error details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipelineExecution service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribePipelineExecution">REST API Reference for DescribePipelineExecution Operation</seealso>
        public virtual Task<DescribePipelineExecutionResponse> DescribePipelineExecutionAsync(DescribePipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelineExecutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePortal

        internal virtual DescribePortalResponse DescribePortal(DescribePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortalResponseUnmarshaller.Instance;

            return Invoke<DescribePortalResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribePortal">REST API Reference for DescribePortal Operation</seealso>
        public virtual Task<DescribePortalResponse> DescribePortalAsync(DescribePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePortalResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePortalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeProject

        internal virtual DescribeProjectResponse DescribeProject(DescribeProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return Invoke<DescribeProjectResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeProject">REST API Reference for DescribeProject Operation</seealso>
        public virtual Task<DescribeProjectResponse> DescribeProjectAsync(DescribeProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProjectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeQuery

        internal virtual DescribeQueryResponse DescribeQuery(DescribeQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueryResponseUnmarshaller.Instance;

            return Invoke<DescribeQueryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a query, including its status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQuery service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeQuery">REST API Reference for DescribeQuery Operation</seealso>
        public virtual Task<DescribeQueryResponse> DescribeQueryAsync(DescribeQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSearch

        internal virtual DescribeSearchResponse DescribeSearch(DescribeSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSearchResponseUnmarshaller.Instance;

            return Invoke<DescribeSearchResponse>(request, options);
        }



        /// <summary>
        /// Returns the current status and metadata of a single search, including the query that
        /// was submitted, the search type, and — when the search has failed — the reason. Use
        /// this to poll a search started with <c>StartSearch</c> until it reaches a terminal
        /// status (<c>SUCCEEDED</c> or <c>FAILED</c>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSearch service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeSearch">REST API Reference for DescribeSearch Operation</seealso>
        public virtual Task<DescribeSearchResponse> DescribeSearchAsync(DescribeSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSearchResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSearchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStorageConfiguration

        internal virtual DescribeStorageConfigurationResponse DescribeStorageConfiguration(DescribeStorageConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeStorageConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about the storage configuration for IoT SiteWise.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorageConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeStorageConfiguration">REST API Reference for DescribeStorageConfiguration Operation</seealso>
        public virtual Task<DescribeStorageConfigurationResponse> DescribeStorageConfigurationAsync(DescribeStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStorageConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStorageConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTask

        internal virtual DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskResponse>(request, options);
        }



        /// <summary>
        /// Retrieves detailed information about a specific task in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        public virtual Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTimeSeries

        internal virtual DescribeTimeSeriesResponse DescribeTimeSeries(DescribeTimeSeriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTimeSeriesResponseUnmarshaller.Instance;

            return Invoke<DescribeTimeSeriesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a time series (data stream).
        /// 
        ///  
        /// <para>
        /// To identify a time series, do one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the time series isn't associated with an asset property, specify the <c>alias</c>
        /// of the time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the time series is associated with an asset property, specify one of the following:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>alias</c> of the time series.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> that identifies the asset property.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeSeries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTimeSeries service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeTimeSeries">REST API Reference for DescribeTimeSeries Operation</seealso>
        public virtual Task<DescribeTimeSeriesResponse> DescribeTimeSeriesAsync(DescribeTimeSeriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTimeSeriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTimeSeriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeWorkspace

        internal virtual DescribeWorkspaceResponse DescribeWorkspace(DescribeWorkspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        public virtual Task<DescribeWorkspaceResponse> DescribeWorkspaceAsync(DescribeWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkspaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateAssets

        internal virtual DisassociateAssetsResponse DisassociateAssets(DisassociateAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssetsResponseUnmarshaller.Instance;

            return Invoke<DisassociateAssetsResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a child asset from the given parent asset through a hierarchy defined
        /// in the parent asset's model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DisassociateAssets">REST API Reference for DisassociateAssets Operation</seealso>
        public virtual Task<DisassociateAssetsResponse> DisassociateAssetsAsync(DisassociateAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateTimeSeriesFromAssetProperty

        internal virtual DisassociateTimeSeriesFromAssetPropertyResponse DisassociateTimeSeriesFromAssetProperty(DisassociateTimeSeriesFromAssetPropertyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateTimeSeriesFromAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTimeSeriesFromAssetPropertyResponseUnmarshaller.Instance;

            return Invoke<DisassociateTimeSeriesFromAssetPropertyResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a time series (data stream) from an asset property.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTimeSeriesFromAssetProperty service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTimeSeriesFromAssetProperty service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/DisassociateTimeSeriesFromAssetProperty">REST API Reference for DisassociateTimeSeriesFromAssetProperty Operation</seealso>
        public virtual Task<DisassociateTimeSeriesFromAssetPropertyResponse> DisassociateTimeSeriesFromAssetPropertyAsync(DisassociateTimeSeriesFromAssetPropertyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateTimeSeriesFromAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTimeSeriesFromAssetPropertyResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTimeSeriesFromAssetPropertyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExecuteAction

        internal virtual ExecuteActionResponse ExecuteAction(ExecuteActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteActionResponseUnmarshaller.Instance;

            return Invoke<ExecuteActionResponse>(request, options);
        }



        /// <summary>
        /// Executes an action on a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteAction service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ExecuteAction">REST API Reference for ExecuteAction Operation</seealso>
        public virtual Task<ExecuteActionResponse> ExecuteActionAsync(ExecuteActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteActionResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteActionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExecuteQuery

        internal virtual ExecuteQueryResponse ExecuteQuery(ExecuteQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return Invoke<ExecuteQueryResponse>(request, options);
        }



        /// <summary>
        /// Run SQL queries to retrieve metadata and time-series data from asset models, assets,
        /// measurements, metrics, transforms, and aggregates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.QueryTimeoutException">
        /// The query timed out.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ValidationException">
        /// The validation failed for this query.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        public virtual Task<ExecuteQueryResponse> ExecuteQueryAsync(ExecuteQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteQueryResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssetPropertyAggregates

        internal virtual GetAssetPropertyAggregatesResponse GetAssetPropertyAggregates(GetAssetPropertyAggregatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyAggregatesResponseUnmarshaller.Instance;

            return Invoke<GetAssetPropertyAggregatesResponse>(request, options);
        }



        /// <summary>
        /// Gets aggregated values for an asset property. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#aggregates">Querying
        /// aggregates</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyAggregates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssetPropertyAggregates service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyAggregates">REST API Reference for GetAssetPropertyAggregates Operation</seealso>
        public virtual Task<GetAssetPropertyAggregatesResponse> GetAssetPropertyAggregatesAsync(GetAssetPropertyAggregatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyAggregatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyAggregatesResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssetPropertyAggregatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssetPropertyValue

        internal virtual GetAssetPropertyValueResponse GetAssetPropertyValue(GetAssetPropertyValueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueResponseUnmarshaller.Instance;

            return Invoke<GetAssetPropertyValueResponse>(request, options);
        }



        /// <summary>
        /// Gets an asset property's current value. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#current-values">Querying
        /// current values</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssetPropertyValue service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyValue">REST API Reference for GetAssetPropertyValue Operation</seealso>
        public virtual Task<GetAssetPropertyValueResponse> GetAssetPropertyValueAsync(GetAssetPropertyValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssetPropertyValueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAssetPropertyValueHistory

        internal virtual GetAssetPropertyValueHistoryResponse GetAssetPropertyValueHistory(GetAssetPropertyValueHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueHistoryResponseUnmarshaller.Instance;

            return Invoke<GetAssetPropertyValueHistoryResponse>(request, options);
        }



        /// <summary>
        /// Gets the history of an asset property's values. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/query-industrial-data.html#historical-values">Querying
        /// historical values</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetPropertyValueHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssetPropertyValueHistory service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetAssetPropertyValueHistory">REST API Reference for GetAssetPropertyValueHistory Operation</seealso>
        public virtual Task<GetAssetPropertyValueHistoryResponse> GetAssetPropertyValueHistoryAsync(GetAssetPropertyValueHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetPropertyValueHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetPropertyValueHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetAssetPropertyValueHistoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCaptureData

        internal virtual GetCaptureDataResponse GetCaptureData(GetCaptureDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaptureDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaptureDataResponseUnmarshaller.Instance;

            return Invoke<GetCaptureDataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves video data for a specific time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCaptureData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCaptureData service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetCaptureData">REST API Reference for GetCaptureData Operation</seealso>
        public virtual Task<GetCaptureDataResponse> GetCaptureDataAsync(GetCaptureDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCaptureDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCaptureDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetCaptureDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetInterpolatedAssetPropertyValues

        internal virtual GetInterpolatedAssetPropertyValuesResponse GetInterpolatedAssetPropertyValues(GetInterpolatedAssetPropertyValuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInterpolatedAssetPropertyValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInterpolatedAssetPropertyValuesResponseUnmarshaller.Instance;

            return Invoke<GetInterpolatedAssetPropertyValuesResponse>(request, options);
        }



        /// <summary>
        /// Get interpolated values for an asset property for a specified time interval, during
        /// a period of time. If your time series is missing data points during the specified
        /// time interval, you can use interpolation to estimate the missing data.
        /// 
        ///  
        /// <para>
        /// For example, you can use this operation to return the interpolated temperature values
        /// for a wind turbine every 24 hours over a duration of 7 days.
        /// </para>
        ///  
        /// <para>
        /// To identify an asset property, you must specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
        /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInterpolatedAssetPropertyValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInterpolatedAssetPropertyValues service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ServiceUnavailableException">
        /// The requested service is unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetInterpolatedAssetPropertyValues">REST API Reference for GetInterpolatedAssetPropertyValues Operation</seealso>
        public virtual Task<GetInterpolatedAssetPropertyValuesResponse> GetInterpolatedAssetPropertyValuesAsync(GetInterpolatedAssetPropertyValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInterpolatedAssetPropertyValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInterpolatedAssetPropertyValuesResponseUnmarshaller.Instance;

            return InvokeAsync<GetInterpolatedAssetPropertyValuesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetQueryResults

        internal virtual GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the paginated results of a query. Returns empty rows if the query is not
        /// yet complete.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSearchResults

        internal virtual GetSearchResultsResponse GetSearchResults(GetSearchResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSearchResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchResultsResponseUnmarshaller.Instance;

            return Invoke<GetSearchResultsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the ranked results of a search, ordered by descending relevance score. Results
        /// are available only after the search has reached the <c>SUCCEEDED</c> status. Calling
        /// this on a search that exists but has not yet completed returns <c>InvalidRequestException</c>,
        /// while calling it on a search that does not exist returns <c>ResourceNotFoundException</c>.
        /// The response is paginated: when <c>nextToken</c> is present, pass it on a subsequent
        /// call to retrieve the next page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSearchResults service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/GetSearchResults">REST API Reference for GetSearchResults Operation</seealso>
        public virtual Task<GetSearchResultsResponse> GetSearchResultsAsync(GetSearchResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSearchResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSearchResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSearchResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  InvokeAssistant

        internal virtual InvokeAssistantResponse InvokeAssistant(InvokeAssistantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAssistantResponseUnmarshaller.Instance;

            return Invoke<InvokeAssistantResponse>(request, options);
        }



        /// <summary>
        /// Invokes SiteWise Assistant to start or continue a conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAssistant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeAssistant service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/InvokeAssistant">REST API Reference for InvokeAssistant Operation</seealso>
        public virtual Task<InvokeAssistantResponse> InvokeAssistantAsync(InvokeAssistantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeAssistantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeAssistantResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeAssistantResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAccessPolicies

        internal virtual ListAccessPoliciesResponse ListAccessPolicies(ListAccessPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListAccessPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of access policies for an identity (an IAM Identity Center
        /// user, an IAM Identity Center group, or an IAM user) or an IoT SiteWise Monitor resource
        /// (a portal or project).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccessPolicies service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAccessPolicies">REST API Reference for ListAccessPolicies Operation</seealso>
        public virtual Task<ListAccessPoliciesResponse> ListAccessPoliciesAsync(ListAccessPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccessPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccessPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAccessPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListActions

        internal virtual ListActionsResponse ListActions(ListActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return Invoke<ListActionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of actions for a specific target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListActions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListActions">REST API Reference for ListActions Operation</seealso>
        public virtual Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListApplications

        internal virtual ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return Invoke<ListApplicationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of existing applications
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListApplications">REST API Reference for ListApplications Operation</seealso>
        public virtual Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApplicationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetModelCompositeModels

        internal virtual ListAssetModelCompositeModelsResponse ListAssetModelCompositeModels(ListAssetModelCompositeModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetModelCompositeModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelCompositeModelsResponseUnmarshaller.Instance;

            return Invoke<ListAssetModelCompositeModelsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of composite models associated with the asset model
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModelCompositeModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetModelCompositeModels service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModelCompositeModels">REST API Reference for ListAssetModelCompositeModels Operation</seealso>
        public virtual Task<ListAssetModelCompositeModelsResponse> ListAssetModelCompositeModelsAsync(ListAssetModelCompositeModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetModelCompositeModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelCompositeModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetModelCompositeModelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetModelProperties

        internal virtual ListAssetModelPropertiesResponse ListAssetModelProperties(ListAssetModelPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetModelPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelPropertiesResponseUnmarshaller.Instance;

            return Invoke<ListAssetModelPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of properties associated with an asset model. If you update
        /// properties associated with the model before you finish listing all the properties,
        /// you need to start all over again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModelProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetModelProperties service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModelProperties">REST API Reference for ListAssetModelProperties Operation</seealso>
        public virtual Task<ListAssetModelPropertiesResponse> ListAssetModelPropertiesAsync(ListAssetModelPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetModelPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetModelPropertiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetModels

        internal virtual ListAssetModelsResponse ListAssetModels(ListAssetModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelsResponseUnmarshaller.Instance;

            return Invoke<ListAssetModelsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of summaries of all asset models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetModels service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetModels">REST API Reference for ListAssetModels Operation</seealso>
        public virtual Task<ListAssetModelsResponse> ListAssetModelsAsync(ListAssetModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetModelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetProperties

        internal virtual ListAssetPropertiesResponse ListAssetProperties(ListAssetPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetPropertiesResponseUnmarshaller.Instance;

            return Invoke<ListAssetPropertiesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of properties associated with an asset. If you update properties
        /// associated with the model before you finish listing all the properties, you need to
        /// start all over again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetProperties service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetProperties">REST API Reference for ListAssetProperties Operation</seealso>
        public virtual Task<ListAssetPropertiesResponse> ListAssetPropertiesAsync(ListAssetPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetPropertiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssetRelationships

        internal virtual ListAssetRelationshipsResponse ListAssetRelationships(ListAssetRelationshipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRelationshipsResponseUnmarshaller.Instance;

            return Invoke<ListAssetRelationshipsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of asset relationships for an asset. You can use this operation
        /// to identify an asset's root asset and all associated assets between that asset and
        /// its root.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRelationships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetRelationships service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssetRelationships">REST API Reference for ListAssetRelationships Operation</seealso>
        public virtual Task<ListAssetRelationshipsResponse> ListAssetRelationshipsAsync(ListAssetRelationshipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRelationshipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetRelationshipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssets

        internal virtual ListAssetsResponse ListAssets(ListAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;

            return Invoke<ListAssetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of asset summaries.
        /// 
        ///  
        /// <para>
        /// You can use this operation to do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// List assets based on a specific asset model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// List top-level assets.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't use this operation to list all assets. To retrieve summaries for all of
        /// your assets, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_ListAssetModels.html">ListAssetModels</a>
        /// to get all of your asset model IDs. Then, use ListAssets to get all assets for each
        /// asset model.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssets">REST API Reference for ListAssets Operation</seealso>
        public virtual Task<ListAssetsResponse> ListAssetsAsync(ListAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAssociatedAssets

        internal virtual ListAssociatedAssetsResponse ListAssociatedAssets(ListAssociatedAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAssetsResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedAssetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of associated assets.
        /// 
        ///  
        /// <para>
        /// You can use this operation to do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CHILD</c> - List all child assets associated to the asset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARENT</c> - List the asset's parent asset.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListAssociatedAssets">REST API Reference for ListAssociatedAssets Operation</seealso>
        public virtual Task<ListAssociatedAssetsResponse> ListAssociatedAssetsAsync(ListAssociatedAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociatedAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociatedAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBulkImportJobs

        internal virtual ListBulkImportJobsResponse ListBulkImportJobs(ListBulkImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBulkImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBulkImportJobsResponseUnmarshaller.Instance;

            return Invoke<ListBulkImportJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of bulk import job requests. For more information, see
        /// <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/ListBulkImportJobs.html">List
        /// bulk import jobs (CLI)</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBulkImportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBulkImportJobs service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListBulkImportJobs">REST API Reference for ListBulkImportJobs Operation</seealso>
        public virtual Task<ListBulkImportJobsResponse> ListBulkImportJobsAsync(ListBulkImportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBulkImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBulkImportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBulkImportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCompositionRelationships

        internal virtual ListCompositionRelationshipsResponse ListCompositionRelationships(ListCompositionRelationshipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCompositionRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompositionRelationshipsResponseUnmarshaller.Instance;

            return Invoke<ListCompositionRelationshipsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of composition relationships for an asset model of type
        /// <c>COMPONENT_MODEL</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompositionRelationships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCompositionRelationships service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListCompositionRelationships">REST API Reference for ListCompositionRelationships Operation</seealso>
        public virtual Task<ListCompositionRelationshipsResponse> ListCompositionRelationshipsAsync(ListCompositionRelationshipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCompositionRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCompositionRelationshipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCompositionRelationshipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComputationModelDataBindingUsages

        internal virtual ListComputationModelDataBindingUsagesResponse ListComputationModelDataBindingUsages(ListComputationModelDataBindingUsagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputationModelDataBindingUsagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelDataBindingUsagesResponseUnmarshaller.Instance;

            return Invoke<ListComputationModelDataBindingUsagesResponse>(request, options);
        }



        /// <summary>
        /// Lists all data binding usages for computation models. This allows to identify where
        /// specific data bindings are being utilized across the computation models. This track
        /// dependencies between data sources and computation models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModelDataBindingUsages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComputationModelDataBindingUsages service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModelDataBindingUsages">REST API Reference for ListComputationModelDataBindingUsages Operation</seealso>
        public virtual Task<ListComputationModelDataBindingUsagesResponse> ListComputationModelDataBindingUsagesAsync(ListComputationModelDataBindingUsagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputationModelDataBindingUsagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelDataBindingUsagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListComputationModelDataBindingUsagesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComputationModelResolveToResources

        internal virtual ListComputationModelResolveToResourcesResponse ListComputationModelResolveToResources(ListComputationModelResolveToResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputationModelResolveToResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelResolveToResourcesResponseUnmarshaller.Instance;

            return Invoke<ListComputationModelResolveToResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists all distinct resources that are resolved from the executed actions of the computation
        /// model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModelResolveToResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComputationModelResolveToResources service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModelResolveToResources">REST API Reference for ListComputationModelResolveToResources Operation</seealso>
        public virtual Task<ListComputationModelResolveToResourcesResponse> ListComputationModelResolveToResourcesAsync(ListComputationModelResolveToResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputationModelResolveToResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelResolveToResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListComputationModelResolveToResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListComputationModels

        internal virtual ListComputationModelsResponse ListComputationModels(ListComputationModelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputationModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelsResponseUnmarshaller.Instance;

            return Invoke<ListComputationModelsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of summaries of all computation models.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputationModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComputationModels service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListComputationModels">REST API Reference for ListComputationModels Operation</seealso>
        public virtual Task<ListComputationModelsResponse> ListComputationModelsAsync(ListComputationModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListComputationModelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComputationModelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComputationModelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDashboards

        internal virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of dashboards for an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDashboardsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetDataSegmentRelationships

        internal virtual ListDatasetDataSegmentRelationshipsResponse ListDatasetDataSegmentRelationships(ListDatasetDataSegmentRelationshipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetDataSegmentRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetDataSegmentRelationshipsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetDataSegmentRelationshipsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of data segment relationships for a session dataset. Use
        /// this operation to find the curated datasets that reference data segments of the specified
        /// session dataset. Use the <c>nextToken</c> parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetDataSegmentRelationships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetDataSegmentRelationships service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDatasetDataSegmentRelationships">REST API Reference for ListDatasetDataSegmentRelationships Operation</seealso>
        public virtual Task<ListDatasetDataSegmentRelationshipsResponse> ListDatasetDataSegmentRelationshipsAsync(ListDatasetDataSegmentRelationshipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetDataSegmentRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetDataSegmentRelationshipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetDataSegmentRelationshipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetDataSegments

        internal virtual ListDatasetDataSegmentsResponse ListDatasetDataSegments(ListDatasetDataSegmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetDataSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetDataSegmentsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetDataSegmentsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of data segments associated with a dataset. Use the <c>nextToken</c>
        /// parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetDataSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetDataSegments service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDatasetDataSegments">REST API Reference for ListDatasetDataSegments Operation</seealso>
        public virtual Task<ListDatasetDataSegmentsResponse> ListDatasetDataSegmentsAsync(ListDatasetDataSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetDataSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetDataSegmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetDataSegmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetExportJobs

        internal virtual ListDatasetExportJobsResponse ListDatasetExportJobs(ListDatasetExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetExportJobsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of dataset export jobs for a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetExportJobs service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDatasetExportJobs">REST API Reference for ListDatasetExportJobs Operation</seealso>
        public virtual Task<ListDatasetExportJobsResponse> ListDatasetExportJobsAsync(ListDatasetExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetExportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasets

        internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of datasets for a specific target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListEnrichmentJobs

        internal virtual ListEnrichmentJobsResponse ListEnrichmentJobs(ListEnrichmentJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnrichmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnrichmentJobsResponseUnmarshaller.Instance;

            return Invoke<ListEnrichmentJobsResponse>(request, options);
        }



        /// <summary>
        /// Lists enrichment jobs within a workspace with optional filtering and pagination. Results
        /// are ordered by createdAt timestamp descending (newest first).
        /// 
        ///  <h2>Filtering</h2> 
        /// <para>
        /// Combine filters to narrow results:
        /// </para>
        ///  <ul> <li><strong>datasetId</strong>: Filter by dataset</li> <li><strong>propertyAlias</strong>
        /// OR <strong>timeSeriesId</strong>: Filter by time series (specify one, not both)</li>
        /// <li><strong>status</strong>: Filter by job status (e.g., RUNNING to find active jobs)</li>
        /// <li><strong>jobType</strong>: Filter by enrichment type (currently only EVENT_DETECTION)</li>
        /// <li><strong>startDate</strong> and <strong>endDate</strong>: Filter by job creation
        /// time range</li> </ul> <h2>Important Constraints</h2> <ul> <li>You must specify either
        /// propertyAlias OR timeSeriesId, but not both</li> <li>Attempting to specify both results
        /// in an InvalidRequestException</li> <li>Date filters use ISO 8601 format</li> <li>startDate
        /// is exclusive, endDate is inclusive</li> </ul> <h2>Pagination</h2> 
        /// <para>
        /// The operation returns up to maxResults jobs per page (default 50). If more results
        /// exist, the response includes a nextToken. Submit this token in a subsequent request
        /// to retrieve the next page.
        /// </para>
        ///  <h2>Common Use Cases</h2> <ul> <li>Find all running jobs: Filter by status=RUNNING</li>
        /// <li>List recent jobs for a dataset: Filter by datasetId with optional date range</li>
        /// <li>Monitor jobs for a specific sensor: Filter by propertyAlias or timeSeriesId</li>
        /// <li>Track all event detection jobs: Filter by jobType=EVENT_DETECTION</li> </ul> <h2>Performance</h2>
        /// 
        /// <para>
        /// Performance is optimal when filtering by supported fields (datasetId, propertyAlias,
        /// timeSeriesId, status, jobType).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnrichmentJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnrichmentJobs service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListEnrichmentJobs">REST API Reference for ListEnrichmentJobs Operation</seealso>
        public virtual Task<ListEnrichmentJobsResponse> ListEnrichmentJobsAsync(ListEnrichmentJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnrichmentJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnrichmentJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnrichmentJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExecutions

        internal virtual ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of summaries of all executions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExecutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGateways

        internal virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<ListGatewaysResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInterfaceRelationships

        internal virtual ListInterfaceRelationshipsResponse ListInterfaceRelationships(ListInterfaceRelationshipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInterfaceRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInterfaceRelationshipsResponseUnmarshaller.Instance;

            return Invoke<ListInterfaceRelationshipsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of asset models that have a specific interface asset model
        /// applied to them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInterfaceRelationships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInterfaceRelationships service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListInterfaceRelationships">REST API Reference for ListInterfaceRelationships Operation</seealso>
        public virtual Task<ListInterfaceRelationshipsResponse> ListInterfaceRelationshipsAsync(ListInterfaceRelationshipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInterfaceRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInterfaceRelationshipsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInterfaceRelationshipsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPipelineExecutions

        internal virtual ListPipelineExecutionsResponse ListPipelineExecutions(ListPipelineExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListPipelineExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Lists pipeline executions for a specific pipeline in a workspace. Supports filtering
        /// by state and time range. State can be combined with either startTime or endTime filters.
        /// Time range filters are grouped: use startTime filters (startTimeAfter, startTimeBefore)
        /// or endTime filters (endTimeAfter, endTimeBefore), but not both. Combining startTime
        /// and endTime filters returns an InvalidRequestException. Note: endTime filters only
        /// return executions in terminal states, as in-progress executions have no endTime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelineExecutions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListPipelineExecutions">REST API Reference for ListPipelineExecutions Operation</seealso>
        public virtual Task<ListPipelineExecutionsResponse> ListPipelineExecutionsAsync(ListPipelineExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelineExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelineExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelineExecutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPipelines

        internal virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
        }



        /// <summary>
        /// Lists pipelines in a workspace. To get complete details about a pipeline, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribePipeline.html">DescribePipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPortals

        internal virtual ListPortalsResponse ListPortals(ListPortalsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return Invoke<ListPortalsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of IoT SiteWise Monitor portals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPortals service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListPortals">REST API Reference for ListPortals Operation</seealso>
        public virtual Task<ListPortalsResponse> ListPortalsAsync(ListPortalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPortalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPortalsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPortalsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProjectAssets

        internal virtual ListProjectAssetsResponse ListProjectAssets(ListProjectAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectAssetsResponseUnmarshaller.Instance;

            return Invoke<ListProjectAssetsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of assets associated with an IoT SiteWise Monitor project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjectAssets service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListProjectAssets">REST API Reference for ListProjectAssets Operation</seealso>
        public virtual Task<ListProjectAssetsResponse> ListProjectAssetsAsync(ListProjectAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProjects

        internal virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of projects for an IoT SiteWise Monitor portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProjectsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListQueries

        internal virtual ListQueriesResponse ListQueries(ListQueriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueriesResponseUnmarshaller.Instance;

            return Invoke<ListQueriesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of queries for a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueries service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListQueries">REST API Reference for ListQueries Operation</seealso>
        public virtual Task<ListQueriesResponse> ListQueriesAsync(ListQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSearches

        internal virtual ListSearchesResponse ListSearches(ListSearchesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchesResponseUnmarshaller.Instance;

            return Invoke<ListSearchesResponse>(request, options);
        }



        /// <summary>
        /// Lists the searches in a workspace, most recently started first. Results can be narrowed
        /// with optional filters (status, search type, group, and started-at time range) and
        /// are paginated: when <c>nextToken</c> is present, pass it on a subsequent call to retrieve
        /// the next page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSearches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSearches service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListSearches">REST API Reference for ListSearches Operation</seealso>
        public virtual Task<ListSearchesResponse> ListSearchesAsync(ListSearchesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSearchesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSearchesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSearchesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the list of tags for an IoT SiteWise resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.UnauthorizedException">
        /// You are not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTasks

        internal virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksResponse>(request, options);
        }



        /// <summary>
        /// Lists tasks in a workspace. To get complete details about a task, use <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeTask.html">DescribeTask</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTimeSeries

        internal virtual ListTimeSeriesResponse ListTimeSeries(ListTimeSeriesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimeSeriesResponseUnmarshaller.Instance;

            return Invoke<ListTimeSeriesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of time series (data streams).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTimeSeries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTimeSeries service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListTimeSeries">REST API Reference for ListTimeSeries Operation</seealso>
        public virtual Task<ListTimeSeriesResponse> ListTimeSeriesAsync(ListTimeSeriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTimeSeriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimeSeriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTimeSeriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWorkspaces

        internal virtual ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return Invoke<ListWorkspacesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of workspaces. Use the <c>nextToken</c> parameter to retrieve
        /// additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        public virtual Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkspacesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAssetModelInterfaceRelationship

        internal virtual PutAssetModelInterfaceRelationshipResponse PutAssetModelInterfaceRelationship(PutAssetModelInterfaceRelationshipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return Invoke<PutAssetModelInterfaceRelationshipResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates an interface relationship between an asset model and an interface
        /// asset model. This operation applies an interface to an asset model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAssetModelInterfaceRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAssetModelInterfaceRelationship service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutAssetModelInterfaceRelationship">REST API Reference for PutAssetModelInterfaceRelationship Operation</seealso>
        public virtual Task<PutAssetModelInterfaceRelationshipResponse> PutAssetModelInterfaceRelationshipAsync(PutAssetModelInterfaceRelationshipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAssetModelInterfaceRelationshipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAssetModelInterfaceRelationshipResponseUnmarshaller.Instance;

            return InvokeAsync<PutAssetModelInterfaceRelationshipResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutDefaultEncryptionConfiguration

        internal virtual PutDefaultEncryptionConfigurationResponse PutDefaultEncryptionConfiguration(PutDefaultEncryptionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutDefaultEncryptionConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Sets the default encryption configuration for the Amazon Web Services account. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/key-management.html">Key
        /// management</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDefaultEncryptionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDefaultEncryptionConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutDefaultEncryptionConfiguration">REST API Reference for PutDefaultEncryptionConfiguration Operation</seealso>
        public virtual Task<PutDefaultEncryptionConfigurationResponse> PutDefaultEncryptionConfigurationAsync(PutDefaultEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDefaultEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDefaultEncryptionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutDefaultEncryptionConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutLoggingOptions

        internal virtual PutLoggingOptionsResponse PutLoggingOptions(PutLoggingOptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutLoggingOptionsResponse>(request, options);
        }



        /// <summary>
        /// Sets logging options for IoT SiteWise.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutLoggingOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutStorageConfiguration

        internal virtual PutStorageConfigurationResponse PutStorageConfiguration(PutStorageConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutStorageConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutStorageConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Configures storage settings for IoT SiteWise.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutStorageConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutStorageConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/PutStorageConfiguration">REST API Reference for PutStorageConfiguration Operation</seealso>
        public virtual Task<PutStorageConfigurationResponse> PutStorageConfigurationAsync(PutStorageConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutStorageConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutStorageConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutStorageConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartPipelineExecution

        internal virtual StartPipelineExecutionResponse StartPipelineExecution(StartPipelineExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return Invoke<StartPipelineExecutionResponse>(request, options);
        }



        /// <summary>
        /// Starts execution of a pipeline in the specified workspace. Each compute node runs
        /// according to the DAG dependency order defined in the pipeline. Nodes without dependencies
        /// start immediately, while dependent nodes wait for all upstream nodes to complete successfully.
        /// 
        ///  
        /// <para>
        /// You can provide runtime environment variable overrides that take the highest priority
        /// in the environment variable hierarchy, without modifying the pipeline definition.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPipelineExecution service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/StartPipelineExecution">REST API Reference for StartPipelineExecution Operation</seealso>
        public virtual Task<StartPipelineExecutionResponse> StartPipelineExecutionAsync(StartPipelineExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPipelineExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartPipelineExecutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartQuery

        internal virtual StartQueryResponse StartQuery(StartQueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;

            return Invoke<StartQueryResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous SQL query against workspace telemetry, annotations, data segment,
        /// and dataset data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQuery service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/StartQuery">REST API Reference for StartQuery Operation</seealso>
        public virtual Task<StartQueryResponse> StartQueryAsync(StartQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartSearch

        internal virtual StartSearchResponse StartSearch(StartSearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSearchResponseUnmarshaller.Instance;

            return Invoke<StartSearchResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous search over the data in a workspace. The search runs in the
        /// background; the response returns immediately with a <c>searchId</c> and an initial
        /// status of <c>QUEUED</c>. Use <c>DescribeSearch</c> to poll for completion and <c>GetSearchResults</c>
        /// to retrieve the results once the search reaches <c>SUCCEEDED</c>. The request is idempotent
        /// on <c>clientToken</c>: repeating a call with the same token returns the original search
        /// instead of starting a new one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSearch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSearch service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/StartSearch">REST API Reference for StartSearch Operation</seealso>
        public virtual Task<StartSearchResponse> StartSearchAsync(StartSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSearchResponseUnmarshaller.Instance;

            return InvokeAsync<StartSearchResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds tags to an IoT SiteWise resource. If a tag already exists for the resource, this
        /// operation updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.TooManyTagsException">
        /// You've reached the quota for the number of tags allowed for a resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html#tag-conventions">Tag
        /// naming limits and requirements</a> in the <i>Amazon Web Services General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.UnauthorizedException">
        /// You are not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag from an IoT SiteWise resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.UnauthorizedException">
        /// You are not authorized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAccessPolicy

        internal virtual UpdateAccessPolicyResponse UpdateAccessPolicy(UpdateAccessPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateAccessPolicyResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates an existing access policy that specifies an identity's access to an IoT SiteWise
        /// Monitor portal or project resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessPolicy service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAccessPolicy">REST API Reference for UpdateAccessPolicy Operation</seealso>
        public virtual Task<UpdateAccessPolicyResponse> UpdateAccessPolicyAsync(UpdateAccessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccessPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccessPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAsset

        internal virtual UpdateAssetResponse UpdateAsset(UpdateAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetResponse>(request, options);
        }



        /// <summary>
        /// Updates an asset's name. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAsset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAsset">REST API Reference for UpdateAsset Operation</seealso>
        public virtual Task<UpdateAssetResponse> UpdateAssetAsync(UpdateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAssetModel

        internal virtual UpdateAssetModelResponse UpdateAssetModel(UpdateAssetModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetModelResponse>(request, options);
        }



        /// <summary>
        /// Updates an asset model and all of the assets that were created from the model. Each
        /// asset created from the model inherits the updated asset model's property and hierarchy
        /// definitions. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// If you remove a property from an asset model, IoT SiteWise deletes all previous data
        /// for that property. You can’t change the type or data type of an existing property.
        /// </para>
        ///  
        /// <para>
        /// To replace an existing asset model property with a new one with the same <c>name</c>,
        /// do the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit an <c>UpdateAssetModel</c> request with the entire existing property removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a second <c>UpdateAssetModel</c> request that includes the new property. The
        /// new asset property will have the same <c>name</c> as the previous one and IoT SiteWise
        /// will generate a new unique <c>id</c>.
        /// </para>
        ///  </li> </ol> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssetModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetModel">REST API Reference for UpdateAssetModel Operation</seealso>
        public virtual Task<UpdateAssetModelResponse> UpdateAssetModelAsync(UpdateAssetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssetModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAssetModelCompositeModel

        internal virtual UpdateAssetModelCompositeModelResponse UpdateAssetModelCompositeModel(UpdateAssetModelCompositeModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelCompositeModelResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetModelCompositeModelResponse>(request, options);
        }



        /// <summary>
        /// Updates a composite model and all of the assets that were created from the model.
        /// Each asset created from the model inherits the updated asset model's property and
        /// hierarchy definitions. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/update-assets-and-models.html">Updating
        /// assets and models</a> in the <i>IoT SiteWise User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// If you remove a property from a composite asset model, IoT SiteWise deletes all previous
        /// data for that property. You can’t change the type or data type of an existing property.
        /// </para>
        ///  
        /// <para>
        /// To replace an existing composite asset model property with a new one with the same
        /// <c>name</c>, do the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Submit an <c>UpdateAssetModelCompositeModel</c> request with the entire existing property
        /// removed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Submit a second <c>UpdateAssetModelCompositeModel</c> request that includes the new
        /// property. The new asset property will have the same <c>name</c> as the previous one
        /// and IoT SiteWise will generate a new unique <c>id</c>.
        /// </para>
        ///  </li> </ol> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetModelCompositeModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssetModelCompositeModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.PreconditionFailedException">
        /// The precondition in one or more of the request-header fields evaluated to <c>FALSE</c>.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetModelCompositeModel">REST API Reference for UpdateAssetModelCompositeModel Operation</seealso>
        public virtual Task<UpdateAssetModelCompositeModelResponse> UpdateAssetModelCompositeModelAsync(UpdateAssetModelCompositeModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetModelCompositeModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetModelCompositeModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssetModelCompositeModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAssetProperty

        internal virtual UpdateAssetPropertyResponse UpdateAssetProperty(UpdateAssetPropertyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetPropertyResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetPropertyResponse>(request, options);
        }



        /// <summary>
        /// Updates an asset property's alias and notification state.
        /// 
        ///  <important> 
        /// <para>
        /// This operation overwrites the property's existing alias and notification state. To
        /// keep your existing property's alias or notification state, you must include the existing
        /// values in the UpdateAssetProperty request. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeAssetProperty.html">DescribeAssetProperty</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetProperty service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssetProperty service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateAssetProperty">REST API Reference for UpdateAssetProperty Operation</seealso>
        public virtual Task<UpdateAssetPropertyResponse> UpdateAssetPropertyAsync(UpdateAssetPropertyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetPropertyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetPropertyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAssetPropertyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateComputationModel

        internal virtual UpdateComputationModelResponse UpdateComputationModel(UpdateComputationModelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputationModelResponseUnmarshaller.Instance;

            return Invoke<UpdateComputationModelResponse>(request, options);
        }



        /// <summary>
        /// Updates the computation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputationModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComputationModel service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateComputationModel">REST API Reference for UpdateComputationModel Operation</seealso>
        public virtual Task<UpdateComputationModelResponse> UpdateComputationModelAsync(UpdateComputationModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateComputationModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputationModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateComputationModelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDashboard

        internal virtual UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return Invoke<UpdateDashboardResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates an IoT SiteWise Monitor dashboard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        public virtual Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDashboardResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDashboardResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDataset

        internal virtual UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGateway

        internal virtual UpdateGatewayResponse UpdateGateway(UpdateGatewayRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayResponse>(request, options);
        }



        /// <summary>
        /// Updates a gateway's name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGateway service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateGateway">REST API Reference for UpdateGateway Operation</seealso>
        public virtual Task<UpdateGatewayResponse> UpdateGatewayAsync(UpdateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateGatewayCapabilityConfiguration

        internal virtual UpdateGatewayCapabilityConfigurationResponse UpdateGatewayCapabilityConfiguration(UpdateGatewayCapabilityConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayCapabilityConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayCapabilityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates a gateway capability configuration or defines a new capability configuration.
        /// Each gateway capability defines data sources for a gateway.
        /// 
        ///  
        /// <para>
        /// Important workflow notes:
        /// </para>
        ///  
        /// <para>
        /// Each gateway capability defines data sources for a gateway. This is the namespace
        /// of the gateway capability.
        /// </para>
        ///  
        /// <para>
        /// . The namespace follows the format <c>service:capability:version</c>, where:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>service</c> - The service providing the capability, or <c>iotsitewise</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>capability</c> - The specific capability type. Options include: <c>opcuacollector</c>
        /// for the OPC UA data source collector, or <c>publisher</c> for data publisher capability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>version</c> - The version number of the capability. Option include <c>2</c> for
        /// Classic streams, V2 gateways, and <c>3</c> for MQTT-enabled, V3 gateways.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After updating a capability configuration, the sync status becomes <c>OUT_OF_SYNC</c>
        /// until the gateway processes the configuration.Use <c>DescribeGatewayCapabilityConfiguration</c>
        /// to check the sync status and verify the configuration was applied.
        /// </para>
        ///  
        /// <para>
        /// A gateway can have multiple capability configurations with different namespaces.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayCapabilityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayCapabilityConfiguration service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateGatewayCapabilityConfiguration">REST API Reference for UpdateGatewayCapabilityConfiguration Operation</seealso>
        public virtual Task<UpdateGatewayCapabilityConfigurationResponse> UpdateGatewayCapabilityConfigurationAsync(UpdateGatewayCapabilityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGatewayCapabilityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayCapabilityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayCapabilityConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePipeline

        internal virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing pipeline in the specified workspace. Only the fields provided
        /// in the request are updated; fields not included in the request are preserved unchanged.
        /// You can update the pipeline description, environment variables, and the list of compute
        /// nodes independently.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.LimitExceededException">
        /// You've reached the quota for a resource. For example, this can occur if you're trying
        /// to associate more than the allowed number of child assets or attempting to create
        /// more than the allowed number of properties for an asset model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePortal

        internal virtual UpdatePortalResponse UpdatePortal(UpdatePortalRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return Invoke<UpdatePortalResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates an IoT SiteWise Monitor portal.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePortal service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        public virtual Task<UpdatePortalResponse> UpdatePortalAsync(UpdatePortalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePortalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePortalResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePortalResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProject

        internal virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
        /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
        /// up prior to that date. Existing customers can continue to use the service as normal.
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
        /// SiteWise Monitor availability change</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates an IoT SiteWise Monitor project.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTask

        internal virtual UpdateTaskResponse UpdateTask(UpdateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return Invoke<UpdateTaskResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing task in the specified workspace. Only the fields provided in the
        /// request are updated; fields not included in the request are preserved unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        public virtual Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWorkspace

        internal virtual UpdateWorkspaceResponse UpdateWorkspace(UpdateWorkspaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkspaceResponse>(request, options);
        }



        /// <summary>
        /// Updates a workspace. You can update only workspaces in the <c>ACTIVE</c> or <c>FAILED</c>
        /// state. Fields that you omit from the request are left unchanged. To recover a workspace
        /// in the <c>FAILED</c> state, call this operation and supply its encryption configuration
        /// again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by IoTSiteWise.</returns>
        /// <exception cref="Amazon.IoTSiteWise.Model.AccessDeniedException">
        /// Access is denied.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ConflictingOperationException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InternalFailureException">
        /// IoT SiteWise can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.InvalidRequestException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters. Check your request and try again.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.IoTSiteWise.Model.ThrottlingException">
        /// Your request exceeded a rate limit. For example, you might have exceeded the number
        /// of IoT SiteWise assets that can be created per second, the allowed number of messages
        /// per second, and so on.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotsitewise-2019-12-02/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        public virtual Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWorkspaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkspaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkspaceResponse>(request, options, cancellationToken);
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