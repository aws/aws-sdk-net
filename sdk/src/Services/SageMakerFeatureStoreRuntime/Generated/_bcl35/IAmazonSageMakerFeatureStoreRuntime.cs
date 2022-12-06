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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMakerFeatureStoreRuntime.Model;

namespace Amazon.SageMakerFeatureStoreRuntime
{
    /// <summary>
    /// Interface for accessing SageMakerFeatureStoreRuntime
    ///
    /// Contains all data plane API operations and data types for the Amazon SageMaker Feature
    /// Store. Use this API to put, delete, and retrieve (get) features from a feature store.
    /// 
    ///  
    /// <para>
    /// Use the following operations to configure your <code>OnlineStore</code> and <code>OfflineStore</code>
    /// features, and to create and manage feature groups:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateFeatureGroup.html">CreateFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DeleteFeatureGroup.html">DeleteFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeFeatureGroup.html">DescribeFeatureGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ListFeatureGroups.html">ListFeatureGroups</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSageMakerFeatureStoreRuntime : IAmazonService, IDisposable
    {




        
        #region  BatchGetRecord


        /// <summary>
        /// Retrieves a batch of <code>Records</code> from a <code>FeatureGroup</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRecord service method.</param>
        /// 
        /// <returns>The response from the BatchGetRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/BatchGetRecord">REST API Reference for BatchGetRecord Operation</seealso>
        BatchGetRecordResponse BatchGetRecord(BatchGetRecordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRecord operation on AmazonSageMakerFeatureStoreRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/BatchGetRecord">REST API Reference for BatchGetRecord Operation</seealso>
        IAsyncResult BeginBatchGetRecord(BatchGetRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetRecord.</param>
        /// 
        /// <returns>Returns a  BatchGetRecordResult from SageMakerFeatureStoreRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/BatchGetRecord">REST API Reference for BatchGetRecord Operation</seealso>
        BatchGetRecordResponse EndBatchGetRecord(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRecord


        /// <summary>
        /// Deletes a <code>Record</code> from a <code>FeatureGroup</code>. When the <code>DeleteRecord</code>
        /// API is called a new record will be added to the <code>OfflineStore</code> and the
        /// <code>Record</code> will be removed from the <code>OnlineStore</code>. This record
        /// will have a value of <code>True</code> in the <code>is_deleted</code> column.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecord service method.</param>
        /// 
        /// <returns>The response from the DeleteRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/DeleteRecord">REST API Reference for DeleteRecord Operation</seealso>
        DeleteRecordResponse DeleteRecord(DeleteRecordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecord operation on AmazonSageMakerFeatureStoreRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/DeleteRecord">REST API Reference for DeleteRecord Operation</seealso>
        IAsyncResult BeginDeleteRecord(DeleteRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecord.</param>
        /// 
        /// <returns>Returns a  DeleteRecordResult from SageMakerFeatureStoreRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/DeleteRecord">REST API Reference for DeleteRecord Operation</seealso>
        DeleteRecordResponse EndDeleteRecord(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecord


        /// <summary>
        /// Use for <code>OnlineStore</code> serving from a <code>FeatureStore</code>. Only the
        /// latest records stored in the <code>OnlineStore</code> can be retrieved. If no Record
        /// with <code>RecordIdentifierValue</code> is found, then an empty result is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecord service method.</param>
        /// 
        /// <returns>The response from the GetRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ResourceNotFoundException">
        /// A resource that is required to perform an action was not found.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/GetRecord">REST API Reference for GetRecord Operation</seealso>
        GetRecordResponse GetRecord(GetRecordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecord operation on AmazonSageMakerFeatureStoreRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/GetRecord">REST API Reference for GetRecord Operation</seealso>
        IAsyncResult BeginGetRecord(GetRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecord.</param>
        /// 
        /// <returns>Returns a  GetRecordResult from SageMakerFeatureStoreRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/GetRecord">REST API Reference for GetRecord Operation</seealso>
        GetRecordResponse EndGetRecord(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRecord


        /// <summary>
        /// Used for data ingestion into the <code>FeatureStore</code>. The <code>PutRecord</code>
        /// API writes to both the <code>OnlineStore</code> and <code>OfflineStore</code>. If
        /// the record is the latest record for the <code>recordIdentifier</code>, the record
        /// is written to both the <code>OnlineStore</code> and <code>OfflineStore</code>. If
        /// the record is a historic record, it is written only to the <code>OfflineStore</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by SageMakerFeatureStoreRuntime.</returns>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.AccessForbiddenException">
        /// You do not have permission to perform an action.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.InternalFailureException">
        /// An internal failure occurred. Try your request again. If the problem persists, contact
        /// Amazon Web Services customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.SageMakerFeatureStoreRuntime.Model.ValidationErrorException">
        /// There was an error validating your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/PutRecord">REST API Reference for PutRecord Operation</seealso>
        PutRecordResponse PutRecord(PutRecordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation on AmazonSageMakerFeatureStoreRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/PutRecord">REST API Reference for PutRecord Operation</seealso>
        IAsyncResult BeginPutRecord(PutRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecord.</param>
        /// 
        /// <returns>Returns a  PutRecordResult from SageMakerFeatureStoreRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-featurestore-runtime-2020-07-01/PutRecord">REST API Reference for PutRecord Operation</seealso>
        PutRecordResponse EndPutRecord(IAsyncResult asyncResult);

        #endregion
        
    }
}