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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CloudWatch.Model;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Interface for accessing CloudWatch
    ///
    /// This is the <i>Amazon CloudWatch API Reference</i>. This guide provides detailed information
    /// about Amazon CloudWatch actions, data types, parameters, and errors. For detailed
    /// information about Amazon CloudWatch features and their associated API calls, go to
    /// the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide">Amazon
    /// CloudWatch Developer Guide</a>. 
    /// 
    ///  
    /// <para>
    /// Amazon CloudWatch is a web service that enables you to publish, monitor, and manage
    /// various metrics, as well as configure alarm actions based on data from metrics. For
    /// more information about this product go to <a href="http://aws.amazon.com/cloudwatch">http://aws.amazon.com/cloudwatch</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  For information about the namespace, metric names, and dimensions that other Amazon
    /// Web Services products use to send metrics to Cloudwatch, go to <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon
    /// CloudWatch Metrics, Namespaces, and Dimensions Reference</a> in the <i>Amazon CloudWatch
    /// Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started using the <i>Amazon CloudWatch API Reference</i>:
    /// </para>
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Amazon CloudWatch actions.</li> <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_Types.html">Data
    /// Types</a>: An alphabetical list of all Amazon CloudWatch data types.</li> <li> <a
    /// href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>: Parameters that all Query actions can use.</li> <li> <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>: Client and server errors that all actions can return.</li> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions
    /// and Endpoints</a>: Itemized regions and endpoints for all AWS products.</li> <li>
    /// <a href="http://monitoring.amazonaws.com/doc/2010-08-01/CloudWatch.wsdl">WSDL Location</a>:
    /// http://monitoring.amazonaws.com/doc/2010-08-01/CloudWatch.wsdl</li> </ul> 
    /// <para>
    /// In addition to using the Amazon CloudWatch API, you can also use the following SDKs
    /// and third-party libraries to access Amazon CloudWatch programmatically.
    /// </para>
    ///  <ul> <li><a href="http://aws.amazon.com/documentation/sdkforjava/">AWS SDK for Java
    /// Documentation</a></li> <li><a href="http://aws.amazon.com/documentation/sdkfornet/">AWS
    /// SDK for .NET Documentation</a></li> <li><a href="http://aws.amazon.com/documentation/sdkforphp/">AWS
    /// SDK for PHP Documentation</a></li> <li><a href="http://aws.amazon.com/documentation/sdkforruby/">AWS
    /// SDK for Ruby Documentation</a></li> </ul> 
    /// <para>
    /// Developers in the AWS developer community also provide their own libraries, which
    /// you can find at the following AWS developer centers:
    /// </para>
    ///  <ul> <li><a href="http://aws.amazon.com/java/">AWS Java Developer Center</a></li>
    /// <li><a href="http://aws.amazon.com/php/">AWS PHP Developer Center</a></li> <li><a
    /// href="http://aws.amazon.com/python/">AWS Python Developer Center</a></li> <li><a href="http://aws.amazon.com/ruby/">AWS
    /// Ruby Developer Center</a></li> <li><a href="http://aws.amazon.com/net/">AWS Windows
    /// and .NET Developer Center</a></li> </ul>
    /// </summary>
    public partial interface IAmazonCloudWatch : IDisposable
    {

        
        #region  DeleteAlarms

        /// <summary>
        /// Deletes all specified alarms. In the event of an error, no alarms are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms service method.</param>
        /// 
        /// <returns>The response from the DeleteAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlarms
        ///         operation.</returns>
        IAsyncResult BeginDeleteAlarms(DeleteAlarmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlarms.</param>
        /// 
        /// <returns>Returns a  DeleteAlarmsResult from CloudWatch.</returns>
        DeleteAlarmsResponse EndDeleteAlarms(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAlarmHistory

        /// <summary>
        /// Retrieves history for the specified alarm. Filter alarms by date range or item type.
        /// If an alarm name is not specified, Amazon CloudWatch returns histories for all of
        /// the owner's alarms.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmHistoryResponse DescribeAlarmHistory();

        /// <summary>
        /// Retrieves history for the specified alarm. Filter alarms by date range or item type.
        /// If an alarm name is not specified, Amazon CloudWatch returns histories for all of
        /// the owner's alarms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarmHistory
        ///         operation.</returns>
        IAsyncResult BeginDescribeAlarmHistory(DescribeAlarmHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarmHistory operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmHistory.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmHistoryResult from CloudWatch.</returns>
        DescribeAlarmHistoryResponse EndDescribeAlarmHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAlarms

        /// <summary>
        /// Retrieves alarms with the specified names. If no name is specified, all alarms for
        /// the user are returned. Alarms can be retrieved by using only a prefix for the alarm
        /// name, the alarm state, or a prefix for any action.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmsResponse DescribeAlarms();

        /// <summary>
        /// Retrieves alarms with the specified names. If no name is specified, all alarms for
        /// the user are returned. Alarms can be retrieved by using only a prefix for the alarm
        /// name, the alarm state, or a prefix for any action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarms
        ///         operation.</returns>
        IAsyncResult BeginDescribeAlarms(DescribeAlarmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarms.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmsResult from CloudWatch.</returns>
        DescribeAlarmsResponse EndDescribeAlarms(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAlarmsForMetric

        /// <summary>
        /// Retrieves all alarms for a single metric. Specify a statistic, period, or unit to
        /// filter the set of alarms further.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmsForMetric service method, as returned by CloudWatch.</returns>
        DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarmsForMetric
        ///         operation.</returns>
        IAsyncResult BeginDescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarmsForMetric operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmsForMetric.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmsForMetricResult from CloudWatch.</returns>
        DescribeAlarmsForMetricResponse EndDescribeAlarmsForMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableAlarmActions

        /// <summary>
        /// Disables actions for the specified alarms. When an alarm's actions are disabled the
        /// alarm's state may change, but none of the alarm's actions will execute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions service method.</param>
        /// 
        /// <returns>The response from the DisableAlarmActions service method, as returned by CloudWatch.</returns>
        DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableAlarmActions
        ///         operation.</returns>
        IAsyncResult BeginDisableAlarmActions(DisableAlarmActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAlarmActions.</param>
        /// 
        /// <returns>Returns a  DisableAlarmActionsResult from CloudWatch.</returns>
        DisableAlarmActionsResponse EndDisableAlarmActions(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableAlarmActions

        /// <summary>
        /// Enables actions for the specified alarms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions service method.</param>
        /// 
        /// <returns>The response from the EnableAlarmActions service method, as returned by CloudWatch.</returns>
        EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableAlarmActions
        ///         operation.</returns>
        IAsyncResult BeginEnableAlarmActions(EnableAlarmActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAlarmActions.</param>
        /// 
        /// <returns>Returns a  EnableAlarmActionsResult from CloudWatch.</returns>
        EnableAlarmActionsResponse EndEnableAlarmActions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMetricStatistics

        /// <summary>
        /// Gets statistics for the specified metric. 
        /// 
        ///  
        /// <para>
        ///  The maximum number of data points returned from a single <code>GetMetricStatistics</code>
        /// request is 1,440, wereas the maximum number of data points that can be queried is
        /// 50,850. If you make a request that generates more than 1,440 data points, Amazon CloudWatch
        /// returns an error. In such a case, you can alter the request by narrowing the specified
        /// time range or increasing the specified period. Alternatively, you can make multiple
        /// requests across adjacent time ranges. 
        /// </para>
        ///  
        /// <para>
        ///  Amazon CloudWatch aggregates data points based on the length of the <code>period</code>
        /// that you specify. For example, if you request statistics with a one-minute granularity,
        /// Amazon CloudWatch aggregates data points with time stamps that fall within the same
        /// one-minute period. In such a case, the data points queried can greatly outnumber the
        /// data points returned. 
        /// </para>
        ///  
        /// <para>
        ///  The following examples show various statistics allowed by the data point query maximum
        /// of 50,850 when you call <code>GetMetricStatistics</code> on Amazon EC2 instances with
        /// detailed (one-minute) monitoring enabled: 
        /// </para>
        ///  <ul> <li>Statistics for up to 400 instances for a span of one hour</li> <li>Statistics
        /// for up to 35 instances over a span of 24 hours</li> <li>Statistics for up to 2 instances
        /// over a span of 2 weeks</li> </ul> 
        /// <para>
        ///  For information about the namespace, metric names, and dimensions that other Amazon
        /// Web Services products use to send metrics to Cloudwatch, go to <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon
        /// CloudWatch Metrics, Namespaces, and Dimensions Reference</a> in the <i>Amazon CloudWatch
        /// Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics service method.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by CloudWatch.</returns>
        /// <exception cref="InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Parameters that must not be used together were used together.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="MissingRequiredParameterException">
        /// An input parameter that is mandatory for processing the request is not supplied.
        /// </exception>
        GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricStatistics
        ///         operation.</returns>
        IAsyncResult BeginGetMetricStatistics(GetMetricStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricStatistics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricStatistics.</param>
        /// 
        /// <returns>Returns a  GetMetricStatisticsResult from CloudWatch.</returns>
        GetMetricStatisticsResponse EndGetMetricStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMetrics

        /// <summary>
        /// Returns a list of valid metrics stored for the AWS account owner. Returned metrics
        /// can be used with <a>GetMetricStatistics</a> to obtain statistical data for a given
        /// metric.
        /// </summary>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        ListMetricsResponse ListMetrics();

        /// <summary>
        /// Returns a list of valid metrics stored for the AWS account owner. Returned metrics
        /// can be used with <a>GetMetricStatistics</a> to obtain statistical data for a given
        /// metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics service method.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        ListMetricsResponse ListMetrics(ListMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetrics
        ///         operation.</returns>
        IAsyncResult BeginListMetrics(ListMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetrics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetrics.</param>
        /// 
        /// <returns>Returns a  ListMetricsResult from CloudWatch.</returns>
        ListMetricsResponse EndListMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMetricAlarm

        /// <summary>
        /// Creates or updates an alarm and associates it with the specified Amazon CloudWatch
        /// metric. Optionally, this operation can associate one or more Amazon Simple Notification
        /// Service resources with the alarm. 
        /// 
        ///  
        /// <para>
        ///  When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
        /// The alarm is evaluated and its <code>StateValue</code> is set appropriately. Any actions
        /// associated with the <code>StateValue</code> is then executed. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm service method.</param>
        /// 
        /// <returns>The response from the PutMetricAlarm service method, as returned by CloudWatch.</returns>
        /// <exception cref="LimitExceededException">
        /// The quota for alarms for this customer has already been reached.
        /// </exception>
        PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetricAlarm
        ///         operation.</returns>
        IAsyncResult BeginPutMetricAlarm(PutMetricAlarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetricAlarm operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricAlarm.</param>
        /// 
        /// <returns>Returns a  PutMetricAlarmResult from CloudWatch.</returns>
        PutMetricAlarmResponse EndPutMetricAlarm(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMetricData

        /// <summary>
        /// Publishes metric data points to Amazon CloudWatch. Amazon Cloudwatch associates the
        /// data points with the specified metric. If the specified metric does not exist, Amazon
        /// CloudWatch creates the metric. It can take up to fifteen minutes for a new metric
        /// to appear in calls to the <a>ListMetrics</a> action.
        /// 
        ///  
        /// <para>
        ///  The size of a PutMetricData request is limited to 8 KB for HTTP GET requests and
        /// 40 KB for HTTP POST requests. 
        /// </para>
        ///  <important> Although the <code>Value</code> parameter accepts numbers of type <code>Double</code>,
        /// Amazon CloudWatch truncates values with very large exponents. Values with base-10
        /// exponents greater than 126 (1 x 10^126) are truncated. Likewise, values with base-10
        /// exponents less than -130 (1 x 10^-130) are also truncated. </important> 
        /// <para>
        /// Data that is timestamped 24 hours or more in the past may take in excess of 48 hours
        /// to become available from submission time using <code>GetMetricStatistics</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by CloudWatch.</returns>
        /// <exception cref="InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="InvalidParameterCombinationException">
        /// Parameters that must not be used together were used together.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="MissingRequiredParameterException">
        /// An input parameter that is mandatory for processing the request is not supplied.
        /// </exception>
        PutMetricDataResponse PutMetricData(PutMetricDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetricData
        ///         operation.</returns>
        IAsyncResult BeginPutMetricData(PutMetricDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetricData operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricData.</param>
        /// 
        /// <returns>Returns a  PutMetricDataResult from CloudWatch.</returns>
        PutMetricDataResponse EndPutMetricData(IAsyncResult asyncResult);

        #endregion
        
        #region  SetAlarmState

        /// <summary>
        /// Temporarily sets the state of an alarm. When the updated <code>StateValue</code>
        /// differs from the previous value, the action configured for the appropriate state is
        /// invoked. This is not a permanent change. The next periodic alarm check (in about a
        /// minute) will set the alarm to its actual state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState service method.</param>
        /// 
        /// <returns>The response from the SetAlarmState service method, as returned by CloudWatch.</returns>
        /// <exception cref="InvalidFormatException">
        /// Data was not syntactically valid JSON.
        /// </exception>
        /// <exception cref="ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetAlarmState
        ///         operation.</returns>
        IAsyncResult BeginSetAlarmState(SetAlarmStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetAlarmState operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetAlarmState.</param>
        /// 
        /// <returns>Returns a  SetAlarmStateResult from CloudWatch.</returns>
        SetAlarmStateResponse EndSetAlarmState(IAsyncResult asyncResult);

        #endregion
        
    }
}