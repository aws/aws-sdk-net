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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CostExplorer.Model;
using Amazon.CostExplorer.Model.Internal.MarshallTransformations;
using Amazon.CostExplorer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.CostExplorer
{
    /// <summary>
    /// <para>Implementation for accessing CostExplorer</para>
    ///
    /// You can use the Cost Explorer API to programmatically query your cost and usage data.
    /// You can query for aggregated data such as total monthly costs or total daily usage.
    /// You can also query for granular data. This might include the number of daily write
    /// operations for Amazon DynamoDB database tables in your production environment. 
    /// 
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// The Cost Explorer API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>https://ce.us-east-1.amazonaws.com</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about the costs that are associated with the Cost Explorer API, see
    /// <a href="http://aws.amazon.com/aws-cost-management/pricing/">Amazon Web Services Cost
    /// Management Pricing</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCostExplorerClient : AmazonServiceClient, IAmazonCostExplorer
    {
        private static IServiceMetadata serviceMetadata = new AmazonCostExplorerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonCostExplorerClient with the credentials loaded from the application's
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
        public AmazonCostExplorerClient()
            : base(new AmazonCostExplorerConfig()) { }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with the credentials loaded from the application's
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
        public AmazonCostExplorerClient(RegionEndpoint region)
            : base(new AmazonCostExplorerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCostExplorerClient Configuration Object</param>
        public AmazonCostExplorerClient(AmazonCostExplorerConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCostExplorerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCostExplorerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostExplorerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCostExplorerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Credentials and an
        /// AmazonCostExplorerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCostExplorerClient Configuration Object</param>
        public AmazonCostExplorerClient(AWSCredentials credentials, AmazonCostExplorerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostExplorerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostExplorerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostExplorerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCostExplorerClient Configuration Object</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCostExplorerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostExplorerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostExplorerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostExplorerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCostExplorerClient Configuration Object</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCostExplorerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ICostExplorerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICostExplorerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CostExplorerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCostExplorerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCostExplorerAuthSchemeHandler());
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


        #region  CreateAnomalyMonitor

        internal virtual CreateAnomalyMonitorResponse CreateAnomalyMonitor(CreateAnomalyMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnomalyMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnomalyMonitorResponseUnmarshaller.Instance;

            return Invoke<CreateAnomalyMonitorResponse>(request, options);
        }



        /// <summary>
        /// Creates a new cost anomaly detection monitor with the requested type and monitor specification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnomalyMonitor service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateAnomalyMonitor">REST API Reference for CreateAnomalyMonitor Operation</seealso>
        public virtual Task<CreateAnomalyMonitorResponse> CreateAnomalyMonitorAsync(CreateAnomalyMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnomalyMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnomalyMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnomalyMonitorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateAnomalySubscription

        internal virtual CreateAnomalySubscriptionResponse CreateAnomalySubscription(CreateAnomalySubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnomalySubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnomalySubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateAnomalySubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Adds an alert subscription to a cost anomaly detection monitor. You can use each subscription
        /// to define subscribers with email or SNS notifications. Email subscribers can set an
        /// absolute or percentage threshold and a time frequency for receiving notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalySubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnomalySubscription service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownMonitorException">
        /// The cost anomaly monitor does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateAnomalySubscription">REST API Reference for CreateAnomalySubscription Operation</seealso>
        public virtual Task<CreateAnomalySubscriptionResponse> CreateAnomalySubscriptionAsync(CreateAnomalySubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAnomalySubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAnomalySubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAnomalySubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCostCategoryDefinition

        internal virtual CreateCostCategoryDefinitionResponse CreateCostCategoryDefinition(CreateCostCategoryDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCostCategoryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCostCategoryDefinitionResponseUnmarshaller.Instance;

            return Invoke<CreateCostCategoryDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Cost Category with the requested name and rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCostCategoryDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCostCategoryDefinition service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of resources you can create, or exceeded the
        /// size of an individual resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateCostCategoryDefinition">REST API Reference for CreateCostCategoryDefinition Operation</seealso>
        public virtual Task<CreateCostCategoryDefinitionResponse> CreateCostCategoryDefinitionAsync(CreateCostCategoryDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCostCategoryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCostCategoryDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCostCategoryDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnomalyMonitor

        internal virtual DeleteAnomalyMonitorResponse DeleteAnomalyMonitor(DeleteAnomalyMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnomalyMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalyMonitorResponseUnmarshaller.Instance;

            return Invoke<DeleteAnomalyMonitorResponse>(request, options);
        }



        /// <summary>
        /// Deletes a cost anomaly monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnomalyMonitor service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownMonitorException">
        /// The cost anomaly monitor does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteAnomalyMonitor">REST API Reference for DeleteAnomalyMonitor Operation</seealso>
        public virtual Task<DeleteAnomalyMonitorResponse> DeleteAnomalyMonitorAsync(DeleteAnomalyMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnomalyMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalyMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnomalyMonitorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAnomalySubscription

        internal virtual DeleteAnomalySubscriptionResponse DeleteAnomalySubscription(DeleteAnomalySubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnomalySubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalySubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteAnomalySubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a cost anomaly subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalySubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnomalySubscription service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownSubscriptionException">
        /// The cost anomaly subscription does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteAnomalySubscription">REST API Reference for DeleteAnomalySubscription Operation</seealso>
        public virtual Task<DeleteAnomalySubscriptionResponse> DeleteAnomalySubscriptionAsync(DeleteAnomalySubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAnomalySubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAnomalySubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAnomalySubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCostCategoryDefinition

        internal virtual DeleteCostCategoryDefinitionResponse DeleteCostCategoryDefinition(DeleteCostCategoryDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCostCategoryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCostCategoryDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteCostCategoryDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Cost Category. Expenses from this month going forward will no longer be
        /// categorized with this Cost Category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCostCategoryDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCostCategoryDefinition service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteCostCategoryDefinition">REST API Reference for DeleteCostCategoryDefinition Operation</seealso>
        public virtual Task<DeleteCostCategoryDefinitionResponse> DeleteCostCategoryDefinitionAsync(DeleteCostCategoryDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCostCategoryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCostCategoryDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCostCategoryDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCostCategoryDefinition

        internal virtual DescribeCostCategoryDefinitionResponse DescribeCostCategoryDefinition(DescribeCostCategoryDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCostCategoryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCostCategoryDefinitionResponseUnmarshaller.Instance;

            return Invoke<DescribeCostCategoryDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Returns the name, Amazon Resource Name (ARN), rules, definition, and effective dates
        /// of a Cost Category that's defined in the account.
        /// 
        ///  
        /// <para>
        /// You have the option to use <c>EffectiveOn</c> to return a Cost Category that's active
        /// on a specific date. If there's no <c>EffectiveOn</c> specified, you see a Cost Category
        /// that's effective on the current date. If Cost Category is still effective, <c>EffectiveEnd</c>
        /// is omitted in the response. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCostCategoryDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCostCategoryDefinition service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DescribeCostCategoryDefinition">REST API Reference for DescribeCostCategoryDefinition Operation</seealso>
        public virtual Task<DescribeCostCategoryDefinitionResponse> DescribeCostCategoryDefinitionAsync(DescribeCostCategoryDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCostCategoryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCostCategoryDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCostCategoryDefinitionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnomalies

        internal virtual GetAnomaliesResponse GetAnomalies(GetAnomaliesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnomaliesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomaliesResponseUnmarshaller.Instance;

            return Invoke<GetAnomaliesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all of the cost anomalies detected on your account during the time period
        /// that's specified by the <c>DateInterval</c> object. Anomalies are available for up
        /// to 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnomalies service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalies">REST API Reference for GetAnomalies Operation</seealso>
        public virtual Task<GetAnomaliesResponse> GetAnomaliesAsync(GetAnomaliesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnomaliesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomaliesResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnomaliesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnomalyMonitors

        internal virtual GetAnomalyMonitorsResponse GetAnomalyMonitors(GetAnomalyMonitorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnomalyMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomalyMonitorsResponseUnmarshaller.Instance;

            return Invoke<GetAnomalyMonitorsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the cost anomaly monitor definitions for your account. You can filter using
        /// a list of cost anomaly monitor Amazon Resource Names (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnomalyMonitors service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownMonitorException">
        /// The cost anomaly monitor does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalyMonitors">REST API Reference for GetAnomalyMonitors Operation</seealso>
        public virtual Task<GetAnomalyMonitorsResponse> GetAnomalyMonitorsAsync(GetAnomalyMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnomalyMonitorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomalyMonitorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnomalyMonitorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnomalySubscriptions

        internal virtual GetAnomalySubscriptionsResponse GetAnomalySubscriptions(GetAnomalySubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnomalySubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomalySubscriptionsResponseUnmarshaller.Instance;

            return Invoke<GetAnomalySubscriptionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the cost anomaly subscription objects for your account. You can filter using
        /// a list of cost anomaly monitor Amazon Resource Names (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalySubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnomalySubscriptions service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownSubscriptionException">
        /// The cost anomaly subscription does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalySubscriptions">REST API Reference for GetAnomalySubscriptions Operation</seealso>
        public virtual Task<GetAnomalySubscriptionsResponse> GetAnomalySubscriptionsAsync(GetAnomalySubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAnomalySubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnomalySubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnomalySubscriptionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApproximateUsageRecords

        internal virtual GetApproximateUsageRecordsResponse GetApproximateUsageRecords(GetApproximateUsageRecordsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApproximateUsageRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApproximateUsageRecordsResponseUnmarshaller.Instance;

            return Invoke<GetApproximateUsageRecordsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves estimated usage records for hourly granularity or resource-level data at
        /// daily granularity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApproximateUsageRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApproximateUsageRecords service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetApproximateUsageRecords">REST API Reference for GetApproximateUsageRecords Operation</seealso>
        public virtual Task<GetApproximateUsageRecordsResponse> GetApproximateUsageRecordsAsync(GetApproximateUsageRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetApproximateUsageRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApproximateUsageRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<GetApproximateUsageRecordsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCommitmentPurchaseAnalysis

        internal virtual GetCommitmentPurchaseAnalysisResponse GetCommitmentPurchaseAnalysis(GetCommitmentPurchaseAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommitmentPurchaseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommitmentPurchaseAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetCommitmentPurchaseAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a commitment purchase analysis result based on the <c>AnalysisId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommitmentPurchaseAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCommitmentPurchaseAnalysis service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.AnalysisNotFoundException">
        /// The requested analysis can't be found.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCommitmentPurchaseAnalysis">REST API Reference for GetCommitmentPurchaseAnalysis Operation</seealso>
        public virtual Task<GetCommitmentPurchaseAnalysisResponse> GetCommitmentPurchaseAnalysisAsync(GetCommitmentPurchaseAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCommitmentPurchaseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCommitmentPurchaseAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<GetCommitmentPurchaseAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCostAndUsage

        internal virtual GetCostAndUsageResponse GetCostAndUsage(GetCostAndUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostAndUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostAndUsageResponseUnmarshaller.Instance;

            return Invoke<GetCostAndUsageResponse>(request, options);
        }



        /// <summary>
        /// Retrieves cost and usage metrics for your account. You can specify which cost and
        /// usage-related metric that you want the request to return. For example, you can specify
        /// <c>BlendedCosts</c> or <c>UsageQuantity</c>. You can also filter and group your data
        /// by various dimensions, such as <c>SERVICE</c> or <c>AZ</c>, in a specific time range.
        /// For a complete list of valid dimensions, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_GetDimensionValues.html">GetDimensionValues</a>
        /// operation. Management account in an organization in Organizations have access to all
        /// member accounts.
        /// 
        ///  
        /// <para>
        /// For information about filter limitations, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/billing-limits.html">Quotas
        /// and restrictions</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostAndUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostAndUsage service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BillExpirationException">
        /// The requested report expired. Update the date interval and try again.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.RequestChangedException">
        /// Your request parameters changed between pages. Try again with the old parameters or
        /// without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsage">REST API Reference for GetCostAndUsage Operation</seealso>
        public virtual Task<GetCostAndUsageResponse> GetCostAndUsageAsync(GetCostAndUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostAndUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostAndUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostAndUsageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCostAndUsageComparisons

        internal virtual GetCostAndUsageComparisonsResponse GetCostAndUsageComparisons(GetCostAndUsageComparisonsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostAndUsageComparisonsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostAndUsageComparisonsResponseUnmarshaller.Instance;

            return Invoke<GetCostAndUsageComparisonsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves cost and usage comparisons for your account between two periods within the
        /// last 13 months. If you have enabled multi-year data at monthly granularity, you can
        /// go back up to 38 months.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostAndUsageComparisons service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostAndUsageComparisons service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsageComparisons">REST API Reference for GetCostAndUsageComparisons Operation</seealso>
        public virtual Task<GetCostAndUsageComparisonsResponse> GetCostAndUsageComparisonsAsync(GetCostAndUsageComparisonsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostAndUsageComparisonsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostAndUsageComparisonsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostAndUsageComparisonsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCostAndUsageWithResources

        internal virtual GetCostAndUsageWithResourcesResponse GetCostAndUsageWithResources(GetCostAndUsageWithResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostAndUsageWithResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostAndUsageWithResourcesResponseUnmarshaller.Instance;

            return Invoke<GetCostAndUsageWithResourcesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves cost and usage metrics with resources for your account. You can specify
        /// which cost and usage-related metric, such as <c>BlendedCosts</c> or <c>UsageQuantity</c>,
        /// that you want the request to return. You can also filter and group your data by various
        /// dimensions, such as <c>SERVICE</c> or <c>AZ</c>, in a specific time range. For a complete
        /// list of valid dimensions, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_GetDimensionValues.html">GetDimensionValues</a>
        /// operation. Management account in an organization in Organizations have access to all
        /// member accounts.
        /// 
        ///  
        /// <para>
        /// Hourly granularity is only available for EC2-Instances (Elastic Compute Cloud) resource-level
        /// data. All other resource-level data is available at daily granularity.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is an opt-in only feature. You can enable this feature from the Cost Explorer
        /// Settings page. For information about how to access the Settings page, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/ce-access.html">Controlling
        /// Access for Cost Explorer</a> in the <i>Billing and Cost Management User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostAndUsageWithResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostAndUsageWithResources service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BillExpirationException">
        /// The requested report expired. Update the date interval and try again.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.RequestChangedException">
        /// Your request parameters changed between pages. Try again with the old parameters or
        /// without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsageWithResources">REST API Reference for GetCostAndUsageWithResources Operation</seealso>
        public virtual Task<GetCostAndUsageWithResourcesResponse> GetCostAndUsageWithResourcesAsync(GetCostAndUsageWithResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostAndUsageWithResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostAndUsageWithResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostAndUsageWithResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCostCategories

        internal virtual GetCostCategoriesResponse GetCostCategories(GetCostCategoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostCategoriesResponseUnmarshaller.Instance;

            return Invoke<GetCostCategoriesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves an array of Cost Category names and values incurred cost.
        /// 
        ///  <note> 
        /// <para>
        /// If some Cost Category names and values are not associated with any cost, they will
        /// not be returned by this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostCategories service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BillExpirationException">
        /// The requested report expired. Update the date interval and try again.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.RequestChangedException">
        /// Your request parameters changed between pages. Try again with the old parameters or
        /// without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostCategories">REST API Reference for GetCostCategories Operation</seealso>
        public virtual Task<GetCostCategoriesResponse> GetCostCategoriesAsync(GetCostCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostCategoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostCategoriesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCostComparisonDrivers

        internal virtual GetCostComparisonDriversResponse GetCostComparisonDrivers(GetCostComparisonDriversRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostComparisonDriversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostComparisonDriversResponseUnmarshaller.Instance;

            return Invoke<GetCostComparisonDriversResponse>(request, options);
        }



        /// <summary>
        /// Retrieves key factors driving cost changes between two time periods within the last
        /// 13 months, such as usage changes, discount changes, and commitment-based savings.
        /// If you have enabled multi-year data at monthly granularity, you can go back up to
        /// 38 months.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostComparisonDrivers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostComparisonDrivers service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostComparisonDrivers">REST API Reference for GetCostComparisonDrivers Operation</seealso>
        public virtual Task<GetCostComparisonDriversResponse> GetCostComparisonDriversAsync(GetCostComparisonDriversRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostComparisonDriversRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostComparisonDriversResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostComparisonDriversResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCostForecast

        internal virtual GetCostForecastResponse GetCostForecast(GetCostForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostForecastResponseUnmarshaller.Instance;

            return Invoke<GetCostForecastResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a forecast for how much Amazon Web Services predicts that you will spend
        /// over the forecast time period that you select, based on your past costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostForecast service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostForecast">REST API Reference for GetCostForecast Operation</seealso>
        public virtual Task<GetCostForecastResponse> GetCostForecastAsync(GetCostForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostForecastResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostForecastResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDimensionValues

        internal virtual GetDimensionValuesResponse GetDimensionValues(GetDimensionValuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDimensionValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDimensionValuesResponseUnmarshaller.Instance;

            return Invoke<GetDimensionValuesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all available filter values for a specified filter over a period of time.
        /// You can search the dimension values for an arbitrary string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDimensionValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDimensionValues service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BillExpirationException">
        /// The requested report expired. Update the date interval and try again.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.RequestChangedException">
        /// Your request parameters changed between pages. Try again with the old parameters or
        /// without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetDimensionValues">REST API Reference for GetDimensionValues Operation</seealso>
        public virtual Task<GetDimensionValuesResponse> GetDimensionValuesAsync(GetDimensionValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDimensionValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDimensionValuesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDimensionValuesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReservationCoverage

        internal virtual GetReservationCoverageResponse GetReservationCoverage(GetReservationCoverageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationCoverageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationCoverageResponseUnmarshaller.Instance;

            return Invoke<GetReservationCoverageResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the reservation coverage for your account, which you can use to see how
        /// much of your Amazon Elastic Compute Cloud, Amazon ElastiCache, Amazon Relational Database
        /// Service, or Amazon Redshift usage is covered by a reservation. An organization's management
        /// account can see the coverage of the associated member accounts. This supports dimensions,
        /// Cost Categories, and nested expressions. For any time period, you can filter data
        /// about reservation usage by the following dimensions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AZ
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CACHE_ENGINE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DATABASE_ENGINE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DEPLOYMENT_OPTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_TYPE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LINKED_ACCOUNT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPERATING_SYSTEM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TENANCY
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To determine valid values for a dimension, use the <c>GetDimensionValues</c> operation.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservationCoverage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservationCoverage service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationCoverage">REST API Reference for GetReservationCoverage Operation</seealso>
        public virtual Task<GetReservationCoverageResponse> GetReservationCoverageAsync(GetReservationCoverageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationCoverageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationCoverageResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservationCoverageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReservationPurchaseRecommendation

        internal virtual GetReservationPurchaseRecommendationResponse GetReservationPurchaseRecommendation(GetReservationPurchaseRecommendationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationPurchaseRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationPurchaseRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetReservationPurchaseRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Gets recommendations for reservation purchases. These recommendations might help you
        /// to reduce your costs. Reservations provide a discounted hourly rate (up to 75%) compared
        /// to On-Demand pricing.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services generates your recommendations by identifying your On-Demand usage
        /// during a specific time period and collecting your usage into categories that are eligible
        /// for a reservation. After Amazon Web Services has these categories, it simulates every
        /// combination of reservations in each category of usage to identify the best number
        /// of each type of Reserved Instance (RI) to purchase to maximize your estimated savings.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For example, Amazon Web Services automatically aggregates your Amazon EC2 Linux, shared
        /// tenancy, and c4 family usage in the US West (Oregon) Region and recommends that you
        /// buy size-flexible regional reservations to apply to the c4 family usage. Amazon Web
        /// Services recommends the smallest size instance in an instance family. This makes it
        /// easier to purchase a size-flexible Reserved Instance (RI). Amazon Web Services also
        /// shows the equal number of normalized units. This way, you can purchase any instance
        /// size that you want. For this example, your RI recommendation is for <c>c4.large</c>
        /// because that is the smallest size instance in the c4 instance family.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservationPurchaseRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservationPurchaseRecommendation service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationPurchaseRecommendation">REST API Reference for GetReservationPurchaseRecommendation Operation</seealso>
        public virtual Task<GetReservationPurchaseRecommendationResponse> GetReservationPurchaseRecommendationAsync(GetReservationPurchaseRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationPurchaseRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationPurchaseRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservationPurchaseRecommendationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetReservationUtilization

        internal virtual GetReservationUtilizationResponse GetReservationUtilization(GetReservationUtilizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationUtilizationResponseUnmarshaller.Instance;

            return Invoke<GetReservationUtilizationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the reservation utilization for your account. Management account in an organization
        /// have access to member accounts. You can filter data by dimensions in a time period.
        /// You can use <c>GetDimensionValues</c> to determine the possible dimension values.
        /// Currently, you can group only by <c>SUBSCRIPTION_ID</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservationUtilization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservationUtilization service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationUtilization">REST API Reference for GetReservationUtilization Operation</seealso>
        public virtual Task<GetReservationUtilizationResponse> GetReservationUtilizationAsync(GetReservationUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservationUtilizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRightsizingRecommendation

        internal virtual GetRightsizingRecommendationResponse GetRightsizingRecommendation(GetRightsizingRecommendationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRightsizingRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRightsizingRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetRightsizingRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Creates recommendations that help you save cost by identifying idle and underutilized
        /// Amazon EC2 instances.
        /// 
        ///  
        /// <para>
        /// Recommendations are generated to either downsize or terminate instances, along with
        /// providing savings detail and metrics. For more information about calculation and function,
        /// see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/ce-rightsizing.html">Optimizing
        /// Your Cost with Rightsizing Recommendations</a> in the <i>Billing and Cost Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRightsizingRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRightsizingRecommendation service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetRightsizingRecommendation">REST API Reference for GetRightsizingRecommendation Operation</seealso>
        public virtual Task<GetRightsizingRecommendationResponse> GetRightsizingRecommendationAsync(GetRightsizingRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRightsizingRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRightsizingRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<GetRightsizingRecommendationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSavingsPlanPurchaseRecommendationDetails

        internal virtual GetSavingsPlanPurchaseRecommendationDetailsResponse GetSavingsPlanPurchaseRecommendationDetails(GetSavingsPlanPurchaseRecommendationDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlanPurchaseRecommendationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlanPurchaseRecommendationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetSavingsPlanPurchaseRecommendationDetailsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the details for a Savings Plan recommendation. These details include the
        /// hourly data-points that construct the cost, coverage, and utilization charts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlanPurchaseRecommendationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSavingsPlanPurchaseRecommendationDetails service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlanPurchaseRecommendationDetails">REST API Reference for GetSavingsPlanPurchaseRecommendationDetails Operation</seealso>
        public virtual Task<GetSavingsPlanPurchaseRecommendationDetailsResponse> GetSavingsPlanPurchaseRecommendationDetailsAsync(GetSavingsPlanPurchaseRecommendationDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlanPurchaseRecommendationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlanPurchaseRecommendationDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSavingsPlanPurchaseRecommendationDetailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSavingsPlansCoverage

        internal virtual GetSavingsPlansCoverageResponse GetSavingsPlansCoverage(GetSavingsPlansCoverageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlansCoverageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlansCoverageResponseUnmarshaller.Instance;

            return Invoke<GetSavingsPlansCoverageResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the Savings Plans covered for your account. This enables you to see how
        /// much of your cost is covered by a Savings Plan. An organization’s management account
        /// can see the coverage of the associated member accounts. This supports dimensions,
        /// Cost Categories, and nested expressions. For any time period, you can filter data
        /// for Savings Plans usage with the following dimensions:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>LINKED_ACCOUNT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE_FAMILY</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To determine valid values for a dimension, use the <c>GetDimensionValues</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansCoverage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSavingsPlansCoverage service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansCoverage">REST API Reference for GetSavingsPlansCoverage Operation</seealso>
        public virtual Task<GetSavingsPlansCoverageResponse> GetSavingsPlansCoverageAsync(GetSavingsPlansCoverageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlansCoverageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlansCoverageResponseUnmarshaller.Instance;

            return InvokeAsync<GetSavingsPlansCoverageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSavingsPlansPurchaseRecommendation

        internal virtual GetSavingsPlansPurchaseRecommendationResponse GetSavingsPlansPurchaseRecommendation(GetSavingsPlansPurchaseRecommendationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlansPurchaseRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlansPurchaseRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetSavingsPlansPurchaseRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the Savings Plans recommendations for your account. First use <c>StartSavingsPlansPurchaseRecommendationGeneration</c>
        /// to generate a new set of recommendations, and then use <c>GetSavingsPlansPurchaseRecommendation</c>
        /// to retrieve them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansPurchaseRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSavingsPlansPurchaseRecommendation service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansPurchaseRecommendation">REST API Reference for GetSavingsPlansPurchaseRecommendation Operation</seealso>
        public virtual Task<GetSavingsPlansPurchaseRecommendationResponse> GetSavingsPlansPurchaseRecommendationAsync(GetSavingsPlansPurchaseRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlansPurchaseRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlansPurchaseRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSavingsPlansPurchaseRecommendationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSavingsPlansUtilization

        internal virtual GetSavingsPlansUtilizationResponse GetSavingsPlansUtilization(GetSavingsPlansUtilizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlansUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlansUtilizationResponseUnmarshaller.Instance;

            return Invoke<GetSavingsPlansUtilizationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the Savings Plans utilization for your account across date ranges with daily
        /// or monthly granularity. Management account in an organization have access to member
        /// accounts. You can use <c>GetDimensionValues</c> in <c>SAVINGS_PLANS</c> to determine
        /// the possible dimension values.
        /// 
        ///  <note> 
        /// <para>
        /// You can't group by any dimension values for <c>GetSavingsPlansUtilization</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansUtilization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSavingsPlansUtilization service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansUtilization">REST API Reference for GetSavingsPlansUtilization Operation</seealso>
        public virtual Task<GetSavingsPlansUtilizationResponse> GetSavingsPlansUtilizationAsync(GetSavingsPlansUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlansUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlansUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSavingsPlansUtilizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSavingsPlansUtilizationDetails

        internal virtual GetSavingsPlansUtilizationDetailsResponse GetSavingsPlansUtilizationDetails(GetSavingsPlansUtilizationDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlansUtilizationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlansUtilizationDetailsResponseUnmarshaller.Instance;

            return Invoke<GetSavingsPlansUtilizationDetailsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves attribute data along with aggregate utilization and savings data for a given
        /// time period. This doesn't support granular or grouped data (daily/monthly) in response.
        /// You can't retrieve data by dates in a single response similar to <c>GetSavingsPlanUtilization</c>,
        /// but you have the option to make multiple calls to <c>GetSavingsPlanUtilizationDetails</c>
        /// by providing individual dates. You can use <c>GetDimensionValues</c> in <c>SAVINGS_PLANS</c>
        /// to determine the possible dimension values.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>GetSavingsPlanUtilizationDetails</c> internally groups data by <c>SavingsPlansArn</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansUtilizationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSavingsPlansUtilizationDetails service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansUtilizationDetails">REST API Reference for GetSavingsPlansUtilizationDetails Operation</seealso>
        public virtual Task<GetSavingsPlansUtilizationDetailsResponse> GetSavingsPlansUtilizationDetailsAsync(GetSavingsPlansUtilizationDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSavingsPlansUtilizationDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSavingsPlansUtilizationDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSavingsPlansUtilizationDetailsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTags

        internal virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }



        /// <summary>
        /// Queries for available tag keys and tag values for a specified period. You can search
        /// the tag values for an arbitrary string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BillExpirationException">
        /// The requested report expired. Update the date interval and try again.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.RequestChangedException">
        /// Your request parameters changed between pages. Try again with the old parameters or
        /// without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetUsageForecast

        internal virtual GetUsageForecastResponse GetUsageForecast(GetUsageForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageForecastResponseUnmarshaller.Instance;

            return Invoke<GetUsageForecastResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a forecast for how much Amazon Web Services predicts that you will use over
        /// the forecast time period that you select, based on your past usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsageForecast service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnresolvableUsageUnitException">
        /// Cost Explorer was unable to identify the usage unit. Provide <c>UsageType/UsageTypeGroup</c>
        /// filter selections that contain matching units, for example: <c>hours</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetUsageForecast">REST API Reference for GetUsageForecast Operation</seealso>
        public virtual Task<GetUsageForecastResponse> GetUsageForecastAsync(GetUsageForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageForecastResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsageForecastResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCommitmentPurchaseAnalyses

        internal virtual ListCommitmentPurchaseAnalysesResponse ListCommitmentPurchaseAnalyses(ListCommitmentPurchaseAnalysesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommitmentPurchaseAnalysesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommitmentPurchaseAnalysesResponseUnmarshaller.Instance;

            return Invoke<ListCommitmentPurchaseAnalysesResponse>(request, options);
        }



        /// <summary>
        /// Lists the commitment purchase analyses for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCommitmentPurchaseAnalyses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCommitmentPurchaseAnalyses service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCommitmentPurchaseAnalyses">REST API Reference for ListCommitmentPurchaseAnalyses Operation</seealso>
        public virtual Task<ListCommitmentPurchaseAnalysesResponse> ListCommitmentPurchaseAnalysesAsync(ListCommitmentPurchaseAnalysesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCommitmentPurchaseAnalysesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCommitmentPurchaseAnalysesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCommitmentPurchaseAnalysesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCostAllocationTagBackfillHistory

        internal virtual ListCostAllocationTagBackfillHistoryResponse ListCostAllocationTagBackfillHistory(ListCostAllocationTagBackfillHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCostAllocationTagBackfillHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCostAllocationTagBackfillHistoryResponseUnmarshaller.Instance;

            return Invoke<ListCostAllocationTagBackfillHistoryResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of your historical cost allocation tag backfill requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCostAllocationTagBackfillHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCostAllocationTagBackfillHistory service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostAllocationTagBackfillHistory">REST API Reference for ListCostAllocationTagBackfillHistory Operation</seealso>
        public virtual Task<ListCostAllocationTagBackfillHistoryResponse> ListCostAllocationTagBackfillHistoryAsync(ListCostAllocationTagBackfillHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCostAllocationTagBackfillHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCostAllocationTagBackfillHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListCostAllocationTagBackfillHistoryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCostAllocationTags

        internal virtual ListCostAllocationTagsResponse ListCostAllocationTags(ListCostAllocationTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCostAllocationTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCostAllocationTagsResponseUnmarshaller.Instance;

            return Invoke<ListCostAllocationTagsResponse>(request, options);
        }



        /// <summary>
        /// Get a list of cost allocation tags. All inputs in the API are optional and serve as
        /// filters. By default, all cost allocation tags are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCostAllocationTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCostAllocationTags service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostAllocationTags">REST API Reference for ListCostAllocationTags Operation</seealso>
        public virtual Task<ListCostAllocationTagsResponse> ListCostAllocationTagsAsync(ListCostAllocationTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCostAllocationTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCostAllocationTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCostAllocationTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCostCategoryDefinitions

        internal virtual ListCostCategoryDefinitionsResponse ListCostCategoryDefinitions(ListCostCategoryDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCostCategoryDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCostCategoryDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListCostCategoryDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Returns the name, Amazon Resource Name (ARN), <c>NumberOfRules</c> and effective dates
        /// of all Cost Categories defined in the account. You have the option to use <c>EffectiveOn</c>
        /// to return a list of Cost Categories that were active on a specific date. If there
        /// is no <c>EffectiveOn</c> specified, you’ll see Cost Categories that are effective
        /// on the current date. If Cost Category is still effective, <c>EffectiveEnd</c> is omitted
        /// in the response. <c>ListCostCategoryDefinitions</c> supports pagination. The request
        /// can have a <c>MaxResults</c> range up to 100.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCostCategoryDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCostCategoryDefinitions service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostCategoryDefinitions">REST API Reference for ListCostCategoryDefinitions Operation</seealso>
        public virtual Task<ListCostCategoryDefinitionsResponse> ListCostCategoryDefinitionsAsync(ListCostCategoryDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCostCategoryDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCostCategoryDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCostCategoryDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSavingsPlansPurchaseRecommendationGeneration

        internal virtual ListSavingsPlansPurchaseRecommendationGenerationResponse ListSavingsPlansPurchaseRecommendationGeneration(ListSavingsPlansPurchaseRecommendationGenerationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSavingsPlansPurchaseRecommendationGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSavingsPlansPurchaseRecommendationGenerationResponseUnmarshaller.Instance;

            return Invoke<ListSavingsPlansPurchaseRecommendationGenerationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a list of your historical recommendation generations within the past 30
        /// days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSavingsPlansPurchaseRecommendationGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSavingsPlansPurchaseRecommendationGeneration service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListSavingsPlansPurchaseRecommendationGeneration">REST API Reference for ListSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        public virtual Task<ListSavingsPlansPurchaseRecommendationGenerationResponse> ListSavingsPlansPurchaseRecommendationGenerationAsync(ListSavingsPlansPurchaseRecommendationGenerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSavingsPlansPurchaseRecommendationGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSavingsPlansPurchaseRecommendationGenerationResponseUnmarshaller.Instance;

            return InvokeAsync<ListSavingsPlansPurchaseRecommendationGenerationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of resource tags associated with the resource specified by the Amazon
        /// Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ProvideAnomalyFeedback

        internal virtual ProvideAnomalyFeedbackResponse ProvideAnomalyFeedback(ProvideAnomalyFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvideAnomalyFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvideAnomalyFeedbackResponseUnmarshaller.Instance;

            return Invoke<ProvideAnomalyFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Modifies the feedback property of a given cost anomaly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvideAnomalyFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ProvideAnomalyFeedback service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ProvideAnomalyFeedback">REST API Reference for ProvideAnomalyFeedback Operation</seealso>
        public virtual Task<ProvideAnomalyFeedbackResponse> ProvideAnomalyFeedbackAsync(ProvideAnomalyFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvideAnomalyFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvideAnomalyFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<ProvideAnomalyFeedbackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartCommitmentPurchaseAnalysis

        internal virtual StartCommitmentPurchaseAnalysisResponse StartCommitmentPurchaseAnalysis(StartCommitmentPurchaseAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCommitmentPurchaseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCommitmentPurchaseAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartCommitmentPurchaseAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Specifies the parameters of a planned commitment purchase and starts the generation
        /// of the analysis. This enables you to estimate the cost, coverage, and utilization
        /// impact of your planned commitment purchases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCommitmentPurchaseAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCommitmentPurchaseAnalysis service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.GenerationExistsException">
        /// A request to generate a recommendation or analysis is already in progress.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of resources you can create, or exceeded the
        /// size of an individual resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/StartCommitmentPurchaseAnalysis">REST API Reference for StartCommitmentPurchaseAnalysis Operation</seealso>
        public virtual Task<StartCommitmentPurchaseAnalysisResponse> StartCommitmentPurchaseAnalysisAsync(StartCommitmentPurchaseAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCommitmentPurchaseAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCommitmentPurchaseAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<StartCommitmentPurchaseAnalysisResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartCostAllocationTagBackfill

        internal virtual StartCostAllocationTagBackfillResponse StartCostAllocationTagBackfill(StartCostAllocationTagBackfillRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCostAllocationTagBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCostAllocationTagBackfillResponseUnmarshaller.Instance;

            return Invoke<StartCostAllocationTagBackfillResponse>(request, options);
        }



        /// <summary>
        /// Request a cost allocation tag backfill. This will backfill the activation status
        /// (either <c>active</c> or <c>inactive</c>) for all tag keys from <c>para:BackfillFrom</c>
        /// up to the time this request is made.
        /// 
        ///  
        /// <para>
        /// You can request a backfill once every 24 hours. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCostAllocationTagBackfill service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCostAllocationTagBackfill service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BackfillLimitExceededException">
        /// A request to backfill is already in progress. Once the previous request is complete,
        /// you can create another request.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/StartCostAllocationTagBackfill">REST API Reference for StartCostAllocationTagBackfill Operation</seealso>
        public virtual Task<StartCostAllocationTagBackfillResponse> StartCostAllocationTagBackfillAsync(StartCostAllocationTagBackfillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCostAllocationTagBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCostAllocationTagBackfillResponseUnmarshaller.Instance;

            return InvokeAsync<StartCostAllocationTagBackfillResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartSavingsPlansPurchaseRecommendationGeneration

        internal virtual StartSavingsPlansPurchaseRecommendationGenerationResponse StartSavingsPlansPurchaseRecommendationGeneration(StartSavingsPlansPurchaseRecommendationGenerationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSavingsPlansPurchaseRecommendationGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSavingsPlansPurchaseRecommendationGenerationResponseUnmarshaller.Instance;

            return Invoke<StartSavingsPlansPurchaseRecommendationGenerationResponse>(request, options);
        }



        /// <summary>
        /// Requests a Savings Plans recommendation generation. This enables you to calculate
        /// a fresh set of Savings Plans recommendations that takes your latest usage data and
        /// current Savings Plans inventory into account. You can refresh Savings Plans recommendations
        /// up to three times daily for a consolidated billing family.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>StartSavingsPlansPurchaseRecommendationGeneration</c> has no request syntax because
        /// no input parameters are needed to support this operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSavingsPlansPurchaseRecommendationGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSavingsPlansPurchaseRecommendationGeneration service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.GenerationExistsException">
        /// A request to generate a recommendation or analysis is already in progress.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of resources you can create, or exceeded the
        /// size of an individual resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/StartSavingsPlansPurchaseRecommendationGeneration">REST API Reference for StartSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        public virtual Task<StartSavingsPlansPurchaseRecommendationGenerationResponse> StartSavingsPlansPurchaseRecommendationGenerationAsync(StartSavingsPlansPurchaseRecommendationGenerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSavingsPlansPurchaseRecommendationGenerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSavingsPlansPurchaseRecommendationGenerationResponseUnmarshaller.Instance;

            return InvokeAsync<StartSavingsPlansPurchaseRecommendationGenerationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// An API operation for adding one or more tags (key-value pairs) to a resource.
        /// 
        ///  
        /// <para>
        /// You can use the <c>TagResource</c> operation with a resource that already has tags.
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// Although the maximum number of array members is 200, user-tag maximum is 50. The remaining
        /// are reserved for Amazon Web Services use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.TooManyTagsException">
        /// Can occur if you specify a number of tags for a resource greater than the maximum
        /// 50 user tags per resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a resource. Specify only tag keys in your request. Don't
        /// specify the value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAnomalyMonitor

        internal virtual UpdateAnomalyMonitorResponse UpdateAnomalyMonitor(UpdateAnomalyMonitorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnomalyMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalyMonitorResponseUnmarshaller.Instance;

            return Invoke<UpdateAnomalyMonitorResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing cost anomaly monitor. The changes made are applied going forward,
        /// and doesn't change anomalies detected in the past.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnomalyMonitor service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownMonitorException">
        /// The cost anomaly monitor does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateAnomalyMonitor">REST API Reference for UpdateAnomalyMonitor Operation</seealso>
        public virtual Task<UpdateAnomalyMonitorResponse> UpdateAnomalyMonitorAsync(UpdateAnomalyMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnomalyMonitorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalyMonitorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAnomalyMonitorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAnomalySubscription

        internal virtual UpdateAnomalySubscriptionResponse UpdateAnomalySubscription(UpdateAnomalySubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnomalySubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalySubscriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateAnomalySubscriptionResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing cost anomaly subscription. Specify the fields that you want to
        /// update. Omitted fields are unchanged.
        /// 
        ///  <note> 
        /// <para>
        /// The JSON below describes the generic construct for each type. See <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_UpdateAnomalySubscription.html#API_UpdateAnomalySubscription_RequestParameters">Request
        /// Parameters</a> for possible values as they apply to <c>AnomalySubscription</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalySubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnomalySubscription service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownMonitorException">
        /// The cost anomaly monitor does not exist for the account.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownSubscriptionException">
        /// The cost anomaly subscription does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateAnomalySubscription">REST API Reference for UpdateAnomalySubscription Operation</seealso>
        public virtual Task<UpdateAnomalySubscriptionResponse> UpdateAnomalySubscriptionAsync(UpdateAnomalySubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnomalySubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalySubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAnomalySubscriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCostAllocationTagsStatus

        internal virtual UpdateCostAllocationTagsStatusResponse UpdateCostAllocationTagsStatus(UpdateCostAllocationTagsStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCostAllocationTagsStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCostAllocationTagsStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateCostAllocationTagsStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates status for cost allocation tags in bulk, with maximum batch size of 20. If
        /// the tag status that's updated is the same as the existing tag status, the request
        /// doesn't fail. Instead, it doesn't have any effect on the tag status (for example,
        /// activating the active tag).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCostAllocationTagsStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCostAllocationTagsStatus service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateCostAllocationTagsStatus">REST API Reference for UpdateCostAllocationTagsStatus Operation</seealso>
        public virtual Task<UpdateCostAllocationTagsStatusResponse> UpdateCostAllocationTagsStatusAsync(UpdateCostAllocationTagsStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCostAllocationTagsStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCostAllocationTagsStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCostAllocationTagsStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCostCategoryDefinition

        internal virtual UpdateCostCategoryDefinitionResponse UpdateCostCategoryDefinition(UpdateCostCategoryDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCostCategoryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCostCategoryDefinitionResponseUnmarshaller.Instance;

            return Invoke<UpdateCostCategoryDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing Cost Category. Changes made to the Cost Category rules will be
        /// used to categorize the current month’s expenses and future expenses. This won’t change
        /// categorization for the previous months.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCostCategoryDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCostCategoryDefinition service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of resources you can create, or exceeded the
        /// size of an individual resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateCostCategoryDefinition">REST API Reference for UpdateCostCategoryDefinition Operation</seealso>
        public virtual Task<UpdateCostCategoryDefinitionResponse> UpdateCostCategoryDefinitionAsync(UpdateCostCategoryDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCostCategoryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCostCategoryDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCostCategoryDefinitionResponse>(request, options, cancellationToken);
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