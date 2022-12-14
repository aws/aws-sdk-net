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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CostExplorer.Model;

namespace Amazon.CostExplorer
{
    /// <summary>
    /// Interface for accessing CostExplorer
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
    ///  <code>https://ce.us-east-1.amazonaws.com</code> 
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICostExplorerPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CreateAnomalyMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyMonitor operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnomalyMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateAnomalyMonitor">REST API Reference for CreateAnomalyMonitor Operation</seealso>
        IAsyncResult BeginCreateAnomalyMonitor(CreateAnomalyMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnomalyMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnomalyMonitor.</param>
        /// 
        /// <returns>Returns a  CreateAnomalyMonitorResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateAnomalyMonitor">REST API Reference for CreateAnomalyMonitor Operation</seealso>
        CreateAnomalyMonitorResponse EndCreateAnomalyMonitor(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateAnomalySubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalySubscription operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnomalySubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateAnomalySubscription">REST API Reference for CreateAnomalySubscription Operation</seealso>
        IAsyncResult BeginCreateAnomalySubscription(CreateAnomalySubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnomalySubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnomalySubscription.</param>
        /// 
        /// <returns>Returns a  CreateAnomalySubscriptionResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateAnomalySubscription">REST API Reference for CreateAnomalySubscription Operation</seealso>
        CreateAnomalySubscriptionResponse EndCreateAnomalySubscription(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateCostCategoryDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCostCategoryDefinition operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCostCategoryDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateCostCategoryDefinition">REST API Reference for CreateCostCategoryDefinition Operation</seealso>
        IAsyncResult BeginCreateCostCategoryDefinition(CreateCostCategoryDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCostCategoryDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCostCategoryDefinition.</param>
        /// 
        /// <returns>Returns a  CreateCostCategoryDefinitionResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/CreateCostCategoryDefinition">REST API Reference for CreateCostCategoryDefinition Operation</seealso>
        CreateCostCategoryDefinitionResponse EndCreateCostCategoryDefinition(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteAnomalyMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyMonitor operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnomalyMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteAnomalyMonitor">REST API Reference for DeleteAnomalyMonitor Operation</seealso>
        IAsyncResult BeginDeleteAnomalyMonitor(DeleteAnomalyMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnomalyMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnomalyMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteAnomalyMonitorResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteAnomalyMonitor">REST API Reference for DeleteAnomalyMonitor Operation</seealso>
        DeleteAnomalyMonitorResponse EndDeleteAnomalyMonitor(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteAnomalySubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalySubscription operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnomalySubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteAnomalySubscription">REST API Reference for DeleteAnomalySubscription Operation</seealso>
        IAsyncResult BeginDeleteAnomalySubscription(DeleteAnomalySubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnomalySubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnomalySubscription.</param>
        /// 
        /// <returns>Returns a  DeleteAnomalySubscriptionResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteAnomalySubscription">REST API Reference for DeleteAnomalySubscription Operation</seealso>
        DeleteAnomalySubscriptionResponse EndDeleteAnomalySubscription(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteCostCategoryDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCostCategoryDefinition operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCostCategoryDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteCostCategoryDefinition">REST API Reference for DeleteCostCategoryDefinition Operation</seealso>
        IAsyncResult BeginDeleteCostCategoryDefinition(DeleteCostCategoryDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCostCategoryDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCostCategoryDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteCostCategoryDefinitionResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DeleteCostCategoryDefinition">REST API Reference for DeleteCostCategoryDefinition Operation</seealso>
        DeleteCostCategoryDefinitionResponse EndDeleteCostCategoryDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCostCategoryDefinition


        /// <summary>
        /// Returns the name, Amazon Resource Name (ARN), rules, definition, and effective dates
        /// of a Cost Category that's defined in the account.
        /// 
        ///  
        /// <para>
        /// You have the option to use <code>EffectiveOn</code> to return a Cost Category that's
        /// active on a specific date. If there's no <code>EffectiveOn</code> specified, you see
        /// a Cost Category that's effective on the current date. If Cost Category is still effective,
        /// <code>EffectiveEnd</code> is omitted in the response. 
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
        /// Initiates the asynchronous execution of the DescribeCostCategoryDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCostCategoryDefinition operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCostCategoryDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DescribeCostCategoryDefinition">REST API Reference for DescribeCostCategoryDefinition Operation</seealso>
        IAsyncResult BeginDescribeCostCategoryDefinition(DescribeCostCategoryDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCostCategoryDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCostCategoryDefinition.</param>
        /// 
        /// <returns>Returns a  DescribeCostCategoryDefinitionResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/DescribeCostCategoryDefinition">REST API Reference for DescribeCostCategoryDefinition Operation</seealso>
        DescribeCostCategoryDefinitionResponse EndDescribeCostCategoryDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnomalies


        /// <summary>
        /// Retrieves all of the cost anomalies detected on your account during the time period
        /// that's specified by the <code>DateInterval</code> object. Anomalies are available
        /// for up to 90 days.
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
        /// Initiates the asynchronous execution of the GetAnomalies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalies operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnomalies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalies">REST API Reference for GetAnomalies Operation</seealso>
        IAsyncResult BeginGetAnomalies(GetAnomaliesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnomalies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnomalies.</param>
        /// 
        /// <returns>Returns a  GetAnomaliesResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalies">REST API Reference for GetAnomalies Operation</seealso>
        GetAnomaliesResponse EndGetAnomalies(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAnomalyMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyMonitors operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnomalyMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalyMonitors">REST API Reference for GetAnomalyMonitors Operation</seealso>
        IAsyncResult BeginGetAnomalyMonitors(GetAnomalyMonitorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnomalyMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnomalyMonitors.</param>
        /// 
        /// <returns>Returns a  GetAnomalyMonitorsResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalyMonitors">REST API Reference for GetAnomalyMonitors Operation</seealso>
        GetAnomalyMonitorsResponse EndGetAnomalyMonitors(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetAnomalySubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalySubscriptions operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnomalySubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalySubscriptions">REST API Reference for GetAnomalySubscriptions Operation</seealso>
        IAsyncResult BeginGetAnomalySubscriptions(GetAnomalySubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnomalySubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnomalySubscriptions.</param>
        /// 
        /// <returns>Returns a  GetAnomalySubscriptionsResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetAnomalySubscriptions">REST API Reference for GetAnomalySubscriptions Operation</seealso>
        GetAnomalySubscriptionsResponse EndGetAnomalySubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCostAndUsage


        /// <summary>
        /// Retrieves cost and usage metrics for your account. You can specify which cost and
        /// usage-related metric that you want the request to return. For example, you can specify
        /// <code>BlendedCosts</code> or <code>UsageQuantity</code>. You can also filter and group
        /// your data by various dimensions, such as <code>SERVICE</code> or <code>AZ</code>,
        /// in a specific time range. For a complete list of valid dimensions, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_GetDimensionValues.html">GetDimensionValues</a>
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
        /// Initiates the asynchronous execution of the GetCostAndUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCostAndUsage operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCostAndUsage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsage">REST API Reference for GetCostAndUsage Operation</seealso>
        IAsyncResult BeginGetCostAndUsage(GetCostAndUsageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCostAndUsage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCostAndUsage.</param>
        /// 
        /// <returns>Returns a  GetCostAndUsageResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsage">REST API Reference for GetCostAndUsage Operation</seealso>
        GetCostAndUsageResponse EndGetCostAndUsage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCostAndUsageWithResources


        /// <summary>
        /// Retrieves cost and usage metrics with resources for your account. You can specify
        /// which cost and usage-related metric, such as <code>BlendedCosts</code> or <code>UsageQuantity</code>,
        /// that you want the request to return. You can also filter and group your data by various
        /// dimensions, such as <code>SERVICE</code> or <code>AZ</code>, in a specific time range.
        /// For a complete list of valid dimensions, see the <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_GetDimensionValues.html">GetDimensionValues</a>
        /// operation. Management account in an organization in Organizations have access to all
        /// member accounts. This API is currently available for the Amazon Elastic Compute Cloud
        /// – Compute service only.
        /// 
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
        /// Initiates the asynchronous execution of the GetCostAndUsageWithResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCostAndUsageWithResources operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCostAndUsageWithResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsageWithResources">REST API Reference for GetCostAndUsageWithResources Operation</seealso>
        IAsyncResult BeginGetCostAndUsageWithResources(GetCostAndUsageWithResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCostAndUsageWithResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCostAndUsageWithResources.</param>
        /// 
        /// <returns>Returns a  GetCostAndUsageWithResourcesResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsageWithResources">REST API Reference for GetCostAndUsageWithResources Operation</seealso>
        GetCostAndUsageWithResourcesResponse EndGetCostAndUsageWithResources(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetCostCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCostCategories operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCostCategories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostCategories">REST API Reference for GetCostCategories Operation</seealso>
        IAsyncResult BeginGetCostCategories(GetCostCategoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCostCategories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCostCategories.</param>
        /// 
        /// <returns>Returns a  GetCostCategoriesResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostCategories">REST API Reference for GetCostCategories Operation</seealso>
        GetCostCategoriesResponse EndGetCostCategories(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetCostForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCostForecast operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCostForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostForecast">REST API Reference for GetCostForecast Operation</seealso>
        IAsyncResult BeginGetCostForecast(GetCostForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCostForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCostForecast.</param>
        /// 
        /// <returns>Returns a  GetCostForecastResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostForecast">REST API Reference for GetCostForecast Operation</seealso>
        GetCostForecastResponse EndGetCostForecast(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetDimensionValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDimensionValues operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDimensionValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetDimensionValues">REST API Reference for GetDimensionValues Operation</seealso>
        IAsyncResult BeginGetDimensionValues(GetDimensionValuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDimensionValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDimensionValues.</param>
        /// 
        /// <returns>Returns a  GetDimensionValuesResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetDimensionValues">REST API Reference for GetDimensionValues Operation</seealso>
        GetDimensionValuesResponse EndGetDimensionValues(IAsyncResult asyncResult);

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
        /// To determine valid values for a dimension, use the <code>GetDimensionValues</code>
        /// operation. 
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
        /// Initiates the asynchronous execution of the GetReservationCoverage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservationCoverage operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReservationCoverage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationCoverage">REST API Reference for GetReservationCoverage Operation</seealso>
        IAsyncResult BeginGetReservationCoverage(GetReservationCoverageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReservationCoverage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReservationCoverage.</param>
        /// 
        /// <returns>Returns a  GetReservationCoverageResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationCoverage">REST API Reference for GetReservationCoverage Operation</seealso>
        GetReservationCoverageResponse EndGetReservationCoverage(IAsyncResult asyncResult);

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
        /// size that you want. For this example, your RI recommendation is for <code>c4.large</code>
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
        /// Initiates the asynchronous execution of the GetReservationPurchaseRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservationPurchaseRecommendation operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReservationPurchaseRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationPurchaseRecommendation">REST API Reference for GetReservationPurchaseRecommendation Operation</seealso>
        IAsyncResult BeginGetReservationPurchaseRecommendation(GetReservationPurchaseRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReservationPurchaseRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReservationPurchaseRecommendation.</param>
        /// 
        /// <returns>Returns a  GetReservationPurchaseRecommendationResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationPurchaseRecommendation">REST API Reference for GetReservationPurchaseRecommendation Operation</seealso>
        GetReservationPurchaseRecommendationResponse EndGetReservationPurchaseRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReservationUtilization


        /// <summary>
        /// Retrieves the reservation utilization for your account. Management account in an organization
        /// have access to member accounts. You can filter data by dimensions in a time period.
        /// You can use <code>GetDimensionValues</code> to determine the possible dimension values.
        /// Currently, you can group only by <code>SUBSCRIPTION_ID</code>.
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
        /// Initiates the asynchronous execution of the GetReservationUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservationUtilization operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReservationUtilization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationUtilization">REST API Reference for GetReservationUtilization Operation</seealso>
        IAsyncResult BeginGetReservationUtilization(GetReservationUtilizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReservationUtilization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReservationUtilization.</param>
        /// 
        /// <returns>Returns a  GetReservationUtilizationResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationUtilization">REST API Reference for GetReservationUtilization Operation</seealso>
        GetReservationUtilizationResponse EndGetReservationUtilization(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetRightsizingRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRightsizingRecommendation operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRightsizingRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetRightsizingRecommendation">REST API Reference for GetRightsizingRecommendation Operation</seealso>
        IAsyncResult BeginGetRightsizingRecommendation(GetRightsizingRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRightsizingRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRightsizingRecommendation.</param>
        /// 
        /// <returns>Returns a  GetRightsizingRecommendationResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetRightsizingRecommendation">REST API Reference for GetRightsizingRecommendation Operation</seealso>
        GetRightsizingRecommendationResponse EndGetRightsizingRecommendation(IAsyncResult asyncResult);

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
        ///  <code>LINKED_ACCOUNT</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REGION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SERVICE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSTANCE_FAMILY</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To determine valid values for a dimension, use the <code>GetDimensionValues</code>
        /// operation.
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
        /// Initiates the asynchronous execution of the GetSavingsPlansCoverage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansCoverage operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSavingsPlansCoverage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansCoverage">REST API Reference for GetSavingsPlansCoverage Operation</seealso>
        IAsyncResult BeginGetSavingsPlansCoverage(GetSavingsPlansCoverageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSavingsPlansCoverage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSavingsPlansCoverage.</param>
        /// 
        /// <returns>Returns a  GetSavingsPlansCoverageResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansCoverage">REST API Reference for GetSavingsPlansCoverage Operation</seealso>
        GetSavingsPlansCoverageResponse EndGetSavingsPlansCoverage(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSavingsPlansPurchaseRecommendation


        /// <summary>
        /// Retrieves the Savings Plans recommendations for your account. First use <code>StartSavingsPlansPurchaseRecommendationGeneration</code>
        /// to generate a new set of recommendations, and then use <code>GetSavingsPlansPurchaseRecommendation</code>
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
        /// Initiates the asynchronous execution of the GetSavingsPlansPurchaseRecommendation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansPurchaseRecommendation operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSavingsPlansPurchaseRecommendation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansPurchaseRecommendation">REST API Reference for GetSavingsPlansPurchaseRecommendation Operation</seealso>
        IAsyncResult BeginGetSavingsPlansPurchaseRecommendation(GetSavingsPlansPurchaseRecommendationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSavingsPlansPurchaseRecommendation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSavingsPlansPurchaseRecommendation.</param>
        /// 
        /// <returns>Returns a  GetSavingsPlansPurchaseRecommendationResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansPurchaseRecommendation">REST API Reference for GetSavingsPlansPurchaseRecommendation Operation</seealso>
        GetSavingsPlansPurchaseRecommendationResponse EndGetSavingsPlansPurchaseRecommendation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSavingsPlansUtilization


        /// <summary>
        /// Retrieves the Savings Plans utilization for your account across date ranges with daily
        /// or monthly granularity. Management account in an organization have access to member
        /// accounts. You can use <code>GetDimensionValues</code> in <code>SAVINGS_PLANS</code>
        /// to determine the possible dimension values.
        /// 
        ///  <note> 
        /// <para>
        /// You can't group by any dimension values for <code>GetSavingsPlansUtilization</code>.
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
        /// Initiates the asynchronous execution of the GetSavingsPlansUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansUtilization operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSavingsPlansUtilization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansUtilization">REST API Reference for GetSavingsPlansUtilization Operation</seealso>
        IAsyncResult BeginGetSavingsPlansUtilization(GetSavingsPlansUtilizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSavingsPlansUtilization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSavingsPlansUtilization.</param>
        /// 
        /// <returns>Returns a  GetSavingsPlansUtilizationResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansUtilization">REST API Reference for GetSavingsPlansUtilization Operation</seealso>
        GetSavingsPlansUtilizationResponse EndGetSavingsPlansUtilization(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSavingsPlansUtilizationDetails


        /// <summary>
        /// Retrieves attribute data along with aggregate utilization and savings data for a given
        /// time period. This doesn't support granular or grouped data (daily/monthly) in response.
        /// You can't retrieve data by dates in a single response similar to <code>GetSavingsPlanUtilization</code>,
        /// but you have the option to make multiple calls to <code>GetSavingsPlanUtilizationDetails</code>
        /// by providing individual dates. You can use <code>GetDimensionValues</code> in <code>SAVINGS_PLANS</code>
        /// to determine the possible dimension values.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>GetSavingsPlanUtilizationDetails</code> internally groups data by <code>SavingsPlansArn</code>.
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
        /// Initiates the asynchronous execution of the GetSavingsPlansUtilizationDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSavingsPlansUtilizationDetails operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSavingsPlansUtilizationDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansUtilizationDetails">REST API Reference for GetSavingsPlansUtilizationDetails Operation</seealso>
        IAsyncResult BeginGetSavingsPlansUtilizationDetails(GetSavingsPlansUtilizationDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSavingsPlansUtilizationDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSavingsPlansUtilizationDetails.</param>
        /// 
        /// <returns>Returns a  GetSavingsPlansUtilizationDetailsResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetSavingsPlansUtilizationDetails">REST API Reference for GetSavingsPlansUtilizationDetails Operation</seealso>
        GetSavingsPlansUtilizationDetailsResponse EndGetSavingsPlansUtilizationDetails(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetTags">REST API Reference for GetTags Operation</seealso>
        IAsyncResult BeginGetTags(GetTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTags.</param>
        /// 
        /// <returns>Returns a  GetTagsResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetTags">REST API Reference for GetTags Operation</seealso>
        GetTagsResponse EndGetTags(IAsyncResult asyncResult);

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
        /// Cost Explorer was unable to identify the usage unit. Provide <code>UsageType/UsageTypeGroup</code>
        /// filter selections that contain matching units, for example: <code>hours</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetUsageForecast">REST API Reference for GetUsageForecast Operation</seealso>
        GetUsageForecastResponse GetUsageForecast(GetUsageForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUsageForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsageForecast operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUsageForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetUsageForecast">REST API Reference for GetUsageForecast Operation</seealso>
        IAsyncResult BeginGetUsageForecast(GetUsageForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUsageForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUsageForecast.</param>
        /// 
        /// <returns>Returns a  GetUsageForecastResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetUsageForecast">REST API Reference for GetUsageForecast Operation</seealso>
        GetUsageForecastResponse EndGetUsageForecast(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListCostAllocationTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCostAllocationTags operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCostAllocationTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostAllocationTags">REST API Reference for ListCostAllocationTags Operation</seealso>
        IAsyncResult BeginListCostAllocationTags(ListCostAllocationTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCostAllocationTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCostAllocationTags.</param>
        /// 
        /// <returns>Returns a  ListCostAllocationTagsResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostAllocationTags">REST API Reference for ListCostAllocationTags Operation</seealso>
        ListCostAllocationTagsResponse EndListCostAllocationTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCostCategoryDefinitions


        /// <summary>
        /// Returns the name, Amazon Resource Name (ARN), <code>NumberOfRules</code> and effective
        /// dates of all Cost Categories defined in the account. You have the option to use <code>EffectiveOn</code>
        /// to return a list of Cost Categories that were active on a specific date. If there
        /// is no <code>EffectiveOn</code> specified, you’ll see Cost Categories that are effective
        /// on the current date. If Cost Category is still effective, <code>EffectiveEnd</code>
        /// is omitted in the response. <code>ListCostCategoryDefinitions</code> supports pagination.
        /// The request can have a <code>MaxResults</code> range up to 100.
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
        /// Initiates the asynchronous execution of the ListCostCategoryDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCostCategoryDefinitions operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCostCategoryDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostCategoryDefinitions">REST API Reference for ListCostCategoryDefinitions Operation</seealso>
        IAsyncResult BeginListCostCategoryDefinitions(ListCostCategoryDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCostCategoryDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCostCategoryDefinitions.</param>
        /// 
        /// <returns>Returns a  ListCostCategoryDefinitionsResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListCostCategoryDefinitions">REST API Reference for ListCostCategoryDefinitions Operation</seealso>
        ListCostCategoryDefinitionsResponse EndListCostCategoryDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSavingsPlansPurchaseRecommendationGeneration


        /// <summary>
        /// Retrieves a list of your historical recommendation generations within the past 30
        /// days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSavingsPlansPurchaseRecommendationGeneration service method.</param>
        /// 
        /// <returns>The response from the ListSavingsPlansPurchaseRecommendationGeneration service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListSavingsPlansPurchaseRecommendationGeneration">REST API Reference for ListSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        ListSavingsPlansPurchaseRecommendationGenerationResponse ListSavingsPlansPurchaseRecommendationGeneration(ListSavingsPlansPurchaseRecommendationGenerationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSavingsPlansPurchaseRecommendationGeneration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSavingsPlansPurchaseRecommendationGeneration operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSavingsPlansPurchaseRecommendationGeneration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListSavingsPlansPurchaseRecommendationGeneration">REST API Reference for ListSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        IAsyncResult BeginListSavingsPlansPurchaseRecommendationGeneration(ListSavingsPlansPurchaseRecommendationGenerationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSavingsPlansPurchaseRecommendationGeneration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSavingsPlansPurchaseRecommendationGeneration.</param>
        /// 
        /// <returns>Returns a  ListSavingsPlansPurchaseRecommendationGenerationResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListSavingsPlansPurchaseRecommendationGeneration">REST API Reference for ListSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        ListSavingsPlansPurchaseRecommendationGenerationResponse EndListSavingsPlansPurchaseRecommendationGeneration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ProvideAnomalyFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvideAnomalyFeedback operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvideAnomalyFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ProvideAnomalyFeedback">REST API Reference for ProvideAnomalyFeedback Operation</seealso>
        IAsyncResult BeginProvideAnomalyFeedback(ProvideAnomalyFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ProvideAnomalyFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvideAnomalyFeedback.</param>
        /// 
        /// <returns>Returns a  ProvideAnomalyFeedbackResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/ProvideAnomalyFeedback">REST API Reference for ProvideAnomalyFeedback Operation</seealso>
        ProvideAnomalyFeedbackResponse EndProvideAnomalyFeedback(IAsyncResult asyncResult);

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
        ///  <code>StartSavingsPlansPurchaseRecommendationGeneration</code> has no request syntax
        /// because no input parameters are needed to support this operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSavingsPlansPurchaseRecommendationGeneration service method.</param>
        /// 
        /// <returns>The response from the StartSavingsPlansPurchaseRecommendationGeneration service method, as returned by CostExplorer.</returns>
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
        /// Initiates the asynchronous execution of the StartSavingsPlansPurchaseRecommendationGeneration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSavingsPlansPurchaseRecommendationGeneration operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSavingsPlansPurchaseRecommendationGeneration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/StartSavingsPlansPurchaseRecommendationGeneration">REST API Reference for StartSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        IAsyncResult BeginStartSavingsPlansPurchaseRecommendationGeneration(StartSavingsPlansPurchaseRecommendationGenerationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSavingsPlansPurchaseRecommendationGeneration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSavingsPlansPurchaseRecommendationGeneration.</param>
        /// 
        /// <returns>Returns a  StartSavingsPlansPurchaseRecommendationGenerationResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/StartSavingsPlansPurchaseRecommendationGeneration">REST API Reference for StartSavingsPlansPurchaseRecommendationGeneration Operation</seealso>
        StartSavingsPlansPurchaseRecommendationGenerationResponse EndStartSavingsPlansPurchaseRecommendationGeneration(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// An API operation for adding one or more tags (key-value pairs) to a resource.
        /// 
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> operation with a resource that already has
        /// tags. If you specify a new tag key for the resource, this tag is appended to the list
        /// of tags associated with the resource. If you specify a tag key that is already associated
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateAnomalyMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyMonitor operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnomalyMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateAnomalyMonitor">REST API Reference for UpdateAnomalyMonitor Operation</seealso>
        IAsyncResult BeginUpdateAnomalyMonitor(UpdateAnomalyMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnomalyMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnomalyMonitor.</param>
        /// 
        /// <returns>Returns a  UpdateAnomalyMonitorResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateAnomalyMonitor">REST API Reference for UpdateAnomalyMonitor Operation</seealso>
        UpdateAnomalyMonitorResponse EndUpdateAnomalyMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAnomalySubscription


        /// <summary>
        /// Updates an existing cost anomaly monitor subscription.
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
        /// Initiates the asynchronous execution of the UpdateAnomalySubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalySubscription operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnomalySubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateAnomalySubscription">REST API Reference for UpdateAnomalySubscription Operation</seealso>
        IAsyncResult BeginUpdateAnomalySubscription(UpdateAnomalySubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnomalySubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnomalySubscription.</param>
        /// 
        /// <returns>Returns a  UpdateAnomalySubscriptionResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateAnomalySubscription">REST API Reference for UpdateAnomalySubscription Operation</seealso>
        UpdateAnomalySubscriptionResponse EndUpdateAnomalySubscription(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateCostAllocationTagsStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCostAllocationTagsStatus operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCostAllocationTagsStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateCostAllocationTagsStatus">REST API Reference for UpdateCostAllocationTagsStatus Operation</seealso>
        IAsyncResult BeginUpdateCostAllocationTagsStatus(UpdateCostAllocationTagsStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCostAllocationTagsStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCostAllocationTagsStatus.</param>
        /// 
        /// <returns>Returns a  UpdateCostAllocationTagsStatusResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateCostAllocationTagsStatus">REST API Reference for UpdateCostAllocationTagsStatus Operation</seealso>
        UpdateCostAllocationTagsStatusResponse EndUpdateCostAllocationTagsStatus(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateCostCategoryDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCostCategoryDefinition operation on AmazonCostExplorerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCostCategoryDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateCostCategoryDefinition">REST API Reference for UpdateCostCategoryDefinition Operation</seealso>
        IAsyncResult BeginUpdateCostCategoryDefinition(UpdateCostCategoryDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCostCategoryDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCostCategoryDefinition.</param>
        /// 
        /// <returns>Returns a  UpdateCostCategoryDefinitionResult from CostExplorer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/UpdateCostCategoryDefinition">REST API Reference for UpdateCostCategoryDefinition Operation</seealso>
        UpdateCostCategoryDefinitionResponse EndUpdateCostCategoryDefinition(IAsyncResult asyncResult);

        #endregion
        
    }
}