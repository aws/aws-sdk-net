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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoboMakerPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the BatchDeleteWorlds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteWorlds operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteWorlds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDeleteWorlds">REST API Reference for BatchDeleteWorlds Operation</seealso>
        IAsyncResult BeginBatchDeleteWorlds(BatchDeleteWorldsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteWorlds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteWorlds.</param>
        /// 
        /// <returns>Returns a  BatchDeleteWorldsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDeleteWorlds">REST API Reference for BatchDeleteWorlds Operation</seealso>
        BatchDeleteWorldsResponse EndBatchDeleteWorlds(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the BatchDescribeSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeSimulationJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDescribeSimulationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDescribeSimulationJob">REST API Reference for BatchDescribeSimulationJob Operation</seealso>
        IAsyncResult BeginBatchDescribeSimulationJob(BatchDescribeSimulationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDescribeSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDescribeSimulationJob.</param>
        /// 
        /// <returns>Returns a  BatchDescribeSimulationJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/BatchDescribeSimulationJob">REST API Reference for BatchDescribeSimulationJob Operation</seealso>
        BatchDescribeSimulationJobResponse EndBatchDescribeSimulationJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CancelDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDeploymentJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDeploymentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelDeploymentJob">REST API Reference for CancelDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginCancelDeploymentJob(CancelDeploymentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDeploymentJob.</param>
        /// 
        /// <returns>Returns a  CancelDeploymentJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelDeploymentJob">REST API Reference for CancelDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        CancelDeploymentJobResponse EndCancelDeploymentJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CancelSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSimulationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJob">REST API Reference for CancelSimulationJob Operation</seealso>
        IAsyncResult BeginCancelSimulationJob(CancelSimulationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSimulationJob.</param>
        /// 
        /// <returns>Returns a  CancelSimulationJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJob">REST API Reference for CancelSimulationJob Operation</seealso>
        CancelSimulationJobResponse EndCancelSimulationJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CancelSimulationJobBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSimulationJobBatch operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSimulationJobBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJobBatch">REST API Reference for CancelSimulationJobBatch Operation</seealso>
        IAsyncResult BeginCancelSimulationJobBatch(CancelSimulationJobBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSimulationJobBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSimulationJobBatch.</param>
        /// 
        /// <returns>Returns a  CancelSimulationJobBatchResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelSimulationJobBatch">REST API Reference for CancelSimulationJobBatch Operation</seealso>
        CancelSimulationJobBatchResponse EndCancelSimulationJobBatch(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CancelWorldExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelWorldExportJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelWorldExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldExportJob">REST API Reference for CancelWorldExportJob Operation</seealso>
        IAsyncResult BeginCancelWorldExportJob(CancelWorldExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelWorldExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelWorldExportJob.</param>
        /// 
        /// <returns>Returns a  CancelWorldExportJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldExportJob">REST API Reference for CancelWorldExportJob Operation</seealso>
        CancelWorldExportJobResponse EndCancelWorldExportJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CancelWorldGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelWorldGenerationJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelWorldGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldGenerationJob">REST API Reference for CancelWorldGenerationJob Operation</seealso>
        IAsyncResult BeginCancelWorldGenerationJob(CancelWorldGenerationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelWorldGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelWorldGenerationJob.</param>
        /// 
        /// <returns>Returns a  CancelWorldGenerationJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CancelWorldGenerationJob">REST API Reference for CancelWorldGenerationJob Operation</seealso>
        CancelWorldGenerationJobResponse EndCancelWorldGenerationJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeploymentJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeploymentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateDeploymentJob">REST API Reference for CreateDeploymentJob Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginCreateDeploymentJob(CreateDeploymentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeploymentJob.</param>
        /// 
        /// <returns>Returns a  CreateDeploymentJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateDeploymentJob">REST API Reference for CreateDeploymentJob Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        CreateDeploymentJobResponse EndCreateDeploymentJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRobot operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRobot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobot">REST API Reference for CreateRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginCreateRobot(CreateRobotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRobot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRobot.</param>
        /// 
        /// <returns>Returns a  CreateRobotResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobot">REST API Reference for CreateRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        CreateRobotResponse EndCreateRobot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplication operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRobotApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplication">REST API Reference for CreateRobotApplication Operation</seealso>
        IAsyncResult BeginCreateRobotApplication(CreateRobotApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRobotApplication.</param>
        /// 
        /// <returns>Returns a  CreateRobotApplicationResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplication">REST API Reference for CreateRobotApplication Operation</seealso>
        CreateRobotApplicationResponse EndCreateRobotApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateRobotApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRobotApplicationVersion operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRobotApplicationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplicationVersion">REST API Reference for CreateRobotApplicationVersion Operation</seealso>
        IAsyncResult BeginCreateRobotApplicationVersion(CreateRobotApplicationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRobotApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRobotApplicationVersion.</param>
        /// 
        /// <returns>Returns a  CreateRobotApplicationVersionResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateRobotApplicationVersion">REST API Reference for CreateRobotApplicationVersion Operation</seealso>
        CreateRobotApplicationVersionResponse EndCreateRobotApplicationVersion(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplication operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSimulationApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplication">REST API Reference for CreateSimulationApplication Operation</seealso>
        IAsyncResult BeginCreateSimulationApplication(CreateSimulationApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSimulationApplication.</param>
        /// 
        /// <returns>Returns a  CreateSimulationApplicationResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplication">REST API Reference for CreateSimulationApplication Operation</seealso>
        CreateSimulationApplicationResponse EndCreateSimulationApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateSimulationApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationApplicationVersion operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSimulationApplicationVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplicationVersion">REST API Reference for CreateSimulationApplicationVersion Operation</seealso>
        IAsyncResult BeginCreateSimulationApplicationVersion(CreateSimulationApplicationVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSimulationApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSimulationApplicationVersion.</param>
        /// 
        /// <returns>Returns a  CreateSimulationApplicationVersionResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationApplicationVersion">REST API Reference for CreateSimulationApplicationVersion Operation</seealso>
        CreateSimulationApplicationVersionResponse EndCreateSimulationApplicationVersion(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSimulationJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSimulationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationJob">REST API Reference for CreateSimulationJob Operation</seealso>
        IAsyncResult BeginCreateSimulationJob(CreateSimulationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSimulationJob.</param>
        /// 
        /// <returns>Returns a  CreateSimulationJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateSimulationJob">REST API Reference for CreateSimulationJob Operation</seealso>
        CreateSimulationJobResponse EndCreateSimulationJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateWorldExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldExportJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorldExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldExportJob">REST API Reference for CreateWorldExportJob Operation</seealso>
        IAsyncResult BeginCreateWorldExportJob(CreateWorldExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorldExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorldExportJob.</param>
        /// 
        /// <returns>Returns a  CreateWorldExportJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldExportJob">REST API Reference for CreateWorldExportJob Operation</seealso>
        CreateWorldExportJobResponse EndCreateWorldExportJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateWorldGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldGenerationJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorldGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldGenerationJob">REST API Reference for CreateWorldGenerationJob Operation</seealso>
        IAsyncResult BeginCreateWorldGenerationJob(CreateWorldGenerationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorldGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorldGenerationJob.</param>
        /// 
        /// <returns>Returns a  CreateWorldGenerationJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldGenerationJob">REST API Reference for CreateWorldGenerationJob Operation</seealso>
        CreateWorldGenerationJobResponse EndCreateWorldGenerationJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateWorldTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorldTemplate operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorldTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldTemplate">REST API Reference for CreateWorldTemplate Operation</seealso>
        IAsyncResult BeginCreateWorldTemplate(CreateWorldTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorldTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorldTemplate.</param>
        /// 
        /// <returns>Returns a  CreateWorldTemplateResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/CreateWorldTemplate">REST API Reference for CreateWorldTemplate Operation</seealso>
        CreateWorldTemplateResponse EndCreateWorldTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobot operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRobot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobot">REST API Reference for DeleteRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginDeleteRobot(DeleteRobotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRobot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRobot.</param>
        /// 
        /// <returns>Returns a  DeleteRobotResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobot">REST API Reference for DeleteRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DeleteRobotResponse EndDeleteRobot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRobotApplication operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRobotApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobotApplication">REST API Reference for DeleteRobotApplication Operation</seealso>
        IAsyncResult BeginDeleteRobotApplication(DeleteRobotApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRobotApplication.</param>
        /// 
        /// <returns>Returns a  DeleteRobotApplicationResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteRobotApplication">REST API Reference for DeleteRobotApplication Operation</seealso>
        DeleteRobotApplicationResponse EndDeleteRobotApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulationApplication operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSimulationApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteSimulationApplication">REST API Reference for DeleteSimulationApplication Operation</seealso>
        IAsyncResult BeginDeleteSimulationApplication(DeleteSimulationApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSimulationApplication.</param>
        /// 
        /// <returns>Returns a  DeleteSimulationApplicationResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteSimulationApplication">REST API Reference for DeleteSimulationApplication Operation</seealso>
        DeleteSimulationApplicationResponse EndDeleteSimulationApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteWorldTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorldTemplate operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorldTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteWorldTemplate">REST API Reference for DeleteWorldTemplate Operation</seealso>
        IAsyncResult BeginDeleteWorldTemplate(DeleteWorldTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorldTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorldTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteWorldTemplateResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeleteWorldTemplate">REST API Reference for DeleteWorldTemplate Operation</seealso>
        DeleteWorldTemplateResponse EndDeleteWorldTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeregisterRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterRobot operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterRobot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeregisterRobot">REST API Reference for DeregisterRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginDeregisterRobot(DeregisterRobotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterRobot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterRobot.</param>
        /// 
        /// <returns>Returns a  DeregisterRobotResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DeregisterRobot">REST API Reference for DeregisterRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DeregisterRobotResponse EndDeregisterRobot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeploymentJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeploymentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeDeploymentJob">REST API Reference for DescribeDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginDescribeDeploymentJob(DescribeDeploymentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeploymentJob.</param>
        /// 
        /// <returns>Returns a  DescribeDeploymentJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeDeploymentJob">REST API Reference for DescribeDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DescribeDeploymentJobResponse EndDescribeDeploymentJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleet operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeFleet">REST API Reference for DescribeFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginDescribeFleet(DescribeFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleet.</param>
        /// 
        /// <returns>Returns a  DescribeFleetResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeFleet">REST API Reference for DescribeFleet Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DescribeFleetResponse EndDescribeFleet(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobot operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRobot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobot">REST API Reference for DescribeRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginDescribeRobot(DescribeRobotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRobot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRobot.</param>
        /// 
        /// <returns>Returns a  DescribeRobotResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobot">REST API Reference for DescribeRobot Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        DescribeRobotResponse EndDescribeRobot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRobotApplication operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRobotApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobotApplication">REST API Reference for DescribeRobotApplication Operation</seealso>
        IAsyncResult BeginDescribeRobotApplication(DescribeRobotApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRobotApplication.</param>
        /// 
        /// <returns>Returns a  DescribeRobotApplicationResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeRobotApplication">REST API Reference for DescribeRobotApplication Operation</seealso>
        DescribeRobotApplicationResponse EndDescribeRobotApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationApplication operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSimulationApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationApplication">REST API Reference for DescribeSimulationApplication Operation</seealso>
        IAsyncResult BeginDescribeSimulationApplication(DescribeSimulationApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSimulationApplication.</param>
        /// 
        /// <returns>Returns a  DescribeSimulationApplicationResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationApplication">REST API Reference for DescribeSimulationApplication Operation</seealso>
        DescribeSimulationApplicationResponse EndDescribeSimulationApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSimulationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJob">REST API Reference for DescribeSimulationJob Operation</seealso>
        IAsyncResult BeginDescribeSimulationJob(DescribeSimulationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSimulationJob.</param>
        /// 
        /// <returns>Returns a  DescribeSimulationJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJob">REST API Reference for DescribeSimulationJob Operation</seealso>
        DescribeSimulationJobResponse EndDescribeSimulationJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeSimulationJobBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulationJobBatch operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSimulationJobBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJobBatch">REST API Reference for DescribeSimulationJobBatch Operation</seealso>
        IAsyncResult BeginDescribeSimulationJobBatch(DescribeSimulationJobBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSimulationJobBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSimulationJobBatch.</param>
        /// 
        /// <returns>Returns a  DescribeSimulationJobBatchResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeSimulationJobBatch">REST API Reference for DescribeSimulationJobBatch Operation</seealso>
        DescribeSimulationJobBatchResponse EndDescribeSimulationJobBatch(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeWorld operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorld operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorld
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorld">REST API Reference for DescribeWorld Operation</seealso>
        IAsyncResult BeginDescribeWorld(DescribeWorldRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorld operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorld.</param>
        /// 
        /// <returns>Returns a  DescribeWorldResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorld">REST API Reference for DescribeWorld Operation</seealso>
        DescribeWorldResponse EndDescribeWorld(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeWorldExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldExportJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorldExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldExportJob">REST API Reference for DescribeWorldExportJob Operation</seealso>
        IAsyncResult BeginDescribeWorldExportJob(DescribeWorldExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorldExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorldExportJob.</param>
        /// 
        /// <returns>Returns a  DescribeWorldExportJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldExportJob">REST API Reference for DescribeWorldExportJob Operation</seealso>
        DescribeWorldExportJobResponse EndDescribeWorldExportJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeWorldGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldGenerationJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorldGenerationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldGenerationJob">REST API Reference for DescribeWorldGenerationJob Operation</seealso>
        IAsyncResult BeginDescribeWorldGenerationJob(DescribeWorldGenerationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorldGenerationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorldGenerationJob.</param>
        /// 
        /// <returns>Returns a  DescribeWorldGenerationJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldGenerationJob">REST API Reference for DescribeWorldGenerationJob Operation</seealso>
        DescribeWorldGenerationJobResponse EndDescribeWorldGenerationJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeWorldTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorldTemplate operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorldTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldTemplate">REST API Reference for DescribeWorldTemplate Operation</seealso>
        IAsyncResult BeginDescribeWorldTemplate(DescribeWorldTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorldTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorldTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeWorldTemplateResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/DescribeWorldTemplate">REST API Reference for DescribeWorldTemplate Operation</seealso>
        DescribeWorldTemplateResponse EndDescribeWorldTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetWorldTemplateBody operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorldTemplateBody operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorldTemplateBody
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/GetWorldTemplateBody">REST API Reference for GetWorldTemplateBody Operation</seealso>
        IAsyncResult BeginGetWorldTemplateBody(GetWorldTemplateBodyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorldTemplateBody operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorldTemplateBody.</param>
        /// 
        /// <returns>Returns a  GetWorldTemplateBodyResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/GetWorldTemplateBody">REST API Reference for GetWorldTemplateBody Operation</seealso>
        GetWorldTemplateBodyResponse EndGetWorldTemplateBody(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDeploymentJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeploymentJobs operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeploymentJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListDeploymentJobs">REST API Reference for ListDeploymentJobs Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginListDeploymentJobs(ListDeploymentJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeploymentJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeploymentJobs.</param>
        /// 
        /// <returns>Returns a  ListDeploymentJobsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListDeploymentJobs">REST API Reference for ListDeploymentJobs Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        ListDeploymentJobsResponse EndListDeploymentJobs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListFleets">REST API Reference for ListFleets Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListFleets">REST API Reference for ListFleets Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        ListFleetsResponse EndListFleets(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListRobotApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRobotApplications operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRobotApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobotApplications">REST API Reference for ListRobotApplications Operation</seealso>
        IAsyncResult BeginListRobotApplications(ListRobotApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRobotApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRobotApplications.</param>
        /// 
        /// <returns>Returns a  ListRobotApplicationsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobotApplications">REST API Reference for ListRobotApplications Operation</seealso>
        ListRobotApplicationsResponse EndListRobotApplications(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListRobots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRobots operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRobots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobots">REST API Reference for ListRobots Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginListRobots(ListRobotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRobots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRobots.</param>
        /// 
        /// <returns>Returns a  ListRobotsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListRobots">REST API Reference for ListRobots Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        ListRobotsResponse EndListRobots(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListSimulationApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationApplications operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSimulationApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationApplications">REST API Reference for ListSimulationApplications Operation</seealso>
        IAsyncResult BeginListSimulationApplications(ListSimulationApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSimulationApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSimulationApplications.</param>
        /// 
        /// <returns>Returns a  ListSimulationApplicationsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationApplications">REST API Reference for ListSimulationApplications Operation</seealso>
        ListSimulationApplicationsResponse EndListSimulationApplications(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListSimulationJobBatches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobBatches operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSimulationJobBatches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobBatches">REST API Reference for ListSimulationJobBatches Operation</seealso>
        IAsyncResult BeginListSimulationJobBatches(ListSimulationJobBatchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSimulationJobBatches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSimulationJobBatches.</param>
        /// 
        /// <returns>Returns a  ListSimulationJobBatchesResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobBatches">REST API Reference for ListSimulationJobBatches Operation</seealso>
        ListSimulationJobBatchesResponse EndListSimulationJobBatches(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListSimulationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSimulationJobs operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSimulationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobs">REST API Reference for ListSimulationJobs Operation</seealso>
        IAsyncResult BeginListSimulationJobs(ListSimulationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSimulationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSimulationJobs.</param>
        /// 
        /// <returns>Returns a  ListSimulationJobsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListSimulationJobs">REST API Reference for ListSimulationJobs Operation</seealso>
        ListSimulationJobsResponse EndListSimulationJobs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListWorldExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorldExportJobs operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorldExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldExportJobs">REST API Reference for ListWorldExportJobs Operation</seealso>
        IAsyncResult BeginListWorldExportJobs(ListWorldExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorldExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorldExportJobs.</param>
        /// 
        /// <returns>Returns a  ListWorldExportJobsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldExportJobs">REST API Reference for ListWorldExportJobs Operation</seealso>
        ListWorldExportJobsResponse EndListWorldExportJobs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListWorldGenerationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorldGenerationJobs operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorldGenerationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldGenerationJobs">REST API Reference for ListWorldGenerationJobs Operation</seealso>
        IAsyncResult BeginListWorldGenerationJobs(ListWorldGenerationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorldGenerationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorldGenerationJobs.</param>
        /// 
        /// <returns>Returns a  ListWorldGenerationJobsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldGenerationJobs">REST API Reference for ListWorldGenerationJobs Operation</seealso>
        ListWorldGenerationJobsResponse EndListWorldGenerationJobs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListWorlds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorlds operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorlds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorlds">REST API Reference for ListWorlds Operation</seealso>
        IAsyncResult BeginListWorlds(ListWorldsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorlds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorlds.</param>
        /// 
        /// <returns>Returns a  ListWorldsResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorlds">REST API Reference for ListWorlds Operation</seealso>
        ListWorldsResponse EndListWorlds(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListWorldTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorldTemplates operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorldTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldTemplates">REST API Reference for ListWorldTemplates Operation</seealso>
        IAsyncResult BeginListWorldTemplates(ListWorldTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorldTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorldTemplates.</param>
        /// 
        /// <returns>Returns a  ListWorldTemplatesResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/ListWorldTemplates">REST API Reference for ListWorldTemplates Operation</seealso>
        ListWorldTemplatesResponse EndListWorldTemplates(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the RegisterRobot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterRobot operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterRobot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RegisterRobot">REST API Reference for RegisterRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginRegisterRobot(RegisterRobotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterRobot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterRobot.</param>
        /// 
        /// <returns>Returns a  RegisterRobotResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RegisterRobot">REST API Reference for RegisterRobot Operation</seealso>
        [Obsolete("AWS RoboMaker is unable to process this request as the support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        RegisterRobotResponse EndRegisterRobot(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the RestartSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartSimulationJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestartSimulationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RestartSimulationJob">REST API Reference for RestartSimulationJob Operation</seealso>
        IAsyncResult BeginRestartSimulationJob(RestartSimulationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestartSimulationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartSimulationJob.</param>
        /// 
        /// <returns>Returns a  RestartSimulationJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/RestartSimulationJob">REST API Reference for RestartSimulationJob Operation</seealso>
        RestartSimulationJobResponse EndRestartSimulationJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartSimulationJobBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSimulationJobBatch operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSimulationJobBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/StartSimulationJobBatch">REST API Reference for StartSimulationJobBatch Operation</seealso>
        IAsyncResult BeginStartSimulationJobBatch(StartSimulationJobBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSimulationJobBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSimulationJobBatch.</param>
        /// 
        /// <returns>Returns a  StartSimulationJobBatchResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/StartSimulationJobBatch">REST API Reference for StartSimulationJobBatch Operation</seealso>
        StartSimulationJobBatchResponse EndStartSimulationJobBatch(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the SyncDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SyncDeploymentJob operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSyncDeploymentJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/SyncDeploymentJob">REST API Reference for SyncDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        IAsyncResult BeginSyncDeploymentJob(SyncDeploymentJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SyncDeploymentJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSyncDeploymentJob.</param>
        /// 
        /// <returns>Returns a  SyncDeploymentJobResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/SyncDeploymentJob">REST API Reference for SyncDeploymentJob Operation</seealso>
        [Obsolete("Support for the AWS RoboMaker application deployment feature has ended. For additional information, see https://docs.aws.amazon.com/robomaker/latest/dg/fleets.html.")]
        SyncDeploymentJobResponse EndSyncDeploymentJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRobotApplication operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRobotApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateRobotApplication">REST API Reference for UpdateRobotApplication Operation</seealso>
        IAsyncResult BeginUpdateRobotApplication(UpdateRobotApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRobotApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRobotApplication.</param>
        /// 
        /// <returns>Returns a  UpdateRobotApplicationResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateRobotApplication">REST API Reference for UpdateRobotApplication Operation</seealso>
        UpdateRobotApplicationResponse EndUpdateRobotApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSimulationApplication operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSimulationApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateSimulationApplication">REST API Reference for UpdateSimulationApplication Operation</seealso>
        IAsyncResult BeginUpdateSimulationApplication(UpdateSimulationApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSimulationApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSimulationApplication.</param>
        /// 
        /// <returns>Returns a  UpdateSimulationApplicationResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateSimulationApplication">REST API Reference for UpdateSimulationApplication Operation</seealso>
        UpdateSimulationApplicationResponse EndUpdateSimulationApplication(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateWorldTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorldTemplate operation on AmazonRoboMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorldTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateWorldTemplate">REST API Reference for UpdateWorldTemplate Operation</seealso>
        IAsyncResult BeginUpdateWorldTemplate(UpdateWorldTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorldTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorldTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateWorldTemplateResult from RoboMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/robomaker-2018-06-29/UpdateWorldTemplate">REST API Reference for UpdateWorldTemplate Operation</seealso>
        UpdateWorldTemplateResponse EndUpdateWorldTemplate(IAsyncResult asyncResult);

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