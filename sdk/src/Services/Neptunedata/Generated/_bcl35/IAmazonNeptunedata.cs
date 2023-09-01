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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Neptunedata.Model;

namespace Amazon.Neptunedata
{
    /// <summary>
    /// Interface for accessing Neptunedata
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
        /// Initiates the asynchronous execution of the CancelGremlinQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelGremlinQuery operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelGremlinQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelGremlinQuery">REST API Reference for CancelGremlinQuery Operation</seealso>
        IAsyncResult BeginCancelGremlinQuery(CancelGremlinQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelGremlinQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelGremlinQuery.</param>
        /// 
        /// <returns>Returns a  CancelGremlinQueryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelGremlinQuery">REST API Reference for CancelGremlinQuery Operation</seealso>
        CancelGremlinQueryResponse EndCancelGremlinQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelLoaderJob


        /// <summary>
        /// Cancels a specified load job. This is an HTTP <code>DELETE</code> request.
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
        /// Loader Get-Status API</a> for more information.
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
        /// Initiates the asynchronous execution of the CancelLoaderJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelLoaderJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelLoaderJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelLoaderJob">REST API Reference for CancelLoaderJob Operation</seealso>
        IAsyncResult BeginCancelLoaderJob(CancelLoaderJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelLoaderJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelLoaderJob.</param>
        /// 
        /// <returns>Returns a  CancelLoaderJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelLoaderJob">REST API Reference for CancelLoaderJob Operation</seealso>
        CancelLoaderJobResponse EndCancelLoaderJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelMLDataProcessingJob


        /// <summary>
        /// Cancels a Neptune ML data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <code>dataprocessing</code> command</a>.
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
        /// Initiates the asynchronous execution of the CancelMLDataProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMLDataProcessingJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMLDataProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLDataProcessingJob">REST API Reference for CancelMLDataProcessingJob Operation</seealso>
        IAsyncResult BeginCancelMLDataProcessingJob(CancelMLDataProcessingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMLDataProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMLDataProcessingJob.</param>
        /// 
        /// <returns>Returns a  CancelMLDataProcessingJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLDataProcessingJob">REST API Reference for CancelMLDataProcessingJob Operation</seealso>
        CancelMLDataProcessingJobResponse EndCancelMLDataProcessingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelMLModelTrainingJob


        /// <summary>
        /// Cancels a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <code>modeltraining</code> command</a>.
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
        /// Initiates the asynchronous execution of the CancelMLModelTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTrainingJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMLModelTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTrainingJob">REST API Reference for CancelMLModelTrainingJob Operation</seealso>
        IAsyncResult BeginCancelMLModelTrainingJob(CancelMLModelTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMLModelTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMLModelTrainingJob.</param>
        /// 
        /// <returns>Returns a  CancelMLModelTrainingJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTrainingJob">REST API Reference for CancelMLModelTrainingJob Operation</seealso>
        CancelMLModelTrainingJobResponse EndCancelMLModelTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelMLModelTransformJob


        /// <summary>
        /// Cancels a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
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
        /// Initiates the asynchronous execution of the CancelMLModelTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMLModelTransformJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMLModelTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTransformJob">REST API Reference for CancelMLModelTransformJob Operation</seealso>
        IAsyncResult BeginCancelMLModelTransformJob(CancelMLModelTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMLModelTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMLModelTransformJob.</param>
        /// 
        /// <returns>Returns a  CancelMLModelTransformJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelMLModelTransformJob">REST API Reference for CancelMLModelTransformJob Operation</seealso>
        CancelMLModelTransformJobResponse EndCancelMLModelTransformJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelOpenCypherQuery


        /// <summary>
        /// Cancels a specified openCypher query. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
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
        /// Initiates the asynchronous execution of the CancelOpenCypherQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelOpenCypherQuery operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelOpenCypherQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelOpenCypherQuery">REST API Reference for CancelOpenCypherQuery Operation</seealso>
        IAsyncResult BeginCancelOpenCypherQuery(CancelOpenCypherQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelOpenCypherQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelOpenCypherQuery.</param>
        /// 
        /// <returns>Returns a  CancelOpenCypherQueryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CancelOpenCypherQuery">REST API Reference for CancelOpenCypherQuery Operation</seealso>
        CancelOpenCypherQueryResponse EndCancelOpenCypherQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMLEndpoint


        /// <summary>
        /// Creates a new Neptune ML inference endpoint that lets you query one specific model
        /// that the model-training process constructed. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
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
        /// Initiates the asynchronous execution of the CreateMLEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMLEndpoint operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMLEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CreateMLEndpoint">REST API Reference for CreateMLEndpoint Operation</seealso>
        IAsyncResult BeginCreateMLEndpoint(CreateMLEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMLEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMLEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateMLEndpointResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/CreateMLEndpoint">REST API Reference for CreateMLEndpoint Operation</seealso>
        CreateMLEndpointResponse EndCreateMLEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMLEndpoint


        /// <summary>
        /// Cancels the creation of a Neptune ML inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
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
        /// Initiates the asynchronous execution of the DeleteMLEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLEndpoint operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMLEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteMLEndpoint">REST API Reference for DeleteMLEndpoint Operation</seealso>
        IAsyncResult BeginDeleteMLEndpoint(DeleteMLEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMLEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMLEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteMLEndpointResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteMLEndpoint">REST API Reference for DeleteMLEndpoint Operation</seealso>
        DeleteMLEndpointResponse EndDeleteMLEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePropertygraphStatistics


        /// <summary>
        /// Deletes statistics for Gremlin and openCypher (property graph) data.
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
        /// Initiates the asynchronous execution of the DeletePropertygraphStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePropertygraphStatistics operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePropertygraphStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeletePropertygraphStatistics">REST API Reference for DeletePropertygraphStatistics Operation</seealso>
        IAsyncResult BeginDeletePropertygraphStatistics(DeletePropertygraphStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePropertygraphStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePropertygraphStatistics.</param>
        /// 
        /// <returns>Returns a  DeletePropertygraphStatisticsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeletePropertygraphStatistics">REST API Reference for DeletePropertygraphStatistics Operation</seealso>
        DeletePropertygraphStatisticsResponse EndDeletePropertygraphStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSparqlStatistics


        /// <summary>
        /// Deletes SPARQL statistics
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
        /// Initiates the asynchronous execution of the DeleteSparqlStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSparqlStatistics operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSparqlStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteSparqlStatistics">REST API Reference for DeleteSparqlStatistics Operation</seealso>
        IAsyncResult BeginDeleteSparqlStatistics(DeleteSparqlStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSparqlStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSparqlStatistics.</param>
        /// 
        /// <returns>Returns a  DeleteSparqlStatisticsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/DeleteSparqlStatistics">REST API Reference for DeleteSparqlStatistics Operation</seealso>
        DeleteSparqlStatisticsResponse EndDeleteSparqlStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteFastReset


        /// <summary>
        /// The fast reset REST API lets you reset a Neptune graph quicky and easily, removing
        /// all of its data.
        /// 
        ///  
        /// <para>
        /// Neptune fast reset is a two-step process. First you call <code>ExecuteFastReset</code>
        /// with <code>action</code> set to <code>initiateDatabaseReset</code>. This returns a
        /// UUID token which you then include when calling <code>ExecuteFastReset</code> again
        /// with <code>action</code> set to <code>performDatabaseReset</code>. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/manage-console-fast-reset.html">Empty
        /// an Amazon Neptune DB cluster using the fast reset API</a>.
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
        /// Initiates the asynchronous execution of the ExecuteFastReset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteFastReset operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteFastReset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteFastReset">REST API Reference for ExecuteFastReset Operation</seealso>
        IAsyncResult BeginExecuteFastReset(ExecuteFastResetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteFastReset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteFastReset.</param>
        /// 
        /// <returns>Returns a  ExecuteFastResetResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteFastReset">REST API Reference for ExecuteFastReset Operation</seealso>
        ExecuteFastResetResponse EndExecuteFastReset(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteGremlinExplainQuery


        /// <summary>
        /// Executes a Gremlin Explain query.
        /// 
        ///  
        /// <para>
        /// Amazon Neptune has added a Gremlin feature named <code>explain</code> that provides
        /// is a self-service tool for understanding the execution approach being taken by the
        /// Neptune engine for the query. You invoke it by adding an <code>explain</code> parameter
        /// to an HTTP call that submits a Gremlin query.
        /// </para>
        ///  
        /// <para>
        /// The explain feature provides information about the logical structure of query execution
        /// plans. You can use this information to identify potential evaluation and execution
        /// bottlenecks and to tune your query, as explained in <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-traversal-tuning.html">Tuning
        /// Gremlin queries</a>. You can also use query hints to improve query execution plans.
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
        /// Initiates the asynchronous execution of the ExecuteGremlinExplainQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinExplainQuery operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteGremlinExplainQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinExplainQuery">REST API Reference for ExecuteGremlinExplainQuery Operation</seealso>
        IAsyncResult BeginExecuteGremlinExplainQuery(ExecuteGremlinExplainQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteGremlinExplainQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteGremlinExplainQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteGremlinExplainQueryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinExplainQuery">REST API Reference for ExecuteGremlinExplainQuery Operation</seealso>
        ExecuteGremlinExplainQueryResponse EndExecuteGremlinExplainQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteGremlinProfileQuery


        /// <summary>
        /// Executes a Gremlin Profile query, which runs a specified traversal, collects various
        /// metrics about the run, and produces a profile report as output. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-profile-api.html">Gremlin
        /// profile API in Neptune</a> for details.
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
        /// Initiates the asynchronous execution of the ExecuteGremlinProfileQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinProfileQuery operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteGremlinProfileQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinProfileQuery">REST API Reference for ExecuteGremlinProfileQuery Operation</seealso>
        IAsyncResult BeginExecuteGremlinProfileQuery(ExecuteGremlinProfileQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteGremlinProfileQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteGremlinProfileQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteGremlinProfileQueryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinProfileQuery">REST API Reference for ExecuteGremlinProfileQuery Operation</seealso>
        ExecuteGremlinProfileQueryResponse EndExecuteGremlinProfileQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteGremlinQuery


        /// <summary>
        /// This commands executes a Gremlin query. Amazon Neptune is compatible with Apache TinkerPop3
        /// and Gremlin, so you can use the Gremlin traversal language to query the graph, as
        /// described under <a href="https://tinkerpop.apache.org/docs/current/reference/#graph">The
        /// Graph</a> in the Apache TinkerPop3 documentation. More details can also be found in
        /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-gremlin.html">Accessing
        /// a Neptune graph with Gremlin</a>.
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
        /// Initiates the asynchronous execution of the ExecuteGremlinQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteGremlinQuery operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteGremlinQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinQuery">REST API Reference for ExecuteGremlinQuery Operation</seealso>
        IAsyncResult BeginExecuteGremlinQuery(ExecuteGremlinQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteGremlinQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteGremlinQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteGremlinQueryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteGremlinQuery">REST API Reference for ExecuteGremlinQuery Operation</seealso>
        ExecuteGremlinQueryResponse EndExecuteGremlinQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteOpenCypherExplainQuery


        /// <summary>
        /// Executes an openCypher <code>explain</code> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-explain.html">The
        /// openCypher explain feature</a> for more information.
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
        /// Initiates the asynchronous execution of the ExecuteOpenCypherExplainQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherExplainQuery operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteOpenCypherExplainQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherExplainQuery">REST API Reference for ExecuteOpenCypherExplainQuery Operation</seealso>
        IAsyncResult BeginExecuteOpenCypherExplainQuery(ExecuteOpenCypherExplainQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteOpenCypherExplainQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteOpenCypherExplainQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteOpenCypherExplainQueryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherExplainQuery">REST API Reference for ExecuteOpenCypherExplainQuery Operation</seealso>
        ExecuteOpenCypherExplainQueryResponse EndExecuteOpenCypherExplainQuery(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ExecuteOpenCypherQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteOpenCypherQuery operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteOpenCypherQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherQuery">REST API Reference for ExecuteOpenCypherQuery Operation</seealso>
        IAsyncResult BeginExecuteOpenCypherQuery(ExecuteOpenCypherQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteOpenCypherQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteOpenCypherQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteOpenCypherQueryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ExecuteOpenCypherQuery">REST API Reference for ExecuteOpenCypherQuery Operation</seealso>
        ExecuteOpenCypherQueryResponse EndExecuteOpenCypherQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEngineStatus


        /// <summary>
        /// Check the status of the graph database on the host.
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
        /// Initiates the asynchronous execution of the GetEngineStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEngineStatus operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEngineStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetEngineStatus">REST API Reference for GetEngineStatus Operation</seealso>
        IAsyncResult BeginGetEngineStatus(GetEngineStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEngineStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEngineStatus.</param>
        /// 
        /// <returns>Returns a  GetEngineStatusResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetEngineStatus">REST API Reference for GetEngineStatus Operation</seealso>
        GetEngineStatusResponse EndGetEngineStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGremlinQueryStatus


        /// <summary>
        /// Gets the status of a specified Gremlin query.
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
        /// Initiates the asynchronous execution of the GetGremlinQueryStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGremlinQueryStatus operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGremlinQueryStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetGremlinQueryStatus">REST API Reference for GetGremlinQueryStatus Operation</seealso>
        IAsyncResult BeginGetGremlinQueryStatus(GetGremlinQueryStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGremlinQueryStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGremlinQueryStatus.</param>
        /// 
        /// <returns>Returns a  GetGremlinQueryStatusResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetGremlinQueryStatus">REST API Reference for GetGremlinQueryStatus Operation</seealso>
        GetGremlinQueryStatusResponse EndGetGremlinQueryStatus(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetLoaderJobStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoaderJobStatus operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoaderJobStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetLoaderJobStatus">REST API Reference for GetLoaderJobStatus Operation</seealso>
        IAsyncResult BeginGetLoaderJobStatus(GetLoaderJobStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoaderJobStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoaderJobStatus.</param>
        /// 
        /// <returns>Returns a  GetLoaderJobStatusResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetLoaderJobStatus">REST API Reference for GetLoaderJobStatus Operation</seealso>
        GetLoaderJobStatusResponse EndGetLoaderJobStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMLDataProcessingJob


        /// <summary>
        /// Retrieves information about a specified data processing job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <code>dataprocessing</code> command</a>.
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
        /// Initiates the asynchronous execution of the GetMLDataProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLDataProcessingJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLDataProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLDataProcessingJob">REST API Reference for GetMLDataProcessingJob Operation</seealso>
        IAsyncResult BeginGetMLDataProcessingJob(GetMLDataProcessingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLDataProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLDataProcessingJob.</param>
        /// 
        /// <returns>Returns a  GetMLDataProcessingJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLDataProcessingJob">REST API Reference for GetMLDataProcessingJob Operation</seealso>
        GetMLDataProcessingJobResponse EndGetMLDataProcessingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMLEndpoint


        /// <summary>
        /// Retrieves details about an inference endpoint. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
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
        /// Initiates the asynchronous execution of the GetMLEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLEndpoint operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLEndpoint">REST API Reference for GetMLEndpoint Operation</seealso>
        IAsyncResult BeginGetMLEndpoint(GetMLEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLEndpoint.</param>
        /// 
        /// <returns>Returns a  GetMLEndpointResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLEndpoint">REST API Reference for GetMLEndpoint Operation</seealso>
        GetMLEndpointResponse EndGetMLEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMLModelTrainingJob


        /// <summary>
        /// Retrieves information about a Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <code>modeltraining</code> command</a>.
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
        /// Initiates the asynchronous execution of the GetMLModelTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTrainingJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLModelTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTrainingJob">REST API Reference for GetMLModelTrainingJob Operation</seealso>
        IAsyncResult BeginGetMLModelTrainingJob(GetMLModelTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLModelTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLModelTrainingJob.</param>
        /// 
        /// <returns>Returns a  GetMLModelTrainingJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTrainingJob">REST API Reference for GetMLModelTrainingJob Operation</seealso>
        GetMLModelTrainingJobResponse EndGetMLModelTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMLModelTransformJob


        /// <summary>
        /// Gets information about a specified model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
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
        /// Initiates the asynchronous execution of the GetMLModelTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLModelTransformJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMLModelTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTransformJob">REST API Reference for GetMLModelTransformJob Operation</seealso>
        IAsyncResult BeginGetMLModelTransformJob(GetMLModelTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMLModelTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMLModelTransformJob.</param>
        /// 
        /// <returns>Returns a  GetMLModelTransformJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetMLModelTransformJob">REST API Reference for GetMLModelTransformJob Operation</seealso>
        GetMLModelTransformJobResponse EndGetMLModelTransformJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOpenCypherQueryStatus


        /// <summary>
        /// Retrieves the status of a specified openCypher query.
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
        /// Initiates the asynchronous execution of the GetOpenCypherQueryStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenCypherQueryStatus operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpenCypherQueryStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetOpenCypherQueryStatus">REST API Reference for GetOpenCypherQueryStatus Operation</seealso>
        IAsyncResult BeginGetOpenCypherQueryStatus(GetOpenCypherQueryStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpenCypherQueryStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpenCypherQueryStatus.</param>
        /// 
        /// <returns>Returns a  GetOpenCypherQueryStatusResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetOpenCypherQueryStatus">REST API Reference for GetOpenCypherQueryStatus Operation</seealso>
        GetOpenCypherQueryStatusResponse EndGetOpenCypherQueryStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPropertygraphStatistics


        /// <summary>
        /// Gets property graph statistics (Gremlin and openCypher).
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
        /// Initiates the asynchronous execution of the GetPropertygraphStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStatistics operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPropertygraphStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStatistics">REST API Reference for GetPropertygraphStatistics Operation</seealso>
        IAsyncResult BeginGetPropertygraphStatistics(GetPropertygraphStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPropertygraphStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPropertygraphStatistics.</param>
        /// 
        /// <returns>Returns a  GetPropertygraphStatisticsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStatistics">REST API Reference for GetPropertygraphStatistics Operation</seealso>
        GetPropertygraphStatisticsResponse EndGetPropertygraphStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPropertygraphStream


        /// <summary>
        /// Gets a stream for a property graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <code>GetPropertygraphStream</code>
        /// lets you collect these change-log entries for a property graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <code>1</code>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
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
        /// Initiates the asynchronous execution of the GetPropertygraphStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphStream operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPropertygraphStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStream">REST API Reference for GetPropertygraphStream Operation</seealso>
        IAsyncResult BeginGetPropertygraphStream(GetPropertygraphStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPropertygraphStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPropertygraphStream.</param>
        /// 
        /// <returns>Returns a  GetPropertygraphStreamResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphStream">REST API Reference for GetPropertygraphStream Operation</seealso>
        GetPropertygraphStreamResponse EndGetPropertygraphStream(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPropertygraphSummary


        /// <summary>
        /// Gets a graph summary for a property graph.
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
        /// Initiates the asynchronous execution of the GetPropertygraphSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPropertygraphSummary operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPropertygraphSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphSummary">REST API Reference for GetPropertygraphSummary Operation</seealso>
        IAsyncResult BeginGetPropertygraphSummary(GetPropertygraphSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPropertygraphSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPropertygraphSummary.</param>
        /// 
        /// <returns>Returns a  GetPropertygraphSummaryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetPropertygraphSummary">REST API Reference for GetPropertygraphSummary Operation</seealso>
        GetPropertygraphSummaryResponse EndGetPropertygraphSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRDFGraphSummary


        /// <summary>
        /// Gets a graph summary for an RDF graph.
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
        /// Initiates the asynchronous execution of the GetRDFGraphSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRDFGraphSummary operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRDFGraphSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetRDFGraphSummary">REST API Reference for GetRDFGraphSummary Operation</seealso>
        IAsyncResult BeginGetRDFGraphSummary(GetRDFGraphSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRDFGraphSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRDFGraphSummary.</param>
        /// 
        /// <returns>Returns a  GetRDFGraphSummaryResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetRDFGraphSummary">REST API Reference for GetRDFGraphSummary Operation</seealso>
        GetRDFGraphSummaryResponse EndGetRDFGraphSummary(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetSparqlStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStatistics operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSparqlStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStatistics">REST API Reference for GetSparqlStatistics Operation</seealso>
        IAsyncResult BeginGetSparqlStatistics(GetSparqlStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSparqlStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSparqlStatistics.</param>
        /// 
        /// <returns>Returns a  GetSparqlStatisticsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStatistics">REST API Reference for GetSparqlStatistics Operation</seealso>
        GetSparqlStatisticsResponse EndGetSparqlStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSparqlStream


        /// <summary>
        /// Gets a stream for an RDF graph.
        /// 
        ///  
        /// <para>
        /// With the Neptune Streams feature, you can generate a complete sequence of change-log
        /// entries that record every change made to your graph data as it happens. <code>GetSparqlStream</code>
        /// lets you collect these change-log entries for an RDF graph.
        /// </para>
        ///  
        /// <para>
        /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
        /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
        /// DB cluster parameter to <code>1</code>.
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
        /// graph changes in real time using Neptune streams</a>.
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
        /// Initiates the asynchronous execution of the GetSparqlStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSparqlStream operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSparqlStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStream">REST API Reference for GetSparqlStream Operation</seealso>
        IAsyncResult BeginGetSparqlStream(GetSparqlStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSparqlStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSparqlStream.</param>
        /// 
        /// <returns>Returns a  GetSparqlStreamResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/GetSparqlStream">REST API Reference for GetSparqlStream Operation</seealso>
        GetSparqlStreamResponse EndGetSparqlStream(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGremlinQueries


        /// <summary>
        /// Lists active Gremlin queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/gremlin-api-status.html">Gremlin
        /// query status API</a> for details about the output.
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
        /// Initiates the asynchronous execution of the ListGremlinQueries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGremlinQueries operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGremlinQueries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListGremlinQueries">REST API Reference for ListGremlinQueries Operation</seealso>
        IAsyncResult BeginListGremlinQueries(ListGremlinQueriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGremlinQueries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGremlinQueries.</param>
        /// 
        /// <returns>Returns a  ListGremlinQueriesResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListGremlinQueries">REST API Reference for ListGremlinQueries Operation</seealso>
        ListGremlinQueriesResponse EndListGremlinQueries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLoaderJobs


        /// <summary>
        /// Retrieves a list of the <code>loadIds</code> for all active loader jobs.
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
        /// Initiates the asynchronous execution of the ListLoaderJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLoaderJobs operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLoaderJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListLoaderJobs">REST API Reference for ListLoaderJobs Operation</seealso>
        IAsyncResult BeginListLoaderJobs(ListLoaderJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLoaderJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLoaderJobs.</param>
        /// 
        /// <returns>Returns a  ListLoaderJobsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListLoaderJobs">REST API Reference for ListLoaderJobs Operation</seealso>
        ListLoaderJobsResponse EndListLoaderJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMLDataProcessingJobs


        /// <summary>
        /// Returns a list of Neptune ML data processing jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html#machine-learning-api-dataprocessing-list-jobs">Listing
        /// active data-processing jobs using the Neptune ML dataprocessing command</a>.
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
        /// Initiates the asynchronous execution of the ListMLDataProcessingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMLDataProcessingJobs operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMLDataProcessingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLDataProcessingJobs">REST API Reference for ListMLDataProcessingJobs Operation</seealso>
        IAsyncResult BeginListMLDataProcessingJobs(ListMLDataProcessingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMLDataProcessingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMLDataProcessingJobs.</param>
        /// 
        /// <returns>Returns a  ListMLDataProcessingJobsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLDataProcessingJobs">REST API Reference for ListMLDataProcessingJobs Operation</seealso>
        ListMLDataProcessingJobsResponse EndListMLDataProcessingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMLEndpoints


        /// <summary>
        /// Lists existing inference endpoints. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-endpoints.html">Managing
        /// inference endpoints using the endpoints command</a>.
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
        /// Initiates the asynchronous execution of the ListMLEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMLEndpoints operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMLEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLEndpoints">REST API Reference for ListMLEndpoints Operation</seealso>
        IAsyncResult BeginListMLEndpoints(ListMLEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMLEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMLEndpoints.</param>
        /// 
        /// <returns>Returns a  ListMLEndpointsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLEndpoints">REST API Reference for ListMLEndpoints Operation</seealso>
        ListMLEndpointsResponse EndListMLEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMLModelTrainingJobs


        /// <summary>
        /// Lists Neptune ML model-training jobs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <code>modeltraining</code> command</a>.
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
        /// Initiates the asynchronous execution of the ListMLModelTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTrainingJobs operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMLModelTrainingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTrainingJobs">REST API Reference for ListMLModelTrainingJobs Operation</seealso>
        IAsyncResult BeginListMLModelTrainingJobs(ListMLModelTrainingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMLModelTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMLModelTrainingJobs.</param>
        /// 
        /// <returns>Returns a  ListMLModelTrainingJobsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTrainingJobs">REST API Reference for ListMLModelTrainingJobs Operation</seealso>
        ListMLModelTrainingJobsResponse EndListMLModelTrainingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMLModelTransformJobs


        /// <summary>
        /// Returns a list of model transform job IDs. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
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
        /// Initiates the asynchronous execution of the ListMLModelTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMLModelTransformJobs operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMLModelTransformJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTransformJobs">REST API Reference for ListMLModelTransformJobs Operation</seealso>
        IAsyncResult BeginListMLModelTransformJobs(ListMLModelTransformJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMLModelTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMLModelTransformJobs.</param>
        /// 
        /// <returns>Returns a  ListMLModelTransformJobsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListMLModelTransformJobs">REST API Reference for ListMLModelTransformJobs Operation</seealso>
        ListMLModelTransformJobsResponse EndListMLModelTransformJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOpenCypherQueries


        /// <summary>
        /// Lists active openCypher queries. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/access-graph-opencypher-status.html">Neptune
        /// openCypher status endpoint</a> for more information.
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
        /// Initiates the asynchronous execution of the ListOpenCypherQueries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenCypherQueries operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpenCypherQueries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListOpenCypherQueries">REST API Reference for ListOpenCypherQueries Operation</seealso>
        IAsyncResult BeginListOpenCypherQueries(ListOpenCypherQueriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpenCypherQueries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpenCypherQueries.</param>
        /// 
        /// <returns>Returns a  ListOpenCypherQueriesResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ListOpenCypherQueries">REST API Reference for ListOpenCypherQueries Operation</seealso>
        ListOpenCypherQueriesResponse EndListOpenCypherQueries(IAsyncResult asyncResult);

        #endregion
        
        #region  ManagePropertygraphStatistics


        /// <summary>
        /// Manages the generation and use of property graph statistics.
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
        /// Initiates the asynchronous execution of the ManagePropertygraphStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ManagePropertygraphStatistics operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndManagePropertygraphStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManagePropertygraphStatistics">REST API Reference for ManagePropertygraphStatistics Operation</seealso>
        IAsyncResult BeginManagePropertygraphStatistics(ManagePropertygraphStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ManagePropertygraphStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginManagePropertygraphStatistics.</param>
        /// 
        /// <returns>Returns a  ManagePropertygraphStatisticsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManagePropertygraphStatistics">REST API Reference for ManagePropertygraphStatistics Operation</seealso>
        ManagePropertygraphStatisticsResponse EndManagePropertygraphStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  ManageSparqlStatistics


        /// <summary>
        /// Manages the generation and use of RDF graph statistics.
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
        /// Initiates the asynchronous execution of the ManageSparqlStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ManageSparqlStatistics operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndManageSparqlStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManageSparqlStatistics">REST API Reference for ManageSparqlStatistics Operation</seealso>
        IAsyncResult BeginManageSparqlStatistics(ManageSparqlStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ManageSparqlStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginManageSparqlStatistics.</param>
        /// 
        /// <returns>Returns a  ManageSparqlStatisticsResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/ManageSparqlStatistics">REST API Reference for ManageSparqlStatistics Operation</seealso>
        ManageSparqlStatisticsResponse EndManageSparqlStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  StartLoaderJob


        /// <summary>
        /// Starts a Neptune bulk loader job to load data from an Amazon S3 bucket into a Neptune
        /// DB instance. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load.html">Using
        /// the Amazon Neptune Bulk Loader to Ingest Data</a>.
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
        /// Initiates the asynchronous execution of the StartLoaderJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLoaderJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartLoaderJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartLoaderJob">REST API Reference for StartLoaderJob Operation</seealso>
        IAsyncResult BeginStartLoaderJob(StartLoaderJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartLoaderJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartLoaderJob.</param>
        /// 
        /// <returns>Returns a  StartLoaderJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartLoaderJob">REST API Reference for StartLoaderJob Operation</seealso>
        StartLoaderJobResponse EndStartLoaderJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMLDataProcessingJob


        /// <summary>
        /// Creates a new Neptune ML data processing job for processing the graph data exported
        /// from Neptune for training. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-dataprocessing.html">The
        /// <code>dataprocessing</code> command</a>.
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
        /// Initiates the asynchronous execution of the StartMLDataProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMLDataProcessingJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMLDataProcessingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLDataProcessingJob">REST API Reference for StartMLDataProcessingJob Operation</seealso>
        IAsyncResult BeginStartMLDataProcessingJob(StartMLDataProcessingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMLDataProcessingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMLDataProcessingJob.</param>
        /// 
        /// <returns>Returns a  StartMLDataProcessingJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLDataProcessingJob">REST API Reference for StartMLDataProcessingJob Operation</seealso>
        StartMLDataProcessingJobResponse EndStartMLDataProcessingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMLModelTrainingJob


        /// <summary>
        /// Creates a new Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
        /// training using the <code>modeltraining</code> command</a>.
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
        /// Initiates the asynchronous execution of the StartMLModelTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTrainingJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMLModelTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTrainingJob">REST API Reference for StartMLModelTrainingJob Operation</seealso>
        IAsyncResult BeginStartMLModelTrainingJob(StartMLModelTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMLModelTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMLModelTrainingJob.</param>
        /// 
        /// <returns>Returns a  StartMLModelTrainingJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTrainingJob">REST API Reference for StartMLModelTrainingJob Operation</seealso>
        StartMLModelTrainingJobResponse EndStartMLModelTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMLModelTransformJob


        /// <summary>
        /// Creates a new model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
        /// a trained model to generate new model artifacts</a>.
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
        /// Initiates the asynchronous execution of the StartMLModelTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMLModelTransformJob operation on AmazonNeptunedataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMLModelTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTransformJob">REST API Reference for StartMLModelTransformJob Operation</seealso>
        IAsyncResult BeginStartMLModelTransformJob(StartMLModelTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMLModelTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMLModelTransformJob.</param>
        /// 
        /// <returns>Returns a  StartMLModelTransformJobResult from Neptunedata.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptunedata-2023-08-01/StartMLModelTransformJob">REST API Reference for StartMLModelTransformJob Operation</seealso>
        StartMLModelTransformJobResponse EndStartMLModelTransformJob(IAsyncResult asyncResult);

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