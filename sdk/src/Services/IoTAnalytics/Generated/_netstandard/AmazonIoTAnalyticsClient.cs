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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.IoTAnalytics
{
    /// <summary>
    /// <para>Implementation for accessing IoTAnalytics</para>
    ///
    /// IoT Analytics allows you to collect large amounts of device data, process messages,
    /// and store them. You can then query the data and run sophisticated analytics on it.
    /// IoT Analytics enables advanced data exploration through integration with Jupyter Notebooks
    /// and data visualization through integration with Amazon QuickSight.
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
    /// IoT Analytics automates the steps required to analyze data from IoT devices. IoT Analytics
    /// filters, transforms, and enriches IoT data before storing it in a time-series data
    /// store for analysis. You can set up the service to collect only the data you need from
    /// your devices, apply mathematical transforms to process the data, and enrich the data
    /// with device-specific metadata such as device type and location before storing it.
    /// Then, you can analyze your data by running queries using the built-in SQL query engine,
    /// or perform more complex analytics and machine learning inference. IoT Analytics includes
    /// pre-built models for common IoT use cases so you can answer questions like which devices
    /// are about to fail or which customers are at risk of abandoning their wearable devices.
    /// </para>
    /// </summary>
    public partial class AmazonIoTAnalyticsClient : AmazonServiceClient, IAmazonIoTAnalytics
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTAnalyticsMetadata();
        
        #region Constructors

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
            : base(new AmazonIoTAnalyticsConfig()) { }

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
            : base(new AmazonIoTAnalyticsConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
        private IIoTAnalyticsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTAnalyticsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTAnalyticsPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTAnalyticsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTAnalyticsAuthSchemeHandler());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return Invoke<BatchPutMessageResponse>(request, options);
        }



        /// <summary>
        /// Sends messages to a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutMessage service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual Task<BatchPutMessageResponse> BatchPutMessageAsync(BatchPutMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelPipelineReprocessing

        internal virtual CancelPipelineReprocessingResponse CancelPipelineReprocessing(CancelPipelineReprocessingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;

            return Invoke<CancelPipelineReprocessingResponse>(request, options);
        }



        /// <summary>
        /// Cancels the reprocessing of data through the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPipelineReprocessing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelPipelineReprocessing service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CancelPipelineReprocessing">REST API Reference for CancelPipelineReprocessing Operation</seealso>
        public virtual Task<CancelPipelineReprocessingResponse> CancelPipelineReprocessingAsync(CancelPipelineReprocessingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;

            return InvokeAsync<CancelPipelineReprocessingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateChannel

        internal virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }



        /// <summary>
        /// Used to create a channel. A channel collects data from an MQTT topic and archives
        /// the raw, unprocessed messages before publishing the data to a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual Task<CreateChannelResponse> CreateChannelAsync(CreateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelResponse>(request, options, cancellationToken);
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
        /// Used to create a dataset. A dataset stores data retrieved from a data store by applying
        /// a <c>queryAction</c> (a SQL query) or a <c>containerAction</c> (executing a containerized
        /// application). This operation creates the skeleton of a dataset. The dataset can be
        /// populated manually by calling <c>CreateDatasetContent</c> or automatically according
        /// to a trigger you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDatasetContent

        internal virtual CreateDatasetContentResponse CreateDatasetContent(CreateDatasetContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetContentResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetContentResponse>(request, options);
        }



        /// <summary>
        /// Creates the content of a dataset by applying a <c>queryAction</c> (a SQL query) or
        /// a <c>containerAction</c> (executing a containerized application).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatasetContent service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatasetContent">REST API Reference for CreateDatasetContent Operation</seealso>
        public virtual Task<CreateDatasetContentResponse> CreateDatasetContentAsync(CreateDatasetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateDatastore

        internal virtual CreateDatastoreResponse CreateDatastore(CreateDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return Invoke<CreateDatastoreResponse>(request, options);
        }



        /// <summary>
        /// Creates a data store, which is a repository for messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDatastore service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        public virtual Task<CreateDatastoreResponse> CreateDatastoreAsync(CreateDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatastoreResponse>(request, options, cancellationToken);
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
        /// Creates a pipeline. A pipeline consumes messages from a channel and allows you to
        /// process the messages before storing them in a data store. You must specify both a
        /// <c>channel</c> and a <c>datastore</c> activity and, optionally, as many as 23 additional
        /// activities in the <c>pipelineActivities</c> array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual Task<CreatePipelineResponse> CreatePipelineAsync(CreatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteChannel

        internal virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual Task<DeleteChannelResponse> DeleteChannelAsync(DeleteChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelResponse>(request, options, cancellationToken);
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
        /// Deletes the specified dataset.
        /// 
        ///  
        /// <para>
        /// You do not have to delete the content of the dataset before you perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual Task<DeleteDatasetResponse> DeleteDatasetAsync(DeleteDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDatasetContent

        internal virtual DeleteDatasetContentResponse DeleteDatasetContent(DeleteDatasetContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetContentResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetContentResponse>(request, options);
        }



        /// <summary>
        /// Deletes the content of the specified dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatasetContent service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatasetContent">REST API Reference for DeleteDatasetContent Operation</seealso>
        public virtual Task<DeleteDatasetContentResponse> DeleteDatasetContentAsync(DeleteDatasetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDatastore

        internal virtual DeleteDatastoreResponse DeleteDatastore(DeleteDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return Invoke<DeleteDatastoreResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDatastore service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        public virtual Task<DeleteDatastoreResponse> DeleteDatastoreAsync(DeleteDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatastoreResponse>(request, options, cancellationToken);
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
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual Task<DeletePipelineResponse> DeletePipelineAsync(DeletePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeChannel

        internal virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual Task<DescribeChannelResponse> DescribeChannelAsync(DescribeChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelResponse>(request, options, cancellationToken);
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
        /// <returns>The response from the DescribeDataset service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDatastore

        internal virtual DescribeDatastoreResponse DescribeDatastore(DescribeDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;

            return Invoke<DescribeDatastoreResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDatastore service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDatastore">REST API Reference for DescribeDatastore Operation</seealso>
        public virtual Task<DescribeDatastoreResponse> DescribeDatastoreAsync(DescribeDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatastoreResponse>(request, options, cancellationToken);
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
        /// Retrieves the current settings of the IoT Analytics logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoggingOptions service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
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
        /// Retrieves information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipeline service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        public virtual Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelineResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDatasetContent

        internal virtual GetDatasetContentResponse GetDatasetContent(GetDatasetContentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatasetContentResponseUnmarshaller.Instance;

            return Invoke<GetDatasetContentResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the contents of a dataset as presigned URIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatasetContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatasetContent service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/GetDatasetContent">REST API Reference for GetDatasetContent Operation</seealso>
        public virtual Task<GetDatasetContentResponse> GetDatasetContentAsync(GetDatasetContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatasetContentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListChannels

        internal virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual Task<ListChannelsResponse> ListChannelsAsync(ListChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatasetContents

        internal virtual ListDatasetContentsResponse ListDatasetContents(ListDatasetContentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetContentsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetContentsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about dataset contents that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetContents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasetContents service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasetContents">REST API Reference for ListDatasetContents Operation</seealso>
        public virtual Task<ListDatasetContentsResponse> ListDatasetContentsAsync(ListDatasetContentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetContentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetContentsResponse>(request, options, cancellationToken);
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
        /// Retrieves information about datasets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDatastores

        internal virtual ListDatastoresResponse ListDatastores(ListDatastoresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return Invoke<ListDatastoresResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of data stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatastores service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        public virtual Task<ListDatastoresResponse> ListDatastoresAsync(ListDatastoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatastoresResponse>(request, options, cancellationToken);
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
        /// Retrieves a list of pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual Task<ListPipelinesResponse> ListPipelinesAsync(ListPipelinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesResponse>(request, options, cancellationToken);
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
        /// Lists the tags (metadata) that you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Sets or updates the IoT Analytics logging options.
        /// 
        ///  
        /// <para>
        /// If you update the value of any <c>loggingOptions</c> field, it takes up to one minute
        /// for the change to take effect. Also, if you change the policy attached to the role
        /// you specified in the <c>roleArn</c> field (for example, to correct an invalid policy),
        /// it takes up to five minutes for that change to take effect. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutLoggingOptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RunPipelineActivity

        internal virtual RunPipelineActivityResponse RunPipelineActivity(RunPipelineActivityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunPipelineActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;

            return Invoke<RunPipelineActivityResponse>(request, options);
        }



        /// <summary>
        /// Simulates the results of running a pipeline activity on a message payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunPipelineActivity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunPipelineActivity service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/RunPipelineActivity">REST API Reference for RunPipelineActivity Operation</seealso>
        public virtual Task<RunPipelineActivityResponse> RunPipelineActivityAsync(RunPipelineActivityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunPipelineActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;

            return InvokeAsync<RunPipelineActivityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SampleChannelData

        internal virtual SampleChannelDataResponse SampleChannelData(SampleChannelDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleChannelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleChannelDataResponseUnmarshaller.Instance;

            return Invoke<SampleChannelDataResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a sample of messages from the specified channel ingested during the specified
        /// timeframe. Up to 10 messages can be retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleChannelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SampleChannelData service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/SampleChannelData">REST API Reference for SampleChannelData Operation</seealso>
        public virtual Task<SampleChannelDataResponse> SampleChannelDataAsync(SampleChannelDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleChannelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleChannelDataResponseUnmarshaller.Instance;

            return InvokeAsync<SampleChannelDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartPipelineReprocessing

        internal virtual StartPipelineReprocessingResponse StartPipelineReprocessing(StartPipelineReprocessingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;

            return Invoke<StartPipelineReprocessingResponse>(request, options);
        }



        /// <summary>
        /// Starts the reprocessing of raw message data through the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineReprocessing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPipelineReprocessing service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceAlreadyExistsException">
        /// A resource with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/StartPipelineReprocessing">REST API Reference for StartPipelineReprocessing Operation</seealso>
        public virtual Task<StartPipelineReprocessingResponse> StartPipelineReprocessingAsync(StartPipelineReprocessingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;

            return InvokeAsync<StartPipelineReprocessingResponse>(request, options, cancellationToken);
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
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateChannel

        internal virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }



        /// <summary>
        /// Used to update the settings of a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual Task<UpdateChannelResponse> UpdateChannelAsync(UpdateChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelResponse>(request, options, cancellationToken);
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
        /// Updates the settings of a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataset service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual Task<UpdateDatasetResponse> UpdateDatasetAsync(UpdateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateDatastore

        internal virtual UpdateDatastoreResponse UpdateDatastore(UpdateDatastoreRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatastoreResponseUnmarshaller.Instance;

            return Invoke<UpdateDatastoreResponse>(request, options);
        }



        /// <summary>
        /// Used to update the settings of a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatastore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDatastore service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDatastore">REST API Reference for UpdateDatastore Operation</seealso>
        public virtual Task<UpdateDatastoreResponse> UpdateDatastoreAsync(UpdateDatastoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatastoreResponse>(request, options, cancellationToken);
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
        /// Updates the settings of a pipeline. You must specify both a <c>channel</c> and a <c>datastore</c>
        /// activity and, optionally, as many as 23 additional activities in the <c>pipelineActivities</c>
        /// array.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by IoTAnalytics.</returns>
        /// <exception cref="Amazon.IoTAnalytics.Model.InternalFailureException">
        /// There was an internal failure.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.InvalidRequestException">
        /// The request was not valid.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.LimitExceededException">
        /// The command caused an internal limit to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ResourceNotFoundException">
        /// A resource with the specified name could not be found.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTAnalytics.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual Task<UpdatePipelineResponse> UpdatePipelineAsync(UpdatePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineResponse>(request, options, cancellationToken);
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