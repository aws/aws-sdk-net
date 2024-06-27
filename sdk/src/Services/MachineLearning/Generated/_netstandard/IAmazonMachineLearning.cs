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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MachineLearning.Model;

#pragma warning disable CS1570
namespace Amazon.MachineLearning
{
    /// <summary>
    /// <para>Interface for accessing MachineLearning</para>
    ///
    /// Definition of the public APIs exposed by Amazon Machine Learning
    /// </summary>
    public partial interface IAmazonMachineLearning : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMachineLearningPaginatorFactory Paginators { get; }
#endif
                
        #region  AddTags



        /// <summary>
        /// Adds one or more tags to an object, up to a limit of 10. Each tag consists of a key
        /// and an optional value. If you add a tag using a key that is already associated with
        /// the ML object, <c>AddTags</c> updates the tag's value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidTagException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.TagLimitExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/AddTags">REST API Reference for AddTags Operation</seealso>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBatchPrediction



        /// <summary>
        /// Generates predictions for a group of observations. The observations to process exist
        /// in one or more data files referenced by a <c>DataSource</c>. This operation creates
        /// a new <c>BatchPrediction</c>, and uses an <c>MLModel</c> and the data files referenced
        /// by the <c>DataSource</c> as information sources. 
        /// 
        ///  
        /// <para>
        ///  <c>CreateBatchPrediction</c> is an asynchronous operation. In response to <c>CreateBatchPrediction</c>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <c>BatchPrediction</c>
        /// status to <c>PENDING</c>. After the <c>BatchPrediction</c> completes, Amazon ML sets
        /// the status to <c>COMPLETED</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can poll for status updates by using the <a>GetBatchPrediction</a> operation and
        /// checking the <c>Status</c> parameter of the result. After the <c>COMPLETED</c> status
        /// appears, the results are available in the location specified by the <c>OutputUri</c>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPrediction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateBatchPrediction">REST API Reference for CreateBatchPrediction Operation</seealso>
        Task<CreateBatchPredictionResponse> CreateBatchPredictionAsync(CreateBatchPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSourceFromRDS



        /// <summary>
        /// Creates a <c>DataSource</c> object from an <a href="http://aws.amazon.com/rds/"> Amazon
        /// Relational Database Service</a> (Amazon RDS). A <c>DataSource</c> references data
        /// that can be used to perform <c>CreateMLModel</c>, <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c>
        /// operations.
        /// 
        ///  
        /// <para>
        ///  <c>CreateDataSourceFromRDS</c> is an asynchronous operation. In response to <c>CreateDataSourceFromRDS</c>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <c>DataSource</c>
        /// status to <c>PENDING</c>. After the <c>DataSource</c> is created and ready for use,
        /// Amazon ML sets the <c>Status</c> parameter to <c>COMPLETED</c>. <c>DataSource</c>
        /// in the <c>COMPLETED</c> or <c>PENDING</c> state can be used only to perform <c>&gt;CreateMLModel</c>&gt;,
        /// <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c> operations. 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML cannot accept the input source, it sets the <c>Status</c> parameter
        /// to <c>FAILED</c> and includes an error message in the <c>Message</c> attribute of
        /// the <c>GetDataSource</c> operation response. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRDS service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSourceFromRDS service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRDS">REST API Reference for CreateDataSourceFromRDS Operation</seealso>
        Task<CreateDataSourceFromRDSResponse> CreateDataSourceFromRDSAsync(CreateDataSourceFromRDSRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSourceFromRedshift



        /// <summary>
        /// Creates a <c>DataSource</c> from a database hosted on an Amazon Redshift cluster.
        /// A <c>DataSource</c> references data that can be used to perform either <c>CreateMLModel</c>,
        /// <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c> operations.
        /// 
        ///  
        /// <para>
        ///  <c>CreateDataSourceFromRedshift</c> is an asynchronous operation. In response to
        /// <c>CreateDataSourceFromRedshift</c>, Amazon Machine Learning (Amazon ML) immediately
        /// returns and sets the <c>DataSource</c> status to <c>PENDING</c>. After the <c>DataSource</c>
        /// is created and ready for use, Amazon ML sets the <c>Status</c> parameter to <c>COMPLETED</c>.
        /// <c>DataSource</c> in <c>COMPLETED</c> or <c>PENDING</c> states can be used to perform
        /// only <c>CreateMLModel</c>, <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c>
        /// operations. 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML can't accept the input source, it sets the <c>Status</c> parameter to
        /// <c>FAILED</c> and includes an error message in the <c>Message</c> attribute of the
        /// <c>GetDataSource</c> operation response. 
        /// </para>
        ///  
        /// <para>
        /// The observations should be contained in the database hosted on an Amazon Redshift
        /// cluster and should be specified by a <c>SelectSqlQuery</c> query. Amazon ML executes
        /// an <c>Unload</c> command in Amazon Redshift to transfer the result set of the <c>SelectSqlQuery</c>
        /// query to <c>S3StagingLocation</c>.
        /// </para>
        ///  
        /// <para>
        /// After the <c>DataSource</c> has been created, it's ready for use in evaluations and
        /// batch predictions. If you plan to use the <c>DataSource</c> to train an <c>MLModel</c>,
        /// the <c>DataSource</c> also requires a recipe. A recipe describes how each input variable
        /// will be used in training an <c>MLModel</c>. Will the variable be included or excluded
        /// from training? Will the variable be manipulated; for example, will it be combined
        /// with another variable or will it be split apart into word combinations? The recipe
        /// provides answers to these questions.
        /// </para>
        ///  
        /// <para>
        /// You can't change an existing datasource, but you can copy and modify the settings
        /// from an existing Amazon Redshift datasource to create a new datasource. To do so,
        /// call <c>GetDataSource</c> for an existing datasource and copy the values to a <c>CreateDataSource</c>
        /// call. Change the settings that you want to change and make sure that all required
        /// fields have the appropriate values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRedshift service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSourceFromRedshift service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromRedshift">REST API Reference for CreateDataSourceFromRedshift Operation</seealso>
        Task<CreateDataSourceFromRedshiftResponse> CreateDataSourceFromRedshiftAsync(CreateDataSourceFromRedshiftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSourceFromS3



        /// <summary>
        /// Creates a <c>DataSource</c> object. A <c>DataSource</c> references data that can be
        /// used to perform <c>CreateMLModel</c>, <c>CreateEvaluation</c>, or <c>CreateBatchPrediction</c>
        /// operations.
        /// 
        ///  
        /// <para>
        ///  <c>CreateDataSourceFromS3</c> is an asynchronous operation. In response to <c>CreateDataSourceFromS3</c>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <c>DataSource</c>
        /// status to <c>PENDING</c>. After the <c>DataSource</c> has been created and is ready
        /// for use, Amazon ML sets the <c>Status</c> parameter to <c>COMPLETED</c>. <c>DataSource</c>
        /// in the <c>COMPLETED</c> or <c>PENDING</c> state can be used to perform only <c>CreateMLModel</c>,
        /// <c>CreateEvaluation</c> or <c>CreateBatchPrediction</c> operations. 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML can't accept the input source, it sets the <c>Status</c> parameter to
        /// <c>FAILED</c> and includes an error message in the <c>Message</c> attribute of the
        /// <c>GetDataSource</c> operation response. 
        /// </para>
        ///  
        /// <para>
        /// The observation data used in a <c>DataSource</c> should be ready to use; that is,
        /// it should have a consistent structure, and missing data values should be kept to a
        /// minimum. The observation data must reside in one or more .csv files in an Amazon Simple
        /// Storage Service (Amazon S3) location, along with a schema that describes the data
        /// items by name and type. The same schema must be used for all of the data files referenced
        /// by the <c>DataSource</c>. 
        /// </para>
        ///  
        /// <para>
        /// After the <c>DataSource</c> has been created, it's ready to use in evaluations and
        /// batch predictions. If you plan to use the <c>DataSource</c> to train an <c>MLModel</c>,
        /// the <c>DataSource</c> also needs a recipe. A recipe describes how each input variable
        /// will be used in training an <c>MLModel</c>. Will the variable be included or excluded
        /// from training? Will the variable be manipulated; for example, will it be combined
        /// with another variable or will it be split apart into word combinations? The recipe
        /// provides answers to these questions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSourceFromS3 service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateDataSourceFromS3">REST API Reference for CreateDataSourceFromS3 Operation</seealso>
        Task<CreateDataSourceFromS3Response> CreateDataSourceFromS3Async(CreateDataSourceFromS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEvaluation



        /// <summary>
        /// Creates a new <c>Evaluation</c> of an <c>MLModel</c>. An <c>MLModel</c> is evaluated
        /// on a set of observations associated to a <c>DataSource</c>. Like a <c>DataSource</c>
        /// for an <c>MLModel</c>, the <c>DataSource</c> for an <c>Evaluation</c> contains values
        /// for the <c>Target Variable</c>. The <c>Evaluation</c> compares the predicted result
        /// for each observation to the actual outcome and provides a summary so that you know
        /// how effective the <c>MLModel</c> functions on the test data. Evaluation generates
        /// a relevant performance metric, such as BinaryAUC, RegressionRMSE or MulticlassAvgFScore
        /// based on the corresponding <c>MLModelType</c>: <c>BINARY</c>, <c>REGRESSION</c> or
        /// <c>MULTICLASS</c>. 
        /// 
        ///  
        /// <para>
        ///  <c>CreateEvaluation</c> is an asynchronous operation. In response to <c>CreateEvaluation</c>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the evaluation status
        /// to <c>PENDING</c>. After the <c>Evaluation</c> is created and ready for use, Amazon
        /// ML sets the status to <c>COMPLETED</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>GetEvaluation</c> operation to check progress of the evaluation
        /// during the creation operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateEvaluation">REST API Reference for CreateEvaluation Operation</seealso>
        Task<CreateEvaluationResponse> CreateEvaluationAsync(CreateEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMLModel



        /// <summary>
        /// Creates a new <c>MLModel</c> using the <c>DataSource</c> and the recipe as information
        /// sources. 
        /// 
        ///  
        /// <para>
        /// An <c>MLModel</c> is nearly immutable. Users can update only the <c>MLModelName</c>
        /// and the <c>ScoreThreshold</c> in an <c>MLModel</c> without creating a new <c>MLModel</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateMLModel</c> is an asynchronous operation. In response to <c>CreateMLModel</c>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <c>MLModel</c>
        /// status to <c>PENDING</c>. After the <c>MLModel</c> has been created and ready is for
        /// use, Amazon ML sets the status to <c>COMPLETED</c>. 
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>GetMLModel</c> operation to check the progress of the <c>MLModel</c>
        /// during the creation operation.
        /// </para>
        ///  
        /// <para>
        ///  <c>CreateMLModel</c> requires a <c>DataSource</c> with computed statistics, which
        /// can be created by setting <c>ComputeStatistics</c> to <c>true</c> in <c>CreateDataSourceFromRDS</c>,
        /// <c>CreateDataSourceFromS3</c>, or <c>CreateDataSourceFromRedshift</c> operations.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.IdempotentParameterMismatchException">
        /// A second request to use or change an object was not allowed. This can result from
        /// retrying a request using a parameter that was not present in the original request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateMLModel">REST API Reference for CreateMLModel Operation</seealso>
        Task<CreateMLModelResponse> CreateMLModelAsync(CreateMLModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRealtimeEndpoint


        /// <summary>
        /// Creates a real-time endpoint for the <c>MLModel</c>. The endpoint contains the URI
        /// of the <c>MLModel</c>; that is, the location to send real-time prediction requests
        /// for the specified <c>MLModel</c>.
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <c>MLModel</c> during creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateRealtimeEndpoint">REST API Reference for CreateRealtimeEndpoint Operation</seealso>
        Task<CreateRealtimeEndpointResponse> CreateRealtimeEndpointAsync(string mlModelId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Creates a real-time endpoint for the <c>MLModel</c>. The endpoint contains the URI
        /// of the <c>MLModel</c>; that is, the location to send real-time prediction requests
        /// for the specified <c>MLModel</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/CreateRealtimeEndpoint">REST API Reference for CreateRealtimeEndpoint Operation</seealso>
        Task<CreateRealtimeEndpointResponse> CreateRealtimeEndpointAsync(CreateRealtimeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBatchPrediction


        /// <summary>
        /// Assigns the DELETED status to a <c>BatchPrediction</c>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <c>DeleteBatchPrediction</c> operation, you can use the <a>GetBatchPrediction</a>
        /// operation to verify that the status of the <c>BatchPrediction</c> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        ///  <b>Caution:</b> The result of the <c>DeleteBatchPrediction</c> operation is irreversible.
        /// </para>
        /// </summary>
        /// <param name="batchPredictionId">A user-supplied ID that uniquely identifies the <c>BatchPrediction</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteBatchPrediction">REST API Reference for DeleteBatchPrediction Operation</seealso>
        Task<DeleteBatchPredictionResponse> DeleteBatchPredictionAsync(string batchPredictionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Assigns the DELETED status to a <c>BatchPrediction</c>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <c>DeleteBatchPrediction</c> operation, you can use the <a>GetBatchPrediction</a>
        /// operation to verify that the status of the <c>BatchPrediction</c> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        ///  <b>Caution:</b> The result of the <c>DeleteBatchPrediction</c> operation is irreversible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPrediction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteBatchPrediction">REST API Reference for DeleteBatchPrediction Operation</seealso>
        Task<DeleteBatchPredictionResponse> DeleteBatchPredictionAsync(DeleteBatchPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataSource


        /// <summary>
        /// Assigns the DELETED status to a <c>DataSource</c>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <c>DeleteDataSource</c> operation, you can use the <a>GetDataSource</a>
        /// operation to verify that the status of the <c>DataSource</c> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        ///  <b>Caution:</b> The results of the <c>DeleteDataSource</c> operation are irreversible.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">A user-supplied ID that uniquely identifies the <c>DataSource</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(string dataSourceId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Assigns the DELETED status to a <c>DataSource</c>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <c>DeleteDataSource</c> operation, you can use the <a>GetDataSource</a>
        /// operation to verify that the status of the <c>DataSource</c> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        ///  <b>Caution:</b> The results of the <c>DeleteDataSource</c> operation are irreversible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEvaluation


        /// <summary>
        /// Assigns the <c>DELETED</c> status to an <c>Evaluation</c>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After invoking the <c>DeleteEvaluation</c> operation, you can use the <c>GetEvaluation</c>
        /// operation to verify that the status of the <c>Evaluation</c> changed to <c>DELETED</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Caution:</b> The results of the <c>DeleteEvaluation</c> operation are irreversible.
        /// </para>
        /// </summary>
        /// <param name="evaluationId">A user-supplied ID that uniquely identifies the <c>Evaluation</c> to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteEvaluation">REST API Reference for DeleteEvaluation Operation</seealso>
        Task<DeleteEvaluationResponse> DeleteEvaluationAsync(string evaluationId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Assigns the <c>DELETED</c> status to an <c>Evaluation</c>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After invoking the <c>DeleteEvaluation</c> operation, you can use the <c>GetEvaluation</c>
        /// operation to verify that the status of the <c>Evaluation</c> changed to <c>DELETED</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Caution:</b> The results of the <c>DeleteEvaluation</c> operation are irreversible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteEvaluation">REST API Reference for DeleteEvaluation Operation</seealso>
        Task<DeleteEvaluationResponse> DeleteEvaluationAsync(DeleteEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMLModel


        /// <summary>
        /// Assigns the <c>DELETED</c> status to an <c>MLModel</c>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <c>DeleteMLModel</c> operation, you can use the <c>GetMLModel</c>
        /// operation to verify that the status of the <c>MLModel</c> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        ///  <b>Caution:</b> The result of the <c>DeleteMLModel</c> operation is irreversible.
        /// </para>
        /// </summary>
        /// <param name="mlModelId">A user-supplied ID that uniquely identifies the <c>MLModel</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteMLModel">REST API Reference for DeleteMLModel Operation</seealso>
        Task<DeleteMLModelResponse> DeleteMLModelAsync(string mlModelId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Assigns the <c>DELETED</c> status to an <c>MLModel</c>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <c>DeleteMLModel</c> operation, you can use the <c>GetMLModel</c>
        /// operation to verify that the status of the <c>MLModel</c> changed to DELETED.
        /// </para>
        ///  
        /// <para>
        ///  <b>Caution:</b> The result of the <c>DeleteMLModel</c> operation is irreversible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteMLModel">REST API Reference for DeleteMLModel Operation</seealso>
        Task<DeleteMLModelResponse> DeleteMLModelAsync(DeleteMLModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRealtimeEndpoint


        /// <summary>
        /// Deletes a real time endpoint of an <c>MLModel</c>.
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <c>MLModel</c> during creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteRealtimeEndpoint">REST API Reference for DeleteRealtimeEndpoint Operation</seealso>
        Task<DeleteRealtimeEndpointResponse> DeleteRealtimeEndpointAsync(string mlModelId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes a real time endpoint of an <c>MLModel</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRealtimeEndpoint service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteRealtimeEndpoint">REST API Reference for DeleteRealtimeEndpoint Operation</seealso>
        Task<DeleteRealtimeEndpointResponse> DeleteRealtimeEndpointAsync(DeleteRealtimeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTags



        /// <summary>
        /// Deletes the specified tags associated with an ML object. After this operation is complete,
        /// you can't recover deleted tags.
        /// 
        ///  
        /// <para>
        /// If you specify a tag that doesn't exist, Amazon ML ignores it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidTagException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBatchPredictions



        /// <summary>
        /// Returns a list of <c>BatchPrediction</c> operations that match the search criteria
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchPredictions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBatchPredictions service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeBatchPredictions">REST API Reference for DescribeBatchPredictions Operation</seealso>
        Task<DescribeBatchPredictionsResponse> DescribeBatchPredictionsAsync(DescribeBatchPredictionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDataSources



        /// <summary>
        /// Returns a list of <c>DataSource</c> that match the search criteria in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataSources service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeDataSources">REST API Reference for DescribeDataSources Operation</seealso>
        Task<DescribeDataSourcesResponse> DescribeDataSourcesAsync(DescribeDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEvaluations



        /// <summary>
        /// Returns a list of <c>DescribeEvaluations</c> that match the search criteria in the
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvaluations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvaluations service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeEvaluations">REST API Reference for DescribeEvaluations Operation</seealso>
        Task<DescribeEvaluationsResponse> DescribeEvaluationsAsync(DescribeEvaluationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeMLModels



        /// <summary>
        /// Returns a list of <c>MLModel</c> that match the search criteria in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMLModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMLModels service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeMLModels">REST API Reference for DescribeMLModels Operation</seealso>
        Task<DescribeMLModelsResponse> DescribeMLModelsAsync(DescribeMLModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTags



        /// <summary>
        /// Describes one or more of the tags for your Amazon ML object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBatchPrediction


        /// <summary>
        /// Returns a <c>BatchPrediction</c> that includes detailed metadata, status, and data
        /// file information for a <c>Batch Prediction</c> request.
        /// </summary>
        /// <param name="batchPredictionId">An ID assigned to the <c>BatchPrediction</c> at creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetBatchPrediction">REST API Reference for GetBatchPrediction Operation</seealso>
        Task<GetBatchPredictionResponse> GetBatchPredictionAsync(string batchPredictionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns a <c>BatchPrediction</c> that includes detailed metadata, status, and data
        /// file information for a <c>Batch Prediction</c> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPrediction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetBatchPrediction">REST API Reference for GetBatchPrediction Operation</seealso>
        Task<GetBatchPredictionResponse> GetBatchPredictionAsync(GetBatchPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataSource


        /// <summary>
        /// Returns a <c>DataSource</c> that includes metadata and data file information, as well
        /// as the current status of the <c>DataSource</c>.
        /// 
        ///  
        /// <para>
        ///  <c>GetDataSource</c> provides results in normal or verbose format. The verbose format
        /// adds the schema description and the list of files pointed to by the DataSource to
        /// the normal format.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <c>DataSource</c> at creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        Task<GetDataSourceResponse> GetDataSourceAsync(string dataSourceId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns a <c>DataSource</c> that includes metadata and data file information, as well
        /// as the current status of the <c>DataSource</c>.
        /// 
        ///  
        /// <para>
        ///  <c>GetDataSource</c> provides results in normal or verbose format. The verbose format
        /// adds the schema description and the list of files pointed to by the DataSource to
        /// the normal format.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <c>DataSource</c> at creation.</param>
        /// <param name="verbose">Specifies whether the <c>GetDataSource</c> operation should return <c>DataSourceSchema</c>. If true, <c>DataSourceSchema</c> is returned. If false, <c>DataSourceSchema</c> is not returned.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        Task<GetDataSourceResponse> GetDataSourceAsync(string dataSourceId, bool? verbose, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns a <c>DataSource</c> that includes metadata and data file information, as well
        /// as the current status of the <c>DataSource</c>.
        /// 
        ///  
        /// <para>
        ///  <c>GetDataSource</c> provides results in normal or verbose format. The verbose format
        /// adds the schema description and the list of files pointed to by the DataSource to
        /// the normal format.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEvaluation


        /// <summary>
        /// Returns an <c>Evaluation</c> that includes metadata as well as the current status
        /// of the <c>Evaluation</c>.
        /// </summary>
        /// <param name="evaluationId">The ID of the <c>Evaluation</c> to retrieve. The evaluation of each <c>MLModel</c> is recorded and cataloged. The ID provides the means to access the information. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetEvaluation">REST API Reference for GetEvaluation Operation</seealso>
        Task<GetEvaluationResponse> GetEvaluationAsync(string evaluationId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns an <c>Evaluation</c> that includes metadata as well as the current status
        /// of the <c>Evaluation</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetEvaluation">REST API Reference for GetEvaluation Operation</seealso>
        Task<GetEvaluationResponse> GetEvaluationAsync(GetEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMLModel


        /// <summary>
        /// Returns an <c>MLModel</c> that includes detailed metadata, data source information,
        /// and the current status of the <c>MLModel</c>.
        /// 
        ///  
        /// <para>
        ///  <c>GetMLModel</c> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <c>MLModel</c> at creation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        Task<GetMLModelResponse> GetMLModelAsync(string mlModelId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns an <c>MLModel</c> that includes detailed metadata, data source information,
        /// and the current status of the <c>MLModel</c>.
        /// 
        ///  
        /// <para>
        ///  <c>GetMLModel</c> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <c>MLModel</c> at creation.</param>
        /// <param name="verbose">Specifies whether the <c>GetMLModel</c> operation should return <c>Recipe</c>. If true, <c>Recipe</c> is returned. If false, <c>Recipe</c> is not returned.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        Task<GetMLModelResponse> GetMLModelAsync(string mlModelId, bool? verbose, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns an <c>MLModel</c> that includes detailed metadata, data source information,
        /// and the current status of the <c>MLModel</c>.
        /// 
        ///  
        /// <para>
        ///  <c>GetMLModel</c> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/GetMLModel">REST API Reference for GetMLModel Operation</seealso>
        Task<GetMLModelResponse> GetMLModelAsync(GetMLModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Predict


        /// <summary>
        /// Generates a prediction for the observation using the specified <c>ML Model</c>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> Not all response parameters will be populated. Whether a response parameter
        /// is populated depends on the type of model requested.
        /// </para>
        /// </summary>
        /// <param name="mlModelId">A unique identifier of the <c>MLModel</c>.</param>
        /// <param name="predictEndpoint">A property of PredictRequest used to execute the Predict service method.</param>
        /// <param name="record">A property of PredictRequest used to execute the Predict service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Predict service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.LimitExceededException">
        /// The subscriber exceeded the maximum number of operations. This exception can occur
        /// when listing objects such as <c>DataSource</c>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.PredictorNotMountedException">
        /// The exception is thrown when a predict request is made to an unmounted <c>MLModel</c>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/Predict">REST API Reference for Predict Operation</seealso>
        Task<PredictResponse> PredictAsync(string mlModelId, string predictEndpoint, Dictionary<string, string> record, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Generates a prediction for the observation using the specified <c>ML Model</c>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> Not all response parameters will be populated. Whether a response parameter
        /// is populated depends on the type of model requested.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Predict service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Predict service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.LimitExceededException">
        /// The subscriber exceeded the maximum number of operations. This exception can occur
        /// when listing objects such as <c>DataSource</c>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.PredictorNotMountedException">
        /// The exception is thrown when a predict request is made to an unmounted <c>MLModel</c>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/Predict">REST API Reference for Predict Operation</seealso>
        Task<PredictResponse> PredictAsync(PredictRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBatchPrediction


        /// <summary>
        /// Updates the <c>BatchPredictionName</c> of a <c>BatchPrediction</c>.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetBatchPrediction</c> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="batchPredictionId">The ID assigned to the <c>BatchPrediction</c> during creation.</param>
        /// <param name="batchPredictionName">A new user-supplied name or description of the <c>BatchPrediction</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateBatchPrediction">REST API Reference for UpdateBatchPrediction Operation</seealso>
        Task<UpdateBatchPredictionResponse> UpdateBatchPredictionAsync(string batchPredictionId, string batchPredictionName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Updates the <c>BatchPredictionName</c> of a <c>BatchPrediction</c>.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetBatchPrediction</c> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBatchPrediction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBatchPrediction service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateBatchPrediction">REST API Reference for UpdateBatchPrediction Operation</seealso>
        Task<UpdateBatchPredictionResponse> UpdateBatchPredictionAsync(UpdateBatchPredictionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSource


        /// <summary>
        /// Updates the <c>DataSourceName</c> of a <c>DataSource</c>.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetDataSource</c> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <c>DataSource</c> during creation.</param>
        /// <param name="dataSourceName">A new user-supplied name or description of the <c>DataSource</c> that will replace the current description. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(string dataSourceId, string dataSourceName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Updates the <c>DataSourceName</c> of a <c>DataSource</c>.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetDataSource</c> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEvaluation


        /// <summary>
        /// Updates the <c>EvaluationName</c> of an <c>Evaluation</c>.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetEvaluation</c> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="evaluationId">The ID assigned to the <c>Evaluation</c> during creation.</param>
        /// <param name="evaluationName">A new user-supplied name or description of the <c>Evaluation</c> that will replace the current content. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateEvaluation">REST API Reference for UpdateEvaluation Operation</seealso>
        Task<UpdateEvaluationResponse> UpdateEvaluationAsync(string evaluationId, string evaluationName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Updates the <c>EvaluationName</c> of an <c>Evaluation</c>.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetEvaluation</c> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEvaluation service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateEvaluation">REST API Reference for UpdateEvaluation Operation</seealso>
        Task<UpdateEvaluationResponse> UpdateEvaluationAsync(UpdateEvaluationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMLModel


        /// <summary>
        /// Updates the <c>MLModelName</c> and the <c>ScoreThreshold</c> of an <c>MLModel</c>.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetMLModel</c> operation to view the contents of the updated data
        /// element.
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <c>MLModel</c> during creation.</param>
        /// <param name="mlModelName">A user-supplied name or description of the <c>MLModel</c>.</param>
        /// <param name="scoreThreshold">The <c>ScoreThreshold</c> used in binary classification <c>MLModel</c> that marks the boundary between a positive prediction and a negative prediction. Output values greater than or equal to the <c>ScoreThreshold</c> receive a positive result from the <c>MLModel</c>, such as <c>true</c>. Output values less than the <c>ScoreThreshold</c> receive a negative response from the <c>MLModel</c>, such as <c>false</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateMLModel">REST API Reference for UpdateMLModel Operation</seealso>
        Task<UpdateMLModelResponse> UpdateMLModelAsync(string mlModelId, string mlModelName, float? scoreThreshold, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Updates the <c>MLModelName</c> and the <c>ScoreThreshold</c> of an <c>MLModel</c>.
        /// 
        ///  
        /// <para>
        /// You can use the <c>GetMLModel</c> operation to view the contents of the updated data
        /// element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMLModel service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/machinelearning-2014-12-12/UpdateMLModel">REST API Reference for UpdateMLModel Operation</seealso>
        Task<UpdateMLModelResponse> UpdateMLModelAsync(UpdateMLModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonMachineLearningConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonMachineLearningConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonMachineLearningConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonMachineLearningConfig to create AmazonMachineLearningClient");
            }

            return awsCredentials == null ? 
                    new AmazonMachineLearningClient(serviceClientConfig) :
                    new AmazonMachineLearningClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}