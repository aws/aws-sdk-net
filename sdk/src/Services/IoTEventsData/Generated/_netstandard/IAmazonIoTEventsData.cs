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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTEventsData.Model;

#pragma warning disable CS1570
namespace Amazon.IoTEventsData
{
    /// <summary>
    /// <para>Interface for accessing IoTEventsData</para>
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
    public partial interface IAmazonIoTEventsData : IAmazonService, IDisposable
    {
                
        #region  BatchAcknowledgeAlarm



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
        Task<BatchAcknowledgeAlarmResponse> BatchAcknowledgeAlarmAsync(BatchAcknowledgeAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteDetector



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
        Task<BatchDeleteDetectorResponse> BatchDeleteDetectorAsync(BatchDeleteDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDisableAlarm



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
        Task<BatchDisableAlarmResponse> BatchDisableAlarmAsync(BatchDisableAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchEnableAlarm



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
        Task<BatchEnableAlarmResponse> BatchEnableAlarmAsync(BatchEnableAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        Task<BatchPutMessageResponse> BatchPutMessageAsync(BatchPutMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchResetAlarm



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
        Task<BatchResetAlarmResponse> BatchResetAlarmAsync(BatchResetAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchSnoozeAlarm



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
        Task<BatchSnoozeAlarmResponse> BatchSnoozeAlarmAsync(BatchSnoozeAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdateDetector



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
        Task<BatchUpdateDetectorResponse> BatchUpdateDetectorAsync(BatchUpdateDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAlarm



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
        Task<DescribeAlarmResponse> DescribeAlarmAsync(DescribeAlarmRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDetector



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
        Task<DescribeDetectorResponse> DescribeDetectorAsync(DescribeDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAlarms



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
        Task<ListAlarmsResponse> ListAlarmsAsync(ListAlarmsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDetectors



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
        Task<ListDetectorsResponse> ListDetectorsAsync(ListDetectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonIoTEventsDataConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonIoTEventsDataConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonIoTEventsDataConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonIoTEventsDataConfig to create AmazonIoTEventsDataClient");
            }

            return awsCredentials == null ? 
                    new AmazonIoTEventsDataClient(serviceClientConfig) :
                    new AmazonIoTEventsDataClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}