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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RoboMaker.Model;

#pragma warning disable CS1570
namespace Amazon.RoboMaker
{
    /// <summary>
    /// <para>Interface for accessing RoboMaker</para>
    ///
    /// This section provides documentation for the AWS RoboMaker API operations.
    /// </summary>
    public partial interface IAmazonRoboMaker : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoboMakerPaginatorFactory Paginators { get; }

        
        #region  BatchDeleteWorlds


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes one or more worlds in a batch operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorlds service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteWorlds service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDeleteWorlds">REST API Reference for BatchDeleteWorlds Operation</seealso>
        BatchDeleteWorldsResponse BatchDeleteWorlds(BatchDeleteWorldsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes one or more worlds in a batch operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorlds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteWorlds service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDeleteWorlds">REST API Reference for BatchDeleteWorlds Operation</seealso>
        Task<BatchDeleteWorldsResponse> BatchDeleteWorldsAsync(BatchDeleteWorldsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDescribeSimulationJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes one or more simulation jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeSimulationJob service method.</param>
        /// 
        /// <returns>The response from the BatchDescribeSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDescribeSimulationJob">REST API Reference for BatchDescribeSimulationJob Operation</seealso>
        BatchDescribeSimulationJobResponse BatchDescribeSimulationJob(BatchDescribeSimulationJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes one or more simulation jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDescribeSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDescribeSimulationJob">REST API Reference for BatchDescribeSimulationJob Operation</seealso>
        Task<BatchDescribeSimulationJobResponse> BatchDescribeSimulationJobAsync(BatchDescribeSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelDeploymentJob


        /// <summary>
        /// <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified deployment job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDeploymentJob service method.</param>
        /// 
        /// <returns>The response from the CancelDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelDeploymentJob">REST API Reference for CancelDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        CancelDeploymentJobResponse CancelDeploymentJob(CancelDeploymentJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified deployment job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDeploymentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelDeploymentJob">REST API Reference for CancelDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<CancelDeploymentJobResponse> CancelDeploymentJobAsync(CancelDeploymentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelSimulationJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJob service method.</param>
        /// 
        /// <returns>The response from the CancelSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJob">REST API Reference for CancelSimulationJob Operation</seealso>
        CancelSimulationJobResponse CancelSimulationJob(CancelSimulationJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJob">REST API Reference for CancelSimulationJob Operation</seealso>
        Task<CancelSimulationJobResponse> CancelSimulationJobAsync(CancelSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelSimulationJobBatch


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels a simulation job batch. When you cancel a simulation job batch, you are also
        /// cancelling all of the active simulation jobs created as part of the batch. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJobBatch service method.</param>
        /// 
        /// <returns>The response from the CancelSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJobBatch">REST API Reference for CancelSimulationJobBatch Operation</seealso>
        CancelSimulationJobBatchResponse CancelSimulationJobBatch(CancelSimulationJobBatchRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels a simulation job batch. When you cancel a simulation job batch, you are also
        /// cancelling all of the active simulation jobs created as part of the batch. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJobBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJobBatch">REST API Reference for CancelSimulationJobBatch Operation</seealso>
        Task<CancelSimulationJobBatchResponse> CancelSimulationJobBatchAsync(CancelSimulationJobBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelWorldExportJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelWorldExportJob service method.</param>
        /// 
        /// <returns>The response from the CancelWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldExportJob">REST API Reference for CancelWorldExportJob Operation</seealso>
        CancelWorldExportJobResponse CancelWorldExportJob(CancelWorldExportJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelWorldExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldExportJob">REST API Reference for CancelWorldExportJob Operation</seealso>
        Task<CancelWorldExportJobResponse> CancelWorldExportJobAsync(CancelWorldExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelWorldGenerationJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified world generator job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelWorldGenerationJob service method.</param>
        /// 
        /// <returns>The response from the CancelWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldGenerationJob">REST API Reference for CancelWorldGenerationJob Operation</seealso>
        CancelWorldGenerationJobResponse CancelWorldGenerationJob(CancelWorldGenerationJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Cancels the specified world generator job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelWorldGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldGenerationJob">REST API Reference for CancelWorldGenerationJob Operation</seealso>
        Task<CancelWorldGenerationJobResponse> CancelWorldGenerationJobAsync(CancelWorldGenerationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDeploymentJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deploys a specific version of a robot application to robots in a fleet.
        /// </para>
        ///  
        /// <para>
        /// The robot application must have a numbered <c>applicationVersion</c> for consistency
        /// reasons. To create a new version, use <c>CreateRobotApplicationVersion</c> or see
        /// <a href="https://docs.aws.amazon.com/robomaker/latest/dg/create-robot-application-version.html">Creating
        /// a Robot Application Version</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// After 90 days, deployment jobs expire and will be deleted. They will no longer be
        /// accessible. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentJob service method.</param>
        /// 
        /// <returns>The response from the CreateDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.ConcurrentDeploymentException">
        /// The failure percentage threshold percentage was met.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateDeploymentJob">REST API Reference for CreateDeploymentJob Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        CreateDeploymentJobResponse CreateDeploymentJob(CreateDeploymentJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deploys a specific version of a robot application to robots in a fleet.
        /// </para>
        ///  
        /// <para>
        /// The robot application must have a numbered <c>applicationVersion</c> for consistency
        /// reasons. To create a new version, use <c>CreateRobotApplicationVersion</c> or see
        /// <a href="https://docs.aws.amazon.com/robomaker/latest/dg/create-robot-application-version.html">Creating
        /// a Robot Application Version</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// After 90 days, deployment jobs expire and will be deleted. They will no longer be
        /// accessible. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.ConcurrentDeploymentException">
        /// The failure percentage threshold percentage was met.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateDeploymentJob">REST API Reference for CreateDeploymentJob Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<CreateDeploymentJobResponse> CreateDeploymentJobAsync(CreateDeploymentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a fleet, a logical group of robots running the same robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        CreateFleetResponse CreateFleet(CreateFleetRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a fleet, a logical group of robots running the same robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRobot


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobot service method.</param>
        /// 
        /// <returns>The response from the CreateRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobot">REST API Reference for CreateRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        CreateRobotResponse CreateRobot(CreateRobotRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobot">REST API Reference for CreateRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<CreateRobotResponse> CreateRobotAsync(CreateRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRobotApplication


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a robot application. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplication service method.</param>
        /// 
        /// <returns>The response from the CreateRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplication">REST API Reference for CreateRobotApplication Operation</seealso>
        CreateRobotApplicationResponse CreateRobotApplication(CreateRobotApplicationRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a robot application. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplication">REST API Reference for CreateRobotApplication Operation</seealso>
        Task<CreateRobotApplicationResponse> CreateRobotApplicationAsync(CreateRobotApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRobotApplicationVersion


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a version of a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateRobotApplicationVersion service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplicationVersion">REST API Reference for CreateRobotApplicationVersion Operation</seealso>
        CreateRobotApplicationVersionResponse CreateRobotApplicationVersion(CreateRobotApplicationVersionRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a version of a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRobotApplicationVersion service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplicationVersion">REST API Reference for CreateRobotApplicationVersion Operation</seealso>
        Task<CreateRobotApplicationVersionResponse> CreateRobotApplicationVersionAsync(CreateRobotApplicationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSimulationApplication


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplication service method.</param>
        /// 
        /// <returns>The response from the CreateSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplication">REST API Reference for CreateSimulationApplication Operation</seealso>
        CreateSimulationApplicationResponse CreateSimulationApplication(CreateSimulationApplicationRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplication">REST API Reference for CreateSimulationApplication Operation</seealso>
        Task<CreateSimulationApplicationResponse> CreateSimulationApplicationAsync(CreateSimulationApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSimulationApplicationVersion


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation application with a specific revision id.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplicationVersion service method.</param>
        /// 
        /// <returns>The response from the CreateSimulationApplicationVersion service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplicationVersion">REST API Reference for CreateSimulationApplicationVersion Operation</seealso>
        CreateSimulationApplicationVersionResponse CreateSimulationApplicationVersion(CreateSimulationApplicationVersionRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation application with a specific revision id.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplicationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSimulationApplicationVersion service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplicationVersion">REST API Reference for CreateSimulationApplicationVersion Operation</seealso>
        Task<CreateSimulationApplicationVersionResponse> CreateSimulationApplicationVersionAsync(CreateSimulationApplicationVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSimulationJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation job.
        /// </para>
        ///  <note> 
        /// <para>
        /// After 90 days, simulation jobs expire and will be deleted. They will no longer be
        /// accessible. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationJob service method.</param>
        /// 
        /// <returns>The response from the CreateSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationJob">REST API Reference for CreateSimulationJob Operation</seealso>
        CreateSimulationJobResponse CreateSimulationJob(CreateSimulationJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a simulation job.
        /// </para>
        ///  <note> 
        /// <para>
        /// After 90 days, simulation jobs expire and will be deleted. They will no longer be
        /// accessible. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationJob">REST API Reference for CreateSimulationJob Operation</seealso>
        Task<CreateSimulationJobResponse> CreateSimulationJobAsync(CreateSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorldExportJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a world export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldExportJob">REST API Reference for CreateWorldExportJob Operation</seealso>
        CreateWorldExportJobResponse CreateWorldExportJob(CreateWorldExportJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a world export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldExportJob">REST API Reference for CreateWorldExportJob Operation</seealso>
        Task<CreateWorldExportJobResponse> CreateWorldExportJobAsync(CreateWorldExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorldGenerationJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates worlds using the specified template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldGenerationJob service method.</param>
        /// 
        /// <returns>The response from the CreateWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldGenerationJob">REST API Reference for CreateWorldGenerationJob Operation</seealso>
        CreateWorldGenerationJobResponse CreateWorldGenerationJob(CreateWorldGenerationJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates worlds using the specified template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldGenerationJob">REST API Reference for CreateWorldGenerationJob Operation</seealso>
        Task<CreateWorldGenerationJobResponse> CreateWorldGenerationJobAsync(CreateWorldGenerationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorldTemplate


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldTemplate">REST API Reference for CreateWorldTemplate Operation</seealso>
        CreateWorldTemplateResponse CreateWorldTemplate(CreateWorldTemplateRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Creates a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldTemplate">REST API Reference for CreateWorldTemplate Operation</seealso>
        Task<CreateWorldTemplateResponse> CreateWorldTemplateAsync(CreateWorldTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a fleet.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a fleet.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRobot


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobot service method.</param>
        /// 
        /// <returns>The response from the DeleteRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobot">REST API Reference for DeleteRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DeleteRobotResponse DeleteRobot(DeleteRobotRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobot">REST API Reference for DeleteRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<DeleteRobotResponse> DeleteRobotAsync(DeleteRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRobotApplication


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobotApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobotApplication">REST API Reference for DeleteRobotApplication Operation</seealso>
        DeleteRobotApplicationResponse DeleteRobotApplication(DeleteRobotApplicationRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobotApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobotApplication">REST API Reference for DeleteRobotApplication Operation</seealso>
        Task<DeleteRobotApplicationResponse> DeleteRobotApplicationAsync(DeleteRobotApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSimulationApplication


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulationApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteSimulationApplication">REST API Reference for DeleteSimulationApplication Operation</seealso>
        DeleteSimulationApplicationResponse DeleteSimulationApplication(DeleteSimulationApplicationRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulationApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteSimulationApplication">REST API Reference for DeleteSimulationApplication Operation</seealso>
        Task<DeleteSimulationApplicationResponse> DeleteSimulationApplicationAsync(DeleteSimulationApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWorldTemplate


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorldTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteWorldTemplate">REST API Reference for DeleteWorldTemplate Operation</seealso>
        DeleteWorldTemplateResponse DeleteWorldTemplate(DeleteWorldTemplateRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Deletes a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorldTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteWorldTemplate">REST API Reference for DeleteWorldTemplate Operation</seealso>
        Task<DeleteWorldTemplateResponse> DeleteWorldTemplateAsync(DeleteWorldTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterRobot


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deregisters a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRobot service method.</param>
        /// 
        /// <returns>The response from the DeregisterRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeregisterRobot">REST API Reference for DeregisterRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DeregisterRobotResponse DeregisterRobot(DeregisterRobotRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Deregisters a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeregisterRobot">REST API Reference for DeregisterRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<DeregisterRobotResponse> DeregisterRobotAsync(DeregisterRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeploymentJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a deployment job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeploymentJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeDeploymentJob">REST API Reference for DescribeDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DescribeDeploymentJobResponse DescribeDeploymentJob(DescribeDeploymentJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a deployment job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeploymentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeDeploymentJob">REST API Reference for DescribeDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<DescribeDeploymentJobResponse> DescribeDeploymentJobAsync(DescribeDeploymentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFleet


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a fleet.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleet service method.</param>
        /// 
        /// <returns>The response from the DescribeFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeFleet">REST API Reference for DescribeFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DescribeFleetResponse DescribeFleet(DescribeFleetRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a fleet.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleet service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeFleet">REST API Reference for DescribeFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<DescribeFleetResponse> DescribeFleetAsync(DescribeFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRobot


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobot service method.</param>
        /// 
        /// <returns>The response from the DescribeRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobot">REST API Reference for DescribeRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DescribeRobotResponse DescribeRobot(DescribeRobotRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a robot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobot">REST API Reference for DescribeRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<DescribeRobotResponse> DescribeRobotAsync(DescribeRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRobotApplication


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobotApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobotApplication">REST API Reference for DescribeRobotApplication Operation</seealso>
        DescribeRobotApplicationResponse DescribeRobotApplication(DescribeRobotApplicationRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobotApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobotApplication">REST API Reference for DescribeRobotApplication Operation</seealso>
        Task<DescribeRobotApplicationResponse> DescribeRobotApplicationAsync(DescribeRobotApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSimulationApplication


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationApplication service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationApplication">REST API Reference for DescribeSimulationApplication Operation</seealso>
        DescribeSimulationApplicationResponse DescribeSimulationApplication(DescribeSimulationApplicationRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationApplication">REST API Reference for DescribeSimulationApplication Operation</seealso>
        Task<DescribeSimulationApplicationResponse> DescribeSimulationApplicationAsync(DescribeSimulationApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSimulationJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJob">REST API Reference for DescribeSimulationJob Operation</seealso>
        DescribeSimulationJobResponse DescribeSimulationJob(DescribeSimulationJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJob">REST API Reference for DescribeSimulationJob Operation</seealso>
        Task<DescribeSimulationJobResponse> DescribeSimulationJobAsync(DescribeSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSimulationJobBatch


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation job batch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJobBatch service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJobBatch">REST API Reference for DescribeSimulationJobBatch Operation</seealso>
        DescribeSimulationJobBatchResponse DescribeSimulationJobBatch(DescribeSimulationJobBatchRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a simulation job batch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJobBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJobBatch">REST API Reference for DescribeSimulationJobBatch Operation</seealso>
        Task<DescribeSimulationJobBatchResponse> DescribeSimulationJobBatchAsync(DescribeSimulationJobBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWorld


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorld service method.</param>
        /// 
        /// <returns>The response from the DescribeWorld service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorld">REST API Reference for DescribeWorld Operation</seealso>
        DescribeWorldResponse DescribeWorld(DescribeWorldRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorld service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorld service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorld">REST API Reference for DescribeWorld Operation</seealso>
        Task<DescribeWorldResponse> DescribeWorldAsync(DescribeWorldRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWorldExportJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldExportJob">REST API Reference for DescribeWorldExportJob Operation</seealso>
        DescribeWorldExportJobResponse DescribeWorldExportJob(DescribeWorldExportJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world export job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorldExportJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldExportJob">REST API Reference for DescribeWorldExportJob Operation</seealso>
        Task<DescribeWorldExportJobResponse> DescribeWorldExportJobAsync(DescribeWorldExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWorldGenerationJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world generation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldGenerationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldGenerationJob">REST API Reference for DescribeWorldGenerationJob Operation</seealso>
        DescribeWorldGenerationJobResponse DescribeWorldGenerationJob(DescribeWorldGenerationJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world generation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldGenerationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorldGenerationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldGenerationJob">REST API Reference for DescribeWorldGenerationJob Operation</seealso>
        Task<DescribeWorldGenerationJobResponse> DescribeWorldGenerationJobAsync(DescribeWorldGenerationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWorldTemplate


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldTemplate">REST API Reference for DescribeWorldTemplate Operation</seealso>
        DescribeWorldTemplateResponse DescribeWorldTemplate(DescribeWorldTemplateRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Describes a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldTemplate">REST API Reference for DescribeWorldTemplate Operation</seealso>
        Task<DescribeWorldTemplateResponse> DescribeWorldTemplateAsync(DescribeWorldTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorldTemplateBody


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Gets the world template body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorldTemplateBody service method.</param>
        /// 
        /// <returns>The response from the GetWorldTemplateBody service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/GetWorldTemplateBody">REST API Reference for GetWorldTemplateBody Operation</seealso>
        GetWorldTemplateBodyResponse GetWorldTemplateBody(GetWorldTemplateBodyRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Gets the world template body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorldTemplateBody service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorldTemplateBody service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/GetWorldTemplateBody">REST API Reference for GetWorldTemplateBody Operation</seealso>
        Task<GetWorldTemplateBodyResponse> GetWorldTemplateBodyAsync(GetWorldTemplateBodyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeploymentJobs


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of deployment jobs for a fleet. You can optionally provide filters
        /// to retrieve specific deployment jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentJobs service method.</param>
        /// 
        /// <returns>The response from the ListDeploymentJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListDeploymentJobs">REST API Reference for ListDeploymentJobs Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        ListDeploymentJobsResponse ListDeploymentJobs(ListDeploymentJobsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of deployment jobs for a fleet. You can optionally provide filters
        /// to retrieve specific deployment jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeploymentJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListDeploymentJobs">REST API Reference for ListDeploymentJobs Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<ListDeploymentJobsResponse> ListDeploymentJobsAsync(ListDeploymentJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of fleets. You can optionally provide filters to retrieve specific
        /// fleets. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListFleets">REST API Reference for ListFleets Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        ListFleetsResponse ListFleets(ListFleetsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of fleets. You can optionally provide filters to retrieve specific
        /// fleets. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListFleets">REST API Reference for ListFleets Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRobotApplications


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of robot application. You can optionally provide filters to retrieve
        /// specific robot applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRobotApplications service method.</param>
        /// 
        /// <returns>The response from the ListRobotApplications service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobotApplications">REST API Reference for ListRobotApplications Operation</seealso>
        ListRobotApplicationsResponse ListRobotApplications(ListRobotApplicationsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of robot application. You can optionally provide filters to retrieve
        /// specific robot applications.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRobotApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRobotApplications service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobotApplications">REST API Reference for ListRobotApplications Operation</seealso>
        Task<ListRobotApplicationsResponse> ListRobotApplicationsAsync(ListRobotApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRobots


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of robots. You can optionally provide filters to retrieve specific
        /// robots. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRobots service method.</param>
        /// 
        /// <returns>The response from the ListRobots service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobots">REST API Reference for ListRobots Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        ListRobotsResponse ListRobots(ListRobotsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Returns a list of robots. You can optionally provide filters to retrieve specific
        /// robots. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRobots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRobots service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobots">REST API Reference for ListRobots Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<ListRobotsResponse> ListRobotsAsync(ListRobotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSimulationApplications


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of simulation applications. You can optionally provide filters to retrieve
        /// specific simulation applications. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationApplications service method.</param>
        /// 
        /// <returns>The response from the ListSimulationApplications service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationApplications">REST API Reference for ListSimulationApplications Operation</seealso>
        ListSimulationApplicationsResponse ListSimulationApplications(ListSimulationApplicationsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of simulation applications. You can optionally provide filters to retrieve
        /// specific simulation applications. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSimulationApplications service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationApplications">REST API Reference for ListSimulationApplications Operation</seealso>
        Task<ListSimulationApplicationsResponse> ListSimulationApplicationsAsync(ListSimulationApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSimulationJobBatches


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list simulation job batches. You can optionally provide filters to retrieve
        /// specific simulation batch jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobBatches service method.</param>
        /// 
        /// <returns>The response from the ListSimulationJobBatches service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobBatches">REST API Reference for ListSimulationJobBatches Operation</seealso>
        ListSimulationJobBatchesResponse ListSimulationJobBatches(ListSimulationJobBatchesRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list simulation job batches. You can optionally provide filters to retrieve
        /// specific simulation batch jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobBatches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSimulationJobBatches service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobBatches">REST API Reference for ListSimulationJobBatches Operation</seealso>
        Task<ListSimulationJobBatchesResponse> ListSimulationJobBatchesAsync(ListSimulationJobBatchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSimulationJobs


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of simulation jobs. You can optionally provide filters to retrieve
        /// specific simulation jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobs service method.</param>
        /// 
        /// <returns>The response from the ListSimulationJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobs">REST API Reference for ListSimulationJobs Operation</seealso>
        ListSimulationJobsResponse ListSimulationJobs(ListSimulationJobsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Returns a list of simulation jobs. You can optionally provide filters to retrieve
        /// specific simulation jobs. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSimulationJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobs">REST API Reference for ListSimulationJobs Operation</seealso>
        Task<ListSimulationJobsResponse> ListSimulationJobsAsync(ListSimulationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists all tags on a AWS RoboMaker resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists all tags on a AWS RoboMaker resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorldExportJobs


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world export jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListWorldExportJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldExportJobs">REST API Reference for ListWorldExportJobs Operation</seealso>
        ListWorldExportJobsResponse ListWorldExportJobs(ListWorldExportJobsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world export jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorldExportJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldExportJobs">REST API Reference for ListWorldExportJobs Operation</seealso>
        Task<ListWorldExportJobsResponse> ListWorldExportJobsAsync(ListWorldExportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorldGenerationJobs


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world generator jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldGenerationJobs service method.</param>
        /// 
        /// <returns>The response from the ListWorldGenerationJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldGenerationJobs">REST API Reference for ListWorldGenerationJobs Operation</seealso>
        ListWorldGenerationJobsResponse ListWorldGenerationJobs(ListWorldGenerationJobsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world generator jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldGenerationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorldGenerationJobs service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldGenerationJobs">REST API Reference for ListWorldGenerationJobs Operation</seealso>
        Task<ListWorldGenerationJobsResponse> ListWorldGenerationJobsAsync(ListWorldGenerationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorlds


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists worlds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorlds service method.</param>
        /// 
        /// <returns>The response from the ListWorlds service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorlds">REST API Reference for ListWorlds Operation</seealso>
        ListWorldsResponse ListWorlds(ListWorldsRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists worlds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorlds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorlds service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorlds">REST API Reference for ListWorlds Operation</seealso>
        Task<ListWorldsResponse> ListWorldsAsync(ListWorldsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorldTemplates


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world templates.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldTemplates service method.</param>
        /// 
        /// <returns>The response from the ListWorldTemplates service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldTemplates">REST API Reference for ListWorldTemplates Operation</seealso>
        ListWorldTemplatesResponse ListWorldTemplates(ListWorldTemplatesRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists world templates.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorldTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorldTemplates service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldTemplates">REST API Reference for ListWorldTemplates Operation</seealso>
        Task<ListWorldTemplatesResponse> ListWorldTemplatesAsync(ListWorldTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterRobot


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Registers a robot with a fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterRobot service method.</param>
        /// 
        /// <returns>The response from the RegisterRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RegisterRobot">REST API Reference for RegisterRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        RegisterRobotResponse RegisterRobot(RegisterRobotRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Registers a robot with a fleet.
        /// </para>
        ///  <important> 
        /// <para>
        /// This API is no longer supported and will throw an error if used. For more information,
        /// see the January 31, 2022 update in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-january2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterRobot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterRobot service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RegisterRobot">REST API Reference for RegisterRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<RegisterRobotResponse> RegisterRobotAsync(RegisterRobotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestartSimulationJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Restarts a running simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartSimulationJob service method.</param>
        /// 
        /// <returns>The response from the RestartSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RestartSimulationJob">REST API Reference for RestartSimulationJob Operation</seealso>
        RestartSimulationJobResponse RestartSimulationJob(RestartSimulationJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Restarts a running simulation job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartSimulationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestartSimulationJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RestartSimulationJob">REST API Reference for RestartSimulationJob Operation</seealso>
        Task<RestartSimulationJobResponse> RestartSimulationJobAsync(RestartSimulationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartSimulationJobBatch


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Starts a new simulation job batch. The batch is defined using one or more <c>SimulationJobRequest</c>
        /// objects. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulationJobBatch service method.</param>
        /// 
        /// <returns>The response from the StartSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/StartSimulationJobBatch">REST API Reference for StartSimulationJobBatch Operation</seealso>
        StartSimulationJobBatchResponse StartSimulationJobBatch(StartSimulationJobBatchRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Starts a new simulation job batch. The batch is defined using one or more <c>SimulationJobRequest</c>
        /// objects. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulationJobBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSimulationJobBatch service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/StartSimulationJobBatch">REST API Reference for StartSimulationJobBatch Operation</seealso>
        Task<StartSimulationJobBatchResponse> StartSimulationJobBatchAsync(StartSimulationJobBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SyncDeploymentJob


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Syncrhonizes robots in a fleet to the latest deployment. This is helpful if robots
        /// were added after a deployment. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SyncDeploymentJob service method.</param>
        /// 
        /// <returns>The response from the SyncDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.ConcurrentDeploymentException">
        /// The failure percentage threshold percentage was met.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/SyncDeploymentJob">REST API Reference for SyncDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        SyncDeploymentJobResponse SyncDeploymentJob(SyncDeploymentJobRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// This API is no longer supported. For more information, see the May 2, 2022 update
        /// in the <a href="https://docs.aws.amazon.com/robomaker/latest/dg/chapter-support-policy.html#software-support-policy-may2022">Support
        /// policy</a> page.
        /// </para>
        ///  </important> 
        /// <para>
        ///  Syncrhonizes robots in a fleet to the latest deployment. This is helpful if robots
        /// were added after a deployment. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SyncDeploymentJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SyncDeploymentJob service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.ConcurrentDeploymentException">
        /// The failure percentage threshold percentage was met.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.IdempotentParameterMismatchException">
        /// The request uses the same client token as a previous, but non-identical request. Do
        /// not reuse a client token with different requests, unless the requests are identical.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/SyncDeploymentJob">REST API Reference for SyncDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        Task<SyncDeploymentJobResponse> SyncDeploymentJobAsync(SyncDeploymentJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Adds or edits tags for a AWS RoboMaker resource.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Tag keys and tag values are both required,
        /// but tag values can be empty strings. 
        /// </para>
        ///  
        /// <para>
        /// For information about the rules that apply to tag keys and tag values, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> in the <i>AWS Billing and Cost Management User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Adds or edits tags for a AWS RoboMaker resource.
        /// </para>
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Tag keys and tag values are both required,
        /// but tag values can be empty strings. 
        /// </para>
        ///  
        /// <para>
        /// For information about the rules that apply to tag keys and tag values, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> in the <i>AWS Billing and Cost Management User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Removes the specified tags from the specified AWS RoboMaker resource.
        /// </para>
        ///  
        /// <para>
        /// To remove a tag, specify the tag key. To change the tag value of an existing tag key,
        /// use <a href="https://docs.aws.amazon.com/robomaker/latest/dg/API_TagResource.html">
        /// <c>TagResource</c> </a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Removes the specified tags from the specified AWS RoboMaker resource.
        /// </para>
        ///  
        /// <para>
        /// To remove a tag, specify the tag key. To change the tag value of an existing tag key,
        /// use <a href="https://docs.aws.amazon.com/robomaker/latest/dg/API_TagResource.html">
        /// <c>TagResource</c> </a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRobotApplication


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRobotApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateRobotApplication">REST API Reference for UpdateRobotApplication Operation</seealso>
        UpdateRobotApplicationResponse UpdateRobotApplication(UpdateRobotApplicationRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a robot application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRobotApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRobotApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateRobotApplication">REST API Reference for UpdateRobotApplication Operation</seealso>
        Task<UpdateRobotApplicationResponse> UpdateRobotApplicationAsync(UpdateRobotApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSimulationApplication


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSimulationApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateSimulationApplication">REST API Reference for UpdateSimulationApplication Operation</seealso>
        UpdateSimulationApplicationResponse UpdateSimulationApplication(UpdateSimulationApplicationRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a simulation application.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSimulationApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSimulationApplication service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateSimulationApplication">REST API Reference for UpdateSimulationApplication Operation</seealso>
        Task<UpdateSimulationApplicationResponse> UpdateSimulationApplicationAsync(UpdateSimulationApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWorldTemplate


        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorldTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateWorldTemplate">REST API Reference for UpdateWorldTemplate Operation</seealso>
        UpdateWorldTemplateResponse UpdateWorldTemplate(UpdateWorldTemplateRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// End of support notice: On September 10, 2025, Amazon Web Services will discontinue
        /// support for Amazon Web Services RoboMaker. After September 10, 2025, you will no longer
        /// be able to access the Amazon Web Services RoboMaker console or Amazon Web Services
        /// RoboMaker resources. For more information on transitioning to Batch to help run containerized
        /// simulations, visit <a href="https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/">https://aws.amazon.com/blogs/hpc/run-simulations-using-multiple-containers-in-a-single-aws-batch-job/</a>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// Updates a world template.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorldTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorldTemplate service method, as returned by RoboMaker.</returns>
        /// <exception cref="Amazon.RoboMaker.Model.InternalServerException">
        /// AWS RoboMaker experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.InvalidParameterException">
        /// A parameter specified in a request is not valid, is unsupported, or cannot be used.
        /// The returned message provides an explanation of the error value.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.RoboMaker.Model.ThrottlingException">
        /// AWS RoboMaker is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateWorldTemplate">REST API Reference for UpdateWorldTemplate Operation</seealso>
        Task<UpdateWorldTemplateResponse> UpdateWorldTemplateAsync(UpdateWorldTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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