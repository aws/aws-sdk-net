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

using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Transform;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.CloudWatch
{
    /// <summary>
    /// Implemenation for accessing AmazonCloudWatch.
    ///  
    /// Amazon CloudWatch <para>Amazon CloudWatch is a web service that
    /// enables you to monitor and manage various metrics, as well as
    /// configure alarm actions based on data from metrics.</para>
    /// <para>Amazon CloudWatch monitoring enables you to collect, analyze,
    /// and view system and application metrics so that you can make
    /// operational and business decisions more quickly and with greater
    /// confidence. You can use Amazon CloudWatch to collect metrics about
    /// your AWS resources, such as the performance of your Amazon EC2
    /// instances. You can also publish your own metrics directly to Amazon
    /// CloudWatch.</para> <para>Amazon CloudWatch allows you to manage the
    /// metrics in several ways. If you are publishing your own metrics, you
    /// can define custom metrics for your own use. If you are registered for
    /// an AWS product that supports Amazon CloudWatch, the service
    /// automatically pushes basic metrics to CloudWatch for you. Once Amazon
    /// CloudWatch contains metrics from either source, you can calculate
    /// statistics based on that data and graphically visualize those
    /// statistics in the Amazon CloudWatch Console.</para> <para>Amazon
    /// CloudWatch alarms help you implement decisions more easily by enabling
    /// you to do things like send notifications or automatically make changes
    /// to the resources you are monitoring, based on rules that you define.
    /// For example, you can create alarms that initiate Auto Scaling and
    /// Simple Notification Service actions on your behalf. </para>
    /// </summary>
    public class AmazonCloudWatchClient : AmazonWebServiceClient, AmazonCloudWatch
    {
    
    
        AbstractAWSSigner signer = new QueryStringSigner();

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials defined in the App.config.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudWatchClient()
            : base(new EnvironmentAWSCredentials(), new AmazonCloudWatchConfig(), true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials defined in the App.config.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonCloudWatchClient(AmazonCloudWatchConfig config)
            : base(new EnvironmentAWSCredentials(), config, true, AuthenticationTypes.User) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3 Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }
        
   

         /// <summary>
         /// <para> Creates or updates an alarm and associates it with the
         /// specified Amazon CloudWatch metric. Optionally, this operation can
         /// associate one or more Amazon Simple Notification Service resources
         /// with the alarm. </para> <para> When this operation creates an alarm,
         /// the alarm state is immediately set to <c>INSUFFICIENT_DATA</c> . The
         /// alarm is evaluated and its <c>StateValue</c> is set appropriately.
         /// Any actions associated with the <c>StateValue</c> is then executed.
         /// </para> <para><b>NOTE:</b> When updating an existing alarm, its
         /// StateValue is left unchanged. </para>
         /// </summary>
         /// 
         /// <param name="putMetricAlarmRequest">Container for the necessary
         ///           parameters to execute the PutMetricAlarm service method on
         ///           AmazonCloudWatch.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
        public PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest putMetricAlarmRequest) 
        {           
            IRequest<PutMetricAlarmRequest> request = new PutMetricAlarmRequestMarshaller().Marshall(putMetricAlarmRequest);
            PutMetricAlarmResponse response = Invoke<PutMetricAlarmRequest, PutMetricAlarmResponse> (request, this.signer, PutMetricAlarmResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Publishes metric data points to Amazon CloudWatch. Amazon
         /// Cloudwatch associates the data points with the specified metric. If
         /// the specified metric does not exist, Amazon CloudWatch creates the
         /// metric. </para> <para><b>NOTE:</b> If you create a metric with the
         /// PutMetricData action, allow up to fifteen minutes for the metric to
         /// appear in calls to the ListMetrics action. </para> <para> The size of
         /// a PutMetricData request is limited to 8 KB for HTTP GET requests and
         /// 40 KB for HTTP POST requests. </para> <para><b>IMPORTANT:</b> Although
         /// the Value parameter accepts numbers of type Double, Amazon CloudWatch
         /// truncates values with very large exponents. Values with base-10
         /// exponents greater than 126 (1 x 10^126) are truncated. Likewise,
         /// values with base-10 exponents less than -130 (1 x 10^-130) are also
         /// truncated. </para>
         /// </summary>
         /// 
         /// <param name="putMetricDataRequest">Container for the necessary
         ///           parameters to execute the PutMetricData service method on
         ///           AmazonCloudWatch.</param>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InternalServiceException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="MissingRequiredParameterException"/>
        public PutMetricDataResponse PutMetricData(PutMetricDataRequest putMetricDataRequest) 
        {           
            IRequest<PutMetricDataRequest> request = new PutMetricDataRequestMarshaller().Marshall(putMetricDataRequest);
            PutMetricDataResponse response = Invoke<PutMetricDataRequest, PutMetricDataResponse> (request, this.signer, PutMetricDataResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Returns a list of valid metrics stored for the AWS account
         /// owner. Returned metrics can be used with <c>GetMetricStatistics</c> to
         /// obtain statistical data for a given metric. </para> <para><b>NOTE:</b>
         /// Up to 500 results are returned for any one call. To retrieve further
         /// results, use returned NextToken values with subsequent ListMetrics
         /// operations. </para> <para><b>NOTE:</b> If you create a metric with the
         /// PutMetricData action, allow up to fifteen minutes for the metric to
         /// appear in calls to the ListMetrics action. </para>
         /// </summary>
         /// 
         /// <param name="listMetricsRequest">Container for the necessary
         ///           parameters to execute the ListMetrics service method on
         ///           AmazonCloudWatch.</param>
         /// 
         /// <returns>The response from the ListMetrics service method, as returned
         ///         by AmazonCloudWatch.</returns>
         /// 
         /// <exception cref="InternalServiceException"/>
         /// <exception cref="InvalidParameterValueException"/>
        public ListMetricsResponse ListMetrics(ListMetricsRequest listMetricsRequest) 
        {           
            IRequest<ListMetricsRequest> request = new ListMetricsRequestMarshaller().Marshall(listMetricsRequest);
            ListMetricsResponse response = Invoke<ListMetricsRequest, ListMetricsResponse> (request, this.signer, ListMetricsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Gets statistics for the specified metric. </para>
         /// <para><b>NOTE:</b> The maximum number of data points returned from a
         /// single GetMetricStatistics request is 1,440. If a request is made that
         /// generates more than 1,440 data points, Amazon CloudWatch returns an
         /// error. In such a case, alter the request by narrowing the specified
         /// time range or increasing the specified period. Alternatively, make
         /// multiple requests across adjacent time ranges. </para> <para> Amazon
         /// CloudWatch aggregates data points based on the length of the
         /// <c>period</c> that you specify. For example, if you request statistics
         /// with a one-minute granularity, Amazon CloudWatch aggregates data
         /// points with time stamps that fall within the same one-minute period.
         /// In such a case, the data points queried can greatly outnumber the data
         /// points returned. </para> <para><b>NOTE:</b> The maximum number of data
         /// points that can be queried is 50,850; whereas the maximum number of
         /// data points returned is 1,440. </para> <para> The following examples
         /// show various statistics allowed by the data point query maximum of
         /// 50,850 when you call <c>GetMetricStatistics</c> on Amazon EC2
         /// instances with detailed (one-minute) monitoring enabled: </para>
         /// <ul>
         /// <li>Statistics for up to 400 instances for a span of one hour</li>
         /// <li>Statistics for up to 35 instances over a span of 24 hours</li>
         /// <li>Statistics for up to 2 instances over a span of 2 weeks</li>
         /// 
         /// </ul>
         /// </summary>
         /// 
         /// <param name="getMetricStatisticsRequest">Container for the necessary
         ///           parameters to execute the GetMetricStatistics service method on
         ///           AmazonCloudWatch.</param>
         /// 
         /// <returns>The response from the GetMetricStatistics service method, as
         ///         returned by AmazonCloudWatch.</returns>
         /// 
         /// <exception cref="InvalidParameterValueException"/>
         /// <exception cref="InternalServiceException"/>
         /// <exception cref="InvalidParameterCombinationException"/>
         /// <exception cref="MissingRequiredParameterException"/>
        public GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest getMetricStatisticsRequest) 
        {           
            IRequest<GetMetricStatisticsRequest> request = new GetMetricStatisticsRequestMarshaller().Marshall(getMetricStatisticsRequest);
            GetMetricStatisticsResponse response = Invoke<GetMetricStatisticsRequest, GetMetricStatisticsResponse> (request, this.signer, GetMetricStatisticsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Disables actions for the specified alarms. When an alarm's
         /// actions are disabled the alarm's state may change, but none of the
         /// alarm's actions will execute. </para>
         /// </summary>
         /// 
         /// <param name="disableAlarmActionsRequest">Container for the necessary
         ///           parameters to execute the DisableAlarmActions service method on
         ///           AmazonCloudWatch.</param>
         /// 
        public DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest disableAlarmActionsRequest) 
        {           
            IRequest<DisableAlarmActionsRequest> request = new DisableAlarmActionsRequestMarshaller().Marshall(disableAlarmActionsRequest);
            DisableAlarmActionsResponse response = Invoke<DisableAlarmActionsRequest, DisableAlarmActionsResponse> (request, this.signer, DisableAlarmActionsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Retrieves alarms with the specified names. If no name is
         /// specified, all alarms for the user are returned. Alarms can be
         /// retrieved by using only a prefix for the alarm name, the alarm state,
         /// or a prefix for any action. </para>
         /// </summary>
         /// 
         /// <param name="describeAlarmsRequest">Container for the necessary
         ///           parameters to execute the DescribeAlarms service method on
         ///           AmazonCloudWatch.</param>
         /// 
         /// <returns>The response from the DescribeAlarms service method, as
         ///         returned by AmazonCloudWatch.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest describeAlarmsRequest) 
        {           
            IRequest<DescribeAlarmsRequest> request = new DescribeAlarmsRequestMarshaller().Marshall(describeAlarmsRequest);
            DescribeAlarmsResponse response = Invoke<DescribeAlarmsRequest, DescribeAlarmsResponse> (request, this.signer, DescribeAlarmsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Retrieves all alarms for a single metric. Specify a statistic,
         /// period, or unit to filter the set of alarms further. </para>
         /// </summary>
         /// 
         /// <param name="describeAlarmsForMetricRequest">Container for the
         ///           necessary parameters to execute the DescribeAlarmsForMetric service
         ///           method on AmazonCloudWatch.</param>
         /// 
         /// <returns>The response from the DescribeAlarmsForMetric service method,
         ///         as returned by AmazonCloudWatch.</returns>
         /// 
        public DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest describeAlarmsForMetricRequest) 
        {           
            IRequest<DescribeAlarmsForMetricRequest> request = new DescribeAlarmsForMetricRequestMarshaller().Marshall(describeAlarmsForMetricRequest);
            DescribeAlarmsForMetricResponse response = Invoke<DescribeAlarmsForMetricRequest, DescribeAlarmsForMetricResponse> (request, this.signer, DescribeAlarmsForMetricResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Retrieves history for the specified alarm. Filter alarms by
         /// date range or item type. If an alarm name is not specified, Amazon
         /// CloudWatch returns histories for all of the owner's alarms. </para>
         /// <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm
         /// for two weeks, whether or not you delete the alarm. </para>
         /// </summary>
         /// 
         /// <param name="describeAlarmHistoryRequest">Container for the necessary
         ///           parameters to execute the DescribeAlarmHistory service method on
         ///           AmazonCloudWatch.</param>
         /// 
         /// <returns>The response from the DescribeAlarmHistory service method, as
         ///         returned by AmazonCloudWatch.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        public DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest describeAlarmHistoryRequest) 
        {           
            IRequest<DescribeAlarmHistoryRequest> request = new DescribeAlarmHistoryRequestMarshaller().Marshall(describeAlarmHistoryRequest);
            DescribeAlarmHistoryResponse response = Invoke<DescribeAlarmHistoryRequest, DescribeAlarmHistoryResponse> (request, this.signer, DescribeAlarmHistoryResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Enables actions for the specified alarms. </para>
         /// </summary>
         /// 
         /// <param name="enableAlarmActionsRequest">Container for the necessary
         ///           parameters to execute the EnableAlarmActions service method on
         ///           AmazonCloudWatch.</param>
         /// 
        public EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest enableAlarmActionsRequest) 
        {           
            IRequest<EnableAlarmActionsRequest> request = new EnableAlarmActionsRequestMarshaller().Marshall(enableAlarmActionsRequest);
            EnableAlarmActionsResponse response = Invoke<EnableAlarmActionsRequest, EnableAlarmActionsResponse> (request, this.signer, EnableAlarmActionsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Deletes all specified alarms. In the event of an error, no
         /// alarms are deleted. </para>
         /// </summary>
         /// 
         /// <param name="deleteAlarmsRequest">Container for the necessary
         ///           parameters to execute the DeleteAlarms service method on
         ///           AmazonCloudWatch.</param>
         /// 
         /// <exception cref="ResourceNotFoundException"/>
        public DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest deleteAlarmsRequest) 
        {           
            IRequest<DeleteAlarmsRequest> request = new DeleteAlarmsRequestMarshaller().Marshall(deleteAlarmsRequest);
            DeleteAlarmsResponse response = Invoke<DeleteAlarmsRequest, DeleteAlarmsResponse> (request, this.signer, DeleteAlarmsResponseUnmarshaller.GetInstance());
            return response;
        }
    

         /// <summary>
         /// <para> Temporarily sets the state of an alarm. When the updated
         /// <c>StateValue</c> differs from the previous value, the action
         /// configured for the appropriate state is invoked. This is not a
         /// permanent change. The next periodic alarm check (in about a minute)
         /// will set the alarm to its actual state. </para>
         /// </summary>
         /// 
         /// <param name="setAlarmStateRequest">Container for the necessary
         ///           parameters to execute the SetAlarmState service method on
         ///           AmazonCloudWatch.</param>
         /// 
         /// <exception cref="ResourceNotFoundException"/>
         /// <exception cref="InvalidFormatException"/>
        public SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest setAlarmStateRequest) 
        {           
            IRequest<SetAlarmStateRequest> request = new SetAlarmStateRequestMarshaller().Marshall(setAlarmStateRequest);
            SetAlarmStateResponse response = Invoke<SetAlarmStateRequest, SetAlarmStateResponse> (request, this.signer, SetAlarmStateResponseUnmarshaller.GetInstance());
            return response;
        }
    
    }
}   
    
