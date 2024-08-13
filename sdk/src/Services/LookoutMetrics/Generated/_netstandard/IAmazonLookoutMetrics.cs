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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LookoutMetrics.Model;

#pragma warning disable CS1570
namespace Amazon.LookoutMetrics
{
    /// <summary>
    /// <para>Interface for accessing LookoutMetrics</para>
    ///
    /// This is the <i>Amazon Lookout for Metrics API Reference</i>. For an introduction to
    /// the service with tutorials for getting started, visit <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev">Amazon
    /// Lookout for Metrics Developer Guide</a>.
    /// </summary>
    public partial interface IAmazonLookoutMetrics : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILookoutMetricsPaginatorFactory Paginators { get; }
#endif
                
        #region  ActivateAnomalyDetector



        /// <summary>
        /// Activates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ActivateAnomalyDetector">REST API Reference for ActivateAnomalyDetector Operation</seealso>
        Task<ActivateAnomalyDetectorResponse> ActivateAnomalyDetectorAsync(ActivateAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BackTestAnomalyDetector



        /// <summary>
        /// Runs a backtest for anomaly detection for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BackTestAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BackTestAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/BackTestAnomalyDetector">REST API Reference for BackTestAnomalyDetector Operation</seealso>
        Task<BackTestAnomalyDetectorResponse> BackTestAnomalyDetectorAsync(BackTestAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAlert



        /// <summary>
        /// Creates an alert for an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlert service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ServiceQuotaExceededException">
        /// The request exceeded the service's quotas. Check the service quotas and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        Task<CreateAlertResponse> CreateAlertAsync(CreateAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAnomalyDetector



        /// <summary>
        /// Creates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ServiceQuotaExceededException">
        /// The request exceeded the service's quotas. Check the service quotas and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAnomalyDetector">REST API Reference for CreateAnomalyDetector Operation</seealso>
        Task<CreateAnomalyDetectorResponse> CreateAnomalyDetectorAsync(CreateAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMetricSet



        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMetricSet service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ServiceQuotaExceededException">
        /// The request exceeded the service's quotas. Check the service quotas and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateMetricSet">REST API Reference for CreateMetricSet Operation</seealso>
        Task<CreateMetricSetResponse> CreateMetricSetAsync(CreateMetricSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeactivateAnomalyDetector



        /// <summary>
        /// Deactivates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeactivateAnomalyDetector">REST API Reference for DeactivateAnomalyDetector Operation</seealso>
        Task<DeactivateAnomalyDetectorResponse> DeactivateAnomalyDetectorAsync(DeactivateAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlert



        /// <summary>
        /// Deletes an alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlert service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        Task<DeleteAlertResponse> DeleteAlertAsync(DeleteAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAnomalyDetector



        /// <summary>
        /// Deletes a detector. Deleting an anomaly detector will delete all of its corresponding
        /// resources including any configured datasets and alerts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        Task<DeleteAnomalyDetectorResponse> DeleteAnomalyDetectorAsync(DeleteAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAlert



        /// <summary>
        /// Describes an alert.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlert service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAlert">REST API Reference for DescribeAlert Operation</seealso>
        Task<DescribeAlertResponse> DescribeAlertAsync(DescribeAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAnomalyDetectionExecutions



        /// <summary>
        /// Returns information about the status of the specified anomaly detection jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetectionExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnomalyDetectionExecutions service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetectionExecutions">REST API Reference for DescribeAnomalyDetectionExecutions Operation</seealso>
        Task<DescribeAnomalyDetectionExecutionsResponse> DescribeAnomalyDetectionExecutionsAsync(DescribeAnomalyDetectionExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAnomalyDetector



        /// <summary>
        /// Describes a detector.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetector">REST API Reference for DescribeAnomalyDetector Operation</seealso>
        Task<DescribeAnomalyDetectorResponse> DescribeAnomalyDetectorAsync(DescribeAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMetricSet



        /// <summary>
        /// Describes a dataset.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricSet service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeMetricSet">REST API Reference for DescribeMetricSet Operation</seealso>
        Task<DescribeMetricSetResponse> DescribeMetricSetAsync(DescribeMetricSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetectMetricSetConfig



        /// <summary>
        /// Detects an Amazon S3 dataset's file format, interval, and offset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectMetricSetConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectMetricSetConfig service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DetectMetricSetConfig">REST API Reference for DetectMetricSetConfig Operation</seealso>
        Task<DetectMetricSetConfigResponse> DetectMetricSetConfigAsync(DetectMetricSetConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAnomalyGroup



        /// <summary>
        /// Returns details about a group of anomalous metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAnomalyGroup service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetAnomalyGroup">REST API Reference for GetAnomalyGroup Operation</seealso>
        Task<GetAnomalyGroupResponse> GetAnomalyGroupAsync(GetAnomalyGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataQualityMetrics



        /// <summary>
        /// Returns details about the requested data quality metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataQualityMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataQualityMetrics service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetDataQualityMetrics">REST API Reference for GetDataQualityMetrics Operation</seealso>
        Task<GetDataQualityMetricsResponse> GetDataQualityMetricsAsync(GetDataQualityMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFeedback



        /// <summary>
        /// Get feedback for an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFeedback service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetFeedback">REST API Reference for GetFeedback Operation</seealso>
        Task<GetFeedbackResponse> GetFeedbackAsync(GetFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSampleData



        /// <summary>
        /// Returns a selection of sample records from an Amazon S3 datasource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampleData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSampleData service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetSampleData">REST API Reference for GetSampleData Operation</seealso>
        Task<GetSampleDataResponse> GetSampleDataAsync(GetSampleDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAlerts



        /// <summary>
        /// Lists the alerts attached to a detector.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        Task<ListAlertsResponse> ListAlertsAsync(ListAlertsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAnomalyDetectors



        /// <summary>
        /// Lists the detectors in the current AWS Region.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyDetectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalyDetectors service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyDetectors">REST API Reference for ListAnomalyDetectors Operation</seealso>
        Task<ListAnomalyDetectorsResponse> ListAnomalyDetectorsAsync(ListAnomalyDetectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAnomalyGroupRelatedMetrics



        /// <summary>
        /// Returns a list of measures that are potential causes or effects of an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupRelatedMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalyGroupRelatedMetrics service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupRelatedMetrics">REST API Reference for ListAnomalyGroupRelatedMetrics Operation</seealso>
        Task<ListAnomalyGroupRelatedMetricsResponse> ListAnomalyGroupRelatedMetricsAsync(ListAnomalyGroupRelatedMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAnomalyGroupSummaries



        /// <summary>
        /// Returns a list of anomaly groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalyGroupSummaries service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupSummaries">REST API Reference for ListAnomalyGroupSummaries Operation</seealso>
        Task<ListAnomalyGroupSummariesResponse> ListAnomalyGroupSummariesAsync(ListAnomalyGroupSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAnomalyGroupTimeSeries



        /// <summary>
        /// Gets a list of anomalous metrics for a measure in an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupTimeSeries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalyGroupTimeSeries service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupTimeSeries">REST API Reference for ListAnomalyGroupTimeSeries Operation</seealso>
        Task<ListAnomalyGroupTimeSeriesResponse> ListAnomalyGroupTimeSeriesAsync(ListAnomalyGroupTimeSeriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMetricSets



        /// <summary>
        /// Lists the datasets in the current AWS Region.
        /// 
        ///  
        /// <para>
        /// Amazon Lookout for Metrics API actions are eventually consistent. If you do a read
        /// operation on a resource immediately after creating or modifying it, use retries to
        /// allow time for the write operation to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetricSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMetricSets service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListMetricSets">REST API Reference for ListMetricSets Operation</seealso>
        Task<ListMetricSetsResponse> ListMetricSetsAsync(ListMetricSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Gets a list of <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// for a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutFeedback



        /// <summary>
        /// Add feedback for an anomalous metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFeedback service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// to a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// from a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAlert



        /// <summary>
        /// Make changes to an existing alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlert service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlert service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAlert">REST API Reference for UpdateAlert Operation</seealso>
        Task<UpdateAlertResponse> UpdateAlertAsync(UpdateAlertRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAnomalyDetector



        /// <summary>
        /// Updates a detector. After activation, you can only change a detector's ingestion delay
        /// and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnomalyDetector service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAnomalyDetector">REST API Reference for UpdateAnomalyDetector Operation</seealso>
        Task<UpdateAnomalyDetectorResponse> UpdateAnomalyDetectorAsync(UpdateAnomalyDetectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMetricSet



        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMetricSet service method, as returned by LookoutMetrics.</returns>
        /// <exception cref="Amazon.LookoutMetrics.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ResourceNotFoundException">
        /// The specified resource cannot be found. Check the ARN of the resource and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ServiceQuotaExceededException">
        /// The request exceeded the service's quotas. Check the service quotas and try again.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateMetricSet">REST API Reference for UpdateMetricSet Operation</seealso>
        Task<UpdateMetricSetResponse> UpdateMetricSetAsync(UpdateMetricSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonLookoutMetricsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonLookoutMetricsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonLookoutMetricsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonLookoutMetricsConfig to create AmazonLookoutMetricsClient");
            }

            return awsCredentials == null ? 
                    new AmazonLookoutMetricsClient(serviceClientConfig) :
                    new AmazonLookoutMetricsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}