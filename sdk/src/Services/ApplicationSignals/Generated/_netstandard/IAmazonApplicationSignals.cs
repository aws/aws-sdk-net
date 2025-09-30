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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetServiceLevelObjectiveBudgetReport service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/BatchGetServiceLevelObjectiveBudgetReport">REST API Reference for BatchGetServiceLevelObjectiveBudgetReport Operation</seealso>
        Task<BatchGetServiceLevelObjectiveBudgetReportResponse> BatchGetServiceLevelObjectiveBudgetReportAsync(BatchGetServiceLevelObjectiveBudgetReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdateExclusionWindows



        /// <summary>
        /// Add or remove time window exclusions for one or more Service Level Objectives (SLOs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateExclusionWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchUpdateExclusionWindowsResponse> BatchUpdateExclusionWindowsAsync(BatchUpdateExclusionWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateServiceLevelObjectiveResponse> CreateServiceLevelObjectiveAsync(CreateServiceLevelObjectiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGroupingConfiguration



        /// <summary>
        /// Deletes the grouping configuration for this account. This removes all custom grouping
        /// attribute definitions that were previously configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGroupingConfigurationResponse> DeleteGroupingConfigurationAsync(DeleteGroupingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServiceLevelObjective



        /// <summary>
        /// Deletes the specified service level objective.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLevelObjective service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteServiceLevelObjectiveResponse> DeleteServiceLevelObjectiveAsync(DeleteServiceLevelObjectiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetService



        /// <summary>
        /// Returns information about a service discovered by Application Signals.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetService service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/GetService">REST API Reference for GetService Operation</seealso>
        Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceLevelObjective



        /// <summary>
        /// Returns information about one SLO created in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLevelObjective service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServiceLevelObjectiveResponse> GetServiceLevelObjectiveAsync(GetServiceLevelObjectiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAuditFindings



        /// <summary>
        /// Returns a list of audit findings that provide automated analysis of service behavior
        /// and root cause analysis. These findings help identify the most significant observations
        /// about your services, including performance issues, anomalies, and potential problems.
        /// The findings are generated using heuristic algorithms based on established troubleshooting
        /// patterns.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAuditFindings service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        Task<ListAuditFindingsResponse> ListAuditFindingsAsync(ListAuditFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGroupingAttributeDefinitions



        /// <summary>
        /// Returns the current grouping configuration for this account, including all custom
        /// grouping attribute definitions that have been configured. These definitions determine
        /// how services are logically grouped based on telemetry attributes, Amazon Web Services
        /// tags, or predefined mappings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupingAttributeDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGroupingAttributeDefinitionsResponse> ListGroupingAttributeDefinitionsAsync(ListGroupingAttributeDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceDependencies



        /// <summary>
        /// Returns a list of service dependencies of the service that you specify. A dependency
        /// is an infrastructure component that an operation of this service connects with. Dependencies
        /// can include Amazon Web Services services, Amazon Web Services resources, and third-party
        /// services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceDependencies service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependencies">REST API Reference for ListServiceDependencies Operation</seealso>
        Task<ListServiceDependenciesResponse> ListServiceDependenciesAsync(ListServiceDependenciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceDependents



        /// <summary>
        /// Returns the list of dependents that invoked the specified service during the provided
        /// time range. Dependents include other services, CloudWatch Synthetics canaries, and
        /// clients that are instrumented with CloudWatch RUM app monitors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceDependents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceDependents service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceDependents">REST API Reference for ListServiceDependents Operation</seealso>
        Task<ListServiceDependentsResponse> ListServiceDependentsAsync(ListServiceDependentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceLevelObjectiveExclusionWindows



        /// <summary>
        /// Retrieves all exclusion windows configured for a specific SLO.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceLevelObjectiveExclusionWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListServiceLevelObjectiveExclusionWindowsResponse> ListServiceLevelObjectiveExclusionWindowsAsync(ListServiceLevelObjectiveExclusionWindowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceLevelObjectives



        /// <summary>
        /// Returns a list of SLOs created in this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceLevelObjectives service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceLevelObjectives service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceLevelObjectives">REST API Reference for ListServiceLevelObjectives Operation</seealso>
        Task<ListServiceLevelObjectivesResponse> ListServiceLevelObjectivesAsync(ListServiceLevelObjectivesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceOperations



        /// <summary>
        /// Returns a list of the <i>operations</i> of this service that have been discovered
        /// by Application Signals. Only the operations that were invoked during the specified
        /// time range are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceOperations service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceOperations">REST API Reference for ListServiceOperations Operation</seealso>
        Task<ListServiceOperationsResponse> ListServiceOperationsAsync(ListServiceOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServices



        /// <summary>
        /// Returns a list of services that have been discovered by Application Signals. A service
        /// represents a minimum logical and transactional unit that completes a business function.
        /// Services are discovered through Application Signals instrumentation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServices">REST API Reference for ListServices Operation</seealso>
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServiceStates



        /// <summary>
        /// Returns information about the last deployment and other change states of services.
        /// This API provides visibility into recent changes that may have affected service performance,
        /// helping with troubleshooting and change correlation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceStates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServiceStates service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ValidationException">
        /// The resource is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListServiceStates">REST API Reference for ListServiceStates Operation</seealso>
        Task<ListServiceStatesResponse> ListServiceStatesAsync(ListServiceStatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Displays the tags associated with a CloudWatch resource. Tags can be assigned to service
        /// level objectives.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutGroupingConfiguration



        /// <summary>
        /// Creates or updates the grouping configuration for this account. This operation allows
        /// you to define custom grouping attributes that determine how services are logically
        /// grouped based on telemetry attributes, Amazon Web Services tags, or predefined mappings.
        /// These grouping attributes can then be used to organize and filter services in the
        /// Application Signals console and APIs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutGroupingConfigurationResponse> PutGroupingConfigurationAsync(PutGroupingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartDiscoveryResponse> StartDiscoveryAsync(StartDiscoveryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ApplicationSignals.</returns>
        /// <exception cref="Amazon.ApplicationSignals.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationSignals.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-signals-2024-04-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateServiceLevelObjectiveResponse> UpdateServiceLevelObjectiveAsync(UpdateServiceLevelObjectiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonApplicationSignalsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonApplicationSignalsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonApplicationSignalsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonApplicationSignalsConfig to create AmazonApplicationSignalsClient");
            }

            return awsCredentials == null ? 
                    new AmazonApplicationSignalsClient(serviceClientConfig) :
                    new AmazonApplicationSignalsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}