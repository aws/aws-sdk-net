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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTAnalytics.Model;
using Amazon.IoTAnalytics.Model.Internal.MarshallTransformations;
using Amazon.IoTAnalytics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTAnalytics
{
    /// <summary>
    /// Implementation for accessing IoTAnalytics
    ///
    /// AWS IoT Analytics allows you to collect large amounts of device data, process messages,
    /// and store them. You can then query the data and run sophisticated analytics on it.
    /// AWS IoT Analytics enables advanced data exploration through integration with Jupyter
    /// Notebooks and data visualization through integration with Amazon QuickSight.
    /// 
    ///  
    /// <para>
    /// Traditional analytics and business intelligence tools are designed to process structured
    /// data. IoT data often comes from devices that record noisy processes (such as temperature,
    /// motion, or sound). As a result the data from these devices can have significant gaps,
    /// corrupted messages, and false readings that must be cleaned up before analysis can
    /// occur. Also, IoT data is often only meaningful in the context of other data from external
    /// sources. 
    /// </para>
    ///  
    /// <para>
    /// AWS IoT Analytics automates the steps required to analyze data from IoT devices. AWS
    /// IoT Analytics filters, transforms, and enriches IoT data before storing it in a time-series
    /// data store for analysis. You can set up the service to collect only the data you need
    /// from your devices, apply mathematical transforms to process the data, and enrich the
    /// data with device-specific metadata such as device type and location before storing
    /// it. Then, you can analyze your data by running queries using the built-in SQL query
    /// engine, or perform more complex analytics and machine learning inference. AWS IoT
    /// Analytics includes pre-built models for common IoT use cases so you can answer questions
    /// like which devices are about to fail or which customers are at risk of abandoning
    /// their wearable devices.
    /// </para>
    /// </summary>
    public partial class AmazonIoTAnalyticsClient : AmazonServiceClient, IAmazonIoTAnalytics
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTAnalyticsMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with the credentials loaded from the application's
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
        public AmazonIoTAnalyticsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTAnalyticsConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with the credentials loaded from the application's
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
        public AmazonIoTAnalyticsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTAnalyticsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTAnalyticsClient Configuration Object</param>
        public AmazonIoTAnalyticsClient(AmazonIoTAnalyticsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTAnalyticsClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTAnalyticsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Credentials and an
        /// AmazonIoTAnalyticsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTAnalyticsClient Configuration Object</param>
        public AmazonIoTAnalyticsClient(AWSCredentials credentials, AmazonIoTAnalyticsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTAnalyticsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTAnalyticsClient Configuration Object</param>
        public AmazonIoTAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTAnalyticsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTAnalyticsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTAnalyticsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTAnalyticsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTAnalyticsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTAnalyticsClient Configuration Object</param>
        public AmazonIoTAnalyticsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTAnalyticsConfig clientConfig)
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


        #region  BatchPutMessage

        internal virtual BatchPutMessageResponse BatchPutMessage(BatchPutMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return Invoke<BatchPutMessageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual Task<BatchPutMessageResponse> BatchPutMessageAsync(BatchPutMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelPipelineReprocessing

        internal virtual CancelPipelineReprocessingResponse CancelPipelineReprocessing(CancelPipelineReprocessingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;

            return Invoke<CancelPipelineReprocessingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelPipelineReprocessing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CancelPipelineReprocessing">REST API Reference for CancelPipelineReprocessing Operation</seealso>
        public virtual Task<CancelPipelineReprocessingResponse> CancelPipelineReprocessingAsync(CancelPipelineReprocessingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;

            return InvokeAsync<CancelPipelineReprocessingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChannel

        internal virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatasetContent

        internal virtual CreateDatasetContentResponse CreateDatasetContent(CreateDatasetContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetContentResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetContentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetContent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatasetContent">REST API Reference for CreateDatasetContent Operation</seealso>
        public virtual Task<CreateDatasetContentResponse> CreateDatasetContentAsync(CreateDatasetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDatastore

        internal virtual CreateDatastoreResponse CreateDatastore(CreateDatastoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return Invoke<CreateDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        public virtual Task<CreateDatastoreResponse> CreateDatastoreAsync(CreateDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline

        internal virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannel

        internal virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataset

        internal virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatasetContent

        internal virtual DeleteDatasetContentResponse DeleteDatasetContent(DeleteDatasetContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetContentResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetContentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetContent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatasetContent">REST API Reference for DeleteDatasetContent Operation</seealso>
        public virtual Task<DeleteDatasetContentResponse> DeleteDatasetContentAsync(DeleteDatasetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatastore

        internal virtual DeleteDatastoreResponse DeleteDatastore(DeleteDatastoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return Invoke<DeleteDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        public virtual Task<DeleteDatastoreResponse> DeleteDatastoreAsync(DeleteDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline

        internal virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannel

        internal virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataset

        internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDatastore

        internal virtual DescribeDatastoreResponse DescribeDatastore(DescribeDatastoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;

            return Invoke<DescribeDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatastore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDatastore">REST API Reference for DescribeDatastore Operation</seealso>
        public virtual Task<DescribeDatastoreResponse> DescribeDatastoreAsync(DescribeDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoggingOptions

        internal virtual DescribeLoggingOptionsResponse DescribeLoggingOptions(DescribeLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual Task<DescribeLoggingOptionsResponse> DescribeLoggingOptionsAsync(DescribeLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePipeline

        internal virtual DescribePipelineResponse DescribePipeline(DescribePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return Invoke<DescribePipelineResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        public virtual Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDatasetContent

        internal virtual GetDatasetContentResponse GetDatasetContent(GetDatasetContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatasetContentResponseUnmarshaller.Instance;

            return Invoke<GetDatasetContentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatasetContent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/GetDatasetContent">REST API Reference for GetDatasetContent Operation</seealso>
        public virtual Task<GetDatasetContentResponse> GetDatasetContentAsync(GetDatasetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatasetContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChannels

        internal virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasetContents

        internal virtual ListDatasetContentsResponse ListDatasetContents(ListDatasetContentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetContentsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetContentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetContents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasetContents">REST API Reference for ListDatasetContents Operation</seealso>
        public virtual Task<ListDatasetContentsResponse> ListDatasetContentsAsync(ListDatasetContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetContentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetContentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasets

        internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatastores

        internal virtual ListDatastoresResponse ListDatastores(ListDatastoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return Invoke<ListDatastoresResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDatastores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        public virtual Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatastoresResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines

        internal virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLoggingOptions

        internal virtual PutLoggingOptionsResponse PutLoggingOptions(PutLoggingOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutLoggingOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutLoggingOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RunPipelineActivity

        internal virtual RunPipelineActivityResponse RunPipelineActivity(RunPipelineActivityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunPipelineActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;

            return Invoke<RunPipelineActivityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RunPipelineActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunPipelineActivity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/RunPipelineActivity">REST API Reference for RunPipelineActivity Operation</seealso>
        public virtual Task<RunPipelineActivityResponse> RunPipelineActivityAsync(RunPipelineActivityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunPipelineActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;

            return InvokeAsync<RunPipelineActivityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SampleChannelData

        internal virtual SampleChannelDataResponse SampleChannelData(SampleChannelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SampleChannelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleChannelDataResponseUnmarshaller.Instance;

            return Invoke<SampleChannelDataResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SampleChannelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SampleChannelData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/SampleChannelData">REST API Reference for SampleChannelData Operation</seealso>
        public virtual Task<SampleChannelDataResponse> SampleChannelDataAsync(SampleChannelDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SampleChannelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleChannelDataResponseUnmarshaller.Instance;

            return InvokeAsync<SampleChannelDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPipelineReprocessing

        internal virtual StartPipelineReprocessingResponse StartPipelineReprocessing(StartPipelineReprocessingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;

            return Invoke<StartPipelineReprocessingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineReprocessing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/StartPipelineReprocessing">REST API Reference for StartPipelineReprocessing Operation</seealso>
        public virtual Task<StartPipelineReprocessingResponse> StartPipelineReprocessingAsync(StartPipelineReprocessingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;

            return InvokeAsync<StartPipelineReprocessingResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannel

        internal virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataset

        internal virtual UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatastore

        internal virtual UpdateDatastoreResponse UpdateDatastore(UpdateDatastoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatastoreResponseUnmarshaller.Instance;

            return Invoke<UpdateDatastoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatastore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDatastore">REST API Reference for UpdateDatastore Operation</seealso>
        public virtual Task<UpdateDatastoreResponse> UpdateDatastoreAsync(UpdateDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatastoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipeline

        internal virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}