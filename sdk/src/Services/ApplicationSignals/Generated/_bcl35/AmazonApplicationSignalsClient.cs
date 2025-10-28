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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ApplicationSignals.Model;
using Amazon.ApplicationSignals.Model.Internal.MarshallTransformations;
using Amazon.ApplicationSignals.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.ApplicationSignals
{
    /// <summary>
    /// <para>Implementation for accessing ApplicationSignals</para>
    ///
    /// Use CloudWatch Application Signals for comprehensive observability of your cloud-based
    /// applications. It enables real-time service health dashboards and helps you track long-term
    /// performance trends against your business goals. The application-centric view provides
    /// you with unified visibility across your applications, services, and dependencies,
    /// so you can proactively monitor and efficiently triage any issues that may arise, ensuring
    /// optimal customer experience.
    /// 
    ///  
    /// <para>
    /// Application Signals provides the following benefits:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Automatically collect metrics and traces from your applications, and display key metrics
    /// such as call volume, availability, latency, faults, and errors. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create and monitor service level objectives (SLOs). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// See a map of your application topology that Application Signals automatically discovers,
    /// that gives you a visual representation of your applications, dependencies, and their
    /// connectivity.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Application Signals works with CloudWatch RUM, CloudWatch Synthetics canaries, and
    /// Amazon Web Services Service Catalog AppRegistry, to display your client pages, Synthetics
    /// canaries, and application names within dashboards and maps.
    /// </para>
    /// </summary>
    public partial class AmazonApplicationSignalsClient : AmazonServiceClient, IAmazonApplicationSignals
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationSignalsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IApplicationSignalsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IApplicationSignalsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ApplicationSignalsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with the credentials loaded from the application's
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
        public AmazonApplicationSignalsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationSignalsConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with the credentials loaded from the application's
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
        public AmazonApplicationSignalsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationSignalsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApplicationSignalsClient Configuration Object</param>
        public AmazonApplicationSignalsClient(AmazonApplicationSignalsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationSignalsClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationSignalsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationSignalsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationSignalsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Credentials and an
        /// AmazonApplicationSignalsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationSignalsClient Configuration Object</param>
        public AmazonApplicationSignalsClient(AWSCredentials credentials, AmazonApplicationSignalsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationSignalsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationSignalsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationSignalsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationSignalsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationSignalsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationSignalsClient Configuration Object</param>
        public AmazonApplicationSignalsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationSignalsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationSignalsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationSignalsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationSignalsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationSignalsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationSignalsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationSignalsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationSignalsClient Configuration Object</param>
        public AmazonApplicationSignalsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationSignalsConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonApplicationSignalsEndpointResolver());
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


        #region  BatchGetServiceLevelObjectiveBudgetReport

        /// <summary>
        /// Use this operation to retrieve one or more <i>service level objective (SLO) budget
        /// reports</i>.
        /// 
        ///  
        /// <para>
        /// An <i>error budget</i> is the amount of time or requests in an unhealthy state that
        /// your service can accumulate during an interval before your overall SLO budget health
        /// is breached and the SLO is considered to be unmet. For example, an SLO with a threshold
        /// of 99.95% and a monthly interval translates to an error budget of 21.9 minutes of
        /// downtime in a 30-day month.
        /// </para>
        ///  
        /// <para>
        /// Budget reports include a health indicator, the attainment value, and remaining budget.
        /// </para>
        ///  
        /// <para>
        /// For more information about SLO error budgets, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-ServiceLevelObjectives.html#CloudWatch-ServiceLevelObjectives-concepts">
        /// SLO concepts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetServiceLevelObjectiveBudgetReport service method.</param>
        /// 
        /// <returns>The response from the BatchGetServiceLevelObjectiveBudgetReport service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/BatchGetServiceLevelObjectiveBudgetReport">REST API Reference for BatchGetServiceLevelObjectiveBudgetReport Operation</seealso>
        public virtual BatchGetServiceLevelObjectiveBudgetReportResponse BatchGetServiceLevelObjectiveBudgetReport(BatchGetServiceLevelObjectiveBudgetReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetServiceLevelObjectiveBudgetReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetServiceLevelObjectiveBudgetReportResponseUnmarshaller.Instance;

            return Invoke<BatchGetServiceLevelObjectiveBudgetReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetServiceLevelObjectiveBudgetReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetServiceLevelObjectiveBudgetReport operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetServiceLevelObjectiveBudgetReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/BatchGetServiceLevelObjectiveBudgetReport">REST API Reference for BatchGetServiceLevelObjectiveBudgetReport Operation</seealso>
        public virtual IAsyncResult BeginBatchGetServiceLevelObjectiveBudgetReport(BatchGetServiceLevelObjectiveBudgetReportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetServiceLevelObjectiveBudgetReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetServiceLevelObjectiveBudgetReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetServiceLevelObjectiveBudgetReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetServiceLevelObjectiveBudgetReport.</param>
        /// 
        /// <returns>Returns a  BatchGetServiceLevelObjectiveBudgetReportResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/BatchGetServiceLevelObjectiveBudgetReport">REST API Reference for BatchGetServiceLevelObjectiveBudgetReport Operation</seealso>
        public virtual BatchGetServiceLevelObjectiveBudgetReportResponse EndBatchGetServiceLevelObjectiveBudgetReport(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetServiceLevelObjectiveBudgetReportResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchUpdateExclusionWindows

        /// <summary>
        /// Add or remove time window exclusions for one or more Service Level Objectives (SLOs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateExclusionWindows service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateExclusionWindows service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/BatchUpdateExclusionWindows">REST API Reference for BatchUpdateExclusionWindows Operation</seealso>
        public virtual BatchUpdateExclusionWindowsResponse BatchUpdateExclusionWindows(BatchUpdateExclusionWindowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateExclusionWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateExclusionWindowsResponseUnmarshaller.Instance;

            return Invoke<BatchUpdateExclusionWindowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateExclusionWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateExclusionWindows operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateExclusionWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/BatchUpdateExclusionWindows">REST API Reference for BatchUpdateExclusionWindows Operation</seealso>
        public virtual IAsyncResult BeginBatchUpdateExclusionWindows(BatchUpdateExclusionWindowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchUpdateExclusionWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchUpdateExclusionWindowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateExclusionWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateExclusionWindows.</param>
        /// 
        /// <returns>Returns a  BatchUpdateExclusionWindowsResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/BatchUpdateExclusionWindows">REST API Reference for BatchUpdateExclusionWindows Operation</seealso>
        public virtual BatchUpdateExclusionWindowsResponse EndBatchUpdateExclusionWindows(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchUpdateExclusionWindowsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServiceLevelObjective

        /// <summary>
        /// Creates a service level objective (SLO), which can help you ensure that your critical
        /// business operations are meeting customer expectations. Use SLOs to set and track specific
        /// target levels for the reliability and availability of your applications and services.
        /// SLOs use service level indicators (SLIs) to calculate whether the application is performing
        /// at the level that you want.
        /// 
        ///  
        /// <para>
        /// Create an SLO to set a target for a service or operation’s availability or latency.
        /// CloudWatch measures this target frequently you can find whether it has been breached.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The target performance quality that is defined for an SLO is the <i>attainment goal</i>.
        /// </para>
        ///  
        /// <para>
        /// You can set SLO targets for your applications that are discovered by Application Signals,
        /// using critical metrics such as latency and availability. You can also set SLOs against
        /// any CloudWatch metric or math expression that produces a time series.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't create an SLO for a service operation that was discovered by Application
        /// Signals until after that operation has reported standard metrics to Application Signals.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you create an SLO, you specify whether it is a <i>period-based SLO</i> or a <i>request-based
        /// SLO</i>. Each type of SLO has a different way of evaluating your application's performance
        /// against its attainment goal.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <i>period-based SLO</i> uses defined <i>periods</i> of time within a specified total
        /// time interval. For each period of time, Application Signals determines whether the
        /// application met its goal. The attainment rate is calculated as the <c>number of good
        /// periods/number of total periods</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, for a period-based SLO, meeting an attainment goal of 99.9% means that
        /// within your interval, your application must meet its performance goal during at least
        /// 99.9% of the time periods.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <i>request-based SLO</i> doesn't use pre-defined periods of time. Instead, the SLO
        /// measures <c>number of good requests/number of total requests</c> during the interval.
        /// At any time, you can find the ratio of good requests to total requests for the interval
        /// up to the time stamp that you specify, and measure that ratio against the goal set
        /// in your SLO.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you have created an SLO, you can retrieve error budget reports for it. An <i>error
        /// budget</i> is the amount of time or amount of requests that your application can be
        /// non-compliant with the SLO's goal, and still have your application meet the goal.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a period-based SLO, the error budget starts at a number defined by the highest
        /// number of periods that can fail to meet the threshold, while still meeting the overall
        /// goal. The <i>remaining error budget</i> decreases with every failed period that is
        /// recorded. The error budget within one interval can never increase.
        /// </para>
        ///  
        /// <para>
        /// For example, an SLO with a threshold that 99.95% of requests must be completed under
        /// 2000ms every month translates to an error budget of 21.9 minutes of downtime per month.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a request-based SLO, the remaining error budget is dynamic and can increase or
        /// decrease, depending on the ratio of good requests to total requests.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SLOs, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-ServiceLevelObjectives.html">
        /// Service level objectives (SLOs)</a>. 
        /// </para>
        ///  
        /// <para>
        /// When you perform a <c>CreateServiceLevelObjective</c> operation, Application Signals
        /// creates the <i>AWSServiceRoleForCloudWatchApplicationSignals</i> service-linked role,
        /// if it doesn't already exist in your account. This service- linked role has the following
        /// permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>xray:GetServiceGraph</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>logs:StartQuery</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>logs:GetQueryResults</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cloudwatch:GetMetricData</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cloudwatch:ListMetrics</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:GetResources</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>autoscaling:DescribeAutoScalingGroups</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLevelObjective service method.</param>
        /// 
        /// <returns>The response from the CreateServiceLevelObjective service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/CreateServiceLevelObjective">REST API Reference for CreateServiceLevelObjective Operation</seealso>
        public virtual CreateServiceLevelObjectiveResponse CreateServiceLevelObjective(CreateServiceLevelObjectiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceLevelObjectiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceLevelObjectiveResponseUnmarshaller.Instance;

            return Invoke<CreateServiceLevelObjectiveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLevelObjective operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceLevelObjective
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/CreateServiceLevelObjective">REST API Reference for CreateServiceLevelObjective Operation</seealso>
        public virtual IAsyncResult BeginCreateServiceLevelObjective(CreateServiceLevelObjectiveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateServiceLevelObjectiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceLevelObjectiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceLevelObjective.</param>
        /// 
        /// <returns>Returns a  CreateServiceLevelObjectiveResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/CreateServiceLevelObjective">REST API Reference for CreateServiceLevelObjective Operation</seealso>
        public virtual CreateServiceLevelObjectiveResponse EndCreateServiceLevelObjective(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceLevelObjectiveResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGroupingConfiguration

        /// <summary>
        /// Deletes a grouping configuration that defines how services are grouped and organized
        /// in Application Signals. Once deleted, services will no longer be grouped according
        /// to the specified configuration rules.
        /// 
        ///  
        /// <para>
        /// This operation is irreversible. After deletion, you must recreate the grouping configuration
        /// if you want to restore the same grouping behavior.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupingConfiguration service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/DeleteGroupingConfiguration">REST API Reference for DeleteGroupingConfiguration Operation</seealso>
        public virtual DeleteGroupingConfigurationResponse DeleteGroupingConfiguration(DeleteGroupingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGroupingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteGroupingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupingConfiguration operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/DeleteGroupingConfiguration">REST API Reference for DeleteGroupingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteGroupingConfiguration(DeleteGroupingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGroupingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGroupingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupingConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteGroupingConfigurationResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/DeleteGroupingConfiguration">REST API Reference for DeleteGroupingConfiguration Operation</seealso>
        public virtual DeleteGroupingConfigurationResponse EndDeleteGroupingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGroupingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServiceLevelObjective

        /// <summary>
        /// Deletes the specified service level objective.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLevelObjective service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceLevelObjective service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/DeleteServiceLevelObjective">REST API Reference for DeleteServiceLevelObjective Operation</seealso>
        public virtual DeleteServiceLevelObjectiveResponse DeleteServiceLevelObjective(DeleteServiceLevelObjectiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceLevelObjectiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceLevelObjectiveResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceLevelObjectiveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLevelObjective operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceLevelObjective
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/DeleteServiceLevelObjective">REST API Reference for DeleteServiceLevelObjective Operation</seealso>
        public virtual IAsyncResult BeginDeleteServiceLevelObjective(DeleteServiceLevelObjectiveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteServiceLevelObjectiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceLevelObjectiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceLevelObjective.</param>
        /// 
        /// <returns>Returns a  DeleteServiceLevelObjectiveResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/DeleteServiceLevelObjective">REST API Reference for DeleteServiceLevelObjective Operation</seealso>
        public virtual DeleteServiceLevelObjectiveResponse EndDeleteServiceLevelObjective(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceLevelObjectiveResponse>(asyncResult);
        }

        #endregion
        
        #region  GetService

        /// <summary>
        /// Returns information about a service discovered by Application Signals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse GetService(GetServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return Invoke<GetServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetService operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetService">REST API Reference for GetService Operation</seealso>
        public virtual IAsyncResult BeginGetService(GetServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetService.</param>
        /// 
        /// <returns>Returns a  GetServiceResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse EndGetService(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceLevelObjective

        /// <summary>
        /// Returns information about one SLO created in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLevelObjective service method.</param>
        /// 
        /// <returns>The response from the GetServiceLevelObjective service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetServiceLevelObjective">REST API Reference for GetServiceLevelObjective Operation</seealso>
        public virtual GetServiceLevelObjectiveResponse GetServiceLevelObjective(GetServiceLevelObjectiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceLevelObjectiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLevelObjectiveResponseUnmarshaller.Instance;

            return Invoke<GetServiceLevelObjectiveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLevelObjective operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceLevelObjective
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetServiceLevelObjective">REST API Reference for GetServiceLevelObjective Operation</seealso>
        public virtual IAsyncResult BeginGetServiceLevelObjective(GetServiceLevelObjectiveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetServiceLevelObjectiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceLevelObjectiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceLevelObjective.</param>
        /// 
        /// <returns>Returns a  GetServiceLevelObjectiveResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetServiceLevelObjective">REST API Reference for GetServiceLevelObjective Operation</seealso>
        public virtual GetServiceLevelObjectiveResponse EndGetServiceLevelObjective(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceLevelObjectiveResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAuditFindings

        /// <summary>
        /// Retrieves a list of audit findings for Application Signals resources. Audit findings
        /// identify potential issues, misconfigurations, or compliance violations in your observability
        /// setup.
        /// 
        ///  
        /// <para>
        /// You can filter findings by time range, auditor type, and target resources to focus
        /// on specific areas of concern. This operation supports pagination for large result
        /// sets.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditFindings service method.</param>
        /// 
        /// <returns>The response from the ListAuditFindings service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        public virtual ListAuditFindingsResponse ListAuditFindings(ListAuditFindingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAuditFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditFindingsResponseUnmarshaller.Instance;

            return Invoke<ListAuditFindingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuditFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuditFindings operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAuditFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        public virtual IAsyncResult BeginListAuditFindings(ListAuditFindingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAuditFindingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAuditFindingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAuditFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAuditFindings.</param>
        /// 
        /// <returns>Returns a  ListAuditFindingsResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        public virtual ListAuditFindingsResponse EndListAuditFindings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAuditFindingsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListGroupingAttributeDefinitions

        /// <summary>
        /// Retrieves the available grouping attribute definitions that can be used to create
        /// grouping configurations. These definitions specify the attributes and rules available
        /// for organizing services.
        /// 
        ///  
        /// <para>
        /// Use this operation to discover what grouping options are available before creating
        /// or updating grouping configurations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupingAttributeDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListGroupingAttributeDefinitions service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListGroupingAttributeDefinitions">REST API Reference for ListGroupingAttributeDefinitions Operation</seealso>
        public virtual ListGroupingAttributeDefinitionsResponse ListGroupingAttributeDefinitions(ListGroupingAttributeDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupingAttributeDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupingAttributeDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListGroupingAttributeDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupingAttributeDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupingAttributeDefinitions operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupingAttributeDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListGroupingAttributeDefinitions">REST API Reference for ListGroupingAttributeDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListGroupingAttributeDefinitions(ListGroupingAttributeDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGroupingAttributeDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGroupingAttributeDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupingAttributeDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupingAttributeDefinitions.</param>
        /// 
        /// <returns>Returns a  ListGroupingAttributeDefinitionsResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListGroupingAttributeDefinitions">REST API Reference for ListGroupingAttributeDefinitions Operation</seealso>
        public virtual ListGroupingAttributeDefinitionsResponse EndListGroupingAttributeDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListGroupingAttributeDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceDependencies

        /// <summary>
        /// Returns a list of service dependencies of the service that you specify. A dependency
        /// is an infrastructure component that an operation of this service connects with. Dependencies
        /// can include Amazon Web Services services, Amazon Web Services resources, and third-party
        /// services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceDependencies service method.</param>
        /// 
        /// <returns>The response from the ListServiceDependencies service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependencies">REST API Reference for ListServiceDependencies Operation</seealso>
        public virtual ListServiceDependenciesResponse ListServiceDependencies(ListServiceDependenciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceDependenciesResponseUnmarshaller.Instance;

            return Invoke<ListServiceDependenciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceDependencies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceDependencies operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceDependencies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependencies">REST API Reference for ListServiceDependencies Operation</seealso>
        public virtual IAsyncResult BeginListServiceDependencies(ListServiceDependenciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceDependenciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceDependenciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceDependencies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceDependencies.</param>
        /// 
        /// <returns>Returns a  ListServiceDependenciesResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependencies">REST API Reference for ListServiceDependencies Operation</seealso>
        public virtual ListServiceDependenciesResponse EndListServiceDependencies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceDependenciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceDependents

        /// <summary>
        /// Returns the list of dependents that invoked the specified service during the provided
        /// time range. Dependents include other services, CloudWatch Synthetics canaries, and
        /// clients that are instrumented with CloudWatch RUM app monitors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceDependents service method.</param>
        /// 
        /// <returns>The response from the ListServiceDependents service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependents">REST API Reference for ListServiceDependents Operation</seealso>
        public virtual ListServiceDependentsResponse ListServiceDependents(ListServiceDependentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceDependentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceDependentsResponseUnmarshaller.Instance;

            return Invoke<ListServiceDependentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceDependents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceDependents operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceDependents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependents">REST API Reference for ListServiceDependents Operation</seealso>
        public virtual IAsyncResult BeginListServiceDependents(ListServiceDependentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceDependentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceDependentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceDependents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceDependents.</param>
        /// 
        /// <returns>Returns a  ListServiceDependentsResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependents">REST API Reference for ListServiceDependents Operation</seealso>
        public virtual ListServiceDependentsResponse EndListServiceDependents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceDependentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceLevelObjectiveExclusionWindows

        /// <summary>
        /// Retrieves all exclusion windows configured for a specific SLO.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceLevelObjectiveExclusionWindows service method.</param>
        /// 
        /// <returns>The response from the ListServiceLevelObjectiveExclusionWindows service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceLevelObjectiveExclusionWindows">REST API Reference for ListServiceLevelObjectiveExclusionWindows Operation</seealso>
        public virtual ListServiceLevelObjectiveExclusionWindowsResponse ListServiceLevelObjectiveExclusionWindows(ListServiceLevelObjectiveExclusionWindowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceLevelObjectiveExclusionWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceLevelObjectiveExclusionWindowsResponseUnmarshaller.Instance;

            return Invoke<ListServiceLevelObjectiveExclusionWindowsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceLevelObjectiveExclusionWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceLevelObjectiveExclusionWindows operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceLevelObjectiveExclusionWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceLevelObjectiveExclusionWindows">REST API Reference for ListServiceLevelObjectiveExclusionWindows Operation</seealso>
        public virtual IAsyncResult BeginListServiceLevelObjectiveExclusionWindows(ListServiceLevelObjectiveExclusionWindowsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceLevelObjectiveExclusionWindowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceLevelObjectiveExclusionWindowsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceLevelObjectiveExclusionWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceLevelObjectiveExclusionWindows.</param>
        /// 
        /// <returns>Returns a  ListServiceLevelObjectiveExclusionWindowsResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceLevelObjectiveExclusionWindows">REST API Reference for ListServiceLevelObjectiveExclusionWindows Operation</seealso>
        public virtual ListServiceLevelObjectiveExclusionWindowsResponse EndListServiceLevelObjectiveExclusionWindows(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceLevelObjectiveExclusionWindowsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceLevelObjectives

        /// <summary>
        /// Returns a list of SLOs created in this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceLevelObjectives service method.</param>
        /// 
        /// <returns>The response from the ListServiceLevelObjectives service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceLevelObjectives">REST API Reference for ListServiceLevelObjectives Operation</seealso>
        public virtual ListServiceLevelObjectivesResponse ListServiceLevelObjectives(ListServiceLevelObjectivesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceLevelObjectivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceLevelObjectivesResponseUnmarshaller.Instance;

            return Invoke<ListServiceLevelObjectivesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceLevelObjectives operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceLevelObjectives operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceLevelObjectives
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceLevelObjectives">REST API Reference for ListServiceLevelObjectives Operation</seealso>
        public virtual IAsyncResult BeginListServiceLevelObjectives(ListServiceLevelObjectivesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceLevelObjectivesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceLevelObjectivesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceLevelObjectives operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceLevelObjectives.</param>
        /// 
        /// <returns>Returns a  ListServiceLevelObjectivesResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceLevelObjectives">REST API Reference for ListServiceLevelObjectives Operation</seealso>
        public virtual ListServiceLevelObjectivesResponse EndListServiceLevelObjectives(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceLevelObjectivesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceOperations

        /// <summary>
        /// Returns a list of the <i>operations</i> of this service that have been discovered
        /// by Application Signals. Only the operations that were invoked during the specified
        /// time range are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceOperations service method.</param>
        /// 
        /// <returns>The response from the ListServiceOperations service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceOperations">REST API Reference for ListServiceOperations Operation</seealso>
        public virtual ListServiceOperationsResponse ListServiceOperations(ListServiceOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceOperationsResponseUnmarshaller.Instance;

            return Invoke<ListServiceOperationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceOperations operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceOperations">REST API Reference for ListServiceOperations Operation</seealso>
        public virtual IAsyncResult BeginListServiceOperations(ListServiceOperationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceOperationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceOperations.</param>
        /// 
        /// <returns>Returns a  ListServiceOperationsResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceOperations">REST API Reference for ListServiceOperations Operation</seealso>
        public virtual ListServiceOperationsResponse EndListServiceOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServices

        /// <summary>
        /// Returns a list of services that have been discovered by Application Signals. A service
        /// represents a minimum logical and transactional unit that completes a business function.
        /// Services are discovered through Application Signals instrumentation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse EndListServices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceStates

        /// <summary>
        /// Retrieves the current state information for services monitored by Application Signals.
        /// Service states include health status, recent change events, and other operational
        /// metadata.
        /// 
        ///  
        /// <para>
        /// You can filter results by time range, AWS account, and service attributes to focus
        /// on specific services or time periods. This operation supports pagination and can include
        /// data from linked accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceStates service method.</param>
        /// 
        /// <returns>The response from the ListServiceStates service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceStates">REST API Reference for ListServiceStates Operation</seealso>
        public virtual ListServiceStatesResponse ListServiceStates(ListServiceStatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceStatesResponseUnmarshaller.Instance;

            return Invoke<ListServiceStatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceStates operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceStates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceStates">REST API Reference for ListServiceStates Operation</seealso>
        public virtual IAsyncResult BeginListServiceStates(ListServiceStatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListServiceStatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceStatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceStates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceStates.</param>
        /// 
        /// <returns>Returns a  ListServiceStatesResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceStates">REST API Reference for ListServiceStates Operation</seealso>
        public virtual ListServiceStatesResponse EndListServiceStates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceStatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Displays the tags associated with a CloudWatch resource. Tags can be assigned to service
        /// level objectives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutGroupingConfiguration

        /// <summary>
        /// Creates or updates a grouping configuration that defines how services are organized
        /// and grouped in Application Signals dashboards and service maps.
        /// 
        ///  
        /// <para>
        /// Grouping configurations allow you to logically organize services based on attributes
        /// such as environment, team ownership, or business function, making it easier to monitor
        /// and manage related services together.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutGroupingConfiguration service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/PutGroupingConfiguration">REST API Reference for PutGroupingConfiguration Operation</seealso>
        public virtual PutGroupingConfigurationResponse PutGroupingConfiguration(PutGroupingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutGroupingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupingConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutGroupingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupingConfiguration operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGroupingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/PutGroupingConfiguration">REST API Reference for PutGroupingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutGroupingConfiguration(PutGroupingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutGroupingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutGroupingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutGroupingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroupingConfiguration.</param>
        /// 
        /// <returns>Returns a  PutGroupingConfigurationResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/PutGroupingConfiguration">REST API Reference for PutGroupingConfiguration Operation</seealso>
        public virtual PutGroupingConfigurationResponse EndPutGroupingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutGroupingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDiscovery

        /// <summary>
        /// Enables this Amazon Web Services account to be able to use CloudWatch Application
        /// Signals by creating the <i>AWSServiceRoleForCloudWatchApplicationSignals</i> service-linked
        /// role. This service- linked role has the following permissions:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>xray:GetServiceGraph</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>logs:StartQuery</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>logs:GetQueryResults</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cloudwatch:GetMetricData</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cloudwatch:ListMetrics</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:GetResources</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>autoscaling:DescribeAutoScalingGroups</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After completing this step, you still need to instrument your Java and Python applications
        /// to send data to Application Signals. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Application-Signals-Enable.html">
        /// Enabling Application Signals</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscovery service method.</param>
        /// 
        /// <returns>The response from the StartDiscovery service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/StartDiscovery">REST API Reference for StartDiscovery Operation</seealso>
        public virtual StartDiscoveryResponse StartDiscovery(StartDiscoveryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscoveryResponseUnmarshaller.Instance;

            return Invoke<StartDiscoveryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDiscovery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDiscovery operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDiscovery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/StartDiscovery">REST API Reference for StartDiscovery Operation</seealso>
        public virtual IAsyncResult BeginStartDiscovery(StartDiscoveryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDiscoveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDiscoveryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDiscovery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDiscovery.</param>
        /// 
        /// <returns>Returns a  StartDiscoveryResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/StartDiscovery">REST API Reference for StartDiscovery Operation</seealso>
        public virtual StartDiscoveryResponse EndStartDiscovery(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDiscoveryResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch resource, such
        /// as a service level objective.
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
        /// You can use the <c>TagResource</c> action with an alarm that already has tags. If
        /// you specify a new tag key for the alarm, this tag is appended to the list of tags
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
        /// <returns>The response from the TagResource service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the UntagResource service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceLevelObjective

        /// <summary>
        /// Updates an existing service level objective (SLO). If you omit parameters, the previous
        /// values of those parameters are retained. 
        /// 
        ///  
        /// <para>
        /// You cannot change from a period-based SLO to a request-based SLO, or change from a
        /// request-based SLO to a period-based SLO.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceLevelObjective service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceLevelObjective service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UpdateServiceLevelObjective">REST API Reference for UpdateServiceLevelObjective Operation</seealso>
        public virtual UpdateServiceLevelObjectiveResponse UpdateServiceLevelObjective(UpdateServiceLevelObjectiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceLevelObjectiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceLevelObjectiveResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceLevelObjectiveResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceLevelObjective operation on AmazonApplicationSignalsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceLevelObjective
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UpdateServiceLevelObjective">REST API Reference for UpdateServiceLevelObjective Operation</seealso>
        public virtual IAsyncResult BeginUpdateServiceLevelObjective(UpdateServiceLevelObjectiveRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateServiceLevelObjectiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceLevelObjectiveResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceLevelObjective.</param>
        /// 
        /// <returns>Returns a  UpdateServiceLevelObjectiveResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UpdateServiceLevelObjective">REST API Reference for UpdateServiceLevelObjective Operation</seealso>
        public virtual UpdateServiceLevelObjectiveResponse EndUpdateServiceLevelObjective(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceLevelObjectiveResponse>(asyncResult);
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
            var resolver = new AmazonApplicationSignalsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}