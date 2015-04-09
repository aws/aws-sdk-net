/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.MachineLearning.Model;

namespace Amazon.MachineLearning
{
    /// <summary>
    /// Interface for accessing MachineLearning
    ///
    /// Definition of the public APIs exposed by Amazon Machine Learning
    /// </summary>
    public partial interface IAmazonMachineLearning : IDisposable
    {

        
        #region  CreateBatchPrediction

        /// <summary>
        /// Generates predictions for a group of observations. The observations to process exist
        /// in one or more data files referenced by a <code>DataSource</code>. This operation
        /// creates a new <code>BatchPrediction</code>, and uses an <code>MLModel</code> and the
        /// data files referenced by the <code>DataSource</code> as information sources. 
        /// 
        ///  
        /// <para>
        /// <code>CreateBatchPrediction</code> is an asynchronous operation. In response to <code>CreateBatchPrediction</code>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>BatchPrediction</code>
        /// status to <code>PENDING</code>. After the <code>BatchPrediction</code> completes,
        /// Amazon ML sets the status to <code>COMPLETED</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can poll for status updates by using the <a>GetBatchPrediction</a> operation and
        /// checking the <code>Status</code> parameter of the result. After the <code>COMPLETED</code>
        /// status appears, the results are available in the location specified by the <code>OutputUri</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPrediction service method.</param>
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
        CreateBatchPredictionResponse CreateBatchPrediction(CreateBatchPredictionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPrediction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateBatchPredictionResponse> CreateBatchPredictionAsync(CreateBatchPredictionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataSourceFromRDS

        /// <summary>
        /// Creates a <code>DataSource</code> object from an <a href="http://aws.amazon.com/rds/">
        /// Amazon Relational Database Service</a> (Amazon RDS). A <code>DataSource</code> references
        /// data that can be used to perform <a>CreateMLModel</a>, <a>CreateEvaluation</a>, or
        /// <a>CreateBatchPrediction</a> operations.
        /// 
        ///  
        /// <para>
        /// <code>CreateDataSourceFromRDS</code> is an asynchronous operation. In response to
        /// <code>CreateDataSourceFromRDS</code>, Amazon Machine Learning (Amazon ML) immediately
        /// returns and sets the <code>DataSource</code> status to <code>PENDING</code>. After
        /// the <code>DataSource</code> is created and ready for use, Amazon ML sets the <code>Status</code>
        /// parameter to <code>COMPLETED</code>. <code>DataSource</code> in <code>COMPLETED</code>
        /// or <code>PENDING</code> status can only be used to perform <a>CreateMLModel</a>, <a>CreateEvaluation</a>,
        /// or <a>CreateBatchPrediction</a> operations. 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML cannot accept the input source, it sets the <code>Status</code> parameter
        /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
        /// of the <a>GetDataSource</a> operation response. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRDS service method.</param>
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
        CreateDataSourceFromRDSResponse CreateDataSourceFromRDS(CreateDataSourceFromRDSRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromRDS operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRDS operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDataSourceFromRDSResponse> CreateDataSourceFromRDSAsync(CreateDataSourceFromRDSRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataSourceFromRedshift

        /// <summary>
        /// Creates a <code>DataSource</code> from <a href="http://aws.amazon.com/redshift/">Amazon
        /// Redshift</a>. A <code>DataSource</code> references data that can be used to perform
        /// either <a>CreateMLModel</a>, <a>CreateEvaluation</a> or <a>CreateBatchPrediction</a>
        /// operations.
        /// 
        ///  
        /// <para>
        /// <code>CreateDataSourceFromRedshift</code> is an asynchronous operation. In response
        /// to <code>CreateDataSourceFromRedshift</code>, Amazon Machine Learning (Amazon ML)
        /// immediately returns and sets the <code>DataSource</code> status to <code>PENDING</code>.
        /// After the <code>DataSource</code> is created and ready for use, Amazon ML sets the
        /// <code>Status</code> parameter to <code>COMPLETED</code>. <code>DataSource</code> in
        /// <code>COMPLETED</code> or <code>PENDING</code> status can only be used to perform
        /// <a>CreateMLModel</a>, <a>CreateEvaluation</a>, or <a>CreateBatchPrediction</a> operations.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML cannot accept the input source, it sets the <code>Status</code> parameter
        /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
        /// of the <a>GetDataSource</a> operation response. 
        /// </para>
        ///  
        /// <para>
        /// The observations should exist in the database hosted on an Amazon Redshift cluster
        /// and should be specified by a <code>SelectSqlQuery</code>. Amazon ML executes <a href="http://docs.aws.amazon.com/redshift/latest/dg/t_Unloading_tables.html">
        /// Unload</a> command in Amazon Redshift to transfer the result set of <code>SelectSqlQuery</code>
        /// to <code>S3StagingLocation.</code> 
        /// </para>
        ///  
        /// <para>
        /// After the <code>DataSource</code> is created, it's ready for use in evaluations and
        /// batch predictions. If you plan to use the <code>DataSource</code> to train an <code>MLModel</code>,
        /// the <code>DataSource</code> requires another item -- a recipe. A recipe describes
        /// the observation variables that participate in training an <code>MLModel</code>. A
        /// recipe describes how each input variable will be used in training. Will the variable
        /// be included or excluded from training? Will the variable be manipulated, for example,
        /// combined with another variable or split apart into word combinations? The recipe provides
        /// answers to these questions. For more information, see the Amazon Machine Learning
        /// Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRedshift service method.</param>
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
        CreateDataSourceFromRedshiftResponse CreateDataSourceFromRedshift(CreateDataSourceFromRedshiftRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromRedshift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromRedshift operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDataSourceFromRedshiftResponse> CreateDataSourceFromRedshiftAsync(CreateDataSourceFromRedshiftRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataSourceFromS3

        /// <summary>
        /// Creates a <code>DataSource</code> object. A <code>DataSource</code> references data
        /// that can be used to perform <a>CreateMLModel</a>, <a>CreateEvaluation</a>, or <a>CreateBatchPrediction</a>
        /// operations.
        /// 
        ///  
        /// <para>
        /// <code>CreateDataSourceFromS3</code> is an asynchronous operation. In response to <code>CreateDataSourceFromS3</code>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>DataSource</code>
        /// status to <code>PENDING</code>. After the <code>DataSource</code> is created and ready
        /// for use, Amazon ML sets the <code>Status</code> parameter to <code>COMPLETED</code>.
        /// <code>DataSource</code> in <code>COMPLETED</code> or <code>PENDING</code> status can
        /// only be used to perform <a>CreateMLModel</a>, <a>CreateEvaluation</a> or <a>CreateBatchPrediction</a>
        /// operations. 
        /// </para>
        ///  
        /// <para>
        ///  If Amazon ML cannot accept the input source, it sets the <code>Status</code> parameter
        /// to <code>FAILED</code> and includes an error message in the <code>Message</code> attribute
        /// of the <a>GetDataSource</a> operation response. 
        /// </para>
        ///  
        /// <para>
        /// The observation data used in a <code>DataSource</code> should be ready to use; that
        /// is, it should have a consistent structure, and missing data values should be kept
        /// to a minimum. The observation data must reside in one or more CSV files in an Amazon
        /// Simple Storage Service (Amazon S3) bucket, along with a schema that describes the
        /// data items by name and type. The same schema must be used for all of the data files
        /// referenced by the <code>DataSource</code>. 
        /// </para>
        ///  
        /// <para>
        /// After the <code>DataSource</code> has been created, it's ready to use in evaluations
        /// and batch predictions. If you plan to use the <code>DataSource</code> to train an
        /// <code>MLModel</code>, the <code>DataSource</code> requires another item: a recipe.
        /// A recipe describes the observation variables that participate in training an <code>MLModel</code>.
        /// A recipe describes how each input variable will be used in training. Will the variable
        /// be included or excluded from training? Will the variable be manipulated, for example,
        /// combined with another variable, or split apart into word combinations? The recipe
        /// provides answers to these questions. For more information, see the <a href="http://docs.aws.amazon.com/machinelearning/latest/dg">Amazon
        /// Machine Learning Developer Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromS3 service method.</param>
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
        CreateDataSourceFromS3Response CreateDataSourceFromS3(CreateDataSourceFromS3Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSourceFromS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSourceFromS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDataSourceFromS3Response> CreateDataSourceFromS3Async(CreateDataSourceFromS3Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEvaluation

        /// <summary>
        /// Creates a new <code>Evaluation</code> of an <code>MLModel</code>. An <code>MLModel</code>
        /// is evaluated on a set of observations associated to a <code>DataSource</code>. Like
        /// a <code>DataSource</code> for an <code>MLModel</code>, the <code>DataSource</code>
        /// for an <code>Evaluation</code> contains values for the Target Variable. The <code>Evaluation</code>
        /// compares the predicted result for each observation to the actual outcome and provides
        /// a summary so that you know how effective the <code>MLModel</code> functions on the
        /// test data. Evaluation generates a relevant performance metric such as BinaryAUC, RegressionRMSE
        /// or MulticlassAvgFScore based on the corresponding <code>MLModelType</code>: <code>BINARY</code>,
        /// <code>REGRESSION</code> or <code>MULTICLASS</code>. 
        /// 
        ///  
        /// <para>
        /// <code>CreateEvaluation</code> is an asynchronous operation. In response to <code>CreateEvaluation</code>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the evaluation status
        /// to <code>PENDING</code>. After the <code>Evaluation</code> is created and ready for
        /// use, Amazon ML sets the status to <code>COMPLETED</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can use the <a>GetEvaluation</a> operation to check progress of the evaluation
        /// during the creation operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluation service method.</param>
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
        CreateEvaluationResponse CreateEvaluation(CreateEvaluationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateEvaluationResponse> CreateEvaluationAsync(CreateEvaluationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMLModel

        /// <summary>
        /// Creates a new <code>MLModel</code> using the data files and the recipe as information
        /// sources. 
        /// 
        ///  
        /// <para>
        /// An <code>MLModel</code> is nearly immutable. Users can only update the <code>MLModelName</code>
        /// and the <code>ScoreThreshold</code> in an <code>MLModel</code> without creating a
        /// new <code>MLModel</code>. 
        /// </para>
        ///  
        /// <para>
        /// <code>CreateMLModel</code> is an asynchronous operation. In response to <code>CreateMLModel</code>,
        /// Amazon Machine Learning (Amazon ML) immediately returns and sets the <code>MLModel</code>
        /// status to <code>PENDING</code>. After the <code>MLModel</code> is created and ready
        /// for use, Amazon ML sets the status to <code>COMPLETED</code>. 
        /// </para>
        ///  
        /// <para>
        /// You can use the <a>GetMLModel</a> operation to check progress of the <code>MLModel</code>
        /// during the creation operation.
        /// </para>
        ///  
        /// <para>
        ///  <a>CreateMLModel</a> requires a <code>DataSource</code> with computed statistics,
        /// which can be created by setting <code>ComputeStatistics</code> to <code>true</code>
        /// in <a>CreateDataSourceFromRDS</a>, <a>CreateDataSourceFromS3</a>, or <a>CreateDataSourceFromRedshift</a>
        /// operations. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMLModel service method.</param>
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
        CreateMLModelResponse CreateMLModel(CreateMLModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMLModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateMLModelResponse> CreateMLModelAsync(CreateMLModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRealtimeEndpoint

        /// <summary>
        /// Creates a real-time endpoint for the <code>MLModel</code>. The endpoint contains the
        /// URI of the <code>MLModel</code>; that is, the location to send real-time prediction
        /// requests for the specified <code>MLModel</code>.
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
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
        CreateRealtimeEndpointResponse CreateRealtimeEndpoint(string mlModelId);

        /// <summary>
        /// Creates a real-time endpoint for the <code>MLModel</code>. The endpoint contains the
        /// URI of the <code>MLModel</code>; that is, the location to send real-time prediction
        /// requests for the specified <code>MLModel</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeEndpoint service method.</param>
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
        CreateRealtimeEndpointResponse CreateRealtimeEndpoint(CreateRealtimeEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRealtimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRealtimeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateRealtimeEndpointResponse> CreateRealtimeEndpointAsync(CreateRealtimeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBatchPrediction

        /// <summary>
        /// Assigns the DELETED status to a <code>BatchPrediction</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteBatchPrediction</code> operation, you can use the <a>GetBatchPrediction</a>
        /// operation to verify that the status of the <code>BatchPrediction</code> changed to
        /// DELETED.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The result of the <code>DeleteBatchPrediction</code> operation is irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="batchPredictionId">A user-supplied ID that uniquely identifies the <code>BatchPrediction</code>.</param>
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
        DeleteBatchPredictionResponse DeleteBatchPrediction(string batchPredictionId);

        /// <summary>
        /// Assigns the DELETED status to a <code>BatchPrediction</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteBatchPrediction</code> operation, you can use the <a>GetBatchPrediction</a>
        /// operation to verify that the status of the <code>BatchPrediction</code> changed to
        /// DELETED.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The result of the <code>DeleteBatchPrediction</code> operation is irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPrediction service method.</param>
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
        DeleteBatchPredictionResponse DeleteBatchPrediction(DeleteBatchPredictionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPrediction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBatchPredictionResponse> DeleteBatchPredictionAsync(DeleteBatchPredictionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDataSource

        /// <summary>
        /// Assigns the DELETED status to a <code>DataSource</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteDataSource</code> operation, you can use the <a>GetDataSource</a>
        /// operation to verify that the status of the <code>DataSource</code> changed to DELETED.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The results of the <code>DeleteDataSource</code> operation are irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="dataSourceId">A user-supplied ID that uniquely identifies the <code>DataSource</code>.</param>
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
        DeleteDataSourceResponse DeleteDataSource(string dataSourceId);

        /// <summary>
        /// Assigns the DELETED status to a <code>DataSource</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteDataSource</code> operation, you can use the <a>GetDataSource</a>
        /// operation to verify that the status of the <code>DataSource</code> changed to DELETED.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The results of the <code>DeleteDataSource</code> operation are irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
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
        DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEvaluation

        /// <summary>
        /// Assigns the <code>DELETED</code> status to an <code>Evaluation</code>, rendering it
        /// unusable.
        /// 
        ///  
        /// <para>
        /// After invoking the <code>DeleteEvaluation</code> operation, you can use the <a>GetEvaluation</a>
        /// operation to verify that the status of the <code>Evaluation</code> changed to <code>DELETED</code>.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The results of the <code>DeleteEvaluation</code> operation are irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="evaluationId">A user-supplied ID that uniquely identifies the <code>Evaluation</code> to delete.</param>
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
        DeleteEvaluationResponse DeleteEvaluation(string evaluationId);

        /// <summary>
        /// Assigns the <code>DELETED</code> status to an <code>Evaluation</code>, rendering it
        /// unusable.
        /// 
        ///  
        /// <para>
        /// After invoking the <code>DeleteEvaluation</code> operation, you can use the <a>GetEvaluation</a>
        /// operation to verify that the status of the <code>Evaluation</code> changed to <code>DELETED</code>.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The results of the <code>DeleteEvaluation</code> operation are irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluation service method.</param>
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
        DeleteEvaluationResponse DeleteEvaluation(DeleteEvaluationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteEvaluationResponse> DeleteEvaluationAsync(DeleteEvaluationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMLModel

        /// <summary>
        /// Assigns the DELETED status to an <code>MLModel</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteMLModel</code> operation, you can use the <a>GetMLModel</a>
        /// operation to verify that the status of the <code>MLModel</code> changed to DELETED.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The result of the <code>DeleteMLModel</code> operation is irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="mlModelId">A user-supplied ID that uniquely identifies the <code>MLModel</code>.</param>
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
        DeleteMLModelResponse DeleteMLModel(string mlModelId);

        /// <summary>
        /// Assigns the DELETED status to an <code>MLModel</code>, rendering it unusable.
        /// 
        ///  
        /// <para>
        /// After using the <code>DeleteMLModel</code> operation, you can use the <a>GetMLModel</a>
        /// operation to verify that the status of the <code>MLModel</code> changed to DELETED.
        /// </para>
        ///  <caution><title>Caution</title> 
        /// <para>
        /// The result of the <code>DeleteMLModel</code> operation is irreversible.
        /// </para>
        /// </caution>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLModel service method.</param>
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
        DeleteMLModelResponse DeleteMLModel(DeleteMLModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMLModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteMLModelResponse> DeleteMLModelAsync(DeleteMLModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRealtimeEndpoint

        /// <summary>
        /// Deletes a real time endpoint of an <code>MLModel</code>.
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
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
        DeleteRealtimeEndpointResponse DeleteRealtimeEndpoint(string mlModelId);

        /// <summary>
        /// Deletes a real time endpoint of an <code>MLModel</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeEndpoint service method.</param>
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
        DeleteRealtimeEndpointResponse DeleteRealtimeEndpoint(DeleteRealtimeEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRealtimeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRealtimeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteRealtimeEndpointResponse> DeleteRealtimeEndpointAsync(DeleteRealtimeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeBatchPredictions

        /// <summary>
        /// Returns a list of <code>BatchPrediction</code> operations that match the search criteria
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchPredictions service method.</param>
        /// 
        /// <returns>The response from the DescribeBatchPredictions service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        DescribeBatchPredictionsResponse DescribeBatchPredictions(DescribeBatchPredictionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBatchPredictions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchPredictions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeBatchPredictionsResponse> DescribeBatchPredictionsAsync(DescribeBatchPredictionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDataSources

        /// <summary>
        /// Returns a list of <code>DataSource</code> that match the search criteria in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSources service method.</param>
        /// 
        /// <returns>The response from the DescribeDataSources service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        DescribeDataSourcesResponse DescribeDataSources(DescribeDataSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataSources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDataSourcesResponse> DescribeDataSourcesAsync(DescribeDataSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEvaluations

        /// <summary>
        /// Returns a list of <code>DescribeEvaluations</code> that match the search criteria
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvaluations service method.</param>
        /// 
        /// <returns>The response from the DescribeEvaluations service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        DescribeEvaluationsResponse DescribeEvaluations(DescribeEvaluationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvaluations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvaluations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeEvaluationsResponse> DescribeEvaluationsAsync(DescribeEvaluationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMLModels

        /// <summary>
        /// Returns a list of <code>MLModel</code> that match the search criteria in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMLModels service method.</param>
        /// 
        /// <returns>The response from the DescribeMLModels service method, as returned by MachineLearning.</returns>
        /// <exception cref="Amazon.MachineLearning.Model.InternalServerException">
        /// An error on the server occurred when trying to process a request.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.InvalidInputException">
        /// An error on the client occurred. Typically, the cause is an invalid input value.
        /// </exception>
        DescribeMLModelsResponse DescribeMLModels(DescribeMLModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMLModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMLModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeMLModelsResponse> DescribeMLModelsAsync(DescribeMLModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBatchPrediction

        /// <summary>
        /// Returns a <code>BatchPrediction</code> that includes detailed metadata, status, and
        /// data file information for a <code>Batch Prediction</code> request.
        /// </summary>
        /// <param name="batchPredictionId">An ID assigned to the <code>BatchPrediction</code> at creation.</param>
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
        GetBatchPredictionResponse GetBatchPrediction(string batchPredictionId);

        /// <summary>
        /// Returns a <code>BatchPrediction</code> that includes detailed metadata, status, and
        /// data file information for a <code>Batch Prediction</code> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPrediction service method.</param>
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
        GetBatchPredictionResponse GetBatchPrediction(GetBatchPredictionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPrediction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBatchPredictionResponse> GetBatchPredictionAsync(GetBatchPredictionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataSource

        /// <summary>
        /// Returns a <code>DataSource</code> that includes metadata and data file information,
        /// as well as the current status of the <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetDataSource</code> provides results in normal or verbose format. The verbose
        /// format adds the schema description and the list of files pointed to by the DataSource
        /// to the normal format.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> at creation.</param>
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
        GetDataSourceResponse GetDataSource(string dataSourceId);

        /// <summary>
        /// Returns a <code>DataSource</code> that includes metadata and data file information,
        /// as well as the current status of the <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetDataSource</code> provides results in normal or verbose format. The verbose
        /// format adds the schema description and the list of files pointed to by the DataSource
        /// to the normal format.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> at creation.</param>
        /// <param name="verbose">Specifies whether the <code>GetDataSource</code> operation should return <code>DataSourceSchema</code>. If true, <code>DataSourceSchema</code> is returned. If false, <code>DataSourceSchema</code> is not returned.</param>
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
        GetDataSourceResponse GetDataSource(string dataSourceId, bool verbose);

        /// <summary>
        /// Returns a <code>DataSource</code> that includes metadata and data file information,
        /// as well as the current status of the <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetDataSource</code> provides results in normal or verbose format. The verbose
        /// format adds the schema description and the list of files pointed to by the DataSource
        /// to the normal format.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
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
        GetDataSourceResponse GetDataSource(GetDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEvaluation

        /// <summary>
        /// Returns an <code>Evaluation</code> that includes metadata as well as the current status
        /// of the <code>Evaluation</code>.
        /// </summary>
        /// <param name="evaluationId">The ID of the <code>Evaluation</code> to retrieve. The evaluation of each <code>MLModel</code> is recorded and cataloged. The ID provides the means to access the information. </param>
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
        GetEvaluationResponse GetEvaluation(string evaluationId);

        /// <summary>
        /// Returns an <code>Evaluation</code> that includes metadata as well as the current status
        /// of the <code>Evaluation</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluation service method.</param>
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
        GetEvaluationResponse GetEvaluation(GetEvaluationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetEvaluationResponse> GetEvaluationAsync(GetEvaluationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMLModel

        /// <summary>
        /// Returns an <code>MLModel</code> that includes detailed metadata, and data source information
        /// as well as the current status of the <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetMLModel</code> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> at creation.</param>
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
        GetMLModelResponse GetMLModel(string mlModelId);

        /// <summary>
        /// Returns an <code>MLModel</code> that includes detailed metadata, and data source information
        /// as well as the current status of the <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetMLModel</code> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> at creation.</param>
        /// <param name="verbose">Specifies whether the <code>GetMLModel</code> operation should return <code>Recipe</code>. If true, <code>Recipe</code> is returned. If false, <code>Recipe</code> is not returned.</param>
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
        GetMLModelResponse GetMLModel(string mlModelId, bool verbose);

        /// <summary>
        /// Returns an <code>MLModel</code> that includes detailed metadata, and data source information
        /// as well as the current status of the <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// <code>GetMLModel</code> provides results in normal or verbose format. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMLModel service method.</param>
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
        GetMLModelResponse GetMLModel(GetMLModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMLModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetMLModelResponse> GetMLModelAsync(GetMLModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Predict

        /// <summary>
        /// Generates a prediction for the observation using the specified <code>MLModel</code>.
        /// 
        ///  <note><title>Note</title> 
        /// <para>
        /// Not all response parameters will be populated because this is dependent on the type
        /// of requested model.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="mlModelId">A unique identifier of the <code>MLModel</code>.</param>
        /// <param name="predictEndpoint">A property of PredictRequest used to execute the Predict service method.</param>
        /// <param name="record">A property of PredictRequest used to execute the Predict service method.</param>
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
        /// when listing objects such as <code>DataSource</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.PredictorNotMountedException">
        /// The exception is thrown when a predict request is made to an unmounted <code>MLModel</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        PredictResponse Predict(string mlModelId, string predictEndpoint, Dictionary<string, string> record);

        /// <summary>
        /// Generates a prediction for the observation using the specified <code>MLModel</code>.
        /// 
        ///  <note><title>Note</title> 
        /// <para>
        /// Not all response parameters will be populated because this is dependent on the type
        /// of requested model.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Predict service method.</param>
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
        /// when listing objects such as <code>DataSource</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.PredictorNotMountedException">
        /// The exception is thrown when a predict request is made to an unmounted <code>MLModel</code>.
        /// </exception>
        /// <exception cref="Amazon.MachineLearning.Model.ResourceNotFoundException">
        /// A specified resource cannot be located.
        /// </exception>
        PredictResponse Predict(PredictRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Predict operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Predict operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PredictResponse> PredictAsync(PredictRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBatchPrediction

        /// <summary>
        /// Updates the <code>BatchPredictionName</code> of a <code>BatchPrediction</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>GetBatchPrediction</a> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="batchPredictionId">The ID assigned to the <code>BatchPrediction</code> during creation.</param>
        /// <param name="batchPredictionName">A new user-supplied name or description of the <code>BatchPrediction</code>.</param>
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
        UpdateBatchPredictionResponse UpdateBatchPrediction(string batchPredictionId, string batchPredictionName);

        /// <summary>
        /// Updates the <code>BatchPredictionName</code> of a <code>BatchPrediction</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>GetBatchPrediction</a> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBatchPrediction service method.</param>
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
        UpdateBatchPredictionResponse UpdateBatchPrediction(UpdateBatchPredictionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBatchPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBatchPrediction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateBatchPredictionResponse> UpdateBatchPredictionAsync(UpdateBatchPredictionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDataSource

        /// <summary>
        /// Updates the <code>DataSourceName</code> of a <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>GetDataSource</a> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="dataSourceId">The ID assigned to the <code>DataSource</code> during creation.</param>
        /// <param name="dataSourceName">A new user-supplied name or description of the <code>DataSource</code> that will replace the current description. </param>
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
        UpdateDataSourceResponse UpdateDataSource(string dataSourceId, string dataSourceName);

        /// <summary>
        /// Updates the <code>DataSourceName</code> of a <code>DataSource</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>GetDataSource</a> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
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
        UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEvaluation

        /// <summary>
        /// Updates the <code>EvaluationName</code> of an <code>Evaluation</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>GetEvaluation</a> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="evaluationId">The ID assigned to the <code>Evaluation</code> during creation.</param>
        /// <param name="evaluationName">A new user-supplied name or description of the <code>Evaluation</code> that will replace the current content. </param>
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
        UpdateEvaluationResponse UpdateEvaluation(string evaluationId, string evaluationName);

        /// <summary>
        /// Updates the <code>EvaluationName</code> of an <code>Evaluation</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>GetEvaluation</a> operation to view the contents of the updated
        /// data element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluation service method.</param>
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
        UpdateEvaluationResponse UpdateEvaluation(UpdateEvaluationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEvaluation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateEvaluationResponse> UpdateEvaluationAsync(UpdateEvaluationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMLModel

        /// <summary>
        /// Updates the <code>MLModelName</code> and the <code>ScoreThreshold</code> of an <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>GetMLModel</a> operation to view the contents of the updated data
        /// element.
        /// </para>
        /// </summary>
        /// <param name="mlModelId">The ID assigned to the <code>MLModel</code> during creation.</param>
        /// <param name="mlModelName">A user-supplied name or description of the <code>MLModel</code>.</param>
        /// <param name="scoreThreshold">The <code>ScoreThreshold</code> used in binary classification <code>MLModel</code> that marks the boundary between a positive prediction and a negative prediction. Output values greater than or equal to the <code>ScoreThreshold</code> receive a positive result from the <code>MLModel</code>, such as <code>true</code>. Output values less than the <code>ScoreThreshold</code> receive a negative response from the <code>MLModel</code>, such as <code>false</code>.</param>
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
        UpdateMLModelResponse UpdateMLModel(string mlModelId, string mlModelName, float scoreThreshold);

        /// <summary>
        /// Updates the <code>MLModelName</code> and the <code>ScoreThreshold</code> of an <code>MLModel</code>.
        /// 
        ///  
        /// <para>
        /// You can use the <a>GetMLModel</a> operation to view the contents of the updated data
        /// element.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLModel service method.</param>
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
        UpdateMLModelResponse UpdateMLModel(UpdateMLModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMLModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMLModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateMLModelResponse> UpdateMLModelAsync(UpdateMLModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}