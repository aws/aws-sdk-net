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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Neptunedata.Model;

#pragma warning disable CS1570
namespace Amazon.Neptunedata
{
    /// <summary>
    /// <para>Interface for accessing Neptunedata</para>
    ///
    /// Neptune Data API 
    /// <para>
    /// The Amazon Neptune data API provides SDK support for more than 40 of Neptune's data
    /// operations, including data loading, query execution, data inquiry, and machine learning.
    /// It supports the Gremlin and openCypher query languages, and is available in all SDK
    /// languages. It automatically signs API requests and greatly simplifies integrating
    /// Neptune into your applications.
    /// 
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonNeptunedata : IAmazonService, IDisposable
    {


        
        #region  CancelGremlinQuery


        /// <summary>
        /// Cancels a Gremlin query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status-cancel.html">Gremlin
        /// query cancellation</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelquery">neptune-db:CancelQuery</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelGremlinQuery service method.</param>
        /// 
        /// <returns>The response from the CancelGremlinQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelGremlinQuery">REST API Reference for CancelGremlinQuery Operation</seealso>
        CancelGremlinQueryResponse CancelGremlinQuery(CancelGremlinQueryRequest request);



        /// <summary>
        /// Cancels a Gremlin query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status-cancel.html">Gremlin
        /// query cancellation</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelquery">neptune-db:CancelQuery</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelGremlinQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelGremlinQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelGremlinQuery">REST API Reference for CancelGremlinQuery Operation</seealso>
        Task<CancelGremlinQueryResponse> CancelGremlinQueryAsync(CancelGremlinQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelLoaderJob


        /// <summary>
        /// Cancels a specified load job. This is an HTTP <c>DELETE</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelloaderjob">neptune-db:CancelLoaderJob</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelLoaderJob service method.</param>
        /// 
        /// <returns>The response from the CancelLoaderJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelLoaderJob">REST API Reference for CancelLoaderJob Operation</seealso>
        CancelLoaderJobResponse CancelLoaderJob(CancelLoaderJobRequest request);



        /// <summary>
        /// Cancels a specified load job. This is an HTTP <c>DELETE</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelloaderjob">neptune-db:CancelLoaderJob</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelLoaderJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelLoaderJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelLoaderJob">REST API Reference for CancelLoaderJob Operation</seealso>
        Task<CancelLoaderJobResponse> CancelLoaderJobAsync(CancelLoaderJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelMLDataProcessingJob


        /// <summary>
        /// Cancels a Neptune ML data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmldataprocessingjob">neptune-db:CancelMLDataProcessingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLDataProcessingJob service method.</param>
        /// 
        /// <returns>The response from the CancelMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLDataProcessingJob">REST API Reference for CancelMLDataProcessingJob Operation</seealso>
        CancelMLDataProcessingJobResponse CancelMLDataProcessingJob(CancelMLDataProcessingJobRequest request);



        /// <summary>
        /// Cancels a Neptune ML data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmldataprocessingjob">neptune-db:CancelMLDataProcessingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLDataProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLDataProcessingJob">REST API Reference for CancelMLDataProcessingJob Operation</seealso>
        Task<CancelMLDataProcessingJobResponse> CancelMLDataProcessingJobAsync(CancelMLDataProcessingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelMLModelTrainingJob


        /// <summary>
        /// Cancels a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltrainingjob">neptune-db:CancelMLModelTrainingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTrainingJob service method.</param>
        /// 
        /// <returns>The response from the CancelMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTrainingJob">REST API Reference for CancelMLModelTrainingJob Operation</seealso>
        CancelMLModelTrainingJobResponse CancelMLModelTrainingJob(CancelMLModelTrainingJobRequest request);



        /// <summary>
        /// Cancels a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltrainingjob">neptune-db:CancelMLModelTrainingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTrainingJob">REST API Reference for CancelMLModelTrainingJob Operation</seealso>
        Task<CancelMLModelTrainingJobResponse> CancelMLModelTrainingJobAsync(CancelMLModelTrainingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelMLModelTransformJob


        /// <summary>
        /// Cancels a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltransformjob">neptune-db:CancelMLModelTransformJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTransformJob service method.</param>
        /// 
        /// <returns>The response from the CancelMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTransformJob">REST API Reference for CancelMLModelTransformJob Operation</seealso>
        CancelMLModelTransformJobResponse CancelMLModelTransformJob(CancelMLModelTransformJobRequest request);



        /// <summary>
        /// Cancels a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelmlmodeltransformjob">neptune-db:CancelMLModelTransformJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTransformJob">REST API Reference for CancelMLModelTransformJob Operation</seealso>
        Task<CancelMLModelTransformJobResponse> CancelMLModelTransformJobAsync(CancelMLModelTransformJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelOpenCypherQuery


        /// <summary>
        /// Cancels a specified openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelquery">neptune-db:CancelQuery</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelOpenCypherQuery service method.</param>
        /// 
        /// <returns>The response from the CancelOpenCypherQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelOpenCypherQuery">REST API Reference for CancelOpenCypherQuery Operation</seealso>
        CancelOpenCypherQueryResponse CancelOpenCypherQuery(CancelOpenCypherQueryRequest request);



        /// <summary>
        /// Cancels a specified openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelquery">neptune-db:CancelQuery</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelOpenCypherQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelOpenCypherQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelOpenCypherQuery">REST API Reference for CancelOpenCypherQuery Operation</seealso>
        Task<CancelOpenCypherQueryResponse> CancelOpenCypherQueryAsync(CancelOpenCypherQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMLEndpoint


        /// <summary>
        /// Creates a new Neptune ML inference endpoint that lets you query one specific model
        /// that the model-training process constructed. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#createmlendpoint">neptune-db:CreateMLEndpoint</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CreateMLEndpoint">REST API Reference for CreateMLEndpoint Operation</seealso>
        CreateMLEndpointResponse CreateMLEndpoint(CreateMLEndpointRequest request);



        /// <summary>
        /// Creates a new Neptune ML inference endpoint that lets you query one specific model
        /// that the model-training process constructed. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#createmlendpoint">neptune-db:CreateMLEndpoint</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CreateMLEndpoint">REST API Reference for CreateMLEndpoint Operation</seealso>
        Task<CreateMLEndpointResponse> CreateMLEndpointAsync(CreateMLEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMLEndpoint


        /// <summary>
        /// Cancels the creation of a Neptune ML inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletemlendpoint">neptune-db:DeleteMLEndpoint</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteMLEndpoint">REST API Reference for DeleteMLEndpoint Operation</seealso>
        DeleteMLEndpointResponse DeleteMLEndpoint(DeleteMLEndpointRequest request);



        /// <summary>
        /// Cancels the creation of a Neptune ML inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletemlendpoint">neptune-db:DeleteMLEndpoint</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteMLEndpoint">REST API Reference for DeleteMLEndpoint Operation</seealso>
        Task<DeleteMLEndpointResponse> DeleteMLEndpointAsync(DeleteMLEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePropertygraphStatistics


        /// <summary>
        /// Deletes statistics for Gremlin and openCypher (property graph) data.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletestatistics">neptune-db:DeleteStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePropertygraphStatistics service method.</param>
        /// 
        /// <returns>The response from the DeletePropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeletePropertygraphStatistics">REST API Reference for DeletePropertygraphStatistics Operation</seealso>
        DeletePropertygraphStatisticsResponse DeletePropertygraphStatistics(DeletePropertygraphStatisticsRequest request);



        /// <summary>
        /// Deletes statistics for Gremlin and openCypher (property graph) data.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletestatistics">neptune-db:DeleteStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePropertygraphStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeletePropertygraphStatistics">REST API Reference for DeletePropertygraphStatistics Operation</seealso>
        Task<DeletePropertygraphStatisticsResponse> DeletePropertygraphStatisticsAsync(DeletePropertygraphStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSparqlStatistics


        /// <summary>
        /// Deletes SPARQL statistics
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletestatistics">neptune-db:DeleteStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSparqlStatistics service method.</param>
        /// 
        /// <returns>The response from the DeleteSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteSparqlStatistics">REST API Reference for DeleteSparqlStatistics Operation</seealso>
        DeleteSparqlStatisticsResponse DeleteSparqlStatistics(DeleteSparqlStatisticsRequest request);



        /// <summary>
        /// Deletes SPARQL statistics
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletestatistics">neptune-db:DeleteStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSparqlStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteSparqlStatistics">REST API Reference for DeleteSparqlStatistics Operation</seealso>
        Task<DeleteSparqlStatisticsResponse> DeleteSparqlStatisticsAsync(DeleteSparqlStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecuteFastReset


        /// <summary>
        /// The fast reset REST API lets you reset a Neptune graph quicky and easily, removing
        /// all of its data.
        /// 
        ///  
        /// <para>
        /// Neptune fast reset is a two-step process. First you call <c>ExecuteFastReset</c> with
        /// <c>action</c> set to <c>initiateDatabaseReset</c>. This returns a UUID token which
        /// you then include when calling <c>ExecuteFastReset</c> again with <c>action</c> set
        /// to <c>performDatabaseReset</c>. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/manage-console-fast-reset.html">Empty
        /// an Amazon Neptune DB cluster using the fast reset API</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#resetdatabase">neptune-db:ResetDatabase</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteFastReset service method.</param>
        /// 
        /// <returns>The response from the ExecuteFastReset service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MethodNotAllowedException">
        /// Raised when the HTTP method used by a request is not supported by the endpoint being
        /// used.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ServerShutdownException">
        /// Raised when the server shuts down while processing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteFastReset">REST API Reference for ExecuteFastReset Operation</seealso>
        ExecuteFastResetResponse ExecuteFastReset(ExecuteFastResetRequest request);



        /// <summary>
        /// The fast reset REST API lets you reset a Neptune graph quicky and easily, removing
        /// all of its data.
        /// 
        ///  
        /// <para>
        /// Neptune fast reset is a two-step process. First you call <c>ExecuteFastReset</c> with
        /// <c>action</c> set to <c>initiateDatabaseReset</c>. This returns a UUID token which
        /// you then include when calling <c>ExecuteFastReset</c> again with <c>action</c> set
        /// to <c>performDatabaseReset</c>. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/manage-console-fast-reset.html">Empty
        /// an Amazon Neptune DB cluster using the fast reset API</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#resetdatabase">neptune-db:ResetDatabase</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteFastReset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteFastReset service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MethodNotAllowedException">
        /// Raised when the HTTP method used by a request is not supported by the endpoint being
        /// used.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ServerShutdownException">
        /// Raised when the server shuts down while processing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteFastReset">REST API Reference for ExecuteFastReset Operation</seealso>
        Task<ExecuteFastResetResponse> ExecuteFastResetAsync(ExecuteFastResetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecuteGremlinExplainQuery


        /// <summary>
        /// Executes a Gremlin Explain query.
        /// 
        ///  
        /// <para>
        /// Amazon Neptune has added a Gremlin feature named <c>explain</c> that provides is a
        /// self-service tool for understanding the execution approach being taken by the Neptune
        /// engine for the query. You invoke it by adding an <c>explain</c> parameter to an HTTP
        /// call that submits a Gremlin query.
        /// </para>
        ///  
        /// <para>
        /// The explain feature provides information about the logical structure of query execution
        /// plans. You can use this information to identify potential evaluation and execution
        /// bottlenecks and to tune your query, as explained in <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-traversal-tuning.html">Tuning
        /// Gremlin queries</a>. You can also use query hints to improve query execution plans.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows one
        /// of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinExplainQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteGremlinExplainQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinExplainQuery">REST API Reference for ExecuteGremlinExplainQuery Operation</seealso>
        ExecuteGremlinExplainQueryResponse ExecuteGremlinExplainQuery(ExecuteGremlinExplainQueryRequest request);



        /// <summary>
        /// Executes a Gremlin Explain query.
        /// 
        ///  
        /// <para>
        /// Amazon Neptune has added a Gremlin feature named <c>explain</c> that provides is a
        /// self-service tool for understanding the execution approach being taken by the Neptune
        /// engine for the query. You invoke it by adding an <c>explain</c> parameter to an HTTP
        /// call that submits a Gremlin query.
        /// </para>
        ///  
        /// <para>
        /// The explain feature provides information about the logical structure of query execution
        /// plans. You can use this information to identify potential evaluation and execution
        /// bottlenecks and to tune your query, as explained in <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-traversal-tuning.html">Tuning
        /// Gremlin queries</a>. You can also use query hints to improve query execution plans.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows one
        /// of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinExplainQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteGremlinExplainQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinExplainQuery">REST API Reference for ExecuteGremlinExplainQuery Operation</seealso>
        Task<ExecuteGremlinExplainQueryResponse> ExecuteGremlinExplainQueryAsync(ExecuteGremlinExplainQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecuteGremlinProfileQuery


        /// <summary>
        /// Executes a Gremlin Profile query, which runs a specified traversal, collects various
        /// metrics about the run, and produces a profile report as output. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
        /// profile API in Neptune</a> for details.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinProfileQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteGremlinProfileQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinProfileQuery">REST API Reference for ExecuteGremlinProfileQuery Operation</seealso>
        ExecuteGremlinProfileQueryResponse ExecuteGremlinProfileQuery(ExecuteGremlinProfileQueryRequest request);



        /// <summary>
        /// Executes a Gremlin Profile query, which runs a specified traversal, collects various
        /// metrics about the run, and produces a profile report as output. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
        /// profile API in Neptune</a> for details.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinProfileQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteGremlinProfileQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinProfileQuery">REST API Reference for ExecuteGremlinProfileQuery Operation</seealso>
        Task<ExecuteGremlinProfileQueryResponse> ExecuteGremlinProfileQueryAsync(ExecuteGremlinProfileQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecuteGremlinQuery


        /// <summary>
        /// This commands executes a Gremlin query. Amazon Neptune is compatible with Apache TinkerPop3
        /// and Gremlin, so you can use the Gremlin traversal language to query the graph, as
        /// described under <a href="https://tinkerpop.apache.org/docs/current/reference/#graph">The
        /// Graph</a> in the Apache TinkerPop3 documentation. More details can also be found in
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-gremlin.html">Accessing
        /// a Neptune graph with Gremlin</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that enables one
        /// of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteGremlinQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinQuery">REST API Reference for ExecuteGremlinQuery Operation</seealso>
        ExecuteGremlinQueryResponse ExecuteGremlinQuery(ExecuteGremlinQueryRequest request);



        /// <summary>
        /// This commands executes a Gremlin query. Amazon Neptune is compatible with Apache TinkerPop3
        /// and Gremlin, so you can use the Gremlin traversal language to query the graph, as
        /// described under <a href="https://tinkerpop.apache.org/docs/current/reference/#graph">The
        /// Graph</a> in the Apache TinkerPop3 documentation. More details can also be found in
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-gremlin.html">Accessing
        /// a Neptune graph with Gremlin</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that enables one
        /// of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteGremlinQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinQuery">REST API Reference for ExecuteGremlinQuery Operation</seealso>
        Task<ExecuteGremlinQueryResponse> ExecuteGremlinQueryAsync(ExecuteGremlinQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecuteOpenCypherExplainQuery


        /// <summary>
        /// Executes an openCypher <c>explain</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-explain.html">The
        /// openCypher explain feature</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherExplainQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteOpenCypherExplainQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherExplainQuery">REST API Reference for ExecuteOpenCypherExplainQuery Operation</seealso>
        ExecuteOpenCypherExplainQueryResponse ExecuteOpenCypherExplainQuery(ExecuteOpenCypherExplainQueryRequest request);



        /// <summary>
        /// Executes an openCypher <c>explain</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-explain.html">The
        /// openCypher explain feature</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherExplainQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteOpenCypherExplainQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherExplainQuery">REST API Reference for ExecuteOpenCypherExplainQuery Operation</seealso>
        Task<ExecuteOpenCypherExplainQueryResponse> ExecuteOpenCypherExplainQueryAsync(ExecuteOpenCypherExplainQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExecuteOpenCypherQuery


        /// <summary>
        /// Executes an openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher.html">Accessing
        /// the Neptune Graph with openCypher</a> for more information.
        /// 
        ///  
        /// <para>
        /// Neptune supports building graph applications using openCypher, which is currently
        /// one of the most popular query languages among developers working with graph databases.
        /// Developers, business analysts, and data scientists like openCypher's declarative,
        /// SQL-inspired syntax because it provides a familiar structure in which to querying
        /// property graphs.
        /// </para>
        ///  
        /// <para>
        /// The openCypher language was originally developed by Neo4j, then open-sourced in 2015
        /// and contributed to the <a href="https://opencypher.org/">openCypher project</a> under
        /// an Apache 2 open-source license.
        /// </para>
        ///  
        /// <para>
        /// Note that when invoking this operation in a Neptune cluster that has IAM authentication
        /// enabled, the IAM user or role making the request must have a policy attached that
        /// allows one of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note also that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteOpenCypherQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherQuery">REST API Reference for ExecuteOpenCypherQuery Operation</seealso>
        ExecuteOpenCypherQueryResponse ExecuteOpenCypherQuery(ExecuteOpenCypherQueryRequest request);



        /// <summary>
        /// Executes an openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher.html">Accessing
        /// the Neptune Graph with openCypher</a> for more information.
        /// 
        ///  
        /// <para>
        /// Neptune supports building graph applications using openCypher, which is currently
        /// one of the most popular query languages among developers working with graph databases.
        /// Developers, business analysts, and data scientists like openCypher's declarative,
        /// SQL-inspired syntax because it provides a familiar structure in which to querying
        /// property graphs.
        /// </para>
        ///  
        /// <para>
        /// The openCypher language was originally developed by Neo4j, then open-sourced in 2015
        /// and contributed to the <a href="https://opencypher.org/">openCypher project</a> under
        /// an Apache 2 open-source license.
        /// </para>
        ///  
        /// <para>
        /// Note that when invoking this operation in a Neptune cluster that has IAM authentication
        /// enabled, the IAM user or role making the request must have a policy attached that
        /// allows one of the following IAM actions in that cluster, depending on the query:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#readdataviaquery">neptune-db:ReadDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#writedataviaquery">neptune-db:WriteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#deletedataviaquery">neptune-db:DeleteDataViaQuery</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note also that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteOpenCypherQuery service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.CancelledByUserException">
        /// Raised when a user cancelled a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MalformedQueryException">
        /// Raised when a query is submitted that is syntactically incorrect or does not pass
        /// additional validation.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitExceededException">
        /// Raised when the number of active queries exceeds what the server can process. The
        /// query in question can be retried when the system is less busy.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryLimitException">
        /// Raised when the size of a query exceeds the system limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.QueryTooLargeException">
        /// Raised when the body of a query is too large.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherQuery">REST API Reference for ExecuteOpenCypherQuery Operation</seealso>
        Task<ExecuteOpenCypherQueryResponse> ExecuteOpenCypherQueryAsync(ExecuteOpenCypherQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEngineStatus


        /// <summary>
        /// Retrieves the status of the graph database on the host.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getenginestatus">neptune-db:GetEngineStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEngineStatus service method.</param>
        /// 
        /// <returns>The response from the GetEngineStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetEngineStatus">REST API Reference for GetEngineStatus Operation</seealso>
        GetEngineStatusResponse GetEngineStatus(GetEngineStatusRequest request);



        /// <summary>
        /// Retrieves the status of the graph database on the host.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getenginestatus">neptune-db:GetEngineStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEngineStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEngineStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetEngineStatus">REST API Reference for GetEngineStatus Operation</seealso>
        Task<GetEngineStatusResponse> GetEngineStatusAsync(GetEngineStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGremlinQueryStatus


        /// <summary>
        /// Gets the status of a specified Gremlin query.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGremlinQueryStatus service method.</param>
        /// 
        /// <returns>The response from the GetGremlinQueryStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetGremlinQueryStatus">REST API Reference for GetGremlinQueryStatus Operation</seealso>
        GetGremlinQueryStatusResponse GetGremlinQueryStatus(GetGremlinQueryStatusRequest request);



        /// <summary>
        /// Gets the status of a specified Gremlin query.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGremlinQueryStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGremlinQueryStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetGremlinQueryStatus">REST API Reference for GetGremlinQueryStatus Operation</seealso>
        Task<GetGremlinQueryStatusResponse> GetGremlinQueryStatusAsync(GetGremlinQueryStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoaderJobStatus


        /// <summary>
        /// Gets status information about a specified load job. Neptune keeps track of the most
        /// recent 1,024 bulk load jobs, and stores the last 10,000 error details per job.
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getloaderjobstatus">neptune-db:GetLoaderJobStatus</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoaderJobStatus service method.</param>
        /// 
        /// <returns>The response from the GetLoaderJobStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetLoaderJobStatus">REST API Reference for GetLoaderJobStatus Operation</seealso>
        GetLoaderJobStatusResponse GetLoaderJobStatus(GetLoaderJobStatusRequest request);



        /// <summary>
        /// Gets status information about a specified load job. Neptune keeps track of the most
        /// recent 1,024 bulk load jobs, and stores the last 10,000 error details per job.
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getloaderjobstatus">neptune-db:GetLoaderJobStatus</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoaderJobStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLoaderJobStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetLoaderJobStatus">REST API Reference for GetLoaderJobStatus Operation</seealso>
        Task<GetLoaderJobStatusResponse> GetLoaderJobStatusAsync(GetLoaderJobStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMLDataProcessingJob


        /// <summary>
        /// Retrieves information about a specified data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmldataprocessingjobstatus">neptune-db:neptune-db:GetMLDataProcessingJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLDataProcessingJob service method.</param>
        /// 
        /// <returns>The response from the GetMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLDataProcessingJob">REST API Reference for GetMLDataProcessingJob Operation</seealso>
        GetMLDataProcessingJobResponse GetMLDataProcessingJob(GetMLDataProcessingJobRequest request);



        /// <summary>
        /// Retrieves information about a specified data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmldataprocessingjobstatus">neptune-db:neptune-db:GetMLDataProcessingJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLDataProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLDataProcessingJob">REST API Reference for GetMLDataProcessingJob Operation</seealso>
        Task<GetMLDataProcessingJobResponse> GetMLDataProcessingJobAsync(GetMLDataProcessingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMLEndpoint


        /// <summary>
        /// Retrieves details about an inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlendpointstatus">neptune-db:GetMLEndpointStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLEndpoint">REST API Reference for GetMLEndpoint Operation</seealso>
        GetMLEndpointResponse GetMLEndpoint(GetMLEndpointRequest request);



        /// <summary>
        /// Retrieves details about an inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlendpointstatus">neptune-db:GetMLEndpointStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLEndpoint service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLEndpoint">REST API Reference for GetMLEndpoint Operation</seealso>
        Task<GetMLEndpointResponse> GetMLEndpointAsync(GetMLEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMLModelTrainingJob


        /// <summary>
        /// Retrieves information about a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlmodeltrainingjobstatus">neptune-db:GetMLModelTrainingJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTrainingJob service method.</param>
        /// 
        /// <returns>The response from the GetMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTrainingJob">REST API Reference for GetMLModelTrainingJob Operation</seealso>
        GetMLModelTrainingJobResponse GetMLModelTrainingJob(GetMLModelTrainingJobRequest request);



        /// <summary>
        /// Retrieves information about a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlmodeltrainingjobstatus">neptune-db:GetMLModelTrainingJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTrainingJob">REST API Reference for GetMLModelTrainingJob Operation</seealso>
        Task<GetMLModelTrainingJobResponse> GetMLModelTrainingJobAsync(GetMLModelTrainingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMLModelTransformJob


        /// <summary>
        /// Gets information about a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlmodeltransformjobstatus">neptune-db:GetMLModelTransformJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTransformJob service method.</param>
        /// 
        /// <returns>The response from the GetMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTransformJob">REST API Reference for GetMLModelTransformJob Operation</seealso>
        GetMLModelTransformJobResponse GetMLModelTransformJob(GetMLModelTransformJobRequest request);



        /// <summary>
        /// Gets information about a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getmlmodeltransformjobstatus">neptune-db:GetMLModelTransformJobStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTransformJob">REST API Reference for GetMLModelTransformJob Operation</seealso>
        Task<GetMLModelTransformJobResponse> GetMLModelTransformJobAsync(GetMLModelTransformJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOpenCypherQueryStatus


        /// <summary>
        /// Retrieves the status of a specified openCypher query.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenCypherQueryStatus service method.</param>
        /// 
        /// <returns>The response from the GetOpenCypherQueryStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetOpenCypherQueryStatus">REST API Reference for GetOpenCypherQueryStatus Operation</seealso>
        GetOpenCypherQueryStatusResponse GetOpenCypherQueryStatus(GetOpenCypherQueryStatusRequest request);



        /// <summary>
        /// Retrieves the status of a specified openCypher query.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenCypherQueryStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOpenCypherQueryStatus service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetOpenCypherQueryStatus">REST API Reference for GetOpenCypherQueryStatus Operation</seealso>
        Task<GetOpenCypherQueryStatusResponse> GetOpenCypherQueryStatusAsync(GetOpenCypherQueryStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPropertygraphStatistics


        /// <summary>
        /// Gets property graph statistics (Gremlin and openCypher).
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstatisticsstatus">neptune-db:GetStatisticsStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStatistics service method.</param>
        /// 
        /// <returns>The response from the GetPropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStatistics">REST API Reference for GetPropertygraphStatistics Operation</seealso>
        GetPropertygraphStatisticsResponse GetPropertygraphStatistics(GetPropertygraphStatisticsRequest request);



        /// <summary>
        /// Gets property graph statistics (Gremlin and openCypher).
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstatisticsstatus">neptune-db:GetStatisticsStatus</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStatistics">REST API Reference for GetPropertygraphStatistics Operation</seealso>
        Task<GetPropertygraphStatisticsResponse> GetPropertygraphStatisticsAsync(GetPropertygraphStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPropertygraphStream


        /// <summary>
        /// Gets a stream for a property graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <c>GetPropertygraphStream</c>
        /// lets you collect these change-log entries for a property graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that enables one
        /// of the following IAM actions, depending on the query:
        /// </para>
        ///  
        /// <para>
        /// Note that you can restrict property-graph queries using the following IAM context
        /// keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStream service method.</param>
        /// 
        /// <returns>The response from the GetPropertygraphStream service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ExpiredStreamException">
        /// Raised when a request attempts to access an stream that has expired.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StreamRecordsNotFoundException">
        /// Raised when stream records requested by a query cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ThrottlingException">
        /// Raised when the rate of requests exceeds the maximum throughput. Requests can be retried
        /// after encountering this exception.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStream">REST API Reference for GetPropertygraphStream Operation</seealso>
        GetPropertygraphStreamResponse GetPropertygraphStream(GetPropertygraphStreamRequest request);



        /// <summary>
        /// Gets a stream for a property graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <c>GetPropertygraphStream</c>
        /// lets you collect these change-log entries for a property graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that enables one
        /// of the following IAM actions, depending on the query:
        /// </para>
        ///  
        /// <para>
        /// Note that you can restrict property-graph queries using the following IAM context
        /// keys:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertygraphStream service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ExpiredStreamException">
        /// Raised when a request attempts to access an stream that has expired.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StreamRecordsNotFoundException">
        /// Raised when stream records requested by a query cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ThrottlingException">
        /// Raised when the rate of requests exceeds the maximum throughput. Requests can be retried
        /// after encountering this exception.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStream">REST API Reference for GetPropertygraphStream Operation</seealso>
        Task<GetPropertygraphStreamResponse> GetPropertygraphStreamAsync(GetPropertygraphStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPropertygraphSummary


        /// <summary>
        /// Gets a graph summary for a property graph.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getgraphsummary">neptune-db:GetGraphSummary</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphSummary service method.</param>
        /// 
        /// <returns>The response from the GetPropertygraphSummary service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphSummary">REST API Reference for GetPropertygraphSummary Operation</seealso>
        GetPropertygraphSummaryResponse GetPropertygraphSummary(GetPropertygraphSummaryRequest request);



        /// <summary>
        /// Gets a graph summary for a property graph.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getgraphsummary">neptune-db:GetGraphSummary</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPropertygraphSummary service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphSummary">REST API Reference for GetPropertygraphSummary Operation</seealso>
        Task<GetPropertygraphSummaryResponse> GetPropertygraphSummaryAsync(GetPropertygraphSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRDFGraphSummary


        /// <summary>
        /// Gets a graph summary for an RDF graph.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getgraphsummary">neptune-db:GetGraphSummary</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRDFGraphSummary service method.</param>
        /// 
        /// <returns>The response from the GetRDFGraphSummary service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetRDFGraphSummary">REST API Reference for GetRDFGraphSummary Operation</seealso>
        GetRDFGraphSummaryResponse GetRDFGraphSummary(GetRDFGraphSummaryRequest request);



        /// <summary>
        /// Gets a graph summary for an RDF graph.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getgraphsummary">neptune-db:GetGraphSummary</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRDFGraphSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRDFGraphSummary service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetRDFGraphSummary">REST API Reference for GetRDFGraphSummary Operation</seealso>
        Task<GetRDFGraphSummaryResponse> GetRDFGraphSummaryAsync(GetRDFGraphSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSparqlStatistics


        /// <summary>
        /// Gets RDF statistics (SPARQL).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStatistics service method.</param>
        /// 
        /// <returns>The response from the GetSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStatistics">REST API Reference for GetSparqlStatistics Operation</seealso>
        GetSparqlStatisticsResponse GetSparqlStatistics(GetSparqlStatisticsRequest request);



        /// <summary>
        /// Gets RDF statistics (SPARQL).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStatistics">REST API Reference for GetSparqlStatistics Operation</seealso>
        Task<GetSparqlStatisticsResponse> GetSparqlStatisticsAsync(GetSparqlStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSparqlStream


        /// <summary>
        /// Gets a stream for an RDF graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <c>GetSparqlStream</c>
        /// lets you collect these change-log entries for an RDF graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Sparql</a>
        /// IAM condition key can be used in the policy document to restrict the use of SPARQL
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStream service method.</param>
        /// 
        /// <returns>The response from the GetSparqlStream service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ExpiredStreamException">
        /// Raised when a request attempts to access an stream that has expired.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StreamRecordsNotFoundException">
        /// Raised when stream records requested by a query cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ThrottlingException">
        /// Raised when the rate of requests exceeds the maximum throughput. Requests can be retried
        /// after encountering this exception.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStream">REST API Reference for GetSparqlStream Operation</seealso>
        GetSparqlStreamResponse GetSparqlStream(GetSparqlStreamRequest request);



        /// <summary>
        /// Gets a stream for an RDF graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <c>GetSparqlStream</c>
        /// lets you collect these change-log entries for an RDF graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <c>1</c>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
        /// </para>
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Sparql</a>
        /// IAM condition key can be used in the policy document to restrict the use of SPARQL
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSparqlStream service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ExpiredStreamException">
        /// Raised when a request attempts to access an stream that has expired.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MemoryLimitExceededException">
        /// Raised when a request fails because of insufficient memory resources. The request
        /// can be retried.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StreamRecordsNotFoundException">
        /// Raised when stream records requested by a query cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ThrottlingException">
        /// Raised when the rate of requests exceeds the maximum throughput. Requests can be retried
        /// after encountering this exception.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStream">REST API Reference for GetSparqlStream Operation</seealso>
        Task<GetSparqlStreamResponse> GetSparqlStreamAsync(GetSparqlStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGremlinQueries


        /// <summary>
        /// Lists active Gremlin queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status.html">Gremlin
        /// query status API</a> for details about the output.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGremlinQueries service method.</param>
        /// 
        /// <returns>The response from the ListGremlinQueries service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListGremlinQueries">REST API Reference for ListGremlinQueries Operation</seealso>
        ListGremlinQueriesResponse ListGremlinQueries(ListGremlinQueriesRequest request);



        /// <summary>
        /// Lists active Gremlin queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status.html">Gremlin
        /// query status API</a> for details about the output.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Gremlin</a>
        /// IAM condition key can be used in the policy document to restrict the use of Gremlin
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGremlinQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGremlinQueries service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListGremlinQueries">REST API Reference for ListGremlinQueries Operation</seealso>
        Task<ListGremlinQueriesResponse> ListGremlinQueriesAsync(ListGremlinQueriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLoaderJobs


        /// <summary>
        /// Retrieves a list of the <c>loadIds</c> for all active loader jobs.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listloaderjobs">neptune-db:ListLoaderJobs</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoaderJobs service method.</param>
        /// 
        /// <returns>The response from the ListLoaderJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListLoaderJobs">REST API Reference for ListLoaderJobs Operation</seealso>
        ListLoaderJobsResponse ListLoaderJobs(ListLoaderJobsRequest request);



        /// <summary>
        /// Retrieves a list of the <c>loadIds</c> for all active loader jobs.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listloaderjobs">neptune-db:ListLoaderJobs</a>
        /// IAM action in that cluster..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLoaderJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLoaderJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListLoaderJobs">REST API Reference for ListLoaderJobs Operation</seealso>
        Task<ListLoaderJobsResponse> ListLoaderJobsAsync(ListLoaderJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMLDataProcessingJobs


        /// <summary>
        /// Returns a list of Neptune ML data processing jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html#machine-learning-api-dataprocessing-list-jobs">Listing
        /// active data-processing jobs using the Neptune ML dataprocessing command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmldataprocessingjobs">neptune-db:ListMLDataProcessingJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLDataProcessingJobs service method.</param>
        /// 
        /// <returns>The response from the ListMLDataProcessingJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLDataProcessingJobs">REST API Reference for ListMLDataProcessingJobs Operation</seealso>
        ListMLDataProcessingJobsResponse ListMLDataProcessingJobs(ListMLDataProcessingJobsRequest request);



        /// <summary>
        /// Returns a list of Neptune ML data processing jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html#machine-learning-api-dataprocessing-list-jobs">Listing
        /// active data-processing jobs using the Neptune ML dataprocessing command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmldataprocessingjobs">neptune-db:ListMLDataProcessingJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLDataProcessingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLDataProcessingJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLDataProcessingJobs">REST API Reference for ListMLDataProcessingJobs Operation</seealso>
        Task<ListMLDataProcessingJobsResponse> ListMLDataProcessingJobsAsync(ListMLDataProcessingJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMLEndpoints


        /// <summary>
        /// Lists existing inference endpoints. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmlendpoints">neptune-db:ListMLEndpoints</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListMLEndpoints service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLEndpoints">REST API Reference for ListMLEndpoints Operation</seealso>
        ListMLEndpointsResponse ListMLEndpoints(ListMLEndpointsRequest request);



        /// <summary>
        /// Lists existing inference endpoints. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmlendpoints">neptune-db:ListMLEndpoints</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLEndpoints service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLEndpoints">REST API Reference for ListMLEndpoints Operation</seealso>
        Task<ListMLEndpointsResponse> ListMLEndpointsAsync(ListMLEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMLModelTrainingJobs


        /// <summary>
        /// Lists Neptune ML model-training jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#neptune-db:listmlmodeltrainingjobs">neptune-db:neptune-db:ListMLModelTrainingJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTrainingJobs service method.</param>
        /// 
        /// <returns>The response from the ListMLModelTrainingJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTrainingJobs">REST API Reference for ListMLModelTrainingJobs Operation</seealso>
        ListMLModelTrainingJobsResponse ListMLModelTrainingJobs(ListMLModelTrainingJobsRequest request);



        /// <summary>
        /// Lists Neptune ML model-training jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#neptune-db:listmlmodeltrainingjobs">neptune-db:neptune-db:ListMLModelTrainingJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTrainingJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLModelTrainingJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTrainingJobs">REST API Reference for ListMLModelTrainingJobs Operation</seealso>
        Task<ListMLModelTrainingJobsResponse> ListMLModelTrainingJobsAsync(ListMLModelTrainingJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMLModelTransformJobs


        /// <summary>
        /// Returns a list of model transform job IDs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmlmodeltransformjobs">neptune-db:ListMLModelTransformJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTransformJobs service method.</param>
        /// 
        /// <returns>The response from the ListMLModelTransformJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTransformJobs">REST API Reference for ListMLModelTransformJobs Operation</seealso>
        ListMLModelTransformJobsResponse ListMLModelTransformJobs(ListMLModelTransformJobsRequest request);



        /// <summary>
        /// Returns a list of model transform job IDs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#listmlmodeltransformjobs">neptune-db:ListMLModelTransformJobs</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTransformJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMLModelTransformJobs service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTransformJobs">REST API Reference for ListMLModelTransformJobs Operation</seealso>
        Task<ListMLModelTransformJobsResponse> ListMLModelTransformJobsAsync(ListMLModelTransformJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOpenCypherQueries


        /// <summary>
        /// Lists active openCypher queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenCypherQueries service method.</param>
        /// 
        /// <returns>The response from the ListOpenCypherQueries service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListOpenCypherQueries">REST API Reference for ListOpenCypherQueries Operation</seealso>
        ListOpenCypherQueriesResponse ListOpenCypherQueries(ListOpenCypherQueriesRequest request);



        /// <summary>
        /// Lists active openCypher queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getquerystatus">neptune-db:GetQueryStatus</a>
        /// IAM action in that cluster.
        /// </para>
        ///  
        /// <para>
        /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:OpenCypher</a>
        /// IAM condition key can be used in the policy document to restrict the use of openCypher
        /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
        /// keys available in Neptune IAM data-access policy statements</a>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenCypherQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpenCypherQueries service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConcurrentModificationException">
        /// Raised when a request attempts to modify data that is concurrently being modified
        /// by another process.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.FailureByQueryException">
        /// Raised when a request fails.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidNumericDataException">
        /// Raised when invalid numerical data is encountered when servicing a request.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ParsingException">
        /// Raised when a parsing issue is encountered.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TimeLimitExceededException">
        /// Raised when the an operation exceeds the time limit allowed for it.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListOpenCypherQueries">REST API Reference for ListOpenCypherQueries Operation</seealso>
        Task<ListOpenCypherQueriesResponse> ListOpenCypherQueriesAsync(ListOpenCypherQueriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ManagePropertygraphStatistics


        /// <summary>
        /// Manages the generation and use of property graph statistics.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#managestatistics">neptune-db:ManageStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ManagePropertygraphStatistics service method.</param>
        /// 
        /// <returns>The response from the ManagePropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManagePropertygraphStatistics">REST API Reference for ManagePropertygraphStatistics Operation</seealso>
        ManagePropertygraphStatisticsResponse ManagePropertygraphStatistics(ManagePropertygraphStatisticsRequest request);



        /// <summary>
        /// Manages the generation and use of property graph statistics.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#managestatistics">neptune-db:ManageStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ManagePropertygraphStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ManagePropertygraphStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManagePropertygraphStatistics">REST API Reference for ManagePropertygraphStatistics Operation</seealso>
        Task<ManagePropertygraphStatisticsResponse> ManagePropertygraphStatisticsAsync(ManagePropertygraphStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ManageSparqlStatistics


        /// <summary>
        /// Manages the generation and use of RDF graph statistics.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#managestatistics">neptune-db:ManageStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ManageSparqlStatistics service method.</param>
        /// 
        /// <returns>The response from the ManageSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManageSparqlStatistics">REST API Reference for ManageSparqlStatistics Operation</seealso>
        ManageSparqlStatisticsResponse ManageSparqlStatistics(ManageSparqlStatisticsRequest request);



        /// <summary>
        /// Manages the generation and use of RDF graph statistics.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#managestatistics">neptune-db:ManageStatistics</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ManageSparqlStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ManageSparqlStatistics service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ReadOnlyViolationException">
        /// Raised when a request attempts to write to a read-only resource.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.StatisticsNotAvailableException">
        /// Raised when statistics needed to satisfy a request are not available.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManageSparqlStatistics">REST API Reference for ManageSparqlStatistics Operation</seealso>
        Task<ManageSparqlStatisticsResponse> ManageSparqlStatisticsAsync(ManageSparqlStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartLoaderJob


        /// <summary>
        /// Starts a Neptune bulk loader job to load data from an Amazon S3 bucket into a Neptune
        /// DB instance. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load.html">Using
        /// the Amazon Neptune Bulk Loader to Ingest Data</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startloaderjob">neptune-db:StartLoaderJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLoaderJob service method.</param>
        /// 
        /// <returns>The response from the StartLoaderJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.S3Exception">
        /// Raised when there is a problem accessing Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartLoaderJob">REST API Reference for StartLoaderJob Operation</seealso>
        StartLoaderJobResponse StartLoaderJob(StartLoaderJobRequest request);



        /// <summary>
        /// Starts a Neptune bulk loader job to load data from an Amazon S3 bucket into a Neptune
        /// DB instance. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load.html">Using
        /// the Amazon Neptune Bulk Loader to Ingest Data</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startloaderjob">neptune-db:StartLoaderJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLoaderJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLoaderJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.BulkLoadIdNotFoundException">
        /// Raised when a specified bulk-load job ID cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InternalFailureException">
        /// Raised when the processing of the request failed unexpectedly.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.LoadUrlAccessDeniedException">
        /// Raised when access is denied to a specified load URL.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.S3Exception">
        /// Raised when there is a problem accessing Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartLoaderJob">REST API Reference for StartLoaderJob Operation</seealso>
        Task<StartLoaderJobResponse> StartLoaderJobAsync(StartLoaderJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMLDataProcessingJob


        /// <summary>
        /// Creates a new Neptune ML data processing job for processing the graph data exported
        /// from Neptune for training. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeldataprocessingjob">neptune-db:StartMLModelDataProcessingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLDataProcessingJob service method.</param>
        /// 
        /// <returns>The response from the StartMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLDataProcessingJob">REST API Reference for StartMLDataProcessingJob Operation</seealso>
        StartMLDataProcessingJobResponse StartMLDataProcessingJob(StartMLDataProcessingJobRequest request);



        /// <summary>
        /// Creates a new Neptune ML data processing job for processing the graph data exported
        /// from Neptune for training. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <c>dataprocessing</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeldataprocessingjob">neptune-db:StartMLModelDataProcessingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLDataProcessingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMLDataProcessingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLDataProcessingJob">REST API Reference for StartMLDataProcessingJob Operation</seealso>
        Task<StartMLDataProcessingJobResponse> StartMLDataProcessingJobAsync(StartMLDataProcessingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMLModelTrainingJob


        /// <summary>
        /// Creates a new Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltrainingjob">neptune-db:StartMLModelTrainingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTrainingJob service method.</param>
        /// 
        /// <returns>The response from the StartMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTrainingJob">REST API Reference for StartMLModelTrainingJob Operation</seealso>
        StartMLModelTrainingJobResponse StartMLModelTrainingJob(StartMLModelTrainingJobRequest request);



        /// <summary>
        /// Creates a new Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <c>modeltraining</c> command</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltrainingjob">neptune-db:StartMLModelTrainingJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTrainingJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMLModelTrainingJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTrainingJob">REST API Reference for StartMLModelTrainingJob Operation</seealso>
        Task<StartMLModelTrainingJobResponse> StartMLModelTrainingJobAsync(StartMLModelTrainingJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMLModelTransformJob


        /// <summary>
        /// Creates a new model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltransformjob">neptune-db:StartMLModelTransformJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTransformJob service method.</param>
        /// 
        /// <returns>The response from the StartMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTransformJob">REST API Reference for StartMLModelTransformJob Operation</seealso>
        StartMLModelTransformJobResponse StartMLModelTransformJob(StartMLModelTransformJobRequest request);



        /// <summary>
        /// Creates a new model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
        /// 
        ///  
        /// <para>
        /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
        /// the IAM user or role making the request must have a policy attached that allows the
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltransformjob">neptune-db:StartMLModelTransformJob</a>
        /// IAM action in that cluster.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTransformJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMLModelTransformJob service method, as returned by Neptunedata.</returns>
        /// <exception cref="Amazon.Neptunedata.Model.BadRequestException">
        /// Raised when a request is submitted that cannot be processed.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ClientTimeoutException">
        /// Raised when a request timed out in the client.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.ConstraintViolationException">
        /// Raised when a value in a request field did not satisfy required constraints.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.IllegalArgumentException">
        /// Raised when an argument in a request is not supported.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidArgumentException">
        /// Raised when an argument in a request has an invalid value.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.InvalidParameterException">
        /// Raised when a parameter value is not valid.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MissingParameterException">
        /// Raised when a required parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.MLResourceNotFoundException">
        /// Raised when a specified machine-learning resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.PreconditionsFailedException">
        /// Raised when a precondition for processing a request is not satisfied.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.TooManyRequestsException">
        /// Raised when the number of requests being processed exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.Neptunedata.Model.UnsupportedOperationException">
        /// Raised when a request attempts to initiate an operation that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTransformJob">REST API Reference for StartMLModelTransformJob Operation</seealso>
        Task<StartMLModelTransformJobResponse> StartMLModelTransformJobAsync(StartMLModelTransformJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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