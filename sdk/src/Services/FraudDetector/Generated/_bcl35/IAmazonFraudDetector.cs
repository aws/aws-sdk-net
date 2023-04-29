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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FraudDetector.Model;

namespace Amazon.FraudDetector
{
    /// <summary>
    /// Interface for accessing FraudDetector
    ///
    /// This is the Amazon Fraud Detector API Reference. This guide is for developers who
    /// need detailed information about Amazon Fraud Detector API actions, data types, and
    /// errors. For more information about Amazon Fraud Detector features, see the <a href="https://docs.aws.amazon.com/frauddetector/latest/ug/">Amazon
    /// Fraud Detector User Guide</a>.
    /// 
    ///  
    /// <para>
    /// We provide the Query API as well as AWS software development kits (SDK) for Amazon
    /// Fraud Detector in Java and Python programming languages.
    /// </para>
    ///  
    /// <para>
    /// The Amazon Fraud Detector Query API provides HTTPS requests that use the HTTP verb
    /// GET or POST and a Query parameter <code>Action</code>. AWS SDK provides libraries,
    /// sample code, tutorials, and other resources for software developers who prefer to
    /// build applications using language-specific APIs instead of submitting a request over
    /// HTTP or HTTPS. These libraries provide basic functions that automatically take care
    /// of tasks such as cryptographically signing your requests, retrying requests, and handling
    /// error responses, so that it is easier for you to get started. For more information
    /// about the AWS SDKs, see <a href="https://docs.aws.amazon.com/https:/aws.amazon.com/tools/">Tools
    /// to build on AWS</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonFraudDetector : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFraudDetectorPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchCreateVariable


        /// <summary>
        /// Creates a batch of variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVariable service method.</param>
        /// 
        /// <returns>The response from the BatchCreateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        BatchCreateVariableResponse BatchCreateVariable(BatchCreateVariableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        IAsyncResult BeginBatchCreateVariable(BatchCreateVariableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateVariable.</param>
        /// 
        /// <returns>Returns a  BatchCreateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchCreateVariable">REST API Reference for BatchCreateVariable Operation</seealso>
        BatchCreateVariableResponse EndBatchCreateVariable(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetVariable


        /// <summary>
        /// Gets a batch of variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVariable service method.</param>
        /// 
        /// <returns>The response from the BatchGetVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        BatchGetVariableResponse BatchGetVariable(BatchGetVariableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        IAsyncResult BeginBatchGetVariable(BatchGetVariableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetVariable.</param>
        /// 
        /// <returns>Returns a  BatchGetVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/BatchGetVariable">REST API Reference for BatchGetVariable Operation</seealso>
        BatchGetVariableResponse EndBatchGetVariable(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelBatchImportJob


        /// <summary>
        /// Cancels an in-progress batch import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchImportJob service method.</param>
        /// 
        /// <returns>The response from the CancelBatchImportJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchImportJob">REST API Reference for CancelBatchImportJob Operation</seealso>
        CancelBatchImportJobResponse CancelBatchImportJob(CancelBatchImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchImportJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBatchImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchImportJob">REST API Reference for CancelBatchImportJob Operation</seealso>
        IAsyncResult BeginCancelBatchImportJob(CancelBatchImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBatchImportJob.</param>
        /// 
        /// <returns>Returns a  CancelBatchImportJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchImportJob">REST API Reference for CancelBatchImportJob Operation</seealso>
        CancelBatchImportJobResponse EndCancelBatchImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelBatchPredictionJob


        /// <summary>
        /// Cancels the specified batch prediction job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchPredictionJob service method.</param>
        /// 
        /// <returns>The response from the CancelBatchPredictionJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchPredictionJob">REST API Reference for CancelBatchPredictionJob Operation</seealso>
        CancelBatchPredictionJobResponse CancelBatchPredictionJob(CancelBatchPredictionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBatchPredictionJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBatchPredictionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchPredictionJob">REST API Reference for CancelBatchPredictionJob Operation</seealso>
        IAsyncResult BeginCancelBatchPredictionJob(CancelBatchPredictionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBatchPredictionJob.</param>
        /// 
        /// <returns>Returns a  CancelBatchPredictionJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CancelBatchPredictionJob">REST API Reference for CancelBatchPredictionJob Operation</seealso>
        CancelBatchPredictionJobResponse EndCancelBatchPredictionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBatchImportJob


        /// <summary>
        /// Creates a batch import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateBatchImportJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchImportJob">REST API Reference for CreateBatchImportJob Operation</seealso>
        CreateBatchImportJobResponse CreateBatchImportJob(CreateBatchImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchImportJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBatchImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchImportJob">REST API Reference for CreateBatchImportJob Operation</seealso>
        IAsyncResult BeginCreateBatchImportJob(CreateBatchImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchImportJob.</param>
        /// 
        /// <returns>Returns a  CreateBatchImportJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchImportJob">REST API Reference for CreateBatchImportJob Operation</seealso>
        CreateBatchImportJobResponse EndCreateBatchImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBatchPredictionJob


        /// <summary>
        /// Creates a batch prediction job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPredictionJob service method.</param>
        /// 
        /// <returns>The response from the CreateBatchPredictionJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchPredictionJob">REST API Reference for CreateBatchPredictionJob Operation</seealso>
        CreateBatchPredictionJobResponse CreateBatchPredictionJob(CreateBatchPredictionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchPredictionJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBatchPredictionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchPredictionJob">REST API Reference for CreateBatchPredictionJob Operation</seealso>
        IAsyncResult BeginCreateBatchPredictionJob(CreateBatchPredictionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchPredictionJob.</param>
        /// 
        /// <returns>Returns a  CreateBatchPredictionJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateBatchPredictionJob">REST API Reference for CreateBatchPredictionJob Operation</seealso>
        CreateBatchPredictionJobResponse EndCreateBatchPredictionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDetectorVersion


        /// <summary>
        /// Creates a detector version. The detector version starts in a <code>DRAFT</code> status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the CreateDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        CreateDetectorVersionResponse CreateDetectorVersion(CreateDetectorVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        IAsyncResult BeginCreateDetectorVersion(CreateDetectorVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDetectorVersion.</param>
        /// 
        /// <returns>Returns a  CreateDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateDetectorVersion">REST API Reference for CreateDetectorVersion Operation</seealso>
        CreateDetectorVersionResponse EndCreateDetectorVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateList


        /// <summary>
        /// Creates a list. 
        /// 
        ///  
        /// <para>
        /// List is a set of input data for a variable in your event dataset. You use the input
        /// data in a rule that's associated with your detector. For more information, see <a
        /// href="https://docs.aws.amazon.com/frauddetector/latest/ug/lists.html">Lists</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateList service method.</param>
        /// 
        /// <returns>The response from the CreateList service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateList">REST API Reference for CreateList Operation</seealso>
        CreateListResponse CreateList(CreateListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateList operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateList">REST API Reference for CreateList Operation</seealso>
        IAsyncResult BeginCreateList(CreateListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateList.</param>
        /// 
        /// <returns>Returns a  CreateListResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateList">REST API Reference for CreateList Operation</seealso>
        CreateListResponse EndCreateList(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Creates a model using the specified model type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse CreateModel(CreateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse EndCreateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModelVersion


        /// <summary>
        /// Creates a version of the model using the specified model type and model id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion service method.</param>
        /// 
        /// <returns>The response from the CreateModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        CreateModelVersionResponse CreateModelVersion(CreateModelVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        IAsyncResult BeginCreateModelVersion(CreateModelVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelVersion.</param>
        /// 
        /// <returns>Returns a  CreateModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateModelVersion">REST API Reference for CreateModelVersion Operation</seealso>
        CreateModelVersionResponse EndCreateModelVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a rule for use with the specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse CreateRule(CreateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse EndCreateRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVariable


        /// <summary>
        /// Creates a variable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVariable service method.</param>
        /// 
        /// <returns>The response from the CreateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        CreateVariableResponse CreateVariable(CreateVariableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        IAsyncResult BeginCreateVariable(CreateVariableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVariable.</param>
        /// 
        /// <returns>Returns a  CreateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/CreateVariable">REST API Reference for CreateVariable Operation</seealso>
        CreateVariableResponse EndCreateVariable(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBatchImportJob


        /// <summary>
        /// Deletes the specified batch import job ID record. This action does not delete the
        /// data that was batch imported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchImportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteBatchImportJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchImportJob">REST API Reference for DeleteBatchImportJob Operation</seealso>
        DeleteBatchImportJobResponse DeleteBatchImportJob(DeleteBatchImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchImportJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBatchImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchImportJob">REST API Reference for DeleteBatchImportJob Operation</seealso>
        IAsyncResult BeginDeleteBatchImportJob(DeleteBatchImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBatchImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBatchImportJob.</param>
        /// 
        /// <returns>Returns a  DeleteBatchImportJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchImportJob">REST API Reference for DeleteBatchImportJob Operation</seealso>
        DeleteBatchImportJobResponse EndDeleteBatchImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBatchPredictionJob


        /// <summary>
        /// Deletes a batch prediction job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPredictionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteBatchPredictionJob service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchPredictionJob">REST API Reference for DeleteBatchPredictionJob Operation</seealso>
        DeleteBatchPredictionJobResponse DeleteBatchPredictionJob(DeleteBatchPredictionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBatchPredictionJob operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBatchPredictionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchPredictionJob">REST API Reference for DeleteBatchPredictionJob Operation</seealso>
        IAsyncResult BeginDeleteBatchPredictionJob(DeleteBatchPredictionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBatchPredictionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBatchPredictionJob.</param>
        /// 
        /// <returns>Returns a  DeleteBatchPredictionJobResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteBatchPredictionJob">REST API Reference for DeleteBatchPredictionJob Operation</seealso>
        DeleteBatchPredictionJobResponse EndDeleteBatchPredictionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDetector


        /// <summary>
        /// Deletes the detector. Before deleting a detector, you must first delete all detector
        /// versions and rule versions associated with the detector.
        /// 
        ///  
        /// <para>
        /// When you delete a detector, Amazon Fraud Detector permanently deletes the detector
        /// and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        DeleteDetectorResponse DeleteDetector(DeleteDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        IAsyncResult BeginDeleteDetector(DeleteDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDetector.</param>
        /// 
        /// <returns>Returns a  DeleteDetectorResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        DeleteDetectorResponse EndDeleteDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDetectorVersion


        /// <summary>
        /// Deletes the detector version. You cannot delete detector versions that are in <code>ACTIVE</code>
        /// status.
        /// 
        ///  
        /// <para>
        /// When you delete a detector version, Amazon Fraud Detector permanently deletes the
        /// detector and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        DeleteDetectorVersionResponse DeleteDetectorVersion(DeleteDetectorVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        IAsyncResult BeginDeleteDetectorVersion(DeleteDetectorVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDetectorVersion.</param>
        /// 
        /// <returns>Returns a  DeleteDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteDetectorVersion">REST API Reference for DeleteDetectorVersion Operation</seealso>
        DeleteDetectorVersionResponse EndDeleteDetectorVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEntityType


        /// <summary>
        /// Deletes an entity type.
        /// 
        ///  
        /// <para>
        /// You cannot delete an entity type that is included in an event type.
        /// </para>
        ///  
        /// <para>
        /// When you delete an entity type, Amazon Fraud Detector permanently deletes that entity
        /// type and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityType service method.</param>
        /// 
        /// <returns>The response from the DeleteEntityType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEntityType">REST API Reference for DeleteEntityType Operation</seealso>
        DeleteEntityTypeResponse DeleteEntityType(DeleteEntityTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEntityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEntityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEntityType">REST API Reference for DeleteEntityType Operation</seealso>
        IAsyncResult BeginDeleteEntityType(DeleteEntityTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEntityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEntityType.</param>
        /// 
        /// <returns>Returns a  DeleteEntityTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEntityType">REST API Reference for DeleteEntityType Operation</seealso>
        DeleteEntityTypeResponse EndDeleteEntityType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEvent


        /// <summary>
        /// Deletes the specified event.
        /// 
        ///  
        /// <para>
        /// When you delete an event, Amazon Fraud Detector permanently deletes that event and
        /// the event data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        DeleteEventResponse DeleteEvent(DeleteEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        IAsyncResult BeginDeleteEvent(DeleteEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEvent.</param>
        /// 
        /// <returns>Returns a  DeleteEventResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        DeleteEventResponse EndDeleteEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventsByEventType


        /// <summary>
        /// Deletes all events of a particular event type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsByEventType service method.</param>
        /// 
        /// <returns>The response from the DeleteEventsByEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventsByEventType">REST API Reference for DeleteEventsByEventType Operation</seealso>
        DeleteEventsByEventTypeResponse DeleteEventsByEventType(DeleteEventsByEventTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventsByEventType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventsByEventType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventsByEventType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventsByEventType">REST API Reference for DeleteEventsByEventType Operation</seealso>
        IAsyncResult BeginDeleteEventsByEventType(DeleteEventsByEventTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventsByEventType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventsByEventType.</param>
        /// 
        /// <returns>Returns a  DeleteEventsByEventTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventsByEventType">REST API Reference for DeleteEventsByEventType Operation</seealso>
        DeleteEventsByEventTypeResponse EndDeleteEventsByEventType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventType


        /// <summary>
        /// Deletes an event type.
        /// 
        ///  
        /// <para>
        /// You cannot delete an event type that is used in a detector or a model.
        /// </para>
        ///  
        /// <para>
        /// When you delete an event type, Amazon Fraud Detector permanently deletes that event
        /// type and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventType service method.</param>
        /// 
        /// <returns>The response from the DeleteEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventType">REST API Reference for DeleteEventType Operation</seealso>
        DeleteEventTypeResponse DeleteEventType(DeleteEventTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventType">REST API Reference for DeleteEventType Operation</seealso>
        IAsyncResult BeginDeleteEventType(DeleteEventTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventType.</param>
        /// 
        /// <returns>Returns a  DeleteEventTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteEventType">REST API Reference for DeleteEventType Operation</seealso>
        DeleteEventTypeResponse EndDeleteEventType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteExternalModel


        /// <summary>
        /// Removes a SageMaker model from Amazon Fraud Detector.
        /// 
        ///  
        /// <para>
        /// You can remove an Amazon SageMaker model if it is not associated with a detector version.
        /// Removing a SageMaker model disconnects it from Amazon Fraud Detector, but the model
        /// remains available in SageMaker.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteExternalModel service method.</param>
        /// 
        /// <returns>The response from the DeleteExternalModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteExternalModel">REST API Reference for DeleteExternalModel Operation</seealso>
        DeleteExternalModelResponse DeleteExternalModel(DeleteExternalModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteExternalModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteExternalModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteExternalModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteExternalModel">REST API Reference for DeleteExternalModel Operation</seealso>
        IAsyncResult BeginDeleteExternalModel(DeleteExternalModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteExternalModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteExternalModel.</param>
        /// 
        /// <returns>Returns a  DeleteExternalModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteExternalModel">REST API Reference for DeleteExternalModel Operation</seealso>
        DeleteExternalModelResponse EndDeleteExternalModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLabel


        /// <summary>
        /// Deletes a label.
        /// 
        ///  
        /// <para>
        /// You cannot delete labels that are included in an event type in Amazon Fraud Detector.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a label assigned to an event ID. You must first delete the relevant
        /// event ID.
        /// </para>
        ///  
        /// <para>
        /// When you delete a label, Amazon Fraud Detector permanently deletes that label and
        /// the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel service method.</param>
        /// 
        /// <returns>The response from the DeleteLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        DeleteLabelResponse DeleteLabel(DeleteLabelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLabel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        IAsyncResult BeginDeleteLabel(DeleteLabelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLabel.</param>
        /// 
        /// <returns>Returns a  DeleteLabelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteLabel">REST API Reference for DeleteLabel Operation</seealso>
        DeleteLabelResponse EndDeleteLabel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteList


        /// <summary>
        /// Deletes the list, provided it is not used in a rule. 
        /// 
        ///  
        /// <para>
        ///  When you delete a list, Amazon Fraud Detector permanently deletes that list and the
        /// elements in the list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteList service method.</param>
        /// 
        /// <returns>The response from the DeleteList service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteList">REST API Reference for DeleteList Operation</seealso>
        DeleteListResponse DeleteList(DeleteListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteList operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteList">REST API Reference for DeleteList Operation</seealso>
        IAsyncResult BeginDeleteList(DeleteListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteList.</param>
        /// 
        /// <returns>Returns a  DeleteListResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteList">REST API Reference for DeleteList Operation</seealso>
        DeleteListResponse EndDeleteList(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a model.
        /// 
        ///  
        /// <para>
        /// You can delete models and model versions in Amazon Fraud Detector, provided that they
        /// are not associated with a detector version.
        /// </para>
        ///  
        /// <para>
        ///  When you delete a model, Amazon Fraud Detector permanently deletes that model and
        /// the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse DeleteModel(DeleteModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModelVersion


        /// <summary>
        /// Deletes a model version.
        /// 
        ///  
        /// <para>
        /// You can delete models and model versions in Amazon Fraud Detector, provided that they
        /// are not associated with a detector version.
        /// </para>
        ///  
        /// <para>
        ///  When you delete a model version, Amazon Fraud Detector permanently deletes that model
        /// version and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModelVersion">REST API Reference for DeleteModelVersion Operation</seealso>
        DeleteModelVersionResponse DeleteModelVersion(DeleteModelVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModelVersion">REST API Reference for DeleteModelVersion Operation</seealso>
        IAsyncResult BeginDeleteModelVersion(DeleteModelVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelVersion.</param>
        /// 
        /// <returns>Returns a  DeleteModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteModelVersion">REST API Reference for DeleteModelVersion Operation</seealso>
        DeleteModelVersionResponse EndDeleteModelVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOutcome


        /// <summary>
        /// Deletes an outcome.
        /// 
        ///  
        /// <para>
        /// You cannot delete an outcome that is used in a rule version.
        /// </para>
        ///  
        /// <para>
        /// When you delete an outcome, Amazon Fraud Detector permanently deletes that outcome
        /// and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutcome service method.</param>
        /// 
        /// <returns>The response from the DeleteOutcome service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteOutcome">REST API Reference for DeleteOutcome Operation</seealso>
        DeleteOutcomeResponse DeleteOutcome(DeleteOutcomeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOutcome operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutcome operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOutcome
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteOutcome">REST API Reference for DeleteOutcome Operation</seealso>
        IAsyncResult BeginDeleteOutcome(DeleteOutcomeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOutcome operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOutcome.</param>
        /// 
        /// <returns>Returns a  DeleteOutcomeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteOutcome">REST API Reference for DeleteOutcome Operation</seealso>
        DeleteOutcomeResponse EndDeleteOutcome(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes the rule. You cannot delete a rule if it is used by an <code>ACTIVE</code>
        /// or <code>INACTIVE</code> detector version.
        /// 
        ///  
        /// <para>
        /// When you delete a rule, Amazon Fraud Detector permanently deletes that rule and the
        /// data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVariable


        /// <summary>
        /// Deletes a variable.
        /// 
        ///  
        /// <para>
        /// You can't delete variables that are included in an event type in Amazon Fraud Detector.
        /// </para>
        ///  
        /// <para>
        /// Amazon Fraud Detector automatically deletes model output variables and SageMaker model
        /// output variables when you delete the model. You can't delete these variables manually.
        /// </para>
        ///  
        /// <para>
        /// When you delete a variable, Amazon Fraud Detector permanently deletes that variable
        /// and the data is no longer stored in Amazon Fraud Detector.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariable service method.</param>
        /// 
        /// <returns>The response from the DeleteVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteVariable">REST API Reference for DeleteVariable Operation</seealso>
        DeleteVariableResponse DeleteVariable(DeleteVariableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteVariable">REST API Reference for DeleteVariable Operation</seealso>
        IAsyncResult BeginDeleteVariable(DeleteVariableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVariable.</param>
        /// 
        /// <returns>Returns a  DeleteVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DeleteVariable">REST API Reference for DeleteVariable Operation</seealso>
        DeleteVariableResponse EndDeleteVariable(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDetector


        /// <summary>
        /// Gets all versions for a specified detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector service method.</param>
        /// 
        /// <returns>The response from the DescribeDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        DescribeDetectorResponse DescribeDetector(DescribeDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetector operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        IAsyncResult BeginDescribeDetector(DescribeDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDetector.</param>
        /// 
        /// <returns>Returns a  DescribeDetectorResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeDetector">REST API Reference for DescribeDetector Operation</seealso>
        DescribeDetectorResponse EndDescribeDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelVersions


        /// <summary>
        /// Gets all of the model versions for the specified model type or for the specified model
        /// type and model ID. You can also get details for a single, specified model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeModelVersions service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        DescribeModelVersionsResponse DescribeModelVersions(DescribeModelVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelVersions operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        IAsyncResult BeginDescribeModelVersions(DescribeModelVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelVersions.</param>
        /// 
        /// <returns>Returns a  DescribeModelVersionsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/DescribeModelVersions">REST API Reference for DescribeModelVersions Operation</seealso>
        DescribeModelVersionsResponse EndDescribeModelVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBatchImportJobs


        /// <summary>
        /// Gets all batch import jobs or a specific job of the specified ID. This is a paginated
        /// API. If you provide a null <code>maxResults</code>, this action retrieves a maximum
        /// of 50 records per page. If you provide a <code>maxResults</code>, the value must be
        /// between 1 and 50. To get the next page results, provide the pagination token from
        /// the <code>GetBatchImportJobsResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetBatchImportJobs service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchImportJobs">REST API Reference for GetBatchImportJobs Operation</seealso>
        GetBatchImportJobsResponse GetBatchImportJobs(GetBatchImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBatchImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBatchImportJobs operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBatchImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchImportJobs">REST API Reference for GetBatchImportJobs Operation</seealso>
        IAsyncResult BeginGetBatchImportJobs(GetBatchImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBatchImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBatchImportJobs.</param>
        /// 
        /// <returns>Returns a  GetBatchImportJobsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchImportJobs">REST API Reference for GetBatchImportJobs Operation</seealso>
        GetBatchImportJobsResponse EndGetBatchImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBatchPredictionJobs


        /// <summary>
        /// Gets all batch prediction jobs or a specific job if you specify a job ID. This is
        /// a paginated API. If you provide a null maxResults, this action retrieves a maximum
        /// of 50 records per page. If you provide a maxResults, the value must be between 1 and
        /// 50. To get the next page results, provide the pagination token from the GetBatchPredictionJobsResponse
        /// as part of your request. A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPredictionJobs service method.</param>
        /// 
        /// <returns>The response from the GetBatchPredictionJobs service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchPredictionJobs">REST API Reference for GetBatchPredictionJobs Operation</seealso>
        GetBatchPredictionJobsResponse GetBatchPredictionJobs(GetBatchPredictionJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBatchPredictionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBatchPredictionJobs operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBatchPredictionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchPredictionJobs">REST API Reference for GetBatchPredictionJobs Operation</seealso>
        IAsyncResult BeginGetBatchPredictionJobs(GetBatchPredictionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBatchPredictionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBatchPredictionJobs.</param>
        /// 
        /// <returns>Returns a  GetBatchPredictionJobsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetBatchPredictionJobs">REST API Reference for GetBatchPredictionJobs Operation</seealso>
        GetBatchPredictionJobsResponse EndGetBatchPredictionJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeleteEventsByEventTypeStatus


        /// <summary>
        /// Retrieves the status of a <code>DeleteEventsByEventType</code> action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeleteEventsByEventTypeStatus service method.</param>
        /// 
        /// <returns>The response from the GetDeleteEventsByEventTypeStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDeleteEventsByEventTypeStatus">REST API Reference for GetDeleteEventsByEventTypeStatus Operation</seealso>
        GetDeleteEventsByEventTypeStatusResponse GetDeleteEventsByEventTypeStatus(GetDeleteEventsByEventTypeStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeleteEventsByEventTypeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeleteEventsByEventTypeStatus operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeleteEventsByEventTypeStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDeleteEventsByEventTypeStatus">REST API Reference for GetDeleteEventsByEventTypeStatus Operation</seealso>
        IAsyncResult BeginGetDeleteEventsByEventTypeStatus(GetDeleteEventsByEventTypeStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeleteEventsByEventTypeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeleteEventsByEventTypeStatus.</param>
        /// 
        /// <returns>Returns a  GetDeleteEventsByEventTypeStatusResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDeleteEventsByEventTypeStatus">REST API Reference for GetDeleteEventsByEventTypeStatus Operation</seealso>
        GetDeleteEventsByEventTypeStatusResponse EndGetDeleteEventsByEventTypeStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDetectors


        /// <summary>
        /// Gets all detectors or a single detector if a <code>detectorId</code> is specified.
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetDetectorsResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors service method.</param>
        /// 
        /// <returns>The response from the GetDetectors service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        GetDetectorsResponse GetDetectors(GetDetectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetectors operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        IAsyncResult BeginGetDetectors(GetDetectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetectors.</param>
        /// 
        /// <returns>Returns a  GetDetectorsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectors">REST API Reference for GetDetectors Operation</seealso>
        GetDetectorsResponse EndGetDetectors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDetectorVersion


        /// <summary>
        /// Gets a particular detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the GetDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        GetDetectorVersionResponse GetDetectorVersion(GetDetectorVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        IAsyncResult BeginGetDetectorVersion(GetDetectorVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDetectorVersion.</param>
        /// 
        /// <returns>Returns a  GetDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetDetectorVersion">REST API Reference for GetDetectorVersion Operation</seealso>
        GetDetectorVersionResponse EndGetDetectorVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEntityTypes


        /// <summary>
        /// Gets all entity types or a specific entity type if a name is specified. This is a
        /// paginated API. If you provide a null <code>maxResults</code>, this action retrieves
        /// a maximum of 10 records per page. If you provide a <code>maxResults</code>, the value
        /// must be between 5 and 10. To get the next page results, provide the pagination token
        /// from the <code>GetEntityTypesResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntityTypes service method.</param>
        /// 
        /// <returns>The response from the GetEntityTypes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEntityTypes">REST API Reference for GetEntityTypes Operation</seealso>
        GetEntityTypesResponse GetEntityTypes(GetEntityTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEntityTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEntityTypes operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEntityTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEntityTypes">REST API Reference for GetEntityTypes Operation</seealso>
        IAsyncResult BeginGetEntityTypes(GetEntityTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEntityTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEntityTypes.</param>
        /// 
        /// <returns>Returns a  GetEntityTypesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEntityTypes">REST API Reference for GetEntityTypes Operation</seealso>
        GetEntityTypesResponse EndGetEntityTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEvent


        /// <summary>
        /// Retrieves details of events stored with Amazon Fraud Detector. This action does not
        /// retrieve prediction results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvent service method.</param>
        /// 
        /// <returns>The response from the GetEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEvent">REST API Reference for GetEvent Operation</seealso>
        GetEventResponse GetEvent(GetEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvent operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEvent">REST API Reference for GetEvent Operation</seealso>
        IAsyncResult BeginGetEvent(GetEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvent.</param>
        /// 
        /// <returns>Returns a  GetEventResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEvent">REST API Reference for GetEvent Operation</seealso>
        GetEventResponse EndGetEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventPrediction


        /// <summary>
        /// Evaluates an event against a detector version. If a version ID is not provided, the
        /// detector’s (<code>ACTIVE</code>) version is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventPrediction service method.</param>
        /// 
        /// <returns>The response from the GetEventPrediction service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceUnavailableException">
        /// An exception indicating that the attached customer-owned (external) model threw an
        /// exception when Amazon Fraud Detector invoked the model.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPrediction">REST API Reference for GetEventPrediction Operation</seealso>
        GetEventPredictionResponse GetEventPrediction(GetEventPredictionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventPrediction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventPrediction operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventPrediction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPrediction">REST API Reference for GetEventPrediction Operation</seealso>
        IAsyncResult BeginGetEventPrediction(GetEventPredictionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventPrediction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventPrediction.</param>
        /// 
        /// <returns>Returns a  GetEventPredictionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPrediction">REST API Reference for GetEventPrediction Operation</seealso>
        GetEventPredictionResponse EndGetEventPrediction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventPredictionMetadata


        /// <summary>
        /// Gets details of the past fraud predictions for the specified event ID, event type,
        /// detector ID, and detector version ID that was generated in the specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventPredictionMetadata service method.</param>
        /// 
        /// <returns>The response from the GetEventPredictionMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPredictionMetadata">REST API Reference for GetEventPredictionMetadata Operation</seealso>
        GetEventPredictionMetadataResponse GetEventPredictionMetadata(GetEventPredictionMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventPredictionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventPredictionMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventPredictionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPredictionMetadata">REST API Reference for GetEventPredictionMetadata Operation</seealso>
        IAsyncResult BeginGetEventPredictionMetadata(GetEventPredictionMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventPredictionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventPredictionMetadata.</param>
        /// 
        /// <returns>Returns a  GetEventPredictionMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventPredictionMetadata">REST API Reference for GetEventPredictionMetadata Operation</seealso>
        GetEventPredictionMetadataResponse EndGetEventPredictionMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventTypes


        /// <summary>
        /// Gets all event types or a specific event type if name is provided. This is a paginated
        /// API. If you provide a null <code>maxResults</code>, this action retrieves a maximum
        /// of 10 records per page. If you provide a <code>maxResults</code>, the value must be
        /// between 5 and 10. To get the next page results, provide the pagination token from
        /// the <code>GetEventTypesResponse</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventTypes service method.</param>
        /// 
        /// <returns>The response from the GetEventTypes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventTypes">REST API Reference for GetEventTypes Operation</seealso>
        GetEventTypesResponse GetEventTypes(GetEventTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventTypes operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventTypes">REST API Reference for GetEventTypes Operation</seealso>
        IAsyncResult BeginGetEventTypes(GetEventTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventTypes.</param>
        /// 
        /// <returns>Returns a  GetEventTypesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetEventTypes">REST API Reference for GetEventTypes Operation</seealso>
        GetEventTypesResponse EndGetEventTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExternalModels


        /// <summary>
        /// Gets the details for one or more Amazon SageMaker models that have been imported into
        /// the service. This is a paginated API. If you provide a null <code>maxResults</code>,
        /// this actions retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 5 and 10. To get the next page results, provide the pagination
        /// token from the <code>GetExternalModelsResult</code> as part of your request. A null
        /// pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExternalModels service method.</param>
        /// 
        /// <returns>The response from the GetExternalModels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        GetExternalModelsResponse GetExternalModels(GetExternalModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExternalModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExternalModels operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExternalModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        IAsyncResult BeginGetExternalModels(GetExternalModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExternalModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExternalModels.</param>
        /// 
        /// <returns>Returns a  GetExternalModelsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetExternalModels">REST API Reference for GetExternalModels Operation</seealso>
        GetExternalModelsResponse EndGetExternalModels(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKMSEncryptionKey


        /// <summary>
        /// Gets the encryption key if a KMS key has been specified to be used to encrypt content
        /// in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKMSEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the GetKMSEncryptionKey service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetKMSEncryptionKey">REST API Reference for GetKMSEncryptionKey Operation</seealso>
        GetKMSEncryptionKeyResponse GetKMSEncryptionKey(GetKMSEncryptionKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKMSEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKMSEncryptionKey operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKMSEncryptionKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetKMSEncryptionKey">REST API Reference for GetKMSEncryptionKey Operation</seealso>
        IAsyncResult BeginGetKMSEncryptionKey(GetKMSEncryptionKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKMSEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKMSEncryptionKey.</param>
        /// 
        /// <returns>Returns a  GetKMSEncryptionKeyResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetKMSEncryptionKey">REST API Reference for GetKMSEncryptionKey Operation</seealso>
        GetKMSEncryptionKeyResponse EndGetKMSEncryptionKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLabels


        /// <summary>
        /// Gets all labels or a specific label if name is provided. This is a paginated API.
        /// If you provide a null <code>maxResults</code>, this action retrieves a maximum of
        /// 50 records per page. If you provide a <code>maxResults</code>, the value must be between
        /// 10 and 50. To get the next page results, provide the pagination token from the <code>GetGetLabelsResponse</code>
        /// as part of your request. A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLabels service method.</param>
        /// 
        /// <returns>The response from the GetLabels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetLabels">REST API Reference for GetLabels Operation</seealso>
        GetLabelsResponse GetLabels(GetLabelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLabels operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetLabels">REST API Reference for GetLabels Operation</seealso>
        IAsyncResult BeginGetLabels(GetLabelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLabels.</param>
        /// 
        /// <returns>Returns a  GetLabelsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetLabels">REST API Reference for GetLabels Operation</seealso>
        GetLabelsResponse EndGetLabels(IAsyncResult asyncResult);

        #endregion
        
        #region  GetListElements


        /// <summary>
        /// Gets all the elements in the specified list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListElements service method.</param>
        /// 
        /// <returns>The response from the GetListElements service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListElements">REST API Reference for GetListElements Operation</seealso>
        GetListElementsResponse GetListElements(GetListElementsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetListElements operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetListElements operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetListElements
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListElements">REST API Reference for GetListElements Operation</seealso>
        IAsyncResult BeginGetListElements(GetListElementsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetListElements operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetListElements.</param>
        /// 
        /// <returns>Returns a  GetListElementsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListElements">REST API Reference for GetListElements Operation</seealso>
        GetListElementsResponse EndGetListElements(IAsyncResult asyncResult);

        #endregion
        
        #region  GetListsMetadata


        /// <summary>
        /// Gets the metadata of either all the lists under the account or the specified list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListsMetadata service method.</param>
        /// 
        /// <returns>The response from the GetListsMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListsMetadata">REST API Reference for GetListsMetadata Operation</seealso>
        GetListsMetadataResponse GetListsMetadata(GetListsMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetListsMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetListsMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetListsMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListsMetadata">REST API Reference for GetListsMetadata Operation</seealso>
        IAsyncResult BeginGetListsMetadata(GetListsMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetListsMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetListsMetadata.</param>
        /// 
        /// <returns>Returns a  GetListsMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetListsMetadata">REST API Reference for GetListsMetadata Operation</seealso>
        GetListsMetadataResponse EndGetListsMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModels


        /// <summary>
        /// Gets one or more models. Gets all models for the Amazon Web Services account if no
        /// model type and no model id provided. Gets all models for the Amazon Web Services account
        /// and model type, if the model type is specified but model id is not provided. Gets
        /// a specific model if (model type, model id) tuple is specified. 
        /// 
        ///  
        /// <para>
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// retrieves a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 1 and 10. To get the next page results, provide the pagination
        /// token from the response as part of your request. A null pagination token fetches the
        /// records from the beginning.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        GetModelsResponse GetModels(GetModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        IAsyncResult BeginGetModels(GetModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModels.</param>
        /// 
        /// <returns>Returns a  GetModelsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModels">REST API Reference for GetModels Operation</seealso>
        GetModelsResponse EndGetModels(IAsyncResult asyncResult);

        #endregion
        
        #region  GetModelVersion


        /// <summary>
        /// Gets the details of the specified model version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion service method.</param>
        /// 
        /// <returns>The response from the GetModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        GetModelVersionResponse GetModelVersion(GetModelVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        IAsyncResult BeginGetModelVersion(GetModelVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetModelVersion.</param>
        /// 
        /// <returns>Returns a  GetModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetModelVersion">REST API Reference for GetModelVersion Operation</seealso>
        GetModelVersionResponse EndGetModelVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOutcomes


        /// <summary>
        /// Gets one or more outcomes. This is a paginated API. If you provide a null <code>maxResults</code>,
        /// this actions retrieves a maximum of 100 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 50 and 100. To get the next page results, provide the pagination
        /// token from the <code>GetOutcomesResult</code> as part of your request. A null pagination
        /// token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOutcomes service method.</param>
        /// 
        /// <returns>The response from the GetOutcomes service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        GetOutcomesResponse GetOutcomes(GetOutcomesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOutcomes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOutcomes operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOutcomes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        IAsyncResult BeginGetOutcomes(GetOutcomesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOutcomes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOutcomes.</param>
        /// 
        /// <returns>Returns a  GetOutcomesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetOutcomes">REST API Reference for GetOutcomes Operation</seealso>
        GetOutcomesResponse EndGetOutcomes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRules


        /// <summary>
        /// Get all rules for a detector (paginated) if <code>ruleId</code> and <code>ruleVersion</code>
        /// are not specified. Gets all rules for the detector and the <code>ruleId</code> if
        /// present (paginated). Gets a specific rule if both the <code>ruleId</code> and the
        /// <code>ruleVersion</code> are specified.
        /// 
        ///  
        /// <para>
        /// This is a paginated API. Providing null maxResults results in retrieving maximum of
        /// 100 records per page. If you provide maxResults the value must be between 50 and 100.
        /// To get the next page result, a provide a pagination token from GetRulesResult as part
        /// of your request. Null pagination token fetches the records from the beginning.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRules service method.</param>
        /// 
        /// <returns>The response from the GetRules service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        GetRulesResponse GetRules(GetRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRules operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        IAsyncResult BeginGetRules(GetRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRules.</param>
        /// 
        /// <returns>Returns a  GetRulesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetRules">REST API Reference for GetRules Operation</seealso>
        GetRulesResponse EndGetRules(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVariables


        /// <summary>
        /// Gets all of the variables or the specific variable. This is a paginated API. Providing
        /// null <code>maxSizePerPage</code> results in retrieving maximum of 100 records per
        /// page. If you provide <code>maxSizePerPage</code> the value must be between 50 and
        /// 100. To get the next page result, a provide a pagination token from <code>GetVariablesResult</code>
        /// as part of your request. Null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVariables service method.</param>
        /// 
        /// <returns>The response from the GetVariables service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        GetVariablesResponse GetVariables(GetVariablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVariables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVariables operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVariables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        IAsyncResult BeginGetVariables(GetVariablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVariables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVariables.</param>
        /// 
        /// <returns>Returns a  GetVariablesResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/GetVariables">REST API Reference for GetVariables Operation</seealso>
        GetVariablesResponse EndGetVariables(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventPredictions


        /// <summary>
        /// Gets a list of past predictions. The list can be filtered by detector ID, detector
        /// version ID, event ID, event type, or by specifying a time period. If filter is not
        /// specified, the most recent prediction is returned.
        /// 
        ///  
        /// <para>
        /// For example, the following filter lists all past predictions for <code>xyz</code>
        /// event type - <code>{ "eventType":{ "value": "xyz" }” } </code> 
        /// </para>
        ///  
        /// <para>
        /// This is a paginated API. If you provide a null <code>maxResults</code>, this action
        /// will retrieve a maximum of 10 records per page. If you provide a <code>maxResults</code>,
        /// the value must be between 50 and 100. To get the next page results, provide the <code>nextToken</code>
        /// from the response as part of your request. A null <code>nextToken</code> fetches the
        /// records from the beginning. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventPredictions service method.</param>
        /// 
        /// <returns>The response from the ListEventPredictions service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListEventPredictions">REST API Reference for ListEventPredictions Operation</seealso>
        ListEventPredictionsResponse ListEventPredictions(ListEventPredictionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventPredictions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventPredictions operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventPredictions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListEventPredictions">REST API Reference for ListEventPredictions Operation</seealso>
        IAsyncResult BeginListEventPredictions(ListEventPredictionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventPredictions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventPredictions.</param>
        /// 
        /// <returns>Returns a  ListEventPredictionsResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListEventPredictions">REST API Reference for ListEventPredictions Operation</seealso>
        ListEventPredictionsResponse EndListEventPredictions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with the resource. This is a paginated API. To get the next
        /// page results, provide the pagination token from the response as part of your request.
        /// A null pagination token fetches the records from the beginning.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDetector


        /// <summary>
        /// Creates or updates a detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDetector service method.</param>
        /// 
        /// <returns>The response from the PutDetector service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        PutDetectorResponse PutDetector(PutDetectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDetector operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        IAsyncResult BeginPutDetector(PutDetectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDetector.</param>
        /// 
        /// <returns>Returns a  PutDetectorResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutDetector">REST API Reference for PutDetector Operation</seealso>
        PutDetectorResponse EndPutDetector(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEntityType


        /// <summary>
        /// Creates or updates an entity type. An entity represents who is performing the event.
        /// As part of a fraud prediction, you pass the entity ID to indicate the specific entity
        /// who performed the event. An entity type classifies the entity. Example classifications
        /// include customer, merchant, or account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEntityType service method.</param>
        /// 
        /// <returns>The response from the PutEntityType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEntityType">REST API Reference for PutEntityType Operation</seealso>
        PutEntityTypeResponse PutEntityType(PutEntityTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEntityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEntityType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEntityType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEntityType">REST API Reference for PutEntityType Operation</seealso>
        IAsyncResult BeginPutEntityType(PutEntityTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEntityType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEntityType.</param>
        /// 
        /// <returns>Returns a  PutEntityTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEntityType">REST API Reference for PutEntityType Operation</seealso>
        PutEntityTypeResponse EndPutEntityType(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEventType


        /// <summary>
        /// Creates or updates an event type. An event is a business activity that is evaluated
        /// for fraud risk. With Amazon Fraud Detector, you generate fraud predictions for events.
        /// An event type defines the structure for an event sent to Amazon Fraud Detector. This
        /// includes the variables sent as part of the event, the entity performing the event
        /// (such as a customer), and the labels that classify the event. Example event types
        /// include online payment transactions, account registrations, and authentications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventType service method.</param>
        /// 
        /// <returns>The response from the PutEventType service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEventType">REST API Reference for PutEventType Operation</seealso>
        PutEventTypeResponse PutEventType(PutEventTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventType operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEventType">REST API Reference for PutEventType Operation</seealso>
        IAsyncResult BeginPutEventType(PutEventTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventType.</param>
        /// 
        /// <returns>Returns a  PutEventTypeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutEventType">REST API Reference for PutEventType Operation</seealso>
        PutEventTypeResponse EndPutEventType(IAsyncResult asyncResult);

        #endregion
        
        #region  PutExternalModel


        /// <summary>
        /// Creates or updates an Amazon SageMaker model endpoint. You can also use this action
        /// to update the configuration of the model endpoint, including the IAM role and/or the
        /// mapped variables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutExternalModel service method.</param>
        /// 
        /// <returns>The response from the PutExternalModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        PutExternalModelResponse PutExternalModel(PutExternalModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutExternalModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutExternalModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutExternalModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        IAsyncResult BeginPutExternalModel(PutExternalModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutExternalModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutExternalModel.</param>
        /// 
        /// <returns>Returns a  PutExternalModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutExternalModel">REST API Reference for PutExternalModel Operation</seealso>
        PutExternalModelResponse EndPutExternalModel(IAsyncResult asyncResult);

        #endregion
        
        #region  PutKMSEncryptionKey


        /// <summary>
        /// Specifies the KMS key to be used to encrypt content in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKMSEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the PutKMSEncryptionKey service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutKMSEncryptionKey">REST API Reference for PutKMSEncryptionKey Operation</seealso>
        PutKMSEncryptionKeyResponse PutKMSEncryptionKey(PutKMSEncryptionKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutKMSEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKMSEncryptionKey operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutKMSEncryptionKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutKMSEncryptionKey">REST API Reference for PutKMSEncryptionKey Operation</seealso>
        IAsyncResult BeginPutKMSEncryptionKey(PutKMSEncryptionKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutKMSEncryptionKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutKMSEncryptionKey.</param>
        /// 
        /// <returns>Returns a  PutKMSEncryptionKeyResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutKMSEncryptionKey">REST API Reference for PutKMSEncryptionKey Operation</seealso>
        PutKMSEncryptionKeyResponse EndPutKMSEncryptionKey(IAsyncResult asyncResult);

        #endregion
        
        #region  PutLabel


        /// <summary>
        /// Creates or updates label. A label classifies an event as fraudulent or legitimate.
        /// Labels are associated with event types and used to train supervised machine learning
        /// models in Amazon Fraud Detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLabel service method.</param>
        /// 
        /// <returns>The response from the PutLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutLabel">REST API Reference for PutLabel Operation</seealso>
        PutLabelResponse PutLabel(PutLabelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLabel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutLabel">REST API Reference for PutLabel Operation</seealso>
        IAsyncResult BeginPutLabel(PutLabelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLabel.</param>
        /// 
        /// <returns>Returns a  PutLabelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutLabel">REST API Reference for PutLabel Operation</seealso>
        PutLabelResponse EndPutLabel(IAsyncResult asyncResult);

        #endregion
        
        #region  PutOutcome


        /// <summary>
        /// Creates or updates an outcome.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOutcome service method.</param>
        /// 
        /// <returns>The response from the PutOutcome service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        PutOutcomeResponse PutOutcome(PutOutcomeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutOutcome operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutOutcome operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutOutcome
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        IAsyncResult BeginPutOutcome(PutOutcomeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutOutcome operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutOutcome.</param>
        /// 
        /// <returns>Returns a  PutOutcomeResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/PutOutcome">REST API Reference for PutOutcome Operation</seealso>
        PutOutcomeResponse EndPutOutcome(IAsyncResult asyncResult);

        #endregion
        
        #region  SendEvent


        /// <summary>
        /// Stores events in Amazon Fraud Detector without generating fraud predictions for those
        /// events. For example, you can use <code>SendEvent</code> to upload a historical dataset,
        /// which you can then later use to train a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEvent service method.</param>
        /// 
        /// <returns>The response from the SendEvent service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/SendEvent">REST API Reference for SendEvent Operation</seealso>
        SendEventResponse SendEvent(SendEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendEvent operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/SendEvent">REST API Reference for SendEvent Operation</seealso>
        IAsyncResult BeginSendEvent(SendEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendEvent.</param>
        /// 
        /// <returns>Returns a  SendEventResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/SendEvent">REST API Reference for SendEvent Operation</seealso>
        SendEventResponse EndSendEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDetectorVersion


        /// <summary>
        /// Updates a detector version. The detector version attributes that you can update include
        /// models, external model endpoints, rules, rule execution mode, and description. You
        /// can only update a <code>DRAFT</code> detector version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        UpdateDetectorVersionResponse UpdateDetectorVersion(UpdateDetectorVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        IAsyncResult BeginUpdateDetectorVersion(UpdateDetectorVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersion.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersion">REST API Reference for UpdateDetectorVersion Operation</seealso>
        UpdateDetectorVersionResponse EndUpdateDetectorVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDetectorVersionMetadata


        /// <summary>
        /// Updates the detector version's description. You can update the metadata for any detector
        /// version (<code>DRAFT, ACTIVE,</code> or <code>INACTIVE</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersionMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        UpdateDetectorVersionMetadataResponse UpdateDetectorVersionMetadata(UpdateDetectorVersionMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetectorVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersionMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        IAsyncResult BeginUpdateDetectorVersionMetadata(UpdateDetectorVersionMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersionMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersionMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionMetadata">REST API Reference for UpdateDetectorVersionMetadata Operation</seealso>
        UpdateDetectorVersionMetadataResponse EndUpdateDetectorVersionMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDetectorVersionStatus


        /// <summary>
        /// Updates the detector version’s status. You can perform the following promotions or
        /// demotions using <code>UpdateDetectorVersionStatus</code>: <code>DRAFT</code> to <code>ACTIVE</code>,
        /// <code>ACTIVE</code> to <code>INACTIVE</code>, and <code>INACTIVE</code> to <code>ACTIVE</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateDetectorVersionStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        UpdateDetectorVersionStatusResponse UpdateDetectorVersionStatus(UpdateDetectorVersionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDetectorVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorVersionStatus operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDetectorVersionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        IAsyncResult BeginUpdateDetectorVersionStatus(UpdateDetectorVersionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDetectorVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDetectorVersionStatus.</param>
        /// 
        /// <returns>Returns a  UpdateDetectorVersionStatusResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateDetectorVersionStatus">REST API Reference for UpdateDetectorVersionStatus Operation</seealso>
        UpdateDetectorVersionStatusResponse EndUpdateDetectorVersionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventLabel


        /// <summary>
        /// Updates the specified event with a new label.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventLabel service method.</param>
        /// 
        /// <returns>The response from the UpdateEventLabel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateEventLabel">REST API Reference for UpdateEventLabel Operation</seealso>
        UpdateEventLabelResponse UpdateEventLabel(UpdateEventLabelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventLabel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventLabel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventLabel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateEventLabel">REST API Reference for UpdateEventLabel Operation</seealso>
        IAsyncResult BeginUpdateEventLabel(UpdateEventLabelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventLabel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventLabel.</param>
        /// 
        /// <returns>Returns a  UpdateEventLabelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateEventLabel">REST API Reference for UpdateEventLabel Operation</seealso>
        UpdateEventLabelResponse EndUpdateEventLabel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateList


        /// <summary>
        /// Updates a list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateList service method.</param>
        /// 
        /// <returns>The response from the UpdateList service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateList">REST API Reference for UpdateList Operation</seealso>
        UpdateListResponse UpdateList(UpdateListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateList operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateList">REST API Reference for UpdateList Operation</seealso>
        IAsyncResult BeginUpdateList(UpdateListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateList.</param>
        /// 
        /// <returns>Returns a  UpdateListResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateList">REST API Reference for UpdateList Operation</seealso>
        UpdateListResponse EndUpdateList(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateModel


        /// <summary>
        /// Updates model description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        UpdateModelResponse UpdateModel(UpdateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        IAsyncResult BeginUpdateModel(UpdateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModel.</param>
        /// 
        /// <returns>Returns a  UpdateModelResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        UpdateModelResponse EndUpdateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateModelVersion


        /// <summary>
        /// Updates a model version. Updating a model version retrains an existing model version
        /// using updated training data and produces a new minor version of the model. You can
        /// update the training data set location and data access role attributes using this action.
        /// This action creates and trains a new minor version of the model, for example version
        /// 1.01, 1.02, 1.03.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateModelVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        UpdateModelVersionResponse UpdateModelVersion(UpdateModelVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        IAsyncResult BeginUpdateModelVersion(UpdateModelVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelVersion.</param>
        /// 
        /// <returns>Returns a  UpdateModelVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersion">REST API Reference for UpdateModelVersion Operation</seealso>
        UpdateModelVersionResponse EndUpdateModelVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateModelVersionStatus


        /// <summary>
        /// Updates the status of a model version.
        /// 
        ///  
        /// <para>
        /// You can perform the following status updates:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Change the <code>TRAINING_IN_PROGRESS</code> status to <code>TRAINING_CANCELLED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the <code>TRAINING_COMPLETE</code> status to <code>ACTIVE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change <code>ACTIVE</code> to <code>INACTIVE</code>.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersionStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateModelVersionStatus service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersionStatus">REST API Reference for UpdateModelVersionStatus Operation</seealso>
        UpdateModelVersionStatusResponse UpdateModelVersionStatus(UpdateModelVersionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModelVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModelVersionStatus operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateModelVersionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersionStatus">REST API Reference for UpdateModelVersionStatus Operation</seealso>
        IAsyncResult BeginUpdateModelVersionStatus(UpdateModelVersionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateModelVersionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateModelVersionStatus.</param>
        /// 
        /// <returns>Returns a  UpdateModelVersionStatusResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateModelVersionStatus">REST API Reference for UpdateModelVersionStatus Operation</seealso>
        UpdateModelVersionStatusResponse EndUpdateModelVersionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRuleMetadata


        /// <summary>
        /// Updates a rule's metadata. The description attribute can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleMetadata service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        UpdateRuleMetadataResponse UpdateRuleMetadata(UpdateRuleMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleMetadata operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        IAsyncResult BeginUpdateRuleMetadata(UpdateRuleMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateRuleMetadataResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleMetadata">REST API Reference for UpdateRuleMetadata Operation</seealso>
        UpdateRuleMetadataResponse EndUpdateRuleMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRuleVersion


        /// <summary>
        /// Updates a rule version resulting in a new rule version. Updates a rule version resulting
        /// in a new rule version (version 1, 2, 3 ...).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleVersion service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        UpdateRuleVersionResponse UpdateRuleVersion(UpdateRuleVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleVersion operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        IAsyncResult BeginUpdateRuleVersion(UpdateRuleVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleVersion.</param>
        /// 
        /// <returns>Returns a  UpdateRuleVersionResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateRuleVersion">REST API Reference for UpdateRuleVersion Operation</seealso>
        UpdateRuleVersionResponse EndUpdateRuleVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVariable


        /// <summary>
        /// Updates a variable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariable service method.</param>
        /// 
        /// <returns>The response from the UpdateVariable service method, as returned by FraudDetector.</returns>
        /// <exception cref="Amazon.FraudDetector.Model.AccessDeniedException">
        /// An exception indicating Amazon Fraud Detector does not have the needed permissions.
        /// This can occur if you submit a request, such as <code>PutExternalModel</code>, that
        /// specifies a role that is not in your account.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ConflictException">
        /// An exception indicating there was a conflict during a delete operation.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.InternalServerException">
        /// An exception indicating an internal server error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ResourceNotFoundException">
        /// An exception indicating the specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ThrottlingException">
        /// An exception indicating a throttling error.
        /// </exception>
        /// <exception cref="Amazon.FraudDetector.Model.ValidationException">
        /// An exception indicating a specified value is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        UpdateVariableResponse UpdateVariable(UpdateVariableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVariable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVariable operation on AmazonFraudDetectorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVariable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        IAsyncResult BeginUpdateVariable(UpdateVariableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVariable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVariable.</param>
        /// 
        /// <returns>Returns a  UpdateVariableResult from FraudDetector.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/frauddetector-2019-11-15/UpdateVariable">REST API Reference for UpdateVariable Operation</seealso>
        UpdateVariableResponse EndUpdateVariable(IAsyncResult asyncResult);

        #endregion
        
    }
}