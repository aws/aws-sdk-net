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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTEventsData.Model;

namespace Amazon.IoTEventsData
{
    /// <summary>
    /// Interface for accessing IoTEventsData
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
        /// Acknowledges one or more alarms. The alarms change to the <code>ACKNOWLEDGED</code>
        /// state after you acknowledge them.
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
        BatchAcknowledgeAlarmResponse BatchAcknowledgeAlarm(BatchAcknowledgeAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAcknowledgeAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAcknowledgeAlarm operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAcknowledgeAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchAcknowledgeAlarm">REST API Reference for BatchAcknowledgeAlarm Operation</seealso>
        IAsyncResult BeginBatchAcknowledgeAlarm(BatchAcknowledgeAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAcknowledgeAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAcknowledgeAlarm.</param>
        /// 
        /// <returns>Returns a  BatchAcknowledgeAlarmResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchAcknowledgeAlarm">REST API Reference for BatchAcknowledgeAlarm Operation</seealso>
        BatchAcknowledgeAlarmResponse EndBatchAcknowledgeAlarm(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDisableAlarm


        /// <summary>
        /// Disables one or more alarms. The alarms change to the <code>DISABLED</code> state
        /// after you disable them.
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
        BatchDisableAlarmResponse BatchDisableAlarm(BatchDisableAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisableAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableAlarm operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisableAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchDisableAlarm">REST API Reference for BatchDisableAlarm Operation</seealso>
        IAsyncResult BeginBatchDisableAlarm(BatchDisableAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisableAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisableAlarm.</param>
        /// 
        /// <returns>Returns a  BatchDisableAlarmResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchDisableAlarm">REST API Reference for BatchDisableAlarm Operation</seealso>
        BatchDisableAlarmResponse EndBatchDisableAlarm(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchEnableAlarm


        /// <summary>
        /// Enables one or more alarms. The alarms change to the <code>NORMAL</code> state after
        /// you enable them.
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
        BatchEnableAlarmResponse BatchEnableAlarm(BatchEnableAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchEnableAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableAlarm operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchEnableAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchEnableAlarm">REST API Reference for BatchEnableAlarm Operation</seealso>
        IAsyncResult BeginBatchEnableAlarm(BatchEnableAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchEnableAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchEnableAlarm.</param>
        /// 
        /// <returns>Returns a  BatchEnableAlarmResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchEnableAlarm">REST API Reference for BatchEnableAlarm Operation</seealso>
        BatchEnableAlarmResponse EndBatchEnableAlarm(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchPutMessage


        /// <summary>
        /// Sends a set of messages to the IoT Events system. Each message payload is transformed
        /// into the input you specify (<code>"inputName"</code>) and ingested into any detectors
        /// that monitor that input. If multiple messages are sent, the order in which the messages
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
        BatchPutMessageResponse BatchPutMessage(BatchPutMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMessage operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        IAsyncResult BeginBatchPutMessage(BatchPutMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutMessage.</param>
        /// 
        /// <returns>Returns a  BatchPutMessageResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchPutMessage">REST API Reference for BatchPutMessage Operation</seealso>
        BatchPutMessageResponse EndBatchPutMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchResetAlarm


        /// <summary>
        /// Resets one or more alarms. The alarms return to the <code>NORMAL</code> state after
        /// you reset them.
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
        BatchResetAlarmResponse BatchResetAlarm(BatchResetAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchResetAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchResetAlarm operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchResetAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchResetAlarm">REST API Reference for BatchResetAlarm Operation</seealso>
        IAsyncResult BeginBatchResetAlarm(BatchResetAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchResetAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchResetAlarm.</param>
        /// 
        /// <returns>Returns a  BatchResetAlarmResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchResetAlarm">REST API Reference for BatchResetAlarm Operation</seealso>
        BatchResetAlarmResponse EndBatchResetAlarm(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchSnoozeAlarm


        /// <summary>
        /// Changes one or more alarms to the snooze mode. The alarms change to the <code>SNOOZE_DISABLED</code>
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
        BatchSnoozeAlarmResponse BatchSnoozeAlarm(BatchSnoozeAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchSnoozeAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchSnoozeAlarm operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchSnoozeAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchSnoozeAlarm">REST API Reference for BatchSnoozeAlarm Operation</seealso>
        IAsyncResult BeginBatchSnoozeAlarm(BatchSnoozeAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchSnoozeAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchSnoozeAlarm.</param>
        /// 
        /// <returns>Returns a  BatchSnoozeAlarmResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchSnoozeAlarm">REST API Reference for BatchSnoozeAlarm Operation</seealso>
        BatchSnoozeAlarmResponse EndBatchSnoozeAlarm(IAsyncResult asyncResult);

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
        BatchUpdateDetectorResponse BatchUpdateDetector(BatchUpdateDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateDetector operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        IAsyncResult BeginBatchUpdateDetector(BatchUpdateDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateDetector.</param>
        /// 
        /// <returns>Returns a  BatchUpdateDetectorResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/BatchUpdateDetector">REST API Reference for BatchUpdateDetector Operation</seealso>
        BatchUpdateDetectorResponse EndBatchUpdateDetector(IAsyncResult asyncResult);

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
        DescribeAlarmResponse DescribeAlarm(DescribeAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarm operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeAlarm">REST API Reference for DescribeAlarm Operation</seealso>
        IAsyncResult BeginDescribeAlarm(DescribeAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarm.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeAlarm">REST API Reference for DescribeAlarm Operation</seealso>
        DescribeAlarmResponse EndDescribeAlarm(IAsyncResult asyncResult);

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
        DescribeDetectorResponse DescribeDetector(DescribeDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        IAsyncResult BeginDescribeDetector(DescribeDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDetector.</param>
        /// 
        /// <returns>Returns a  DescribeDetectorResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        DescribeDetectorResponse EndDescribeDetector(IAsyncResult asyncResult);

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
        ListAlarmsResponse ListAlarms(ListAlarmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlarms operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlarms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListAlarms">REST API Reference for ListAlarms Operation</seealso>
        IAsyncResult BeginListAlarms(ListAlarmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlarms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlarms.</param>
        /// 
        /// <returns>Returns a  ListAlarmsResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListAlarms">REST API Reference for ListAlarms Operation</seealso>
        ListAlarmsResponse EndListAlarms(IAsyncResult asyncResult);

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
        ListDetectorsResponse ListDetectors(ListDetectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors operation on AmazonIoTEventsDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        IAsyncResult BeginListDetectors(ListDetectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDetectors.</param>
        /// 
        /// <returns>Returns a  ListDetectorsResult from IoTEventsData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-data-2018-10-23/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        ListDetectorsResponse EndListDetectors(IAsyncResult asyncResult);

        #endregion
        
    }
}