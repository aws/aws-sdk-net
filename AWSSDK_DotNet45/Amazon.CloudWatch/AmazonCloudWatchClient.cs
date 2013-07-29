/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using System.Threading.Tasks;

using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Implementation for accessing AmazonCloudWatch.
    /// 
    /// Amazon CloudWatch <para>This is the <i>Amazon CloudWatch API Reference</i> . This guide provides detailed information about Amazon
    /// CloudWatch actions, data types, parameters, and errors. For detailed information about Amazon CloudWatch features and their associated API
    /// calls, go to the Amazon CloudWatch Developer Guide. </para> <para>Amazon CloudWatch is a web service that enables you to publish, monitor,
    /// and manage various metrics, as well as configure alarm actions based on data from metrics. For more information about this product go to
    /// http://aws.amazon.com/cloudwatch. </para> <para>Use the following links to get started using the <i>Amazon CloudWatch API Reference</i>
    /// :</para>
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
	public partial class AmazonCloudWatchClient : AmazonWebServiceClient, Amazon.CloudWatch.IAmazonCloudWatch
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
        /// <param name="config">The AmazonCloudWatch Configuration Object</param>
        public AmazonCloudWatchClient(AmazonCloudWatchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials and an
        /// AmazonCloudWatchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, AmazonCloudWatchConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

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
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para> Deletes all specified alarms. In the event of an error, no alarms are deleted. </para>
        /// </summary>
        /// 
        /// <param name="deleteAlarmsRequest">Container for the necessary parameters to execute the DeleteAlarms service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.ResourceNotFoundException" />
		public DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request)
        {
            var task = DeleteAlarmsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DeleteAlarms"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DeleteAlarmsResponse> DeleteAlarmsAsync(DeleteAlarmsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAlarmsRequestMarshaller();
            var unmarshaller = DeleteAlarmsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteAlarmsRequest, DeleteAlarmsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
        /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
        /// two weeks, whether or not you delete the alarm. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmHistoryRequest">Container for the necessary parameters to execute the DescribeAlarmHistory service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidNextTokenException" />
		public DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest request)
        {
            var task = DescribeAlarmHistoryAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarmHistory"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeAlarmHistoryResponse> DescribeAlarmHistoryAsync(DescribeAlarmHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmHistoryRequestMarshaller();
            var unmarshaller = DescribeAlarmHistoryResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeAlarmHistoryRequest, DescribeAlarmHistoryResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Retrieves history for the specified alarm. Filter alarms by date range or item type. If an alarm name is not specified, Amazon
        /// CloudWatch returns histories for all of the owner's alarms. </para> <para><b>NOTE:</b> Amazon CloudWatch retains the history of an alarm for
        /// two weeks, whether or not you delete the alarm. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmHistoryRequest">Container for the necessary parameters to execute the DescribeAlarmHistory service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidNextTokenException" />
		public DescribeAlarmHistoryResponse DescribeAlarmHistory()
        {
            return this.DescribeAlarmHistory(new DescribeAlarmHistoryRequest());
        }
 
        /// <summary>
        /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
        /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmsRequest">Container for the necessary parameters to execute the DescribeAlarms service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidNextTokenException" />
		public DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request)
        {
            var task = DescribeAlarmsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarms"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeAlarmsResponse> DescribeAlarmsAsync(DescribeAlarmsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmsRequestMarshaller();
            var unmarshaller = DescribeAlarmsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeAlarmsRequest, DescribeAlarmsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Retrieves alarms with the specified names. If no name is specified, all alarms for the user are returned. Alarms can be retrieved by
        /// using only a prefix for the alarm name, the alarm state, or a prefix for any action. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmsRequest">Container for the necessary parameters to execute the DescribeAlarms service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidNextTokenException" />
		public DescribeAlarmsResponse DescribeAlarms()
        {
            return this.DescribeAlarms(new DescribeAlarmsRequest());
        }
 
        /// <summary>
        /// <para> Retrieves all alarms for a single metric. Specify a statistic, period, or unit to filter the set of alarms further. </para>
        /// </summary>
        /// 
        /// <param name="describeAlarmsForMetricRequest">Container for the necessary parameters to execute the DescribeAlarmsForMetric service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the DescribeAlarmsForMetric service method, as returned by AmazonCloudWatch.</returns>
		public DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request)
        {
            var task = DescribeAlarmsForMetricAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DescribeAlarmsForMetric"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DescribeAlarmsForMetricResponse> DescribeAlarmsForMetricAsync(DescribeAlarmsForMetricRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAlarmsForMetricRequestMarshaller();
            var unmarshaller = DescribeAlarmsForMetricResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DescribeAlarmsForMetricRequest, DescribeAlarmsForMetricResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Disables actions for the specified alarms. When an alarm's actions are disabled the alarm's state may change, but none of the alarm's
        /// actions will execute. </para>
        /// </summary>
        /// 
        /// <param name="disableAlarmActionsRequest">Container for the necessary parameters to execute the DisableAlarmActions service method on
        /// AmazonCloudWatch.</param>
		public DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest request)
        {
            var task = DisableAlarmActionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.DisableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<DisableAlarmActionsResponse> DisableAlarmActionsAsync(DisableAlarmActionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableAlarmActionsRequestMarshaller();
            var unmarshaller = DisableAlarmActionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DisableAlarmActionsRequest, DisableAlarmActionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Enables actions for the specified alarms. </para>
        /// </summary>
        /// 
        /// <param name="enableAlarmActionsRequest">Container for the necessary parameters to execute the EnableAlarmActions service method on
        /// AmazonCloudWatch.</param>
		public EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest request)
        {
            var task = EnableAlarmActionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.EnableAlarmActions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<EnableAlarmActionsResponse> EnableAlarmActionsAsync(EnableAlarmActionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableAlarmActionsRequestMarshaller();
            var unmarshaller = EnableAlarmActionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, EnableAlarmActionsRequest, EnableAlarmActionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
        /// </summary>
        /// 
        /// <param name="getMetricStatisticsRequest">Container for the necessary parameters to execute the GetMetricStatistics service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.MissingRequiredParameterException" />
		public GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request)
        {
            var task = GetMetricStatisticsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.GetMetricStatistics"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<GetMetricStatisticsResponse> GetMetricStatisticsAsync(GetMetricStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetMetricStatisticsRequestMarshaller();
            var unmarshaller = GetMetricStatisticsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetMetricStatisticsRequest, GetMetricStatisticsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with <c>GetMetricStatistics</c> to
        /// obtain statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
        /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. </para>
        /// </summary>
        /// 
        /// <param name="listMetricsRequest">Container for the necessary parameters to execute the ListMetrics service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterValueException" />
		public ListMetricsResponse ListMetrics(ListMetricsRequest request)
        {
            var task = ListMetricsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.ListMetrics"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<ListMetricsResponse> ListMetricsAsync(ListMetricsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMetricsRequestMarshaller();
            var unmarshaller = ListMetricsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListMetricsRequest, ListMetricsResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Returns a list of valid metrics stored for the AWS account owner. Returned metrics can be used with <c>GetMetricStatistics</c> to
        /// obtain statistical data for a given metric. </para> <para><b>NOTE:</b> Up to 500 results are returned for any one call. To retrieve further
        /// results, use returned NextToken values with subsequent ListMetrics operations. </para> <para><b>NOTE:</b> If you create a metric with the
        /// PutMetricData action, allow up to fifteen minutes for the metric to appear in calls to the ListMetrics action. </para>
        /// </summary>
        /// 
        /// <param name="listMetricsRequest">Container for the necessary parameters to execute the ListMetrics service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by AmazonCloudWatch.</returns>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterValueException" />
		public ListMetricsResponse ListMetrics()
        {
            return this.ListMetrics(new ListMetricsRequest());
        }
 
        /// <summary>
        /// <para> Creates or updates an alarm and associates it with the specified Amazon CloudWatch metric. Optionally, this operation can associate
        /// one or more Amazon Simple Notification Service resources with the alarm. </para> <para> When this operation creates an alarm, the alarm
        /// state is immediately set to <c>INSUFFICIENT_DATA</c> . The alarm is evaluated and its <c>StateValue</c> is set appropriately. Any actions
        /// associated with the <c>StateValue</c> is then executed. </para> <para><b>NOTE:</b> When updating an existing alarm, its StateValue is left
        /// unchanged. </para>
        /// </summary>
        /// 
        /// <param name="putMetricAlarmRequest">Container for the necessary parameters to execute the PutMetricAlarm service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.LimitExceededException" />
		public PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest request)
        {
            var task = PutMetricAlarmAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.PutMetricAlarm"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<PutMetricAlarmResponse> PutMetricAlarmAsync(PutMetricAlarmRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMetricAlarmRequestMarshaller();
            var unmarshaller = PutMetricAlarmResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PutMetricAlarmRequest, PutMetricAlarmResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
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
        /// AmazonCloudWatch.</param>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InternalServiceException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.MissingRequiredParameterException" />
		public PutMetricDataResponse PutMetricData(PutMetricDataRequest request)
        {
            var task = PutMetricDataAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.PutMetricData"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMetricDataRequestMarshaller();
            var unmarshaller = PutMetricDataResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PutMetricDataRequest, PutMetricDataResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// <para> Temporarily sets the state of an alarm. When the updated <c>StateValue</c> differs from the previous value, the action configured for
        /// the appropriate state is invoked. This is not a permanent change. The next periodic alarm check (in about a minute) will set the alarm to
        /// its actual state. </para>
        /// </summary>
        /// 
        /// <param name="setAlarmStateRequest">Container for the necessary parameters to execute the SetAlarmState service method on
        /// AmazonCloudWatch.</param>
        /// 
        /// <exception cref="T:Amazon.CloudWatch.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.CloudWatch.Model.InvalidFormatException" />
		public SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest request)
        {
            var task = SetAlarmStateAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// <seealso cref="Amazon.CloudWatch.IAmazonCloudWatch.SetAlarmState"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public async Task<SetAlarmStateResponse> SetAlarmStateAsync(SetAlarmStateRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetAlarmStateRequestMarshaller();
            var unmarshaller = SetAlarmStateResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetAlarmStateRequest, SetAlarmStateResponse>(request, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
