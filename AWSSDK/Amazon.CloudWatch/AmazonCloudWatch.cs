/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;

using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Interface for accessing AmazonCloudWatch.
    ///  
    ///  Amazon CloudWatch <para>This is the <i>Amazon CloudWatch API Reference</i> . This guide provides detailed information about Amazon
    /// CloudWatch actions, data types, parameters, and errors. For detailed information about Amazon CloudWatch features and their associated API
    /// calls, go to the Amazon CloudWatch Developer Guide. </para> <para>Amazon CloudWatch is a web service that enables you to publish, monitor,
    /// and manage various metrics, as well as configure alarm actions based on data from metrics. For more information about this product go to
    /// http://aws.amazon.com/cloudwatch. </para> <para> For information about the namespace, metric names, and dimensions that other Amazon Web
    /// Services products use to send metrics to Cloudwatch, go to Amazon CloudWatch Metrics, Namespaces, and Dimensions Reference in the <i>Amazon
    /// CloudWatch Developer Guide</i> .
    /// </para> <para>Use the following links to get started using the <i>Amazon CloudWatch API Reference</i> :</para>
    /// <ul>
    /// <li> Actions: An alphabetical list of all Amazon CloudWatch actions.</li>
    /// <li> Data Types: An alphabetical list of all Amazon CloudWatch data types.</li>
    /// <li> Common Parameters: Parameters that all Query actions can use.</li>
    /// <li> Common Errors: Client and server errors that all actions can return.</li>
    /// <li> Regions and Endpoints: Itemized regions and endpoints for all AWS products.</li>
    /// <li> WSDL Location: http://monitoring.amazonaws.com/doc/2010-08-01/CloudWatch.wsdl</li>
    /// 
    /// </ul>
    /// </summary>
    public interface AmazonCloudWatch : IDisposable
    {
        

        #region PutMetricAlarm

        /// <summary>
        /// <para> Creates or updates an alarm and associates it with the specified Amazon CloudWatch metric. Optionally, this operation can associate
        /// one or more Amazon Simple Notification Service resources with the alarm. </para> <para> When this operation creates an alarm, the alarm
        /// state is immediately set to <c>INSUFFICIENT_DATA</c> . The alarm is evaluated and its <c>StateValue</c> is set appropriately. Any actions
        /// associated with the <c>StateValue</c> is then executed. </para> <para><b>NOTE:</b> When updating an existing alarm, its StateValue is left
        /// unchanged. </para>
        /// </summary>
        /// 
        /// <param name="putMetricAlarmRequest">Container for the necessary parameters to execute the PutMetricAlarm service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <exception cref="LimitExceededException"/>
        PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest putMetricAlarmRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.PutMetricAlarm"/>
        /// </summary>
        /// 
        /// <param name="putMetricAlarmRequest">Container for the necessary parameters to execute the PutMetricAlarm operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutMetricAlarm(PutMetricAlarmRequest putMetricAlarmRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutMetricAlarm operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.PutMetricAlarm"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricAlarm.</param>
        PutMetricAlarmResponse EndPutMetricAlarm(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutMetricData

        /// <summary>
        /// <para> Publishes metric data points to Amazon CloudWatch. Amazon Cloudwatch associates the data points with the specified metric. If the
        /// specified metric does not exist, Amazon CloudWatch creates the metric. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. </para> <para> The size of a
        /// PutMetricData request is limited to 8 KB for HTTP GET requests and 40 KB for HTTP POST requests. </para> <para><b>IMPORTANT:</b> Although
        /// the Value parameter accepts numbers of type Double, Amazon CloudWatch truncates values with very large exponents. Values with base-10
        /// exponents greater than 126 (1 x 10^126) are truncated. Likewise, values with base-10 exponents less than -130 (1 x 10^-130) are also
        /// truncated. </para>
        /// </summary>
        /// 
        /// <param name="putMetricDataRequest">Container for the necessary parameters to execute the PutMetricData service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="MissingRequiredParameterException"/>
        PutMetricDataResponse PutMetricData(PutMetricDataRequest putMetricDataRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.PutMetricData"/>
        /// </summary>
        /// 
        /// <param name="putMetricDataRequest">Container for the necessary parameters to execute the PutMetricData operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutMetricData(PutMetricDataRequest putMetricDataRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutMetricData operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.PutMetricData"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricData.</param>
        PutMetricDataResponse EndPutMetricData(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListMetrics

        /// <summary>
        /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with GetMetricStatistics to obtain
        /// statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
        /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. Statistics about the metric,
        /// however, are available sooner using GetMetricStatistics. </para>
        /// </summary>
        /// 
        /// <param name="listMetricsRequest">Container for the necessary parameters to execute the ListMetrics service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="InvalidParameterValueException"/>
        ListMetricsResponse ListMetrics(ListMetricsRequest listMetricsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.ListMetrics"/>
        /// </summary>
        /// 
        /// <param name="listMetricsRequest">Container for the necessary parameters to execute the ListMetrics operation on AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetrics
        ///         operation.</returns>
        IAsyncResult BeginListMetrics(ListMetricsRequest listMetricsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListMetrics operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.ListMetrics"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetrics.</param>
        /// 
        /// <returns>Returns a ListMetricsResult from AmazonCloudWatch.</returns>
        ListMetricsResponse EndListMetrics(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with GetMetricStatistics to obtain
        /// statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
        /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. Statistics about the metric,
        /// however, are available sooner using GetMetricStatistics. </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="InvalidParameterValueException"/>
        ListMetricsResponse ListMetrics();
        
        #endregion
        
    

        #region GetMetricStatistics

        /// <summary>
        /// <para> Gets statistics for the specified metric. </para> <para><b>NOTE:</b> The maximum number of data points returned from a single
        /// GetMetricStatistics request is 1,440. If a request is made that generates more than 1,440 data points, Amazon CloudWatch returns an error.
        /// In such a case, alter the request by narrowing the specified time range or increasing the specified period. Alternatively, make multiple
        /// requests across adjacent time ranges. </para> <para> Amazon CloudWatch aggregates data points based on the length of the <c>period</c> that
        /// you specify. For example, if you request statistics with a one-minute granularity, Amazon CloudWatch aggregates data points with time stamps
        /// that fall within the same one-minute period. In such a case, the data points queried can greatly outnumber the data points returned. </para>
        /// <para><b>NOTE:</b> The maximum number of data points that can be queried is 50,850; whereas the maximum number of data points returned is
        /// 1,440. </para> <para> The following examples show various statistics allowed by the data point query maximum of 50,850 when you call
        /// <c>GetMetricStatistics</c> on Amazon EC2 instances with detailed (one-minute) monitoring enabled: </para>
        /// <ul>
        /// <li>Statistics for up to 400 instances for a span of one hour</li>
        /// <li>Statistics for up to 35 instances over a span of 24 hours</li>
        /// <li>Statistics for up to 2 instances over a span of 2 weeks</li>
        /// 
        /// </ul>
        /// <para> For information about the namespace, metric names, and dimensions that other Amazon Web Services products use to send metrics to
        /// Cloudwatch, go to Amazon CloudWatch Metrics, Namespaces, and Dimensions Reference in the <i>Amazon CloudWatch Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getMetricStatisticsRequest">Container for the necessary parameters to execute the GetMetricStatistics service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidParameterValueException"/>
        /// <exception cref="InternalServiceException"/>
        /// <exception cref="InvalidParameterCombinationException"/>
        /// <exception cref="MissingRequiredParameterException"/>
        GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest getMetricStatisticsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.GetMetricStatistics"/>
        /// </summary>
        /// 
        /// <param name="getMetricStatisticsRequest">Container for the necessary parameters to execute the GetMetricStatistics operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetMetricStatistics operation.</returns>
        IAsyncResult BeginGetMetricStatistics(GetMetricStatisticsRequest getMetricStatisticsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetMetricStatistics operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.GetMetricStatistics"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricStatistics.</param>
        /// 
        /// <returns>Returns a GetMetricStatisticsResult from AmazonCloudWatch.</returns>
        GetMetricStatisticsResponse EndGetMetricStatistics(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DisableAlarmActions

        /// <summary>
        /// <para> Disables actions for the specified alarms. When an alarm's actions are disabled the alarm's state may change, but none of the alarm's
        /// actions will execute. </para>
        /// </summary>
        /// 
        /// <param name="disableAlarmActionsRequest">Container for the necessary parameters to execute the DisableAlarmActions service method on
        ///          AmazonCloudWatch.</param>
        /// 
        DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest disableAlarmActionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DisableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="disableAlarmActionsRequest">Container for the necessary parameters to execute the DisableAlarmActions operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDisableAlarmActions(DisableAlarmActionsRequest disableAlarmActionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DisableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAlarmActions.</param>
        DisableAlarmActionsResponse EndDisableAlarmActions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeAlarms

        /// <summary>
        /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
        /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmsRequest">Container for the necessary parameters to execute the DescribeAlarms service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest describeAlarmsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarms"/>
        /// </summary>
        /// 
        /// <param name="describeAlarmsRequest">Container for the necessary parameters to execute the DescribeAlarms operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarms
        ///         operation.</returns>
        IAsyncResult BeginDescribeAlarms(DescribeAlarmsRequest describeAlarmsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarms"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarms.</param>
        /// 
        /// <returns>Returns a DescribeAlarmsResult from AmazonCloudWatch.</returns>
        DescribeAlarmsResponse EndDescribeAlarms(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
        /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeAlarmsResponse DescribeAlarms();
        
        #endregion
        
    

        #region DescribeAlarmsForMetric

        /// <summary>
        /// <para> Retrieves all alarms for a single metric. Specify a statistic, period, or unit to filter the set of alarms further. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmsForMetricRequest">Container for the necessary parameters to execute the DescribeAlarmsForMetric service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmsForMetric service method, as returned by AmazonCloudWatch.</returns>
        /// 
        DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest describeAlarmsForMetricRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarmsForMetric"/>
        /// </summary>
        /// 
        /// <param name="describeAlarmsForMetricRequest">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAlarmsForMetric operation.</returns>
        IAsyncResult BeginDescribeAlarmsForMetric(DescribeAlarmsForMetricRequest describeAlarmsForMetricRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarmsForMetric"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmsForMetric.</param>
        /// 
        /// <returns>Returns a DescribeAlarmsForMetricResult from AmazonCloudWatch.</returns>
        DescribeAlarmsForMetricResponse EndDescribeAlarmsForMetric(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeAlarmHistory

        /// <summary>
        /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
        /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
        /// two weeks, whether or not you delete the alarm. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmHistoryRequest">Container for the necessary parameters to execute the DescribeAlarmHistory service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest describeAlarmHistoryRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarmHistory"/>
        /// </summary>
        /// 
        /// <param name="describeAlarmHistoryRequest">Container for the necessary parameters to execute the DescribeAlarmHistory operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAlarmHistory operation.</returns>
        IAsyncResult BeginDescribeAlarmHistory(DescribeAlarmHistoryRequest describeAlarmHistoryRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAlarmHistory operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DescribeAlarmHistory"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmHistory.</param>
        /// 
        /// <returns>Returns a DescribeAlarmHistoryResult from AmazonCloudWatch.</returns>
        DescribeAlarmHistoryResponse EndDescribeAlarmHistory(IAsyncResult asyncResult);

        /// <summary>
        /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
        /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
        /// two weeks, whether or not you delete the alarm. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="InvalidNextTokenException"/>
        DescribeAlarmHistoryResponse DescribeAlarmHistory();
        
        #endregion
        
    

        #region EnableAlarmActions

        /// <summary>
        /// <para> Enables actions for the specified alarms. </para>
        /// </summary>
        /// 
        /// <param name="enableAlarmActionsRequest">Container for the necessary parameters to execute the EnableAlarmActions service method on
        ///          AmazonCloudWatch.</param>
        /// 
        EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest enableAlarmActionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.EnableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="enableAlarmActionsRequest">Container for the necessary parameters to execute the EnableAlarmActions operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginEnableAlarmActions(EnableAlarmActionsRequest enableAlarmActionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.EnableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAlarmActions.</param>
        EnableAlarmActionsResponse EndEnableAlarmActions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteAlarms

        /// <summary>
        /// <para> Deletes all specified alarms. In the event of an error, no alarms are deleted. </para>
        /// </summary>
        /// 
        /// <param name="deleteAlarmsRequest">Container for the necessary parameters to execute the DeleteAlarms service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest deleteAlarmsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DeleteAlarms"/>
        /// </summary>
        /// 
        /// <param name="deleteAlarmsRequest">Container for the necessary parameters to execute the DeleteAlarms operation on AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteAlarms(DeleteAlarmsRequest deleteAlarmsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.DeleteAlarms"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlarms.</param>
        DeleteAlarmsResponse EndDeleteAlarms(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetAlarmState

        /// <summary>
        /// <para> Temporarily sets the state of an alarm. When the updated <c>StateValue</c> differs from the previous value, the action configured for
        /// the appropriate state is invoked. This is not a permanent change. The next periodic alarm check (in about a minute) will set the alarm to
        /// its actual state. </para>
        /// </summary>
        /// 
        /// <param name="setAlarmStateRequest">Container for the necessary parameters to execute the SetAlarmState service method on
        ///          AmazonCloudWatch.</param>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InvalidFormatException"/>
        SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest setAlarmStateRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.SetAlarmState"/>
        /// </summary>
        /// 
        /// <param name="setAlarmStateRequest">Container for the necessary parameters to execute the SetAlarmState operation on
        ///          AmazonCloudWatch.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetAlarmState(SetAlarmStateRequest setAlarmStateRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetAlarmState operation.
        /// <seealso cref="Amazon.CloudWatch.AmazonCloudWatch.SetAlarmState"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetAlarmState.</param>
        SetAlarmStateResponse EndSetAlarmState(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
