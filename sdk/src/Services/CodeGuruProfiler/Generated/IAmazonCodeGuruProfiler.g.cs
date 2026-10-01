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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.CodeGuruProfiler.Model;

#pragma warning disable CS1570

namespace Amazon.CodeGuruProfiler
{
    /// <summary>
    /// <para>Interface for accessing CodeGuruProfiler</para>
    ///
    /// This section provides documentation for the Amazon CodeGuru Profiler API operations.
    /// 
    /// 
    ///  
    /// <para>
    ///  Amazon CodeGuru Profiler collects runtime performance data from your live applications,
    /// and provides recommendations that can help you fine-tune your application performance.
    /// Using machine learning algorithms, CodeGuru Profiler can help you find your most expensive
    /// lines of code and suggest ways you can improve efficiency and remove CPU bottlenecks.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  Amazon CodeGuru Profiler provides different visualizations of profiling data to help
    /// you identify what code is running on the CPU, see how much time is consumed, and suggest
    /// ways to reduce CPU utilization. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon CodeGuru Profiler currently supports applications written in all Java virtual
    /// machine (JVM) languages and Python. While CodeGuru Profiler supports both visualizations
    /// and recommendations for applications written in Java, it can also generate visualizations
    /// and a subset of recommendations for applications written in other JVM languages and
    /// Python.
    /// </para>
    ///  </note> 
    /// <para>
    ///  For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/what-is-codeguru-profiler.html">What
    /// is Amazon CodeGuru Profiler</a> in the <i>Amazon CodeGuru Profiler User Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeGuruProfiler : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICodeGuruProfilerPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Add up to 2 anomaly notifications channels for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddNotificationChannels service method.</param>
        /// <returns>The response from the AddNotificationChannels service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">Service
        /// Quotas</a> to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/AddNotificationChannels">REST API Reference for AddNotificationChannels Operation</seealso>
        AddNotificationChannelsResponse AddNotificationChannels(AddNotificationChannelsRequest request);
#endif

        /// <summary>
        /// Add up to 2 anomaly notifications channels for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddNotificationChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AddNotificationChannels service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">Service
        /// Quotas</a> to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/AddNotificationChannels">REST API Reference for AddNotificationChannels Operation</seealso>
        Task<AddNotificationChannelsResponse> AddNotificationChannelsAsync(AddNotificationChannelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the time series of values for a requested list of frame metrics from a time
        /// period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFrameMetricData service method.</param>
        /// <returns>The response from the BatchGetFrameMetricData service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/BatchGetFrameMetricData">REST API Reference for BatchGetFrameMetricData Operation</seealso>
        BatchGetFrameMetricDataResponse BatchGetFrameMetricData(BatchGetFrameMetricDataRequest request);
#endif

        /// <summary>
        /// Returns the time series of values for a requested list of frame metrics from a time
        /// period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFrameMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the BatchGetFrameMetricData service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/BatchGetFrameMetricData">REST API Reference for BatchGetFrameMetricData Operation</seealso>
        Task<BatchGetFrameMetricDataResponse> BatchGetFrameMetricDataAsync(BatchGetFrameMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Used by profiler agents to report their current state and to receive remote configuration
        /// updates. For example, <c>ConfigureAgent</c> can be used to tell an agent whether to
        /// profile or not and for how long to return profiling data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAgent service method.</param>
        /// <returns>The response from the ConfigureAgent service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        ConfigureAgentResponse ConfigureAgent(ConfigureAgentRequest request);
#endif

        /// <summary>
        /// Used by profiler agents to report their current state and to receive remote configuration
        /// updates. For example, <c>ConfigureAgent</c> can be used to tell an agent whether to
        /// profile or not and for how long to return profiling data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ConfigureAgent service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        Task<ConfigureAgentResponse> ConfigureAgentAsync(ConfigureAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfilingGroup service method.</param>
        /// <returns>The response from the CreateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">Service
        /// Quotas</a> to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        CreateProfilingGroupResponse CreateProfilingGroup(CreateProfilingGroupRequest request);
#endif

        /// <summary>
        /// Creates a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfilingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/intro.html">Service
        /// Quotas</a> to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        Task<CreateProfilingGroupResponse> CreateProfilingGroupAsync(CreateProfilingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfilingGroup service method.</param>
        /// <returns>The response from the DeleteProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        DeleteProfilingGroupResponse DeleteProfilingGroup(DeleteProfilingGroupRequest request);
#endif

        /// <summary>
        /// Deletes a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfilingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        Task<DeleteProfilingGroupResponse> DeleteProfilingGroupAsync(DeleteProfilingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <c>ProfilingGroupDescription</c> </a> object that contains information about the requested
        /// profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfilingGroup service method.</param>
        /// <returns>The response from the DescribeProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        DescribeProfilingGroupResponse DescribeProfilingGroup(DescribeProfilingGroupRequest request);
#endif

        /// <summary>
        /// Returns a <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <c>ProfilingGroupDescription</c> </a> object that contains information about the requested
        /// profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfilingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        Task<DescribeProfilingGroupResponse> DescribeProfilingGroupAsync(DescribeProfilingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_FindingsReportSummary.html">
        /// <c>FindingsReportSummary</c> </a> objects that contain analysis results for all profiling
        /// groups in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportAccountSummary service method.</param>
        /// <returns>The response from the GetFindingsReportAccountSummary service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetFindingsReportAccountSummary">REST API Reference for GetFindingsReportAccountSummary Operation</seealso>
        GetFindingsReportAccountSummaryResponse GetFindingsReportAccountSummary(GetFindingsReportAccountSummaryRequest request);
#endif

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_FindingsReportSummary.html">
        /// <c>FindingsReportSummary</c> </a> objects that contain analysis results for all profiling
        /// groups in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsReportAccountSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetFindingsReportAccountSummary service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetFindingsReportAccountSummary">REST API Reference for GetFindingsReportAccountSummary Operation</seealso>
        Task<GetFindingsReportAccountSummaryResponse> GetFindingsReportAccountSummaryAsync(GetFindingsReportAccountSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get the current configuration for anomaly notifications for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request);
#endif

        /// <summary>
        /// Get the current configuration for anomaly notifications for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotificationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetNotificationConfiguration service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetNotificationConfiguration">REST API Reference for GetNotificationConfiguration Operation</seealso>
        Task<GetNotificationConfigurationResponse> GetNotificationConfigurationAsync(GetNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the JSON-formatted resource-based policy on a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <returns>The response from the GetPolicy service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);
#endif

        /// <summary>
        /// Returns the JSON-formatted resource-based policy on a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPolicy service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets the aggregated profile of a profiling group for a specified time range. Amazon
        /// CodeGuru Profiler collects posted agent profiles for a profiling group into aggregated
        /// profiles. 
        /// 
        ///  <note> 
        /// <para>
        ///  Because aggregated profiles expire over time <c>GetProfile</c> is not idempotent.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        ///  Specify the time range for the requested aggregated profile using 1 or 2 of the following
        /// parameters: <c>startTime</c>, <c>endTime</c>, <c>period</c>. The maximum time range
        /// allowed is 7 days. If you specify all 3 parameters, an exception is thrown. If you
        /// specify only <c>period</c>, the latest aggregated profile is returned. 
        /// </para>
        ///  
        /// <para>
        ///  Aggregated profiles are available with aggregation periods of 5 minutes, 1 hour,
        /// and 1 day, aligned to UTC. The aggregation period of an aggregated profile determines
        /// how long it is retained. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_AggregatedProfileTime.html">
        /// <c>AggregatedProfileTime</c> </a>. The aggregated profile's aggregation period determines
        /// how long it is retained by CodeGuru Profiler. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If the aggregation period is 5 minutes, the aggregated profile is retained for 15
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the aggregation period is 1 hour, the aggregated profile is retained for 60 days.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the aggregation period is 1 day, the aggregated profile is retained for 3 years.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// There are two use cases for calling <c>GetProfile</c>.
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  If you want to return an aggregated profile that already exists, use <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ListProfileTimes.html">
        /// <c>ListProfileTimes</c> </a> to view the time ranges of existing aggregated profiles.
        /// Use them in a <c>GetProfile</c> request to return a specific, existing aggregated
        /// profile. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you want to return an aggregated profile for a time range that doesn't align with
        /// an existing aggregated profile, then CodeGuru Profiler makes a best effort to combine
        /// existing aggregated profiles from the requested time range and return them as one
        /// aggregated profile. 
        /// </para>
        ///  
        /// <para>
        ///  If aggregated profiles do not exist for the full time range requested, then aggregated
        /// profiles for a smaller time range are returned. For example, if the requested time
        /// range is from 00:00 to 00:20, and the existing aggregated profiles are from 00:15
        /// and 00:25, then the aggregated profiles from 00:15 to 00:20 are returned. 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <returns>The response from the GetProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        GetProfileResponse GetProfile(GetProfileRequest request);
#endif

        /// <summary>
        /// Gets the aggregated profile of a profiling group for a specified time range. Amazon
        /// CodeGuru Profiler collects posted agent profiles for a profiling group into aggregated
        /// profiles. 
        /// 
        ///  <note> 
        /// <para>
        ///  Because aggregated profiles expire over time <c>GetProfile</c> is not idempotent.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        ///  Specify the time range for the requested aggregated profile using 1 or 2 of the following
        /// parameters: <c>startTime</c>, <c>endTime</c>, <c>period</c>. The maximum time range
        /// allowed is 7 days. If you specify all 3 parameters, an exception is thrown. If you
        /// specify only <c>period</c>, the latest aggregated profile is returned. 
        /// </para>
        ///  
        /// <para>
        ///  Aggregated profiles are available with aggregation periods of 5 minutes, 1 hour,
        /// and 1 day, aligned to UTC. The aggregation period of an aggregated profile determines
        /// how long it is retained. For more information, see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_AggregatedProfileTime.html">
        /// <c>AggregatedProfileTime</c> </a>. The aggregated profile's aggregation period determines
        /// how long it is retained by CodeGuru Profiler. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If the aggregation period is 5 minutes, the aggregated profile is retained for 15
        /// days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the aggregation period is 1 hour, the aggregated profile is retained for 60 days.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the aggregation period is 1 day, the aggregated profile is retained for 3 years.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// There are two use cases for calling <c>GetProfile</c>.
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  If you want to return an aggregated profile that already exists, use <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ListProfileTimes.html">
        /// <c>ListProfileTimes</c> </a> to view the time ranges of existing aggregated profiles.
        /// Use them in a <c>GetProfile</c> request to return a specific, existing aggregated
        /// profile. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you want to return an aggregated profile for a time range that doesn't align with
        /// an existing aggregated profile, then CodeGuru Profiler makes a best effort to combine
        /// existing aggregated profiles from the requested time range and return them as one
        /// aggregated profile. 
        /// </para>
        ///  
        /// <para>
        ///  If aggregated profiles do not exist for the full time range requested, then aggregated
        /// profiles for a smaller time range are returned. For example, if the requested time
        /// range is from 00:00 to 00:20, and the existing aggregated profiles are from 00:15
        /// and 00:25, then the aggregated profiles from 00:15 to 00:20 are returned. 
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_Recommendation.html">
        /// <c>Recommendation</c> </a> objects that contain recommendations for a profiling group
        /// for a given time period. A list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_Anomaly.html">
        /// <c>Anomaly</c> </a> objects that contains details about anomalies detected in the
        /// profiling group for the same time period is also returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// <returns>The response from the GetRecommendations service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        GetRecommendationsResponse GetRecommendations(GetRecommendationsRequest request);
#endif

        /// <summary>
        /// Returns a list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_Recommendation.html">
        /// <c>Recommendation</c> </a> objects that contain recommendations for a profiling group
        /// for a given time period. A list of <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_Anomaly.html">
        /// <c>Anomaly</c> </a> objects that contains details about anomalies detected in the
        /// profiling group for the same time period is also returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRecommendations service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetRecommendations">REST API Reference for GetRecommendations Operation</seealso>
        Task<GetRecommendationsResponse> GetRecommendationsAsync(GetRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the available reports for a given profiling group and time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsReports service method.</param>
        /// <returns>The response from the ListFindingsReports service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListFindingsReports">REST API Reference for ListFindingsReports Operation</seealso>
        ListFindingsReportsResponse ListFindingsReports(ListFindingsReportsRequest request);
#endif

        /// <summary>
        /// List the available reports for a given profiling group and time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindingsReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFindingsReports service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListFindingsReports">REST API Reference for ListFindingsReports Operation</seealso>
        Task<ListFindingsReportsResponse> ListFindingsReportsAsync(ListFindingsReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the start times of the available aggregated profiles of a profiling group for
        /// an aggregation period within the specified time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileTimes service method.</param>
        /// <returns>The response from the ListProfileTimes service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        ListProfileTimesResponse ListProfileTimes(ListProfileTimesRequest request);
#endif

        /// <summary>
        /// Lists the start times of the available aggregated profiles of a profiling group for
        /// an aggregation period within the specified time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileTimes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProfileTimes service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        Task<ListProfileTimesResponse> ListProfileTimesAsync(ListProfileTimesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of profiling groups. The profiling groups are returned as <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <c>ProfilingGroupDescription</c> </a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfilingGroups service method.</param>
        /// <returns>The response from the ListProfilingGroups service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        ListProfilingGroupsResponse ListProfilingGroups(ListProfilingGroupsRequest request);
#endif

        /// <summary>
        /// Returns a list of profiling groups. The profiling groups are returned as <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingGroupDescription.html">
        /// <c>ProfilingGroupDescription</c> </a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfilingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProfilingGroups service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        Task<ListProfilingGroupsResponse> ListProfilingGroupsAsync(ListProfilingGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of the tags that are assigned to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Returns a list of the tags that are assigned to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Submits profiling data to an aggregated profile of a profiling group. To get an aggregated
        /// profile that is created with this profiling data, use <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_GetProfile.html">
        /// <c>GetProfile</c> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostAgentProfile service method.</param>
        /// <returns>The response from the PostAgentProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        PostAgentProfileResponse PostAgentProfile(PostAgentProfileRequest request);
#endif

        /// <summary>
        /// Submits profiling data to an aggregated profile of a profiling group. To get an aggregated
        /// profile that is created with this profiling data, use <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_GetProfile.html">
        /// <c>GetProfile</c> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostAgentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PostAgentProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        Task<PostAgentProfileResponse> PostAgentProfileAsync(PostAgentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds permissions to a profiling group's resource-based policy that are provided using
        /// an action group. If a profiling group doesn't have a resource-based policy, one is
        /// created for it using the permissions in the action group and the roles and users in
        /// the <c>principals</c> parameter. 
        /// 
        ///  
        /// <para>
        ///  The one supported action group that can be added is <c>agentPermission</c> which
        /// grants <c>ConfigureAgent</c> and <c>PostAgent</c> permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/resource-based-policies.html">Resource-based
        /// policies in CodeGuru Profiler</a> in the <i>Amazon CodeGuru Profiler User Guide</i>,
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
        /// <c>ConfigureAgent</c> </a>, and <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_PostAgentProfile.html">
        /// <c>PostAgentProfile</c> </a>. 
        /// </para>
        ///  
        /// <para>
        ///  The first time you call <c>PutPermission</c> on a profiling group, do not specify
        /// a <c>revisionId</c> because it doesn't have a resource-based policy. Subsequent calls
        /// must provide a <c>revisionId</c> to specify which revision of the resource-based policy
        /// to add the permissions to. 
        /// </para>
        ///  
        /// <para>
        ///  The response contains the profiling group's JSON-formatted resource policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// <returns>The response from the PutPermission service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PutPermission">REST API Reference for PutPermission Operation</seealso>
        PutPermissionResponse PutPermission(PutPermissionRequest request);
#endif

        /// <summary>
        /// Adds permissions to a profiling group's resource-based policy that are provided using
        /// an action group. If a profiling group doesn't have a resource-based policy, one is
        /// created for it using the permissions in the action group and the roles and users in
        /// the <c>principals</c> parameter. 
        /// 
        ///  
        /// <para>
        ///  The one supported action group that can be added is <c>agentPermission</c> which
        /// grants <c>ConfigureAgent</c> and <c>PostAgent</c> permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/resource-based-policies.html">Resource-based
        /// policies in CodeGuru Profiler</a> in the <i>Amazon CodeGuru Profiler User Guide</i>,
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
        /// <c>ConfigureAgent</c> </a>, and <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_PostAgentProfile.html">
        /// <c>PostAgentProfile</c> </a>. 
        /// </para>
        ///  
        /// <para>
        ///  The first time you call <c>PutPermission</c> on a profiling group, do not specify
        /// a <c>revisionId</c> because it doesn't have a resource-based policy. Subsequent calls
        /// must provide a <c>revisionId</c> to specify which revision of the resource-based policy
        /// to add the permissions to. 
        /// </para>
        ///  
        /// <para>
        ///  The response contains the profiling group's JSON-formatted resource policy. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutPermission service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PutPermission">REST API Reference for PutPermission Operation</seealso>
        Task<PutPermissionResponse> PutPermissionAsync(PutPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Remove one anomaly notifications channel for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveNotificationChannel service method.</param>
        /// <returns>The response from the RemoveNotificationChannel service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        RemoveNotificationChannelResponse RemoveNotificationChannel(RemoveNotificationChannelRequest request);
#endif

        /// <summary>
        /// Remove one anomaly notifications channel for a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveNotificationChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RemoveNotificationChannel service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemoveNotificationChannel">REST API Reference for RemoveNotificationChannel Operation</seealso>
        Task<RemoveNotificationChannelResponse> RemoveNotificationChannelAsync(RemoveNotificationChannelRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes permissions from a profiling group's resource-based policy that are provided
        /// using an action group. The one supported action group that can be removed is <c>agentPermission</c>
        /// which grants <c>ConfigureAgent</c> and <c>PostAgent</c> permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/resource-based-policies.html">Resource-based
        /// policies in CodeGuru Profiler</a> in the <i>Amazon CodeGuru Profiler User Guide</i>,
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
        /// <c>ConfigureAgent</c> </a>, and <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_PostAgentProfile.html">
        /// <c>PostAgentProfile</c> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// <returns>The response from the RemovePermission service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);
#endif

        /// <summary>
        /// Removes permissions from a profiling group's resource-based policy that are provided
        /// using an action group. The one supported action group that can be removed is <c>agentPermission</c>
        /// which grants <c>ConfigureAgent</c> and <c>PostAgent</c> permissions. For more information,
        /// see <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-ug/resource-based-policies.html">Resource-based
        /// policies in CodeGuru Profiler</a> in the <i>Amazon CodeGuru Profiler User Guide</i>,
        /// <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ConfigureAgent.html">
        /// <c>ConfigureAgent</c> </a>, and <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_PostAgentProfile.html">
        /// <c>PostAgentProfile</c> </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RemovePermission service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Sends feedback to CodeGuru Profiler about whether the anomaly detected by the analysis
        /// is useful or not.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// <returns>The response from the SubmitFeedback service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        SubmitFeedbackResponse SubmitFeedback(SubmitFeedbackRequest request);
#endif

        /// <summary>
        /// Sends feedback to CodeGuru Profiler about whether the anomaly detected by the analysis
        /// is useful or not.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SubmitFeedback service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/SubmitFeedback">REST API Reference for SubmitFeedback Operation</seealso>
        Task<SubmitFeedbackResponse> SubmitFeedbackAsync(SubmitFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Use to assign one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Use to assign one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Use to remove one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Use to remove one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfilingGroup service method.</param>
        /// <returns>The response from the UpdateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        UpdateProfilingGroupResponse UpdateProfilingGroup(UpdateProfilingGroupRequest request);
#endif

        /// <summary>
        /// Updates a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfilingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// The resource specified in the request does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The parameter is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        Task<UpdateProfilingGroupResponse> UpdateProfilingGroupAsync(UpdateProfilingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonCodeGuruProfilerConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonCodeGuruProfilerConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonCodeGuruProfilerConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonCodeGuruProfilerConfig to create AmazonCodeGuruProfilerClient");
            }

            return awsCredentials == null ?
                    new AmazonCodeGuruProfilerClient(serviceClientConfig) :
                    new AmazonCodeGuruProfilerClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
