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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CostExplorer.Model;

#pragma warning disable CS1570
namespace Amazon.CostExplorer
{
    /// <summary>
    /// <para>Interface for accessing CostExplorer</para>
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
    public partial interface IAmazonCostExplorer : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICostExplorerPaginatorFactory Paginators { get; }

        
        #region  CreateAnomalyMonitor


        /// <summary>
        /// Creates a new cost anomaly detection monitor with the requested type and monitor specification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyMonitor service method.</param>
        /// 
        /// <returns>The response from the CreateAnomalyMonitor service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateAnomalyMonitor">REST API Reference for CreateAnomalyMonitor Operation</seealso>
        CreateAnomalyMonitorResponse CreateAnomalyMonitor(CreateAnomalyMonitorRequest request);



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
        Task<CreateAnomalyMonitorResponse> CreateAnomalyMonitorAsync(CreateAnomalyMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAnomalySubscription


        /// <summary>
        /// Adds an alert subscription to a cost anomaly detection monitor. You can use each subscription
        /// to define subscribers with email or SNS notifications. Email subscribers can set an
        /// absolute or percentage threshold and a time frequency for receiving notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalySubscription service method.</param>
        /// 
        /// <returns>The response from the CreateAnomalySubscription service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownMonitorException">
        /// The cost anomaly monitor does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateAnomalySubscription">REST API Reference for CreateAnomalySubscription Operation</seealso>
        CreateAnomalySubscriptionResponse CreateAnomalySubscription(CreateAnomalySubscriptionRequest request);



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
        Task<CreateAnomalySubscriptionResponse> CreateAnomalySubscriptionAsync(CreateAnomalySubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCostCategoryDefinition


        /// <summary>
        /// Creates a new Cost Category with the requested name and rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCostCategoryDefinition service method.</param>
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
        CreateCostCategoryDefinitionResponse CreateCostCategoryDefinition(CreateCostCategoryDefinitionRequest request);



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
        Task<CreateCostCategoryDefinitionResponse> CreateCostCategoryDefinitionAsync(CreateCostCategoryDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAnomalyMonitor


        /// <summary>
        /// Deletes a cost anomaly monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyMonitor service method.</param>
        /// 
        /// <returns>The response from the DeleteAnomalyMonitor service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownMonitorException">
        /// The cost anomaly monitor does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteAnomalyMonitor">REST API Reference for DeleteAnomalyMonitor Operation</seealso>
        DeleteAnomalyMonitorResponse DeleteAnomalyMonitor(DeleteAnomalyMonitorRequest request);



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
        Task<DeleteAnomalyMonitorResponse> DeleteAnomalyMonitorAsync(DeleteAnomalyMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAnomalySubscription


        /// <summary>
        /// Deletes a cost anomaly subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalySubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteAnomalySubscription service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownSubscriptionException">
        /// The cost anomaly subscription does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteAnomalySubscription">REST API Reference for DeleteAnomalySubscription Operation</seealso>
        DeleteAnomalySubscriptionResponse DeleteAnomalySubscription(DeleteAnomalySubscriptionRequest request);



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
        Task<DeleteAnomalySubscriptionResponse> DeleteAnomalySubscriptionAsync(DeleteAnomalySubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCostCategoryDefinition


        /// <summary>
        /// Deletes a Cost Category. Expenses from this month going forward will no longer be
        /// categorized with this Cost Category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCostCategoryDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteCostCategoryDefinition service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteCostCategoryDefinition">REST API Reference for DeleteCostCategoryDefinition Operation</seealso>
        DeleteCostCategoryDefinitionResponse DeleteCostCategoryDefinition(DeleteCostCategoryDefinitionRequest request);



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
        Task<DeleteCostCategoryDefinitionResponse> DeleteCostCategoryDefinitionAsync(DeleteCostCategoryDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCostCategoryDefinition


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
        /// 
        /// <returns>The response from the DescribeCostCategoryDefinition service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DescribeCostCategoryDefinition">REST API Reference for DescribeCostCategoryDefinition Operation</seealso>
        DescribeCostCategoryDefinitionResponse DescribeCostCategoryDefinition(DescribeCostCategoryDefinitionRequest request);



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
        Task<DescribeCostCategoryDefinitionResponse> DescribeCostCategoryDefinitionAsync(DescribeCostCategoryDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAnomalies


        /// <summary>
        /// Retrieves all of the cost anomalies detected on your account during the time period
        /// that's specified by the <c>DateInterval</c> object. Anomalies are available for up
        /// to 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalies service method.</param>
        /// 
        /// <returns>The response from the GetAnomalies service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalies">REST API Reference for GetAnomalies Operation</seealso>
        GetAnomaliesResponse GetAnomalies(GetAnomaliesRequest request);



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
        Task<GetAnomaliesResponse> GetAnomaliesAsync(GetAnomaliesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAnomalyMonitors


        /// <summary>
        /// Retrieves the cost anomaly monitor definitions for your account. You can filter using
        /// a list of cost anomaly monitor Amazon Resource Names (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyMonitors service method.</param>
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
        GetAnomalyMonitorsResponse GetAnomalyMonitors(GetAnomalyMonitorsRequest request);



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
        Task<GetAnomalyMonitorsResponse> GetAnomalyMonitorsAsync(GetAnomalyMonitorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAnomalySubscriptions


        /// <summary>
        /// Retrieves the cost anomaly subscription objects for your account. You can filter using
        /// a list of cost anomaly monitor Amazon Resource Names (ARNs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalySubscriptions service method.</param>
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
        GetAnomalySubscriptionsResponse GetAnomalySubscriptions(GetAnomalySubscriptionsRequest request);



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
        Task<GetAnomalySubscriptionsResponse> GetAnomalySubscriptionsAsync(GetAnomalySubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApproximateUsageRecords


        /// <summary>
        /// Retrieves estimated usage records for hourly granularity or resource-level data at
        /// daily granularity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApproximateUsageRecords service method.</param>
        /// 
        /// <returns>The response from the GetApproximateUsageRecords service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetApproximateUsageRecords">REST API Reference for GetApproximateUsageRecords Operation</seealso>
        GetApproximateUsageRecordsResponse GetApproximateUsageRecords(GetApproximateUsageRecordsRequest request);



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
        Task<GetApproximateUsageRecordsResponse> GetApproximateUsageRecordsAsync(GetApproximateUsageRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCostAndUsage


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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsage">REST API Reference for GetCostAndUsage Operation</seealso>
        GetCostAndUsageResponse GetCostAndUsage(GetCostAndUsageRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsage">REST API Reference for GetCostAndUsage Operation</seealso>
        Task<GetCostAndUsageResponse> GetCostAndUsageAsync(GetCostAndUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCostAndUsageWithResources


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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsageWithResources">REST API Reference for GetCostAndUsageWithResources Operation</seealso>
        GetCostAndUsageWithResourcesResponse GetCostAndUsageWithResources(GetCostAndUsageWithResourcesRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsageWithResources">REST API Reference for GetCostAndUsageWithResources Operation</seealso>
        Task<GetCostAndUsageWithResourcesResponse> GetCostAndUsageWithResourcesAsync(GetCostAndUsageWithResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCostCategories


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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostCategories">REST API Reference for GetCostCategories Operation</seealso>
        GetCostCategoriesResponse GetCostCategories(GetCostCategoriesRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostCategories">REST API Reference for GetCostCategories Operation</seealso>
        Task<GetCostCategoriesResponse> GetCostCategoriesAsync(GetCostCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCostForecast


        /// <summary>
        /// Retrieves a forecast for how much Amazon Web Services predicts that you will spend
        /// over the forecast time period that you select, based on your past costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostForecast service method.</param>
        /// 
        /// <returns>The response from the GetCostForecast service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostForecast">REST API Reference for GetCostForecast Operation</seealso>
        GetCostForecastResponse GetCostForecast(GetCostForecastRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostForecast">REST API Reference for GetCostForecast Operation</seealso>
        Task<GetCostForecastResponse> GetCostForecastAsync(GetCostForecastRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDimensionValues


        /// <summary>
        /// Retrieves all available filter values for a specified filter over a period of time.
        /// You can search the dimension values for an arbitrary string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDimensionValues service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetDimensionValues">REST API Reference for GetDimensionValues Operation</seealso>
        GetDimensionValuesResponse GetDimensionValues(GetDimensionValuesRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetDimensionValues">REST API Reference for GetDimensionValues Operation</seealso>
        Task<GetDimensionValuesResponse> GetDimensionValuesAsync(GetDimensionValuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReservationCoverage


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
        GetReservationCoverageResponse GetReservationCoverage(GetReservationCoverageRequest request);



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
        Task<GetReservationCoverageResponse> GetReservationCoverageAsync(GetReservationCoverageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReservationPurchaseRecommendation


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
        GetReservationPurchaseRecommendationResponse GetReservationPurchaseRecommendation(GetReservationPurchaseRecommendationRequest request);



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
        Task<GetReservationPurchaseRecommendationResponse> GetReservationPurchaseRecommendationAsync(GetReservationPurchaseRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReservationUtilization


        /// <summary>
        /// Retrieves the reservation utilization for your account. Management account in an organization
        /// have access to member accounts. You can filter data by dimensions in a time period.
        /// You can use <c>GetDimensionValues</c> to determine the possible dimension values.
        /// Currently, you can group only by <c>SUBSCRIPTION_ID</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservationUtilization service method.</param>
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
        GetReservationUtilizationResponse GetReservationUtilization(GetReservationUtilizationRequest request);



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
        Task<GetReservationUtilizationResponse> GetReservationUtilizationAsync(GetReservationUtilizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRightsizingRecommendation


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
        /// 
        /// <returns>The response from the GetRightsizingRecommendation service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetRightsizingRecommendation">REST API Reference for GetRightsizingRecommendation Operation</seealso>
        GetRightsizingRecommendationResponse GetRightsizingRecommendation(GetRightsizingRecommendationRequest request);



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
        Task<GetRightsizingRecommendationResponse> GetRightsizingRecommendationAsync(GetRightsizingRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSavingsPlanPurchaseRecommendationDetails


        /// <summary>
        /// Retrieves the details for a Savings Plan recommendation. These details include the
        /// hourly data-points that construct the cost, coverage, and utilization charts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlanPurchaseRecommendationDetails service method.</param>
        /// 
        /// <returns>The response from the GetSavingsPlanPurchaseRecommendationDetails service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlanPurchaseRecommendationDetails">REST API Reference for GetSavingsPlanPurchaseRecommendationDetails Operation</seealso>
        GetSavingsPlanPurchaseRecommendationDetailsResponse GetSavingsPlanPurchaseRecommendationDetails(GetSavingsPlanPurchaseRecommendationDetailsRequest request);



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
        Task<GetSavingsPlanPurchaseRecommendationDetailsResponse> GetSavingsPlanPurchaseRecommendationDetailsAsync(GetSavingsPlanPurchaseRecommendationDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSavingsPlansCoverage


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
        GetSavingsPlansCoverageResponse GetSavingsPlansCoverage(GetSavingsPlansCoverageRequest request);



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
        Task<GetSavingsPlansCoverageResponse> GetSavingsPlansCoverageAsync(GetSavingsPlansCoverageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSavingsPlansPurchaseRecommendation


        /// <summary>
        /// Retrieves the Savings Plans recommendations for your account. First use <c>StartSavingsPlansPurchaseRecommendationGeneration</c>
        /// to generate a new set of recommendations, and then use <c>GetSavingsPlansPurchaseRecommendation</c>
        /// to retrieve them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansPurchaseRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetSavingsPlansPurchaseRecommendation service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansPurchaseRecommendation">REST API Reference for GetSavingsPlansPurchaseRecommendation Operation</seealso>
        GetSavingsPlansPurchaseRecommendationResponse GetSavingsPlansPurchaseRecommendation(GetSavingsPlansPurchaseRecommendationRequest request);



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
        Task<GetSavingsPlansPurchaseRecommendationResponse> GetSavingsPlansPurchaseRecommendationAsync(GetSavingsPlansPurchaseRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSavingsPlansUtilization


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
        /// 
        /// <returns>The response from the GetSavingsPlansUtilization service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansUtilization">REST API Reference for GetSavingsPlansUtilization Operation</seealso>
        GetSavingsPlansUtilizationResponse GetSavingsPlansUtilization(GetSavingsPlansUtilizationRequest request);



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
        Task<GetSavingsPlansUtilizationResponse> GetSavingsPlansUtilizationAsync(GetSavingsPlansUtilizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSavingsPlansUtilizationDetails


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
        GetSavingsPlansUtilizationDetailsResponse GetSavingsPlansUtilizationDetails(GetSavingsPlansUtilizationDetailsRequest request);



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
        Task<GetSavingsPlansUtilizationDetailsResponse> GetSavingsPlansUtilizationDetailsAsync(GetSavingsPlansUtilizationDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTags


        /// <summary>
        /// Queries for available tag keys and tag values for a specified period. You can search
        /// the tag values for an arbitrary string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse GetTags(GetTagsRequest request);



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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetTags">REST API Reference for GetTags Operation</seealso>
        Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUsageForecast


        /// <summary>
        /// Retrieves a forecast for how much Amazon Web Services predicts that you will use over
        /// the forecast time period that you select, based on your past usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageForecast service method.</param>
        /// 
        /// <returns>The response from the GetUsageForecast service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnresolvableUsageUnitException">
        /// Cost Explorer was unable to identify the usage unit. Provide <c>UsageType/UsageTypeGroup</c>
        /// filter selections that contain matching units, for example: <c>hours</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetUsageForecast">REST API Reference for GetUsageForecast Operation</seealso>
        GetUsageForecastResponse GetUsageForecast(GetUsageForecastRequest request);



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
        /// <exception cref="Amazon.CostExplorer.Model.UnresolvableUsageUnitException">
        /// Cost Explorer was unable to identify the usage unit. Provide <c>UsageType/UsageTypeGroup</c>
        /// filter selections that contain matching units, for example: <c>hours</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetUsageForecast">REST API Reference for GetUsageForecast Operation</seealso>
        Task<GetUsageForecastResponse> GetUsageForecastAsync(GetUsageForecastRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCostAllocationTagBackfillHistory


        /// <summary>
        /// Retrieves a list of your historical cost allocation tag backfill requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCostAllocationTagBackfillHistory service method.</param>
        /// 
        /// <returns>The response from the ListCostAllocationTagBackfillHistory service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostAllocationTagBackfillHistory">REST API Reference for ListCostAllocationTagBackfillHistory Operation</seealso>
        ListCostAllocationTagBackfillHistoryResponse ListCostAllocationTagBackfillHistory(ListCostAllocationTagBackfillHistoryRequest request);



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
        Task<ListCostAllocationTagBackfillHistoryResponse> ListCostAllocationTagBackfillHistoryAsync(ListCostAllocationTagBackfillHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCostAllocationTags


        /// <summary>
        /// Get a list of cost allocation tags. All inputs in the API are optional and serve as
        /// filters. By default, all cost allocation tags are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCostAllocationTags service method.</param>
        /// 
        /// <returns>The response from the ListCostAllocationTags service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostAllocationTags">REST API Reference for ListCostAllocationTags Operation</seealso>
        ListCostAllocationTagsResponse ListCostAllocationTags(ListCostAllocationTagsRequest request);



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
        Task<ListCostAllocationTagsResponse> ListCostAllocationTagsAsync(ListCostAllocationTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCostCategoryDefinitions


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
        /// 
        /// <returns>The response from the ListCostCategoryDefinitions service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostCategoryDefinitions">REST API Reference for ListCostCategoryDefinitions Operation</seealso>
        ListCostCategoryDefinitionsResponse ListCostCategoryDefinitions(ListCostCategoryDefinitionsRequest request);



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
        Task<ListCostCategoryDefinitionsResponse> ListCostCategoryDefinitionsAsync(ListCostCategoryDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSavingsPlansPurchaseRecommendationGeneration


        /// <summary>
        /// Retrieves a list of your historical recommendation generations within the past 30
        /// days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSavingsPlansPurchaseRecommendationGeneration service method.</param>
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
        ListSavingsPlansPurchaseRecommendationGenerationResponse ListSavingsPlansPurchaseRecommendationGeneration(ListSavingsPlansPurchaseRecommendationGenerationRequest request);



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
        Task<ListSavingsPlansPurchaseRecommendationGenerationResponse> ListSavingsPlansPurchaseRecommendationGenerationAsync(ListSavingsPlansPurchaseRecommendationGenerationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of resource tags associated with the resource specified by the Amazon
        /// Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ProvideAnomalyFeedback


        /// <summary>
        /// Modifies the feedback property of a given cost anomaly.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvideAnomalyFeedback service method.</param>
        /// 
        /// <returns>The response from the ProvideAnomalyFeedback service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ProvideAnomalyFeedback">REST API Reference for ProvideAnomalyFeedback Operation</seealso>
        ProvideAnomalyFeedbackResponse ProvideAnomalyFeedback(ProvideAnomalyFeedbackRequest request);



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
        Task<ProvideAnomalyFeedbackResponse> ProvideAnomalyFeedbackAsync(ProvideAnomalyFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCostAllocationTagBackfill


        /// <summary>
        /// Request a cost allocation tag backfill. This will backfill the activation status
        /// (either <c>active</c> or <c>inactive</c>) for all tag keys from <c>para:BackfillFrom</c>
        /// up to the when this request is made.
        /// 
        ///  
        /// <para>
        /// You can request a backfill once every 24 hours. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCostAllocationTagBackfill service method.</param>
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
        StartCostAllocationTagBackfillResponse StartCostAllocationTagBackfill(StartCostAllocationTagBackfillRequest request);



        /// <summary>
        /// Request a cost allocation tag backfill. This will backfill the activation status
        /// (either <c>active</c> or <c>inactive</c>) for all tag keys from <c>para:BackfillFrom</c>
        /// up to the when this request is made.
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
        Task<StartCostAllocationTagBackfillResponse> StartCostAllocationTagBackfillAsync(StartCostAllocationTagBackfillRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartSavingsPlansPurchaseRecommendationGeneration


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
        /// 
        /// <returns>The response from the StartSavingsPlansPurchaseRecommendationGeneration service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.GenerationExistsException">
        /// A request to generate a recommendation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of resources you can create, or exceeded the
        /// size of an individual resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/StartSavingsPlansPurchaseRecommendationGeneration">REST API Reference for StartSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        StartSavingsPlansPurchaseRecommendationGenerationResponse StartSavingsPlansPurchaseRecommendationGeneration(StartSavingsPlansPurchaseRecommendationGenerationRequest request);



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
        /// A request to generate a recommendation is already in progress.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ServiceQuotaExceededException">
        /// You've reached the limit on the number of resources you can create, or exceeded the
        /// size of an individual resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/StartSavingsPlansPurchaseRecommendationGeneration">REST API Reference for StartSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        Task<StartSavingsPlansPurchaseRecommendationGenerationResponse> StartSavingsPlansPurchaseRecommendationGenerationAsync(StartSavingsPlansPurchaseRecommendationGenerationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a resource. Specify only tag keys in your request. Don't
        /// specify the value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.ResourceNotFoundException">
        /// The specified ARN in the request doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAnomalyMonitor


        /// <summary>
        /// Updates an existing cost anomaly monitor. The changes made are applied going forward,
        /// and doesn't change anomalies detected in the past.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyMonitor service method.</param>
        /// 
        /// <returns>The response from the UpdateAnomalyMonitor service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnknownMonitorException">
        /// The cost anomaly monitor does not exist for the account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateAnomalyMonitor">REST API Reference for UpdateAnomalyMonitor Operation</seealso>
        UpdateAnomalyMonitorResponse UpdateAnomalyMonitor(UpdateAnomalyMonitorRequest request);



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
        Task<UpdateAnomalyMonitorResponse> UpdateAnomalyMonitorAsync(UpdateAnomalyMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAnomalySubscription


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
        UpdateAnomalySubscriptionResponse UpdateAnomalySubscription(UpdateAnomalySubscriptionRequest request);



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
        Task<UpdateAnomalySubscriptionResponse> UpdateAnomalySubscriptionAsync(UpdateAnomalySubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCostAllocationTagsStatus


        /// <summary>
        /// Updates status for cost allocation tags in bulk, with maximum batch size of 20. If
        /// the tag status that's updated is the same as the existing tag status, the request
        /// doesn't fail. Instead, it doesn't have any effect on the tag status (for example,
        /// activating the active tag).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCostAllocationTagsStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateCostAllocationTagsStatus service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateCostAllocationTagsStatus">REST API Reference for UpdateCostAllocationTagsStatus Operation</seealso>
        UpdateCostAllocationTagsStatusResponse UpdateCostAllocationTagsStatus(UpdateCostAllocationTagsStatusRequest request);



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
        Task<UpdateCostAllocationTagsStatusResponse> UpdateCostAllocationTagsStatusAsync(UpdateCostAllocationTagsStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCostCategoryDefinition


        /// <summary>
        /// Updates an existing Cost Category. Changes made to the Cost Category rules will be
        /// used to categorize the current month’s expenses and future expenses. This won’t change
        /// categorization for the previous months.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCostCategoryDefinition service method.</param>
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
        UpdateCostCategoryDefinitionResponse UpdateCostCategoryDefinition(UpdateCostCategoryDefinitionRequest request);



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
        Task<UpdateCostCategoryDefinitionResponse> UpdateCostCategoryDefinitionAsync(UpdateCostCategoryDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}