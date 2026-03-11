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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTEventsData.Model;
using Amazon.IoTEventsData.Model.Internal.MarshallTransformations;
using Amazon.IoTEventsData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.IoTEventsData
{
    /// <summary>
    /// <para>Implementation for accessing IoTEventsData</para>
    ///
    /// IoT Events monitors your equipment or device fleets for failures or changes in operation,
    /// and triggers actions when such events occur. You can use IoT Events Data API commands
    /// to send inputs to detectors, list detectors, and view or update a detector's status.
    /// 
    ///  
    /// <para>
    ///  For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/what-is-iotevents.html">What
    /// is IoT Events?</a> in the <i>IoT Events Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonIoTEventsDataClient : AmazonServiceClient, IAmazonIoTEventsData
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTEventsDataMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with the credentials loaded from the application's
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
        public AmazonIoTEventsDataClient()
            : base(new AmazonIoTEventsDataConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with the credentials loaded from the application's
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
        public AmazonIoTEventsDataClient(RegionEndpoint region)
            : base(new AmazonIoTEventsDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTEventsDataClient Configuration Object</param>
        public AmazonIoTEventsDataClient(AmazonIoTEventsDataConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTEventsDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTEventsDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTEventsDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Credentials and an
        /// AmazonIoTEventsDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTEventsDataClient Configuration Object</param>
        public AmazonIoTEventsDataClient(AWSCredentials credentials, AmazonIoTEventsDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTEventsDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTEventsDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTEventsDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTEventsDataClient Configuration Object</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTEventsDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTEventsDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTEventsDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTEventsDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTEventsDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTEventsDataClient Configuration Object</param>
        public AmazonIoTEventsDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTEventsDataConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTEventsDataEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTEventsDataAuthSchemeHandler());
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


        #region  BatchAcknowledgeAlarm


        /// <summary>
        /// Acknowledges one or more alarms. The alarms change to the <c>ACKNOWLEDGED</c> state
        /// after you acknowledge them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAcknowledgeAlarm service method.</param>
        /// 
        /// <returns>The response from the BatchAcknowledgeAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchAcknowledgeAlarm">REST API Reference for BatchAcknowledgeAlarm Operation</seealso>
        public virtual BatchAcknowledgeAlarmResponse BatchAcknowledgeAlarm(BatchAcknowledgeAlarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAcknowledgeAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAcknowledgeAlarmResponseUnmarshaller.Instance;

            return Invoke<BatchAcknowledgeAlarmResponse>(request, options);
        }


        /// <summary>
        /// Acknowledges one or more alarms. The alarms change to the <c>ACKNOWLEDGED</c> state
        /// after you acknowledge them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAcknowledgeAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchAcknowledgeAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchAcknowledgeAlarm">REST API Reference for BatchAcknowledgeAlarm Operation</seealso>
        public virtual Task<BatchAcknowledgeAlarmResponse> BatchAcknowledgeAlarmAsync(BatchAcknowledgeAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchAcknowledgeAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchAcknowledgeAlarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchAcknowledgeAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteDetector


        /// <summary>
        /// Deletes one or more detectors that were created. When a detector is deleted, its state
        /// will be cleared and the detector will be removed from the list of detectors. The deleted
        /// detector will no longer appear if referenced in the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_iotevents-data_ListDetectors.html">ListDetectors</a>
        /// API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDetector service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchDeleteDetector">REST API Reference for BatchDeleteDetector Operation</seealso>
        public virtual BatchDeleteDetectorResponse BatchDeleteDetector(BatchDeleteDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDetectorResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteDetectorResponse>(request, options);
        }


        /// <summary>
        /// Deletes one or more detectors that were created. When a detector is deleted, its state
        /// will be cleared and the detector will be removed from the list of detectors. The deleted
        /// detector will no longer appear if referenced in the <a href="https://docs.aws.amazon.com/iotevents/latest/apireference/API_iotevents-data_ListDetectors.html">ListDetectors</a>
        /// API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchDeleteDetector">REST API Reference for BatchDeleteDetector Operation</seealso>
        public virtual Task<BatchDeleteDetectorResponse> BatchDeleteDetectorAsync(BatchDeleteDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDeleteDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteDetectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDeleteDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDisableAlarm


        /// <summary>
        /// Disables one or more alarms. The alarms change to the <c>DISABLED</c> state after
        /// you disable them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableAlarm service method.</param>
        /// 
        /// <returns>The response from the BatchDisableAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchDisableAlarm">REST API Reference for BatchDisableAlarm Operation</seealso>
        public virtual BatchDisableAlarmResponse BatchDisableAlarm(BatchDisableAlarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisableAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisableAlarmResponseUnmarshaller.Instance;

            return Invoke<BatchDisableAlarmResponse>(request, options);
        }


        /// <summary>
        /// Disables one or more alarms. The alarms change to the <c>DISABLED</c> state after
        /// you disable them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDisableAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchDisableAlarm">REST API Reference for BatchDisableAlarm Operation</seealso>
        public virtual Task<BatchDisableAlarmResponse> BatchDisableAlarmAsync(BatchDisableAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchDisableAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDisableAlarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchDisableAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchEnableAlarm


        /// <summary>
        /// Enables one or more alarms. The alarms change to the <c>NORMAL</c> state after you
        /// enable them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableAlarm service method.</param>
        /// 
        /// <returns>The response from the BatchEnableAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchEnableAlarm">REST API Reference for BatchEnableAlarm Operation</seealso>
        public virtual BatchEnableAlarmResponse BatchEnableAlarm(BatchEnableAlarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchEnableAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEnableAlarmResponseUnmarshaller.Instance;

            return Invoke<BatchEnableAlarmResponse>(request, options);
        }


        /// <summary>
        /// Enables one or more alarms. The alarms change to the <c>NORMAL</c> state after you
        /// enable them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchEnableAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchEnableAlarm">REST API Reference for BatchEnableAlarm Operation</seealso>
        public virtual Task<BatchEnableAlarmResponse> BatchEnableAlarmAsync(BatchEnableAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchEnableAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchEnableAlarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchEnableAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchPutMessage


        /// <summary>
        /// Sends a set of messages to the IoT Events system. Each message payload is transformed
        /// into the input you specify (<c>"inputName"</c>) and ingested into any detectors that
        /// monitor that input. If multiple messages are sent, the order in which the messages
        /// are processed isn't guaranteed. To guarantee ordering, you must send messages one
        /// at a time and wait for a successful response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage service method.</param>
        /// 
        /// <returns>The response from the BatchPutMessage service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual BatchPutMessageResponse BatchPutMessage(BatchPutMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;

            return Invoke<BatchPutMessageResponse>(request, options);
        }


        /// <summary>
        /// Sends a set of messages to the IoT Events system. Each message payload is transformed
        /// into the input you specify (<c>"inputName"</c>) and ingested into any detectors that
        /// monitor that input. If multiple messages are sent, the order in which the messages
        /// are processed isn't guaranteed. To guarantee ordering, you must send messages one
        /// at a time and wait for a successful response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutMessage service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        public virtual Task<BatchPutMessageResponse> BatchPutMessageAsync(BatchPutMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutMessageResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchPutMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchResetAlarm


        /// <summary>
        /// Resets one or more alarms. The alarms return to the <c>NORMAL</c> state after you
        /// reset them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchResetAlarm service method.</param>
        /// 
        /// <returns>The response from the BatchResetAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchResetAlarm">REST API Reference for BatchResetAlarm Operation</seealso>
        public virtual BatchResetAlarmResponse BatchResetAlarm(BatchResetAlarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchResetAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchResetAlarmResponseUnmarshaller.Instance;

            return Invoke<BatchResetAlarmResponse>(request, options);
        }


        /// <summary>
        /// Resets one or more alarms. The alarms return to the <c>NORMAL</c> state after you
        /// reset them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchResetAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchResetAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchResetAlarm">REST API Reference for BatchResetAlarm Operation</seealso>
        public virtual Task<BatchResetAlarmResponse> BatchResetAlarmAsync(BatchResetAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchResetAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchResetAlarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchResetAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchSnoozeAlarm


        /// <summary>
        /// Changes one or more alarms to the snooze mode. The alarms change to the <c>SNOOZE_DISABLED</c>
        /// state after you set them to the snooze mode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchSnoozeAlarm service method.</param>
        /// 
        /// <returns>The response from the BatchSnoozeAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchSnoozeAlarm">REST API Reference for BatchSnoozeAlarm Operation</seealso>
        public virtual BatchSnoozeAlarmResponse BatchSnoozeAlarm(BatchSnoozeAlarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchSnoozeAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchSnoozeAlarmResponseUnmarshaller.Instance;

            return Invoke<BatchSnoozeAlarmResponse>(request, options);
        }


        /// <summary>
        /// Changes one or more alarms to the snooze mode. The alarms change to the <c>SNOOZE_DISABLED</c>
        /// state after you set them to the snooze mode.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchSnoozeAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchSnoozeAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchSnoozeAlarm">REST API Reference for BatchSnoozeAlarm Operation</seealso>
        public virtual Task<BatchSnoozeAlarmResponse> BatchSnoozeAlarmAsync(BatchSnoozeAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchSnoozeAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchSnoozeAlarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchSnoozeAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchUpdateDetector


        /// <summary>
        /// Updates the state, variable values, and timer settings of one or more detectors (instances)
        /// of a specified detector model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDetector service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        public virtual BatchUpdateDetectorResponse BatchUpdateDetector(BatchUpdateDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateDetectorResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateDetectorResponse>(request, options);
        }


        /// <summary>
        /// Updates the state, variable values, and timer settings of one or more detectors (instances)
        /// of a specified detector model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        public virtual Task<BatchUpdateDetectorResponse> BatchUpdateDetectorAsync(BatchUpdateDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateDetectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchUpdateDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlarm


        /// <summary>
        /// Retrieves information about an alarm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarm service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeAlarm">REST API Reference for DescribeAlarm Operation</seealso>
        public virtual DescribeAlarmResponse DescribeAlarm(DescribeAlarmRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about an alarm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlarm service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeAlarm">REST API Reference for DescribeAlarm Operation</seealso>
        public virtual Task<DescribeAlarmResponse> DescribeAlarmAsync(DescribeAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAlarmResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDetector


        /// <summary>
        /// Returns information about the specified detector (instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual DescribeDetectorResponse DescribeDetector(DescribeDetectorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;

            return Invoke<DescribeDetectorResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified detector (instance).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        public virtual Task<DescribeDetectorResponse> DescribeDetectorAsync(DescribeDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDetectorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeDetectorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAlarms


        /// <summary>
        /// Lists one or more alarms. The operation returns only the metadata associated with
        /// each alarm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlarms service method.</param>
        /// 
        /// <returns>The response from the ListAlarms service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListAlarms">REST API Reference for ListAlarms Operation</seealso>
        public virtual ListAlarmsResponse ListAlarms(ListAlarmsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmsResponseUnmarshaller.Instance;

            return Invoke<ListAlarmsResponse>(request, options);
        }


        /// <summary>
        /// Lists one or more alarms. The operation returns only the metadata associated with
        /// each alarm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlarms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlarms service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListAlarms">REST API Reference for ListAlarms Operation</seealso>
        public virtual Task<ListAlarmsResponse> ListAlarmsAsync(ListAlarmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAlarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAlarmsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDetectors


        /// <summary>
        /// Lists detectors (the instances of a detector model).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual ListDetectorsResponse ListDetectors(ListDetectorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorsResponseUnmarshaller.Instance;

            return Invoke<ListDetectorsResponse>(request, options);
        }


        /// <summary>
        /// Lists detectors (the instances of a detector model).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by IoTEventsData.</returns>
        /// <exception cref="Amazon.IoTEventsData.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEventsData.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        public virtual Task<ListDetectorsResponse> ListDetectorsAsync(ListDetectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDetectorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListDetectorsResponse>(request, options, cancellationToken);
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