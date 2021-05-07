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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LookoutMetrics.Model;

namespace Amazon.LookoutMetrics
{
    /// <summary>
    /// Interface for accessing LookoutMetrics
    ///
    /// This is the <i>Amazon Lookout for Metrics API Reference</i>. For an introduction to
    /// the service with tutorials for getting started, visit <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev">Amazon
    /// Lookout for Metrics Developer Guide</a>.
    /// </summary>
    public partial interface IAmazonLookoutMetrics : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        ActivateAnomalyDetectorResponse ActivateAnomalyDetector(ActivateAnomalyDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ActivateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ActivateAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndActivateAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ActivateAnomalyDetector">REST API Reference for ActivateAnomalyDetector Operation</seealso>
        IAsyncResult BeginActivateAnomalyDetector(ActivateAnomalyDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ActivateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginActivateAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  ActivateAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ActivateAnomalyDetector">REST API Reference for ActivateAnomalyDetector Operation</seealso>
        ActivateAnomalyDetectorResponse EndActivateAnomalyDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  BackTestAnomalyDetector


        /// <summary>
        /// Runs a backtest for anomaly detection for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BackTestAnomalyDetector service method.</param>
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
        BackTestAnomalyDetectorResponse BackTestAnomalyDetector(BackTestAnomalyDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BackTestAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BackTestAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBackTestAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/BackTestAnomalyDetector">REST API Reference for BackTestAnomalyDetector Operation</seealso>
        IAsyncResult BeginBackTestAnomalyDetector(BackTestAnomalyDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BackTestAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBackTestAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  BackTestAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/BackTestAnomalyDetector">REST API Reference for BackTestAnomalyDetector Operation</seealso>
        BackTestAnomalyDetectorResponse EndBackTestAnomalyDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAlert


        /// <summary>
        /// Creates an alert for an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert service method.</param>
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
        CreateAlertResponse CreateAlert(CreateAlertRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlert operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlert operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlert
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        IAsyncResult BeginCreateAlert(CreateAlertRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlert operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlert.</param>
        /// 
        /// <returns>Returns a  CreateAlertResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAlert">REST API Reference for CreateAlert Operation</seealso>
        CreateAlertResponse EndCreateAlert(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAnomalyDetector


        /// <summary>
        /// Creates an anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyDetector service method.</param>
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
        CreateAnomalyDetectorResponse CreateAnomalyDetector(CreateAnomalyDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAnomalyDetector">REST API Reference for CreateAnomalyDetector Operation</seealso>
        IAsyncResult BeginCreateAnomalyDetector(CreateAnomalyDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  CreateAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateAnomalyDetector">REST API Reference for CreateAnomalyDetector Operation</seealso>
        CreateAnomalyDetectorResponse EndCreateAnomalyDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMetricSet


        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricSet service method.</param>
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
        CreateMetricSetResponse CreateMetricSet(CreateMetricSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMetricSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMetricSet operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMetricSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateMetricSet">REST API Reference for CreateMetricSet Operation</seealso>
        IAsyncResult BeginCreateMetricSet(CreateMetricSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMetricSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMetricSet.</param>
        /// 
        /// <returns>Returns a  CreateMetricSetResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/CreateMetricSet">REST API Reference for CreateMetricSet Operation</seealso>
        CreateMetricSetResponse EndCreateMetricSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAlert


        /// <summary>
        /// Deletes an alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert service method.</param>
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
        DeleteAlertResponse DeleteAlert(DeleteAlertRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlert operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlert operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlert
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        IAsyncResult BeginDeleteAlert(DeleteAlertRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlert operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlert.</param>
        /// 
        /// <returns>Returns a  DeleteAlertResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAlert">REST API Reference for DeleteAlert Operation</seealso>
        DeleteAlertResponse EndDeleteAlert(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAnomalyDetector


        /// <summary>
        /// Deletes a detector. Deleting an anomaly detector will delete all of its corresponding
        /// resources including any configured datasets and alerts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyDetector service method.</param>
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
        DeleteAnomalyDetectorResponse DeleteAnomalyDetector(DeleteAnomalyDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        IAsyncResult BeginDeleteAnomalyDetector(DeleteAnomalyDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  DeleteAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DeleteAnomalyDetector">REST API Reference for DeleteAnomalyDetector Operation</seealso>
        DeleteAnomalyDetectorResponse EndDeleteAnomalyDetector(IAsyncResult asyncResult);

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
        DescribeAlertResponse DescribeAlert(DescribeAlertRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlert operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlert operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlert
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAlert">REST API Reference for DescribeAlert Operation</seealso>
        IAsyncResult BeginDescribeAlert(DescribeAlertRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlert operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlert.</param>
        /// 
        /// <returns>Returns a  DescribeAlertResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAlert">REST API Reference for DescribeAlert Operation</seealso>
        DescribeAlertResponse EndDescribeAlert(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAnomalyDetectionExecutions


        /// <summary>
        /// Returns information about the status of the specified anomaly detection jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetectionExecutions service method.</param>
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
        DescribeAnomalyDetectionExecutionsResponse DescribeAnomalyDetectionExecutions(DescribeAnomalyDetectionExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnomalyDetectionExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetectionExecutions operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnomalyDetectionExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetectionExecutions">REST API Reference for DescribeAnomalyDetectionExecutions Operation</seealso>
        IAsyncResult BeginDescribeAnomalyDetectionExecutions(DescribeAnomalyDetectionExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnomalyDetectionExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnomalyDetectionExecutions.</param>
        /// 
        /// <returns>Returns a  DescribeAnomalyDetectionExecutionsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetectionExecutions">REST API Reference for DescribeAnomalyDetectionExecutions Operation</seealso>
        DescribeAnomalyDetectionExecutionsResponse EndDescribeAnomalyDetectionExecutions(IAsyncResult asyncResult);

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
        DescribeAnomalyDetectorResponse DescribeAnomalyDetector(DescribeAnomalyDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetector">REST API Reference for DescribeAnomalyDetector Operation</seealso>
        IAsyncResult BeginDescribeAnomalyDetector(DescribeAnomalyDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  DescribeAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeAnomalyDetector">REST API Reference for DescribeAnomalyDetector Operation</seealso>
        DescribeAnomalyDetectorResponse EndDescribeAnomalyDetector(IAsyncResult asyncResult);

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
        DescribeMetricSetResponse DescribeMetricSet(DescribeMetricSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricSet operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetricSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeMetricSet">REST API Reference for DescribeMetricSet Operation</seealso>
        IAsyncResult BeginDescribeMetricSet(DescribeMetricSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetricSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricSet.</param>
        /// 
        /// <returns>Returns a  DescribeMetricSetResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/DescribeMetricSet">REST API Reference for DescribeMetricSet Operation</seealso>
        DescribeMetricSetResponse EndDescribeMetricSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAnomalyGroup


        /// <summary>
        /// Returns details about a group of anomalous metrics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyGroup service method.</param>
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
        GetAnomalyGroupResponse GetAnomalyGroup(GetAnomalyGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnomalyGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnomalyGroup operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnomalyGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetAnomalyGroup">REST API Reference for GetAnomalyGroup Operation</seealso>
        IAsyncResult BeginGetAnomalyGroup(GetAnomalyGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnomalyGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnomalyGroup.</param>
        /// 
        /// <returns>Returns a  GetAnomalyGroupResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetAnomalyGroup">REST API Reference for GetAnomalyGroup Operation</seealso>
        GetAnomalyGroupResponse EndGetAnomalyGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFeedback


        /// <summary>
        /// Get feedback for an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeedback service method.</param>
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
        GetFeedbackResponse GetFeedback(GetFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFeedback operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetFeedback">REST API Reference for GetFeedback Operation</seealso>
        IAsyncResult BeginGetFeedback(GetFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFeedback.</param>
        /// 
        /// <returns>Returns a  GetFeedbackResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetFeedback">REST API Reference for GetFeedback Operation</seealso>
        GetFeedbackResponse EndGetFeedback(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSampleData


        /// <summary>
        /// Returns a selection of sample records from an Amazon S3 datasource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSampleData service method.</param>
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
        GetSampleDataResponse GetSampleData(GetSampleDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSampleData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSampleData operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSampleData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetSampleData">REST API Reference for GetSampleData Operation</seealso>
        IAsyncResult BeginGetSampleData(GetSampleDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSampleData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSampleData.</param>
        /// 
        /// <returns>Returns a  GetSampleDataResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/GetSampleData">REST API Reference for GetSampleData Operation</seealso>
        GetSampleDataResponse EndGetSampleData(IAsyncResult asyncResult);

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
        ListAlertsResponse ListAlerts(ListAlertsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlerts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        IAsyncResult BeginListAlerts(ListAlertsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlerts.</param>
        /// 
        /// <returns>Returns a  ListAlertsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        ListAlertsResponse EndListAlerts(IAsyncResult asyncResult);

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
        ListAnomalyDetectorsResponse ListAnomalyDetectors(ListAnomalyDetectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomalyDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyDetectors operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomalyDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyDetectors">REST API Reference for ListAnomalyDetectors Operation</seealso>
        IAsyncResult BeginListAnomalyDetectors(ListAnomalyDetectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomalyDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomalyDetectors.</param>
        /// 
        /// <returns>Returns a  ListAnomalyDetectorsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyDetectors">REST API Reference for ListAnomalyDetectors Operation</seealso>
        ListAnomalyDetectorsResponse EndListAnomalyDetectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnomalyGroupSummaries


        /// <summary>
        /// Returns a list of anomaly groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupSummaries service method.</param>
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
        ListAnomalyGroupSummariesResponse ListAnomalyGroupSummaries(ListAnomalyGroupSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomalyGroupSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupSummaries operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomalyGroupSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupSummaries">REST API Reference for ListAnomalyGroupSummaries Operation</seealso>
        IAsyncResult BeginListAnomalyGroupSummaries(ListAnomalyGroupSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomalyGroupSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomalyGroupSummaries.</param>
        /// 
        /// <returns>Returns a  ListAnomalyGroupSummariesResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupSummaries">REST API Reference for ListAnomalyGroupSummaries Operation</seealso>
        ListAnomalyGroupSummariesResponse EndListAnomalyGroupSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAnomalyGroupTimeSeries


        /// <summary>
        /// Gets a list of anomalous metrics for a measure in an anomaly group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupTimeSeries service method.</param>
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
        ListAnomalyGroupTimeSeriesResponse ListAnomalyGroupTimeSeries(ListAnomalyGroupTimeSeriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomalyGroupTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalyGroupTimeSeries operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomalyGroupTimeSeries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupTimeSeries">REST API Reference for ListAnomalyGroupTimeSeries Operation</seealso>
        IAsyncResult BeginListAnomalyGroupTimeSeries(ListAnomalyGroupTimeSeriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomalyGroupTimeSeries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomalyGroupTimeSeries.</param>
        /// 
        /// <returns>Returns a  ListAnomalyGroupTimeSeriesResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListAnomalyGroupTimeSeries">REST API Reference for ListAnomalyGroupTimeSeries Operation</seealso>
        ListAnomalyGroupTimeSeriesResponse EndListAnomalyGroupTimeSeries(IAsyncResult asyncResult);

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
        ListMetricSetsResponse ListMetricSets(ListMetricSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetricSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetricSets operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetricSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListMetricSets">REST API Reference for ListMetricSets Operation</seealso>
        IAsyncResult BeginListMetricSets(ListMetricSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetricSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetricSets.</param>
        /// 
        /// <returns>Returns a  ListMetricSetsResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListMetricSets">REST API Reference for ListMetricSets Operation</seealso>
        ListMetricSetsResponse EndListMetricSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets a list of <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// for a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutFeedback


        /// <summary>
        /// Add feedback for an anomalous metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
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
        PutFeedbackResponse PutFeedback(PutFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        IAsyncResult BeginPutFeedback(PutFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFeedback.</param>
        /// 
        /// <returns>Returns a  PutFeedbackResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        PutFeedbackResponse EndPutFeedback(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// to a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes <a href="https://docs.aws.amazon.com/lookoutmetrics/latest/dev/detectors-tags.html">tags</a>
        /// from a detector, dataset, or alert.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAnomalyDetector


        /// <summary>
        /// Updates a detector. After activation, you can only change a detector's ingestion delay
        /// and description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyDetector service method.</param>
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
        UpdateAnomalyDetectorResponse UpdateAnomalyDetector(UpdateAnomalyDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomalyDetector operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAnomalyDetector">REST API Reference for UpdateAnomalyDetector Operation</seealso>
        IAsyncResult BeginUpdateAnomalyDetector(UpdateAnomalyDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  UpdateAnomalyDetectorResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateAnomalyDetector">REST API Reference for UpdateAnomalyDetector Operation</seealso>
        UpdateAnomalyDetectorResponse EndUpdateAnomalyDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMetricSet


        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricSet service method.</param>
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
        /// <exception cref="Amazon.LookoutMetrics.Model.TooManyRequestsException">
        /// The request was denied due to too many requests being submitted at the same time.
        /// </exception>
        /// <exception cref="Amazon.LookoutMetrics.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the AWS service. Check your
        /// input values and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateMetricSet">REST API Reference for UpdateMetricSet Operation</seealso>
        UpdateMetricSetResponse UpdateMetricSet(UpdateMetricSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMetricSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMetricSet operation on AmazonLookoutMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMetricSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateMetricSet">REST API Reference for UpdateMetricSet Operation</seealso>
        IAsyncResult BeginUpdateMetricSet(UpdateMetricSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMetricSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMetricSet.</param>
        /// 
        /// <returns>Returns a  UpdateMetricSetResult from LookoutMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/lookoutmetrics-2017-07-25/UpdateMetricSet">REST API Reference for UpdateMetricSet Operation</seealso>
        UpdateMetricSetResponse EndUpdateMetricSet(IAsyncResult asyncResult);

        #endregion
        
    }
}