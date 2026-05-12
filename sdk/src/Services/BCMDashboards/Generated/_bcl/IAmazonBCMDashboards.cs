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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BCMDashboards.Model;

#pragma warning disable CS1570
namespace Amazon.BCMDashboards
{
    /// <summary>
    /// <para>Interface for accessing BCMDashboards</para>
    ///
    /// Amazon Web Services Billing and Cost Management Dashboards is a service that enables
    /// you to create, manage, and share dashboards that combine multiple visualizations of
    /// your Amazon Web Services cost and usage data. You can combine multiple data sources
    /// including Cost Explorer, Savings Plans, and Reserved Instance metrics into unified
    /// dashboards, helping you analyze spending patterns and share cost insights across your
    /// organization.
    /// 
    ///  
    /// <para>
    /// You can use the Amazon Web Services Billing and Cost Management Dashboards API to
    /// programmatically create, manage, and share dashboards. This includes creating custom
    /// dashboards, configuring widgets, managing dashboard permissions, and sharing dashboards
    /// across accounts in your organization.
    /// </para>
    /// </summary>
    public partial interface IAmazonBCMDashboards : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBCMDashboardsPaginatorFactory Paginators { get; }

        
        #region  CreateDashboard


        /// <summary>
        /// Creates a new dashboard that can contain multiple widgets displaying cost and usage
        /// data. You can add custom widgets or use predefined widgets, arranging them in your
        /// preferred layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review the service quotas for Amazon Web
        /// Services Billing and Cost Management Dashboards and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        CreateDashboardResponse CreateDashboard(CreateDashboardRequest request);



        /// <summary>
        /// Creates a new dashboard that can contain multiple widgets displaying cost and usage
        /// data. You can add custom widgets or use predefined widgets, arranging them in your
        /// preferred layout.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review the service quotas for Amazon Web
        /// Services Billing and Cost Management Dashboards and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateDashboard">REST API Reference for CreateDashboard Operation</seealso>
        Task<CreateDashboardResponse> CreateDashboardAsync(CreateDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScheduledReport


        /// <summary>
        /// Creates a new scheduled report for a dashboard. A scheduled report automatically generates
        /// and delivers dashboard snapshots on a recurring schedule. Reports are delivered within
        /// 15 minutes of the scheduled delivery time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledReport service method.</param>
        /// 
        /// <returns>The response from the CreateScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review the service quotas for Amazon Web
        /// Services Billing and Cost Management Dashboards and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateScheduledReport">REST API Reference for CreateScheduledReport Operation</seealso>
        CreateScheduledReportResponse CreateScheduledReport(CreateScheduledReportRequest request);



        /// <summary>
        /// Creates a new scheduled report for a dashboard. A scheduled report automatically generates
        /// and delivers dashboard snapshots on a recurring schedule. Reports are delivered within
        /// 15 minutes of the scheduled delivery time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota. Review the service quotas for Amazon Web
        /// Services Billing and Cost Management Dashboards and retry your request.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/CreateScheduledReport">REST API Reference for CreateScheduledReport Operation</seealso>
        Task<CreateScheduledReportResponse> CreateScheduledReportAsync(CreateScheduledReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDashboard


        /// <summary>
        /// Deletes a specified dashboard. This action cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        DeleteDashboardResponse DeleteDashboard(DeleteDashboardRequest request);



        /// <summary>
        /// Deletes a specified dashboard. This action cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteDashboard">REST API Reference for DeleteDashboard Operation</seealso>
        Task<DeleteDashboardResponse> DeleteDashboardAsync(DeleteDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteScheduledReport


        /// <summary>
        /// Deletes a specified scheduled report. This is an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledReport service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteScheduledReport">REST API Reference for DeleteScheduledReport Operation</seealso>
        DeleteScheduledReportResponse DeleteScheduledReport(DeleteScheduledReportRequest request);



        /// <summary>
        /// Deletes a specified scheduled report. This is an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/DeleteScheduledReport">REST API Reference for DeleteScheduledReport Operation</seealso>
        Task<DeleteScheduledReportResponse> DeleteScheduledReportAsync(DeleteScheduledReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecuteScheduledReport


        /// <summary>
        /// Triggers an immediate execution of a scheduled report, outside of its regular schedule.
        /// The scheduled report must be in <c>ENABLED</c> state. Calling this operation on a
        /// <c>DISABLED</c> scheduled report returns a <c>ValidationException</c>.
        /// 
        ///  <note> 
        /// <para>
        /// If a <c>clientToken</c> is provided, the service uses it for idempotency. Requests
        /// with the same client token will not trigger a new execution within the same minute.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteScheduledReport service method.</param>
        /// 
        /// <returns>The response from the ExecuteScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ExecuteScheduledReport">REST API Reference for ExecuteScheduledReport Operation</seealso>
        ExecuteScheduledReportResponse ExecuteScheduledReport(ExecuteScheduledReportRequest request);



        /// <summary>
        /// Triggers an immediate execution of a scheduled report, outside of its regular schedule.
        /// The scheduled report must be in <c>ENABLED</c> state. Calling this operation on a
        /// <c>DISABLED</c> scheduled report returns a <c>ValidationException</c>.
        /// 
        ///  <note> 
        /// <para>
        /// If a <c>clientToken</c> is provided, the service uses it for idempotency. Requests
        /// with the same client token will not trigger a new execution within the same minute.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ExecuteScheduledReport">REST API Reference for ExecuteScheduledReport Operation</seealso>
        Task<ExecuteScheduledReportResponse> ExecuteScheduledReportAsync(ExecuteScheduledReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDashboard


        /// <summary>
        /// Retrieves the configuration and metadata of a specified dashboard, including its widgets
        /// and layout settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// 
        /// <returns>The response from the GetDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        GetDashboardResponse GetDashboard(GetDashboardRequest request);



        /// <summary>
        /// Retrieves the configuration and metadata of a specified dashboard, including its widgets
        /// and layout settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetDashboard">REST API Reference for GetDashboard Operation</seealso>
        Task<GetDashboardResponse> GetDashboardAsync(GetDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Retrieves the resource-based policy attached to a dashboard, showing sharing configurations
        /// and permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);



        /// <summary>
        /// Retrieves the resource-based policy attached to a dashboard, showing sharing configurations
        /// and permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetScheduledReport


        /// <summary>
        /// Retrieves the configuration and metadata of a specified scheduled report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduledReport service method.</param>
        /// 
        /// <returns>The response from the GetScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetScheduledReport">REST API Reference for GetScheduledReport Operation</seealso>
        GetScheduledReportResponse GetScheduledReport(GetScheduledReportRequest request);



        /// <summary>
        /// Retrieves the configuration and metadata of a specified scheduled report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/GetScheduledReport">REST API Reference for GetScheduledReport Operation</seealso>
        Task<GetScheduledReportResponse> GetScheduledReportAsync(GetScheduledReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDashboards


        /// <summary>
        /// Returns a list of all dashboards in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        ListDashboardsResponse ListDashboards(ListDashboardsRequest request);



        /// <summary>
        /// Returns a list of all dashboards in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDashboards service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDashboards service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListDashboards">REST API Reference for ListDashboards Operation</seealso>
        Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListScheduledReports


        /// <summary>
        /// Returns a list of scheduled reports in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledReports service method.</param>
        /// 
        /// <returns>The response from the ListScheduledReports service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListScheduledReports">REST API Reference for ListScheduledReports Operation</seealso>
        ListScheduledReportsResponse ListScheduledReports(ListScheduledReportsRequest request);



        /// <summary>
        /// Returns a list of scheduled reports in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduledReports service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListScheduledReports">REST API Reference for ListScheduledReports Operation</seealso>
        Task<ListScheduledReportsResponse> ListScheduledReportsAsync(ListScheduledReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of all tags associated with a specified dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of all tags associated with a specified dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a specified dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or updates tags for a specified dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes specified tags from a dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes specified tags from a dashboard resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDashboard


        /// <summary>
        /// Updates an existing dashboard's properties, including its name, description, and widget
        /// configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        UpdateDashboardResponse UpdateDashboard(UpdateDashboardRequest request);



        /// <summary>
        /// Updates an existing dashboard's properties, including its name, description, and widget
        /// configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDashboard service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDashboard service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateDashboard">REST API Reference for UpdateDashboard Operation</seealso>
        Task<UpdateDashboardResponse> UpdateDashboardAsync(UpdateDashboardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateScheduledReport


        /// <summary>
        /// Updates an existing scheduled report's properties, including its name, description,
        /// schedule configuration, and widget settings. Only the parameters included in the request
        /// are updated; all other properties remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledReport service method.</param>
        /// 
        /// <returns>The response from the UpdateScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateScheduledReport">REST API Reference for UpdateScheduledReport Operation</seealso>
        UpdateScheduledReportResponse UpdateScheduledReport(UpdateScheduledReportRequest request);



        /// <summary>
        /// Updates an existing scheduled report's properties, including its name, description,
        /// schedule configuration, and widget settings. Only the parameters included in the request
        /// are updated; all other properties remain unchanged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScheduledReport service method, as returned by BCMDashboards.</returns>
        /// <exception cref="Amazon.BCMDashboards.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action. Verify your IAM permissions
        /// and any resource policies.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. For example, attempting to create a resource that already exists or is being
        /// created.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.InternalServerException">
        /// An internal error occurred while processing the request. Retry your request. If the
        /// problem persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ResourceNotFoundException">
        /// The specified resource (dashboard, policy, or widget) was not found. Verify the ARN
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ThrottlingException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and use exponential backoff.
        /// </exception>
        /// <exception cref="Amazon.BCMDashboards.Model.ValidationException">
        /// The input parameters do not satisfy the requirements. Check the error message for
        /// specific validation details.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bcm-dashboards-2025-08-18/UpdateScheduledReport">REST API Reference for UpdateScheduledReport Operation</seealso>
        Task<UpdateScheduledReportResponse> UpdateScheduledReportAsync(UpdateScheduledReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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