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
 * Do not modify this file. This file is generated from the s3vectors-2025-07-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.S3Vectors.Model;

#pragma warning disable CS1570
namespace Amazon.S3Vectors
{
    /// <summary>
    /// <para>Interface for accessing S3Vectors</para>
    ///
    /// Amazon S3 vector buckets are a bucket type to store and search vectors with sub-second
    /// search times. They are designed to provide dedicated API operations for you to interact
    /// with vectors to do similarity search. Within a vector bucket, you use a vector index
    /// to organize and logically group your vector data. When you make a write or read request,
    /// you direct it to a single vector index. You store your vector data as vectors. A vector
    /// contains a key (a name that you assign), a multi-dimensional vector, and, optionally,
    /// metadata that describes a vector. The key uniquely identifies the vector in a vector
    /// index.
    /// </summary>
    public partial interface IAmazonS3Vectors : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IS3VectorsPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateIndex


        /// <summary>
        /// Creates a vector index within a vector bucket. To specify the vector bucket, you must
        /// use either the vector bucket name or the vector bucket Amazon Resource Name (ARN).
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:CreateIndex</c> permission to use this operation.
        /// </para>
        ///  
        /// <para>
        /// You must have the <c>s3vectors:TagResource</c> permission in addition to <c>s3vectors:CreateIndex</c>
        /// permission to create a vector index with tags.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ConflictException">
        /// The request failed because a vector bucket name or a vector index name already exists.
        /// Vector bucket names must be unique within your Amazon Web Services account for each
        /// Amazon Web Services Region. Vector index names must be unique within your vector bucket.
        /// Choose a different vector bucket name or vector index name, and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        CreateIndexResponse CreateIndex(CreateIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        IAsyncResult BeginCreateIndex(CreateIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIndex.</param>
        /// 
        /// <returns>Returns a  CreateIndexResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        CreateIndexResponse EndCreateIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVectorBucket


        /// <summary>
        /// Creates a vector bucket in the Amazon Web Services Region that you want your bucket
        /// to be in. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:CreateVectorBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must have the <c>s3vectors:TagResource</c> permission in addition to <c>s3vectors:CreateVectorBucket</c>
        /// permission to create a vector bucket with tags.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVectorBucket service method.</param>
        /// 
        /// <returns>The response from the CreateVectorBucket service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ConflictException">
        /// The request failed because a vector bucket name or a vector index name already exists.
        /// Vector bucket names must be unique within your Amazon Web Services account for each
        /// Amazon Web Services Region. Vector index names must be unique within your vector bucket.
        /// Choose a different vector bucket name or vector index name, and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/CreateVectorBucket">REST API Reference for CreateVectorBucket Operation</seealso>
        CreateVectorBucketResponse CreateVectorBucket(CreateVectorBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVectorBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVectorBucket operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVectorBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/CreateVectorBucket">REST API Reference for CreateVectorBucket Operation</seealso>
        IAsyncResult BeginCreateVectorBucket(CreateVectorBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVectorBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVectorBucket.</param>
        /// 
        /// <returns>Returns a  CreateVectorBucketResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/CreateVectorBucket">REST API Reference for CreateVectorBucket Operation</seealso>
        CreateVectorBucketResponse EndCreateVectorBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIndex


        /// <summary>
        /// Deletes a vector index. To specify the vector index, you can either use both the vector
        /// bucket name and vector index name, or use the vector index Amazon Resource Name (ARN).
        /// 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:DeleteIndex</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        DeleteIndexResponse DeleteIndex(DeleteIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        IAsyncResult BeginDeleteIndex(DeleteIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndex.</param>
        /// 
        /// <returns>Returns a  DeleteIndexResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        DeleteIndexResponse EndDeleteIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVectorBucket


        /// <summary>
        /// Deletes a vector bucket. All vector indexes in the vector bucket must be deleted before
        /// the vector bucket can be deleted. To perform this operation, you must use either the
        /// vector bucket name or the vector bucket Amazon Resource Name (ARN). 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:DeleteVectorBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteVectorBucket service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ConflictException">
        /// The request failed because a vector bucket name or a vector index name already exists.
        /// Vector bucket names must be unique within your Amazon Web Services account for each
        /// Amazon Web Services Region. Vector index names must be unique within your vector bucket.
        /// Choose a different vector bucket name or vector index name, and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectorBucket">REST API Reference for DeleteVectorBucket Operation</seealso>
        DeleteVectorBucketResponse DeleteVectorBucket(DeleteVectorBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVectorBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorBucket operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVectorBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectorBucket">REST API Reference for DeleteVectorBucket Operation</seealso>
        IAsyncResult BeginDeleteVectorBucket(DeleteVectorBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVectorBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVectorBucket.</param>
        /// 
        /// <returns>Returns a  DeleteVectorBucketResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectorBucket">REST API Reference for DeleteVectorBucket Operation</seealso>
        DeleteVectorBucketResponse EndDeleteVectorBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVectorBucketPolicy


        /// <summary>
        /// Deletes a vector bucket policy. To specify the bucket, you must use either the vector
        /// bucket name or the vector bucket Amazon Resource Name (ARN).
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:DeleteVectorBucketPolicy</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteVectorBucketPolicy service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectorBucketPolicy">REST API Reference for DeleteVectorBucketPolicy Operation</seealso>
        DeleteVectorBucketPolicyResponse DeleteVectorBucketPolicy(DeleteVectorBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVectorBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectorBucketPolicy operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVectorBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectorBucketPolicy">REST API Reference for DeleteVectorBucketPolicy Operation</seealso>
        IAsyncResult BeginDeleteVectorBucketPolicy(DeleteVectorBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVectorBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVectorBucketPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteVectorBucketPolicyResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectorBucketPolicy">REST API Reference for DeleteVectorBucketPolicy Operation</seealso>
        DeleteVectorBucketPolicyResponse EndDeleteVectorBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVectors


        /// <summary>
        /// Deletes one or more vectors in a vector index. To specify the vector index, you can
        /// either use both the vector bucket name and vector index name, or use the vector index
        /// Amazon Resource Name (ARN). 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:DeleteVectors</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectors service method.</param>
        /// 
        /// <returns>The response from the DeleteVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsDisabledException">
        /// The specified Amazon Web Services KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (<c>KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">InvalidKeyUsageException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidStateException">
        /// The key state of the KMS key isn't compatible with the operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">KMSInvalidStateException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsNotFoundException">
        /// The KMS key can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectors">REST API Reference for DeleteVectors Operation</seealso>
        DeleteVectorsResponse DeleteVectors(DeleteVectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVectors operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectors">REST API Reference for DeleteVectors Operation</seealso>
        IAsyncResult BeginDeleteVectors(DeleteVectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVectors.</param>
        /// 
        /// <returns>Returns a  DeleteVectorsResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/DeleteVectors">REST API Reference for DeleteVectors Operation</seealso>
        DeleteVectorsResponse EndDeleteVectors(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIndex


        /// <summary>
        /// Returns vector index attributes. To specify the vector index, you can either use both
        /// the vector bucket name and the vector index name, or use the vector index Amazon Resource
        /// Name (ARN). 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:GetIndex</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndex service method.</param>
        /// 
        /// <returns>The response from the GetIndex service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetIndex">REST API Reference for GetIndex Operation</seealso>
        GetIndexResponse GetIndex(GetIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIndex operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetIndex">REST API Reference for GetIndex Operation</seealso>
        IAsyncResult BeginGetIndex(GetIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIndex.</param>
        /// 
        /// <returns>Returns a  GetIndexResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetIndex">REST API Reference for GetIndex Operation</seealso>
        GetIndexResponse EndGetIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVectorBucket


        /// <summary>
        /// Returns vector bucket attributes. To specify the bucket, you must use either the vector
        /// bucket name or the vector bucket Amazon Resource Name (ARN). 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:GetVectorBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectorBucket service method.</param>
        /// 
        /// <returns>The response from the GetVectorBucket service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectorBucket">REST API Reference for GetVectorBucket Operation</seealso>
        GetVectorBucketResponse GetVectorBucket(GetVectorBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVectorBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVectorBucket operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVectorBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectorBucket">REST API Reference for GetVectorBucket Operation</seealso>
        IAsyncResult BeginGetVectorBucket(GetVectorBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVectorBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVectorBucket.</param>
        /// 
        /// <returns>Returns a  GetVectorBucketResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectorBucket">REST API Reference for GetVectorBucket Operation</seealso>
        GetVectorBucketResponse EndGetVectorBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVectorBucketPolicy


        /// <summary>
        /// Gets details about a vector bucket policy. To specify the bucket, you must use either
        /// the vector bucket name or the vector bucket Amazon Resource Name (ARN). 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:GetVectorBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectorBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the GetVectorBucketPolicy service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectorBucketPolicy">REST API Reference for GetVectorBucketPolicy Operation</seealso>
        GetVectorBucketPolicyResponse GetVectorBucketPolicy(GetVectorBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVectorBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVectorBucketPolicy operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVectorBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectorBucketPolicy">REST API Reference for GetVectorBucketPolicy Operation</seealso>
        IAsyncResult BeginGetVectorBucketPolicy(GetVectorBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVectorBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVectorBucketPolicy.</param>
        /// 
        /// <returns>Returns a  GetVectorBucketPolicyResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectorBucketPolicy">REST API Reference for GetVectorBucketPolicy Operation</seealso>
        GetVectorBucketPolicyResponse EndGetVectorBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVectors


        /// <summary>
        /// Returns vector attributes. To specify the vector index, you can either use both the
        /// vector bucket name and the vector index name, or use the vector index Amazon Resource
        /// Name (ARN). 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:GetVectors</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVectors service method.</param>
        /// 
        /// <returns>The response from the GetVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsDisabledException">
        /// The specified Amazon Web Services KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (<c>KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">InvalidKeyUsageException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidStateException">
        /// The key state of the KMS key isn't compatible with the operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">KMSInvalidStateException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsNotFoundException">
        /// The KMS key can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectors">REST API Reference for GetVectors Operation</seealso>
        GetVectorsResponse GetVectors(GetVectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVectors operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectors">REST API Reference for GetVectors Operation</seealso>
        IAsyncResult BeginGetVectors(GetVectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVectors.</param>
        /// 
        /// <returns>Returns a  GetVectorsResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/GetVectors">REST API Reference for GetVectors Operation</seealso>
        GetVectorsResponse EndGetVectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIndexes


        /// <summary>
        /// Returns a list of all the vector indexes within the specified vector bucket. To specify
        /// the bucket, you must use either the vector bucket name or the vector bucket Amazon
        /// Resource Name (ARN). 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:ListIndexes</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndexes service method.</param>
        /// 
        /// <returns>The response from the ListIndexes service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListIndexes">REST API Reference for ListIndexes Operation</seealso>
        ListIndexesResponse ListIndexes(ListIndexesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndexes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndexes operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndexes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListIndexes">REST API Reference for ListIndexes Operation</seealso>
        IAsyncResult BeginListIndexes(ListIndexesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndexes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndexes.</param>
        /// 
        /// <returns>Returns a  ListIndexesResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListIndexes">REST API Reference for ListIndexes Operation</seealso>
        ListIndexesResponse EndListIndexes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags applied to a specified Amazon S3 Vectors resource. Each tag
        /// is a label consisting of a key and value pair. Tags can help you organize, track costs
        /// for, and control access to resources. 
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For vector buckets and vector indexes, you must have the <c>s3vectors:ListTagsForResource</c>
        /// permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVectorBuckets


        /// <summary>
        /// Returns a list of all the vector buckets that are owned by the authenticated sender
        /// of the request.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:ListVectorBuckets</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVectorBuckets service method.</param>
        /// 
        /// <returns>The response from the ListVectorBuckets service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListVectorBuckets">REST API Reference for ListVectorBuckets Operation</seealso>
        ListVectorBucketsResponse ListVectorBuckets(ListVectorBucketsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVectorBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVectorBuckets operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVectorBuckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListVectorBuckets">REST API Reference for ListVectorBuckets Operation</seealso>
        IAsyncResult BeginListVectorBuckets(ListVectorBucketsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVectorBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVectorBuckets.</param>
        /// 
        /// <returns>Returns a  ListVectorBucketsResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListVectorBuckets">REST API Reference for ListVectorBuckets Operation</seealso>
        ListVectorBucketsResponse EndListVectorBuckets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVectors


        /// <summary>
        /// List vectors in the specified vector index. To specify the vector index, you can either
        /// use both the vector bucket name and the vector index name, or use the vector index
        /// Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        ///  <c>ListVectors</c> operations proceed sequentially; however, for faster performance
        /// on a large number of vectors in a vector index, applications can request a parallel
        /// <c>ListVectors</c> operation by providing the <c>segmentCount</c> and <c>segmentIndex</c>
        /// parameters.
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:ListVectors</c> permission to use this operation. Additional
        /// permissions are required based on the request parameters you specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With only <c>s3vectors:ListVectors</c> permission, you can list vector keys when <c>returnData</c>
        /// and <c>returnMetadata</c> are both set to false or not specified..
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set <c>returnData</c> or <c>returnMetadata</c> to true, you must have both
        /// <c>s3vectors:ListVectors</c> and <c>s3vectors:GetVectors</c> permissions. The request
        /// fails with a <c>403 Forbidden</c> error if you request vector data or metadata without
        /// the <c>s3vectors:GetVectors</c> permission.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVectors service method.</param>
        /// 
        /// <returns>The response from the ListVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListVectors">REST API Reference for ListVectors Operation</seealso>
        ListVectorsResponse ListVectors(ListVectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVectors operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListVectors">REST API Reference for ListVectors Operation</seealso>
        IAsyncResult BeginListVectors(ListVectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVectors.</param>
        /// 
        /// <returns>Returns a  ListVectorsResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/ListVectors">REST API Reference for ListVectors Operation</seealso>
        ListVectorsResponse EndListVectors(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVectorBucketPolicy


        /// <summary>
        /// Creates a bucket policy for a vector bucket. To specify the bucket, you must use either
        /// the vector bucket name or the vector bucket Amazon Resource Name (ARN). 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:PutVectorBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVectorBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the PutVectorBucketPolicy service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/PutVectorBucketPolicy">REST API Reference for PutVectorBucketPolicy Operation</seealso>
        PutVectorBucketPolicyResponse PutVectorBucketPolicy(PutVectorBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVectorBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVectorBucketPolicy operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVectorBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/PutVectorBucketPolicy">REST API Reference for PutVectorBucketPolicy Operation</seealso>
        IAsyncResult BeginPutVectorBucketPolicy(PutVectorBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVectorBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVectorBucketPolicy.</param>
        /// 
        /// <returns>Returns a  PutVectorBucketPolicyResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/PutVectorBucketPolicy">REST API Reference for PutVectorBucketPolicy Operation</seealso>
        PutVectorBucketPolicyResponse EndPutVectorBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVectors


        /// <summary>
        /// Adds one or more vectors to a vector index. To specify the vector index, you can either
        /// use both the vector bucket name and the vector index name, or use the vector index
        /// Amazon Resource Name (ARN). 
        /// 
        ///  
        /// <para>
        /// For more information about limits, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-vectors-limitations.html">Limitations
        /// and restrictions</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When inserting vector data into your vector index, you must provide the vector data
        /// as <c>float32</c> (32-bit floating point) values. If you pass higher-precision values
        /// to an Amazon Web Services SDK, S3 Vectors converts the values to 32-bit floating point
        /// before storing them, and <c>GetVectors</c>, <c>ListVectors</c>, and <c>QueryVectors</c>
        /// operations return the float32 values. Different Amazon Web Services SDKs may have
        /// different default numeric types, so ensure your vectors are properly formatted as
        /// <c>float32</c> values regardless of which SDK you're using. For example, in Python,
        /// use <c>numpy.float32</c> or explicitly cast your values.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:PutVectors</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVectors service method.</param>
        /// 
        /// <returns>The response from the PutVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsDisabledException">
        /// The specified Amazon Web Services KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (<c>KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">InvalidKeyUsageException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidStateException">
        /// The key state of the KMS key isn't compatible with the operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">KMSInvalidStateException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsNotFoundException">
        /// The KMS key can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceQuotaExceededException">
        /// Your request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/PutVectors">REST API Reference for PutVectors Operation</seealso>
        PutVectorsResponse PutVectors(PutVectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVectors operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/PutVectors">REST API Reference for PutVectors Operation</seealso>
        IAsyncResult BeginPutVectors(PutVectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVectors.</param>
        /// 
        /// <returns>Returns a  PutVectorsResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/PutVectors">REST API Reference for PutVectors Operation</seealso>
        PutVectorsResponse EndPutVectors(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryVectors


        /// <summary>
        /// Performs an approximate nearest neighbor search query in a vector index using a query
        /// vector. By default, it returns the keys of approximate nearest neighbors. You can
        /// optionally include the computed distance (between the query vector and each vector
        /// in the response), the vector data, and metadata of each vector in the response. 
        /// 
        ///  
        /// <para>
        /// To specify the vector index, you can either use both the vector bucket name and the
        /// vector index name, or use the vector index Amazon Resource Name (ARN). 
        /// </para>
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3vectors:QueryVectors</c> permission to use this operation.
        /// Additional permissions are required based on the request parameters you specify:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With only <c>s3vectors:QueryVectors</c> permission, you can retrieve vector keys of
        /// approximate nearest neighbors and computed distances between these vectors. This permission
        /// is sufficient only when you don't set any metadata filters and don't request vector
        /// data or metadata (by keeping the <c>returnMetadata</c> parameter set to <c>false</c>
        /// or not specified).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a metadata filter or set <c>returnMetadata</c> to true, you must have
        /// both <c>s3vectors:QueryVectors</c> and <c>s3vectors:GetVectors</c> permissions. The
        /// request fails with a <c>403 Forbidden error</c> if you request metadata filtering,
        /// vector data, or metadata without the <c>s3vectors:GetVectors</c> permission.
        /// </para>
        ///  </li> </ul> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryVectors service method.</param>
        /// 
        /// <returns>The response from the QueryVectors service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsDisabledException">
        /// The specified Amazon Web Services KMS key isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (<c>KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">InvalidKeyUsageException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsInvalidStateException">
        /// The key state of the KMS key isn't compatible with the operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_Encrypt.html#API_Encrypt_Errors">KMSInvalidStateException</a>
        /// in the <i>Amazon Web Services Key Management Service API Reference</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.KmsNotFoundException">
        /// The KMS key can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/QueryVectors">REST API Reference for QueryVectors Operation</seealso>
        QueryVectorsResponse QueryVectors(QueryVectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryVectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryVectors operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryVectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/QueryVectors">REST API Reference for QueryVectors Operation</seealso>
        IAsyncResult BeginQueryVectors(QueryVectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryVectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryVectors.</param>
        /// 
        /// <returns>Returns a  QueryVectorsResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/QueryVectors">REST API Reference for QueryVectors Operation</seealso>
        QueryVectorsResponse EndQueryVectors(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies one or more user-defined tags to an Amazon S3 Vectors resource or updates
        /// existing tags. Each tag is a label consisting of a key and value pair. Tags can help
        /// you organize, track costs for, and control access to your resources. You can add up
        /// to 50 tags for each resource.
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For vector buckets and vector indexes, you must have the <c>s3vectors:TagResource</c>
        /// permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ConflictException">
        /// The request failed because a vector bucket name or a vector index name already exists.
        /// Vector bucket names must be unique within your Amazon Web Services account for each
        /// Amazon Web Services Region. Vector index names must be unique within your vector bucket.
        /// Choose a different vector bucket name or vector index name, and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified user-defined tags from an Amazon S3 Vectors resource. You can
        /// pass one or more tag keys. 
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For vector buckets and vector indexes, you must have the <c>s3vectors:UntagResource</c>
        /// permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by S3Vectors.</returns>
        /// <exception cref="Amazon.S3Vectors.Model.AccessDeniedException">
        /// Access denied.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ConflictException">
        /// The request failed because a vector bucket name or a vector index name already exists.
        /// Vector bucket names must be unique within your Amazon Web Services account for each
        /// Amazon Web Services Region. Vector index names must be unique within your vector bucket.
        /// Choose a different vector bucket name or vector index name, and try again.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.InternalServerException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.NotFoundException">
        /// The request was rejected because the specified resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.RequestTimeoutException">
        /// The request timed out. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ServiceUnavailableException">
        /// The service is unavailable. Wait briefly and retry your request. If it continues to
        /// fail, increase your waiting time between retries.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.TooManyRequestsException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.S3Vectors.Model.ValidationException">
        /// The requested action isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonS3VectorsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from S3Vectors.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3vectors-2025-07-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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