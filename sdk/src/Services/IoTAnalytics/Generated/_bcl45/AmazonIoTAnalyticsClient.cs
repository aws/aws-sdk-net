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

using Amazon.IoTAnalytics.Model;
using Amazon.IoTAnalytics.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoTAnalytics
{
    /// <summary>
    /// Implementation for accessing IoTAnalytics
    ///
    /// AWS IoT Analytics provides advanced data analysis for AWS IoT. It allows you to collect
    /// large amounts of device data, process messages, store them, and then query the data
    /// and run sophisticated analytics to make accurate decisions in your IoT applications
    /// and machine learning use cases. AWS IoT Analytics enables advanced data exploration
    /// through integration with Jupyter Notebooks and data visualization through integration
    /// with Amazon QuickSight.
    /// 
    ///  
    /// <para>
    /// Traditional analytics and business intelligence tools are designed to process structured
    /// data. IoT data often comes from devices that record noisy processes (such as temperature,
    /// motion, or sound). As a result, the data from these devices can have significant gaps,
    /// corrupted messages, and false readings that must be cleaned up before analysis can
    /// occur. Also, IoT data is often only meaningful in the context of other data from external
    /// sources. 
    /// </para>
    ///  
    /// <para>
    /// AWS IoT Analytics automates each of the steps required to analyze data from IoT devices.
    /// AWS IoT Analytics filters, transforms, and enriches IoT data before storing it in
    /// a time-series data store for analysis. You can set up the service to collect only
    /// the data you need from your devices, apply mathematical transforms to process the
    /// data, and enrich the data with device-specific metadata such as device type and location
    /// before storing it. Then, you can analyze your data by running queries using the built-in
    /// SQL query engine, or perform more complex analytics and machine learning inference.
    /// AWS IoT Analytics includes models for common IoT use cases so you can answer questions
    /// like which devices are about to fail or which customers are at risk of abandoning
    /// their wearable devices.
    /// </para>
    /// </summary>
    public partial class AmazonIoTAnalyticsClient : AmazonServiceClient, IAmazonIoTAnalytics
    {
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


        /// <summary>
        /// Sends messages to a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage service method.</param>
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
        public virtual BatchPutMessageResponse BatchPutMessage(BatchPutMessageRequest request)
        {
            var marshaller = BatchPutMessageRequestMarshaller.Instance;
            var unmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return Invoke<BatchPutMessageRequest,BatchPutMessageResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchPutMessageRequestMarshaller.Instance;
            var unmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutMessageRequest,BatchPutMessageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelPipelineReprocessing


        /// <summary>
        /// Cancels the reprocessing of data through the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelPipelineReprocessing service method.</param>
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
        public virtual CancelPipelineReprocessingResponse CancelPipelineReprocessing(CancelPipelineReprocessingRequest request)
        {
            var marshaller = CancelPipelineReprocessingRequestMarshaller.Instance;
            var unmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;

            return Invoke<CancelPipelineReprocessingRequest,CancelPipelineReprocessingResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CancelPipelineReprocessingRequestMarshaller.Instance;
            var unmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;

            return InvokeAsync<CancelPipelineReprocessingRequest,CancelPipelineReprocessingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Creates a channel. A channel collects data from an MQTT topic and archives the raw,
        /// unprocessed messages before publishing the data to a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
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
        public virtual CreateChannelResponse CreateChannel(CreateChannelRequest request)
        {
            var marshaller = CreateChannelRequestMarshaller.Instance;
            var unmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelRequest,CreateChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateChannelRequestMarshaller.Instance;
            var unmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChannelRequest,CreateChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDataset


        /// <summary>
        /// Creates a data set. A data set stores data retrieved from a data store by applying
        /// an SQL action.
        /// 
        ///  <note> 
        /// <para>
        /// This operation creates the skeleton of a data set. To populate the data set, call
        /// "CreateDatasetContent".
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
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
        public virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var marshaller = CreateDatasetRequestMarshaller.Instance;
            var unmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetRequest,CreateDatasetResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateDatasetRequestMarshaller.Instance;
            var unmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetRequest,CreateDatasetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDatasetContent


        /// <summary>
        /// Creates the content of a data set by applying an SQL action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetContent service method.</param>
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
        public virtual CreateDatasetContentResponse CreateDatasetContent(CreateDatasetContentRequest request)
        {
            var marshaller = CreateDatasetContentRequestMarshaller.Instance;
            var unmarshaller = CreateDatasetContentResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetContentRequest,CreateDatasetContentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateDatasetContentRequestMarshaller.Instance;
            var unmarshaller = CreateDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetContentRequest,CreateDatasetContentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDatastore


        /// <summary>
        /// Creates a data store, which is a repository for messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore service method.</param>
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
        public virtual CreateDatastoreResponse CreateDatastore(CreateDatastoreRequest request)
        {
            var marshaller = CreateDatastoreRequestMarshaller.Instance;
            var unmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return Invoke<CreateDatastoreRequest,CreateDatastoreResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateDatastoreRequestMarshaller.Instance;
            var unmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatastoreRequest,CreateDatastoreResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePipeline


        /// <summary>
        /// Creates a pipeline. A pipeline consumes messages from one or more channels and allows
        /// you to process the messages before storing them in a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
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
        public virtual CreatePipelineResponse CreatePipeline(CreatePipelineRequest request)
        {
            var marshaller = CreatePipelineRequestMarshaller.Instance;
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreatePipelineRequestMarshaller.Instance;
            var unmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePipelineRequest,CreatePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Deletes the specified channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
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
        public virtual DeleteChannelResponse DeleteChannel(DeleteChannelRequest request)
        {
            var marshaller = DeleteChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelRequest,DeleteChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteChannelRequestMarshaller.Instance;
            var unmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChannelRequest,DeleteChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes the specified data set.
        /// 
        ///  
        /// <para>
        /// You do not have to delete the content of the data set before you perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
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
        public virtual DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request)
        {
            var marshaller = DeleteDatasetRequestMarshaller.Instance;
            var unmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetRequest,DeleteDatasetResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteDatasetRequestMarshaller.Instance;
            var unmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetRequest,DeleteDatasetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatasetContent


        /// <summary>
        /// Deletes the content of the specified data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetContent service method.</param>
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
        public virtual DeleteDatasetContentResponse DeleteDatasetContent(DeleteDatasetContentRequest request)
        {
            var marshaller = DeleteDatasetContentRequestMarshaller.Instance;
            var unmarshaller = DeleteDatasetContentResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetContentRequest,DeleteDatasetContentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteDatasetContentRequestMarshaller.Instance;
            var unmarshaller = DeleteDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatasetContentRequest,DeleteDatasetContentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDatastore


        /// <summary>
        /// Deletes the specified data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore service method.</param>
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
        public virtual DeleteDatastoreResponse DeleteDatastore(DeleteDatastoreRequest request)
        {
            var marshaller = DeleteDatastoreRequestMarshaller.Instance;
            var unmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return Invoke<DeleteDatastoreRequest,DeleteDatastoreResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteDatastoreRequestMarshaller.Instance;
            var unmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDatastoreRequest,DeleteDatastoreResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// Deletes the specified pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
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
        public virtual DeletePipelineResponse DeletePipeline(DeletePipelineRequest request)
        {
            var marshaller = DeletePipelineRequestMarshaller.Instance;
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeletePipelineRequestMarshaller.Instance;
            var unmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePipelineRequest,DeletePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeChannel


        /// <summary>
        /// Retrieves information about a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
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
        public virtual DescribeChannelResponse DescribeChannel(DescribeChannelRequest request)
        {
            var marshaller = DescribeChannelRequestMarshaller.Instance;
            var unmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelRequest,DescribeChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeChannelRequestMarshaller.Instance;
            var unmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChannelRequest,DescribeChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Retrieves information about a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
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
        public virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var marshaller = DescribeDatasetRequestMarshaller.Instance;
            var unmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetRequest,DescribeDatasetResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeDatasetRequestMarshaller.Instance;
            var unmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetRequest,DescribeDatasetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDatastore


        /// <summary>
        /// Retrieves information about a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatastore service method.</param>
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
        public virtual DescribeDatastoreResponse DescribeDatastore(DescribeDatastoreRequest request)
        {
            var marshaller = DescribeDatastoreRequestMarshaller.Instance;
            var unmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;

            return Invoke<DescribeDatastoreRequest,DescribeDatastoreResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeDatastoreRequestMarshaller.Instance;
            var unmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatastoreRequest,DescribeDatastoreResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoggingOptions


        /// <summary>
        /// Retrieves the current settings of the AWS IoT Analytics logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
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
        public virtual DescribeLoggingOptionsResponse DescribeLoggingOptions(DescribeLoggingOptionsRequest request)
        {
            var marshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingOptionsRequest,DescribeLoggingOptionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingOptionsRequest,DescribeLoggingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePipeline


        /// <summary>
        /// Retrieves information about a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline service method.</param>
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
        public virtual DescribePipelineResponse DescribePipeline(DescribePipelineRequest request)
        {
            var marshaller = DescribePipelineRequestMarshaller.Instance;
            var unmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return Invoke<DescribePipelineRequest,DescribePipelineResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribePipelineRequestMarshaller.Instance;
            var unmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePipelineRequest,DescribePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDatasetContent


        /// <summary>
        /// Retrieves the contents of a data set as pre-signed URIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatasetContent service method.</param>
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
        public virtual GetDatasetContentResponse GetDatasetContent(GetDatasetContentRequest request)
        {
            var marshaller = GetDatasetContentRequestMarshaller.Instance;
            var unmarshaller = GetDatasetContentResponseUnmarshaller.Instance;

            return Invoke<GetDatasetContentRequest,GetDatasetContentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDatasetContentRequestMarshaller.Instance;
            var unmarshaller = GetDatasetContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDatasetContentRequest,GetDatasetContentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Retrieves a list of channels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
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
        public virtual ListChannelsResponse ListChannels(ListChannelsRequest request)
        {
            var marshaller = ListChannelsRequestMarshaller.Instance;
            var unmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsRequest,ListChannelsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListChannelsRequestMarshaller.Instance;
            var unmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChannelsRequest,ListChannelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Retrieves information about data sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
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
        public virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var marshaller = ListDatasetsRequestMarshaller.Instance;
            var unmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsRequest,ListDatasetsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListDatasetsRequestMarshaller.Instance;
            var unmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsRequest,ListDatasetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDatastores


        /// <summary>
        /// Retrieves a list of data stores.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores service method.</param>
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
        public virtual ListDatastoresResponse ListDatastores(ListDatastoresRequest request)
        {
            var marshaller = ListDatastoresRequestMarshaller.Instance;
            var unmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return Invoke<ListDatastoresRequest,ListDatastoresResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListDatastoresRequestMarshaller.Instance;
            var unmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatastoresRequest,ListDatastoresResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// Retrieves a list of pipelines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
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
        public virtual ListPipelinesResponse ListPipelines(ListPipelinesRequest request)
        {
            var marshaller = ListPipelinesRequestMarshaller.Instance;
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListPipelinesRequestMarshaller.Instance;
            var unmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPipelinesRequest,ListPipelinesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutLoggingOptions


        /// <summary>
        /// Sets or updates the AWS IoT Analytics logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
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
        public virtual PutLoggingOptionsResponse PutLoggingOptions(PutLoggingOptionsRequest request)
        {
            var marshaller = PutLoggingOptionsRequestMarshaller.Instance;
            var unmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutLoggingOptionsRequest,PutLoggingOptionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutLoggingOptionsRequestMarshaller.Instance;
            var unmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<PutLoggingOptionsRequest,PutLoggingOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunPipelineActivity


        /// <summary>
        /// Simulates the results of running a pipeline activity on a message payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunPipelineActivity service method.</param>
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
        public virtual RunPipelineActivityResponse RunPipelineActivity(RunPipelineActivityRequest request)
        {
            var marshaller = RunPipelineActivityRequestMarshaller.Instance;
            var unmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;

            return Invoke<RunPipelineActivityRequest,RunPipelineActivityResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RunPipelineActivityRequestMarshaller.Instance;
            var unmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;

            return InvokeAsync<RunPipelineActivityRequest,RunPipelineActivityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SampleChannelData


        /// <summary>
        /// Retrieves a sample of messages from the specified channel ingested during the specified
        /// timeframe. Up to 10 messages can be retrieved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SampleChannelData service method.</param>
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
        public virtual SampleChannelDataResponse SampleChannelData(SampleChannelDataRequest request)
        {
            var marshaller = SampleChannelDataRequestMarshaller.Instance;
            var unmarshaller = SampleChannelDataResponseUnmarshaller.Instance;

            return Invoke<SampleChannelDataRequest,SampleChannelDataResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SampleChannelDataRequestMarshaller.Instance;
            var unmarshaller = SampleChannelDataResponseUnmarshaller.Instance;

            return InvokeAsync<SampleChannelDataRequest,SampleChannelDataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartPipelineReprocessing


        /// <summary>
        /// Starts the reprocessing of raw message data through the pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineReprocessing service method.</param>
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
        public virtual StartPipelineReprocessingResponse StartPipelineReprocessing(StartPipelineReprocessingRequest request)
        {
            var marshaller = StartPipelineReprocessingRequestMarshaller.Instance;
            var unmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;

            return Invoke<StartPipelineReprocessingRequest,StartPipelineReprocessingResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartPipelineReprocessingRequestMarshaller.Instance;
            var unmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;

            return InvokeAsync<StartPipelineReprocessingRequest,StartPipelineReprocessingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates the settings of a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
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
        public virtual UpdateChannelResponse UpdateChannel(UpdateChannelRequest request)
        {
            var marshaller = UpdateChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelRequest,UpdateChannelResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateChannelRequestMarshaller.Instance;
            var unmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateChannelRequest,UpdateChannelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDataset


        /// <summary>
        /// Updates the settings of a data set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset service method.</param>
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
        public virtual UpdateDatasetResponse UpdateDataset(UpdateDatasetRequest request)
        {
            var marshaller = UpdateDatasetRequestMarshaller.Instance;
            var unmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetRequest,UpdateDatasetResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateDatasetRequestMarshaller.Instance;
            var unmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatasetRequest,UpdateDatasetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDatastore


        /// <summary>
        /// Updates the settings of a data store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatastore service method.</param>
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
        public virtual UpdateDatastoreResponse UpdateDatastore(UpdateDatastoreRequest request)
        {
            var marshaller = UpdateDatastoreRequestMarshaller.Instance;
            var unmarshaller = UpdateDatastoreResponseUnmarshaller.Instance;

            return Invoke<UpdateDatastoreRequest,UpdateDatastoreResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateDatastoreRequestMarshaller.Instance;
            var unmarshaller = UpdateDatastoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDatastoreRequest,UpdateDatastoreResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Updates the settings of a pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
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
        public virtual UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request)
        {
            var marshaller = UpdatePipelineRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdatePipelineRequestMarshaller.Instance;
            var unmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePipelineRequest,UpdatePipelineResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}