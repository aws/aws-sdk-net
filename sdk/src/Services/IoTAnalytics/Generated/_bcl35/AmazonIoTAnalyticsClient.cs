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
using System.Collections.Generic;
using System.Net;

using Amazon.IoTAnalytics.Model;
using Amazon.IoTAnalytics.Model.Internal.MarshallTransformations;
using Amazon.IoTAnalytics.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTAnalyticsEndpointResolver());
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return Invoke<BatchPutMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual IAsyncResult BeginBatchPutMessage(BatchPutMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutMessage.</param>
        /// 
        /// <returns>Returns a  BatchPutMessageResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual BatchPutMessageResponse EndBatchPutMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutMessageResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;

            return Invoke<CancelPipelineReprocessingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelPipelineReprocessing operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelPipelineReprocessing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CancelPipelineReprocessing">REST API Reference for CancelPipelineReprocessing Operation</seealso>
        public virtual IAsyncResult BeginCancelPipelineReprocessing(CancelPipelineReprocessingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelPipelineReprocessingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelPipelineReprocessing.</param>
        /// 
        /// <returns>Returns a  CancelPipelineReprocessingResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CancelPipelineReprocessing">REST API Reference for CancelPipelineReprocessing Operation</seealso>
        public virtual CancelPipelineReprocessingResponse EndCancelPipelineReprocessing(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelPipelineReprocessingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateChannel

        /// <summary>
        /// Used to create a channel. A channel collects data from an MQTT topic and archives
        /// the raw, unprocessed messages before publishing the data to a pipeline.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return Invoke<CreateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        public virtual CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataset

        /// <summary>
        /// Used to create a dataset. A dataset stores data retrieved from a data store by applying
        /// a <c>queryAction</c> (a SQL query) or a <c>containerAction</c> (executing a containerized
        /// application). This operation creates the skeleton of a dataset. The dataset can be
        /// populated manually by calling <c>CreateDatasetContent</c> or automatically according
        /// to a trigger you specify.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDatasetContent

        /// <summary>
        /// Creates the content of a dataset by applying a <c>queryAction</c> (a SQL query) or
        /// a <c>containerAction</c> (executing a containerized application).
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetContentResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetContent operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatasetContent">REST API Reference for CreateDatasetContent Operation</seealso>
        public virtual IAsyncResult BeginCreateDatasetContent(CreateDatasetContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetContent.</param>
        /// 
        /// <returns>Returns a  CreateDatasetContentResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatasetContent">REST API Reference for CreateDatasetContent Operation</seealso>
        public virtual CreateDatasetContentResponse EndCreateDatasetContent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatasetContentResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return Invoke<CreateDatastoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatastore operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        public virtual IAsyncResult BeginCreateDatastore(CreateDatastoreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatastoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatastore.</param>
        /// 
        /// <returns>Returns a  CreateDatastoreResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreateDatastore">REST API Reference for CreateDatastore Operation</seealso>
        public virtual CreateDatastoreResponse EndCreateDatastore(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDatastoreResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePipeline

        /// <summary>
        /// Creates a pipeline. A pipeline consumes messages from a channel and allows you to
        /// process the messages before storing them in a data store. You must specify both a
        /// <c>channel</c> and a <c>datastore</c> activity and, optionally, as many as 23 additional
        /// activities in the <c>pipelineActivities</c> array.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return Invoke<CreatePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        public virtual CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePipelineResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        public virtual DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataset

        /// <summary>
        /// Deletes the specified dataset.
        /// 
        ///  
        /// <para>
        /// You do not have to delete the content of the dataset before you perform this operation.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        public virtual DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDatasetContent

        /// <summary>
        /// Deletes the content of the specified dataset.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetContentResponseUnmarshaller.Instance;

            return Invoke<DeleteDatasetContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetContent operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatasetContent">REST API Reference for DeleteDatasetContent Operation</seealso>
        public virtual IAsyncResult BeginDeleteDatasetContent(DeleteDatasetContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatasetContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetContent.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetContentResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatasetContent">REST API Reference for DeleteDatasetContent Operation</seealso>
        public virtual DeleteDatasetContentResponse EndDeleteDatasetContent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatasetContentResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return Invoke<DeleteDatastoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatastore operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        public virtual IAsyncResult BeginDeleteDatastore(DeleteDatastoreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDatastoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatastore.</param>
        /// 
        /// <returns>Returns a  DeleteDatastoreResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeleteDatastore">REST API Reference for DeleteDatastore Operation</seealso>
        public virtual DeleteDatastoreResponse EndDeleteDatastore(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDatastoreResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return Invoke<DeletePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        public virtual DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePipelineResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return Invoke<DescribeChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        public virtual DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDataset

        /// <summary>
        /// Retrieves information about a dataset.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatasetResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;

            return Invoke<DescribeDatastoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatastore operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDatastore">REST API Reference for DescribeDatastore Operation</seealso>
        public virtual IAsyncResult BeginDescribeDatastore(DescribeDatastoreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatastoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatastore.</param>
        /// 
        /// <returns>Returns a  DescribeDatastoreResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeDatastore">REST API Reference for DescribeDatastore Operation</seealso>
        public virtual DescribeDatastoreResponse EndDescribeDatastore(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDatastoreResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoggingOptions

        /// <summary>
        /// Retrieves the current settings of the IoT Analytics logging options.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual IAsyncResult BeginDescribeLoggingOptions(DescribeLoggingOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingOptions.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingOptionsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        public virtual DescribeLoggingOptionsResponse EndDescribeLoggingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoggingOptionsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return Invoke<DescribePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipeline operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        public virtual IAsyncResult BeginDescribePipeline(DescribePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePipeline.</param>
        /// 
        /// <returns>Returns a  DescribePipelineResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/DescribePipeline">REST API Reference for DescribePipeline Operation</seealso>
        public virtual DescribePipelineResponse EndDescribePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDatasetContent

        /// <summary>
        /// Retrieves the contents of a dataset as presigned URIs.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatasetContentResponseUnmarshaller.Instance;

            return Invoke<GetDatasetContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDatasetContent operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDatasetContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/GetDatasetContent">REST API Reference for GetDatasetContent Operation</seealso>
        public virtual IAsyncResult BeginGetDatasetContent(GetDatasetContentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDatasetContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDatasetContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDatasetContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDatasetContent.</param>
        /// 
        /// <returns>Returns a  GetDatasetContentResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/GetDatasetContent">REST API Reference for GetDatasetContent Operation</seealso>
        public virtual GetDatasetContentResponse EndGetDatasetContent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDatasetContentResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return Invoke<ListChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListChannels">REST API Reference for ListChannels Operation</seealso>
        public virtual ListChannelsResponse EndListChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasetContents

        /// <summary>
        /// Lists information about dataset contents that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetContents service method.</param>
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
        public virtual ListDatasetContentsResponse ListDatasetContents(ListDatasetContentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetContentsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetContentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetContents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetContents operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetContents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasetContents">REST API Reference for ListDatasetContents Operation</seealso>
        public virtual IAsyncResult BeginListDatasetContents(ListDatasetContentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetContentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetContentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetContents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetContents.</param>
        /// 
        /// <returns>Returns a  ListDatasetContentsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasetContents">REST API Reference for ListDatasetContents Operation</seealso>
        public virtual ListDatasetContentsResponse EndListDatasetContents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetContentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDatasets

        /// <summary>
        /// Retrieves information about datasets.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatasetsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return Invoke<ListDatastoresResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatastores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatastores operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatastores
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        public virtual IAsyncResult BeginListDatastores(ListDatastoresRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDatastoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatastoresResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatastores operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatastores.</param>
        /// 
        /// <returns>Returns a  ListDatastoresResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListDatastores">REST API Reference for ListDatastores Operation</seealso>
        public virtual ListDatastoresResponse EndListDatastores(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDatastoresResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return Invoke<ListPipelinesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPipelinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipelinesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        public virtual ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPipelinesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags (metadata) that you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLoggingOptions

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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return Invoke<PutLoggingOptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual IAsyncResult BeginPutLoggingOptions(PutLoggingOptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLoggingOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLoggingOptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLoggingOptions.</param>
        /// 
        /// <returns>Returns a  PutLoggingOptionsResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        public virtual PutLoggingOptionsResponse EndPutLoggingOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLoggingOptionsResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunPipelineActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;

            return Invoke<RunPipelineActivityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunPipelineActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunPipelineActivity operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunPipelineActivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/RunPipelineActivity">REST API Reference for RunPipelineActivity Operation</seealso>
        public virtual IAsyncResult BeginRunPipelineActivity(RunPipelineActivityRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RunPipelineActivityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunPipelineActivityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunPipelineActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunPipelineActivity.</param>
        /// 
        /// <returns>Returns a  RunPipelineActivityResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/RunPipelineActivity">REST API Reference for RunPipelineActivity Operation</seealso>
        public virtual RunPipelineActivityResponse EndRunPipelineActivity(IAsyncResult asyncResult)
        {
            return EndInvoke<RunPipelineActivityResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleChannelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleChannelDataResponseUnmarshaller.Instance;

            return Invoke<SampleChannelDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SampleChannelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SampleChannelData operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSampleChannelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/SampleChannelData">REST API Reference for SampleChannelData Operation</seealso>
        public virtual IAsyncResult BeginSampleChannelData(SampleChannelDataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SampleChannelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SampleChannelDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SampleChannelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSampleChannelData.</param>
        /// 
        /// <returns>Returns a  SampleChannelDataResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/SampleChannelData">REST API Reference for SampleChannelData Operation</seealso>
        public virtual SampleChannelDataResponse EndSampleChannelData(IAsyncResult asyncResult)
        {
            return EndInvoke<SampleChannelDataResponse>(asyncResult);
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;

            return Invoke<StartPipelineReprocessingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipelineReprocessing operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPipelineReprocessing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/StartPipelineReprocessing">REST API Reference for StartPipelineReprocessing Operation</seealso>
        public virtual IAsyncResult BeginStartPipelineReprocessing(StartPipelineReprocessingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartPipelineReprocessingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipelineReprocessingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartPipelineReprocessing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPipelineReprocessing.</param>
        /// 
        /// <returns>Returns a  StartPipelineReprocessingResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/StartPipelineReprocessing">REST API Reference for StartPipelineReprocessing Operation</seealso>
        public virtual StartPipelineReprocessingResponse EndStartPipelineReprocessing(IAsyncResult asyncResult)
        {
            return EndInvoke<StartPipelineReprocessingResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateChannel

        /// <summary>
        /// Used to update the settings of a channel.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        public virtual UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataset

        /// <summary>
        /// Updates the settings of a dataset.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return Invoke<UpdateDatasetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataset operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataset(UpdateDatasetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatasetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataset.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDataset">REST API Reference for UpdateDataset Operation</seealso>
        public virtual UpdateDatasetResponse EndUpdateDataset(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDatasetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDatastore

        /// <summary>
        /// Used to update the settings of a data store.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatastoreResponseUnmarshaller.Instance;

            return Invoke<UpdateDatastoreResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatastore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatastore operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatastore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDatastore">REST API Reference for UpdateDatastore Operation</seealso>
        public virtual IAsyncResult BeginUpdateDatastore(UpdateDatastoreRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDatastoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDatastoreResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatastore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatastore.</param>
        /// 
        /// <returns>Returns a  UpdateDatastoreResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdateDatastore">REST API Reference for UpdateDatastore Operation</seealso>
        public virtual UpdateDatastoreResponse EndUpdateDatastore(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDatastoreResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePipeline

        /// <summary>
        /// Updates the settings of a pipeline. You must specify both a <c>channel</c> and a <c>datastore</c>
        /// activity and, optionally, as many as 23 additional activities in the <c>pipelineActivities</c>
        /// array.
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
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdatePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonIoTAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from IoTAnalytics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotanalytics-2017-11-27/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        public virtual UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePipelineResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonIoTAnalyticsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}