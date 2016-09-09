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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudWatch.Model;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Interface for accessing CloudWatch
    ///
    /// Amazon CloudWatch monitors your Amazon Web Services (AWS) resources and the applications
    /// you run on AWS in real-time. You can use CloudWatch to collect and track metrics,
    /// which are the variables you want to measure for your resources and applications.
    /// 
    ///  
    /// <para>
    /// CloudWatch alarms send notifications or automatically make changes to the resources
    /// you are monitoring based on rules that you define. For example, you can monitor the
    /// CPU usage and disk reads and writes of your Amazon Elastic Compute Cloud (Amazon EC2)
    /// instances and then use this data to determine whether you should launch additional
    /// instances to handle increased load. You can also use this data to stop under-used
    /// instances to save money.
    /// </para>
    ///  
    /// <para>
    /// In addition to monitoring the built-in metrics that come with AWS, you can monitor
    /// your own custom metrics. With CloudWatch, you gain system-wide visibility into resource
    /// utilization, application performance, and operational health.
    /// </para>
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
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteAlarmsResponse> DeleteAlarmsAsync(DeleteAlarmsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAlarmHistory


        /// <summary>
        /// Retrieves history for the specified alarm. Filter alarms by date range or item type.
        /// If an alarm name is not specified, Amazon CloudWatch returns histories for all of
        /// the owner's alarms.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon CloudWatch retains the history of an alarm for two weeks, whether or not you
        /// delete the alarm.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmHistoryResponse DescribeAlarmHistory();


        /// <summary>
        /// Retrieves history for the specified alarm. Filter alarms by date range or item type.
        /// If an alarm name is not specified, Amazon CloudWatch returns histories for all of
        /// the owner's alarms.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon CloudWatch retains the history of an alarm for two weeks, whether or not you
        /// delete the alarm.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest request);


        /// <summary>
        /// Retrieves history for the specified alarm. Filter alarms by date range or item type.
        /// If an alarm name is not specified, Amazon CloudWatch returns histories for all of
        /// the owner's alarms.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon CloudWatch retains the history of an alarm for two weeks, whether or not you
        /// delete the alarm.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        Task<DescribeAlarmHistoryResponse> DescribeAlarmHistoryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAlarmHistoryResponse> DescribeAlarmHistoryAsync(DescribeAlarmHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAlarms


        /// <summary>
        /// Retrieves alarms with the specified names. If no name is specified, all alarms for
        /// the user are returned. Alarms can be retrieved by using only a prefix for the alarm
        /// name, the alarm state, or a prefix for any action.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
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
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request);


        /// <summary>
        /// Retrieves alarms with the specified names. If no name is specified, all alarms for
        /// the user are returned. Alarms can be retrieved by using only a prefix for the alarm
        /// name, the alarm state, or a prefix for any action.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        Task<DescribeAlarmsResponse> DescribeAlarmsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAlarmsResponse> DescribeAlarmsAsync(DescribeAlarmsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAlarmsForMetricResponse> DescribeAlarmsForMetricAsync(DescribeAlarmsForMetricRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableAlarmActionsResponse> DisableAlarmActionsAsync(DisableAlarmActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableAlarmActionsResponse> EnableAlarmActionsAsync(EnableAlarmActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMetricStatistics


        /// <summary>
        /// Gets statistics for the specified metric.
        /// 
        ///  
        /// <para>
        ///  The maximum number of data points that can be queried is 50,850, whereas the maximum
        /// number of data points returned from a single <code>GetMetricStatistics</code> request
        /// is 1,440. If you make a request that generates more than 1,440 data points, Amazon
        /// CloudWatch returns an error. In such a case, you can alter the request by narrowing
        /// the specified time range or increasing the specified period. A period can be as short
        /// as one minute (60 seconds) or as long as one day (86,400 seconds). Alternatively,
        /// you can make multiple requests across adjacent time ranges. <code>GetMetricStatistics</code>
        /// does not return the data in chronological order. 
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
        ///  <ul> <li> 
        /// <para>
        /// Statistics for up to 400 instances for a span of one hour
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Statistics for up to 35 instances over a span of 24 hours
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Statistics for up to 2 instances over a span of 2 weeks
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For information about the namespace, metric names, and dimensions that other Amazon
        /// Web Services products use to send metrics to CloudWatch, go to <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon
        /// CloudWatch Metrics, Namespaces, and Dimensions Reference</a> in the <i>Amazon CloudWatch
        /// Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics service method.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters that must not be used together were used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is mandatory for processing the request is not supplied.
        /// </exception>
        GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetMetricStatisticsResponse> GetMetricStatisticsAsync(GetMetricStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMetrics


        /// <summary>
        /// Returns a list of valid metrics stored for the AWS account owner. Returned metrics
        /// can be used with <a>GetMetricStatistics</a> to obtain statistical data for a given
        /// metric. 
        /// 
        ///  <note> 
        /// <para>
        ///  Up to 500 results are returned for any one call. To retrieve further results, use
        /// returned <code>NextToken</code> values with subsequent <code>ListMetrics</code> operations.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  If you create a metric with <a>PutMetricData</a>, allow up to fifteen minutes for
        /// the metric to appear in calls to <code>ListMetrics</code>. Statistics about the metric,
        /// however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        ListMetricsResponse ListMetrics();


        /// <summary>
        /// Returns a list of valid metrics stored for the AWS account owner. Returned metrics
        /// can be used with <a>GetMetricStatistics</a> to obtain statistical data for a given
        /// metric. 
        /// 
        ///  <note> 
        /// <para>
        ///  Up to 500 results are returned for any one call. To retrieve further results, use
        /// returned <code>NextToken</code> values with subsequent <code>ListMetrics</code> operations.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  If you create a metric with <a>PutMetricData</a>, allow up to fifteen minutes for
        /// the metric to appear in calls to <code>ListMetrics</code>. Statistics about the metric,
        /// however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics service method.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        ListMetricsResponse ListMetrics(ListMetricsRequest request);


        /// <summary>
        /// Returns a list of valid metrics stored for the AWS account owner. Returned metrics
        /// can be used with <a>GetMetricStatistics</a> to obtain statistical data for a given
        /// metric. 
        /// 
        ///  <note> 
        /// <para>
        ///  Up to 500 results are returned for any one call. To retrieve further results, use
        /// returned <code>NextToken</code> values with subsequent <code>ListMetrics</code> operations.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  If you create a metric with <a>PutMetricData</a>, allow up to fifteen minutes for
        /// the metric to appear in calls to <code>ListMetrics</code>. Statistics about the metric,
        /// however, are available sooner using <a>GetMetricStatistics</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        Task<ListMetricsResponse> ListMetricsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutMetricAlarm


        /// <summary>
        /// Creates or updates an alarm and associates it with the specified Amazon CloudWatch
        /// metric. Optionally, this operation can associate one or more Amazon SNS resources
        /// with the alarm.
        /// 
        ///  
        /// <para>
        ///  When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
        /// The alarm is evaluated and its <code>StateValue</code> is set appropriately. Any actions
        /// associated with the <code>StateValue</code> are then executed. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When updating an existing alarm, its <code>StateValue</code> is left unchanged, but
        /// it completely overwrites the alarm's previous configuration.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If you are using an AWS Identity and Access Management (IAM) account to create or
        /// modify an alarm, you must have the following Amazon EC2 permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ec2:DescribeInstanceStatus</code> and <code>ec2:DescribeInstances</code> for
        /// all alarms on Amazon EC2 instance status metrics.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:StopInstances</code> for alarms with stop actions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:TerminateInstances</code> for alarms with terminate actions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ec2:DescribeInstanceRecoveryAttribute</code>, and <code>ec2:RecoverInstances</code>
        /// for alarms with recover actions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you have read/write permissions for Amazon CloudWatch but not for Amazon EC2, you
        /// can still create an alarm but the stop or terminate actions won't be performed on
        /// the Amazon EC2 instance. However, if you are later granted permission to use the associated
        /// Amazon EC2 APIs, the alarm actions you created earlier will be performed. For more
        /// information about IAM permissions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html">Permissions
        /// and Policies</a> in <i>Using IAM</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are using an IAM role (e.g., an Amazon EC2 instance profile), you cannot stop
        /// or terminate the instance using alarm actions. However, you can still see the alarm
        /// state and perform any other actions such as Amazon SNS notifications or Auto Scaling
        /// policies.
        /// </para>
        ///  
        /// <para>
        /// If you are using temporary security credentials granted using the AWS Security Token
        /// Service (AWS STS), you cannot stop or terminate an Amazon EC2 instance using alarm
        /// actions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm service method.</param>
        /// 
        /// <returns>The response from the PutMetricAlarm service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.LimitExceededException">
        /// The quota for alarms for this customer has already been reached.
        /// </exception>
        PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutMetricAlarmResponse> PutMetricAlarmAsync(PutMetricAlarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutMetricData


        /// <summary>
        /// Publishes metric data points to Amazon CloudWatch. Amazon CloudWatch associates the
        /// data points with the specified metric. If the specified metric does not exist, Amazon
        /// CloudWatch creates the metric. When Amazon CloudWatch creates a metric, it can take
        /// up to fifteen minutes for the metric to appear in calls to <a>ListMetrics</a>. 
        /// 
        ///  
        /// <para>
        ///  Each <code>PutMetricData</code> request is limited to 8 KB in size for HTTP GET requests
        /// and is limited to 40 KB in size for HTTP POST requests. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Although the <code>Value</code> parameter accepts numbers of type <code>Double</code>,
        /// Amazon CloudWatch rejects values that are either too small or too large. Values must
        /// be in the range of 8.515920e-109 to 1.174271e+108 (Base 10) or 2e-360 to 2e360 (Base
        /// 2). In addition, special values (e.g., NaN, +Infinity, -Infinity) are not supported.
        /// </para>
        ///  </important> 
        /// <para>
        /// Data that is timestamped 24 hours or more in the past may take in excess of 48 hours
        /// to become available from submission time using <code>GetMetricStatistics</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Indicates that the request processing has failed due to some unknown error, exception,
        /// or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters that must not be used together were used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// Bad or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is mandatory for processing the request is not supplied.
        /// </exception>
        PutMetricDataResponse PutMetricData(PutMetricDataRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetAlarmState


        /// <summary>
        /// Temporarily sets the state of an alarm for testing purposes. When the updated <code>StateValue</code>
        /// differs from the previous value, the action configured for the appropriate state is
        /// invoked. For example, if your alarm is configured to send an Amazon SNS message when
        /// an alarm is triggered, temporarily changing the alarm's state to <b>ALARM</b> sends
        /// an Amazon SNS message. The alarm returns to its actual state (often within seconds).
        /// Because the alarm state change happens very quickly, it is typically only visible
        /// in the alarm's <b>History</b> tab in the Amazon CloudWatch console or through <code>DescribeAlarmHistory</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState service method.</param>
        /// 
        /// <returns>The response from the SetAlarmState service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidFormatException">
        /// Data was not syntactically valid JSON.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetAlarmStateResponse> SetAlarmStateAsync(SetAlarmStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}