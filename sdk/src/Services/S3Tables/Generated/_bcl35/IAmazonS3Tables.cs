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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.S3Tables.Model;

#pragma warning disable CS1570
namespace Amazon.S3Tables
{
    /// <summary>
    /// <para>Interface for accessing S3Tables</para>
    ///
    /// An Amazon S3 table represents a structured dataset consisting of tabular data in <a
    /// href="https://parquet.apache.org/docs/">Apache Parquet</a> format and related metadata.
    /// This data is stored inside an S3 table as a subresource. All tables in a table bucket
    /// are stored in the <a href="https://iceberg.apache.org/docs/latest/">Apache Iceberg</a>
    /// table format. Through integration with the <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/glue/latest/dg/catalog-and-crawler.html">AWS
    /// Glue Data Catalog</a> you can interact with your tables using AWS analytics services,
    /// such as <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/athena/">Amazon
    /// Athena</a> and <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/redshift/">Amazon
    /// Redshift</a>. Amazon S3 manages maintenance of your tables through automatic file
    /// compaction and snapshot management. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets.html">Amazon
    /// S3 table buckets</a>.
    /// </summary>
    public partial interface IAmazonS3Tables : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IS3TablesPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateNamespace


        /// <summary>
        /// Creates a namespace. A namespace is a logical grouping of tables within your table
        /// bucket, which you can use to organize tables. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace.html">Table
        /// namespaces</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        IAsyncResult BeginCreateNamespace(CreateNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNamespace.</param>
        /// 
        /// <returns>Returns a  CreateNamespaceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        CreateNamespaceResponse EndCreateNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTable


        /// <summary>
        /// Creates a new table associated with the given namespace in a table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        CreateTableResponse CreateTable(CreateTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        IAsyncResult BeginCreateTable(CreateTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTable.</param>
        /// 
        /// <returns>Returns a  CreateTableResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        CreateTableResponse EndCreateTable(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTableBucket


        /// <summary>
        /// Creates a table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTableBucket service method.</param>
        /// 
        /// <returns>The response from the CreateTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTableBucket">REST API Reference for CreateTableBucket Operation</seealso>
        CreateTableBucketResponse CreateTableBucket(CreateTableBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTableBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTableBucket operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTableBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTableBucket">REST API Reference for CreateTableBucket Operation</seealso>
        IAsyncResult BeginCreateTableBucket(CreateTableBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTableBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTableBucket.</param>
        /// 
        /// <returns>Returns a  CreateTableBucketResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/CreateTableBucket">REST API Reference for CreateTableBucket Operation</seealso>
        CreateTableBucketResponse EndCreateTableBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNamespace


        /// <summary>
        /// Deletes a namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        IAsyncResult BeginDeleteNamespace(DeleteNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteNamespaceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        DeleteNamespaceResponse EndDeleteNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTable


        /// <summary>
        /// Deletes a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        DeleteTableResponse DeleteTable(DeleteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        IAsyncResult BeginDeleteTable(DeleteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTable.</param>
        /// 
        /// <returns>Returns a  DeleteTableResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        DeleteTableResponse EndDeleteTable(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTableBucket


        /// <summary>
        /// Deletes a table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucket service method.</param>
        /// 
        /// <returns>The response from the DeleteTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucket">REST API Reference for DeleteTableBucket Operation</seealso>
        DeleteTableBucketResponse DeleteTableBucket(DeleteTableBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucket operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucket">REST API Reference for DeleteTableBucket Operation</seealso>
        IAsyncResult BeginDeleteTableBucket(DeleteTableBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableBucket.</param>
        /// 
        /// <returns>Returns a  DeleteTableBucketResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucket">REST API Reference for DeleteTableBucket Operation</seealso>
        DeleteTableBucketResponse EndDeleteTableBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTableBucketPolicy


        /// <summary>
        /// Deletes a table bucket policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketPolicy">REST API Reference for DeleteTableBucketPolicy Operation</seealso>
        DeleteTableBucketPolicyResponse DeleteTableBucketPolicy(DeleteTableBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketPolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketPolicy">REST API Reference for DeleteTableBucketPolicy Operation</seealso>
        IAsyncResult BeginDeleteTableBucketPolicy(DeleteTableBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableBucketPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteTableBucketPolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketPolicy">REST API Reference for DeleteTableBucketPolicy Operation</seealso>
        DeleteTableBucketPolicyResponse EndDeleteTableBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTablePolicy


        /// <summary>
        /// Deletes a table policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTablePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTablePolicy">REST API Reference for DeleteTablePolicy Operation</seealso>
        DeleteTablePolicyResponse DeleteTablePolicy(DeleteTablePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTablePolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTablePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTablePolicy">REST API Reference for DeleteTablePolicy Operation</seealso>
        IAsyncResult BeginDeleteTablePolicy(DeleteTablePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTablePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteTablePolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTablePolicy">REST API Reference for DeleteTablePolicy Operation</seealso>
        DeleteTablePolicyResponse EndDeleteTablePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNamespace


        /// <summary>
        /// Gets details about a namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        GetNamespaceResponse GetNamespace(GetNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        IAsyncResult BeginGetNamespace(GetNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNamespace.</param>
        /// 
        /// <returns>Returns a  GetNamespaceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        GetNamespaceResponse EndGetNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTable


        /// <summary>
        /// Gets details about a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTable service method.</param>
        /// 
        /// <returns>The response from the GetTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTable">REST API Reference for GetTable Operation</seealso>
        GetTableResponse GetTable(GetTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTable operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTable">REST API Reference for GetTable Operation</seealso>
        IAsyncResult BeginGetTable(GetTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTable.</param>
        /// 
        /// <returns>Returns a  GetTableResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTable">REST API Reference for GetTable Operation</seealso>
        GetTableResponse EndGetTable(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableBucket


        /// <summary>
        /// Gets details on a table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucket service method.</param>
        /// 
        /// <returns>The response from the GetTableBucket service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucket">REST API Reference for GetTableBucket Operation</seealso>
        GetTableBucketResponse GetTableBucket(GetTableBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucket operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucket
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucket">REST API Reference for GetTableBucket Operation</seealso>
        IAsyncResult BeginGetTableBucket(GetTableBucketRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucket operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucket.</param>
        /// 
        /// <returns>Returns a  GetTableBucketResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucket">REST API Reference for GetTableBucket Operation</seealso>
        GetTableBucketResponse EndGetTableBucket(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableBucketMaintenanceConfiguration


        /// <summary>
        /// Gets details about a maintenance configuration for a given table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketMaintenanceConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetTableBucketMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMaintenanceConfiguration">REST API Reference for GetTableBucketMaintenanceConfiguration Operation</seealso>
        GetTableBucketMaintenanceConfigurationResponse GetTableBucketMaintenanceConfiguration(GetTableBucketMaintenanceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucketMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketMaintenanceConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucketMaintenanceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMaintenanceConfiguration">REST API Reference for GetTableBucketMaintenanceConfiguration Operation</seealso>
        IAsyncResult BeginGetTableBucketMaintenanceConfiguration(GetTableBucketMaintenanceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucketMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucketMaintenanceConfiguration.</param>
        /// 
        /// <returns>Returns a  GetTableBucketMaintenanceConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMaintenanceConfiguration">REST API Reference for GetTableBucketMaintenanceConfiguration Operation</seealso>
        GetTableBucketMaintenanceConfigurationResponse EndGetTableBucketMaintenanceConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableBucketPolicy


        /// <summary>
        /// Gets details about a table bucket policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the GetTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketPolicy">REST API Reference for GetTableBucketPolicy Operation</seealso>
        GetTableBucketPolicyResponse GetTableBucketPolicy(GetTableBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketPolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketPolicy">REST API Reference for GetTableBucketPolicy Operation</seealso>
        IAsyncResult BeginGetTableBucketPolicy(GetTableBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucketPolicy.</param>
        /// 
        /// <returns>Returns a  GetTableBucketPolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketPolicy">REST API Reference for GetTableBucketPolicy Operation</seealso>
        GetTableBucketPolicyResponse EndGetTableBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableMaintenanceConfiguration


        /// <summary>
        /// Gets details about the maintenance configuration of a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetTableMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceConfiguration">REST API Reference for GetTableMaintenanceConfiguration Operation</seealso>
        GetTableMaintenanceConfigurationResponse GetTableMaintenanceConfiguration(GetTableMaintenanceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableMaintenanceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceConfiguration">REST API Reference for GetTableMaintenanceConfiguration Operation</seealso>
        IAsyncResult BeginGetTableMaintenanceConfiguration(GetTableMaintenanceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableMaintenanceConfiguration.</param>
        /// 
        /// <returns>Returns a  GetTableMaintenanceConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceConfiguration">REST API Reference for GetTableMaintenanceConfiguration Operation</seealso>
        GetTableMaintenanceConfigurationResponse EndGetTableMaintenanceConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableMaintenanceJobStatus


        /// <summary>
        /// Gets the status of a maintenance job for a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceJobStatus service method.</param>
        /// 
        /// <returns>The response from the GetTableMaintenanceJobStatus service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceJobStatus">REST API Reference for GetTableMaintenanceJobStatus Operation</seealso>
        GetTableMaintenanceJobStatusResponse GetTableMaintenanceJobStatus(GetTableMaintenanceJobStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableMaintenanceJobStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableMaintenanceJobStatus operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableMaintenanceJobStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceJobStatus">REST API Reference for GetTableMaintenanceJobStatus Operation</seealso>
        IAsyncResult BeginGetTableMaintenanceJobStatus(GetTableMaintenanceJobStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableMaintenanceJobStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableMaintenanceJobStatus.</param>
        /// 
        /// <returns>Returns a  GetTableMaintenanceJobStatusResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMaintenanceJobStatus">REST API Reference for GetTableMaintenanceJobStatus Operation</seealso>
        GetTableMaintenanceJobStatusResponse EndGetTableMaintenanceJobStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableMetadataLocation


        /// <summary>
        /// Gets the location of the table metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadataLocation service method.</param>
        /// 
        /// <returns>The response from the GetTableMetadataLocation service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMetadataLocation">REST API Reference for GetTableMetadataLocation Operation</seealso>
        GetTableMetadataLocationResponse GetTableMetadataLocation(GetTableMetadataLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableMetadataLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadataLocation operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableMetadataLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMetadataLocation">REST API Reference for GetTableMetadataLocation Operation</seealso>
        IAsyncResult BeginGetTableMetadataLocation(GetTableMetadataLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableMetadataLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableMetadataLocation.</param>
        /// 
        /// <returns>Returns a  GetTableMetadataLocationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableMetadataLocation">REST API Reference for GetTableMetadataLocation Operation</seealso>
        GetTableMetadataLocationResponse EndGetTableMetadataLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTablePolicy


        /// <summary>
        /// Gets details about a table policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTablePolicy service method.</param>
        /// 
        /// <returns>The response from the GetTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTablePolicy">REST API Reference for GetTablePolicy Operation</seealso>
        GetTablePolicyResponse GetTablePolicy(GetTablePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTablePolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTablePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTablePolicy">REST API Reference for GetTablePolicy Operation</seealso>
        IAsyncResult BeginGetTablePolicy(GetTablePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTablePolicy.</param>
        /// 
        /// <returns>Returns a  GetTablePolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTablePolicy">REST API Reference for GetTablePolicy Operation</seealso>
        GetTablePolicyResponse EndGetTablePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNamespaces


        /// <summary>
        /// Lists the namespaces within a table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        ListNamespacesResponse ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        IAsyncResult BeginListNamespaces(ListNamespacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNamespaces.</param>
        /// 
        /// <returns>Returns a  ListNamespacesResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        ListNamespacesResponse EndListNamespaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTableBuckets


        /// <summary>
        /// Lists table buckets for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableBuckets service method.</param>
        /// 
        /// <returns>The response from the ListTableBuckets service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTableBuckets">REST API Reference for ListTableBuckets Operation</seealso>
        ListTableBucketsResponse ListTableBuckets(ListTableBucketsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableBuckets operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableBuckets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTableBuckets">REST API Reference for ListTableBuckets Operation</seealso>
        IAsyncResult BeginListTableBuckets(ListTableBucketsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableBuckets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableBuckets.</param>
        /// 
        /// <returns>Returns a  ListTableBucketsResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTableBuckets">REST API Reference for ListTableBuckets Operation</seealso>
        ListTableBucketsResponse EndListTableBuckets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTables


        /// <summary>
        /// List tables in the given table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse ListTables(ListTablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTables">REST API Reference for ListTables Operation</seealso>
        IAsyncResult BeginListTables(ListTablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a  ListTablesResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse EndListTables(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTableBucketMaintenanceConfiguration


        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing maintenance configuration
        /// for a table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketMaintenanceConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutTableBucketMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMaintenanceConfiguration">REST API Reference for PutTableBucketMaintenanceConfiguration Operation</seealso>
        PutTableBucketMaintenanceConfigurationResponse PutTableBucketMaintenanceConfiguration(PutTableBucketMaintenanceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableBucketMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketMaintenanceConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableBucketMaintenanceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMaintenanceConfiguration">REST API Reference for PutTableBucketMaintenanceConfiguration Operation</seealso>
        IAsyncResult BeginPutTableBucketMaintenanceConfiguration(PutTableBucketMaintenanceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableBucketMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableBucketMaintenanceConfiguration.</param>
        /// 
        /// <returns>Returns a  PutTableBucketMaintenanceConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMaintenanceConfiguration">REST API Reference for PutTableBucketMaintenanceConfiguration Operation</seealso>
        PutTableBucketMaintenanceConfigurationResponse EndPutTableBucketMaintenanceConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTableBucketPolicy


        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing table bucket policy
        /// for a table bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketPolicy service method.</param>
        /// 
        /// <returns>The response from the PutTableBucketPolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketPolicy">REST API Reference for PutTableBucketPolicy Operation</seealso>
        PutTableBucketPolicyResponse PutTableBucketPolicy(PutTableBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketPolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableBucketPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketPolicy">REST API Reference for PutTableBucketPolicy Operation</seealso>
        IAsyncResult BeginPutTableBucketPolicy(PutTableBucketPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableBucketPolicy.</param>
        /// 
        /// <returns>Returns a  PutTableBucketPolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketPolicy">REST API Reference for PutTableBucketPolicy Operation</seealso>
        PutTableBucketPolicyResponse EndPutTableBucketPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTableMaintenanceConfiguration


        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing maintenance configuration
        /// for a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableMaintenanceConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutTableMaintenanceConfiguration service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableMaintenanceConfiguration">REST API Reference for PutTableMaintenanceConfiguration Operation</seealso>
        PutTableMaintenanceConfigurationResponse PutTableMaintenanceConfiguration(PutTableMaintenanceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableMaintenanceConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableMaintenanceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableMaintenanceConfiguration">REST API Reference for PutTableMaintenanceConfiguration Operation</seealso>
        IAsyncResult BeginPutTableMaintenanceConfiguration(PutTableMaintenanceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableMaintenanceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableMaintenanceConfiguration.</param>
        /// 
        /// <returns>Returns a  PutTableMaintenanceConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableMaintenanceConfiguration">REST API Reference for PutTableMaintenanceConfiguration Operation</seealso>
        PutTableMaintenanceConfigurationResponse EndPutTableMaintenanceConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTablePolicy


        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing table policy for a
        /// table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTablePolicy service method.</param>
        /// 
        /// <returns>The response from the PutTablePolicy service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTablePolicy">REST API Reference for PutTablePolicy Operation</seealso>
        PutTablePolicyResponse PutTablePolicy(PutTablePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTablePolicy operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTablePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTablePolicy">REST API Reference for PutTablePolicy Operation</seealso>
        IAsyncResult BeginPutTablePolicy(PutTablePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTablePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTablePolicy.</param>
        /// 
        /// <returns>Returns a  PutTablePolicyResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTablePolicy">REST API Reference for PutTablePolicy Operation</seealso>
        PutTablePolicyResponse EndPutTablePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RenameTable


        /// <summary>
        /// Renames a table or a namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenameTable service method.</param>
        /// 
        /// <returns>The response from the RenameTable service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/RenameTable">REST API Reference for RenameTable Operation</seealso>
        RenameTableResponse RenameTable(RenameTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RenameTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenameTable operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenameTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/RenameTable">REST API Reference for RenameTable Operation</seealso>
        IAsyncResult BeginRenameTable(RenameTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RenameTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenameTable.</param>
        /// 
        /// <returns>Returns a  RenameTableResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/RenameTable">REST API Reference for RenameTable Operation</seealso>
        RenameTableResponse EndRenameTable(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTableMetadataLocation


        /// <summary>
        /// Updates the metadata location for a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableMetadataLocation service method.</param>
        /// 
        /// <returns>The response from the UpdateTableMetadataLocation service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ConflictException">
        /// The request failed because there is a conflict with a previous write. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.ForbiddenException">
        /// The caller isn't authorized to make the request.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.InternalServerErrorException">
        /// The request failed due to an internal server error.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.NotFoundException">
        /// The request was rejected because the specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.TooManyRequestsException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UpdateTableMetadataLocation">REST API Reference for UpdateTableMetadataLocation Operation</seealso>
        UpdateTableMetadataLocationResponse UpdateTableMetadataLocation(UpdateTableMetadataLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTableMetadataLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableMetadataLocation operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTableMetadataLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UpdateTableMetadataLocation">REST API Reference for UpdateTableMetadataLocation Operation</seealso>
        IAsyncResult BeginUpdateTableMetadataLocation(UpdateTableMetadataLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTableMetadataLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTableMetadataLocation.</param>
        /// 
        /// <returns>Returns a  UpdateTableMetadataLocationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UpdateTableMetadataLocation">REST API Reference for UpdateTableMetadataLocation Operation</seealso>
        UpdateTableMetadataLocationResponse EndUpdateTableMetadataLocation(IAsyncResult asyncResult);

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