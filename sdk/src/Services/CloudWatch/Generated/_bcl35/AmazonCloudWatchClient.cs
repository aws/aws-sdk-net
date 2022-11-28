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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudWatch.Model;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.CloudWatch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Implementation for accessing CloudWatch
    ///
    /// Amazon CloudWatch monitors your Amazon Web Services (Amazon Web Services) resources
    /// and the applications you run on Amazon Web Services in real time. You can use CloudWatch
    /// to collect and track metrics, which are the variables you want to measure for your
    /// resources and applications.
    /// 
    ///  
    /// <para>
    /// CloudWatch alarms send notifications or automatically change the resources you are
    /// monitoring based on rules that you define. For example, you can monitor the CPU usage
    /// and disk reads and writes of your Amazon EC2 instances. Then, use this data to determine
    /// whether you should launch additional instances to handle increased load. You can also
    /// use this data to stop under-used instances to save money.
    /// </para>
    ///  
    /// <para>
    /// In addition to monitoring the built-in metrics that come with Amazon Web Services,
    /// you can monitor your own custom metrics. With CloudWatch, you gain system-wide visibility
    /// into resource utilization, application performance, and operational health.
    /// </para>
    /// </summary>
    public partial class AmazonCloudWatchClient : AmazonServiceClient, IAmazonCloudWatch
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudWatchMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ICloudWatchPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudWatchPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudWatchPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudWatchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
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
        public AmazonCloudWatchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(AmazonCloudWatchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : this(credentials, new AmazonCloudWatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Credentials and an
        /// AmazonCloudWatchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(AWSCredentials credentials, AmazonCloudWatchConfig clientConfig)
            : base(credentials, clientConfig)
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
        /// AmazonCloudWatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchClient Configuration Object</param>
        public AmazonCloudWatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudWatchEndpointResolver());
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


        #region  DeleteAlarms

        /// <summary>
        /// Deletes the specified alarms. You can delete up to 100 alarms in one operation. However,
        /// this total can include no more than one composite alarm. For example, you could delete
        /// 99 metric alarms and one composite alarms with one operation, but you can't delete
        /// two composite alarms with one operation.
        /// 
        ///  
        /// <para>
        ///  In the event of an error, no alarms are deleted.
        /// </para>
        ///  <note> 
        /// <para>
        /// It is possible to create a loop or cycle of composite alarms, where composite alarm
        /// A depends on composite alarm B, and composite alarm B also depends on composite alarm
        /// A. In this scenario, you can't delete any composite alarm that is part of the cycle
        /// because there is always still a composite alarm that depends on that alarm that you
        /// want to delete.
        /// </para>
        ///  
        /// <para>
        /// To get out of such a situation, you must break the cycle by changing the rule of one
        /// of the composite alarms in the cycle to remove a dependency that creates the cycle.
        /// The simplest change to make to break a cycle is to change the <code>AlarmRule</code>
        /// of one of the alarms to <code>false</code>. 
        /// </para>
        ///  
        /// <para>
        /// Additionally, the evaluation of composite alarms stops if CloudWatch detects a cycle
        /// in the evaluation path. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms service method.</param>
        /// 
        /// <returns>The response from the DeleteAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAlarms">REST API Reference for DeleteAlarms Operation</seealso>
        public virtual DeleteAlarmsResponse DeleteAlarms(DeleteAlarmsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlarmsResponseUnmarshaller.Instance;

            return Invoke<DeleteAlarmsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlarms operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlarms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAlarms">REST API Reference for DeleteAlarms Operation</seealso>
        public virtual IAsyncResult BeginDeleteAlarms(DeleteAlarmsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlarmsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlarms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlarms.</param>
        /// 
        /// <returns>Returns a  DeleteAlarmsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAlarms">REST API Reference for DeleteAlarms Operation</seealso>
        public virtual DeleteAlarmsResponse EndDeleteAlarms(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAlarmsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAnomalyDetector

        /// <summary>
        /// Deletes the specified anomaly detection model from your account. For more information
        /// about how to delete an anomaly detection model, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Create_Anomaly_Detection_Alarm.html#Delete_Anomaly_Detection_Model">Deleting
        /// an anomaly detection model</a> in the <i>CloudWatch User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteAnomalyDetector service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        public virtual DeleteAnomalyDetectorResponse DeleteAnomalyDetector(DeleteAnomalyDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyDetector operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginDeleteAnomalyDetector(DeleteAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  DeleteAnomalyDetectorResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        public virtual DeleteAnomalyDetectorResponse EndDeleteAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDashboards

        /// <summary>
        /// Deletes all dashboards that you specify. You can specify up to 100 dashboards to delete.
        /// If there is an error during this call, no dashboards are deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboards service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboards service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.DashboardNotFoundErrorException">
        /// The specified dashboard does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteDashboards">REST API Reference for DeleteDashboards Operation</seealso>
        public virtual DeleteDashboardsResponse DeleteDashboards(DeleteDashboardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardsResponseUnmarshaller.Instance;

            return Invoke<DeleteDashboardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboards operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDashboards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteDashboards">REST API Reference for DeleteDashboards Operation</seealso>
        public virtual IAsyncResult BeginDeleteDashboards(DeleteDashboardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDashboardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDashboards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDashboards.</param>
        /// 
        /// <returns>Returns a  DeleteDashboardsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteDashboards">REST API Reference for DeleteDashboards Operation</seealso>
        public virtual DeleteDashboardsResponse EndDeleteDashboards(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDashboardsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInsightRules

        /// <summary>
        /// Permanently deletes the specified Contributor Insights rules.
        /// 
        ///  
        /// <para>
        /// If you create a rule, delete it, and then re-create it with the same name, historical
        /// data from the first time the rule was created might not be available.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsightRules service method.</param>
        /// 
        /// <returns>The response from the DeleteInsightRules service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteInsightRules">REST API Reference for DeleteInsightRules Operation</seealso>
        public virtual DeleteInsightRulesResponse DeleteInsightRules(DeleteInsightRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightRulesResponseUnmarshaller.Instance;

            return Invoke<DeleteInsightRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInsightRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsightRules operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInsightRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteInsightRules">REST API Reference for DeleteInsightRules Operation</seealso>
        public virtual IAsyncResult BeginDeleteInsightRules(DeleteInsightRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInsightRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInsightRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInsightRules.</param>
        /// 
        /// <returns>Returns a  DeleteInsightRulesResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteInsightRules">REST API Reference for DeleteInsightRules Operation</seealso>
        public virtual DeleteInsightRulesResponse EndDeleteInsightRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInsightRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteMetricStream

        /// <summary>
        /// Permanently deletes the metric stream that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricStream service method.</param>
        /// 
        /// <returns>The response from the DeleteMetricStream service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteMetricStream">REST API Reference for DeleteMetricStream Operation</seealso>
        public virtual DeleteMetricStreamResponse DeleteMetricStream(DeleteMetricStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMetricStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteMetricStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMetricStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricStream operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMetricStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteMetricStream">REST API Reference for DeleteMetricStream Operation</seealso>
        public virtual IAsyncResult BeginDeleteMetricStream(DeleteMetricStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMetricStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMetricStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMetricStream.</param>
        /// 
        /// <returns>Returns a  DeleteMetricStreamResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DeleteMetricStream">REST API Reference for DeleteMetricStream Operation</seealso>
        public virtual DeleteMetricStreamResponse EndDeleteMetricStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMetricStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlarmHistory

        /// <summary>
        /// Retrieves the history for the specified alarm. You can filter the results by date
        /// range or item type. If an alarm name is not specified, the histories for either all
        /// metric alarms or all composite alarms are returned.
        /// 
        ///  
        /// <para>
        /// CloudWatch retains the history of an alarm even if you delete the alarm.
        /// </para>
        ///  
        /// <para>
        /// To use this operation and return information about a composite alarm, you must be
        /// signed on with the <code>cloudwatch:DescribeAlarmHistory</code> permission that is
        /// scoped to <code>*</code>. You can't return information about composite alarms if your
        /// <code>cloudwatch:DescribeAlarmHistory</code> permission has a narrower scope.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual DescribeAlarmHistoryResponse DescribeAlarmHistory()
        {
            return DescribeAlarmHistory(new DescribeAlarmHistoryRequest());
        }

        /// <summary>
        /// Retrieves the history for the specified alarm. You can filter the results by date
        /// range or item type. If an alarm name is not specified, the histories for either all
        /// metric alarms or all composite alarms are returned.
        /// 
        ///  
        /// <para>
        /// CloudWatch retains the history of an alarm even if you delete the alarm.
        /// </para>
        ///  
        /// <para>
        /// To use this operation and return information about a composite alarm, you must be
        /// signed on with the <code>cloudwatch:DescribeAlarmHistory</code> permission that is
        /// scoped to <code>*</code>. You can't return information about composite alarms if your
        /// <code>cloudwatch:DescribeAlarmHistory</code> permission has a narrower scope.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmHistory service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual DescribeAlarmHistoryResponse DescribeAlarmHistory(DescribeAlarmHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlarmHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmHistory operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarmHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlarmHistory(DescribeAlarmHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlarmHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarmHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmHistory.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmHistoryResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmHistory">REST API Reference for DescribeAlarmHistory Operation</seealso>
        public virtual DescribeAlarmHistoryResponse EndDescribeAlarmHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAlarmHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlarms

        /// <summary>
        /// Retrieves the specified alarms. You can filter the results by specifying a prefix
        /// for the alarm name, the alarm state, or a prefix for any action.
        /// 
        ///  
        /// <para>
        /// To use this operation and return information about composite alarms, you must be signed
        /// on with the <code>cloudwatch:DescribeAlarms</code> permission that is scoped to <code>*</code>.
        /// You can't return information about composite alarms if your <code>cloudwatch:DescribeAlarms</code>
        /// permission has a narrower scope.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual DescribeAlarmsResponse DescribeAlarms()
        {
            return DescribeAlarms(new DescribeAlarmsRequest());
        }

        /// <summary>
        /// Retrieves the specified alarms. You can filter the results by specifying a prefix
        /// for the alarm name, the alarm state, or a prefix for any action.
        /// 
        ///  
        /// <para>
        /// To use this operation and return information about composite alarms, you must be signed
        /// on with the <code>cloudwatch:DescribeAlarms</code> permission that is scoped to <code>*</code>.
        /// You can't return information about composite alarms if your <code>cloudwatch:DescribeAlarms</code>
        /// permission has a narrower scope.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarms service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual DescribeAlarmsResponse DescribeAlarms(DescribeAlarmsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmsResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarms operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlarms(DescribeAlarmsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlarmsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarms.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarms">REST API Reference for DescribeAlarms Operation</seealso>
        public virtual DescribeAlarmsResponse EndDescribeAlarms(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAlarmsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAlarmsForMetric

        /// <summary>
        /// Retrieves the alarms for the specified metric. To filter the results, specify a statistic,
        /// period, or unit.
        /// 
        ///  
        /// <para>
        /// This operation retrieves only standard alarms that are based on the specified metric.
        /// It does not return alarms based on math expressions that use the specified metric,
        /// or composite alarms that use the specified metric.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric service method.</param>
        /// 
        /// <returns>The response from the DescribeAlarmsForMetric service method, as returned by CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmsForMetric">REST API Reference for DescribeAlarmsForMetric Operation</seealso>
        public virtual DescribeAlarmsForMetricResponse DescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlarmsForMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmsForMetricResponseUnmarshaller.Instance;

            return Invoke<DescribeAlarmsForMetricResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlarmsForMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlarmsForMetric operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlarmsForMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmsForMetric">REST API Reference for DescribeAlarmsForMetric Operation</seealso>
        public virtual IAsyncResult BeginDescribeAlarmsForMetric(DescribeAlarmsForMetricRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAlarmsForMetricRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAlarmsForMetricResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlarmsForMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlarmsForMetric.</param>
        /// 
        /// <returns>Returns a  DescribeAlarmsForMetricResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAlarmsForMetric">REST API Reference for DescribeAlarmsForMetric Operation</seealso>
        public virtual DescribeAlarmsForMetricResponse EndDescribeAlarmsForMetric(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAlarmsForMetricResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAnomalyDetectors

        /// <summary>
        /// Lists the anomaly detection models that you have created in your account. For single
        /// metric anomaly detectors, you can list all of the models in your account or filter
        /// the results to only the models that are related to a certain namespace, metric name,
        /// or metric dimension. For metric math anomaly detectors, you can list them by adding
        /// <code>METRIC_MATH</code> to the <code>AnomalyDetectorTypes</code> array. This will
        /// return all metric math anomaly detectors in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetectors service method.</param>
        /// 
        /// <returns>The response from the DescribeAnomalyDetectors service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAnomalyDetectors">REST API Reference for DescribeAnomalyDetectors Operation</seealso>
        public virtual DescribeAnomalyDetectorsResponse DescribeAnomalyDetectors(DescribeAnomalyDetectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectorsResponseUnmarshaller.Instance;

            return Invoke<DescribeAnomalyDetectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnomalyDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetectors operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnomalyDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAnomalyDetectors">REST API Reference for DescribeAnomalyDetectors Operation</seealso>
        public virtual IAsyncResult BeginDescribeAnomalyDetectors(DescribeAnomalyDetectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAnomalyDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAnomalyDetectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnomalyDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnomalyDetectors.</param>
        /// 
        /// <returns>Returns a  DescribeAnomalyDetectorsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeAnomalyDetectors">REST API Reference for DescribeAnomalyDetectors Operation</seealso>
        public virtual DescribeAnomalyDetectorsResponse EndDescribeAnomalyDetectors(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAnomalyDetectorsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInsightRules

        /// <summary>
        /// Returns a list of all the Contributor Insights rules in your account.
        /// 
        ///  
        /// <para>
        /// For more information about Contributor Insights, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ContributorInsights.html">Using
        /// Contributor Insights to Analyze High-Cardinality Data</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsightRules service method.</param>
        /// 
        /// <returns>The response from the DescribeInsightRules service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeInsightRules">REST API Reference for DescribeInsightRules Operation</seealso>
        public virtual DescribeInsightRulesResponse DescribeInsightRules(DescribeInsightRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeInsightRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInsightRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInsightRules operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInsightRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeInsightRules">REST API Reference for DescribeInsightRules Operation</seealso>
        public virtual IAsyncResult BeginDescribeInsightRules(DescribeInsightRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInsightRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInsightRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInsightRules.</param>
        /// 
        /// <returns>Returns a  DescribeInsightRulesResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DescribeInsightRules">REST API Reference for DescribeInsightRules Operation</seealso>
        public virtual DescribeInsightRulesResponse EndDescribeInsightRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInsightRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableAlarmActions

        /// <summary>
        /// Disables the actions for the specified alarms. When an alarm's actions are disabled,
        /// the alarm actions do not execute when the alarm state changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions service method.</param>
        /// 
        /// <returns>The response from the DisableAlarmActions service method, as returned by CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableAlarmActions">REST API Reference for DisableAlarmActions Operation</seealso>
        public virtual DisableAlarmActionsResponse DisableAlarmActions(DisableAlarmActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAlarmActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAlarmActionsResponseUnmarshaller.Instance;

            return Invoke<DisableAlarmActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAlarmActions operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableAlarmActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableAlarmActions">REST API Reference for DisableAlarmActions Operation</seealso>
        public virtual IAsyncResult BeginDisableAlarmActions(DisableAlarmActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableAlarmActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableAlarmActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableAlarmActions.</param>
        /// 
        /// <returns>Returns a  DisableAlarmActionsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableAlarmActions">REST API Reference for DisableAlarmActions Operation</seealso>
        public virtual DisableAlarmActionsResponse EndDisableAlarmActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableAlarmActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableInsightRules

        /// <summary>
        /// Disables the specified Contributor Insights rules. When rules are disabled, they do
        /// not analyze log groups and do not incur costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableInsightRules service method.</param>
        /// 
        /// <returns>The response from the DisableInsightRules service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableInsightRules">REST API Reference for DisableInsightRules Operation</seealso>
        public virtual DisableInsightRulesResponse DisableInsightRules(DisableInsightRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableInsightRulesResponseUnmarshaller.Instance;

            return Invoke<DisableInsightRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableInsightRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableInsightRules operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableInsightRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableInsightRules">REST API Reference for DisableInsightRules Operation</seealso>
        public virtual IAsyncResult BeginDisableInsightRules(DisableInsightRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableInsightRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableInsightRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableInsightRules.</param>
        /// 
        /// <returns>Returns a  DisableInsightRulesResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/DisableInsightRules">REST API Reference for DisableInsightRules Operation</seealso>
        public virtual DisableInsightRulesResponse EndDisableInsightRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableInsightRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableAlarmActions

        /// <summary>
        /// Enables the actions for the specified alarms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions service method.</param>
        /// 
        /// <returns>The response from the EnableAlarmActions service method, as returned by CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableAlarmActions">REST API Reference for EnableAlarmActions Operation</seealso>
        public virtual EnableAlarmActionsResponse EnableAlarmActions(EnableAlarmActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAlarmActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAlarmActionsResponseUnmarshaller.Instance;

            return Invoke<EnableAlarmActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAlarmActions operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableAlarmActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableAlarmActions">REST API Reference for EnableAlarmActions Operation</seealso>
        public virtual IAsyncResult BeginEnableAlarmActions(EnableAlarmActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableAlarmActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableAlarmActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableAlarmActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableAlarmActions.</param>
        /// 
        /// <returns>Returns a  EnableAlarmActionsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableAlarmActions">REST API Reference for EnableAlarmActions Operation</seealso>
        public virtual EnableAlarmActionsResponse EndEnableAlarmActions(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableAlarmActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableInsightRules

        /// <summary>
        /// Enables the specified Contributor Insights rules. When rules are enabled, they immediately
        /// begin analyzing log data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableInsightRules service method.</param>
        /// 
        /// <returns>The response from the EnableInsightRules service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.LimitExceededException">
        /// The operation exceeded one or more limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableInsightRules">REST API Reference for EnableInsightRules Operation</seealso>
        public virtual EnableInsightRulesResponse EnableInsightRules(EnableInsightRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableInsightRulesResponseUnmarshaller.Instance;

            return Invoke<EnableInsightRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableInsightRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableInsightRules operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableInsightRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableInsightRules">REST API Reference for EnableInsightRules Operation</seealso>
        public virtual IAsyncResult BeginEnableInsightRules(EnableInsightRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableInsightRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableInsightRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableInsightRules.</param>
        /// 
        /// <returns>Returns a  EnableInsightRulesResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/EnableInsightRules">REST API Reference for EnableInsightRules Operation</seealso>
        public virtual EnableInsightRulesResponse EndEnableInsightRules(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableInsightRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDashboard

        /// <summary>
        /// Displays the details of the dashboard that you specify.
        /// 
        ///  
        /// <para>
        /// To copy an existing dashboard, use <code>GetDashboard</code>, and then use the data
        /// returned within <code>DashboardBody</code> as the template for the new dashboard when
        /// you call <code>PutDashboard</code> to create the copy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// 
        /// <returns>The response from the GetDashboard service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.DashboardNotFoundErrorException">
        /// The specified dashboard does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual GetDashboardResponse GetDashboard(GetDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return Invoke<GetDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual IAsyncResult BeginGetDashboard(GetDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDashboard.</param>
        /// 
        /// <returns>Returns a  GetDashboardResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        public virtual GetDashboardResponse EndGetDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInsightRuleReport

        /// <summary>
        /// This operation returns the time series data collected by a Contributor Insights rule.
        /// The data includes the identity and number of contributors to the log group.
        /// 
        ///  
        /// <para>
        /// You can also optionally return one or more statistics about each data point in the
        /// time series. These statistics can include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>UniqueContributors</code> -- the number of unique contributors for each data
        /// point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaxContributorValue</code> -- the value of the top contributor for each data
        /// point. The identity of the contributor might change for each data point in the graph.
        /// </para>
        ///  
        /// <para>
        /// If this rule aggregates by COUNT, the top contributor for each data point is the contributor
        /// with the most occurrences in that period. If the rule aggregates by SUM, the top contributor
        /// is the contributor with the highest sum in the log field specified by the rule's <code>Value</code>,
        /// during that period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SampleCount</code> -- the number of data points matched by the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Sum</code> -- the sum of the values from all contributors during the time period
        /// represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Minimum</code> -- the minimum value from a single observation during the time
        /// period represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Maximum</code> -- the maximum value from a single observation during the time
        /// period represented by that data point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Average</code> -- the average value from all contributors during the time period
        /// represented by that data point.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightRuleReport service method.</param>
        /// 
        /// <returns>The response from the GetInsightRuleReport service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetInsightRuleReport">REST API Reference for GetInsightRuleReport Operation</seealso>
        public virtual GetInsightRuleReportResponse GetInsightRuleReport(GetInsightRuleReportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightRuleReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightRuleReportResponseUnmarshaller.Instance;

            return Invoke<GetInsightRuleReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsightRuleReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightRuleReport operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsightRuleReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetInsightRuleReport">REST API Reference for GetInsightRuleReport Operation</seealso>
        public virtual IAsyncResult BeginGetInsightRuleReport(GetInsightRuleReportRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInsightRuleReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInsightRuleReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsightRuleReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsightRuleReport.</param>
        /// 
        /// <returns>Returns a  GetInsightRuleReportResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetInsightRuleReport">REST API Reference for GetInsightRuleReport Operation</seealso>
        public virtual GetInsightRuleReportResponse EndGetInsightRuleReport(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInsightRuleReportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMetricData

        /// <summary>
        /// You can use the <code>GetMetricData</code> API to retrieve CloudWatch metric values.
        /// The operation can also include a CloudWatch Metrics Insights query, and one or more
        /// metric math functions.
        /// 
        ///  
        /// <para>
        /// A <code>GetMetricData</code> operation that does not include a query can retrieve
        /// as many as 500 different metrics in a single request, with a total of as many as 100,800
        /// data points. You can also optionally perform metric math expressions on the values
        /// of the returned statistics, to create new time series that represent new insights
        /// into your data. For example, using Lambda metrics, you could divide the Errors metric
        /// by the Invocations metric to get an error rate time series. For more information about
        /// metric math expressions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax">Metric
        /// Math Syntax and Functions</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you include a Metrics Insights query, each <code>GetMetricData</code> operation
        /// can include only one query. But the same <code>GetMetricData</code> operation can
        /// also retrieve other metrics. Metrics Insights queries can query only the most recent
        /// three hours of metric data. For more information about Metrics Insights, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/query_with_cloudwatch-metrics-insights.html">Query
        /// your metrics with CloudWatch Metrics Insights</a>.
        /// </para>
        ///  
        /// <para>
        /// Calls to the <code>GetMetricData</code> API have a different pricing structure than
        /// calls to <code>GetMetricStatistics</code>. For more information about pricing, see
        /// <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon CloudWatch Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon CloudWatch retains metric data as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data points with a period of less than 60 seconds are available for 3 hours. These
        /// data points are high-resolution metrics and are available only for custom metrics
        /// that have been defined with a <code>StorageResolution</code> of 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 60 seconds (1-minute) are available for 15 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 300 seconds (5-minute) are available for 63 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 3600 seconds (1 hour) are available for 455 days (15
        /// months).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Data points that are initially published with a shorter period are aggregated together
        /// for long-term storage. For example, if you collect data using a period of 1 minute,
        /// the data remains available for 15 days with 1-minute resolution. After 15 days, this
        /// data is still available, but is aggregated and retrievable only with a resolution
        /// of 5 minutes. After 63 days, the data is further aggregated and is available with
        /// a resolution of 1 hour.
        /// </para>
        ///  
        /// <para>
        /// If you omit <code>Unit</code> in your request, all data that was collected with any
        /// unit is returned, along with the corresponding units that were specified when the
        /// data was reported to CloudWatch. If you specify a unit, the operation returns only
        /// data that was collected with that unit specified. If you specify a unit that does
        /// not match the data collected, the results of the operation are null. CloudWatch does
        /// not perform unit conversions.
        /// </para>
        ///  
        /// <para>
        ///  <b>Using Metrics Insights queries with metric math</b> 
        /// </para>
        ///  
        /// <para>
        /// You can't mix a Metric Insights query and metric math syntax in the same expression,
        /// but you can reference results from a Metrics Insights query within other Metric math
        /// expressions. A Metrics Insights query without a <b>GROUP BY</b> clause returns a single
        /// time-series (TS), and can be used as input for a metric math expression that expects
        /// a single time series. A Metrics Insights query with a <b>GROUP BY</b> clause returns
        /// an array of time-series (TS[]), and can be used as input for a metric math expression
        /// that expects an array of time series. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual GetMetricDataResponse GetMetricData(GetMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return Invoke<GetMetricDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual IAsyncResult BeginGetMetricData(GetMetricDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricData.</param>
        /// 
        /// <returns>Returns a  GetMetricDataResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        public virtual GetMetricDataResponse EndGetMetricData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMetricDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMetricStatistics

        /// <summary>
        /// Gets statistics for the specified metric.
        /// 
        ///  
        /// <para>
        /// The maximum number of data points returned from a single call is 1,440. If you request
        /// more than 1,440 data points, CloudWatch returns an error. To reduce the number of
        /// data points, you can narrow the specified time range and make multiple requests across
        /// adjacent time ranges, or you can increase the specified period. Data points are not
        /// returned in chronological order.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch aggregates data points based on the length of the period that you specify.
        /// For example, if you request statistics with a one-hour period, CloudWatch aggregates
        /// all data points with time stamps that fall within each one-hour period. Therefore,
        /// the number of values aggregated by CloudWatch is larger than the number of data points
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch needs raw data points to calculate percentile statistics. If you publish
        /// data using a statistic set instead, you can only retrieve percentile statistics for
        /// this data if one of the following conditions is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The SampleCount value of the statistic set is 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Min and the Max values of the statistic set are equal.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Percentile statistics are not available for metrics when any of the metric values
        /// are negative numbers.
        /// </para>
        ///  
        /// <para>
        /// Amazon CloudWatch retains metric data as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Data points with a period of less than 60 seconds are available for 3 hours. These
        /// data points are high-resolution metrics and are available only for custom metrics
        /// that have been defined with a <code>StorageResolution</code> of 1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 60 seconds (1-minute) are available for 15 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 300 seconds (5-minute) are available for 63 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Data points with a period of 3600 seconds (1 hour) are available for 455 days (15
        /// months).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Data points that are initially published with a shorter period are aggregated together
        /// for long-term storage. For example, if you collect data using a period of 1 minute,
        /// the data remains available for 15 days with 1-minute resolution. After 15 days, this
        /// data is still available, but is aggregated and retrievable only with a resolution
        /// of 5 minutes. After 63 days, the data is further aggregated and is available with
        /// a resolution of 1 hour.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch started retaining 5-minute and 1-hour metric data as of July 9, 2016.
        /// </para>
        ///  
        /// <para>
        /// For information about metrics and dimensions supported by Amazon Web Services services,
        /// see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CW_Support_For_AWS.html">Amazon
        /// CloudWatch Metrics and Dimensions Reference</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics service method.</param>
        /// 
        /// <returns>The response from the GetMetricStatistics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStatistics">REST API Reference for GetMetricStatistics Operation</seealso>
        public virtual GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricStatisticsResponseUnmarshaller.Instance;

            return Invoke<GetMetricStatisticsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStatistics operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStatistics">REST API Reference for GetMetricStatistics Operation</seealso>
        public virtual IAsyncResult BeginGetMetricStatistics(GetMetricStatisticsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricStatisticsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricStatisticsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricStatistics.</param>
        /// 
        /// <returns>Returns a  GetMetricStatisticsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStatistics">REST API Reference for GetMetricStatistics Operation</seealso>
        public virtual GetMetricStatisticsResponse EndGetMetricStatistics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMetricStatisticsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMetricStream

        /// <summary>
        /// Returns information about the metric stream that you specify.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStream service method.</param>
        /// 
        /// <returns>The response from the GetMetricStream service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStream">REST API Reference for GetMetricStream Operation</seealso>
        public virtual GetMetricStreamResponse GetMetricStream(GetMetricStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricStreamResponseUnmarshaller.Instance;

            return Invoke<GetMetricStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricStream operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStream">REST API Reference for GetMetricStream Operation</seealso>
        public virtual IAsyncResult BeginGetMetricStream(GetMetricStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricStream.</param>
        /// 
        /// <returns>Returns a  GetMetricStreamResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricStream">REST API Reference for GetMetricStream Operation</seealso>
        public virtual GetMetricStreamResponse EndGetMetricStream(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMetricStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMetricWidgetImage

        /// <summary>
        /// You can use the <code>GetMetricWidgetImage</code> API to retrieve a snapshot graph
        /// of one or more Amazon CloudWatch metrics as a bitmap image. You can then embed this
        /// image into your services and products, such as wiki pages, reports, and documents.
        /// You could also retrieve images regularly, such as every minute, and create your own
        /// custom live dashboard.
        /// 
        ///  
        /// <para>
        /// The graph you retrieve can include all CloudWatch metric graph features, including
        /// metric math and horizontal and vertical annotations.
        /// </para>
        ///  
        /// <para>
        /// There is a limit of 20 transactions per second for this API. Each <code>GetMetricWidgetImage</code>
        /// action has the following limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// As many as 100 metrics in the graph.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Up to 100 KB uncompressed payload.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricWidgetImage service method.</param>
        /// 
        /// <returns>The response from the GetMetricWidgetImage service method, as returned by CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricWidgetImage">REST API Reference for GetMetricWidgetImage Operation</seealso>
        public virtual GetMetricWidgetImageResponse GetMetricWidgetImage(GetMetricWidgetImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricWidgetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricWidgetImageResponseUnmarshaller.Instance;

            return Invoke<GetMetricWidgetImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetricWidgetImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetricWidgetImage operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetricWidgetImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricWidgetImage">REST API Reference for GetMetricWidgetImage Operation</seealso>
        public virtual IAsyncResult BeginGetMetricWidgetImage(GetMetricWidgetImageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMetricWidgetImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetricWidgetImageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetricWidgetImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetricWidgetImage.</param>
        /// 
        /// <returns>Returns a  GetMetricWidgetImageResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/GetMetricWidgetImage">REST API Reference for GetMetricWidgetImage Operation</seealso>
        public virtual GetMetricWidgetImageResponse EndGetMetricWidgetImage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMetricWidgetImageResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDashboards

        /// <summary>
        /// Returns a list of the dashboards for your account. If you include <code>DashboardNamePrefix</code>,
        /// only those dashboards with names starting with the prefix are listed. Otherwise, all
        /// dashboards in your account are listed. 
        /// 
        ///  
        /// <para>
        ///  <code>ListDashboards</code> returns up to 1000 results on one page. If there are
        /// more than 1000 dashboards, you can call <code>ListDashboards</code> again and include
        /// the value you received for <code>NextToken</code> in the first call, to receive the
        /// next 1000 results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return Invoke<ListDashboardsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDashboards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual IAsyncResult BeginListDashboards(ListDashboardsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDashboardsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDashboardsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDashboards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDashboards.</param>
        /// 
        /// <returns>Returns a  ListDashboardsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        public virtual ListDashboardsResponse EndListDashboards(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDashboardsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListManagedInsightRules

        /// <summary>
        /// Returns a list that contains the number of managed Contributor Insights rules in
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedInsightRules service method.</param>
        /// 
        /// <returns>The response from the ListManagedInsightRules service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListManagedInsightRules">REST API Reference for ListManagedInsightRules Operation</seealso>
        public virtual ListManagedInsightRulesResponse ListManagedInsightRules(ListManagedInsightRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedInsightRulesResponseUnmarshaller.Instance;

            return Invoke<ListManagedInsightRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedInsightRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedInsightRules operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedInsightRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListManagedInsightRules">REST API Reference for ListManagedInsightRules Operation</seealso>
        public virtual IAsyncResult BeginListManagedInsightRules(ListManagedInsightRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListManagedInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListManagedInsightRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedInsightRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedInsightRules.</param>
        /// 
        /// <returns>Returns a  ListManagedInsightRulesResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListManagedInsightRules">REST API Reference for ListManagedInsightRules Operation</seealso>
        public virtual ListManagedInsightRulesResponse EndListManagedInsightRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListManagedInsightRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMetrics

        /// <summary>
        /// List the specified metrics. You can use the returned metrics with <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>
        /// to get statistical data.
        /// 
        ///  
        /// <para>
        /// Up to 500 results are returned for any one call. To retrieve additional results, use
        /// the returned token with subsequent calls.
        /// </para>
        ///  
        /// <para>
        /// After you create a metric, allow up to 15 minutes for the metric to appear. To see
        /// metric statistics sooner, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view metrics from the linked source accounts. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>ListMetrics</code> doesn't return information about metrics if those metrics
        /// haven't reported data in the past two weeks. To retrieve those metrics, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual ListMetricsResponse ListMetrics()
        {
            return ListMetrics(new ListMetricsRequest());
        }

        /// <summary>
        /// List the specified metrics. You can use the returned metrics with <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>
        /// to get statistical data.
        /// 
        ///  
        /// <para>
        /// Up to 500 results are returned for any one call. To retrieve additional results, use
        /// the returned token with subsequent calls.
        /// </para>
        ///  
        /// <para>
        /// After you create a metric, allow up to 15 minutes for the metric to appear. To see
        /// metric statistics sooner, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view metrics from the linked source accounts. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>ListMetrics</code> doesn't return information about metrics if those metrics
        /// haven't reported data in the past two weeks. To retrieve those metrics, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics service method.</param>
        /// 
        /// <returns>The response from the ListMetrics service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual ListMetricsResponse ListMetrics(ListMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricsResponseUnmarshaller.Instance;

            return Invoke<ListMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetrics operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual IAsyncResult BeginListMetrics(ListMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetrics.</param>
        /// 
        /// <returns>Returns a  ListMetricsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetrics">REST API Reference for ListMetrics Operation</seealso>
        public virtual ListMetricsResponse EndListMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMetricStreams

        /// <summary>
        /// Returns a list of metric streams in this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetricStreams service method.</param>
        /// 
        /// <returns>The response from the ListMetricStreams service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidNextTokenException">
        /// The next token specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetricStreams">REST API Reference for ListMetricStreams Operation</seealso>
        public virtual ListMetricStreamsResponse ListMetricStreams(ListMetricStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMetricStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricStreamsResponseUnmarshaller.Instance;

            return Invoke<ListMetricStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetricStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetricStreams operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetricStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetricStreams">REST API Reference for ListMetricStreams Operation</seealso>
        public virtual IAsyncResult BeginListMetricStreams(ListMetricStreamsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMetricStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetricStreamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetricStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetricStreams.</param>
        /// 
        /// <returns>Returns a  ListMetricStreamsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListMetricStreams">REST API Reference for ListMetricStreams Operation</seealso>
        public virtual ListMetricStreamsResponse EndListMetricStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMetricStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Displays the tags associated with a CloudWatch resource. Currently, alarms and Contributor
        /// Insights rules support tagging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAnomalyDetector

        /// <summary>
        /// Creates an anomaly detection model for a CloudWatch metric. You can use the model
        /// to display a band of expected normal values when the metric is graphed.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Anomaly_Detection.html">CloudWatch
        /// Anomaly Detection</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAnomalyDetector service method.</param>
        /// 
        /// <returns>The response from the PutAnomalyDetector service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.LimitExceededException">
        /// The operation exceeded one or more limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutAnomalyDetector">REST API Reference for PutAnomalyDetector Operation</seealso>
        public virtual PutAnomalyDetectorResponse PutAnomalyDetector(PutAnomalyDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<PutAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAnomalyDetector operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutAnomalyDetector">REST API Reference for PutAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginPutAnomalyDetector(PutAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  PutAnomalyDetectorResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutAnomalyDetector">REST API Reference for PutAnomalyDetector Operation</seealso>
        public virtual PutAnomalyDetectorResponse EndPutAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region  PutCompositeAlarm

        /// <summary>
        /// Creates or updates a <i>composite alarm</i>. When you create a composite alarm, you
        /// specify a rule expression for the alarm that takes into account the alarm states of
        /// other alarms that you have created. The composite alarm goes into ALARM state only
        /// if all conditions of the rule are met.
        /// 
        ///  
        /// <para>
        /// The alarms specified in a composite alarm's rule expression can include metric alarms
        /// and other composite alarms. The rule expression of a composite alarm can include as
        /// many as 100 underlying alarms. Any single alarm can be included in the rule expressions
        /// of as many as 150 composite alarms.
        /// </para>
        ///  
        /// <para>
        /// Using composite alarms can reduce alarm noise. You can create multiple metric alarms,
        /// and also create a composite alarm and set up alerts only for the composite alarm.
        /// For example, you could create a composite alarm that goes into ALARM state only when
        /// more than one of the underlying metric alarms are in ALARM state.
        /// </para>
        ///  
        /// <para>
        /// Currently, the only alarm actions that can be taken by composite alarms are notifying
        /// SNS topics.
        /// </para>
        ///  <note> 
        /// <para>
        /// It is possible to create a loop or cycle of composite alarms, where composite alarm
        /// A depends on composite alarm B, and composite alarm B also depends on composite alarm
        /// A. In this scenario, you can't delete any composite alarm that is part of the cycle
        /// because there is always still a composite alarm that depends on that alarm that you
        /// want to delete.
        /// </para>
        ///  
        /// <para>
        /// To get out of such a situation, you must break the cycle by changing the rule of one
        /// of the composite alarms in the cycle to remove a dependency that creates the cycle.
        /// The simplest change to make to break a cycle is to change the <code>AlarmRule</code>
        /// of one of the alarms to <code>false</code>. 
        /// </para>
        ///  
        /// <para>
        /// Additionally, the evaluation of composite alarms stops if CloudWatch detects a cycle
        /// in the evaluation path. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
        /// The alarm is then evaluated and its state is set appropriately. Any actions associated
        /// with the new state are then executed. For a composite alarm, this initial time after
        /// creation is the only time that the alarm can be in <code>INSUFFICIENT_DATA</code>
        /// state.
        /// </para>
        ///  
        /// <para>
        /// When you update an existing alarm, its state is left unchanged, but the update completely
        /// overwrites the previous configuration of the alarm.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must be signed on with the <code>cloudwatch:PutCompositeAlarm</code>
        /// permission that is scoped to <code>*</code>. You can't create a composite alarms if
        /// your <code>cloudwatch:PutCompositeAlarm</code> permission has a narrower scope.
        /// </para>
        ///  
        /// <para>
        /// If you are an IAM user, you must have <code>iam:CreateServiceLinkedRole</code> to
        /// create a composite alarm that has Systems Manager OpsItem actions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCompositeAlarm service method.</param>
        /// 
        /// <returns>The response from the PutCompositeAlarm service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.LimitExceededException">
        /// The quota for alarms for this customer has already been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutCompositeAlarm">REST API Reference for PutCompositeAlarm Operation</seealso>
        public virtual PutCompositeAlarmResponse PutCompositeAlarm(PutCompositeAlarmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCompositeAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCompositeAlarmResponseUnmarshaller.Instance;

            return Invoke<PutCompositeAlarmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutCompositeAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCompositeAlarm operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutCompositeAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutCompositeAlarm">REST API Reference for PutCompositeAlarm Operation</seealso>
        public virtual IAsyncResult BeginPutCompositeAlarm(PutCompositeAlarmRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCompositeAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCompositeAlarmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutCompositeAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCompositeAlarm.</param>
        /// 
        /// <returns>Returns a  PutCompositeAlarmResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutCompositeAlarm">REST API Reference for PutCompositeAlarm Operation</seealso>
        public virtual PutCompositeAlarmResponse EndPutCompositeAlarm(IAsyncResult asyncResult)
        {
            return EndInvoke<PutCompositeAlarmResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDashboard

        /// <summary>
        /// Creates a dashboard if it does not already exist, or updates an existing dashboard.
        /// If you update a dashboard, the entire contents are replaced with what you specify
        /// here.
        /// 
        ///  
        /// <para>
        /// All dashboards in your account are global, not region-specific.
        /// </para>
        ///  
        /// <para>
        /// A simple way to create a dashboard using <code>PutDashboard</code> is to copy an existing
        /// dashboard. To copy an existing dashboard using the console, you can load the dashboard
        /// and then use the View/edit source command in the Actions menu to display the JSON
        /// block for that dashboard. Another way to copy a dashboard is to use <code>GetDashboard</code>,
        /// and then use the data returned within <code>DashboardBody</code> as the template for
        /// the new dashboard when you call <code>PutDashboard</code>.
        /// </para>
        ///  
        /// <para>
        /// When you create a dashboard with <code>PutDashboard</code>, a good practice is to
        /// add a text widget at the top of the dashboard with a message that the dashboard was
        /// created by script and should not be changed in the console. This message could also
        /// point console users to the location of the <code>DashboardBody</code> script or the
        /// CloudFormation template used to create the dashboard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDashboard service method.</param>
        /// 
        /// <returns>The response from the PutDashboard service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.DashboardInvalidInputErrorException">
        /// Some part of the dashboard data is invalid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutDashboard">REST API Reference for PutDashboard Operation</seealso>
        public virtual PutDashboardResponse PutDashboard(PutDashboardRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDashboardResponseUnmarshaller.Instance;

            return Invoke<PutDashboardResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDashboard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDashboard operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDashboard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutDashboard">REST API Reference for PutDashboard Operation</seealso>
        public virtual IAsyncResult BeginPutDashboard(PutDashboardRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDashboardRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDashboardResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDashboard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDashboard.</param>
        /// 
        /// <returns>Returns a  PutDashboardResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutDashboard">REST API Reference for PutDashboard Operation</seealso>
        public virtual PutDashboardResponse EndPutDashboard(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDashboardResponse>(asyncResult);
        }

        #endregion
        
        #region  PutInsightRule

        /// <summary>
        /// Creates a Contributor Insights rule. Rules evaluate log events in a CloudWatch Logs
        /// log group, enabling you to find contributor data for the log events in that log group.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/ContributorInsights.html">Using
        /// Contributor Insights to Analyze High-Cardinality Data</a>.
        /// 
        ///  
        /// <para>
        /// If you create a rule, delete it, and then re-create it with the same name, historical
        /// data from the first time the rule was created might not be available.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInsightRule service method.</param>
        /// 
        /// <returns>The response from the PutInsightRule service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.LimitExceededException">
        /// The operation exceeded one or more limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutInsightRule">REST API Reference for PutInsightRule Operation</seealso>
        public virtual PutInsightRuleResponse PutInsightRule(PutInsightRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInsightRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInsightRuleResponseUnmarshaller.Instance;

            return Invoke<PutInsightRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutInsightRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInsightRule operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInsightRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutInsightRule">REST API Reference for PutInsightRule Operation</seealso>
        public virtual IAsyncResult BeginPutInsightRule(PutInsightRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutInsightRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutInsightRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutInsightRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInsightRule.</param>
        /// 
        /// <returns>Returns a  PutInsightRuleResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutInsightRule">REST API Reference for PutInsightRule Operation</seealso>
        public virtual PutInsightRuleResponse EndPutInsightRule(IAsyncResult asyncResult)
        {
            return EndInvoke<PutInsightRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  PutManagedInsightRules

        /// <summary>
        /// Creates a managed Contributor Insights rule for a specified Amazon Web Services resource.
        /// When you enable a managed rule, you create a Contributor Insights rule that collects
        /// data from Amazon Web Services services. You cannot edit these rules with <code>PutInsightRule</code>.
        /// The rules can be enabled, disabled, and deleted using <code>EnableInsightRules</code>,
        /// <code>DisableInsightRules</code>, and <code>DeleteInsightRules</code>. If a previously
        /// created managed rule is currently disabled, a subsequent call to this API will re-enable
        /// it. Use <code>ListManagedInsightRules</code> to describe all available rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutManagedInsightRules service method.</param>
        /// 
        /// <returns>The response from the PutManagedInsightRules service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutManagedInsightRules">REST API Reference for PutManagedInsightRules Operation</seealso>
        public virtual PutManagedInsightRulesResponse PutManagedInsightRules(PutManagedInsightRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutManagedInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutManagedInsightRulesResponseUnmarshaller.Instance;

            return Invoke<PutManagedInsightRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutManagedInsightRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutManagedInsightRules operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutManagedInsightRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutManagedInsightRules">REST API Reference for PutManagedInsightRules Operation</seealso>
        public virtual IAsyncResult BeginPutManagedInsightRules(PutManagedInsightRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutManagedInsightRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutManagedInsightRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutManagedInsightRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutManagedInsightRules.</param>
        /// 
        /// <returns>Returns a  PutManagedInsightRulesResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutManagedInsightRules">REST API Reference for PutManagedInsightRules Operation</seealso>
        public virtual PutManagedInsightRulesResponse EndPutManagedInsightRules(IAsyncResult asyncResult)
        {
            return EndInvoke<PutManagedInsightRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMetricAlarm

        /// <summary>
        /// Creates or updates an alarm and associates it with the specified metric, metric math
        /// expression, or anomaly detection model.
        /// 
        ///  
        /// <para>
        /// Alarms based on anomaly detection models cannot have Auto Scaling actions.
        /// </para>
        ///  
        /// <para>
        /// When this operation creates an alarm, the alarm state is immediately set to <code>INSUFFICIENT_DATA</code>.
        /// The alarm is then evaluated and its state is set appropriately. Any actions associated
        /// with the new state are then executed.
        /// </para>
        ///  
        /// <para>
        /// When you update an existing alarm, its state is left unchanged, but the update completely
        /// overwrites the previous configuration of the alarm.
        /// </para>
        ///  
        /// <para>
        /// If you are an IAM user, you must have Amazon EC2 permissions for some alarm operations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>iam:CreateServiceLinkedRole</code> for all alarms with EC2 actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>iam:CreateServiceLinkedRole</code> to create an alarm with Systems Manager
        /// OpsItem actions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The first time you create an alarm in the Amazon Web Services Management Console,
        /// the CLI, or by using the PutMetricAlarm API, CloudWatch creates the necessary service-linked
        /// role for you. The service-linked roles are called <code>AWSServiceRoleForCloudWatchEvents</code>
        /// and <code>AWSServiceRoleForCloudWatchAlarms_ActionSSM</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html#iam-term-service-linked-role">Amazon
        /// Web Services service-linked role</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account alarms</b> 
        /// </para>
        ///  
        /// <para>
        /// You can set an alarm on metrics in the current account, or in another account. To
        /// create a cross-account alarm that watches a metric in a different account, you must
        /// have completed the following pre-requisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The account where the metrics are located (the <i>sharing account</i>) must already
        /// have a sharing role named <b>CloudWatch-CrossAccountSharingRole</b>. If it does not
        /// already have this role, you must create it using the instructions in <b>Set up a sharing
        /// account</b> in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Cross-Account-Cross-Region.html#enable-cross-account-cross-Region">
        /// Cross-account cross-Region CloudWatch console</a>. The policy for that role must grant
        /// access to the ID of the account where you are creating the alarm. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The account where you are creating the alarm (the <i>monitoring account</i>) must
        /// already have a service-linked role named <b>AWSServiceRoleForCloudWatchCrossAccount</b>
        /// to allow CloudWatch to assume the sharing role in the sharing account. If it does
        /// not, you must create it following the directions in <b>Set up a monitoring account</b>
        /// in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Cross-Account-Cross-Region.html#enable-cross-account-cross-Region">
        /// Cross-account cross-Region CloudWatch console</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm service method.</param>
        /// 
        /// <returns>The response from the PutMetricAlarm service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.LimitExceededException">
        /// The quota for alarms for this customer has already been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricAlarm">REST API Reference for PutMetricAlarm Operation</seealso>
        public virtual PutMetricAlarmResponse PutMetricAlarm(PutMetricAlarmRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricAlarmResponseUnmarshaller.Instance;

            return Invoke<PutMetricAlarmResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricAlarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricAlarm operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetricAlarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricAlarm">REST API Reference for PutMetricAlarm Operation</seealso>
        public virtual IAsyncResult BeginPutMetricAlarm(PutMetricAlarmRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricAlarmRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricAlarmResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetricAlarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricAlarm.</param>
        /// 
        /// <returns>Returns a  PutMetricAlarmResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricAlarm">REST API Reference for PutMetricAlarm Operation</seealso>
        public virtual PutMetricAlarmResponse EndPutMetricAlarm(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMetricAlarmResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMetricData

        /// <summary>
        /// Publishes metric data points to Amazon CloudWatch. CloudWatch associates the data
        /// points with the specified metric. If the specified metric does not exist, CloudWatch
        /// creates the metric. When CloudWatch creates a metric, it can take up to fifteen minutes
        /// for the metric to appear in calls to <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_ListMetrics.html">ListMetrics</a>.
        /// 
        ///  
        /// <para>
        /// You can publish either individual data points in the <code>Value</code> field, or
        /// arrays of values and the number of times each value occurred during the period by
        /// using the <code>Values</code> and <code>Counts</code> fields in the <code>MetricDatum</code>
        /// structure. Using the <code>Values</code> and <code>Counts</code> method enables you
        /// to publish up to 150 values per metric with one <code>PutMetricData</code> request,
        /// and supports retrieving percentile statistics on this data.
        /// </para>
        ///  
        /// <para>
        /// Each <code>PutMetricData</code> request is limited to 1 MB in size for HTTP POST requests.
        /// You can send a payload compressed by gzip. Each request is also limited to no more
        /// than 1000 different metrics.
        /// </para>
        ///  
        /// <para>
        /// Although the <code>Value</code> parameter accepts numbers of type <code>Double</code>,
        /// CloudWatch rejects values that are either too small or too large. Values must be in
        /// the range of -2^360 to 2^360. In addition, special values (for example, NaN, +Infinity,
        /// -Infinity) are not supported.
        /// </para>
        ///  
        /// <para>
        /// You can use up to 30 dimensions per metric to further clarify what data the metric
        /// collects. Each dimension consists of a Name and Value pair. For more information about
        /// specifying dimensions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html">Publishing
        /// Metrics</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You specify the time stamp to be associated with each data point. You can specify
        /// time stamps that are as much as two weeks before the current date, and as much as
        /// 2 hours after the current day and time.
        /// </para>
        ///  
        /// <para>
        /// Data points with time stamps from 24 hours ago or longer can take at least 48 hours
        /// to become available for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>
        /// from the time they are submitted. Data points with time stamps between 3 and 24 hours
        /// ago can take as much as 2 hours to become available for for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch needs raw data points to calculate percentile statistics. If you publish
        /// data using a statistic set instead, you can only retrieve percentile statistics for
        /// this data if one of the following conditions is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>SampleCount</code> value of the statistic set is 1 and <code>Min</code>,
        /// <code>Max</code>, and <code>Sum</code> are all equal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Min</code> and <code>Max</code> are equal, and <code>Sum</code> is equal
        /// to <code>Min</code> multiplied by <code>SampleCount</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual PutMetricDataResponse PutMetricData(PutMetricDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return Invoke<PutMetricDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetricData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual IAsyncResult BeginPutMetricData(PutMetricDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetricData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricData.</param>
        /// 
        /// <returns>Returns a  PutMetricDataResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        public virtual PutMetricDataResponse EndPutMetricData(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMetricDataResponse>(asyncResult);
        }

        #endregion
        
        #region  PutMetricStream

        /// <summary>
        /// Creates or updates a metric stream. Metric streams can automatically stream CloudWatch
        /// metrics to Amazon Web Services destinations, including Amazon S3, and to many third-party
        /// solutions.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Metric-Streams.html">
        /// Using Metric Streams</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a metric stream, you must be signed in to an account that has the <code>iam:PassRole</code>
        /// permission and either the <code>CloudWatchFullAccess</code> policy or the <code>cloudwatch:PutMetricStream</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// When you create or update a metric stream, you choose one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Stream metrics from all metric namespaces in the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stream metrics from all metric namespaces in the account, except for the namespaces
        /// that you list in <code>ExcludeFilters</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stream metrics from only the metric namespaces that you list in <code>IncludeFilters</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By default, a metric stream always sends the <code>MAX</code>, <code>MIN</code>, <code>SUM</code>,
        /// and <code>SAMPLECOUNT</code> statistics for each metric that is streamed. You can
        /// use the <code>StatisticsConfigurations</code> parameter to have the metric stream
        /// send additional statistics in the stream. Streaming additional statistics incurs additional
        /// costs. For more information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>. 
        /// </para>
        ///  
        /// <para>
        /// When you use <code>PutMetricStream</code> to create a new metric stream, the stream
        /// is created in the <code>running</code> state. If you use it to update an existing
        /// stream, the state of the stream is not changed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricStream service method.</param>
        /// 
        /// <returns>The response from the PutMetricStream service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterCombinationException">
        /// Parameters were used together that cannot be used together.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricStream">REST API Reference for PutMetricStream Operation</seealso>
        public virtual PutMetricStreamResponse PutMetricStream(PutMetricStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricStreamResponseUnmarshaller.Instance;

            return Invoke<PutMetricStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricStream operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetricStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricStream">REST API Reference for PutMetricStream Operation</seealso>
        public virtual IAsyncResult BeginPutMetricStream(PutMetricStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetricStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricStream.</param>
        /// 
        /// <returns>Returns a  PutMetricStreamResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/PutMetricStream">REST API Reference for PutMetricStream Operation</seealso>
        public virtual PutMetricStreamResponse EndPutMetricStream(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMetricStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  SetAlarmState

        /// <summary>
        /// Temporarily sets the state of an alarm for testing purposes. When the updated state
        /// differs from the previous value, the action configured for the appropriate state is
        /// invoked. For example, if your alarm is configured to send an Amazon SNS message when
        /// an alarm is triggered, temporarily changing the alarm state to <code>ALARM</code>
        /// sends an SNS message.
        /// 
        ///  
        /// <para>
        /// Metric alarms returns to their actual state quickly, often within seconds. Because
        /// the metric alarm state change happens quickly, it is typically only visible in the
        /// alarm's <b>History</b> tab in the Amazon CloudWatch console or through <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DescribeAlarmHistory.html">DescribeAlarmHistory</a>.
        /// </para>
        ///  
        /// <para>
        /// If you use <code>SetAlarmState</code> on a composite alarm, the composite alarm is
        /// not guaranteed to return to its actual state. It returns to its actual state only
        /// once any of its children alarms change state. It is also reevaluated if you update
        /// its configuration.
        /// </para>
        ///  
        /// <para>
        /// If an alarm triggers EC2 Auto Scaling policies or application Auto Scaling policies,
        /// you must include information in the <code>StateReasonData</code> parameter to enable
        /// the policy to take the correct action.
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/SetAlarmState">REST API Reference for SetAlarmState Operation</seealso>
        public virtual SetAlarmStateResponse SetAlarmState(SetAlarmStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetAlarmStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetAlarmStateResponseUnmarshaller.Instance;

            return Invoke<SetAlarmStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetAlarmState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetAlarmState operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetAlarmState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/SetAlarmState">REST API Reference for SetAlarmState Operation</seealso>
        public virtual IAsyncResult BeginSetAlarmState(SetAlarmStateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetAlarmStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetAlarmStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SetAlarmState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetAlarmState.</param>
        /// 
        /// <returns>Returns a  SetAlarmStateResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/SetAlarmState">REST API Reference for SetAlarmState Operation</seealso>
        public virtual SetAlarmStateResponse EndSetAlarmState(IAsyncResult asyncResult)
        {
            return EndInvoke<SetAlarmStateResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMetricStreams

        /// <summary>
        /// Starts the streaming of metrics for one or more of your metric streams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetricStreams service method.</param>
        /// 
        /// <returns>The response from the StartMetricStreams service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/StartMetricStreams">REST API Reference for StartMetricStreams Operation</seealso>
        public virtual StartMetricStreamsResponse StartMetricStreams(StartMetricStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetricStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetricStreamsResponseUnmarshaller.Instance;

            return Invoke<StartMetricStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMetricStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMetricStreams operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMetricStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/StartMetricStreams">REST API Reference for StartMetricStreams Operation</seealso>
        public virtual IAsyncResult BeginStartMetricStreams(StartMetricStreamsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMetricStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetricStreamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMetricStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMetricStreams.</param>
        /// 
        /// <returns>Returns a  StartMetricStreamsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/StartMetricStreams">REST API Reference for StartMetricStreams Operation</seealso>
        public virtual StartMetricStreamsResponse EndStartMetricStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMetricStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  StopMetricStreams

        /// <summary>
        /// Stops the streaming of metrics for one or more of your metric streams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMetricStreams service method.</param>
        /// 
        /// <returns>The response from the StopMetricStreams service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.MissingRequiredParameterException">
        /// An input parameter that is required is missing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/StopMetricStreams">REST API Reference for StopMetricStreams Operation</seealso>
        public virtual StopMetricStreamsResponse StopMetricStreams(StopMetricStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMetricStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMetricStreamsResponseUnmarshaller.Instance;

            return Invoke<StopMetricStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopMetricStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMetricStreams operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMetricStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/StopMetricStreams">REST API Reference for StopMetricStreams Operation</seealso>
        public virtual IAsyncResult BeginStopMetricStreams(StopMetricStreamsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMetricStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMetricStreamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopMetricStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMetricStreams.</param>
        /// 
        /// <returns>Returns a  StopMetricStreamsResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/StopMetricStreams">REST API Reference for StopMetricStreams Operation</seealso>
        public virtual StopMetricStreamsResponse EndStopMetricStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<StopMetricStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch resource. Currently,
        /// the only CloudWatch resources that can be tagged are alarms and Contributor Insights
        /// rules.
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with an alarm that already has tags.
        /// If you specify a new tag key for the alarm, this tag is appended to the list of tags
        /// associated with the alarm. If you specify a tag key that is already associated with
        /// the alarm, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a CloudWatch resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatch.</returns>
        /// <exception cref="Amazon.CloudWatch.Model.ConcurrentModificationException">
        /// More than one process tried to modify a resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InternalServiceException">
        /// Request processing has failed due to some unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.InvalidParameterValueException">
        /// The value of an input parameter is bad or out-of-range.
        /// </exception>
        /// <exception cref="Amazon.CloudWatch.Model.ResourceNotFoundException">
        /// The named resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudWatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from CloudWatch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/monitoring-2010-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}