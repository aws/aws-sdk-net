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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ComputeOptimizer.Model;

namespace Amazon.ComputeOptimizer
{
    /// <summary>
    /// Interface for accessing ComputeOptimizer
    ///
    /// AWS Compute Optimizer is a service that analyzes the configuration and utilization
    /// metrics of your AWS compute resources, such as EC2 instances, Auto Scaling groups,
    /// AWS Lambda functions, and Amazon EBS volumes. It reports whether your resources are
    /// optimal, and generates optimization recommendations to reduce the cost and improve
    /// the performance of your workloads. Compute Optimizer also provides recent utilization
    /// metric data, as well as projected utilization metric data for the recommendations,
    /// which you can use to evaluate which recommendation provides the best price-performance
    /// trade-off. The analysis of your usage patterns can help you decide when to move or
    /// resize your running resources, and still meet your performance and capacity requirements.
    /// For more information about Compute Optimizer, including the required permissions to
    /// use the service, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/">AWS
    /// Compute Optimizer User Guide</a>.
    /// </summary>
    public partial interface IAmazonComputeOptimizer : IAmazonService, IDisposable
    {




        
        #region  DescribeRecommendationExportJobs


        /// <summary>
        /// Describes recommendation export jobs created in the last seven days.
        /// 
        ///  
        /// <para>
        /// Use the <code>ExportAutoScalingGroupRecommendations</code> or <code>ExportEC2InstanceRecommendations</code>
        /// actions to request an export of your recommendations. Then use the <code>DescribeRecommendationExportJobs</code>
        /// action to view your export jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationExportJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeRecommendationExportJobs service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DescribeRecommendationExportJobs">REST API Reference for DescribeRecommendationExportJobs Operation</seealso>
        DescribeRecommendationExportJobsResponse DescribeRecommendationExportJobs(DescribeRecommendationExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRecommendationExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationExportJobs operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRecommendationExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DescribeRecommendationExportJobs">REST API Reference for DescribeRecommendationExportJobs Operation</seealso>
        IAsyncResult BeginDescribeRecommendationExportJobs(DescribeRecommendationExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRecommendationExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRecommendationExportJobs.</param>
        /// 
        /// <returns>Returns a  DescribeRecommendationExportJobsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DescribeRecommendationExportJobs">REST API Reference for DescribeRecommendationExportJobs Operation</seealso>
        DescribeRecommendationExportJobsResponse EndDescribeRecommendationExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportAutoScalingGroupRecommendations


        /// <summary>
        /// Exports optimization recommendations for Auto Scaling groups.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (.json) file, to an existing Amazon Simple Storage
        /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Auto Scaling group export job in progress per AWS Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportAutoScalingGroupRecommendations service method.</param>
        /// 
        /// <returns>The response from the ExportAutoScalingGroupRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportAutoScalingGroupRecommendations">REST API Reference for ExportAutoScalingGroupRecommendations Operation</seealso>
        ExportAutoScalingGroupRecommendationsResponse ExportAutoScalingGroupRecommendations(ExportAutoScalingGroupRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportAutoScalingGroupRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportAutoScalingGroupRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportAutoScalingGroupRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportAutoScalingGroupRecommendations">REST API Reference for ExportAutoScalingGroupRecommendations Operation</seealso>
        IAsyncResult BeginExportAutoScalingGroupRecommendations(ExportAutoScalingGroupRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportAutoScalingGroupRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportAutoScalingGroupRecommendations.</param>
        /// 
        /// <returns>Returns a  ExportAutoScalingGroupRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportAutoScalingGroupRecommendations">REST API Reference for ExportAutoScalingGroupRecommendations Operation</seealso>
        ExportAutoScalingGroupRecommendationsResponse EndExportAutoScalingGroupRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  ExportEC2InstanceRecommendations


        /// <summary>
        /// Exports optimization recommendations for Amazon EC2 instances.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (.json) file, to an existing Amazon Simple Storage
        /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Amazon EC2 instance export job in progress per AWS Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEC2InstanceRecommendations service method.</param>
        /// 
        /// <returns>The response from the ExportEC2InstanceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEC2InstanceRecommendations">REST API Reference for ExportEC2InstanceRecommendations Operation</seealso>
        ExportEC2InstanceRecommendationsResponse ExportEC2InstanceRecommendations(ExportEC2InstanceRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExportEC2InstanceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportEC2InstanceRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExportEC2InstanceRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEC2InstanceRecommendations">REST API Reference for ExportEC2InstanceRecommendations Operation</seealso>
        IAsyncResult BeginExportEC2InstanceRecommendations(ExportEC2InstanceRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExportEC2InstanceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExportEC2InstanceRecommendations.</param>
        /// 
        /// <returns>Returns a  ExportEC2InstanceRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEC2InstanceRecommendations">REST API Reference for ExportEC2InstanceRecommendations Operation</seealso>
        ExportEC2InstanceRecommendationsResponse EndExportEC2InstanceRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAutoScalingGroupRecommendations


        /// <summary>
        /// Returns Auto Scaling group recommendations.
        /// 
        ///  
        /// <para>
        /// AWS Compute Optimizer generates recommendations for Amazon EC2 Auto Scaling groups
        /// that meet a specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoScalingGroupRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetAutoScalingGroupRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetAutoScalingGroupRecommendations">REST API Reference for GetAutoScalingGroupRecommendations Operation</seealso>
        GetAutoScalingGroupRecommendationsResponse GetAutoScalingGroupRecommendations(GetAutoScalingGroupRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAutoScalingGroupRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAutoScalingGroupRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAutoScalingGroupRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetAutoScalingGroupRecommendations">REST API Reference for GetAutoScalingGroupRecommendations Operation</seealso>
        IAsyncResult BeginGetAutoScalingGroupRecommendations(GetAutoScalingGroupRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAutoScalingGroupRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAutoScalingGroupRecommendations.</param>
        /// 
        /// <returns>Returns a  GetAutoScalingGroupRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetAutoScalingGroupRecommendations">REST API Reference for GetAutoScalingGroupRecommendations Operation</seealso>
        GetAutoScalingGroupRecommendationsResponse EndGetAutoScalingGroupRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEBSVolumeRecommendations


        /// <summary>
        /// Returns Amazon Elastic Block Store (Amazon EBS) volume recommendations.
        /// 
        ///  
        /// <para>
        /// AWS Compute Optimizer generates recommendations for Amazon EBS volumes that meet a
        /// specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEBSVolumeRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetEBSVolumeRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEBSVolumeRecommendations">REST API Reference for GetEBSVolumeRecommendations Operation</seealso>
        GetEBSVolumeRecommendationsResponse GetEBSVolumeRecommendations(GetEBSVolumeRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEBSVolumeRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEBSVolumeRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEBSVolumeRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEBSVolumeRecommendations">REST API Reference for GetEBSVolumeRecommendations Operation</seealso>
        IAsyncResult BeginGetEBSVolumeRecommendations(GetEBSVolumeRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEBSVolumeRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEBSVolumeRecommendations.</param>
        /// 
        /// <returns>Returns a  GetEBSVolumeRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEBSVolumeRecommendations">REST API Reference for GetEBSVolumeRecommendations Operation</seealso>
        GetEBSVolumeRecommendationsResponse EndGetEBSVolumeRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEC2InstanceRecommendations


        /// <summary>
        /// Returns Amazon EC2 instance recommendations.
        /// 
        ///  
        /// <para>
        /// AWS Compute Optimizer generates recommendations for Amazon Elastic Compute Cloud (Amazon
        /// EC2) instances that meet a specific set of requirements. For more information, see
        /// the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEC2InstanceRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetEC2InstanceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2InstanceRecommendations">REST API Reference for GetEC2InstanceRecommendations Operation</seealso>
        GetEC2InstanceRecommendationsResponse GetEC2InstanceRecommendations(GetEC2InstanceRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEC2InstanceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEC2InstanceRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEC2InstanceRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2InstanceRecommendations">REST API Reference for GetEC2InstanceRecommendations Operation</seealso>
        IAsyncResult BeginGetEC2InstanceRecommendations(GetEC2InstanceRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEC2InstanceRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEC2InstanceRecommendations.</param>
        /// 
        /// <returns>Returns a  GetEC2InstanceRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2InstanceRecommendations">REST API Reference for GetEC2InstanceRecommendations Operation</seealso>
        GetEC2InstanceRecommendationsResponse EndGetEC2InstanceRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEC2RecommendationProjectedMetrics


        /// <summary>
        /// Returns the projected utilization metrics of Amazon EC2 instance recommendations.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>Cpu</code> and <code>Memory</code> metrics are the only projected utilization
        /// metrics returned when you run this action. Additionally, the <code>Memory</code> metric
        /// is returned only for resources that have the unified CloudWatch agent installed on
        /// them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEC2RecommendationProjectedMetrics service method.</param>
        /// 
        /// <returns>The response from the GetEC2RecommendationProjectedMetrics service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2RecommendationProjectedMetrics">REST API Reference for GetEC2RecommendationProjectedMetrics Operation</seealso>
        GetEC2RecommendationProjectedMetricsResponse GetEC2RecommendationProjectedMetrics(GetEC2RecommendationProjectedMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEC2RecommendationProjectedMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEC2RecommendationProjectedMetrics operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEC2RecommendationProjectedMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2RecommendationProjectedMetrics">REST API Reference for GetEC2RecommendationProjectedMetrics Operation</seealso>
        IAsyncResult BeginGetEC2RecommendationProjectedMetrics(GetEC2RecommendationProjectedMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEC2RecommendationProjectedMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEC2RecommendationProjectedMetrics.</param>
        /// 
        /// <returns>Returns a  GetEC2RecommendationProjectedMetricsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2RecommendationProjectedMetrics">REST API Reference for GetEC2RecommendationProjectedMetrics Operation</seealso>
        GetEC2RecommendationProjectedMetricsResponse EndGetEC2RecommendationProjectedMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEnrollmentStatus


        /// <summary>
        /// Returns the enrollment (opt in) status of an account to the AWS Compute Optimizer
        /// service.
        /// 
        ///  
        /// <para>
        /// If the account is the management account of an organization, this action also confirms
        /// the enrollment status of member accounts within the organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatus service method.</param>
        /// 
        /// <returns>The response from the GetEnrollmentStatus service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatus">REST API Reference for GetEnrollmentStatus Operation</seealso>
        GetEnrollmentStatusResponse GetEnrollmentStatus(GetEnrollmentStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnrollmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatus operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnrollmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatus">REST API Reference for GetEnrollmentStatus Operation</seealso>
        IAsyncResult BeginGetEnrollmentStatus(GetEnrollmentStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnrollmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnrollmentStatus.</param>
        /// 
        /// <returns>Returns a  GetEnrollmentStatusResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatus">REST API Reference for GetEnrollmentStatus Operation</seealso>
        GetEnrollmentStatusResponse EndGetEnrollmentStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLambdaFunctionRecommendations


        /// <summary>
        /// Returns AWS Lambda function recommendations.
        /// 
        ///  
        /// <para>
        /// AWS Compute Optimizer generates recommendations for functions that meet a specific
        /// set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>AWS Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLambdaFunctionRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetLambdaFunctionRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLambdaFunctionRecommendations">REST API Reference for GetLambdaFunctionRecommendations Operation</seealso>
        GetLambdaFunctionRecommendationsResponse GetLambdaFunctionRecommendations(GetLambdaFunctionRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLambdaFunctionRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLambdaFunctionRecommendations operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLambdaFunctionRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLambdaFunctionRecommendations">REST API Reference for GetLambdaFunctionRecommendations Operation</seealso>
        IAsyncResult BeginGetLambdaFunctionRecommendations(GetLambdaFunctionRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLambdaFunctionRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLambdaFunctionRecommendations.</param>
        /// 
        /// <returns>Returns a  GetLambdaFunctionRecommendationsResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLambdaFunctionRecommendations">REST API Reference for GetLambdaFunctionRecommendations Operation</seealso>
        GetLambdaFunctionRecommendationsResponse EndGetLambdaFunctionRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecommendationSummaries


        /// <summary>
        /// Returns the optimization findings for an account.
        /// 
        ///  
        /// <para>
        /// For example, it returns the number of Amazon EC2 instances in an account that are
        /// under-provisioned, over-provisioned, or optimized. It also returns the number of Auto
        /// Scaling groups in an account that are not optimized, or optimized.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationSummaries service method.</param>
        /// 
        /// <returns>The response from the GetRecommendationSummaries service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to AWS Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationSummaries">REST API Reference for GetRecommendationSummaries Operation</seealso>
        GetRecommendationSummariesResponse GetRecommendationSummaries(GetRecommendationSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommendationSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationSummaries operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommendationSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationSummaries">REST API Reference for GetRecommendationSummaries Operation</seealso>
        IAsyncResult BeginGetRecommendationSummaries(GetRecommendationSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommendationSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommendationSummaries.</param>
        /// 
        /// <returns>Returns a  GetRecommendationSummariesResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationSummaries">REST API Reference for GetRecommendationSummaries Operation</seealso>
        GetRecommendationSummariesResponse EndGetRecommendationSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEnrollmentStatus


        /// <summary>
        /// Updates the enrollment (opt in) status of an account to the AWS Compute Optimizer
        /// service.
        /// 
        ///  
        /// <para>
        /// If the account is a management account of an organization, this action can also be
        /// used to enroll member accounts within the organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateEnrollmentStatus service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// An invalid or out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) AWS access key ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        UpdateEnrollmentStatusResponse UpdateEnrollmentStatus(UpdateEnrollmentStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnrollmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus operation on AmazonComputeOptimizerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnrollmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        IAsyncResult BeginUpdateEnrollmentStatus(UpdateEnrollmentStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnrollmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnrollmentStatus.</param>
        /// 
        /// <returns>Returns a  UpdateEnrollmentStatusResult from ComputeOptimizer.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        UpdateEnrollmentStatusResponse EndUpdateEnrollmentStatus(IAsyncResult asyncResult);

        #endregion
        
    }
}