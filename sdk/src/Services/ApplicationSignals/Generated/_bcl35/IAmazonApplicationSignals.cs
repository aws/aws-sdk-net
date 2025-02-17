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

using Amazon.Runtime;
using Amazon.ApplicationSignals.Model;

#pragma warning disable CS1570
namespace Amazon.ApplicationSignals
{
    /// <summary>
    /// <para>Interface for accessing ApplicationSignals</para>
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
    public partial interface IAmazonApplicationSignals : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IApplicationSignalsPaginatorFactory Paginators { get; }
#endif


        
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
        BatchGetServiceLevelObjectiveBudgetReportResponse BatchGetServiceLevelObjectiveBudgetReport(BatchGetServiceLevelObjectiveBudgetReportRequest request);

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
        IAsyncResult BeginBatchGetServiceLevelObjectiveBudgetReport(BatchGetServiceLevelObjectiveBudgetReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetServiceLevelObjectiveBudgetReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetServiceLevelObjectiveBudgetReport.</param>
        /// 
        /// <returns>Returns a  BatchGetServiceLevelObjectiveBudgetReportResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/BatchGetServiceLevelObjectiveBudgetReport">REST API Reference for BatchGetServiceLevelObjectiveBudgetReport Operation</seealso>
        BatchGetServiceLevelObjectiveBudgetReportResponse EndBatchGetServiceLevelObjectiveBudgetReport(IAsyncResult asyncResult);

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
        ///  
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
        CreateServiceLevelObjectiveResponse CreateServiceLevelObjective(CreateServiceLevelObjectiveRequest request);

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
        IAsyncResult BeginCreateServiceLevelObjective(CreateServiceLevelObjectiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceLevelObjective.</param>
        /// 
        /// <returns>Returns a  CreateServiceLevelObjectiveResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/CreateServiceLevelObjective">REST API Reference for CreateServiceLevelObjective Operation</seealso>
        CreateServiceLevelObjectiveResponse EndCreateServiceLevelObjective(IAsyncResult asyncResult);

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
        DeleteServiceLevelObjectiveResponse DeleteServiceLevelObjective(DeleteServiceLevelObjectiveRequest request);

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
        IAsyncResult BeginDeleteServiceLevelObjective(DeleteServiceLevelObjectiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceLevelObjective.</param>
        /// 
        /// <returns>Returns a  DeleteServiceLevelObjectiveResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/DeleteServiceLevelObjective">REST API Reference for DeleteServiceLevelObjective Operation</seealso>
        DeleteServiceLevelObjectiveResponse EndDeleteServiceLevelObjective(IAsyncResult asyncResult);

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
        GetServiceResponse GetService(GetServiceRequest request);

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
        IAsyncResult BeginGetService(GetServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetService.</param>
        /// 
        /// <returns>Returns a  GetServiceResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse EndGetService(IAsyncResult asyncResult);

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
        GetServiceLevelObjectiveResponse GetServiceLevelObjective(GetServiceLevelObjectiveRequest request);

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
        IAsyncResult BeginGetServiceLevelObjective(GetServiceLevelObjectiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceLevelObjective.</param>
        /// 
        /// <returns>Returns a  GetServiceLevelObjectiveResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetServiceLevelObjective">REST API Reference for GetServiceLevelObjective Operation</seealso>
        GetServiceLevelObjectiveResponse EndGetServiceLevelObjective(IAsyncResult asyncResult);

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
        ListServiceDependenciesResponse ListServiceDependencies(ListServiceDependenciesRequest request);

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
        IAsyncResult BeginListServiceDependencies(ListServiceDependenciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceDependencies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceDependencies.</param>
        /// 
        /// <returns>Returns a  ListServiceDependenciesResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependencies">REST API Reference for ListServiceDependencies Operation</seealso>
        ListServiceDependenciesResponse EndListServiceDependencies(IAsyncResult asyncResult);

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
        ListServiceDependentsResponse ListServiceDependents(ListServiceDependentsRequest request);

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
        IAsyncResult BeginListServiceDependents(ListServiceDependentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceDependents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceDependents.</param>
        /// 
        /// <returns>Returns a  ListServiceDependentsResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependents">REST API Reference for ListServiceDependents Operation</seealso>
        ListServiceDependentsResponse EndListServiceDependents(IAsyncResult asyncResult);

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
        ListServiceLevelObjectivesResponse ListServiceLevelObjectives(ListServiceLevelObjectivesRequest request);

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
        IAsyncResult BeginListServiceLevelObjectives(ListServiceLevelObjectivesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceLevelObjectives operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceLevelObjectives.</param>
        /// 
        /// <returns>Returns a  ListServiceLevelObjectivesResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceLevelObjectives">REST API Reference for ListServiceLevelObjectives Operation</seealso>
        ListServiceLevelObjectivesResponse EndListServiceLevelObjectives(IAsyncResult asyncResult);

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
        ListServiceOperationsResponse ListServiceOperations(ListServiceOperationsRequest request);

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
        IAsyncResult BeginListServiceOperations(ListServiceOperationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceOperations.</param>
        /// 
        /// <returns>Returns a  ListServiceOperationsResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceOperations">REST API Reference for ListServiceOperations Operation</seealso>
        ListServiceOperationsResponse EndListServiceOperations(IAsyncResult asyncResult);

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
        ListServicesResponse ListServices(ListServicesRequest request);

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
        IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse EndListServices(IAsyncResult asyncResult);

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

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
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        StartDiscoveryResponse StartDiscovery(StartDiscoveryRequest request);

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
        IAsyncResult BeginStartDiscovery(StartDiscoveryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDiscovery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDiscovery.</param>
        /// 
        /// <returns>Returns a  StartDiscoveryResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/StartDiscovery">REST API Reference for StartDiscovery Operation</seealso>
        StartDiscoveryResponse EndStartDiscovery(IAsyncResult asyncResult);

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
        TagResourceResponse TagResource(TagResourceRequest request);

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
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

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
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        UpdateServiceLevelObjectiveResponse UpdateServiceLevelObjective(UpdateServiceLevelObjectiveRequest request);

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
        IAsyncResult BeginUpdateServiceLevelObjective(UpdateServiceLevelObjectiveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceLevelObjective operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceLevelObjective.</param>
        /// 
        /// <returns>Returns a  UpdateServiceLevelObjectiveResult from ApplicationSignals.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UpdateServiceLevelObjective">REST API Reference for UpdateServiceLevelObjective Operation</seealso>
        UpdateServiceLevelObjectiveResponse EndUpdateServiceLevelObjective(IAsyncResult asyncResult);

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