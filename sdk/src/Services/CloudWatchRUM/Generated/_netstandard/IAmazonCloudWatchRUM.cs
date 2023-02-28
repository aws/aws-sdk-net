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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CloudWatchRUM.Model;

namespace Amazon.CloudWatchRUM
{
    /// <summary>
    /// Interface for accessing CloudWatchRUM
    ///
    /// With Amazon CloudWatch RUM, you can perform real-user monitoring to collect client-side
    /// data about your web application performance from actual user sessions in real time.
    /// The data collected includes page load times, client-side errors, and user behavior.
    /// When you view this data, you can see it all aggregated together and also see breakdowns
    /// by the browsers and devices that your customers use.
    /// 
    ///  
    /// <para>
    /// You can use the collected data to quickly identify and debug client-side performance
    /// issues. CloudWatch RUM helps you visualize anomalies in your application performance
    /// and find relevant debugging data such as error messages, stack traces, and user sessions.
    /// You can also use RUM to understand the range of end-user impact including the number
    /// of users, geolocations, and browsers used.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudWatchRUM : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudWatchRUMPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchCreateRumMetricDefinitions



        /// <summary>
        /// Specifies the extended metrics and custom metrics that you want a CloudWatch RUM app
        /// monitor to send to a destination. Valid destinations include CloudWatch and Evidently.
        /// 
        ///  
        /// <para>
        /// By default, RUM app monitors send some metrics to CloudWatch. These default metrics
        /// are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-metrics.html">CloudWatch
        /// metrics that you can collect with CloudWatch RUM</a>.
        /// </para>
        ///  
        /// <para>
        /// In addition to these default metrics, you can choose to send extended metrics or custom
        /// metrics or both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Extended metrics enable you to send metrics with additional dimensions not included
        /// in the default metrics. You can also send extended metrics to Evidently as well as
        /// CloudWatch. The valid dimension names for the additional dimensions for extended metrics
        /// are <code>BrowserName</code>, <code>CountryCode</code>, <code>DeviceType</code>, <code>FileType</code>,
        /// <code>OSName</code>, and <code>PageId</code>. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-vended-metrics.html">
        /// Extended metrics that you can send to CloudWatch and CloudWatch Evidently</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Custom metrics are metrics that you define. You can send custom metrics to CloudWatch
        /// or to CloudWatch Evidently or to both. With custom metrics, you can use any metric
        /// name and namespace, and to derive the metrics you can use any custom events, built-in
        /// events, custom attributes, or default attributes. 
        /// </para>
        ///  
        /// <para>
        /// You can't send custom metrics to the <code>AWS/RUM</code> namespace. You must send
        /// custom metrics to a custom namespace that you define. The namespace that you use can't
        /// start with <code>AWS/</code>. CloudWatch RUM prepends <code>RUM/CustomMetrics/</code>
        /// to the custom namespace that you define, so the final namespace for your metrics in
        /// CloudWatch is <code>RUM/CustomMetrics/<i>your-custom-namespace</i> </code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum number of metric definitions that you can specify in one <code>BatchCreateRumMetricDefinitions</code>
        /// operation is 200.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of metric definitions that one destination can contain is 2000.
        /// </para>
        ///  
        /// <para>
        /// Extended metrics sent to CloudWatch and RUM custom metrics are charged as CloudWatch
        /// custom metrics. Each combination of additional dimension name and dimension value
        /// counts as a custom metric. For more information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// You must have already created a destination for the metrics before you send them.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_PutRumMetricsDestination.html">PutRumMetricsDestination</a>.
        /// </para>
        ///  
        /// <para>
        /// If some metric definitions specified in a <code>BatchCreateRumMetricDefinitions</code>
        /// operations are not valid, those metric definitions fail and return errors, but all
        /// valid metric definitions in the same operation still succeed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateRumMetricDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchCreateRumMetricDefinitions">REST API Reference for BatchCreateRumMetricDefinitions Operation</seealso>
        Task<BatchCreateRumMetricDefinitionsResponse> BatchCreateRumMetricDefinitionsAsync(BatchCreateRumMetricDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteRumMetricDefinitions



        /// <summary>
        /// Removes the specified metrics from being sent to an extended metrics destination.
        /// 
        ///  
        /// <para>
        /// If some metric definition IDs specified in a <code>BatchDeleteRumMetricDefinitions</code>
        /// operations are not valid, those metric definitions fail and return errors, but all
        /// valid metric definition IDs in the same operation are still deleted.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of metric definitions that you can specify in one <code>BatchDeleteRumMetricDefinitions</code>
        /// operation is 200.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteRumMetricDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchDeleteRumMetricDefinitions">REST API Reference for BatchDeleteRumMetricDefinitions Operation</seealso>
        Task<BatchDeleteRumMetricDefinitionsResponse> BatchDeleteRumMetricDefinitionsAsync(BatchDeleteRumMetricDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetRumMetricDefinitions



        /// <summary>
        /// Retrieves the list of metrics and dimensions that a RUM app monitor is sending to
        /// a single destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRumMetricDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetRumMetricDefinitions service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/BatchGetRumMetricDefinitions">REST API Reference for BatchGetRumMetricDefinitions Operation</seealso>
        Task<BatchGetRumMetricDefinitionsResponse> BatchGetRumMetricDefinitionsAsync(BatchGetRumMetricDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAppMonitor



        /// <summary>
        /// Creates a Amazon CloudWatch RUM app monitor, which collects telemetry data from your
        /// application and sends that data to RUM. The data includes performance and reliability
        /// information such as page load time, client-side errors, and user behavior.
        /// 
        ///  
        /// <para>
        /// You use this operation only to create a new app monitor. To update an existing app
        /// monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_UpdateAppMonitor.html">UpdateAppMonitor</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// After you create an app monitor, sign in to the CloudWatch RUM console to get the
        /// JavaScript code snippet to add to your web application. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-find-code-snippet.html">How
        /// do I find a code snippet that I've already generated?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/CreateAppMonitor">REST API Reference for CreateAppMonitor Operation</seealso>
        Task<CreateAppMonitorResponse> CreateAppMonitorAsync(CreateAppMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAppMonitor



        /// <summary>
        /// Deletes an existing app monitor. This immediately stops the collection of data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/DeleteAppMonitor">REST API Reference for DeleteAppMonitor Operation</seealso>
        Task<DeleteAppMonitorResponse> DeleteAppMonitorAsync(DeleteAppMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRumMetricsDestination



        /// <summary>
        /// Deletes a destination for CloudWatch RUM extended metrics, so that the specified app
        /// monitor stops sending extended metrics to that destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRumMetricsDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRumMetricsDestination service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/DeleteRumMetricsDestination">REST API Reference for DeleteRumMetricsDestination Operation</seealso>
        Task<DeleteRumMetricsDestinationResponse> DeleteRumMetricsDestinationAsync(DeleteRumMetricsDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAppMonitor



        /// <summary>
        /// Retrieves the complete configuration information for one app monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitor">REST API Reference for GetAppMonitor Operation</seealso>
        Task<GetAppMonitorResponse> GetAppMonitorAsync(GetAppMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAppMonitorData



        /// <summary>
        /// Retrieves the raw performance events that RUM has collected from your web application,
        /// so that you can do your own processing or analysis of this data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAppMonitorData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAppMonitorData service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/GetAppMonitorData">REST API Reference for GetAppMonitorData Operation</seealso>
        Task<GetAppMonitorDataResponse> GetAppMonitorDataAsync(GetAppMonitorDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAppMonitors



        /// <summary>
        /// Returns a list of the Amazon CloudWatch RUM app monitors in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppMonitors service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListAppMonitors">REST API Reference for ListAppMonitors Operation</seealso>
        Task<ListAppMonitorsResponse> ListAppMonitorsAsync(ListAppMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRumMetricsDestinations



        /// <summary>
        /// Returns a list of destinations that you have created to receive RUM extended metrics,
        /// for the specified app monitor.
        /// 
        ///  
        /// <para>
        /// For more information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_AddRumMetrcs.html">AddRumMetrics</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRumMetricsDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRumMetricsDestinations service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListRumMetricsDestinations">REST API Reference for ListRumMetricsDestinations Operation</seealso>
        Task<ListRumMetricsDestinationsResponse> ListRumMetricsDestinationsAsync(ListRumMetricsDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Displays the tags associated with a CloudWatch RUM resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRumEvents



        /// <summary>
        /// Sends telemetry events about your application performance and user behavior to CloudWatch
        /// RUM. The code snippet that RUM generates for you to add to your application includes
        /// <code>PutRumEvents</code> operations to send this data to RUM.
        /// 
        ///  
        /// <para>
        /// Each <code>PutRumEvents</code> operation can send a batch of events from one user
        /// session.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRumEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRumEvents service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/PutRumEvents">REST API Reference for PutRumEvents Operation</seealso>
        Task<PutRumEventsResponse> PutRumEventsAsync(PutRumEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRumMetricsDestination



        /// <summary>
        /// Creates or updates a destination to receive extended metrics from CloudWatch RUM.
        /// You can send extended metrics to CloudWatch or to a CloudWatch Evidently experiment.
        /// 
        ///  
        /// <para>
        /// For more information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_BatchCreateRumMetricDefinitions.html">BatchCreateRumMetricDefinitions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRumMetricsDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRumMetricsDestination service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/PutRumMetricsDestination">REST API Reference for PutRumMetricsDestination Operation</seealso>
        Task<PutRumMetricsDestinationResponse> PutRumMetricsDestinationAsync(PutRumMetricsDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch RUM resource.
        /// Currently, the only resources that can be tagged app monitors.
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
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the alarm. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a resource.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAppMonitor



        /// <summary>
        /// Updates the configuration of an existing app monitor. When you use this operation,
        /// only the parts of the app monitor configuration that you specify in this operation
        /// are changed. For any parameters that you omit, the existing values are kept.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to change the tags of an existing app monitor. To change
        /// the tags of an existing app monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To create a new app monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_CreateAppMonitor.html">CreateAppMonitor</a>.
        /// </para>
        ///  
        /// <para>
        /// After you update an app monitor, sign in to the CloudWatch RUM console to get the
        /// updated JavaScript code snippet to add to your web application. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-find-code-snippet.html">How
        /// do I find a code snippet that I've already generated?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAppMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAppMonitor service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UpdateAppMonitor">REST API Reference for UpdateAppMonitor Operation</seealso>
        Task<UpdateAppMonitorResponse> UpdateAppMonitorAsync(UpdateAppMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRumMetricDefinition



        /// <summary>
        /// Modifies one existing metric definition for CloudWatch RUM extended metrics. For more
        /// information about extended metrics, see <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_BatchCreateRumMetricsDefinitions.html">BatchCreateRumMetricsDefinitions</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRumMetricDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRumMetricDefinition service method, as returned by CloudWatchRUM.</returns>
        /// <exception cref="Amazon.CloudWatchRUM.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.InternalServerException">
        /// Internal service exception.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ResourceNotFoundException">
        /// Resource not found.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchRUM.Model.ValidationException">
        /// One of the arguments for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rum-2018-05-10/UpdateRumMetricDefinition">REST API Reference for UpdateRumMetricDefinition Operation</seealso>
        Task<UpdateRumMetricDefinitionResponse> UpdateRumMetricDefinitionAsync(UpdateRumMetricDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}